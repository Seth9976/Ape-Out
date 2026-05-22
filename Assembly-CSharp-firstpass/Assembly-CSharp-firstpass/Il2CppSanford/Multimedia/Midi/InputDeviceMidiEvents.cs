using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001BA RID: 442
	public class InputDeviceMidiEvents : Object
	{
		// Token: 0x06001549 RID: 5449 RVA: 0x000616A8 File Offset: 0x0005F8A8
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceMidiEvents()
		{
			Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "InputDeviceMidiEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr);
			InputDeviceMidiEvents.NativeFieldInfoPtr_FInDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, "FInDevice");
			InputDeviceMidiEvents.NativeMethodInfoPtr_get_DeviceID_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666310);
			InputDeviceMidiEvents.NativeMethodInfoPtr__ctor_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666311);
			InputDeviceMidiEvents.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666312);
			InputDeviceMidiEvents.NativeMethodInfoPtr_FromDeviceID_Public_Static_InputDeviceMidiEvents_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666313);
			InputDeviceMidiEvents.NativeMethodInfoPtr_add_MessageReceived_Public_Virtual_Final_New_add_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666314);
			InputDeviceMidiEvents.NativeMethodInfoPtr_remove_MessageReceived_Public_Virtual_Final_New_rem_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666315);
			InputDeviceMidiEvents.NativeMethodInfoPtr_add_ShortMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666316);
			InputDeviceMidiEvents.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666317);
			InputDeviceMidiEvents.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666318);
			InputDeviceMidiEvents.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666319);
			InputDeviceMidiEvents.NativeMethodInfoPtr_add_SysExMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666320);
			InputDeviceMidiEvents.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666321);
			InputDeviceMidiEvents.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666322);
			InputDeviceMidiEvents.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666323);
			InputDeviceMidiEvents.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666324);
			InputDeviceMidiEvents.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr, 100666325);
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0006182C File Offset: 0x0005FA2C
		public unsafe virtual int DeviceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_get_DeviceID_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00061868 File Offset: 0x0005FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16523, XrefRangeEnd = 16525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceMidiEvents(InputDevice inDevice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceMidiEvents>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr__ctor_Public_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000618B4 File Offset: 0x0005FAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16525, XrefRangeEnd = 16526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000618E8 File Offset: 0x0005FAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16526, XrefRangeEnd = 16530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDeviceMidiEvents FromDeviceID(int deviceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_FromDeviceID_Public_Static_InputDeviceMidiEvents_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceMidiEvents>(intPtr3) : null;
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00061928 File Offset: 0x0005FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16530, XrefRangeEnd = 16533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_add_MessageReceived_Public_Virtual_Final_New_add_Void_MidiMessageEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0006196C File Offset: 0x0005FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16533, XrefRangeEnd = 16536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_remove_MessageReceived_Public_Virtual_Final_New_rem_Void_MidiMessageEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000619B0 File Offset: 0x0005FBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16536, XrefRangeEnd = 16539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_add_ShortMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000619F4 File Offset: 0x0005FBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16539, XrefRangeEnd = 16542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00061A38 File Offset: 0x0005FC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16542, XrefRangeEnd = 16545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00061A7C File Offset: 0x0005FC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16545, XrefRangeEnd = 16548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00061AC0 File Offset: 0x0005FCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16548, XrefRangeEnd = 16551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_add_SysExMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00061B04 File Offset: 0x0005FD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16551, XrefRangeEnd = 16554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00061B48 File Offset: 0x0005FD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16554, XrefRangeEnd = 16557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00061B8C File Offset: 0x0005FD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16557, XrefRangeEnd = 16560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00061BD0 File Offset: 0x0005FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16560, XrefRangeEnd = 16563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00061C14 File Offset: 0x0005FE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16563, XrefRangeEnd = 16566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMidiEvents.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00008A5A File Offset: 0x00006C5A
		public InputDeviceMidiEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x00061C58 File Offset: 0x0005FE58
		// (set) Token: 0x0600155C RID: 5468 RVA: 0x00008A63 File Offset: 0x00006C63
		public unsafe InputDevice FInDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMidiEvents.NativeFieldInfoPtr_FInDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMidiEvents.NativeFieldInfoPtr_FInDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_FInDevice;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceID_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputDevice_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_FromDeviceID_Public_Static_InputDeviceMidiEvents_Int32_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_add_MessageReceived_Public_Virtual_Final_New_add_Void_MidiMessageEventHandler_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_remove_MessageReceived_Public_Virtual_Final_New_rem_Void_MidiMessageEventHandler_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_add_ShortMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_add_SysExMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;
	}
}
