using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000521 RID: 1313
	public class EventDispatcher : Object
	{
		// Token: 0x06004D5E RID: 19806 RVA: 0x0016418C File Offset: 0x0016238C
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatcher()
		{
			Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr);
			EventDispatcher.NativeFieldInfoPtr_m_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Listener");
			EventDispatcher.NativeFieldInfoPtr_m_EventEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_EventEnabled");
			EventDispatcher.NativeFieldInfoPtr_m_activityFilteringEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_activityFilteringEnabled");
			EventDispatcher.NativeFieldInfoPtr_m_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Next");
			EventDispatcher.NativeMethodInfoPtr__ctor_Internal_Void_EventDispatcher_Il2CppStructArray_1_Boolean_EventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100674854);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00164220 File Offset: 0x00162420
		[CallerCount(0)]
		public unsafe EventDispatcher(EventDispatcher next, Il2CppStructArray<bool> eventEnabled, EventListener listener)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventEnabled);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr__ctor_Internal_Void_EventDispatcher_Il2CppStructArray_1_Boolean_EventListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x0001CD3B File Offset: 0x0001AF3B
		public EventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004D61 RID: 19809 RVA: 0x00164290 File Offset: 0x00162490
		// (set) Token: 0x06004D62 RID: 19810 RVA: 0x0001CD44 File Offset: 0x0001AF44
		public unsafe EventListener m_Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x001642C0 File Offset: 0x001624C0
		// (set) Token: 0x06004D64 RID: 19812 RVA: 0x0001CD63 File Offset: 0x0001AF63
		public unsafe Il2CppStructArray<bool> m_EventEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_EventEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_EventEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x001642F0 File Offset: 0x001624F0
		// (set) Token: 0x06004D66 RID: 19814 RVA: 0x0001CD82 File Offset: 0x0001AF82
		public unsafe bool m_activityFilteringEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_activityFilteringEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_activityFilteringEnabled)) = value;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06004D67 RID: 19815 RVA: 0x00164318 File Offset: 0x00162518
		// (set) Token: 0x06004D68 RID: 19816 RVA: 0x0001CD9D File Offset: 0x0001AF9D
		public unsafe EventDispatcher m_Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E70 RID: 15984
		private static readonly IntPtr NativeFieldInfoPtr_m_Listener;

		// Token: 0x04003E71 RID: 15985
		private static readonly IntPtr NativeFieldInfoPtr_m_EventEnabled;

		// Token: 0x04003E72 RID: 15986
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilteringEnabled;

		// Token: 0x04003E73 RID: 15987
		private static readonly IntPtr NativeFieldInfoPtr_m_Next;

		// Token: 0x04003E74 RID: 15988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventDispatcher_Il2CppStructArray_1_Boolean_EventListener_0;
	}
}
