using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200001E RID: 30
	public static class CSteamAPIContext : Object
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00011F48 File Offset: 0x00010148
		// Note: this type is marked as 'beforefieldinit'.
		static CSteamAPIContext()
		{
			Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CSteamAPIContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr);
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamClient");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUser");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamFriends");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUtils");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMatchmaking");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUserStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUserStats");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamApps");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmakingServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMatchmakingServers");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworking");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemoteStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamRemoteStorage");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamScreenshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamScreenshots");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamHTTP");
			CSteamAPIContext.NativeFieldInfoPtr_m_pController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pController");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUGC");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamAppList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamAppList");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMusic");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusicRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMusicRemote");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTMLSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamHTMLSurface");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamInventory");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamVideo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamVideo");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParentalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamParentalSettings");
			CSteamAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663543);
			CSteamAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663544);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663545);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663546);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663547);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663548);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmaking_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663549);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663550);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663551);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmakingServers_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663552);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663553);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamRemoteStorage_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663554);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamScreenshots_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663555);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663556);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamController_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663557);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663558);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamAppList_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663559);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusic_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663560);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusicRemote_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663561);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTMLSurface_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663562);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663563);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamVideo_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663564);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamParentalSettings_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663565);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000122E8 File Offset: 0x000104E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3022, XrefRangeEnd = 3046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00012310 File Offset: 0x00010510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 3165, RefRangeEnd = 3168, XrefRangeStart = 3046, XrefRangeEnd = 3165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00012340 File Offset: 0x00010540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3168, XrefRangeEnd = 3170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00012370 File Offset: 0x00010570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3170, XrefRangeEnd = 3172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUser()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000123A0 File Offset: 0x000105A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3172, XrefRangeEnd = 3174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamFriends()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000123D0 File Offset: 0x000105D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3174, XrefRangeEnd = 3176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUtils()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00012400 File Offset: 0x00010600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3176, XrefRangeEnd = 3178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMatchmaking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmaking_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00012430 File Offset: 0x00010630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3178, XrefRangeEnd = 3180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUserStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00012460 File Offset: 0x00010660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3180, XrefRangeEnd = 3182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamApps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00012490 File Offset: 0x00010690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3182, XrefRangeEnd = 3184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMatchmakingServers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmakingServers_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000124C0 File Offset: 0x000106C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3184, XrefRangeEnd = 3186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000124F0 File Offset: 0x000106F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3186, XrefRangeEnd = 3188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamRemoteStorage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamRemoteStorage_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00012520 File Offset: 0x00010720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3188, XrefRangeEnd = 3190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamScreenshots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamScreenshots_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00012550 File Offset: 0x00010750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3190, XrefRangeEnd = 3192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamHTTP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00012580 File Offset: 0x00010780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3192, XrefRangeEnd = 3194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamController()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamController_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000125B0 File Offset: 0x000107B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3194, XrefRangeEnd = 3196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUGC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000125E0 File Offset: 0x000107E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3196, XrefRangeEnd = 3198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamAppList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamAppList_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00012610 File Offset: 0x00010810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3198, XrefRangeEnd = 3200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMusic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusic_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00012640 File Offset: 0x00010840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3200, XrefRangeEnd = 3202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMusicRemote()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusicRemote_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00012670 File Offset: 0x00010870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3202, XrefRangeEnd = 3204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamHTMLSurface()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTMLSurface_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000126A0 File Offset: 0x000108A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3204, XrefRangeEnd = 3206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamInventory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000126D0 File Offset: 0x000108D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3206, XrefRangeEnd = 3208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamVideo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamVideo_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00012700 File Offset: 0x00010900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3208, XrefRangeEnd = 3210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamParentalSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamParentalSettings_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000028BC File Offset: 0x00000ABC
		public CSteamAPIContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00012730 File Offset: 0x00010930
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000028C5 File Offset: 0x00000AC5
		public unsafe static IntPtr m_pSteamClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0001274C File Offset: 0x0001094C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000028D3 File Offset: 0x00000AD3
		public unsafe static IntPtr m_pSteamUser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUser, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUser, (void*)(&value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00012768 File Offset: 0x00010968
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000028E1 File Offset: 0x00000AE1
		public unsafe static IntPtr m_pSteamFriends
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamFriends, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamFriends, (void*)(&value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00012784 File Offset: 0x00010984
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000028EF File Offset: 0x00000AEF
		public unsafe static IntPtr m_pSteamUtils
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000127A0 File Offset: 0x000109A0
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000028FD File Offset: 0x00000AFD
		public unsafe static IntPtr m_pSteamMatchmaking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmaking, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmaking, (void*)(&value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000127BC File Offset: 0x000109BC
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000290B File Offset: 0x00000B0B
		public unsafe static IntPtr m_pSteamUserStats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUserStats, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUserStats, (void*)(&value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000127D8 File Offset: 0x000109D8
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002919 File Offset: 0x00000B19
		public unsafe static IntPtr m_pSteamApps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000127F4 File Offset: 0x000109F4
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002927 File Offset: 0x00000B27
		public unsafe static IntPtr m_pSteamMatchmakingServers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmakingServers, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmakingServers, (void*)(&value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00012810 File Offset: 0x00010A10
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002935 File Offset: 0x00000B35
		public unsafe static IntPtr m_pSteamNetworking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0001282C File Offset: 0x00010A2C
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002943 File Offset: 0x00000B43
		public unsafe static IntPtr m_pSteamRemoteStorage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemoteStorage, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemoteStorage, (void*)(&value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00012848 File Offset: 0x00010A48
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002951 File Offset: 0x00000B51
		public unsafe static IntPtr m_pSteamScreenshots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamScreenshots, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamScreenshots, (void*)(&value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00012864 File Offset: 0x00010A64
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000295F File Offset: 0x00000B5F
		public unsafe static IntPtr m_pSteamHTTP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00012880 File Offset: 0x00010A80
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000296D File Offset: 0x00000B6D
		public unsafe static IntPtr m_pController
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pController, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pController, (void*)(&value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001289C File Offset: 0x00010A9C
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000297B File Offset: 0x00000B7B
		public unsafe static IntPtr m_pSteamUGC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000128B8 File Offset: 0x00010AB8
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002989 File Offset: 0x00000B89
		public unsafe static IntPtr m_pSteamAppList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamAppList, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamAppList, (void*)(&value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000128D4 File Offset: 0x00010AD4
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002997 File Offset: 0x00000B97
		public unsafe static IntPtr m_pSteamMusic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusic, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusic, (void*)(&value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000128F0 File Offset: 0x00010AF0
		// (set) Token: 0x06000179 RID: 377 RVA: 0x000029A5 File Offset: 0x00000BA5
		public unsafe static IntPtr m_pSteamMusicRemote
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusicRemote, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusicRemote, (void*)(&value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001290C File Offset: 0x00010B0C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x000029B3 File Offset: 0x00000BB3
		public unsafe static IntPtr m_pSteamHTMLSurface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTMLSurface, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTMLSurface, (void*)(&value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00012928 File Offset: 0x00010B28
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000029C1 File Offset: 0x00000BC1
		public unsafe static IntPtr m_pSteamInventory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00012944 File Offset: 0x00010B44
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000029CF File Offset: 0x00000BCF
		public unsafe static IntPtr m_pSteamVideo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamVideo, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamVideo, (void*)(&value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00012960 File Offset: 0x00010B60
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000029DD File Offset: 0x00000BDD
		public unsafe static IntPtr m_pSteamParentalSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParentalSettings, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParentalSettings, (void*)(&value));
			}
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamClient;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUser;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamFriends;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUtils;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMatchmaking;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUserStats;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamApps;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMatchmakingServers;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworking;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamRemoteStorage;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamScreenshots;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamHTTP;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_m_pController;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUGC;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamAppList;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMusic;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMusicRemote;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamHTMLSurface;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamInventory;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamVideo;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamParentalSettings;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Static_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Static_Boolean_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMatchmaking_Internal_Static_IntPtr_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMatchmakingServers_Internal_Static_IntPtr_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamRemoteStorage_Internal_Static_IntPtr_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamScreenshots_Internal_Static_IntPtr_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamController_Internal_Static_IntPtr_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamAppList_Internal_Static_IntPtr_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMusic_Internal_Static_IntPtr_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMusicRemote_Internal_Static_IntPtr_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamHTMLSurface_Internal_Static_IntPtr_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamVideo_Internal_Static_IntPtr_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamParentalSettings_Internal_Static_IntPtr_0;
	}
}
