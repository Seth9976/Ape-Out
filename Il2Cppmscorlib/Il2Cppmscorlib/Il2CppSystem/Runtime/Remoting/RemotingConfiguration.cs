using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000396 RID: 918
	public static class RemotingConfiguration : Object
	{
		// Token: 0x06003C92 RID: 15506 RVA: 0x0011FAF0 File Offset: 0x0011DCF0
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingConfiguration()
		{
			Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr);
			RemotingConfiguration.NativeFieldInfoPtr_applicationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationID");
			RemotingConfiguration.NativeFieldInfoPtr_applicationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationName");
			RemotingConfiguration.NativeFieldInfoPtr_processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "processGuid");
			RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultConfigRead");
			RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultDelayedConfigRead");
			RemotingConfiguration.NativeFieldInfoPtr__errorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "_errorMode");
			RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownClientEntries");
			RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedClientEntries");
			RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownServiceEntries");
			RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedServiceEntries");
			RemotingConfiguration.NativeFieldInfoPtr_channelTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "channelTemplates");
			RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "clientProviderTemplates");
			RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "serverProviderTemplates");
			RemotingConfiguration.NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672302);
			RemotingConfiguration.NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672303);
			RemotingConfiguration.NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672304);
			RemotingConfiguration.NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672305);
			RemotingConfiguration.NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672306);
			RemotingConfiguration.NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672307);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672308);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672309);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672310);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672311);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672312);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672313);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672314);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672315);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672316);
			RemotingConfiguration.NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672317);
			RemotingConfiguration.NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672318);
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x0011FD78 File Offset: 0x0011DF78
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x0011FDA4 File Offset: 0x0011DFA4
		public unsafe static string ApplicationName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219374, XrefRangeEnd = 219378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219378, XrefRangeEnd = 219382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x0011FDDC File Offset: 0x0011DFDC
		public unsafe static string ProcessId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219395, RefRangeEnd = 219397, XrefRangeStart = 219382, XrefRangeEnd = 219395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0011FE08 File Offset: 0x0011E008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219439, RefRangeEnd = 219440, XrefRangeStart = 219397, XrefRangeEnd = 219439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadDefaultDelayedChannels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0011FE30 File Offset: 0x0011E030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219454, RefRangeEnd = 219455, XrefRangeStart = 219440, XrefRangeEnd = 219454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivatedClientTypeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x0011FE74 File Offset: 0x0011E074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219469, RefRangeEnd = 219470, XrefRangeStart = 219455, XrefRangeEnd = 219469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WellKnownClientTypeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x0011FEB8 File Offset: 0x0011E0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219483, RefRangeEnd = 219484, XrefRangeStart = 219470, XrefRangeEnd = 219483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x0011FEF0 File Offset: 0x0011E0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219494, RefRangeEnd = 219495, XrefRangeStart = 219484, XrefRangeEnd = 219494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x0011FF28 File Offset: 0x0011E128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219508, RefRangeEnd = 219509, XrefRangeStart = 219495, XrefRangeEnd = 219508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x0011FF60 File Offset: 0x0011E160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219523, RefRangeEnd = 219524, XrefRangeStart = 219509, XrefRangeEnd = 219523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0011FF98 File Offset: 0x0011E198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219524, XrefRangeEnd = 219529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannelTemplate(ChannelData channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x0011FFD0 File Offset: 0x0011E1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219529, XrefRangeEnd = 219534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterClientProviderTemplate(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00120008 File Offset: 0x0011E208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219534, XrefRangeEnd = 219539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterServerProviderTemplate(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00120040 File Offset: 0x0011E240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219606, RefRangeEnd = 219607, XrefRangeStart = 219539, XrefRangeEnd = 219606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyDelayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00120084 File Offset: 0x0011E284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219649, RefRangeEnd = 219650, XrefRangeStart = 219607, XrefRangeEnd = 219649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypes(ArrayList types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x001200BC File Offset: 0x0011E2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219660, RefRangeEnd = 219661, XrefRangeStart = 219650, XrefRangeEnd = 219660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLocalRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x001200FC File Offset: 0x0011E2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219661, XrefRangeEnd = 219672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCustomErrorsMode(string mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x000169A2 File Offset: 0x00014BA2
		public RemotingConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x00120134 File Offset: 0x0011E334
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x000169AB File Offset: 0x00014BAB
		public unsafe static string applicationID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_applicationID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_applicationID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x00120154 File Offset: 0x0011E354
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x000169BD File Offset: 0x00014BBD
		public unsafe static string applicationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_applicationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_applicationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00120174 File Offset: 0x0011E374
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x000169CF File Offset: 0x00014BCF
		public unsafe static string processGuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_processGuid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_processGuid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00120194 File Offset: 0x0011E394
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x000169E1 File Offset: 0x00014BE1
		public unsafe static bool defaultConfigRead
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead, (void*)(&value));
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x001201B0 File Offset: 0x0011E3B0
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x000169EF File Offset: 0x00014BEF
		public unsafe static bool defaultDelayedConfigRead
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&value));
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x001201CC File Offset: 0x0011E3CC
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x000169FD File Offset: 0x00014BFD
		public unsafe static string _errorMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr__errorMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr__errorMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x001201EC File Offset: 0x0011E3EC
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x00016A0F File Offset: 0x00014C0F
		public unsafe static Hashtable wellKnownClientEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x00120214 File Offset: 0x0011E414
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x00016A21 File Offset: 0x00014C21
		public unsafe static Hashtable activatedClientEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x0012023C File Offset: 0x0011E43C
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x00016A33 File Offset: 0x00014C33
		public unsafe static Hashtable wellKnownServiceEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x00120264 File Offset: 0x0011E464
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x00016A45 File Offset: 0x00014C45
		public unsafe static Hashtable activatedServiceEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x0012028C File Offset: 0x0011E48C
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x00016A57 File Offset: 0x00014C57
		public unsafe static Hashtable channelTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_channelTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_channelTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x001202B4 File Offset: 0x0011E4B4
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x00016A69 File Offset: 0x00014C69
		public unsafe static Hashtable clientProviderTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x001202DC File Offset: 0x0011E4DC
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x00016A7B File Offset: 0x00014C7B
		public unsafe static Hashtable serverProviderTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeFieldInfoPtr_applicationID;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeFieldInfoPtr_applicationName;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeFieldInfoPtr_processGuid;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeFieldInfoPtr_defaultConfigRead;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeFieldInfoPtr_defaultDelayedConfigRead;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeFieldInfoPtr__errorMode;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeFieldInfoPtr_wellKnownClientEntries;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeFieldInfoPtr_activatedClientEntries;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeFieldInfoPtr_wellKnownServiceEntries;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeFieldInfoPtr_activatedServiceEntries;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeFieldInfoPtr_channelTemplates;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeFieldInfoPtr_clientProviderTemplates;

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeFieldInfoPtr_serverProviderTemplates;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0;

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0;

		// Token: 0x04003261 RID: 12897
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0;

		// Token: 0x04003262 RID: 12898
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0;

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0;

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0;

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0;

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0;
	}
}
