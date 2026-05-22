using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051B RID: 1307
	public sealed class EventAttribute : Attribute
	{
		// Token: 0x06004CFB RID: 19707 RVA: 0x00162BAC File Offset: 0x00160DAC
		// Note: this type is marked as 'beforefieldinit'.
		static EventAttribute()
		{
			Il2CppClassPointerStore<EventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr);
			EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<EventId>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Level_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Level>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Keywords>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Task_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Task>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Version>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Message>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Tags>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__ActivityOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<ActivityOptions>k__BackingField");
			EventAttribute.NativeFieldInfoPtr_m_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "m_opcode");
			EventAttribute.NativeFieldInfoPtr_m_opcodeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "m_opcodeSet");
			EventAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674791);
			EventAttribute.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674792);
			EventAttribute.NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674793);
			EventAttribute.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674794);
			EventAttribute.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674795);
			EventAttribute.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674796);
			EventAttribute.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674797);
			EventAttribute.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674798);
			EventAttribute.NativeMethodInfoPtr_get_IsOpcodeSet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674799);
			EventAttribute.NativeMethodInfoPtr_get_Task_Public_get_EventTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674800);
			EventAttribute.NativeMethodInfoPtr_set_Task_Public_set_Void_EventTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674801);
			EventAttribute.NativeMethodInfoPtr_get_Version_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674802);
			EventAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674803);
			EventAttribute.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674804);
			EventAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674805);
			EventAttribute.NativeMethodInfoPtr_get_ActivityOptions_Public_get_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674806);
			EventAttribute.NativeMethodInfoPtr_set_ActivityOptions_Public_set_Void_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674807);
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00162DF8 File Offset: 0x00160FF8
		[CallerCount(0)]
		public unsafe EventAttribute(int eventId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x00162E40 File Offset: 0x00161040
		// (set) Token: 0x06004CFE RID: 19710 RVA: 0x00162E7C File Offset: 0x0016107C
		public unsafe int EventId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_EventId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x00162EBC File Offset: 0x001610BC
		// (set) Token: 0x06004D00 RID: 19712 RVA: 0x00162EF8 File Offset: 0x001610F8
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x00162F38 File Offset: 0x00161138
		public unsafe EventKeywords Keywords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x00162F74 File Offset: 0x00161174
		// (set) Token: 0x06004D03 RID: 19715 RVA: 0x00162FB0 File Offset: 0x001611B0
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x00162FF0 File Offset: 0x001611F0
		public unsafe bool IsOpcodeSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_IsOpcodeSet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x0016302C File Offset: 0x0016122C
		// (set) Token: 0x06004D06 RID: 19718 RVA: 0x00163068 File Offset: 0x00161268
		public unsafe EventTask Task
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Task_Public_get_EventTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Task_Public_set_Void_EventTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x001630A8 File Offset: 0x001612A8
		public unsafe byte Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Version_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x001630E4 File Offset: 0x001612E4
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x0016311C File Offset: 0x0016131C
		public unsafe string Message
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x00163160 File Offset: 0x00161360
		public unsafe EventTags Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x0016319C File Offset: 0x0016139C
		// (set) Token: 0x06004D0C RID: 19724 RVA: 0x001631D8 File Offset: 0x001613D8
		public unsafe EventActivityOptions ActivityOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_get_ActivityOptions_Public_get_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_ActivityOptions_Public_set_Void_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x0001CA6B File Offset: 0x0001AC6B
		public EventAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06004D0E RID: 19726 RVA: 0x00163218 File Offset: 0x00161418
		// (set) Token: 0x06004D0F RID: 19727 RVA: 0x0001CA74 File Offset: 0x0001AC74
		public unsafe int _EventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x00163240 File Offset: 0x00161440
		// (set) Token: 0x06004D11 RID: 19729 RVA: 0x0001CA8F File Offset: 0x0001AC8F
		public unsafe EventLevel _Level_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Level_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Level_k__BackingField)) = value;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x00163268 File Offset: 0x00161468
		// (set) Token: 0x06004D13 RID: 19731 RVA: 0x0001CAAA File Offset: 0x0001ACAA
		public unsafe EventKeywords _Keywords_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField)) = value;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x00163290 File Offset: 0x00161490
		// (set) Token: 0x06004D15 RID: 19733 RVA: 0x0001CAC5 File Offset: 0x0001ACC5
		public unsafe EventTask _Task_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Task_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Task_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x001632B8 File Offset: 0x001614B8
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
		public unsafe byte _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x001632E0 File Offset: 0x001614E0
		// (set) Token: 0x06004D19 RID: 19737 RVA: 0x0001CAFB File Offset: 0x0001ACFB
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x00163308 File Offset: 0x00161508
		// (set) Token: 0x06004D1B RID: 19739 RVA: 0x0001CB1A File Offset: 0x0001AD1A
		public unsafe EventTags _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Tags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Tags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x00163330 File Offset: 0x00161530
		// (set) Token: 0x06004D1D RID: 19741 RVA: 0x0001CB35 File Offset: 0x0001AD35
		public unsafe EventActivityOptions _ActivityOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__ActivityOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__ActivityOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x00163358 File Offset: 0x00161558
		// (set) Token: 0x06004D1F RID: 19743 RVA: 0x0001CB50 File Offset: 0x0001AD50
		public unsafe EventOpcode m_opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcode)) = value;
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06004D20 RID: 19744 RVA: 0x00163380 File Offset: 0x00161580
		// (set) Token: 0x06004D21 RID: 19745 RVA: 0x0001CB6B File Offset: 0x0001AD6B
		public unsafe bool m_opcodeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcodeSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr_m_opcodeSet)) = value;
			}
		}

		// Token: 0x04003E26 RID: 15910
		private static readonly IntPtr NativeFieldInfoPtr__EventId_k__BackingField;

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeFieldInfoPtr__Level_k__BackingField;

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeFieldInfoPtr__Keywords_k__BackingField;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeFieldInfoPtr__Task_k__BackingField;

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeFieldInfoPtr__ActivityOptions_k__BackingField;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeFieldInfoPtr_m_opcode;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeFieldInfoPtr_m_opcodeSet;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeMethodInfoPtr_get_EventId_Public_get_Int32_0;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0;

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0;

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0;

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0;

		// Token: 0x04003E37 RID: 15927
		private static readonly IntPtr NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0;

		// Token: 0x04003E38 RID: 15928
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpcodeSet_Internal_get_Boolean_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_EventTask_0;

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeMethodInfoPtr_set_Task_Public_set_Void_EventTask_0;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Byte_0;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivityOptions_Public_get_EventActivityOptions_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_set_ActivityOptions_Public_set_Void_EventActivityOptions_0;
	}
}
