using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B7 RID: 439
	public class MessageDispatcher : Object
	{
		// Token: 0x0600150D RID: 5389 RVA: 0x00060934 File Offset: 0x0005EB34
		// Note: this type is marked as 'beforefieldinit'.
		static MessageDispatcher()
		{
			Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MessageDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr);
			MessageDispatcher.NativeFieldInfoPtr_ChannelMessageDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, "ChannelMessageDispatched");
			MessageDispatcher.NativeFieldInfoPtr_SysExMessageDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, "SysExMessageDispatched");
			MessageDispatcher.NativeFieldInfoPtr_SysCommonMessageDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, "SysCommonMessageDispatched");
			MessageDispatcher.NativeFieldInfoPtr_SysRealtimeMessageDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, "SysRealtimeMessageDispatched");
			MessageDispatcher.NativeFieldInfoPtr_MetaMessageDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, "MetaMessageDispatched");
			MessageDispatcher.NativeMethodInfoPtr_add_ChannelMessageDispatched_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666281);
			MessageDispatcher.NativeMethodInfoPtr_remove_ChannelMessageDispatched_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666282);
			MessageDispatcher.NativeMethodInfoPtr_add_SysExMessageDispatched_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666283);
			MessageDispatcher.NativeMethodInfoPtr_remove_SysExMessageDispatched_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666284);
			MessageDispatcher.NativeMethodInfoPtr_add_SysCommonMessageDispatched_Public_add_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666285);
			MessageDispatcher.NativeMethodInfoPtr_remove_SysCommonMessageDispatched_Public_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666286);
			MessageDispatcher.NativeMethodInfoPtr_add_SysRealtimeMessageDispatched_Public_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666287);
			MessageDispatcher.NativeMethodInfoPtr_remove_SysRealtimeMessageDispatched_Public_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666288);
			MessageDispatcher.NativeMethodInfoPtr_add_MetaMessageDispatched_Public_add_Void_EventHandler_1_MetaMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666289);
			MessageDispatcher.NativeMethodInfoPtr_remove_MetaMessageDispatched_Public_rem_Void_EventHandler_1_MetaMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666290);
			MessageDispatcher.NativeMethodInfoPtr_Dispatch_Public_Void_IMidiMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666291);
			MessageDispatcher.NativeMethodInfoPtr_OnChannelMessageDispatched_Protected_Virtual_New_Void_ChannelMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666292);
			MessageDispatcher.NativeMethodInfoPtr_OnSysExMessageDispatched_Protected_Virtual_New_Void_SysExMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666293);
			MessageDispatcher.NativeMethodInfoPtr_OnSysCommonMessageDispatched_Protected_Virtual_New_Void_SysCommonMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666294);
			MessageDispatcher.NativeMethodInfoPtr_OnSysRealtimeMessageDispatched_Protected_Virtual_New_Void_SysRealtimeMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666295);
			MessageDispatcher.NativeMethodInfoPtr_OnMetaMessageDispatched_Protected_Virtual_New_Void_MetaMessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666296);
			MessageDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr, 100666297);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00060B1C File Offset: 0x0005ED1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16409, RefRangeEnd = 16411, XrefRangeStart = 16406, XrefRangeEnd = 16409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ChannelMessageDispatched(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_add_ChannelMessageDispatched_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00060B60 File Offset: 0x0005ED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16411, XrefRangeEnd = 16414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ChannelMessageDispatched(EventHandler<ChannelMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_remove_ChannelMessageDispatched_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00060BA4 File Offset: 0x0005EDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16414, XrefRangeEnd = 16417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysExMessageDispatched(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_add_SysExMessageDispatched_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16417, XrefRangeEnd = 16420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysExMessageDispatched(EventHandler<SysExMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_remove_SysExMessageDispatched_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00060C2C File Offset: 0x0005EE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16420, XrefRangeEnd = 16423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysCommonMessageDispatched(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_add_SysCommonMessageDispatched_Public_add_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00060C70 File Offset: 0x0005EE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16423, XrefRangeEnd = 16426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysCommonMessageDispatched(EventHandler<SysCommonMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_remove_SysCommonMessageDispatched_Public_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00060CB4 File Offset: 0x0005EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16426, XrefRangeEnd = 16429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SysRealtimeMessageDispatched(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_add_SysRealtimeMessageDispatched_Public_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00060CF8 File Offset: 0x0005EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16429, XrefRangeEnd = 16432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SysRealtimeMessageDispatched(EventHandler<SysRealtimeMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_remove_SysRealtimeMessageDispatched_Public_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00060D3C File Offset: 0x0005EF3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16435, RefRangeEnd = 16437, XrefRangeStart = 16432, XrefRangeEnd = 16435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_MetaMessageDispatched(EventHandler<MetaMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_add_MetaMessageDispatched_Public_add_Void_EventHandler_1_MetaMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00060D80 File Offset: 0x0005EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16437, XrefRangeEnd = 16440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_MetaMessageDispatched(EventHandler<MetaMessageEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_remove_MetaMessageDispatched_Public_rem_Void_EventHandler_1_MetaMessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00060DC4 File Offset: 0x0005EFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16464, RefRangeEnd = 16465, XrefRangeStart = 16440, XrefRangeEnd = 16464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(IMidiMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr_Dispatch_Public_Void_IMidiMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00060E08 File Offset: 0x0005F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16465, XrefRangeEnd = 16468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChannelMessageDispatched(ChannelMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDispatcher.NativeMethodInfoPtr_OnChannelMessageDispatched_Protected_Virtual_New_Void_ChannelMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00060E58 File Offset: 0x0005F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16468, XrefRangeEnd = 16471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSysExMessageDispatched(SysExMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDispatcher.NativeMethodInfoPtr_OnSysExMessageDispatched_Protected_Virtual_New_Void_SysExMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00060EA8 File Offset: 0x0005F0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16471, XrefRangeEnd = 16474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSysCommonMessageDispatched(SysCommonMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDispatcher.NativeMethodInfoPtr_OnSysCommonMessageDispatched_Protected_Virtual_New_Void_SysCommonMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00060EF8 File Offset: 0x0005F0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16474, XrefRangeEnd = 16477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSysRealtimeMessageDispatched(SysRealtimeMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDispatcher.NativeMethodInfoPtr_OnSysRealtimeMessageDispatched_Protected_Virtual_New_Void_SysRealtimeMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00060F48 File Offset: 0x0005F148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16477, XrefRangeEnd = 16480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMetaMessageDispatched(MetaMessageEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDispatcher.NativeMethodInfoPtr_OnMetaMessageDispatched_Protected_Virtual_New_Void_MetaMessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00060F98 File Offset: 0x0005F198
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00008900 File Offset: 0x00006B00
		public MessageDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x00060FD4 File Offset: 0x0005F1D4
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x00008909 File Offset: 0x00006B09
		public unsafe EventHandler<ChannelMessageEventArgs> ChannelMessageDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_ChannelMessageDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ChannelMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_ChannelMessageDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x00061004 File Offset: 0x0005F204
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x00008928 File Offset: 0x00006B28
		public unsafe EventHandler<SysExMessageEventArgs> SysExMessageDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_SysExMessageDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysExMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_SysExMessageDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x00061034 File Offset: 0x0005F234
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00008947 File Offset: 0x00006B47
		public unsafe EventHandler<SysCommonMessageEventArgs> SysCommonMessageDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_SysCommonMessageDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysCommonMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_SysCommonMessageDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00061064 File Offset: 0x0005F264
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x00008966 File Offset: 0x00006B66
		public unsafe EventHandler<SysRealtimeMessageEventArgs> SysRealtimeMessageDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_SysRealtimeMessageDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SysRealtimeMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_SysRealtimeMessageDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x00061094 File Offset: 0x0005F294
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x00008985 File Offset: 0x00006B85
		public unsafe EventHandler<MetaMessageEventArgs> MetaMessageDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_MetaMessageDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<MetaMessageEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDispatcher.NativeFieldInfoPtr_MetaMessageDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_ChannelMessageDispatched;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_SysExMessageDispatched;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_SysCommonMessageDispatched;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_SysRealtimeMessageDispatched;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_MetaMessageDispatched;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_add_ChannelMessageDispatched_Public_add_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_remove_ChannelMessageDispatched_Public_rem_Void_EventHandler_1_ChannelMessageEventArgs_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_add_SysExMessageDispatched_Public_add_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysExMessageDispatched_Public_rem_Void_EventHandler_1_SysExMessageEventArgs_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_add_SysCommonMessageDispatched_Public_add_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysCommonMessageDispatched_Public_rem_Void_EventHandler_1_SysCommonMessageEventArgs_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_add_SysRealtimeMessageDispatched_Public_add_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_remove_SysRealtimeMessageDispatched_Public_rem_Void_EventHandler_1_SysRealtimeMessageEventArgs_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_add_MetaMessageDispatched_Public_add_Void_EventHandler_1_MetaMessageEventArgs_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_remove_MetaMessageDispatched_Public_rem_Void_EventHandler_1_MetaMessageEventArgs_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_IMidiMessage_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_OnChannelMessageDispatched_Protected_Virtual_New_Void_ChannelMessageEventArgs_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_OnSysExMessageDispatched_Protected_Virtual_New_Void_SysExMessageEventArgs_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_OnSysCommonMessageDispatched_Protected_Virtual_New_Void_SysCommonMessageEventArgs_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_OnSysRealtimeMessageDispatched_Protected_Virtual_New_Void_SysRealtimeMessageEventArgs_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_OnMetaMessageDispatched_Protected_Virtual_New_Void_MetaMessageEventArgs_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
