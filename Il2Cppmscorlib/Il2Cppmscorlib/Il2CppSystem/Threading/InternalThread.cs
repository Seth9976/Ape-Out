using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000298 RID: 664
	public sealed class InternalThread : CriticalFinalizerObject
	{
		// Token: 0x06002D65 RID: 11621 RVA: 0x000E91AC File Offset: 0x000E73AC
		// Note: this type is marked as 'beforefieldinit'.
		static InternalThread()
		{
			Il2CppClassPointerStore<InternalThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "InternalThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalThread>.NativeClassPtr);
			InternalThread.NativeFieldInfoPtr_lock_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "lock_thread_id");
			InternalThread.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "handle");
			InternalThread.NativeFieldInfoPtr_native_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "native_handle");
			InternalThread.NativeFieldInfoPtr_unused3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused3");
			InternalThread.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name");
			InternalThread.NativeFieldInfoPtr_name_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_len");
			InternalThread.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "state");
			InternalThread.NativeFieldInfoPtr_abort_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_exc");
			InternalThread.NativeFieldInfoPtr_abort_state_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_state_handle");
			InternalThread.NativeFieldInfoPtr_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_id");
			InternalThread.NativeFieldInfoPtr_debugger_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "debugger_thread");
			InternalThread.NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "static_data");
			InternalThread.NativeFieldInfoPtr_runtime_thread_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "runtime_thread_info");
			InternalThread.NativeFieldInfoPtr_current_appcontext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "current_appcontext");
			InternalThread.NativeFieldInfoPtr_root_domain_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "root_domain_thread");
			InternalThread.NativeFieldInfoPtr__serialized_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal");
			InternalThread.NativeFieldInfoPtr__serialized_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal_version");
			InternalThread.NativeFieldInfoPtr_appdomain_refs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "appdomain_refs");
			InternalThread.NativeFieldInfoPtr_interruption_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "interruption_requested");
			InternalThread.NativeFieldInfoPtr_synch_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "synch_cs");
			InternalThread.NativeFieldInfoPtr_threadpool_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "threadpool_thread");
			InternalThread.NativeFieldInfoPtr_thread_interrupt_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_interrupt_requested");
			InternalThread.NativeFieldInfoPtr_stack_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "stack_size");
			InternalThread.NativeFieldInfoPtr_apartment_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "apartment_state");
			InternalThread.NativeFieldInfoPtr_critical_region_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "critical_region_level");
			InternalThread.NativeFieldInfoPtr_managed_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "managed_id");
			InternalThread.NativeFieldInfoPtr_small_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "small_id");
			InternalThread.NativeFieldInfoPtr_manage_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "manage_callback");
			InternalThread.NativeFieldInfoPtr_unused4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused4");
			InternalThread.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "flags");
			InternalThread.NativeFieldInfoPtr_thread_pinning_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_pinning_ref");
			InternalThread.NativeFieldInfoPtr_abort_protected_block_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_protected_block_count");
			InternalThread.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "priority");
			InternalThread.NativeFieldInfoPtr_owned_mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "owned_mutex");
			InternalThread.NativeFieldInfoPtr_suspended_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "suspended_event");
			InternalThread.NativeFieldInfoPtr_self_suspended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "self_suspended");
			InternalThread.NativeFieldInfoPtr_unused1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused1");
			InternalThread.NativeFieldInfoPtr_unused2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused2");
			InternalThread.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "last");
			InternalThread.NativeMethodInfoPtr_Thread_free_internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100670559);
			InternalThread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100670560);
			InternalThread.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100670561);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000E9524 File Offset: 0x000E7724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204819, XrefRangeEnd = 204821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Thread_free_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr_Thread_free_internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000E9558 File Offset: 0x000E7758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204821, XrefRangeEnd = 204826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000E958C File Offset: 0x000E778C
		[CallerCount(0)]
		public unsafe InternalThread()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalThread>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x0000FA99 File Offset: 0x0000DC99
		public InternalThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000E95C8 File Offset: 0x000E77C8
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x0000FAA2 File Offset: 0x0000DCA2
		public unsafe int lock_thread_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_lock_thread_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_lock_thread_id)) = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000E95F0 File Offset: 0x000E77F0
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x0000FABD File Offset: 0x0000DCBD
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000E9618 File Offset: 0x000E7818
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		public unsafe IntPtr native_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_native_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_native_handle)) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000E9640 File Offset: 0x000E7840
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x0000FAF3 File Offset: 0x0000DCF3
		public unsafe IntPtr unused3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused3)) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000E9668 File Offset: 0x000E7868
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x0000FB0E File Offset: 0x0000DD0E
		public unsafe IntPtr name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name)) = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x000E9690 File Offset: 0x000E7890
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x0000FB29 File Offset: 0x0000DD29
		public unsafe int name_len
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_len);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_len)) = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x000E96B8 File Offset: 0x000E78B8
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x0000FB44 File Offset: 0x0000DD44
		public unsafe ThreadState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000E96E0 File Offset: 0x000E78E0
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x0000FB5F File Offset: 0x0000DD5F
		public unsafe Object abort_exc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_exc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_exc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x000E9710 File Offset: 0x000E7910
		// (set) Token: 0x06002D7B RID: 11643 RVA: 0x0000FB7E File Offset: 0x0000DD7E
		public unsafe int abort_state_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_state_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_state_handle)) = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x000E9738 File Offset: 0x000E7938
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x0000FB99 File Offset: 0x0000DD99
		public unsafe long thread_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_id)) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000E9760 File Offset: 0x000E7960
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		public unsafe IntPtr debugger_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_debugger_thread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_debugger_thread)) = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x000E9788 File Offset: 0x000E7988
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x0000FBCF File Offset: 0x0000DDCF
		public unsafe UIntPtr static_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_static_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_static_data)) = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x000E97B0 File Offset: 0x000E79B0
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x0000FBEA File Offset: 0x0000DDEA
		public unsafe IntPtr runtime_thread_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_runtime_thread_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_runtime_thread_info)) = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000E97D8 File Offset: 0x000E79D8
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x0000FC05 File Offset: 0x0000DE05
		public unsafe Object current_appcontext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_current_appcontext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_current_appcontext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000E9808 File Offset: 0x000E7A08
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x0000FC24 File Offset: 0x0000DE24
		public unsafe Object root_domain_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_root_domain_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_root_domain_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x000E9838 File Offset: 0x000E7A38
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x0000FC43 File Offset: 0x0000DE43
		public unsafe Il2CppStructArray<byte> _serialized_principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000E9868 File Offset: 0x000E7A68
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x0000FC62 File Offset: 0x0000DE62
		public unsafe int _serialized_principal_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal_version)) = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000E9890 File Offset: 0x000E7A90
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x0000FC7D File Offset: 0x0000DE7D
		public unsafe IntPtr appdomain_refs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_appdomain_refs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_appdomain_refs)) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000E98B8 File Offset: 0x000E7AB8
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x0000FC98 File Offset: 0x0000DE98
		public unsafe int interruption_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_interruption_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_interruption_requested)) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000E98E0 File Offset: 0x000E7AE0
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x0000FCB3 File Offset: 0x0000DEB3
		public unsafe IntPtr synch_cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_synch_cs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_synch_cs)) = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000E9908 File Offset: 0x000E7B08
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x0000FCCE File Offset: 0x0000DECE
		public unsafe bool threadpool_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_threadpool_thread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_threadpool_thread)) = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000E9930 File Offset: 0x000E7B30
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
		public unsafe bool thread_interrupt_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_interrupt_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_interrupt_requested)) = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x000E9958 File Offset: 0x000E7B58
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public unsafe int stack_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_stack_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_stack_size)) = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000E9980 File Offset: 0x000E7B80
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x0000FD1F File Offset: 0x0000DF1F
		public unsafe byte apartment_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_apartment_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_apartment_state)) = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000E99A8 File Offset: 0x000E7BA8
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x0000FD3A File Offset: 0x0000DF3A
		public unsafe int critical_region_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_critical_region_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_critical_region_level)) = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000E99D0 File Offset: 0x000E7BD0
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x0000FD55 File Offset: 0x0000DF55
		public unsafe int managed_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_managed_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_managed_id)) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000E99F8 File Offset: 0x000E7BF8
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x0000FD70 File Offset: 0x0000DF70
		public unsafe int small_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_small_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_small_id)) = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000E9A20 File Offset: 0x000E7C20
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x0000FD8B File Offset: 0x0000DF8B
		public unsafe IntPtr manage_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_manage_callback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_manage_callback)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x000E9A48 File Offset: 0x000E7C48
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x0000FDA6 File Offset: 0x0000DFA6
		public unsafe IntPtr unused4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused4)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x000E9A70 File Offset: 0x000E7C70
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x0000FDC1 File Offset: 0x0000DFC1
		public unsafe IntPtr flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000E9A98 File Offset: 0x000E7C98
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		public unsafe IntPtr thread_pinning_ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_pinning_ref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_pinning_ref)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000E9AC0 File Offset: 0x000E7CC0
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x0000FDF7 File Offset: 0x0000DFF7
		public unsafe IntPtr abort_protected_block_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_protected_block_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_protected_block_count)) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000E9AE8 File Offset: 0x000E7CE8
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x0000FE12 File Offset: 0x0000E012
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000E9B10 File Offset: 0x000E7D10
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x0000FE2D File Offset: 0x0000E02D
		public unsafe IntPtr owned_mutex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_owned_mutex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_owned_mutex)) = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x000E9B38 File Offset: 0x000E7D38
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x0000FE48 File Offset: 0x0000E048
		public unsafe IntPtr suspended_event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_suspended_event);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_suspended_event)) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x000E9B60 File Offset: 0x000E7D60
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x0000FE63 File Offset: 0x0000E063
		public unsafe int self_suspended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_self_suspended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_self_suspended)) = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x000E9B88 File Offset: 0x000E7D88
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x0000FE7E File Offset: 0x0000E07E
		public unsafe IntPtr unused1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused1)) = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000E9BB0 File Offset: 0x000E7DB0
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x0000FE99 File Offset: 0x0000E099
		public unsafe IntPtr unused2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused2)) = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000E9BD8 File Offset: 0x000E7DD8
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		public unsafe IntPtr last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_last)) = value;
			}
		}

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeFieldInfoPtr_lock_thread_id;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeFieldInfoPtr_native_handle;

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeFieldInfoPtr_unused3;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeFieldInfoPtr_name_len;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeFieldInfoPtr_abort_exc;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeFieldInfoPtr_abort_state_handle;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeFieldInfoPtr_thread_id;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeFieldInfoPtr_debugger_thread;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeFieldInfoPtr_static_data;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeFieldInfoPtr_runtime_thread_info;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeFieldInfoPtr_current_appcontext;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeFieldInfoPtr_root_domain_thread;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeFieldInfoPtr__serialized_principal;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeFieldInfoPtr__serialized_principal_version;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeFieldInfoPtr_appdomain_refs;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeFieldInfoPtr_interruption_requested;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeFieldInfoPtr_synch_cs;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeFieldInfoPtr_threadpool_thread;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeFieldInfoPtr_thread_interrupt_requested;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeFieldInfoPtr_stack_size;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeFieldInfoPtr_apartment_state;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeFieldInfoPtr_critical_region_level;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeFieldInfoPtr_managed_id;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeFieldInfoPtr_small_id;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeFieldInfoPtr_manage_callback;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeFieldInfoPtr_unused4;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeFieldInfoPtr_thread_pinning_ref;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeFieldInfoPtr_abort_protected_block_count;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeFieldInfoPtr_owned_mutex;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeFieldInfoPtr_suspended_event;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeFieldInfoPtr_self_suspended;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeFieldInfoPtr_unused1;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeFieldInfoPtr_unused2;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_Thread_free_internal_Private_Void_0;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
