using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000516 RID: 1302
	public class EventListener : Object
	{
		// Token: 0x06004C9A RID: 19610 RVA: 0x00161A50 File Offset: 0x0015FC50
		// Note: this type is marked as 'beforefieldinit'.
		static EventListener()
		{
			Il2CppClassPointerStore<EventListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventListener>.NativeClassPtr);
			EventListener.NativeFieldInfoPtr_s_EventSourceCreatedLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_EventSourceCreatedLock");
			EventListener.NativeFieldInfoPtr__EventSourceCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "_EventSourceCreated");
			EventListener.NativeFieldInfoPtr_EventWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "EventWritten");
			EventListener.NativeFieldInfoPtr_m_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "m_Next");
			EventListener.NativeFieldInfoPtr_m_activityFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "m_activityFilter");
			EventListener.NativeFieldInfoPtr_s_Listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_Listeners");
			EventListener.NativeFieldInfoPtr_s_EventSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_EventSources");
			EventListener.NativeFieldInfoPtr_s_CreatingListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_CreatingListener");
			EventListener.NativeFieldInfoPtr_s_EventSourceShutdownRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_EventSourceShutdownRegistered");
			EventListener.NativeMethodInfoPtr_OnEventSourceCreated_FamOrAssem_Virtual_New_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674765);
			EventListener.NativeMethodInfoPtr_OnEventWritten_FamOrAssem_Virtual_New_Void_EventWrittenEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674766);
			EventListener.NativeMethodInfoPtr_AddEventSource_Internal_Static_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674767);
			EventListener.NativeMethodInfoPtr_DisposeOnShutdown_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674768);
			EventListener.NativeMethodInfoPtr_get_EventListenersLock_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674769);
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x00161B98 File Offset: 0x0015FD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241204, XrefRangeEnd = 241213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEventSourceCreated(EventSource eventSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventListener.NativeMethodInfoPtr_OnEventSourceCreated_FamOrAssem_Virtual_New_Void_EventSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x00161BE8 File Offset: 0x0015FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241213, XrefRangeEnd = 241216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEventWritten(EventWrittenEventArgs eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventListener.NativeMethodInfoPtr_OnEventWritten_FamOrAssem_Virtual_New_Void_EventWrittenEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00161C38 File Offset: 0x0015FE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241287, RefRangeEnd = 241288, XrefRangeStart = 241216, XrefRangeEnd = 241287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddEventSource(EventSource newEventSource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEventSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListener.NativeMethodInfoPtr_AddEventSource_Internal_Static_Void_EventSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00161C70 File Offset: 0x0015FE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241288, XrefRangeEnd = 241310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeOnShutdown(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListener.NativeMethodInfoPtr_DisposeOnShutdown_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x00161CB8 File Offset: 0x0015FEB8
		public unsafe static Object EventListenersLock
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 241327, RefRangeEnd = 241333, XrefRangeStart = 241310, XrefRangeEnd = 241327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListener.NativeMethodInfoPtr_get_EventListenersLock_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x0001C6E6 File Offset: 0x0001A8E6
		public EventListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x00161CEC File Offset: 0x0015FEEC
		// (set) Token: 0x06004CA2 RID: 19618 RVA: 0x0001C6EF File Offset: 0x0001A8EF
		public unsafe static Object s_EventSourceCreatedLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_EventSourceCreatedLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_EventSourceCreatedLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x00161D14 File Offset: 0x0015FF14
		// (set) Token: 0x06004CA4 RID: 19620 RVA: 0x0001C701 File Offset: 0x0001A901
		public unsafe EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr__EventSourceCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<EventSourceCreatedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr__EventSourceCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x00161D44 File Offset: 0x0015FF44
		// (set) Token: 0x06004CA6 RID: 19622 RVA: 0x0001C720 File Offset: 0x0001A920
		public unsafe EventHandler<EventWrittenEventArgs> EventWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_EventWritten);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<EventWrittenEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_EventWritten), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06004CA7 RID: 19623 RVA: 0x00161D74 File Offset: 0x0015FF74
		// (set) Token: 0x06004CA8 RID: 19624 RVA: 0x0001C73F File Offset: 0x0001A93F
		public unsafe EventListener m_Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x00161DA4 File Offset: 0x0015FFA4
		// (set) Token: 0x06004CAA RID: 19626 RVA: 0x0001C75E File Offset: 0x0001A95E
		public unsafe ActivityFilter m_activityFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_activityFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_activityFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x00161DD4 File Offset: 0x0015FFD4
		// (set) Token: 0x06004CAC RID: 19628 RVA: 0x0001C77D File Offset: 0x0001A97D
		public unsafe static EventListener s_Listeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_Listeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_Listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x00161DFC File Offset: 0x0015FFFC
		// (set) Token: 0x06004CAE RID: 19630 RVA: 0x0001C78F File Offset: 0x0001A98F
		public unsafe static List<WeakReference> s_EventSources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_EventSources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_EventSources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06004CAF RID: 19631 RVA: 0x00161E24 File Offset: 0x00160024
		// (set) Token: 0x06004CB0 RID: 19632 RVA: 0x0001C7A1 File Offset: 0x0001A9A1
		public unsafe static bool s_CreatingListener
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_CreatingListener, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_CreatingListener, (void*)(&value));
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x00161E40 File Offset: 0x00160040
		// (set) Token: 0x06004CB2 RID: 19634 RVA: 0x0001C7AF File Offset: 0x0001A9AF
		public unsafe static bool s_EventSourceShutdownRegistered
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_EventSourceShutdownRegistered, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_EventSourceShutdownRegistered, (void*)(&value));
			}
		}

		// Token: 0x04003DEE RID: 15854
		private static readonly IntPtr NativeFieldInfoPtr_s_EventSourceCreatedLock;

		// Token: 0x04003DEF RID: 15855
		private static readonly IntPtr NativeFieldInfoPtr__EventSourceCreated;

		// Token: 0x04003DF0 RID: 15856
		private static readonly IntPtr NativeFieldInfoPtr_EventWritten;

		// Token: 0x04003DF1 RID: 15857
		private static readonly IntPtr NativeFieldInfoPtr_m_Next;

		// Token: 0x04003DF2 RID: 15858
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilter;

		// Token: 0x04003DF3 RID: 15859
		private static readonly IntPtr NativeFieldInfoPtr_s_Listeners;

		// Token: 0x04003DF4 RID: 15860
		private static readonly IntPtr NativeFieldInfoPtr_s_EventSources;

		// Token: 0x04003DF5 RID: 15861
		private static readonly IntPtr NativeFieldInfoPtr_s_CreatingListener;

		// Token: 0x04003DF6 RID: 15862
		private static readonly IntPtr NativeFieldInfoPtr_s_EventSourceShutdownRegistered;

		// Token: 0x04003DF7 RID: 15863
		private static readonly IntPtr NativeMethodInfoPtr_OnEventSourceCreated_FamOrAssem_Virtual_New_Void_EventSource_0;

		// Token: 0x04003DF8 RID: 15864
		private static readonly IntPtr NativeMethodInfoPtr_OnEventWritten_FamOrAssem_Virtual_New_Void_EventWrittenEventArgs_0;

		// Token: 0x04003DF9 RID: 15865
		private static readonly IntPtr NativeMethodInfoPtr_AddEventSource_Internal_Static_Void_EventSource_0;

		// Token: 0x04003DFA RID: 15866
		private static readonly IntPtr NativeMethodInfoPtr_DisposeOnShutdown_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x04003DFB RID: 15867
		private static readonly IntPtr NativeMethodInfoPtr_get_EventListenersLock_Internal_Static_get_Object_0;
	}
}
