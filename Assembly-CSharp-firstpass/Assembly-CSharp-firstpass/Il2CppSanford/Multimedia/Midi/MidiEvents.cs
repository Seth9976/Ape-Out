using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001BC RID: 444
	public class MidiEvents : Il2CppObjectBase
	{
		// Token: 0x06001571 RID: 5489 RVA: 0x00062268 File Offset: 0x00060468
		// Note: this type is marked as 'beforefieldinit'.
		static MidiEvents()
		{
			Il2CppClassPointerStore<MidiEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiEvents");
			MidiEvents.NativeMethodInfoPtr_get_DeviceID_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666342);
			MidiEvents.NativeMethodInfoPtr_add_MessageReceived_Public_Abstract_Virtual_New_add_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666343);
			MidiEvents.NativeMethodInfoPtr_remove_MessageReceived_Public_Abstract_Virtual_New_rem_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666344);
			MidiEvents.NativeMethodInfoPtr_add_ShortMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666345);
			MidiEvents.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666346);
			MidiEvents.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666347);
			MidiEvents.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666348);
			MidiEvents.NativeMethodInfoPtr_add_SysExMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666349);
			MidiEvents.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666350);
			MidiEvents.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666351);
			MidiEvents.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666352);
			MidiEvents.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666353);
			MidiEvents.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiEvents>.NativeClassPtr, 100666354);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00062394 File Offset: 0x00060594
		public unsafe virtual int DeviceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_get_DeviceID_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000623DC File Offset: 0x000605DC
		[CallerCount(0)]
		public unsafe virtual void add_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_add_MessageReceived_Public_Abstract_Virtual_New_add_Void_MidiMessageEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0006242C File Offset: 0x0006062C
		[CallerCount(0)]
		public unsafe virtual void remove_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_remove_MessageReceived_Public_Abstract_Virtual_New_rem_Void_MidiMessageEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0006247C File Offset: 0x0006067C
		[CallerCount(0)]
		public unsafe virtual void add_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_add_ShortMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_ShortMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000624CC File Offset: 0x000606CC
		[CallerCount(0)]
		public unsafe virtual void remove_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0006251C File Offset: 0x0006071C
		[CallerCount(0)]
		public unsafe virtual void add_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0006256C File Offset: 0x0006076C
		[CallerCount(0)]
		public unsafe virtual void remove_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000625BC File Offset: 0x000607BC
		[CallerCount(0)]
		public unsafe virtual void add_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_add_SysExMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysExMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0006260C File Offset: 0x0006080C
		[CallerCount(0)]
		public unsafe virtual void remove_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0006265C File Offset: 0x0006085C
		[CallerCount(0)]
		public unsafe virtual void add_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000626AC File Offset: 0x000608AC
		[CallerCount(0)]
		public unsafe virtual void remove_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000626FC File Offset: 0x000608FC
		[CallerCount(0)]
		public unsafe virtual void add_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0006274C File Offset: 0x0006094C
		[CallerCount(0)]
		public unsafe virtual void remove_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiEvents.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00008AAA File Offset: 0x00006CAA
		public MidiEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceID_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_add_MessageReceived_Public_Abstract_Virtual_New_add_Void_MidiMessageEventHandler_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_remove_MessageReceived_Public_Abstract_Virtual_New_rem_Void_MidiMessageEventHandler_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_add_ShortMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_add_SysExMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Abstract_Virtual_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Abstract_Virtual_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;
	}
}
