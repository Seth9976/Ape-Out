using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000296 RID: 662
	public sealed class ReaderWriterLock : CriticalFinalizerObject
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x000E8A08 File Offset: 0x000E6C08
		// Note: this type is marked as 'beforefieldinit'.
		static ReaderWriterLock()
		{
			Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ReaderWriterLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr);
			ReaderWriterLock.NativeFieldInfoPtr_seq_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "seq_num");
			ReaderWriterLock.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "state");
			ReaderWriterLock.NativeFieldInfoPtr_readers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "readers");
			ReaderWriterLock.NativeFieldInfoPtr_writer_lock_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "writer_lock_owner");
			ReaderWriterLock.NativeFieldInfoPtr_writer_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "writer_queue");
			ReaderWriterLock.NativeFieldInfoPtr_reader_locks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "reader_locks");
			ReaderWriterLock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670549);
			ReaderWriterLock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670550);
			ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670551);
			ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670552);
			ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670553);
			ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670554);
			ReaderWriterLock.NativeMethodInfoPtr_HasWriterLock_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100670555);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000E8B3C File Offset: 0x000E6D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204742, RefRangeEnd = 204743, XrefRangeStart = 204731, XrefRangeEnd = 204742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderWriterLock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000E8B78 File Offset: 0x000E6D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x000E8BAC File Offset: 0x000E6DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204743, XrefRangeEnd = 204744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireWriterLock(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000E8BEC File Offset: 0x000E6DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204752, RefRangeEnd = 204754, XrefRangeStart = 204744, XrefRangeEnd = 204752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireWriterLock(int millisecondsTimeout, int initialLockCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialLockCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x000E8C38 File Offset: 0x000E6E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204762, RefRangeEnd = 204763, XrefRangeStart = 204754, XrefRangeEnd = 204762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseWriterLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000E8C6C File Offset: 0x000E6E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204763, XrefRangeEnd = 204766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseWriterLock(int releaseCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref releaseCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000E8CAC File Offset: 0x000E6EAC
		[CallerCount(0)]
		public unsafe bool HasWriterLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_HasWriterLock_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x0000F8D6 File Offset: 0x0000DAD6
		public ReaderWriterLock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000E8CE8 File Offset: 0x000E6EE8
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x0000F8DF File Offset: 0x0000DADF
		public unsafe int seq_num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_seq_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_seq_num)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x000E8D10 File Offset: 0x000E6F10
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x0000F8FA File Offset: 0x0000DAFA
		public unsafe int state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000E8D38 File Offset: 0x000E6F38
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x0000F915 File Offset: 0x0000DB15
		public unsafe int readers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_readers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_readers)) = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000E8D60 File Offset: 0x000E6F60
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x0000F930 File Offset: 0x0000DB30
		public unsafe int writer_lock_owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_lock_owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_lock_owner)) = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000E8D88 File Offset: 0x000E6F88
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x0000F94B File Offset: 0x0000DB4B
		public unsafe LockQueue writer_queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LockQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000E8DB8 File Offset: 0x000E6FB8
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x0000F96A File Offset: 0x0000DB6A
		public unsafe Hashtable reader_locks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_reader_locks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_reader_locks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeFieldInfoPtr_seq_num;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeFieldInfoPtr_readers;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeFieldInfoPtr_writer_lock_owner;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeFieldInfoPtr_writer_queue;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeFieldInfoPtr_reader_locks;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeMethodInfoPtr_AcquireWriterLock_Public_Void_Int32_0;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeMethodInfoPtr_AcquireWriterLock_Private_Void_Int32_Int32_0;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseWriterLock_Public_Void_0;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseWriterLock_Private_Void_Int32_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr_HasWriterLock_Private_Boolean_0;
	}
}
