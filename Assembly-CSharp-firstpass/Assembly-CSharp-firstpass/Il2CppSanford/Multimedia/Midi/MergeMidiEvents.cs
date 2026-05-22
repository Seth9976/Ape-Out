using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001BB RID: 443
	public class MergeMidiEvents : Object
	{
		// Token: 0x0600155D RID: 5469 RVA: 0x00061C88 File Offset: 0x0005FE88
		// Note: this type is marked as 'beforefieldinit'.
		static MergeMidiEvents()
		{
			Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MergeMidiEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr);
			MergeMidiEvents.NativeFieldInfoPtr_FMidiEventsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, "FMidiEventsList");
			MergeMidiEvents.NativeMethodInfoPtr_get_DeviceID_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666326);
			MergeMidiEvents.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_MidiEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666327);
			MergeMidiEvents.NativeMethodInfoPtr_get_EventSources_Public_get_IEnumerable_1_MidiEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666328);
			MergeMidiEvents.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666329);
			MergeMidiEvents.NativeMethodInfoPtr_add_MessageReceived_Public_Virtual_Final_New_add_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666330);
			MergeMidiEvents.NativeMethodInfoPtr_remove_MessageReceived_Public_Virtual_Final_New_rem_Void_MidiMessageEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666331);
			MergeMidiEvents.NativeMethodInfoPtr_add_ShortMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666332);
			MergeMidiEvents.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666333);
			MergeMidiEvents.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666334);
			MergeMidiEvents.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666335);
			MergeMidiEvents.NativeMethodInfoPtr_add_SysExMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666336);
			MergeMidiEvents.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666337);
			MergeMidiEvents.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666338);
			MergeMidiEvents.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666339);
			MergeMidiEvents.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666340);
			MergeMidiEvents.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr, 100666341);
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00061E0C File Offset: 0x0006000C
		public unsafe virtual int DeviceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_get_DeviceID_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00061E48 File Offset: 0x00060048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16566, XrefRangeEnd = 16590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MergeMidiEvents(IEnumerable<MidiEvents> midiEvents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MergeMidiEvents>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midiEvents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_MidiEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00061E94 File Offset: 0x00060094
		public unsafe IEnumerable<MidiEvents> EventSources
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_get_EventSources_Public_get_IEnumerable_1_MidiEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MidiEvents>>(intPtr3) : null;
			}
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00061ED4 File Offset: 0x000600D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00061F08 File Offset: 0x00060108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16590, XrefRangeEnd = 16602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_add_MessageReceived_Public_Virtual_Final_New_add_Void_MidiMessageEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00061F4C File Offset: 0x0006014C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16602, XrefRangeEnd = 16614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_MessageReceived(MidiMessageEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_remove_MessageReceived_Public_Virtual_Final_New_rem_Void_MidiMessageEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00061F90 File Offset: 0x00060190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16614, XrefRangeEnd = 16626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_add_ShortMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00061FD4 File Offset: 0x000601D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16626, XrefRangeEnd = 16638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ShortMessageReceived(EventHandler<ShortMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00062018 File Offset: 0x00060218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16638, XrefRangeEnd = 16650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0006205C File Offset: 0x0006025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16650, XrefRangeEnd = 16662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ChannelMessageReceived(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000620A0 File Offset: 0x000602A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16662, XrefRangeEnd = 16674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_add_SysExMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000620E4 File Offset: 0x000602E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16674, XrefRangeEnd = 16686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_SysExMessageReceived(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00062128 File Offset: 0x00060328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16686, XrefRangeEnd = 16698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0006216C File Offset: 0x0006036C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16698, XrefRangeEnd = 16710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_SysCommonMessageReceived(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000621B0 File Offset: 0x000603B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16710, XrefRangeEnd = 16722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000621F4 File Offset: 0x000603F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16722, XrefRangeEnd = 16734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_SysRealtimeMessageReceived(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeMidiEvents.NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00008A82 File Offset: 0x00006C82
		public MergeMidiEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00062238 File Offset: 0x00060438
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00008A8B File Offset: 0x00006C8B
		public unsafe List<MidiEvents> FMidiEventsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MergeMidiEvents.NativeFieldInfoPtr_FMidiEventsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MidiEvents>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MergeMidiEvents.NativeFieldInfoPtr_FMidiEventsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeFieldInfoPtr_FMidiEventsList;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceID_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_MidiEvents_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_get_EventSources_Public_get_IEnumerable_1_MidiEvents_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_add_MessageReceived_Public_Virtual_Final_New_add_Void_MidiMessageEventHandler_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_remove_MessageReceived_Public_Virtual_Final_New_rem_Void_MidiMessageEventHandler_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_add_ShortMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_remove_ShortMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ShortMessageEventArgs_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_add_ChannelMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChannelMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_add_SysExMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysExMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_add_SysCommonMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysCommonMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_add_SysRealtimeMessageReceived_Public_Virtual_Final_New_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysRealtimeMessageReceived_Public_Virtual_Final_New_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;
	}
}
