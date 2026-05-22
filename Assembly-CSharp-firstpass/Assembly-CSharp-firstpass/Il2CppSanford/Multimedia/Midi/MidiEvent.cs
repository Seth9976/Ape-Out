using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001CB RID: 459
	public class MidiEvent : Object
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x00064F80 File Offset: 0x00063180
		// Note: this type is marked as 'beforefieldinit'.
		static MidiEvent()
		{
			Il2CppClassPointerStore<MidiEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr);
			MidiEvent.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, "owner");
			MidiEvent.NativeFieldInfoPtr_absoluteTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, "absoluteTicks");
			MidiEvent.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, "message");
			MidiEvent.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, "next");
			MidiEvent.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, "previous");
			MidiEvent.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int32_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666439);
			MidiEvent.NativeMethodInfoPtr_SetAbsoluteTicks_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666440);
			MidiEvent.NativeMethodInfoPtr_get_Owner_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666441);
			MidiEvent.NativeMethodInfoPtr_get_AbsoluteTicks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666442);
			MidiEvent.NativeMethodInfoPtr_get_DeltaTicks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666443);
			MidiEvent.NativeMethodInfoPtr_get_MidiMessage_Public_get_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666444);
			MidiEvent.NativeMethodInfoPtr_get_Next_Internal_get_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666445);
			MidiEvent.NativeMethodInfoPtr_set_Next_Internal_set_Void_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666446);
			MidiEvent.NativeMethodInfoPtr_get_Previous_Internal_get_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666447);
			MidiEvent.NativeMethodInfoPtr_set_Previous_Internal_set_Void_MidiEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr, 100666448);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000650DC File Offset: 0x000632DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 17083, RefRangeEnd = 17089, XrefRangeStart = 17083, XrefRangeEnd = 17083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiEvent(Object owner, int absoluteTicks, IMidiMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref absoluteTicks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int32_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00065148 File Offset: 0x00063348
		[CallerCount(0)]
		public unsafe void SetAbsoluteTicks(int absoluteTicks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref absoluteTicks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_SetAbsoluteTicks_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00065188 File Offset: 0x00063388
		public unsafe Object Owner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_get_Owner_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x000651C8 File Offset: 0x000633C8
		public unsafe int AbsoluteTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_get_AbsoluteTicks_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x00065204 File Offset: 0x00063404
		public unsafe int DeltaTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_get_DeltaTicks_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00065240 File Offset: 0x00063440
		public unsafe IMidiMessage MidiMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_get_MidiMessage_Public_get_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMidiMessage>(intPtr3) : null;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x00065280 File Offset: 0x00063480
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x000652C0 File Offset: 0x000634C0
		public unsafe MidiEvent Next
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_get_Next_Internal_get_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_set_Next_Internal_set_Void_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00065304 File Offset: 0x00063504
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x00065344 File Offset: 0x00063544
		public unsafe MidiEvent Previous
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_get_Previous_Internal_get_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiEvent.NativeMethodInfoPtr_set_Previous_Internal_set_Void_MidiEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00008EE7 File Offset: 0x000070E7
		public MidiEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00065388 File Offset: 0x00063588
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00008EF0 File Offset: 0x000070F0
		public unsafe Object owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x000653B8 File Offset: 0x000635B8
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00008F0F File Offset: 0x0000710F
		public unsafe int absoluteTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_absoluteTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_absoluteTicks)) = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x000653E0 File Offset: 0x000635E0
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00008F2A File Offset: 0x0000712A
		public unsafe IMidiMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMidiMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00065410 File Offset: 0x00063610
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00008F49 File Offset: 0x00007149
		public unsafe MidiEvent next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00065440 File Offset: 0x00063640
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00008F68 File Offset: 0x00007168
		public unsafe MidiEvent previous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_previous);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiEvent.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_absoluteTicks;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr_previous;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Int32_IMidiMessage_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_SetAbsoluteTicks_Internal_Void_Int32_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Internal_get_Object_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsoluteTicks_Public_get_Int32_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_get_DeltaTicks_Public_get_Int32_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiMessage_Public_get_IMidiMessage_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Internal_get_MidiEvent_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_MidiEvent_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_get_Previous_Internal_get_MidiEvent_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_set_Previous_Internal_set_Void_MidiEvent_0;
	}
}
