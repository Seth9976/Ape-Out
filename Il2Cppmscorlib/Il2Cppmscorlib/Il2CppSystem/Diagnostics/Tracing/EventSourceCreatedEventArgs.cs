using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000518 RID: 1304
	public class EventSourceCreatedEventArgs : EventArgs
	{
		// Token: 0x06004CD0 RID: 19664 RVA: 0x00162374 File Offset: 0x00160574
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceCreatedEventArgs()
		{
			Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceCreatedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr);
			EventSourceCreatedEventArgs.NativeFieldInfoPtr__EventSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr, "<EventSource>k__BackingField");
			EventSourceCreatedEventArgs.NativeMethodInfoPtr_set_EventSource_Internal_set_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr, 100674776);
			EventSourceCreatedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr, 100674777);
		}

		// Token: 0x17001352 RID: 4946
		// (set) Token: 0x06004CD1 RID: 19665 RVA: 0x001623E0 File Offset: 0x001605E0
		public unsafe EventSource EventSource
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceCreatedEventArgs.NativeMethodInfoPtr_set_EventSource_Internal_set_Void_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00162424 File Offset: 0x00160624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241336, XrefRangeEnd = 241339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceCreatedEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceCreatedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x0001C903 File Offset: 0x0001AB03
		public EventSourceCreatedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x00162460 File Offset: 0x00160660
		// (set) Token: 0x06004CD5 RID: 19669 RVA: 0x0001C90C File Offset: 0x0001AB0C
		public unsafe EventSource _EventSource_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceCreatedEventArgs.NativeFieldInfoPtr__EventSource_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceCreatedEventArgs.NativeFieldInfoPtr__EventSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E0C RID: 15884
		private static readonly IntPtr NativeFieldInfoPtr__EventSource_k__BackingField;

		// Token: 0x04003E0D RID: 15885
		private static readonly IntPtr NativeMethodInfoPtr_set_EventSource_Internal_set_Void_EventSource_0;

		// Token: 0x04003E0E RID: 15886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
