using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001D RID: 29
	public class AsyncProtocolRequest : Object
	{
		// Token: 0x0600013C RID: 316 RVA: 0x000150F8 File Offset: 0x000132F8
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncProtocolRequest()
		{
			Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncProtocolRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr);
			AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<Parent>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<RunSynchronously>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<UserResult>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "Started");
			AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "RequestedSize");
			AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "WriteRequested");
			AsyncProtocolRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "locker");
			AsyncProtocolRequest.NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663608);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663609);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663610);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663611);
			AsyncProtocolRequest.NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663612);
			AsyncProtocolRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663613);
			AsyncProtocolRequest.NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663614);
			AsyncProtocolRequest.NativeMethodInfoPtr_RequestWrite_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663615);
			AsyncProtocolRequest.NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663616);
			AsyncProtocolRequest.NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663617);
			AsyncProtocolRequest.NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663618);
			AsyncProtocolRequest.NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663619);
			AsyncProtocolRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663620);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000152B8 File Offset: 0x000134B8
		public unsafe MobileAuthenticatedStream Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000152F8 File Offset: 0x000134F8
		public unsafe bool RunSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00015334 File Offset: 0x00013534
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365817, XrefRangeEnd = 365819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0001536C File Offset: 0x0001356C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000153A8 File Offset: 0x000135A8
		public unsafe int UserResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000153E8 File Offset: 0x000135E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365822, RefRangeEnd = 365825, XrefRangeStart = 365819, XrefRangeEnd = 365822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00015444 File Offset: 0x00013644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365828, RefRangeEnd = 365830, XrefRangeStart = 365825, XrefRangeEnd = 365828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRead(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00015484 File Offset: 0x00013684
		[CallerCount(0)]
		public unsafe void RequestWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_RequestWrite_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000154B8 File Offset: 0x000136B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365840, RefRangeEnd = 365842, XrefRangeStart = 365830, XrefRangeEnd = 365840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncProtocolResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00015510 File Offset: 0x00013710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365851, RefRangeEnd = 365852, XrefRangeStart = 365842, XrefRangeEnd = 365851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessOperation(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00015568 File Offset: 0x00013768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365862, RefRangeEnd = 365863, XrefRangeStart = 365852, XrefRangeEnd = 365862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<int>> InnerRead(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000155C0 File Offset: 0x000137C0
		[CallerCount(0)]
		public unsafe virtual AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncProtocolRequest.NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00015614 File Offset: 0x00013814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365863, XrefRangeEnd = 365868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncProtocolRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000026D8 File Offset: 0x000008D8
		public AsyncProtocolRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00015658 File Offset: 0x00013858
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000026E1 File Offset: 0x000008E1
		public unsafe MobileAuthenticatedStream _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00015688 File Offset: 0x00013888
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002700 File Offset: 0x00000900
		public unsafe bool _RunSynchronously_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000156B0 File Offset: 0x000138B0
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000271B File Offset: 0x0000091B
		public unsafe int _UserResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000156D8 File Offset: 0x000138D8
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002736 File Offset: 0x00000936
		public unsafe int Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_Started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_Started)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00015700 File Offset: 0x00013900
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002751 File Offset: 0x00000951
		public unsafe int RequestedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00015728 File Offset: 0x00013928
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000276C File Offset: 0x0000096C
		public unsafe int WriteRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00015750 File Offset: 0x00013950
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002787 File Offset: 0x00000987
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr__RunSynchronously_k__BackingField;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__UserResult_k__BackingField;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_Started;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_RequestedSize;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_WriteRequested;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_RequestWrite_Internal_Void_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020001A3 RID: 419
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<StartOperation>d__23")]
		public sealed class _StartOperation_d__23 : ValueType
		{
			// Token: 0x06001820 RID: 6176 RVA: 0x00069D7C File Offset: 0x00067F7C
			// Note: this type is marked as 'beforefieldinit'.
			static _StartOperation_d__23()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<StartOperation>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr);
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, 100663621);
				AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, 100663622);
			}

			// Token: 0x06001821 RID: 6177 RVA: 0x00069E34 File Offset: 0x00068034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365699, XrefRangeEnd = 365726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001822 RID: 6178 RVA: 0x00069E6C File Offset: 0x0006806C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365726, XrefRangeEnd = 365741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001823 RID: 6179 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
			public _StartOperation_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001824 RID: 6180 RVA: 0x0000C2CC File Offset: 0x0000A4CC
			public _StartOperation_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06001825 RID: 6181 RVA: 0x00069EB4 File Offset: 0x000680B4
			// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000C2DE File Offset: 0x0000A4DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06001827 RID: 6183 RVA: 0x00069EDC File Offset: 0x000680DC
			// (set) Token: 0x06001828 RID: 6184 RVA: 0x0000C2F9 File Offset: 0x0000A4F9
			public AsyncTaskMethodBuilder<AsyncProtocolResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AsyncProtocolResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncProtocolResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncProtocolResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06001829 RID: 6185 RVA: 0x00069F0C File Offset: 0x0006810C
			// (set) Token: 0x0600182A RID: 6186 RVA: 0x0000C327 File Offset: 0x0000A527
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x0600182B RID: 6187 RVA: 0x00069F3C File Offset: 0x0006813C
			// (set) Token: 0x0600182C RID: 6188 RVA: 0x0000C346 File Offset: 0x0000A546
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x0600182D RID: 6189 RVA: 0x00069F6C File Offset: 0x0006816C
			// (set) Token: 0x0600182E RID: 6190 RVA: 0x0000C374 File Offset: 0x0000A574
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001317 RID: 4887
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001318 RID: 4888
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001319 RID: 4889
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400131A RID: 4890
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400131B RID: 4891
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400131C RID: 4892
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400131D RID: 4893
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001A4 RID: 420
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24")]
		public sealed class _ProcessOperation_d__24 : ValueType
		{
			// Token: 0x0600182F RID: 6191 RVA: 0x00069F9C File Offset: 0x0006819C
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessOperation_d__24()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<ProcessOperation>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr);
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<status>5__1");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<newStatus>5__2");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>u__2");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, 100663623);
				AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, 100663624);
			}

			// Token: 0x06001830 RID: 6192 RVA: 0x0006A090 File Offset: 0x00068290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365741, XrefRangeEnd = 365775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001831 RID: 6193 RVA: 0x0006A0C8 File Offset: 0x000682C8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001832 RID: 6194 RVA: 0x0000C3A2 File Offset: 0x0000A5A2
			public _ProcessOperation_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001833 RID: 6195 RVA: 0x0000C3AB File Offset: 0x0000A5AB
			public _ProcessOperation_d__24()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr))
			{
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06001834 RID: 6196 RVA: 0x0006A110 File Offset: 0x00068310
			// (set) Token: 0x06001835 RID: 6197 RVA: 0x0000C3BD File Offset: 0x0000A5BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x06001836 RID: 6198 RVA: 0x0006A138 File Offset: 0x00068338
			// (set) Token: 0x06001837 RID: 6199 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x06001838 RID: 6200 RVA: 0x0006A168 File Offset: 0x00068368
			// (set) Token: 0x06001839 RID: 6201 RVA: 0x0000C406 File Offset: 0x0000A606
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x0600183A RID: 6202 RVA: 0x0006A198 File Offset: 0x00068398
			// (set) Token: 0x0600183B RID: 6203 RVA: 0x0000C434 File Offset: 0x0000A634
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x0600183C RID: 6204 RVA: 0x0006A1C8 File Offset: 0x000683C8
			// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000C453 File Offset: 0x0000A653
			public unsafe AsyncOperationStatus _status_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__1)) = value;
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x0600183E RID: 6206 RVA: 0x0006A1F0 File Offset: 0x000683F0
			// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000C46E File Offset: 0x0000A66E
			public unsafe AsyncOperationStatus _newStatus_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__2)) = value;
				}
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06001840 RID: 6208 RVA: 0x0006A218 File Offset: 0x00068418
			// (set) Token: 0x06001841 RID: 6209 RVA: 0x0000C489 File Offset: 0x0000A689
			public ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06001842 RID: 6210 RVA: 0x0006A248 File Offset: 0x00068448
			// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000C4B7 File Offset: 0x0000A6B7
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400131E RID: 4894
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400131F RID: 4895
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001320 RID: 4896
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001321 RID: 4897
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001322 RID: 4898
			private static readonly IntPtr NativeFieldInfoPtr__status_5__1;

			// Token: 0x04001323 RID: 4899
			private static readonly IntPtr NativeFieldInfoPtr__newStatus_5__2;

			// Token: 0x04001324 RID: 4900
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001325 RID: 4901
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001326 RID: 4902
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001327 RID: 4903
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001A5 RID: 421
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<InnerRead>d__25")]
		public sealed class _InnerRead_d__25 : ValueType
		{
			// Token: 0x06001844 RID: 6212 RVA: 0x0006A278 File Offset: 0x00068478
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerRead_d__25()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<InnerRead>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr);
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<requestedSize>5__1");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<totalRead>5__2");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, 100663625);
				AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, 100663626);
			}

			// Token: 0x06001845 RID: 6213 RVA: 0x0006A358 File Offset: 0x00068558
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 365801, RefRangeEnd = 365802, XrefRangeStart = 365775, XrefRangeEnd = 365801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001846 RID: 6214 RVA: 0x0006A390 File Offset: 0x00068590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365802, XrefRangeEnd = 365817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001847 RID: 6215 RVA: 0x0000C4E5 File Offset: 0x0000A6E5
			public _InnerRead_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001848 RID: 6216 RVA: 0x0000C4EE File Offset: 0x0000A6EE
			public _InnerRead_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06001849 RID: 6217 RVA: 0x0006A3D8 File Offset: 0x000685D8
			// (set) Token: 0x0600184A RID: 6218 RVA: 0x0000C500 File Offset: 0x0000A700
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x0600184B RID: 6219 RVA: 0x0006A400 File Offset: 0x00068600
			// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000C51B File Offset: 0x0000A71B
			public AsyncTaskMethodBuilder<Nullable<int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x0600184D RID: 6221 RVA: 0x0006A430 File Offset: 0x00068630
			// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000C549 File Offset: 0x0000A749
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x0600184F RID: 6223 RVA: 0x0006A460 File Offset: 0x00068660
			// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000C568 File Offset: 0x0000A768
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06001851 RID: 6225 RVA: 0x0006A490 File Offset: 0x00068690
			// (set) Token: 0x06001852 RID: 6226 RVA: 0x0000C596 File Offset: 0x0000A796
			public unsafe int _requestedSize_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__1)) = value;
				}
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06001853 RID: 6227 RVA: 0x0006A4B8 File Offset: 0x000686B8
			// (set) Token: 0x06001854 RID: 6228 RVA: 0x0000C5B1 File Offset: 0x0000A7B1
			public Nullable<int> _totalRead_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06001855 RID: 6229 RVA: 0x0006A4E8 File Offset: 0x000686E8
			// (set) Token: 0x06001856 RID: 6230 RVA: 0x0000C5DF File Offset: 0x0000A7DF
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001328 RID: 4904
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001329 RID: 4905
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400132A RID: 4906
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400132B RID: 4907
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400132C RID: 4908
			private static readonly IntPtr NativeFieldInfoPtr__requestedSize_5__1;

			// Token: 0x0400132D RID: 4909
			private static readonly IntPtr NativeFieldInfoPtr__totalRead_5__2;

			// Token: 0x0400132E RID: 4910
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400132F RID: 4911
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001330 RID: 4912
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
