using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000155 RID: 341
	public sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x00062B08 File Offset: 0x00060D08
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSocketHandle()
		{
			Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SafeSocketHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr);
			SafeSocketHandle.NativeFieldInfoPtr_blocking_threads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "blocking_threads");
			SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "threads_stacktraces");
			SafeSocketHandle.NativeFieldInfoPtr_in_cleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "in_cleanup");
			SafeSocketHandle.NativeFieldInfoPtr_SOCKET_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "SOCKET_CLOSED");
			SafeSocketHandle.NativeFieldInfoPtr_ABORT_RETRIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "ABORT_RETRIES");
			SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "THROW_ON_ABORT_RETRIES");
			SafeSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666405);
			SafeSocketHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666406);
			SafeSocketHandle.NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666407);
			SafeSocketHandle.NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100666408);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00062C00 File Offset: 0x00060E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388068, RefRangeEnd = 388071, XrefRangeStart = 388058, XrefRangeEnd = 388068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00062C58 File Offset: 0x00060E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388071, XrefRangeEnd = 388138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00062C94 File Offset: 0x00060E94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 388165, RefRangeEnd = 388172, XrefRangeStart = 388138, XrefRangeEnd = 388165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterForBlockingSyscall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00062CC8 File Offset: 0x00060EC8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 388189, RefRangeEnd = 388203, XrefRangeStart = 388172, XrefRangeEnd = 388189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterForBlockingSyscall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0000AC48 File Offset: 0x00008E48
		public SafeSocketHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00062CFC File Offset: 0x00060EFC
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0000AC51 File Offset: 0x00008E51
		public unsafe List<Thread> blocking_threads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_blocking_threads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Thread>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_blocking_threads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00062D2C File Offset: 0x00060F2C
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000AC70 File Offset: 0x00008E70
		public unsafe Dictionary<Thread, StackTrace> threads_stacktraces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Thread, StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00062D5C File Offset: 0x00060F5C
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x0000AC8F File Offset: 0x00008E8F
		public unsafe bool in_cleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_in_cleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_in_cleanup)) = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x00062D84 File Offset: 0x00060F84
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x0000ACAA File Offset: 0x00008EAA
		public unsafe static int SOCKET_CLOSED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeSocketHandle.NativeFieldInfoPtr_SOCKET_CLOSED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSocketHandle.NativeFieldInfoPtr_SOCKET_CLOSED, (void*)(&value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00062DA0 File Offset: 0x00060FA0
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		public unsafe static int ABORT_RETRIES
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeSocketHandle.NativeFieldInfoPtr_ABORT_RETRIES, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSocketHandle.NativeFieldInfoPtr_ABORT_RETRIES, (void*)(&value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00062DBC File Offset: 0x00060FBC
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0000ACC6 File Offset: 0x00008EC6
		public unsafe static bool THROW_ON_ABORT_RETRIES
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&value));
			}
		}

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_blocking_threads;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeFieldInfoPtr_threads_stacktraces;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeFieldInfoPtr_in_cleanup;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_SOCKET_CLOSED;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_ABORT_RETRIES;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0;
	}
}
