using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C8 RID: 456
	public class ChannelStopper : Object
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x0006491C File Offset: 0x00062B1C
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelStopper()
		{
			Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ChannelStopper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr);
			ChannelStopper.NativeFieldInfoPtr_noteOnMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, "noteOnMessage");
			ChannelStopper.NativeFieldInfoPtr_holdPedal1Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, "holdPedal1Message");
			ChannelStopper.NativeFieldInfoPtr_holdPedal2Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, "holdPedal2Message");
			ChannelStopper.NativeFieldInfoPtr_sustenutoMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, "sustenutoMessage");
			ChannelStopper.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, "builder");
			ChannelStopper.NativeFieldInfoPtr_Stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, "Stopped");
			ChannelStopper.NativeMethodInfoPtr_add_Stopped_Public_add_Void_EventHandler_1_StoppedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666428);
			ChannelStopper.NativeMethodInfoPtr_remove_Stopped_Public_rem_Void_EventHandler_1_StoppedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666429);
			ChannelStopper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666430);
			ChannelStopper.NativeMethodInfoPtr_Process_Public_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666431);
			ChannelStopper.NativeMethodInfoPtr_AllSoundOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666432);
			ChannelStopper.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666433);
			ChannelStopper.NativeMethodInfoPtr_OnStopped_Protected_Virtual_New_Void_StoppedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr, 100666434);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00064A50 File Offset: 0x00062C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17015, XrefRangeEnd = 17018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Stopped(EventHandler<StoppedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelStopper.NativeMethodInfoPtr_add_Stopped_Public_add_Void_EventHandler_1_StoppedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00064A94 File Offset: 0x00062C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17018, XrefRangeEnd = 17021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Stopped(EventHandler<StoppedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelStopper.NativeMethodInfoPtr_remove_Stopped_Public_rem_Void_EventHandler_1_StoppedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00064AD8 File Offset: 0x00062CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17034, RefRangeEnd = 17035, XrefRangeStart = 17021, XrefRangeEnd = 17034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelStopper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelStopper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelStopper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00064B14 File Offset: 0x00062D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17036, RefRangeEnd = 17037, XrefRangeStart = 17035, XrefRangeEnd = 17036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelStopper.NativeMethodInfoPtr_Process_Public_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00064B58 File Offset: 0x00062D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17072, RefRangeEnd = 17073, XrefRangeStart = 17037, XrefRangeEnd = 17072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllSoundOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelStopper.NativeMethodInfoPtr_AllSoundOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00064B8C File Offset: 0x00062D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17073, XrefRangeEnd = 17074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelStopper.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00064BC0 File Offset: 0x00062DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17074, XrefRangeEnd = 17077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStopped(StoppedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChannelStopper.NativeMethodInfoPtr_OnStopped_Protected_Virtual_New_Void_StoppedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00008DD4 File Offset: 0x00006FD4
		public ChannelStopper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x00064C10 File Offset: 0x00062E10
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x00008DDD File Offset: 0x00006FDD
		public unsafe Il2CppObjectBase noteOnMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_noteOnMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_noteOnMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00064C40 File Offset: 0x00062E40
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x00008DFC File Offset: 0x00006FFC
		public unsafe Il2CppStructArray<bool> holdPedal1Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_holdPedal1Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_holdPedal1Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00064C70 File Offset: 0x00062E70
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x00008E1B File Offset: 0x0000701B
		public unsafe Il2CppStructArray<bool> holdPedal2Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_holdPedal2Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_holdPedal2Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00064CA0 File Offset: 0x00062EA0
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00008E3A File Offset: 0x0000703A
		public unsafe Il2CppStructArray<bool> sustenutoMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_sustenutoMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_sustenutoMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00064CD0 File Offset: 0x00062ED0
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x00008E59 File Offset: 0x00007059
		public unsafe ChannelMessageBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelMessageBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00064D00 File Offset: 0x00062F00
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00008E78 File Offset: 0x00007078
		public unsafe EventHandler<StoppedEventArgs> Stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_Stopped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<StoppedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelStopper.NativeFieldInfoPtr_Stopped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_noteOnMessage;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_holdPedal1Message;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_holdPedal2Message;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_sustenutoMessage;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_Stopped;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_add_Stopped_Public_add_Void_EventHandler_1_StoppedEventArgs_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_remove_Stopped_Public_rem_Void_EventHandler_1_StoppedEventArgs_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_ChannelMessage_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_AllSoundOff_Public_Void_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_OnStopped_Protected_Virtual_New_Void_StoppedEventArgs_0;
	}
}
