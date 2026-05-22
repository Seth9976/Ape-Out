using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000146 RID: 326
	public static class SteamMatchmakingServers : Object
	{
		// Token: 0x06000CAF RID: 3247 RVA: 0x0003EFB4 File Offset: 0x0003D1B4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMatchmakingServers()
		{
			Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamMatchmakingServers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestInternetServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664906);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestLANServerList_Public_Static_HServerListRequest_AppId_t_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664907);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestFriendsServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664908);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestFavoritesServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664909);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestHistoryServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664910);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestSpectatorServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664911);
			SteamMatchmakingServers.NativeMethodInfoPtr_ReleaseRequest_Public_Static_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664912);
			SteamMatchmakingServers.NativeMethodInfoPtr_GetServerDetails_Public_Static_gameserveritem_t_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664913);
			SteamMatchmakingServers.NativeMethodInfoPtr_CancelQuery_Public_Static_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664914);
			SteamMatchmakingServers.NativeMethodInfoPtr_RefreshQuery_Public_Static_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664915);
			SteamMatchmakingServers.NativeMethodInfoPtr_IsRefreshing_Public_Static_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664916);
			SteamMatchmakingServers.NativeMethodInfoPtr_GetServerCount_Public_Static_Int32_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664917);
			SteamMatchmakingServers.NativeMethodInfoPtr_RefreshServer_Public_Static_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664918);
			SteamMatchmakingServers.NativeMethodInfoPtr_PingServer_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPingResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664919);
			SteamMatchmakingServers.NativeMethodInfoPtr_PlayerDetails_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPlayersResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664920);
			SteamMatchmakingServers.NativeMethodInfoPtr_ServerRules_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingRulesResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664921);
			SteamMatchmakingServers.NativeMethodInfoPtr_CancelServerQuery_Public_Static_Void_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100664922);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0003F138 File Offset: 0x0003D338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10060, XrefRangeEnd = 10073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestInternetServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestInternetServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10073, XrefRangeEnd = 10082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestLANServerList_Public_Static_HServerListRequest_AppId_t_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0003F1F8 File Offset: 0x0003D3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10082, XrefRangeEnd = 10095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestFriendsServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestFriendsServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0003F268 File Offset: 0x0003D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10095, XrefRangeEnd = 10108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestFavoritesServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestFavoritesServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10108, XrefRangeEnd = 10121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestHistoryServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestHistoryServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0003F348 File Offset: 0x0003D548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10121, XrefRangeEnd = 10134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestSpectatorServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestSpectatorServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0003F3B8 File Offset: 0x0003D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10134, XrefRangeEnd = 10139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hServerListRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_ReleaseRequest_Public_Static_Void_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0003F3EC File Offset: 0x0003D5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10139, XrefRangeEnd = 10156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_GetServerDetails_Public_Static_gameserveritem_t_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<gameserveritem_t>(intPtr3) : null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0003F43C File Offset: 0x0003D63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10156, XrefRangeEnd = 10161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelQuery(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_CancelQuery_Public_Static_Void_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003F470 File Offset: 0x0003D670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10161, XrefRangeEnd = 10166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshQuery(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RefreshQuery_Public_Static_Void_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0003F4A4 File Offset: 0x0003D6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10166, XrefRangeEnd = 10171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRefreshing(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_IsRefreshing_Public_Static_Boolean_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003F4E4 File Offset: 0x0003D6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10171, XrefRangeEnd = 10176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetServerCount(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_GetServerCount_Public_Static_Int32_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0003F524 File Offset: 0x0003D724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10176, XrefRangeEnd = 10181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RefreshServer_Public_Static_Void_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003F564 File Offset: 0x0003D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10181, XrefRangeEnd = 10190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_PingServer_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPingResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10190, XrefRangeEnd = 10199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_PlayerDetails_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPlayersResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0003F624 File Offset: 0x0003D824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10199, XrefRangeEnd = 10208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_ServerRules_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingRulesResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0003F684 File Offset: 0x0003D884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10208, XrefRangeEnd = 10213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelServerQuery(HServerQuery hServerQuery)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hServerQuery;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_CancelServerQuery_Public_Static_Void_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0000651F File Offset: 0x0000471F
		public SteamMatchmakingServers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_RequestInternetServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_RequestLANServerList_Public_Static_HServerListRequest_AppId_t_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_RequestFriendsServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_RequestFavoritesServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_RequestHistoryServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_RequestSpectatorServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRequest_Public_Static_Void_HServerListRequest_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_GetServerDetails_Public_Static_gameserveritem_t_HServerListRequest_Int32_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_CancelQuery_Public_Static_Void_HServerListRequest_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuery_Public_Static_Void_HServerListRequest_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_IsRefreshing_Public_Static_Boolean_HServerListRequest_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_GetServerCount_Public_Static_Int32_HServerListRequest_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_RefreshServer_Public_Static_Void_HServerListRequest_Int32_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_PingServer_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPingResponse_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_PlayerDetails_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPlayersResponse_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_ServerRules_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingRulesResponse_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_CancelServerQuery_Public_Static_Void_HServerQuery_0;
	}
}
