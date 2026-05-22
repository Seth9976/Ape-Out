using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028F RID: 655
	public class WaitHandle : MarshalByRefObject
	{
		// Token: 0x06002CD8 RID: 11480 RVA: 0x000E6EAC File Offset: 0x000E50AC
		// Note: this type is marked as 'beforefieldinit'.
		static WaitHandle()
		{
			Il2CppClassPointerStore<WaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr);
			WaitHandle.NativeFieldInfoPtr_WaitTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WaitTimeout");
			WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MAX_WAITHANDLES");
			WaitHandle.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "waitHandle");
			WaitHandle.NativeFieldInfoPtr_safeWaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "safeWaitHandle");
			WaitHandle.NativeFieldInfoPtr_hasThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "hasThreadAffinity");
			WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_OBJECT_0");
			WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_ABANDONED");
			WaitHandle.NativeFieldInfoPtr_WAIT_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_FAILED");
			WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "ERROR_TOO_MANY_POSTS");
			WaitHandle.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "InvalidHandle");
			WaitHandle.NativeFieldInfoPtr_MaxWaitHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MaxWaitHandles");
			WaitHandle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670491);
			WaitHandle.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670492);
			WaitHandle.NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670493);
			WaitHandle.NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670494);
			WaitHandle.NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670495);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670496);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670497);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670498);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670499);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670500);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670501);
			WaitHandle.NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670502);
			WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670503);
			WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670504);
			WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670505);
			WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670506);
			WaitHandle.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670507);
			WaitHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670508);
			WaitHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670509);
			WaitHandle.NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670510);
			WaitHandle.NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670511);
			WaitHandle.NativeMethodInfoPtr_Wait_internal_Private_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670512);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000E7170 File Offset: 0x000E5370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204537, XrefRangeEnd = 204541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000E71AC File Offset: 0x000E53AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A90 RID: 2704
		// (set) Token: 0x06002CDB RID: 11483 RVA: 0x000E71E0 File Offset: 0x000E53E0
		public unsafe virtual IntPtr Handle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204541, XrefRangeEnd = 204550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x000E722C File Offset: 0x000E542C
		public unsafe SafeWaitHandle SafeWaitHandle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 204562, RefRangeEnd = 204569, XrefRangeStart = 204550, XrefRangeEnd = 204562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x000E726C File Offset: 0x000E546C
		[CallerCount(0)]
		public unsafe void SetHandleInternal(SafeWaitHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000E72B0 File Offset: 0x000E54B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204569, XrefRangeEnd = 204578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000E7314 File Offset: 0x000E5514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204578, XrefRangeEnd = 204587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WaitOne(TimeSpan timeout, bool exitContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_TimeSpan_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000E7378 File Offset: 0x000E5578
		[CallerCount(0)]
		public unsafe virtual bool WaitOne()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000E73C0 File Offset: 0x000E55C0
		[CallerCount(0)]
		public unsafe virtual bool WaitOne(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000E7414 File Offset: 0x000E5614
		[CallerCount(0)]
		public unsafe virtual bool WaitOne(TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000E7468 File Offset: 0x000E5668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204595, RefRangeEnd = 204597, XrefRangeStart = 204587, XrefRangeEnd = 204595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitOne(long timeout, bool exitContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000E74C0 File Offset: 0x000E56C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204597, XrefRangeEnd = 204601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitableSafeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasThreadAffinity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000E752C File Offset: 0x000E572C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204615, RefRangeEnd = 204617, XrefRangeStart = 204601, XrefRangeEnd = 204615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000E758C File Offset: 0x000E578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204617, XrefRangeEnd = 204629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, TimeSpan timeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000E75EC File Offset: 0x000E57EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204629, XrefRangeEnd = 204634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbandonedMutexException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000E7614 File Offset: 0x000E5814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204634, XrefRangeEnd = 204639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000E7658 File Offset: 0x000E5858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204639, XrefRangeEnd = 204643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000E7694 File Offset: 0x000E5894
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool explicitDisposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref explicitDisposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x000E76E0 File Offset: 0x000E58E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204643, XrefRangeEnd = 204647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000E7714 File Offset: 0x000E5914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204663, RefRangeEnd = 204664, XrefRangeStart = 204647, XrefRangeEnd = 204663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitMultiple(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref WaitAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000E7780 File Offset: 0x000E5980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204673, RefRangeEnd = 204675, XrefRangeStart = 204664, XrefRangeEnd = 204673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitableSafeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasThreadAffinity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000E77EC File Offset: 0x000E59EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204675, XrefRangeEnd = 204678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = handles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numHandles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Wait_internal_Private_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0000F76A File Offset: 0x0000D96A
		public WaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000E7854 File Offset: 0x000E5A54
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x0000F773 File Offset: 0x0000D973
		public unsafe static int WaitTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WaitTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WaitTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000E7870 File Offset: 0x000E5A70
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x0000F781 File Offset: 0x0000D981
		public unsafe static int MAX_WAITHANDLES
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&value));
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000E788C File Offset: 0x000E5A8C
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x0000F78F File Offset: 0x0000D98F
		public unsafe IntPtr waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_waitHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_waitHandle)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000E78B4 File Offset: 0x000E5AB4
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x0000F7AA File Offset: 0x0000D9AA
		public unsafe SafeWaitHandle safeWaitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_safeWaitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_safeWaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000E78E4 File Offset: 0x000E5AE4
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x0000F7C9 File Offset: 0x0000D9C9
		public unsafe bool hasThreadAffinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_hasThreadAffinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_hasThreadAffinity)) = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000E790C File Offset: 0x000E5B0C
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		public unsafe static int WAIT_OBJECT_0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&value));
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x000E7928 File Offset: 0x000E5B28
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x0000F7F2 File Offset: 0x0000D9F2
		public unsafe static int WAIT_ABANDONED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&value));
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x000E7944 File Offset: 0x000E5B44
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x0000F800 File Offset: 0x0000DA00
		public unsafe static int WAIT_FAILED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_FAILED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_FAILED, (void*)(&value));
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x000E7960 File Offset: 0x000E5B60
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x0000F80E File Offset: 0x0000DA0E
		public unsafe static int ERROR_TOO_MANY_POSTS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&value));
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000E797C File Offset: 0x000E5B7C
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x0000F81C File Offset: 0x0000DA1C
		public unsafe static IntPtr InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000E7998 File Offset: 0x000E5B98
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x0000F82A File Offset: 0x0000DA2A
		public unsafe static int MaxWaitHandles
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_MaxWaitHandles, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_MaxWaitHandles, (void*)(&value));
			}
		}

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeFieldInfoPtr_WaitTimeout;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeFieldInfoPtr_MAX_WAITHANDLES;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeFieldInfoPtr_safeWaitHandle;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeFieldInfoPtr_hasThreadAffinity;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_OBJECT_0;

		// Token: 0x0400270C RID: 9996
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_ABANDONED;

		// Token: 0x0400270D RID: 9997
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_FAILED;

		// Token: 0x0400270E RID: 9998
		private static readonly IntPtr NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS;

		// Token: 0x0400270F RID: 9999
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x04002710 RID: 10000
		private static readonly IntPtr NativeFieldInfoPtr_MaxWaitHandles;

		// Token: 0x04002711 RID: 10001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002712 RID: 10002
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04002713 RID: 10003
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0;

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0;

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_TimeSpan_Boolean_0;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_TimeSpan_0;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0;

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeMethodInfoPtr_Wait_internal_Private_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0;
	}
}
