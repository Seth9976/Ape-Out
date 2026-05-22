using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C3 RID: 963
	public sealed class ChannelServices : Object
	{
		// Token: 0x06003EF4 RID: 16116 RVA: 0x001288D4 File Offset: 0x00126AD4
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelServices()
		{
			Il2CppClassPointerStore<ChannelServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ChannelServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr);
			ChannelServices.NativeFieldInfoPtr_registeredChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "registeredChannels");
			ChannelServices.NativeFieldInfoPtr_delayedClientChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "delayedClientChannels");
			ChannelServices.NativeFieldInfoPtr__crossContextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "_crossContextSink");
			ChannelServices.NativeFieldInfoPtr_CrossContextUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "CrossContextUrl");
			ChannelServices.NativeFieldInfoPtr_oldStartModeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "oldStartModeTypes");
			ChannelServices.NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672611);
			ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672612);
			ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672613);
			ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672614);
			ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672615);
			ChannelServices.NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672616);
			ChannelServices.NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672617);
			ChannelServices.NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672618);
			ChannelServices.NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672619);
			ChannelServices.NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672620);
			ChannelServices.NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672621);
			ChannelServices.NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100672622);
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x00128A58 File Offset: 0x00126C58
		public unsafe static CrossContextChannel CrossContextChannel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222646, XrefRangeEnd = 222650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr3) : null;
			}
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00128A8C File Offset: 0x00126C8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222731, RefRangeEnd = 222734, XrefRangeStart = 222650, XrefRangeEnd = 222731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink CreateClientChannelSinkChain(string url, Object remoteChannelData, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x00128B00 File Offset: 0x00126D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222734, XrefRangeEnd = 222741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Il2CppReferenceArray<Object> channelDataArray, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelDataArray);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00128B84 File Offset: 0x00126D84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222745, RefRangeEnd = 222747, XrefRangeStart = 222741, XrefRangeEnd = 222745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannel(IChannel chnl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chnl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x00128BBC File Offset: 0x00126DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222800, RefRangeEnd = 222802, XrefRangeStart = 222747, XrefRangeEnd = 222800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chnl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ensureSecurity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x00128C00 File Offset: 0x00126E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222946, RefRangeEnd = 222947, XrefRangeStart = 222802, XrefRangeEnd = 222946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannelConfig(ChannelData channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x00128C38 File Offset: 0x00126E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222962, RefRangeEnd = 222964, XrefRangeStart = 222947, XrefRangeEnd = 222962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateProvider(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x00128C7C File Offset: 0x00126E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222964, XrefRangeEnd = 222977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage SyncDispatchMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x00128CC0 File Offset: 0x00126EC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222995, RefRangeEnd = 222998, XrefRangeStart = 222977, XrefRangeEnd = 222995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReturnMessage CheckIncomingMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00128D04 File Offset: 0x00126F04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 223024, RefRangeEnd = 223028, XrefRangeStart = 222998, XrefRangeEnd = 223024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x00128D5C File Offset: 0x00126F5C
		[CallerCount(0)]
		public unsafe static bool IsLocalCall(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00128DA0 File Offset: 0x00126FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223119, RefRangeEnd = 223121, XrefRangeStart = 223028, XrefRangeEnd = 223119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCurrentChannelInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelServices.NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x00017854 File Offset: 0x00015A54
		public ChannelServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x00128DD4 File Offset: 0x00126FD4
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x0001785D File Offset: 0x00015A5D
		public unsafe static ArrayList registeredChannels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_registeredChannels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_registeredChannels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x00128DFC File Offset: 0x00126FFC
		// (set) Token: 0x06003F05 RID: 16133 RVA: 0x0001786F File Offset: 0x00015A6F
		public unsafe static ArrayList delayedClientChannels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_delayedClientChannels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_delayedClientChannels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x00128E24 File Offset: 0x00127024
		// (set) Token: 0x06003F07 RID: 16135 RVA: 0x00017881 File Offset: 0x00015A81
		public unsafe static CrossContextChannel _crossContextSink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr__crossContextSink, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr__crossContextSink, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x00128E4C File Offset: 0x0012704C
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x00017893 File Offset: 0x00015A93
		public unsafe static string CrossContextUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_CrossContextUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_CrossContextUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x00128E6C File Offset: 0x0012706C
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x000178A5 File Offset: 0x00015AA5
		public unsafe static IList oldStartModeTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChannelServices.NativeFieldInfoPtr_oldStartModeTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChannelServices.NativeFieldInfoPtr_oldStartModeTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeFieldInfoPtr_registeredChannels;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeFieldInfoPtr_delayedClientChannels;

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeFieldInfoPtr__crossContextSink;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeFieldInfoPtr_CrossContextUrl;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeFieldInfoPtr_oldStartModeTypes;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0;
	}
}
