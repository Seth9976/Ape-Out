using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001D0 RID: 464
	public class RecordingSession : Object
	{
		// Token: 0x06001670 RID: 5744 RVA: 0x00065B40 File Offset: 0x00063D40
		// Note: this type is marked as 'beforefieldinit'.
		static RecordingSession()
		{
			Il2CppClassPointerStore<RecordingSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "RecordingSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr);
			RecordingSession.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, "clock");
			RecordingSession.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, "buffer");
			RecordingSession.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, "result");
			RecordingSession.NativeMethodInfoPtr__ctor_Public_Void_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, 100666466);
			RecordingSession.NativeMethodInfoPtr_Build_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, 100666467);
			RecordingSession.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, 100666468);
			RecordingSession.NativeMethodInfoPtr_get_Result_Public_get_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, 100666469);
			RecordingSession.NativeMethodInfoPtr_Record_Public_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, 100666470);
			RecordingSession.NativeMethodInfoPtr_Record_Public_Void_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, 100666471);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00065C24 File Offset: 0x00063E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17258, XrefRangeEnd = 17272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecordingSession(IClock clock)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.NativeMethodInfoPtr__ctor_Public_Void_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00065C70 File Offset: 0x00063E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17272, XrefRangeEnd = 17290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.NativeMethodInfoPtr_Build_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00065CA4 File Offset: 0x00063EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17290, XrefRangeEnd = 17292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00065CD8 File Offset: 0x00063ED8
		public unsafe Track Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.NativeMethodInfoPtr_get_Result_Public_get_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Track>(intPtr3) : null;
			}
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00065D18 File Offset: 0x00063F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17292, XrefRangeEnd = 17299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Record(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.NativeMethodInfoPtr_Record_Public_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00065D5C File Offset: 0x00063F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17299, XrefRangeEnd = 17306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Record(SysExMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.NativeMethodInfoPtr_Record_Public_Void_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0000905E File Offset: 0x0000725E
		public RecordingSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00065DA0 File Offset: 0x00063FA0
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00009067 File Offset: 0x00007267
		public unsafe IClock clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.NativeFieldInfoPtr_clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00065DD0 File Offset: 0x00063FD0
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x00009086 File Offset: 0x00007286
		public unsafe List<RecordingSession.TimestampedMessage> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RecordingSession.TimestampedMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00065E00 File Offset: 0x00064000
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x000090A5 File Offset: 0x000072A5
		public unsafe Track result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeFieldInfoPtr_clock;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClock_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Void_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Track_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_Record_Public_Void_ChannelMessage_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_Record_Public_Void_SysExMessage_0;

		// Token: 0x02000254 RID: 596
		public sealed class TimestampedMessage : ValueType
		{
			// Token: 0x06002075 RID: 8309 RVA: 0x0008E360 File Offset: 0x0008C560
			// Note: this type is marked as 'beforefieldinit'.
			static TimestampedMessage()
			{
				Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, "TimestampedMessage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr);
				RecordingSession.TimestampedMessage.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr, "ticks");
				RecordingSession.TimestampedMessage.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr, "message");
				RecordingSession.TimestampedMessage.NativeMethodInfoPtr__ctor_Public_Void_Int32_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr, 100666472);
			}

			// Token: 0x06002076 RID: 8310 RVA: 0x0008E3C8 File Offset: 0x0008C5C8
			[CallerCount(0)]
			public unsafe TimestampedMessage(int ticks, IMidiMessage message)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ticks;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.TimestampedMessage.NativeMethodInfoPtr__ctor_Public_Void_Int32_IMidiMessage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002077 RID: 8311 RVA: 0x0000BF24 File Offset: 0x0000A124
			public TimestampedMessage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002078 RID: 8312 RVA: 0x0000BF2D File Offset: 0x0000A12D
			public TimestampedMessage()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordingSession.TimestampedMessage>.NativeClassPtr))
			{
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06002079 RID: 8313 RVA: 0x0008E428 File Offset: 0x0008C628
			// (set) Token: 0x0600207A RID: 8314 RVA: 0x0000BF3F File Offset: 0x0000A13F
			public unsafe int ticks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.TimestampedMessage.NativeFieldInfoPtr_ticks);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.TimestampedMessage.NativeFieldInfoPtr_ticks)) = value;
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x0600207B RID: 8315 RVA: 0x0008E450 File Offset: 0x0008C650
			// (set) Token: 0x0600207C RID: 8316 RVA: 0x0000BF5A File Offset: 0x0000A15A
			public unsafe IMidiMessage message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.TimestampedMessage.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMidiMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordingSession.TimestampedMessage.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002055 RID: 8277
			private static readonly IntPtr NativeFieldInfoPtr_ticks;

			// Token: 0x04002056 RID: 8278
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04002057 RID: 8279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IMidiMessage_0;
		}

		// Token: 0x02000255 RID: 597
		public class TimestampComparer : Object
		{
			// Token: 0x0600207D RID: 8317 RVA: 0x0008E480 File Offset: 0x0008C680
			// Note: this type is marked as 'beforefieldinit'.
			static TimestampComparer()
			{
				Il2CppClassPointerStore<RecordingSession.TimestampComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecordingSession>.NativeClassPtr, "TimestampComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordingSession.TimestampComparer>.NativeClassPtr);
				RecordingSession.TimestampComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_TimestampedMessage_TimestampedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession.TimestampComparer>.NativeClassPtr, 100666473);
				RecordingSession.TimestampComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordingSession.TimestampComparer>.NativeClassPtr, 100666474);
			}

			// Token: 0x0600207E RID: 8318 RVA: 0x0008E4D4 File Offset: 0x0008C6D4
			[CallerCount(0)]
			public unsafe virtual int Compare(RecordingSession.TimestampedMessage x, RecordingSession.TimestampedMessage y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.TimestampComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_TimestampedMessage_TimestampedMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600207F RID: 8319 RVA: 0x0008E540 File Offset: 0x0008C740
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimestampComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordingSession.TimestampComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordingSession.TimestampComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002080 RID: 8320 RVA: 0x0000BF79 File Offset: 0x0000A179
			public TimestampComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002058 RID: 8280
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_TimestampedMessage_TimestampedMessage_0;

			// Token: 0x04002059 RID: 8281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
