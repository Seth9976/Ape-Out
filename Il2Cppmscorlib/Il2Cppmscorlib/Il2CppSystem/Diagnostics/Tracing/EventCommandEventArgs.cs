using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000517 RID: 1303
	public class EventCommandEventArgs : EventArgs
	{
		// Token: 0x06004CB3 RID: 19635 RVA: 0x00161E5C File Offset: 0x0016005C
		// Note: this type is marked as 'beforefieldinit'.
		static EventCommandEventArgs()
		{
			Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventCommandEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr);
			EventCommandEventArgs.NativeFieldInfoPtr__Command_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "<Command>k__BackingField");
			EventCommandEventArgs.NativeFieldInfoPtr__Arguments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "<Arguments>k__BackingField");
			EventCommandEventArgs.NativeFieldInfoPtr_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "eventSource");
			EventCommandEventArgs.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "dispatcher");
			EventCommandEventArgs.NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "listener");
			EventCommandEventArgs.NativeFieldInfoPtr_perEventSourceSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "perEventSourceSessionId");
			EventCommandEventArgs.NativeFieldInfoPtr_etwSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "etwSessionId");
			EventCommandEventArgs.NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "enable");
			EventCommandEventArgs.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "level");
			EventCommandEventArgs.NativeFieldInfoPtr_matchAnyKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "matchAnyKeyword");
			EventCommandEventArgs.NativeFieldInfoPtr_nextCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "nextCommand");
			EventCommandEventArgs.NativeMethodInfoPtr_get_Command_Public_get_EventCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674771);
			EventCommandEventArgs.NativeMethodInfoPtr_set_Command_Internal_set_Void_EventCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674772);
			EventCommandEventArgs.NativeMethodInfoPtr_get_Arguments_Public_get_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674773);
			EventCommandEventArgs.NativeMethodInfoPtr_set_Arguments_Internal_set_Void_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674774);
			EventCommandEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventCommand_IDictionary_2_String_String_EventSource_EventListener_Int32_Int32_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674775);
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00161FCC File Offset: 0x001601CC
		// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x00162008 File Offset: 0x00160208
		public unsafe EventCommand Command
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_get_Command_Public_get_EventCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_set_Command_Internal_set_Void_EventCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x00162048 File Offset: 0x00160248
		// (set) Token: 0x06004CB7 RID: 19639 RVA: 0x00162088 File Offset: 0x00160288
		public unsafe IDictionary<string, string> Arguments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_get_Arguments_Public_get_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_set_Arguments_Internal_set_Void_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x001620CC File Offset: 0x001602CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241333, XrefRangeEnd = 241336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCommandEventArgs(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventCommand_IDictionary_2_String_String_EventSource_EventListener_Int32_Int32_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x0001C7BD File Offset: 0x0001A9BD
		public EventCommandEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x00162194 File Offset: 0x00160394
		// (set) Token: 0x06004CBB RID: 19643 RVA: 0x0001C7C6 File Offset: 0x0001A9C6
		public unsafe EventCommand _Command_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Command_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Command_k__BackingField)) = value;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x001621BC File Offset: 0x001603BC
		// (set) Token: 0x06004CBD RID: 19645 RVA: 0x0001C7E1 File Offset: 0x0001A9E1
		public unsafe IDictionary<string, string> _Arguments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Arguments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Arguments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x001621EC File Offset: 0x001603EC
		// (set) Token: 0x06004CBF RID: 19647 RVA: 0x0001C800 File Offset: 0x0001AA00
		public unsafe EventSource eventSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_eventSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x0016221C File Offset: 0x0016041C
		// (set) Token: 0x06004CC1 RID: 19649 RVA: 0x0001C81F File Offset: 0x0001AA1F
		public unsafe EventDispatcher dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x0016224C File Offset: 0x0016044C
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x0001C83E File Offset: 0x0001AA3E
		public unsafe EventListener listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x0016227C File Offset: 0x0016047C
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x0001C85D File Offset: 0x0001AA5D
		public unsafe int perEventSourceSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_perEventSourceSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_perEventSourceSessionId)) = value;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x001622A4 File Offset: 0x001604A4
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x0001C878 File Offset: 0x0001AA78
		public unsafe int etwSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_etwSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_etwSessionId)) = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x001622CC File Offset: 0x001604CC
		// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x0001C893 File Offset: 0x0001AA93
		public unsafe bool enable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_enable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_enable)) = value;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06004CCA RID: 19658 RVA: 0x001622F4 File Offset: 0x001604F4
		// (set) Token: 0x06004CCB RID: 19659 RVA: 0x0001C8AE File Offset: 0x0001AAAE
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06004CCC RID: 19660 RVA: 0x0016231C File Offset: 0x0016051C
		// (set) Token: 0x06004CCD RID: 19661 RVA: 0x0001C8C9 File Offset: 0x0001AAC9
		public unsafe EventKeywords matchAnyKeyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_matchAnyKeyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_matchAnyKeyword)) = value;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x00162344 File Offset: 0x00160544
		// (set) Token: 0x06004CCF RID: 19663 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		public unsafe EventCommandEventArgs nextCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_nextCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCommandEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_nextCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DFC RID: 15868
		private static readonly IntPtr NativeFieldInfoPtr__Command_k__BackingField;

		// Token: 0x04003DFD RID: 15869
		private static readonly IntPtr NativeFieldInfoPtr__Arguments_k__BackingField;

		// Token: 0x04003DFE RID: 15870
		private static readonly IntPtr NativeFieldInfoPtr_eventSource;

		// Token: 0x04003DFF RID: 15871
		private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

		// Token: 0x04003E00 RID: 15872
		private static readonly IntPtr NativeFieldInfoPtr_listener;

		// Token: 0x04003E01 RID: 15873
		private static readonly IntPtr NativeFieldInfoPtr_perEventSourceSessionId;

		// Token: 0x04003E02 RID: 15874
		private static readonly IntPtr NativeFieldInfoPtr_etwSessionId;

		// Token: 0x04003E03 RID: 15875
		private static readonly IntPtr NativeFieldInfoPtr_enable;

		// Token: 0x04003E04 RID: 15876
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003E05 RID: 15877
		private static readonly IntPtr NativeFieldInfoPtr_matchAnyKeyword;

		// Token: 0x04003E06 RID: 15878
		private static readonly IntPtr NativeFieldInfoPtr_nextCommand;

		// Token: 0x04003E07 RID: 15879
		private static readonly IntPtr NativeMethodInfoPtr_get_Command_Public_get_EventCommand_0;

		// Token: 0x04003E08 RID: 15880
		private static readonly IntPtr NativeMethodInfoPtr_set_Command_Internal_set_Void_EventCommand_0;

		// Token: 0x04003E09 RID: 15881
		private static readonly IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_IDictionary_2_String_String_0;

		// Token: 0x04003E0A RID: 15882
		private static readonly IntPtr NativeMethodInfoPtr_set_Arguments_Internal_set_Void_IDictionary_2_String_String_0;

		// Token: 0x04003E0B RID: 15883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventCommand_IDictionary_2_String_String_EventSource_EventListener_Int32_Int32_Boolean_EventLevel_EventKeywords_0;
	}
}
