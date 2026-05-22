using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C7 RID: 455
	public class ChannelChaser : Object
	{
		// Token: 0x06001604 RID: 5636 RVA: 0x00064508 File Offset: 0x00062708
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelChaser()
		{
			Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ChannelChaser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr);
			ChannelChaser.NativeFieldInfoPtr_controllerMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, "controllerMessages");
			ChannelChaser.NativeFieldInfoPtr_programChangeMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, "programChangeMessages");
			ChannelChaser.NativeFieldInfoPtr_pitchBendMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, "pitchBendMessages");
			ChannelChaser.NativeFieldInfoPtr_channelPressureMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, "channelPressureMessages");
			ChannelChaser.NativeFieldInfoPtr_polyPressureMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, "polyPressureMessages");
			ChannelChaser.NativeFieldInfoPtr_Chased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, "Chased");
			ChannelChaser.NativeMethodInfoPtr_add_Chased_Public_add_Void_EventHandler_1_ChasedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666421);
			ChannelChaser.NativeMethodInfoPtr_remove_Chased_Public_rem_Void_EventHandler_1_ChasedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666422);
			ChannelChaser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666423);
			ChannelChaser.NativeMethodInfoPtr_Process_Public_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666424);
			ChannelChaser.NativeMethodInfoPtr_Chase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666425);
			ChannelChaser.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666426);
			ChannelChaser.NativeMethodInfoPtr_OnChased_Protected_Virtual_New_Void_ChasedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr, 100666427);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0006463C File Offset: 0x0006283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16958, XrefRangeEnd = 16961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Chased(EventHandler<ChasedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelChaser.NativeMethodInfoPtr_add_Chased_Public_add_Void_EventHandler_1_ChasedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00064680 File Offset: 0x00062880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16961, XrefRangeEnd = 16964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Chased(EventHandler<ChasedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelChaser.NativeMethodInfoPtr_remove_Chased_Public_rem_Void_EventHandler_1_ChasedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000646C4 File Offset: 0x000628C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16976, RefRangeEnd = 16977, XrefRangeStart = 16964, XrefRangeEnd = 16976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelChaser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelChaser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelChaser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00064700 File Offset: 0x00062900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16977, XrefRangeEnd = 16981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelChaser.NativeMethodInfoPtr_Process_Public_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00064744 File Offset: 0x00062944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16981, XrefRangeEnd = 17007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Chase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelChaser.NativeMethodInfoPtr_Chase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00064778 File Offset: 0x00062978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17007, XrefRangeEnd = 17012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelChaser.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000647AC File Offset: 0x000629AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17012, XrefRangeEnd = 17015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChased(ChasedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChannelChaser.NativeMethodInfoPtr_OnChased_Protected_Virtual_New_Void_ChasedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00008D11 File Offset: 0x00006F11
		public ChannelChaser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000647FC File Offset: 0x000629FC
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x00008D1A File Offset: 0x00006F1A
		public unsafe Il2CppObjectBase controllerMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_controllerMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_controllerMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0006482C File Offset: 0x00062A2C
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x00008D39 File Offset: 0x00006F39
		public unsafe Il2CppReferenceArray<ChannelMessage> programChangeMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_programChangeMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChannelMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_programChangeMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0006485C File Offset: 0x00062A5C
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00008D58 File Offset: 0x00006F58
		public unsafe Il2CppReferenceArray<ChannelMessage> pitchBendMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_pitchBendMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChannelMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_pitchBendMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0006488C File Offset: 0x00062A8C
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x00008D77 File Offset: 0x00006F77
		public unsafe Il2CppReferenceArray<ChannelMessage> channelPressureMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_channelPressureMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChannelMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_channelPressureMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x000648BC File Offset: 0x00062ABC
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00008D96 File Offset: 0x00006F96
		public unsafe Il2CppReferenceArray<ChannelMessage> polyPressureMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_polyPressureMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChannelMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_polyPressureMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x000648EC File Offset: 0x00062AEC
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00008DB5 File Offset: 0x00006FB5
		public unsafe EventHandler<ChasedEventArgs> Chased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_Chased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ChasedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelChaser.NativeFieldInfoPtr_Chased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_controllerMessages;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_programChangeMessages;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_pitchBendMessages;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_channelPressureMessages;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeFieldInfoPtr_polyPressureMessages;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_Chased;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_add_Chased_Public_add_Void_EventHandler_1_ChasedEventArgs_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_remove_Chased_Public_rem_Void_EventHandler_1_ChasedEventArgs_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_ChannelMessage_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_Chase_Public_Void_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_OnChased_Protected_Virtual_New_Void_ChasedEventArgs_0;
	}
}
