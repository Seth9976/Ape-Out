using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000519 RID: 1305
	public class EventWrittenEventArgs : EventArgs
	{
		// Token: 0x06004CD6 RID: 19670 RVA: 0x00162490 File Offset: 0x00160690
		// Note: this type is marked as 'beforefieldinit'.
		static EventWrittenEventArgs()
		{
			Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventWrittenEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr);
			EventWrittenEventArgs.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "<EventId>k__BackingField");
			EventWrittenEventArgs.NativeFieldInfoPtr__RelatedActivityId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "<RelatedActivityId>k__BackingField");
			EventWrittenEventArgs.NativeFieldInfoPtr__Payload_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "<Payload>k__BackingField");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_message");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_eventName");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_eventSource");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_payloadNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_payloadNames");
			EventWrittenEventArgs.NativeMethodInfoPtr_set_EventName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674778);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_EventId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674779);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_RelatedActivityId_Internal_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674780);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_Payload_Internal_set_Void_ReadOnlyCollection_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674781);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_PayloadNames_Internal_set_Void_ReadOnlyCollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674782);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_Message_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674783);
			EventWrittenEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674784);
		}

		// Token: 0x1700135A RID: 4954
		// (set) Token: 0x06004CD7 RID: 19671 RVA: 0x001625D8 File Offset: 0x001607D8
		public unsafe string EventName
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_EventName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700135B RID: 4955
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x0016261C File Offset: 0x0016081C
		public unsafe int EventId
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_EventId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700135C RID: 4956
		// (set) Token: 0x06004CD9 RID: 19673 RVA: 0x0016265C File Offset: 0x0016085C
		public unsafe Guid RelatedActivityId
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_RelatedActivityId_Internal_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700135D RID: 4957
		// (set) Token: 0x06004CDA RID: 19674 RVA: 0x0016269C File Offset: 0x0016089C
		public unsafe ReadOnlyCollection<Object> Payload
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_Payload_Internal_set_Void_ReadOnlyCollection_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700135E RID: 4958
		// (set) Token: 0x06004CDB RID: 19675 RVA: 0x001626E0 File Offset: 0x001608E0
		public unsafe ReadOnlyCollection<string> PayloadNames
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_PayloadNames_Internal_set_Void_ReadOnlyCollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700135F RID: 4959
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x00162724 File Offset: 0x00160924
		public unsafe string Message
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_Message_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00162768 File Offset: 0x00160968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241342, RefRangeEnd = 241345, XrefRangeStart = 241339, XrefRangeEnd = 241342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWrittenEventArgs(EventSource eventSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x0001C92B File Offset: 0x0001AB2B
		public EventWrittenEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x001627B4 File Offset: 0x001609B4
		// (set) Token: 0x06004CE0 RID: 19680 RVA: 0x0001C934 File Offset: 0x0001AB34
		public unsafe int _EventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__EventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x001627DC File Offset: 0x001609DC
		// (set) Token: 0x06004CE2 RID: 19682 RVA: 0x0001C94F File Offset: 0x0001AB4F
		public unsafe Guid _RelatedActivityId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__RelatedActivityId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__RelatedActivityId_k__BackingField)) = value;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x00162804 File Offset: 0x00160A04
		// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x0001C96A File Offset: 0x0001AB6A
		public unsafe ReadOnlyCollection<Object> _Payload_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__Payload_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__Payload_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x00162834 File Offset: 0x00160A34
		// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0001C989 File Offset: 0x0001AB89
		public unsafe string m_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x0016285C File Offset: 0x00160A5C
		// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		public unsafe string m_eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x00162884 File Offset: 0x00160A84
		// (set) Token: 0x06004CEA RID: 19690 RVA: 0x0001C9C7 File Offset: 0x0001ABC7
		public unsafe EventSource m_eventSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x001628B4 File Offset: 0x00160AB4
		// (set) Token: 0x06004CEC RID: 19692 RVA: 0x0001C9E6 File Offset: 0x0001ABE6
		public unsafe ReadOnlyCollection<string> m_payloadNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_payloadNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_payloadNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E0F RID: 15887
		private static readonly IntPtr NativeFieldInfoPtr__EventId_k__BackingField;

		// Token: 0x04003E10 RID: 15888
		private static readonly IntPtr NativeFieldInfoPtr__RelatedActivityId_k__BackingField;

		// Token: 0x04003E11 RID: 15889
		private static readonly IntPtr NativeFieldInfoPtr__Payload_k__BackingField;

		// Token: 0x04003E12 RID: 15890
		private static readonly IntPtr NativeFieldInfoPtr_m_message;

		// Token: 0x04003E13 RID: 15891
		private static readonly IntPtr NativeFieldInfoPtr_m_eventName;

		// Token: 0x04003E14 RID: 15892
		private static readonly IntPtr NativeFieldInfoPtr_m_eventSource;

		// Token: 0x04003E15 RID: 15893
		private static readonly IntPtr NativeFieldInfoPtr_m_payloadNames;

		// Token: 0x04003E16 RID: 15894
		private static readonly IntPtr NativeMethodInfoPtr_set_EventName_Internal_set_Void_String_0;

		// Token: 0x04003E17 RID: 15895
		private static readonly IntPtr NativeMethodInfoPtr_set_EventId_Internal_set_Void_Int32_0;

		// Token: 0x04003E18 RID: 15896
		private static readonly IntPtr NativeMethodInfoPtr_set_RelatedActivityId_Internal_set_Void_Guid_0;

		// Token: 0x04003E19 RID: 15897
		private static readonly IntPtr NativeMethodInfoPtr_set_Payload_Internal_set_Void_ReadOnlyCollection_1_Object_0;

		// Token: 0x04003E1A RID: 15898
		private static readonly IntPtr NativeMethodInfoPtr_set_PayloadNames_Internal_set_Void_ReadOnlyCollection_1_String_0;

		// Token: 0x04003E1B RID: 15899
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Internal_set_Void_String_0;

		// Token: 0x04003E1C RID: 15900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventSource_0;
	}
}
