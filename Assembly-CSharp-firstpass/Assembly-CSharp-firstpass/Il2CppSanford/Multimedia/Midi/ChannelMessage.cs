using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A4 RID: 420
	public sealed class ChannelMessage : ShortMessage
	{
		// Token: 0x06001410 RID: 5136 RVA: 0x0005D20C File Offset: 0x0005B40C
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelMessage()
		{
			Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ChannelMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr);
			ChannelMessage.NativeFieldInfoPtr_MidiChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, "MidiChannelMask");
			ChannelMessage.NativeFieldInfoPtr_CommandMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, "CommandMask");
			ChannelMessage.NativeFieldInfoPtr_MidiChannelMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, "MidiChannelMaxValue");
			ChannelMessage.NativeMethodInfoPtr__ctor_Public_Void_ChannelCommand_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666155);
			ChannelMessage.NativeMethodInfoPtr__ctor_Public_Void_ChannelCommand_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666156);
			ChannelMessage.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666157);
			ChannelMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666158);
			ChannelMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666159);
			ChannelMessage.NativeMethodInfoPtr_DataBytesPerType_Internal_Static_Int32_ChannelCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666160);
			ChannelMessage.NativeMethodInfoPtr_UnpackCommand_Internal_Static_ChannelCommand_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666161);
			ChannelMessage.NativeMethodInfoPtr_UnpackMidiChannel_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666162);
			ChannelMessage.NativeMethodInfoPtr_PackMidiChannel_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666163);
			ChannelMessage.NativeMethodInfoPtr_PackCommand_Internal_Static_Int32_Int32_ChannelCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666164);
			ChannelMessage.NativeMethodInfoPtr_get_Command_Public_get_ChannelCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666165);
			ChannelMessage.NativeMethodInfoPtr_get_MidiChannel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666166);
			ChannelMessage.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666167);
			ChannelMessage.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666168);
			ChannelMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr, 100666169);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16137, XrefRangeEnd = 16139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelMessage(ChannelCommand command, int midiChannel, int data1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiChannel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr__ctor_Public_Void_ChannelCommand_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0005D408 File Offset: 0x0005B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16139, XrefRangeEnd = 16142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelMessage(ChannelCommand command, int midiChannel, int data1, int data2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiChannel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr__ctor_Public_Void_ChannelCommand_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0005D47C File Offset: 0x0005B67C
		[CallerCount(0)]
		public unsafe ChannelMessage(int message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0005D4C4 File Offset: 0x0005B6C4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0005D500 File Offset: 0x0005B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16142, XrefRangeEnd = 16144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0005D550 File Offset: 0x0005B750
		[CallerCount(0)]
		public unsafe static int DataBytesPerType(ChannelCommand command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_DataBytesPerType_Internal_Static_Int32_ChannelCommand_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0005D590 File Offset: 0x0005B790
		[CallerCount(0)]
		public unsafe static ChannelCommand UnpackCommand(int message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_UnpackCommand_Internal_Static_ChannelCommand_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0005D5D0 File Offset: 0x0005B7D0
		[CallerCount(0)]
		public unsafe static int UnpackMidiChannel(int message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_UnpackMidiChannel_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0005D610 File Offset: 0x0005B810
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 16144, RefRangeEnd = 16152, XrefRangeStart = 16144, XrefRangeEnd = 16144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PackMidiChannel(int message, int midiChannel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref midiChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_PackMidiChannel_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0005D65C File Offset: 0x0005B85C
		[CallerCount(0)]
		public unsafe static int PackCommand(int message, ChannelCommand command)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref command;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_PackCommand_Internal_Static_Int32_Int32_ChannelCommand_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0005D6A8 File Offset: 0x0005B8A8
		public unsafe ChannelCommand Command
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_get_Command_Public_get_ChannelCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0005D6E4 File Offset: 0x0005B8E4
		public unsafe int MidiChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_get_MidiChannel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0005D720 File Offset: 0x0005B920
		public unsafe int Data1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_get_Data1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0005D75C File Offset: 0x0005B95C
		public unsafe int Data2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_get_Data2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0005D798 File Offset: 0x0005B998
		public unsafe override MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000083DA File Offset: 0x000065DA
		public ChannelMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0005D7D4 File Offset: 0x0005B9D4
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x000083E3 File Offset: 0x000065E3
		public unsafe static int MidiChannelMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ChannelMessage.NativeFieldInfoPtr_MidiChannelMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelMessage.NativeFieldInfoPtr_MidiChannelMask, (void*)(&value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0005D7F0 File Offset: 0x0005B9F0
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x000083F1 File Offset: 0x000065F1
		public unsafe static int CommandMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ChannelMessage.NativeFieldInfoPtr_CommandMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelMessage.NativeFieldInfoPtr_CommandMask, (void*)(&value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0005D80C File Offset: 0x0005BA0C
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x000083FF File Offset: 0x000065FF
		public unsafe static int MidiChannelMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ChannelMessage.NativeFieldInfoPtr_MidiChannelMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelMessage.NativeFieldInfoPtr_MidiChannelMaxValue, (void*)(&value));
			}
		}

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeFieldInfoPtr_MidiChannelMask;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeFieldInfoPtr_CommandMask;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeFieldInfoPtr_MidiChannelMaxValue;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChannelCommand_Int32_Int32_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChannelCommand_Int32_Int32_Int32_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_DataBytesPerType_Internal_Static_Int32_ChannelCommand_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_UnpackCommand_Internal_Static_ChannelCommand_Int32_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_UnpackMidiChannel_Internal_Static_Int32_Int32_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_PackMidiChannel_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_PackCommand_Internal_Static_Int32_Int32_ChannelCommand_0;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_get_Command_Public_get_ChannelCommand_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr_get_MidiChannel_Public_get_Int32_0;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr_get_Data1_Public_get_Int32_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_get_Data2_Public_get_Int32_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Virtual_get_MessageType_0;
	}
}
