using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001BD RID: 445
	public class OutputDeviceEventSink : Object
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x0006279C File Offset: 0x0006099C
		// Note: this type is marked as 'beforefieldinit'.
		static OutputDeviceEventSink()
		{
			Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "OutputDeviceEventSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr);
			OutputDeviceEventSink.NativeFieldInfoPtr_FOutDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, "FOutDevice");
			OutputDeviceEventSink.NativeFieldInfoPtr_FEventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, "FEventSource");
			OutputDeviceEventSink.NativeMethodInfoPtr_get_DeviceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666355);
			OutputDeviceEventSink.NativeMethodInfoPtr__ctor_Public_Void_OutputDevice_MidiEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666356);
			OutputDeviceEventSink.NativeMethodInfoPtr_RegisterEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666357);
			OutputDeviceEventSink.NativeMethodInfoPtr_UnRegisterEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666358);
			OutputDeviceEventSink.NativeMethodInfoPtr_FEventSource_MessageReceived_Private_Void_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666359);
			OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_SysRealtimeMessageReceived_Private_Void_Object_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666360);
			OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_SysExMessageReceived_Private_Void_Object_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666361);
			OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_SysCommonMessageReceived_Private_Void_Object_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666362);
			OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_ChannelMessageReceived_Private_Void_Object_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666363);
			OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_RawMessageReceived_Private_Void_Object_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666364);
			OutputDeviceEventSink.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666365);
			OutputDeviceEventSink.NativeMethodInfoPtr_FromDeviceID_Public_Static_OutputDeviceEventSink_Int32_MidiEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr, 100666366);
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000628E4 File Offset: 0x00060AE4
		public unsafe int DeviceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_get_DeviceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00062920 File Offset: 0x00060B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16734, XrefRangeEnd = 16735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputDeviceEventSink(OutputDevice outDevice, MidiEvents eventSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputDeviceEventSink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outDevice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr__ctor_Public_Void_OutputDevice_MidiEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00062980 File Offset: 0x00060B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16778, RefRangeEnd = 16779, XrefRangeStart = 16735, XrefRangeEnd = 16778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_RegisterEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000629B4 File Offset: 0x00060BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16822, RefRangeEnd = 16823, XrefRangeStart = 16779, XrefRangeEnd = 16822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_UnRegisterEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000629E8 File Offset: 0x00060BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16823, XrefRangeEnd = 16826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FEventSource_MessageReceived(IMidiMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_FEventSource_MessageReceived_Private_Void_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00062A2C File Offset: 0x00060C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16826, XrefRangeEnd = 16827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EventSource_SysRealtimeMessageReceived(Object sender, SysRealtimeMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_SysRealtimeMessageReceived_Private_Void_Object_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00062A80 File Offset: 0x00060C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16827, XrefRangeEnd = 16828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EventSource_SysExMessageReceived(Object sender, SysExMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_SysExMessageReceived_Private_Void_Object_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00062AD4 File Offset: 0x00060CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16828, XrefRangeEnd = 16829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EventSource_SysCommonMessageReceived(Object sender, SysCommonMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_SysCommonMessageReceived_Private_Void_Object_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00062B28 File Offset: 0x00060D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16829, XrefRangeEnd = 16830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EventSource_ChannelMessageReceived(Object sender, ChannelMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_ChannelMessageReceived_Private_Void_Object_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00062B7C File Offset: 0x00060D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16830, XrefRangeEnd = 16831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EventSource_RawMessageReceived(Object sender, ShortMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_EventSource_RawMessageReceived_Private_Void_Object_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00062BD0 File Offset: 0x00060DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16831, XrefRangeEnd = 16833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00062C04 File Offset: 0x00060E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16833, XrefRangeEnd = 16837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OutputDeviceEventSink FromDeviceID(int deviceID, MidiEvents eventSource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceEventSink.NativeMethodInfoPtr_FromDeviceID_Public_Static_OutputDeviceEventSink_Int32_MidiEvents_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutputDeviceEventSink>(intPtr3) : null;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00008AB3 File Offset: 0x00006CB3
		public OutputDeviceEventSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00062C58 File Offset: 0x00060E58
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00008ABC File Offset: 0x00006CBC
		public unsafe OutputDevice FOutDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceEventSink.NativeFieldInfoPtr_FOutDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceEventSink.NativeFieldInfoPtr_FOutDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00062C88 File Offset: 0x00060E88
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00008ADB File Offset: 0x00006CDB
		public unsafe MidiEvents FEventSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceEventSink.NativeFieldInfoPtr_FEventSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceEventSink.NativeFieldInfoPtr_FEventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_FOutDevice;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeFieldInfoPtr_FEventSource;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceID_Public_get_Int32_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OutputDevice_MidiEvents_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEvents_Private_Void_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterEvents_Private_Void_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_FEventSource_MessageReceived_Private_Void_IMidiMessage_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_EventSource_SysRealtimeMessageReceived_Private_Void_Object_SysRealtimeMessageEventArgs_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_EventSource_SysExMessageReceived_Private_Void_Object_SysExMessageEventArgs_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_EventSource_SysCommonMessageReceived_Private_Void_Object_SysCommonMessageEventArgs_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_EventSource_ChannelMessageReceived_Private_Void_Object_ChannelMessageEventArgs_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_EventSource_RawMessageReceived_Private_Void_Object_ShortMessageEventArgs_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_FromDeviceID_Public_Static_OutputDeviceEventSink_Int32_MidiEvents_0;
	}
}
