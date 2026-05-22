using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSanford.Threading;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000192 RID: 402
	public class InputDevice : MidiDevice
	{
		// Token: 0x06001285 RID: 4741 RVA: 0x00058190 File Offset: 0x00056390
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevice()
		{
			Il2CppClassPointerStore<InputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "InputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice>.NativeClassPtr);
			InputDevice.NativeFieldInfoPtr__PostEventsOnCreationContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<PostEventsOnCreationContext>k__BackingField");
			InputDevice.NativeFieldInfoPtr_MessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MessageReceived");
			InputDevice.NativeFieldInfoPtr_ShortMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "ShortMessageReceived");
			InputDevice.NativeFieldInfoPtr_ChannelMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "ChannelMessageReceived");
			InputDevice.NativeFieldInfoPtr_SysExMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "SysExMessageReceived");
			InputDevice.NativeFieldInfoPtr_SysCommonMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "SysCommonMessageReceived");
			InputDevice.NativeFieldInfoPtr_SysRealtimeMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "SysRealtimeMessageReceived");
			InputDevice.NativeFieldInfoPtr_InvalidShortMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "InvalidShortMessageReceived");
			InputDevice.NativeFieldInfoPtr_InvalidSysExMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "InvalidSysExMessageReceived");
			InputDevice.NativeFieldInfoPtr_delegateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "delegateQueue");
			InputDevice.NativeFieldInfoPtr_bufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "bufferCount");
			InputDevice.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "lockObject");
			InputDevice.NativeFieldInfoPtr_midiInProc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "midiInProc");
			InputDevice.NativeFieldInfoPtr_recording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "recording");
			InputDevice.NativeFieldInfoPtr_headerBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "headerBuilder");
			InputDevice.NativeFieldInfoPtr_cmBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cmBuilder");
			InputDevice.NativeFieldInfoPtr_scBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "scBuilder");
			InputDevice.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "handle");
			InputDevice.NativeFieldInfoPtr_resetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "resetting");
			InputDevice.NativeFieldInfoPtr_sysExBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "sysExBufferSize");
			InputDevice.NativeFieldInfoPtr_sysExData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "sysExData");
			InputDevice.NativeFieldInfoPtr__PostDriverCallbackToDelegateQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<PostDriverCallbackToDelegateQueue>k__BackingField");
			InputDevice.NativeFieldInfoPtr_FLastParam2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "FLastParam2");
			InputDevice.NativeFieldInfoPtr_MIDI_IO_STATUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIDI_IO_STATUS");
			InputDevice.NativeFieldInfoPtr_MIM_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_OPEN");
			InputDevice.NativeFieldInfoPtr_MIM_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_CLOSE");
			InputDevice.NativeFieldInfoPtr_MIM_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_DATA");
			InputDevice.NativeFieldInfoPtr_MIM_LONGDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_LONGDATA");
			InputDevice.NativeFieldInfoPtr_MIM_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_ERROR");
			InputDevice.NativeFieldInfoPtr_MIM_LONGERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_LONGERROR");
			InputDevice.NativeFieldInfoPtr_MIM_MOREDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MIM_MOREDATA");
			InputDevice.NativeFieldInfoPtr_MHDR_DONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MHDR_DONE");
			InputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665969);
			InputDevice.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665970);
			InputDevice.NativeMethodInfoPtr_get_PostEventsOnCreationContext_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665971);
			InputDevice.NativeMethodInfoPtr_set_PostEventsOnCreationContext_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665972);
			InputDevice.NativeMethodInfoPtr_add_MessageReceived_Public_add_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665973);
			InputDevice.NativeMethodInfoPtr_remove_MessageReceived_Public_rem_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665974);
			InputDevice.NativeMethodInfoPtr_add_ShortMessageReceived_Public_add_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665975);
			InputDevice.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_rem_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665976);
			InputDevice.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665977);
			InputDevice.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665978);
			InputDevice.NativeMethodInfoPtr_add_SysExMessageReceived_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665979);
			InputDevice.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665980);
			InputDevice.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_add_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665981);
			InputDevice.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665982);
			InputDevice.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665983);
			InputDevice.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665984);
			InputDevice.NativeMethodInfoPtr_add_InvalidShortMessageReceived_Public_add_Void_EventHandler_1_InvalidShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665985);
			InputDevice.NativeMethodInfoPtr_remove_InvalidShortMessageReceived_Public_rem_Void_EventHandler_1_InvalidShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665986);
			InputDevice.NativeMethodInfoPtr_add_InvalidSysExMessageReceived_Public_add_Void_EventHandler_1_InvalidSysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665987);
			InputDevice.NativeMethodInfoPtr_remove_InvalidSysExMessageReceived_Public_rem_Void_EventHandler_1_InvalidSysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665988);
			InputDevice.NativeMethodInfoPtr_OnShortMessage_Protected_Virtual_New_Void_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665989);
			InputDevice.NativeMethodInfoPtr_OnMessageReceived_Protected_Void_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665990);
			InputDevice.NativeMethodInfoPtr_OnChannelMessageReceived_Protected_Virtual_New_Void_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665991);
			InputDevice.NativeMethodInfoPtr_OnSysExMessageReceived_Protected_Virtual_New_Void_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665992);
			InputDevice.NativeMethodInfoPtr_OnSysCommonMessageReceived_Protected_Virtual_New_Void_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665993);
			InputDevice.NativeMethodInfoPtr_OnSysRealtimeMessageReceived_Protected_Virtual_New_Void_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665994);
			InputDevice.NativeMethodInfoPtr_OnInvalidShortMessageReceived_Protected_Virtual_New_Void_InvalidShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665995);
			InputDevice.NativeMethodInfoPtr_OnInvalidSysExMessageReceived_Protected_Virtual_New_Void_InvalidSysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665996);
			InputDevice.NativeMethodInfoPtr_get_PostDriverCallbackToDelegateQueue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665997);
			InputDevice.NativeMethodInfoPtr_set_PostDriverCallbackToDelegateQueue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665998);
			InputDevice.NativeMethodInfoPtr_HandleMessage_Private_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665999);
			InputDevice.NativeMethodInfoPtr_HandleShortMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666000);
			InputDevice.NativeMethodInfoPtr_HandleSysExMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666001);
			InputDevice.NativeMethodInfoPtr_HandleInvalidShortMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666002);
			InputDevice.NativeMethodInfoPtr_HandleInvalidSysExMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666003);
			InputDevice.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666004);
			InputDevice.NativeMethodInfoPtr_AddSysExBuffer_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666005);
			InputDevice.NativeMethodInfoPtr_get_Handle_Public_Virtual_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666006);
			InputDevice.NativeMethodInfoPtr_get_SysExBufferSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666007);
			InputDevice.NativeMethodInfoPtr_set_SysExBufferSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666008);
			InputDevice.NativeMethodInfoPtr_get_DeviceCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666009);
			InputDevice.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666010);
			InputDevice.NativeMethodInfoPtr_StartRecording_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666011);
			InputDevice.NativeMethodInfoPtr_StopRecording_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666012);
			InputDevice.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666013);
			InputDevice.NativeMethodInfoPtr_GetDeviceCapabilities_Public_Static_MidiInCaps_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666014);
			InputDevice.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666015);
			InputDevice.NativeMethodInfoPtr_midiInOpen_Private_Static_Int32_byref_IntPtr_Int32_MidiInProc_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666016);
			InputDevice.NativeMethodInfoPtr_midiInClose_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666017);
			InputDevice.NativeMethodInfoPtr_midiInStart_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666018);
			InputDevice.NativeMethodInfoPtr_midiInStop_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666019);
			InputDevice.NativeMethodInfoPtr_midiInReset_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666020);
			InputDevice.NativeMethodInfoPtr_midiInPrepareHeader_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666021);
			InputDevice.NativeMethodInfoPtr_midiInUnprepareHeader_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666022);
			InputDevice.NativeMethodInfoPtr_midiInAddBuffer_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666023);
			InputDevice.NativeMethodInfoPtr_midiInGetDevCaps_Private_Static_Int32_IntPtr_byref_MidiInCaps_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666024);
			InputDevice.NativeMethodInfoPtr_midiInGetNumDevs_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666025);
			InputDevice.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100666026);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000588C8 File Offset: 0x00056AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14996, XrefRangeEnd = 15030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDevice(int deviceID, bool postEventsOnCreationContext = true, bool postDriverCallbackToDelegateQueue = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref postEventsOnCreationContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref postDriverCallbackToDelegateQueue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0005892C File Offset: 0x00056B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15030, XrefRangeEnd = 15033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00058968 File Offset: 0x00056B68
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x000589A4 File Offset: 0x00056BA4
		public unsafe bool PostEventsOnCreationContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_PostEventsOnCreationContext_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_PostEventsOnCreationContext_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000589E4 File Offset: 0x00056BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15033, XrefRangeEnd = 15036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_MessageReceived_Public_add_Void_MidiMessageEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00058A28 File Offset: 0x00056C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15036, XrefRangeEnd = 15039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_MessageReceived_Public_rem_Void_MidiMessageEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00058A6C File Offset: 0x00056C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15039, XrefRangeEnd = 15042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_ShortMessageReceived_Public_add_Void_EventHandler_1_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00058AB0 File Offset: 0x00056CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15042, XrefRangeEnd = 15045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_rem_Void_EventHandler_1_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00058AF4 File Offset: 0x00056CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15045, XrefRangeEnd = 15048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00058B38 File Offset: 0x00056D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15048, XrefRangeEnd = 15051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00058B7C File Offset: 0x00056D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15051, XrefRangeEnd = 15054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_SysExMessageReceived_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00058BC0 File Offset: 0x00056DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15054, XrefRangeEnd = 15057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00058C04 File Offset: 0x00056E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15057, XrefRangeEnd = 15060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_add_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00058C48 File Offset: 0x00056E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15060, XrefRangeEnd = 15063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00058C8C File Offset: 0x00056E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15063, XrefRangeEnd = 15066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00058CD0 File Offset: 0x00056ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15066, XrefRangeEnd = 15069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00058D14 File Offset: 0x00056F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15069, XrefRangeEnd = 15072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InvalidShortMessageReceived(EventHandler<InvalidShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_InvalidShortMessageReceived_Public_add_Void_EventHandler_1_InvalidShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00058D58 File Offset: 0x00056F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15072, XrefRangeEnd = 15075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InvalidShortMessageReceived(EventHandler<InvalidShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_InvalidShortMessageReceived_Public_rem_Void_EventHandler_1_InvalidShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00058D9C File Offset: 0x00056F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15075, XrefRangeEnd = 15078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InvalidSysExMessageReceived(EventHandler<InvalidSysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_add_InvalidSysExMessageReceived_Public_add_Void_EventHandler_1_InvalidSysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00058DE0 File Offset: 0x00056FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15078, XrefRangeEnd = 15081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InvalidSysExMessageReceived(EventHandler<InvalidSysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_remove_InvalidSysExMessageReceived_Public_rem_Void_EventHandler_1_InvalidSysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00058E24 File Offset: 0x00057024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15081, XrefRangeEnd = 15089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnShortMessage(ShortMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnShortMessage_Protected_Virtual_New_Void_ShortMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00058E74 File Offset: 0x00057074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15095, RefRangeEnd = 15097, XrefRangeStart = 15089, XrefRangeEnd = 15095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMessageReceived(IMidiMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_OnMessageReceived_Protected_Void_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00058EB8 File Offset: 0x000570B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15097, XrefRangeEnd = 15105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChannelMessageReceived(ChannelMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnChannelMessageReceived_Protected_Virtual_New_Void_ChannelMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00058F08 File Offset: 0x00057108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15105, XrefRangeEnd = 15113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSysExMessageReceived(SysExMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnSysExMessageReceived_Protected_Virtual_New_Void_SysExMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00058F58 File Offset: 0x00057158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15113, XrefRangeEnd = 15121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSysCommonMessageReceived(SysCommonMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnSysCommonMessageReceived_Protected_Virtual_New_Void_SysCommonMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00058FA8 File Offset: 0x000571A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15121, XrefRangeEnd = 15129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSysRealtimeMessageReceived(SysRealtimeMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnSysRealtimeMessageReceived_Protected_Virtual_New_Void_SysRealtimeMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00058FF8 File Offset: 0x000571F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15129, XrefRangeEnd = 15137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInvalidShortMessageReceived(InvalidShortMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnInvalidShortMessageReceived_Protected_Virtual_New_Void_InvalidShortMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00059048 File Offset: 0x00057248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15137, XrefRangeEnd = 15145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInvalidSysExMessageReceived(InvalidSysExMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_OnInvalidSysExMessageReceived_Protected_Virtual_New_Void_InvalidSysExMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00059098 File Offset: 0x00057298
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x000590D4 File Offset: 0x000572D4
		public unsafe bool PostDriverCallbackToDelegateQueue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_PostDriverCallbackToDelegateQueue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_PostDriverCallbackToDelegateQueue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00059114 File Offset: 0x00057314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15145, XrefRangeEnd = 15160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleMessage(IntPtr hnd, int msg, IntPtr instance, IntPtr param1, IntPtr param2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_HandleMessage_Private_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0005918C File Offset: 0x0005738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15160, XrefRangeEnd = 15202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleShortMessage(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_HandleShortMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000591D0 File Offset: 0x000573D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15202, XrefRangeEnd = 15249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSysExMessage(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_HandleSysExMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00059214 File Offset: 0x00057414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15249, XrefRangeEnd = 15259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInvalidShortMessage(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_HandleInvalidShortMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00059258 File Offset: 0x00057458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15298, RefRangeEnd = 15299, XrefRangeStart = 15259, XrefRangeEnd = 15298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInvalidSysExMessage(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_HandleInvalidSysExMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0005929C File Offset: 0x0005749C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15327, RefRangeEnd = 15329, XrefRangeStart = 15299, XrefRangeEnd = 15327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBuffer(IntPtr headerPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref headerPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000592DC File Offset: 0x000574DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 15347, RefRangeEnd = 15353, XrefRangeStart = 15329, XrefRangeEnd = 15347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddSysExBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_AddSysExBuffer_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00059318 File Offset: 0x00057518
		public unsafe override IntPtr Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_get_Handle_Public_Virtual_get_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00059360 File Offset: 0x00057560
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x0005939C File Offset: 0x0005759C
		public unsafe int SysExBufferSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_SysExBufferSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_SysExBufferSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000593DC File Offset: 0x000575DC
		public unsafe static int DeviceCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15353, XrefRangeEnd = 15355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DeviceCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0005940C File Offset: 0x0005760C
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00059448 File Offset: 0x00057648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15364, RefRangeEnd = 15365, XrefRangeStart = 15355, XrefRangeEnd = 15364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartRecording()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_StartRecording_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0005947C File Offset: 0x0005767C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15365, XrefRangeEnd = 15370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRecording()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_StopRecording_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000594B0 File Offset: 0x000576B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15370, XrefRangeEnd = 15376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000594EC File Offset: 0x000576EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15376, XrefRangeEnd = 15383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MidiInCaps GetDeviceCapabilities(int deviceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetDeviceCapabilities_Public_Static_MidiInCaps_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MidiInCaps(intPtr);
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00059524 File Offset: 0x00057724
		[CallerCount(0)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00059560 File Offset: 0x00057760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15383, XrefRangeEnd = 15385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInOpen(out IntPtr handle, int deviceID, InputDevice.MidiInProc proc, IntPtr instance, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proc);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInOpen_Private_Static_Int32_byref_IntPtr_Int32_MidiInProc_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000595DC File Offset: 0x000577DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15387, RefRangeEnd = 15390, XrefRangeStart = 15385, XrefRangeEnd = 15387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInClose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInClose_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0005961C File Offset: 0x0005781C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15390, XrefRangeEnd = 15392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInStart(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInStart_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0005965C File Offset: 0x0005785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15392, XrefRangeEnd = 15394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInStop(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInStop_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0005969C File Offset: 0x0005789C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15396, RefRangeEnd = 15399, XrefRangeStart = 15394, XrefRangeEnd = 15396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInReset(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInReset_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000596DC File Offset: 0x000578DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15399, XrefRangeEnd = 15401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInPrepareHeader(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInPrepareHeader_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00059738 File Offset: 0x00057938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15403, RefRangeEnd = 15405, XrefRangeStart = 15401, XrefRangeEnd = 15403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInUnprepareHeader(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInUnprepareHeader_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00059794 File Offset: 0x00057994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15405, XrefRangeEnd = 15407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInAddBuffer(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInAddBuffer_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000597F0 File Offset: 0x000579F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15407, XrefRangeEnd = 15410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInGetDevCaps(IntPtr deviceID, ref MidiInCaps caps, int sizeOfMidiInCaps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(caps));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiInCaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInGetDevCaps_Private_Static_Int32_IntPtr_byref_MidiInCaps_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00059854 File Offset: 0x00057A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiInGetNumDevs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_midiInGetNumDevs_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00059884 File Offset: 0x00057A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15410, XrefRangeEnd = 15433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0000795E File Offset: 0x00005B5E
		public InputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000598D0 File Offset: 0x00057AD0
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00007967 File Offset: 0x00005B67
		public unsafe bool _PostEventsOnCreationContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__PostEventsOnCreationContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__PostEventsOnCreationContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000598F8 File Offset: 0x00057AF8
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00007982 File Offset: 0x00005B82
		public unsafe MidiMessageEventHandler MessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_MessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiMessageEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_MessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00059928 File Offset: 0x00057B28
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x000079A1 File Offset: 0x00005BA1
		public unsafe EventHandler<ShortMessageEventArgs> ShortMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_ShortMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ShortMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_ShortMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00059958 File Offset: 0x00057B58
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x000079C0 File Offset: 0x00005BC0
		public unsafe EventHandler<ChannelMessageEventArgs> ChannelMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_ChannelMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ChannelMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_ChannelMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00059988 File Offset: 0x00057B88
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x000079DF File Offset: 0x00005BDF
		public unsafe EventHandler<SysExMessageEventArgs> SysExMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_SysExMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysExMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_SysExMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000599B8 File Offset: 0x00057BB8
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x000079FE File Offset: 0x00005BFE
		public unsafe EventHandler<SysCommonMessageEventArgs> SysCommonMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_SysCommonMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysCommonMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_SysCommonMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x000599E8 File Offset: 0x00057BE8
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00007A1D File Offset: 0x00005C1D
		public unsafe EventHandler<SysRealtimeMessageEventArgs> SysRealtimeMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_SysRealtimeMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysRealtimeMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_SysRealtimeMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00059A18 File Offset: 0x00057C18
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00007A3C File Offset: 0x00005C3C
		public unsafe EventHandler<InvalidShortMessageEventArgs> InvalidShortMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_InvalidShortMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvalidShortMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_InvalidShortMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00059A48 File Offset: 0x00057C48
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00007A5B File Offset: 0x00005C5B
		public unsafe EventHandler<InvalidSysExMessageEventArgs> InvalidSysExMessageReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_InvalidSysExMessageReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvalidSysExMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_InvalidSysExMessageReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00059A78 File Offset: 0x00057C78
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00007A7A File Offset: 0x00005C7A
		public unsafe DelegateQueue delegateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_delegateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_delegateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00059AA8 File Offset: 0x00057CA8
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00007A99 File Offset: 0x00005C99
		public unsafe int bufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_bufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_bufferCount)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00059AD0 File Offset: 0x00057CD0
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00007AB4 File Offset: 0x00005CB4
		public unsafe Object lockObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_lockObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_lockObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00059B00 File Offset: 0x00057D00
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x00007AD3 File Offset: 0x00005CD3
		public unsafe InputDevice.MidiInProc midiInProc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_midiInProc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice.MidiInProc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_midiInProc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00059B30 File Offset: 0x00057D30
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00007AF2 File Offset: 0x00005CF2
		public unsafe bool recording
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_recording);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_recording)) = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00059B58 File Offset: 0x00057D58
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00007B0D File Offset: 0x00005D0D
		public unsafe MidiHeaderBuilder headerBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_headerBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiHeaderBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_headerBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00059B88 File Offset: 0x00057D88
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00007B2C File Offset: 0x00005D2C
		public unsafe ChannelMessageBuilder cmBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cmBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cmBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00059BB8 File Offset: 0x00057DB8
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00007B4B File Offset: 0x00005D4B
		public unsafe SysCommonMessageBuilder scBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_scBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysCommonMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_scBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00059BE8 File Offset: 0x00057DE8
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00007B6A File Offset: 0x00005D6A
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00059C10 File Offset: 0x00057E10
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00007B85 File Offset: 0x00005D85
		public unsafe bool resetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_resetting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_resetting)) = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00059C38 File Offset: 0x00057E38
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public unsafe int sysExBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_sysExBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_sysExBufferSize)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00059C60 File Offset: 0x00057E60
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00007BBB File Offset: 0x00005DBB
		public unsafe List<byte> sysExData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_sysExData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_sysExData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00059C90 File Offset: 0x00057E90
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x00007BDA File Offset: 0x00005DDA
		public unsafe bool _PostDriverCallbackToDelegateQueue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__PostDriverCallbackToDelegateQueue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__PostDriverCallbackToDelegateQueue_k__BackingField)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00059CB8 File Offset: 0x00057EB8
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public unsafe int FLastParam2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_FLastParam2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_FLastParam2)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00059CE0 File Offset: 0x00057EE0
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00007C10 File Offset: 0x00005E10
		public unsafe static int MIDI_IO_STATUS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIDI_IO_STATUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIDI_IO_STATUS, (void*)(&value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00059CFC File Offset: 0x00057EFC
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00007C1E File Offset: 0x00005E1E
		public unsafe static int MIM_OPEN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_OPEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00059D18 File Offset: 0x00057F18
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00007C2C File Offset: 0x00005E2C
		public unsafe static int MIM_CLOSE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_CLOSE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_CLOSE, (void*)(&value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00059D34 File Offset: 0x00057F34
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00007C3A File Offset: 0x00005E3A
		public unsafe static int MIM_DATA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_DATA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_DATA, (void*)(&value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00059D50 File Offset: 0x00057F50
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00007C48 File Offset: 0x00005E48
		public unsafe static int MIM_LONGDATA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_LONGDATA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_LONGDATA, (void*)(&value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00059D6C File Offset: 0x00057F6C
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00007C56 File Offset: 0x00005E56
		public unsafe static int MIM_ERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_ERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_ERROR, (void*)(&value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00059D88 File Offset: 0x00057F88
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00007C64 File Offset: 0x00005E64
		public unsafe static int MIM_LONGERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_LONGERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_LONGERROR, (void*)(&value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00059DA4 File Offset: 0x00057FA4
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00007C72 File Offset: 0x00005E72
		public unsafe static int MIM_MOREDATA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MIM_MOREDATA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MIM_MOREDATA, (void*)(&value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00059DC0 File Offset: 0x00057FC0
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00007C80 File Offset: 0x00005E80
		public unsafe static int MHDR_DONE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_MHDR_DONE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_MHDR_DONE, (void*)(&value));
			}
		}

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr__PostEventsOnCreationContext_k__BackingField;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_MessageReceived;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_ShortMessageReceived;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_ChannelMessageReceived;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_SysExMessageReceived;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_SysCommonMessageReceived;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_SysRealtimeMessageReceived;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeFieldInfoPtr_InvalidShortMessageReceived;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_InvalidSysExMessageReceived;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_delegateQueue;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeFieldInfoPtr_bufferCount;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr_midiInProc;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeFieldInfoPtr_recording;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeFieldInfoPtr_headerBuilder;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeFieldInfoPtr_cmBuilder;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeFieldInfoPtr_scBuilder;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeFieldInfoPtr_resetting;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_sysExBufferSize;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_sysExData;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeFieldInfoPtr__PostDriverCallbackToDelegateQueue_k__BackingField;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeFieldInfoPtr_FLastParam2;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeFieldInfoPtr_MIDI_IO_STATUS;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeFieldInfoPtr_MIM_OPEN;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeFieldInfoPtr_MIM_CLOSE;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeFieldInfoPtr_MIM_DATA;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeFieldInfoPtr_MIM_LONGDATA;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeFieldInfoPtr_MIM_ERROR;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeFieldInfoPtr_MIM_LONGERROR;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeFieldInfoPtr_MIM_MOREDATA;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeFieldInfoPtr_MHDR_DONE;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_get_PostEventsOnCreationContext_Public_get_Boolean_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_set_PostEventsOnCreationContext_Public_set_Void_Boolean_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_add_MessageReceived_Public_add_Void_MidiMessageEventHandler_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_remove_MessageReceived_Public_rem_Void_MidiMessageEventHandler_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_add_ShortMessageReceived_Public_add_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_remove_ShortMessageReceived_Public_rem_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_add_ChannelMessageReceived_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_add_SysExMessageReceived_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysExMessageReceived_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_add_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_add_InvalidShortMessageReceived_Public_add_Void_EventHandler_1_InvalidShortMessageEventArgs_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_remove_InvalidShortMessageReceived_Public_rem_Void_EventHandler_1_InvalidShortMessageEventArgs_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_add_InvalidSysExMessageReceived_Public_add_Void_EventHandler_1_InvalidSysExMessageEventArgs_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_remove_InvalidSysExMessageReceived_Public_rem_Void_EventHandler_1_InvalidSysExMessageEventArgs_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_OnShortMessage_Protected_Virtual_New_Void_ShortMessageEventArgs_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_OnMessageReceived_Protected_Void_IMidiMessage_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_OnChannelMessageReceived_Protected_Virtual_New_Void_ChannelMessageEventArgs_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_OnSysExMessageReceived_Protected_Virtual_New_Void_SysExMessageEventArgs_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_OnSysCommonMessageReceived_Protected_Virtual_New_Void_SysCommonMessageEventArgs_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_OnSysRealtimeMessageReceived_Protected_Virtual_New_Void_SysRealtimeMessageEventArgs_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_OnInvalidShortMessageReceived_Protected_Virtual_New_Void_InvalidShortMessageEventArgs_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_OnInvalidSysExMessageReceived_Protected_Virtual_New_Void_InvalidSysExMessageEventArgs_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_get_PostDriverCallbackToDelegateQueue_Public_get_Boolean_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_set_PostDriverCallbackToDelegateQueue_Public_set_Void_Boolean_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_HandleMessage_Private_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_HandleShortMessage_Private_Void_Object_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_HandleSysExMessage_Private_Void_Object_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_HandleInvalidShortMessage_Private_Void_Object_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_HandleInvalidSysExMessage_Private_Void_Object_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBuffer_Private_Void_IntPtr_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_AddSysExBuffer_Public_Int32_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_get_IntPtr_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_get_SysExBufferSize_Public_get_Int32_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_set_SysExBufferSize_Public_set_Void_Int32_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceCount_Public_Static_get_Int32_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_StartRecording_Public_Void_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_StopRecording_Public_Void_0;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceCapabilities_Public_Static_MidiInCaps_Int32_0;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr_midiInOpen_Private_Static_Int32_byref_IntPtr_Int32_MidiInProc_IntPtr_Int32_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr_midiInClose_Private_Static_Int32_IntPtr_0;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_midiInStart_Private_Static_Int32_IntPtr_0;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_midiInStop_Private_Static_Int32_IntPtr_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_midiInReset_Private_Static_Int32_IntPtr_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_midiInPrepareHeader_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_midiInUnprepareHeader_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_midiInAddBuffer_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_midiInGetDevCaps_Private_Static_Int32_IntPtr_byref_MidiInCaps_Int32_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_midiInGetNumDevs_Private_Static_Int32_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x02000246 RID: 582
		public sealed class GenericDelegate<T> : MulticastDelegate
		{
			// Token: 0x06001FF9 RID: 8185 RVA: 0x0008CB4C File Offset: 0x0008AD4C
			// Note: this type is marked as 'beforefieldinit'.
			static GenericDelegate()
			{
				Il2CppClassPointerStore<InputDevice.GenericDelegate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "GenericDelegate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				InputDevice.GenericDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.GenericDelegate<T>>.NativeClassPtr, 100666027);
				InputDevice.GenericDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.GenericDelegate<T>>.NativeClassPtr, 100666028);
				InputDevice.GenericDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.GenericDelegate<T>>.NativeClassPtr, 100666029);
				InputDevice.GenericDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.GenericDelegate<T>>.NativeClassPtr, 100666030);
			}

			// Token: 0x06001FFA RID: 8186 RVA: 0x0008CBF8 File Offset: 0x0008ADF8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GenericDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.GenericDelegate<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.GenericDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FFB RID: 8187 RVA: 0x0008CC54 File Offset: 0x0008AE54
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(T args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = args;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref args;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.GenericDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FFC RID: 8188 RVA: 0x0008CCE4 File Offset: 0x0008AEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T args, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = args;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref args;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.GenericDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FFD RID: 8189 RVA: 0x0008CDA4 File Offset: 0x0008AFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.GenericDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FFE RID: 8190 RVA: 0x0000BAFA File Offset: 0x00009CFA
			public GenericDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FFF RID: 8191 RVA: 0x0000BB03 File Offset: 0x00009D03
			public static implicit operator InputDevice.GenericDelegate<T>(Action<T> A_0)
			{
				return DelegateSupport.ConvertDelegate<InputDevice.GenericDelegate<T>>(A_0);
			}

			// Token: 0x06002000 RID: 8192 RVA: 0x0000BB0B File Offset: 0x00009D0B
			public static InputDevice.GenericDelegate<T>operator +(InputDevice.GenericDelegate<T> A_0, InputDevice.GenericDelegate<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<InputDevice.GenericDelegate<T>>();
			}

			// Token: 0x06002001 RID: 8193 RVA: 0x0000BB19 File Offset: 0x00009D19
			public static InputDevice.GenericDelegate<T>operator -(InputDevice.GenericDelegate<T> A_0, InputDevice.GenericDelegate<T> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<InputDevice.GenericDelegate<T>>();
				}
				return delegate2;
			}

			// Token: 0x04002016 RID: 8214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002017 RID: 8215
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;

			// Token: 0x04002018 RID: 8216
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04002019 RID: 8217
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000247 RID: 583
		public sealed class MidiInProc : MulticastDelegate
		{
			// Token: 0x06002002 RID: 8194 RVA: 0x0008CDE8 File Offset: 0x0008AFE8
			// Note: this type is marked as 'beforefieldinit'.
			static MidiInProc()
			{
				Il2CppClassPointerStore<InputDevice.MidiInProc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "MidiInProc");
				InputDevice.MidiInProc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.MidiInProc>.NativeClassPtr, 100666031);
				InputDevice.MidiInProc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.MidiInProc>.NativeClassPtr, 100666032);
				InputDevice.MidiInProc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.MidiInProc>.NativeClassPtr, 100666033);
				InputDevice.MidiInProc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.MidiInProc>.NativeClassPtr, 100666034);
			}

			// Token: 0x06002003 RID: 8195 RVA: 0x0008CE5C File Offset: 0x0008B05C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MidiInProc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.MidiInProc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.MidiInProc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002004 RID: 8196 RVA: 0x0008CEB8 File Offset: 0x0008B0B8
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr handle, int msg, IntPtr instance, IntPtr param1, IntPtr param2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.MidiInProc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002005 RID: 8197 RVA: 0x0008CF30 File Offset: 0x0008B130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14953, XrefRangeEnd = 14966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr handle, int msg, IntPtr instance, IntPtr param1, IntPtr param2, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.MidiInProc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002006 RID: 8198 RVA: 0x0008CFDC File Offset: 0x0008B1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.MidiInProc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002007 RID: 8199 RVA: 0x0000BB2A File Offset: 0x00009D2A
			public MidiInProc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002008 RID: 8200 RVA: 0x0000BB33 File Offset: 0x00009D33
			public static implicit operator InputDevice.MidiInProc(Action<IntPtr, int, IntPtr, IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<InputDevice.MidiInProc>(A_0);
			}

			// Token: 0x06002009 RID: 8201 RVA: 0x0000BB3B File Offset: 0x00009D3B
			public static InputDevice.MidiInProc operator +(InputDevice.MidiInProc A_0, InputDevice.MidiInProc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<InputDevice.MidiInProc>();
			}

			// Token: 0x0600200A RID: 8202 RVA: 0x0000BB49 File Offset: 0x00009D49
			public static InputDevice.MidiInProc operator -(InputDevice.MidiInProc A_0, InputDevice.MidiInProc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<InputDevice.MidiInProc>();
				}
				return delegate2;
			}

			// Token: 0x0400201A RID: 8218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400201B RID: 8219
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0;

			// Token: 0x0400201C RID: 8220
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0;

			// Token: 0x0400201D RID: 8221
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000248 RID: 584
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x0600200B RID: 8203 RVA: 0x0008D020 File Offset: 0x0008B220
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr, 100666035);
				InputDevice.__c__DisplayClass30_0.NativeMethodInfoPtr__OnShortMessage_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr, 100666036);
			}

			// Token: 0x0600200C RID: 8204 RVA: 0x0008D0B0 File Offset: 0x0008B2B0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600200D RID: 8205 RVA: 0x0008D0EC File Offset: 0x0008B2EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14966, XrefRangeEnd = 14970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShortMessage_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass30_0.NativeMethodInfoPtr__OnShortMessage_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600200E RID: 8206 RVA: 0x0000BB5A File Offset: 0x00009D5A
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x0008D130 File Offset: 0x0008B330
			// (set) Token: 0x06002010 RID: 8208 RVA: 0x0000BB63 File Offset: 0x00009D63
			public unsafe EventHandler<ShortMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ShortMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06002011 RID: 8209 RVA: 0x0008D160 File Offset: 0x0008B360
			// (set) Token: 0x06002012 RID: 8210 RVA: 0x0000BB82 File Offset: 0x00009D82
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06002013 RID: 8211 RVA: 0x0008D190 File Offset: 0x0008B390
			// (set) Token: 0x06002014 RID: 8212 RVA: 0x0000BBA1 File Offset: 0x00009DA1
			public unsafe ShortMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShortMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass30_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400201E RID: 8222
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x0400201F RID: 8223
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002020 RID: 8224
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04002021 RID: 8225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002022 RID: 8226
			private static readonly IntPtr NativeMethodInfoPtr__OnShortMessage_b__0_Internal_Void_Object_0;
		}

		// Token: 0x02000249 RID: 585
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Object
		{
			// Token: 0x06002015 RID: 8213 RVA: 0x0008D1C0 File Offset: 0x0008B3C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass31_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass31_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr, "message");
				InputDevice.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr, 100666037);
				InputDevice.__c__DisplayClass31_0.NativeMethodInfoPtr__OnMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr, 100666038);
			}

			// Token: 0x06002016 RID: 8214 RVA: 0x0008D23C File Offset: 0x0008B43C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002017 RID: 8215 RVA: 0x0008D278 File Offset: 0x0008B478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14970, XrefRangeEnd = 14972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass31_0.NativeMethodInfoPtr__OnMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002018 RID: 8216 RVA: 0x0000BBC0 File Offset: 0x00009DC0
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06002019 RID: 8217 RVA: 0x0008D2BC File Offset: 0x0008B4BC
			// (set) Token: 0x0600201A RID: 8218 RVA: 0x0000BBC9 File Offset: 0x00009DC9
			public unsafe MidiMessageEventHandler handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass31_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiMessageEventHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass31_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x0600201B RID: 8219 RVA: 0x0008D2EC File Offset: 0x0008B4EC
			// (set) Token: 0x0600201C RID: 8220 RVA: 0x0000BBE8 File Offset: 0x00009DE8
			public unsafe IMidiMessage message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass31_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMidiMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass31_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002023 RID: 8227
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04002024 RID: 8228
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04002025 RID: 8229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002026 RID: 8230
			private static readonly IntPtr NativeMethodInfoPtr__OnMessageReceived_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200024A RID: 586
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Object
		{
			// Token: 0x0600201D RID: 8221 RVA: 0x0008D31C File Offset: 0x0008B51C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr, 100666039);
				InputDevice.__c__DisplayClass32_0.NativeMethodInfoPtr__OnChannelMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr, 100666040);
			}

			// Token: 0x0600201E RID: 8222 RVA: 0x0008D3AC File Offset: 0x0008B5AC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600201F RID: 8223 RVA: 0x0008D3E8 File Offset: 0x0008B5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14972, XrefRangeEnd = 14976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnChannelMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass32_0.NativeMethodInfoPtr__OnChannelMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002020 RID: 8224 RVA: 0x0000BC07 File Offset: 0x00009E07
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06002021 RID: 8225 RVA: 0x0008D42C File Offset: 0x0008B62C
			// (set) Token: 0x06002022 RID: 8226 RVA: 0x0000BC10 File Offset: 0x00009E10
			public unsafe EventHandler<ChannelMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ChannelMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06002023 RID: 8227 RVA: 0x0008D45C File Offset: 0x0008B65C
			// (set) Token: 0x06002024 RID: 8228 RVA: 0x0000BC2F File Offset: 0x00009E2F
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06002025 RID: 8229 RVA: 0x0008D48C File Offset: 0x0008B68C
			// (set) Token: 0x06002026 RID: 8230 RVA: 0x0000BC4E File Offset: 0x00009E4E
			public unsafe ChannelMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass32_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002027 RID: 8231
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04002028 RID: 8232
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002029 RID: 8233
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x0400202A RID: 8234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400202B RID: 8235
			private static readonly IntPtr NativeMethodInfoPtr__OnChannelMessageReceived_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200024B RID: 587
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Object
		{
			// Token: 0x06002027 RID: 8231 RVA: 0x0008D4BC File Offset: 0x0008B6BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr, 100666041);
				InputDevice.__c__DisplayClass33_0.NativeMethodInfoPtr__OnSysExMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr, 100666042);
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x0008D54C File Offset: 0x0008B74C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002029 RID: 8233 RVA: 0x0008D588 File Offset: 0x0008B788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14976, XrefRangeEnd = 14980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSysExMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass33_0.NativeMethodInfoPtr__OnSysExMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600202A RID: 8234 RVA: 0x0000BC6D File Offset: 0x00009E6D
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x0600202B RID: 8235 RVA: 0x0008D5CC File Offset: 0x0008B7CC
			// (set) Token: 0x0600202C RID: 8236 RVA: 0x0000BC76 File Offset: 0x00009E76
			public unsafe EventHandler<SysExMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysExMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x0600202D RID: 8237 RVA: 0x0008D5FC File Offset: 0x0008B7FC
			// (set) Token: 0x0600202E RID: 8238 RVA: 0x0000BC95 File Offset: 0x00009E95
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x0600202F RID: 8239 RVA: 0x0008D62C File Offset: 0x0008B82C
			// (set) Token: 0x06002030 RID: 8240 RVA: 0x0000BCB4 File Offset: 0x00009EB4
			public unsafe SysExMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysExMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass33_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400202C RID: 8236
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x0400202D RID: 8237
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400202E RID: 8238
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x0400202F RID: 8239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002030 RID: 8240
			private static readonly IntPtr NativeMethodInfoPtr__OnSysExMessageReceived_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200024C RID: 588
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Object
		{
			// Token: 0x06002031 RID: 8241 RVA: 0x0008D65C File Offset: 0x0008B85C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr, 100666043);
				InputDevice.__c__DisplayClass34_0.NativeMethodInfoPtr__OnSysCommonMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr, 100666044);
			}

			// Token: 0x06002032 RID: 8242 RVA: 0x0008D6EC File Offset: 0x0008B8EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002033 RID: 8243 RVA: 0x0008D728 File Offset: 0x0008B928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14980, XrefRangeEnd = 14984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSysCommonMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass34_0.NativeMethodInfoPtr__OnSysCommonMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002034 RID: 8244 RVA: 0x0000BCD3 File Offset: 0x00009ED3
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x06002035 RID: 8245 RVA: 0x0008D76C File Offset: 0x0008B96C
			// (set) Token: 0x06002036 RID: 8246 RVA: 0x0000BCDC File Offset: 0x00009EDC
			public unsafe EventHandler<SysCommonMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysCommonMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x06002037 RID: 8247 RVA: 0x0008D79C File Offset: 0x0008B99C
			// (set) Token: 0x06002038 RID: 8248 RVA: 0x0000BCFB File Offset: 0x00009EFB
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06002039 RID: 8249 RVA: 0x0008D7CC File Offset: 0x0008B9CC
			// (set) Token: 0x0600203A RID: 8250 RVA: 0x0000BD1A File Offset: 0x00009F1A
			public unsafe SysCommonMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysCommonMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass34_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002031 RID: 8241
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04002032 RID: 8242
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002033 RID: 8243
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04002034 RID: 8244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002035 RID: 8245
			private static readonly IntPtr NativeMethodInfoPtr__OnSysCommonMessageReceived_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200024D RID: 589
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Object
		{
			// Token: 0x0600203B RID: 8251 RVA: 0x0008D7FC File Offset: 0x0008B9FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr, 100666045);
				InputDevice.__c__DisplayClass35_0.NativeMethodInfoPtr__OnSysRealtimeMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr, 100666046);
			}

			// Token: 0x0600203C RID: 8252 RVA: 0x0008D88C File Offset: 0x0008BA8C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600203D RID: 8253 RVA: 0x0008D8C8 File Offset: 0x0008BAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14984, XrefRangeEnd = 14988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSysRealtimeMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass35_0.NativeMethodInfoPtr__OnSysRealtimeMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600203E RID: 8254 RVA: 0x0000BD39 File Offset: 0x00009F39
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x0600203F RID: 8255 RVA: 0x0008D90C File Offset: 0x0008BB0C
			// (set) Token: 0x06002040 RID: 8256 RVA: 0x0000BD42 File Offset: 0x00009F42
			public unsafe EventHandler<SysRealtimeMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysRealtimeMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x06002041 RID: 8257 RVA: 0x0008D93C File Offset: 0x0008BB3C
			// (set) Token: 0x06002042 RID: 8258 RVA: 0x0000BD61 File Offset: 0x00009F61
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x06002043 RID: 8259 RVA: 0x0008D96C File Offset: 0x0008BB6C
			// (set) Token: 0x06002044 RID: 8260 RVA: 0x0000BD80 File Offset: 0x00009F80
			public unsafe SysRealtimeMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SysRealtimeMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass35_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002036 RID: 8246
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04002037 RID: 8247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002038 RID: 8248
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04002039 RID: 8249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400203A RID: 8250
			private static readonly IntPtr NativeMethodInfoPtr__OnSysRealtimeMessageReceived_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200024E RID: 590
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Object
		{
			// Token: 0x06002045 RID: 8261 RVA: 0x0008D99C File Offset: 0x0008BB9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr, 100666047);
				InputDevice.__c__DisplayClass36_0.NativeMethodInfoPtr__OnInvalidShortMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr, 100666048);
			}

			// Token: 0x06002046 RID: 8262 RVA: 0x0008DA2C File Offset: 0x0008BC2C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002047 RID: 8263 RVA: 0x0008DA68 File Offset: 0x0008BC68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14988, XrefRangeEnd = 14992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInvalidShortMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass36_0.NativeMethodInfoPtr__OnInvalidShortMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002048 RID: 8264 RVA: 0x0000BD9F File Offset: 0x00009F9F
			public __c__DisplayClass36_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008DAAC File Offset: 0x0008BCAC
			// (set) Token: 0x0600204A RID: 8266 RVA: 0x0000BDA8 File Offset: 0x00009FA8
			public unsafe EventHandler<InvalidShortMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvalidShortMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x0600204B RID: 8267 RVA: 0x0008DADC File Offset: 0x0008BCDC
			// (set) Token: 0x0600204C RID: 8268 RVA: 0x0000BDC7 File Offset: 0x00009FC7
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x0600204D RID: 8269 RVA: 0x0008DB0C File Offset: 0x0008BD0C
			// (set) Token: 0x0600204E RID: 8270 RVA: 0x0000BDE6 File Offset: 0x00009FE6
			public unsafe InvalidShortMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvalidShortMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass36_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400203B RID: 8251
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x0400203C RID: 8252
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400203D RID: 8253
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x0400203E RID: 8254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400203F RID: 8255
			private static readonly IntPtr NativeMethodInfoPtr__OnInvalidShortMessageReceived_b__0_Internal_Void_Object_0;
		}

		// Token: 0x0200024F RID: 591
		[ObfuscatedName("Sanford.Multimedia.Midi.InputDevice+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Object
		{
			// Token: 0x0600204F RID: 8271 RVA: 0x0008DB3C File Offset: 0x0008BD3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr);
				InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr, "handler");
				InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr, "e");
				InputDevice.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr, 100666049);
				InputDevice.__c__DisplayClass37_0.NativeMethodInfoPtr__OnInvalidSysExMessageReceived_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr, 100666050);
			}

			// Token: 0x06002050 RID: 8272 RVA: 0x0008DBCC File Offset: 0x0008BDCC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002051 RID: 8273 RVA: 0x0008DC08 File Offset: 0x0008BE08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14992, XrefRangeEnd = 14996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInvalidSysExMessageReceived_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.__c__DisplayClass37_0.NativeMethodInfoPtr__OnInvalidSysExMessageReceived_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002052 RID: 8274 RVA: 0x0000BE05 File Offset: 0x0000A005
			public __c__DisplayClass37_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x06002053 RID: 8275 RVA: 0x0008DC4C File Offset: 0x0008BE4C
			// (set) Token: 0x06002054 RID: 8276 RVA: 0x0000BE0E File Offset: 0x0000A00E
			public unsafe EventHandler<InvalidSysExMessageEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<InvalidSysExMessageEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x06002055 RID: 8277 RVA: 0x0008DC7C File Offset: 0x0008BE7C
			// (set) Token: 0x06002056 RID: 8278 RVA: 0x0000BE2D File Offset: 0x0000A02D
			public unsafe InputDevice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x06002057 RID: 8279 RVA: 0x0008DCAC File Offset: 0x0008BEAC
			// (set) Token: 0x06002058 RID: 8280 RVA: 0x0000BE4C File Offset: 0x0000A04C
			public unsafe InvalidSysExMessageEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvalidSysExMessageEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.__c__DisplayClass37_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002040 RID: 8256
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04002041 RID: 8257
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002042 RID: 8258
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04002043 RID: 8259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002044 RID: 8260
			private static readonly IntPtr NativeMethodInfoPtr__OnInvalidSysExMessageReceived_b__0_Internal_Void_Object_0;
		}
	}
}
