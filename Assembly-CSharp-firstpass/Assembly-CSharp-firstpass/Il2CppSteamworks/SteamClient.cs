using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000136 RID: 310
	public static class SteamClient : Object
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x00031414 File Offset: 0x0002F614
		// Note: this type is marked as 'beforefieldinit'.
		static SteamClient()
		{
			Il2CppClassPointerStore<SteamClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamClient>.NativeClassPtr);
			SteamClient.NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664336);
			SteamClient.NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664337);
			SteamClient.NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664338);
			SteamClient.NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664339);
			SteamClient.NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664340);
			SteamClient.NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664341);
			SteamClient.NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664342);
			SteamClient.NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664343);
			SteamClient.NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664344);
			SteamClient.NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664345);
			SteamClient.NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664346);
			SteamClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664347);
			SteamClient.NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664348);
			SteamClient.NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664349);
			SteamClient.NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664350);
			SteamClient.NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664351);
			SteamClient.NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664352);
			SteamClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664353);
			SteamClient.NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664354);
			SteamClient.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664355);
			SteamClient.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664356);
			SteamClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664357);
			SteamClient.NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664358);
			SteamClient.NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664359);
			SteamClient.NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664360);
			SteamClient.NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664361);
			SteamClient.NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664362);
			SteamClient.NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664363);
			SteamClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664364);
			SteamClient.NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664365);
			SteamClient.NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664366);
			SteamClient.NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100664367);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000316C4 File Offset: 0x0002F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5667, XrefRangeEnd = 5671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe CreateSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000316F4 File Offset: 0x0002F8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5671, XrefRangeEnd = 5675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00031734 File Offset: 0x0002F934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5675, XrefRangeEnd = 5679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00031774 File Offset: 0x0002F974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5679, XrefRangeEnd = 5683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &phSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000317C0 File Offset: 0x0002F9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5683, XrefRangeEnd = 5687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00031800 File Offset: 0x0002FA00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5699, RefRangeEnd = 5700, XrefRangeStart = 5687, XrefRangeEnd = 5699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00031860 File Offset: 0x0002FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5700, XrefRangeEnd = 5712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000318C0 File Offset: 0x0002FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5712, XrefRangeEnd = 5716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00031900 File Offset: 0x0002FB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5728, RefRangeEnd = 5729, XrefRangeStart = 5716, XrefRangeEnd = 5728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00031960 File Offset: 0x0002FB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5741, RefRangeEnd = 5742, XrefRangeStart = 5729, XrefRangeEnd = 5741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000319B0 File Offset: 0x0002FBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5754, RefRangeEnd = 5755, XrefRangeStart = 5742, XrefRangeEnd = 5754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00031A10 File Offset: 0x0002FC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5767, RefRangeEnd = 5768, XrefRangeStart = 5755, XrefRangeEnd = 5767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00031A70 File Offset: 0x0002FC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5768, XrefRangeEnd = 5780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00031AD0 File Offset: 0x0002FCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5792, RefRangeEnd = 5793, XrefRangeStart = 5780, XrefRangeEnd = 5792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00031B30 File Offset: 0x0002FD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5793, XrefRangeEnd = 5805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00031B90 File Offset: 0x0002FD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5817, RefRangeEnd = 5818, XrefRangeStart = 5805, XrefRangeEnd = 5817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00031BF0 File Offset: 0x0002FDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5830, RefRangeEnd = 5831, XrefRangeStart = 5818, XrefRangeEnd = 5830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00031C50 File Offset: 0x0002FE50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5843, RefRangeEnd = 5844, XrefRangeStart = 5831, XrefRangeEnd = 5843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5856, RefRangeEnd = 5857, XrefRangeStart = 5844, XrefRangeEnd = 5856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00031D10 File Offset: 0x0002FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5857, XrefRangeEnd = 5861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetIPCCallCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00031D40 File Offset: 0x0002FF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5861, XrefRangeEnd = 5865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00031D78 File Offset: 0x0002FF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5865, XrefRangeEnd = 5869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BShutdownIfAllPipesClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00031DA8 File Offset: 0x0002FFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5881, RefRangeEnd = 5882, XrefRangeStart = 5869, XrefRangeEnd = 5881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00031E08 File Offset: 0x00030008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5894, RefRangeEnd = 5895, XrefRangeStart = 5882, XrefRangeEnd = 5894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00031E68 File Offset: 0x00030068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5907, RefRangeEnd = 5908, XrefRangeStart = 5895, XrefRangeEnd = 5907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00031EC8 File Offset: 0x000300C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5920, RefRangeEnd = 5921, XrefRangeStart = 5908, XrefRangeEnd = 5920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00031F28 File Offset: 0x00030128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5933, RefRangeEnd = 5934, XrefRangeStart = 5921, XrefRangeEnd = 5933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00031F88 File Offset: 0x00030188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5946, RefRangeEnd = 5947, XrefRangeStart = 5934, XrefRangeEnd = 5946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00031FE8 File Offset: 0x000301E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5959, RefRangeEnd = 5960, XrefRangeStart = 5947, XrefRangeEnd = 5959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00032048 File Offset: 0x00030248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5972, RefRangeEnd = 5973, XrefRangeStart = 5960, XrefRangeEnd = 5972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000320A8 File Offset: 0x000302A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5985, RefRangeEnd = 5986, XrefRangeStart = 5973, XrefRangeEnd = 5985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00032108 File Offset: 0x00030308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5998, RefRangeEnd = 5999, XrefRangeStart = 5986, XrefRangeEnd = 5998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0000648F File Offset: 0x0000468F
		public SteamClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_UInt32_UInt16_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;
	}
}
