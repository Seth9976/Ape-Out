using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000292 RID: 658
	public class LockQueue : Object
	{
		// Token: 0x06002D23 RID: 11555 RVA: 0x000E851C File Offset: 0x000E671C
		// Note: this type is marked as 'beforefieldinit'.
		static LockQueue()
		{
			Il2CppClassPointerStore<LockQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockQueue>.NativeClassPtr);
			LockQueue.NativeFieldInfoPtr_rwlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, "rwlock");
			LockQueue.NativeFieldInfoPtr_lockCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, "lockCount");
			LockQueue.NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100670539);
			LockQueue.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100670540);
			LockQueue.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100670541);
			LockQueue.NativeMethodInfoPtr_Pulse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100670542);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000E85C4 File Offset: 0x000E67C4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockQueue(ReaderWriterLock rwlock)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockQueue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rwlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000E8610 File Offset: 0x000E6810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204691, RefRangeEnd = 204692, XrefRangeStart = 204683, XrefRangeEnd = 204691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x000E865C File Offset: 0x000E685C
		public unsafe bool IsEmpty
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 204695, RefRangeEnd = 204698, XrefRangeStart = 204692, XrefRangeEnd = 204695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000E8698 File Offset: 0x000E6898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204702, RefRangeEnd = 204704, XrefRangeStart = 204698, XrefRangeEnd = 204702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pulse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr_Pulse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0000F84A File Offset: 0x0000DA4A
		public LockQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000E86CC File Offset: 0x000E68CC
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x0000F853 File Offset: 0x0000DA53
		public unsafe ReaderWriterLock rwlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_rwlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReaderWriterLock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_rwlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000E86FC File Offset: 0x000E68FC
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x0000F872 File Offset: 0x0000DA72
		public unsafe int lockCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_lockCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_lockCount)) = value;
			}
		}

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeFieldInfoPtr_rwlock;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeFieldInfoPtr_lockCount;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_Pulse_Public_Void_0;
	}
}
