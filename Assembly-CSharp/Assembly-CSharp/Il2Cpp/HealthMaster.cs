using System;
using Il2CppCodeStage.AntiCheat.ObscuredTypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x0200010A RID: 266
	public class HealthMaster : MonoBehaviour
	{
		// Token: 0x06001F6E RID: 8046 RVA: 0x0008C858 File Offset: 0x0008AA58
		// Note: this type is marked as 'beforefieldinit'.
		static HealthMaster()
		{
			Il2CppClassPointerStore<HealthMaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HealthMaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr);
			HealthMaster.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "me");
			HealthMaster.NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "world");
			HealthMaster.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "level");
			HealthMaster.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "mode");
			HealthMaster.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "time");
			HealthMaster.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "score");
			HealthMaster.NativeFieldInfoPtr_prevTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "prevTime");
			HealthMaster.NativeFieldInfoPtr_prevScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "prevScore");
			HealthMaster.NativeFieldInfoPtr_guardsKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "guardsKilled");
			HealthMaster.NativeFieldInfoPtr_prevguardsKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "prevguardsKilled");
			HealthMaster.NativeFieldInfoPtr_extraTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "extraTime");
			HealthMaster.NativeFieldInfoPtr_prevExtraTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "prevExtraTime");
			HealthMaster.NativeFieldInfoPtr_distanceTraveled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "distanceTraveled");
			HealthMaster.NativeFieldInfoPtr_prevDistanceTraveled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "prevDistanceTraveled");
			HealthMaster.NativeFieldInfoPtr_steamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "steamName");
			HealthMaster.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "names");
			HealthMaster.NativeFieldInfoPtr_distances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "distances");
			HealthMaster.NativeFieldInfoPtr_kills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "kills");
			HealthMaster.NativeFieldInfoPtr_scores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "scores");
			HealthMaster.NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "levels");
			HealthMaster.NativeFieldInfoPtr_demoLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "demoLevels");
			HealthMaster.NativeFieldInfoPtr_labLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "labLevels");
			HealthMaster.NativeFieldInfoPtr_labLevelsHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "labLevelsHard");
			HealthMaster.NativeFieldInfoPtr_bunkerLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "bunkerLevels");
			HealthMaster.NativeFieldInfoPtr_bunkerLevelsHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "bunkerLevelsHard");
			HealthMaster.NativeFieldInfoPtr_officeLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "officeLevels");
			HealthMaster.NativeFieldInfoPtr_officeLevelsHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "officeLevelsHard");
			HealthMaster.NativeFieldInfoPtr_zooLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "zooLevels");
			HealthMaster.NativeFieldInfoPtr_zooLevelsHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "zooLevelsHard");
			HealthMaster.NativeFieldInfoPtr_single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "single");
			HealthMaster.NativeFieldInfoPtr_singleHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "singleHard");
			HealthMaster.NativeFieldInfoPtr_curLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "curLevel");
			HealthMaster.NativeFieldInfoPtr_m_GameOverlayActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "m_GameOverlayActivated");
			HealthMaster.NativeFieldInfoPtr_LeaderboardScoreUploaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "LeaderboardScoreUploaded");
			HealthMaster.NativeFieldInfoPtr_LeaderboardFindResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "LeaderboardFindResult");
			HealthMaster.NativeFieldInfoPtr_LeaderboardScoresDownloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "LeaderboardScoresDownloaded");
			HealthMaster.NativeFieldInfoPtr_m_SteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "m_SteamLeaderboard");
			HealthMaster.NativeFieldInfoPtr_m_SteamLeaderboardEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "m_SteamLeaderboardEntries");
			HealthMaster.NativeFieldInfoPtr_LeaderboardEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "LeaderboardEntry");
			HealthMaster.NativeFieldInfoPtr_leaderboardLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "leaderboardLen");
			HealthMaster.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "timer");
			HealthMaster.NativeFieldInfoPtr_totalLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "totalLevels");
			HealthMaster.NativeFieldInfoPtr_scoreList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "scoreList");
			HealthMaster.NativeFieldInfoPtr_newGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "newGame");
			HealthMaster.NativeFieldInfoPtr_fromMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "fromMenu");
			HealthMaster.NativeFieldInfoPtr_fromGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "fromGame");
			HealthMaster.NativeFieldInfoPtr_incrementedLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "incrementedLevel");
			HealthMaster.NativeFieldInfoPtr_curAlbumPlayerPref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "curAlbumPlayerPref");
			HealthMaster.NativeFieldInfoPtr_localLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "localLeaderboard");
			HealthMaster.NativeFieldInfoPtr_albumIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "albumIndex");
			HealthMaster.NativeFieldInfoPtr_playedSideTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "playedSideTitle");
			HealthMaster.NativeFieldInfoPtr_seamless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "seamless");
			HealthMaster.NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "lastTime");
			HealthMaster.NativeFieldInfoPtr_lastKills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "lastKills");
			HealthMaster.NativeFieldInfoPtr_introTitlesShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "introTitlesShown");
			HealthMaster.NativeFieldInfoPtr_musicSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "musicSystem");
			HealthMaster.NativeFieldInfoPtr_soundMan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "soundMan");
			HealthMaster.NativeFieldInfoPtr_unlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "unlocking");
			HealthMaster.NativeFieldInfoPtr_mouseControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "mouseControl");
			HealthMaster.NativeFieldInfoPtr_mousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "mousePos");
			HealthMaster.NativeFieldInfoPtr_prevMPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "prevMPos");
			HealthMaster.NativeFieldInfoPtr_mouseDelt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "mouseDelt");
			HealthMaster.NativeFieldInfoPtr_bananaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "bananaMask");
			HealthMaster.NativeFieldInfoPtr_bananaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "bananaLevel");
			HealthMaster.NativeFieldInfoPtr_friend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "friend");
			HealthMaster.NativeFieldInfoPtr_controlStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "controlStrings");
			HealthMaster.NativeFieldInfoPtr_defControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "defControls");
			HealthMaster.NativeFieldInfoPtr_realControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "realControls");
			HealthMaster.NativeFieldInfoPtr_bagHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "bagHolder");
			HealthMaster.NativeFieldInfoPtr_steam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "steam");
			HealthMaster.NativeFieldInfoPtr_bloodRender2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "bloodRender2D");
			HealthMaster.NativeFieldInfoPtr_didFullScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "didFullScreen");
			HealthMaster.NativeFieldInfoPtr_laptopMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "laptopMode");
			HealthMaster.NativeMethodInfoPtr_GetMaxArea_Private_Int32_Il2CppReferenceArray_1_Level_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665801);
			HealthMaster.NativeMethodInfoPtr_CreateBloodRender_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665802);
			HealthMaster.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665803);
			HealthMaster.NativeMethodInfoPtr_GetSimpleAlbInd_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665804);
			HealthMaster.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665805);
			HealthMaster.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665806);
			HealthMaster.NativeMethodInfoPtr_GetUnlockedAlbums_Public_ObscuredInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665807);
			HealthMaster.NativeMethodInfoPtr_OnApeDeath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665808);
			HealthMaster.NativeMethodInfoPtr_GoFriends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665809);
			HealthMaster.NativeMethodInfoPtr_GoGlobal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665810);
			HealthMaster.NativeMethodInfoPtr_LevelWasLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665811);
			HealthMaster.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665812);
			HealthMaster.NativeMethodInfoPtr_UpdateJson_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665813);
			HealthMaster.NativeMethodInfoPtr_GetAlbumEndLine_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665814);
			HealthMaster.NativeMethodInfoPtr_GetDeaths_Public_ObscuredInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665815);
			HealthMaster.NativeMethodInfoPtr_GetTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665816);
			HealthMaster.NativeMethodInfoPtr_AddAlbumPPref_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665817);
			HealthMaster.NativeMethodInfoPtr_IncrementLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665818);
			HealthMaster.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665819);
			HealthMaster.NativeMethodInfoPtr_UpdateLeaderboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665820);
			HealthMaster.NativeMethodInfoPtr_DownloadLeaderboard_Public_Void_ELeaderboardDataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665821);
			HealthMaster.NativeMethodInfoPtr_OnLeaderboardFindResult_Public_Void_LeaderboardFindResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665822);
			HealthMaster.NativeMethodInfoPtr_OnGameOverlayActivated_Public_Void_GameOverlayActivated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665823);
			HealthMaster.NativeMethodInfoPtr_OnLeaderboardScoresDownloaded_Public_Void_LeaderboardScoresDownloaded_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665824);
			HealthMaster.NativeMethodInfoPtr_OnLeaderboardScoreUploaded_Private_Void_LeaderboardScoreUploaded_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665825);
			HealthMaster.NativeMethodInfoPtr_ResetShit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665826);
			HealthMaster.NativeMethodInfoPtr_IsThisHighScore_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665827);
			HealthMaster.NativeMethodInfoPtr_AddEntry_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665828);
			HealthMaster.NativeMethodInfoPtr_WriteScoreboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665829);
			HealthMaster.NativeMethodInfoPtr_ReadScoreboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665830);
			HealthMaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, 100665831);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0008D0A8 File Offset: 0x0008B2A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 66467, RefRangeEnd = 66472, XrefRangeStart = 66442, XrefRangeEnd = 66467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMaxArea(Il2CppReferenceArray<Level> lvls)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lvls);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GetMaxArea_Private_Int32_Il2CppReferenceArray_1_Level_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0008D0F8 File Offset: 0x0008B2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66472, XrefRangeEnd = 66475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CreateBloodRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_CreateBloodRender_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0008D138 File Offset: 0x0008B338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66475, XrefRangeEnd = 66697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0008D16C File Offset: 0x0008B36C
		[CallerCount(0)]
		public unsafe int GetSimpleAlbInd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GetSimpleAlbInd_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0008D1A8 File Offset: 0x0008B3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66697, XrefRangeEnd = 66769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0008D1DC File Offset: 0x0008B3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66769, XrefRangeEnd = 66773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0008D210 File Offset: 0x0008B410
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 66790, RefRangeEnd = 66798, XrefRangeStart = 66773, XrefRangeEnd = 66790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredInt GetUnlockedAlbums(bool apeShit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref apeShit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GetUnlockedAlbums_Public_ObscuredInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0008D25C File Offset: 0x0008B45C
		[CallerCount(0)]
		public unsafe void OnApeDeath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnApeDeath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0008D290 File Offset: 0x0008B490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66798, XrefRangeEnd = 66799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GoFriends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0008D2C4 File Offset: 0x0008B4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66799, XrefRangeEnd = 66800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoGlobal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GoGlobal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x0008D2F8 File Offset: 0x0008B4F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66888, RefRangeEnd = 66892, XrefRangeStart = 66800, XrefRangeEnd = 66888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LevelWasLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_LevelWasLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0008D32C File Offset: 0x0008B52C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0008D360 File Offset: 0x0008B560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66892, XrefRangeEnd = 66924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateJson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_UpdateJson_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0008D394 File Offset: 0x0008B594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66924, XrefRangeEnd = 66949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetAlbumEndLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GetAlbumEndLine_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0008D3D4 File Offset: 0x0008B5D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66970, RefRangeEnd = 66973, XrefRangeStart = 66949, XrefRangeEnd = 66970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredInt GetDeaths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GetDeaths_Public_ObscuredInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0008D410 File Offset: 0x0008B610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66973, XrefRangeEnd = 66984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_GetTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0008D44C File Offset: 0x0008B64C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 66997, RefRangeEnd = 67002, XrefRangeStart = 66984, XrefRangeEnd = 66997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAlbumPPref(string updateString, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(updateString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_AddAlbumPPref_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0008D49C File Offset: 0x0008B69C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67017, RefRangeEnd = 67018, XrefRangeStart = 67002, XrefRangeEnd = 67017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_IncrementLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67018, XrefRangeEnd = 67072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0008D504 File Offset: 0x0008B704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67139, RefRangeEnd = 67140, XrefRangeStart = 67072, XrefRangeEnd = 67139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLeaderboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_UpdateLeaderboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0008D538 File Offset: 0x0008B738
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67164, RefRangeEnd = 67168, XrefRangeStart = 67140, XrefRangeEnd = 67164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownloadLeaderboard(ELeaderboardDataRequest boop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref boop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_DownloadLeaderboard_Public_Void_ELeaderboardDataRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0008D578 File Offset: 0x0008B778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67168, XrefRangeEnd = 67205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLeaderboardFindResult(LeaderboardFindResult_t pCallback, bool bIOFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCallback;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIOFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnLeaderboardFindResult_Public_Void_LeaderboardFindResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0008D5C4 File Offset: 0x0008B7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67205, XrefRangeEnd = 67221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameOverlayActivated(GameOverlayActivated_t pCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCallback;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnGameOverlayActivated_Public_Void_GameOverlayActivated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0008D604 File Offset: 0x0008B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67221, XrefRangeEnd = 67265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLeaderboardScoresDownloaded(LeaderboardScoresDownloaded_t pCallResult, bool boop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCallResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnLeaderboardScoresDownloaded_Public_Void_LeaderboardScoresDownloaded_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0008D650 File Offset: 0x0008B850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67265, XrefRangeEnd = 67266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLeaderboardScoreUploaded(LeaderboardScoreUploaded_t pCallResult, bool bingo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCallResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bingo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_OnLeaderboardScoreUploaded_Private_Void_LeaderboardScoreUploaded_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0008D69C File Offset: 0x0008B89C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 67281, RefRangeEnd = 67284, XrefRangeStart = 67266, XrefRangeEnd = 67281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_ResetShit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67284, XrefRangeEnd = 67286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsThisHighScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_IsThisHighScore_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0008D70C File Offset: 0x0008B90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67286, XrefRangeEnd = 67325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEntry(string inits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_AddEntry_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0008D750 File Offset: 0x0008B950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67373, RefRangeEnd = 67374, XrefRangeStart = 67325, XrefRangeEnd = 67373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteScoreboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_WriteScoreboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0008D784 File Offset: 0x0008B984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67374, XrefRangeEnd = 67422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadScoreboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr_ReadScoreboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0008D7B8 File Offset: 0x0008B9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67422, XrefRangeEnd = 67464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HealthMaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00015F8D File Offset: 0x0001418D
		public HealthMaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0008D7F4 File Offset: 0x0008B9F4
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00015F96 File Offset: 0x00014196
		public unsafe static HealthMaster me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HealthMaster.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HealthMaster>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HealthMaster.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0008D81C File Offset: 0x0008BA1C
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x00015FA8 File Offset: 0x000141A8
		public unsafe HealthMaster.Levels world
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_world);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_world)) = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0008D844 File Offset: 0x0008BA44
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x00015FC3 File Offset: 0x000141C3
		public unsafe int level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0008D86C File Offset: 0x0008BA6C
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x00015FDE File Offset: 0x000141DE
		public unsafe int mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0008D894 File Offset: 0x0008BA94
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x00015FF9 File Offset: 0x000141F9
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0008D8BC File Offset: 0x0008BABC
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00016014 File Offset: 0x00014214
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0008D8E4 File Offset: 0x0008BAE4
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0001602F File Offset: 0x0001422F
		public unsafe float prevTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevTime)) = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0008D90C File Offset: 0x0008BB0C
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0001604A File Offset: 0x0001424A
		public unsafe int prevScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevScore)) = value;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0008D934 File Offset: 0x0008BB34
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x00016065 File Offset: 0x00014265
		public unsafe int guardsKilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_guardsKilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_guardsKilled)) = value;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0008D95C File Offset: 0x0008BB5C
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00016080 File Offset: 0x00014280
		public unsafe int prevguardsKilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevguardsKilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevguardsKilled)) = value;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0008D984 File Offset: 0x0008BB84
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0001609B File Offset: 0x0001429B
		public unsafe float extraTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_extraTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_extraTime)) = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0008D9AC File Offset: 0x0008BBAC
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x000160B6 File Offset: 0x000142B6
		public unsafe float prevExtraTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevExtraTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevExtraTime)) = value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0008D9D4 File Offset: 0x0008BBD4
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x000160D1 File Offset: 0x000142D1
		public unsafe float distanceTraveled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_distanceTraveled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_distanceTraveled)) = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0008D9FC File Offset: 0x0008BBFC
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x000160EC File Offset: 0x000142EC
		public unsafe float prevDistanceTraveled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevDistanceTraveled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevDistanceTraveled)) = value;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0008DA24 File Offset: 0x0008BC24
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00016107 File Offset: 0x00014307
		public unsafe string steamName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_steamName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_steamName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0008DA4C File Offset: 0x0008BC4C
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00016126 File Offset: 0x00014326
		public unsafe Text names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0008DA7C File Offset: 0x0008BC7C
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00016145 File Offset: 0x00014345
		public unsafe Text distances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_distances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_distances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0008DAAC File Offset: 0x0008BCAC
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00016164 File Offset: 0x00014364
		public unsafe Text kills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_kills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_kills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0008DADC File Offset: 0x0008BCDC
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00016183 File Offset: 0x00014383
		public unsafe Text scores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_scores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_scores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0008DB0C File Offset: 0x0008BD0C
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x000161A2 File Offset: 0x000143A2
		public unsafe Il2CppReferenceArray<Level> levels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_levels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_levels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0008DB3C File Offset: 0x0008BD3C
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x000161C1 File Offset: 0x000143C1
		public unsafe Il2CppReferenceArray<Level> demoLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_demoLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_demoLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0008DB6C File Offset: 0x0008BD6C
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x000161E0 File Offset: 0x000143E0
		public unsafe Il2CppReferenceArray<Level> labLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_labLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_labLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0008DB9C File Offset: 0x0008BD9C
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x000161FF File Offset: 0x000143FF
		public unsafe Il2CppReferenceArray<Level> labLevelsHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_labLevelsHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_labLevelsHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0008DBCC File Offset: 0x0008BDCC
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x0001621E File Offset: 0x0001441E
		public unsafe Il2CppReferenceArray<Level> bunkerLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bunkerLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bunkerLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0008DBFC File Offset: 0x0008BDFC
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0001623D File Offset: 0x0001443D
		public unsafe Il2CppReferenceArray<Level> bunkerLevelsHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bunkerLevelsHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bunkerLevelsHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0008DC2C File Offset: 0x0008BE2C
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0001625C File Offset: 0x0001445C
		public unsafe Il2CppReferenceArray<Level> officeLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_officeLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_officeLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0008DC5C File Offset: 0x0008BE5C
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0001627B File Offset: 0x0001447B
		public unsafe Il2CppReferenceArray<Level> officeLevelsHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_officeLevelsHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_officeLevelsHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0008DC8C File Offset: 0x0008BE8C
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0001629A File Offset: 0x0001449A
		public unsafe Il2CppReferenceArray<Level> zooLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_zooLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_zooLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0008DCBC File Offset: 0x0008BEBC
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x000162B9 File Offset: 0x000144B9
		public unsafe Il2CppReferenceArray<Level> zooLevelsHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_zooLevelsHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_zooLevelsHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0008DCEC File Offset: 0x0008BEEC
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x000162D8 File Offset: 0x000144D8
		public unsafe Il2CppReferenceArray<Level> single
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_single);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_single), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0008DD1C File Offset: 0x0008BF1C
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x000162F7 File Offset: 0x000144F7
		public unsafe Il2CppReferenceArray<Level> singleHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_singleHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_singleHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0008DD4C File Offset: 0x0008BF4C
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00016316 File Offset: 0x00014516
		public unsafe Level curLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_curLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Level>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_curLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0008DD7C File Offset: 0x0008BF7C
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00016335 File Offset: 0x00014535
		public unsafe Callback<GameOverlayActivated_t> m_GameOverlayActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_m_GameOverlayActivated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<GameOverlayActivated_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_m_GameOverlayActivated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0008DDAC File Offset: 0x0008BFAC
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00016354 File Offset: 0x00014554
		public unsafe CallResult<LeaderboardScoreUploaded_t> LeaderboardScoreUploaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardScoreUploaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallResult<LeaderboardScoreUploaded_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardScoreUploaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0008DDDC File Offset: 0x0008BFDC
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00016373 File Offset: 0x00014573
		public unsafe CallResult<LeaderboardFindResult_t> LeaderboardFindResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardFindResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallResult<LeaderboardFindResult_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardFindResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0008DE0C File Offset: 0x0008C00C
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00016392 File Offset: 0x00014592
		public unsafe CallResult<LeaderboardScoresDownloaded_t> LeaderboardScoresDownloaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardScoresDownloaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallResult<LeaderboardScoresDownloaded_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardScoresDownloaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0008DE3C File Offset: 0x0008C03C
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x000163B1 File Offset: 0x000145B1
		public unsafe SteamLeaderboard_t m_SteamLeaderboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_m_SteamLeaderboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_m_SteamLeaderboard)) = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0008DE64 File Offset: 0x0008C064
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x000163CC File Offset: 0x000145CC
		public unsafe SteamLeaderboardEntries_t m_SteamLeaderboardEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_m_SteamLeaderboardEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_m_SteamLeaderboardEntries)) = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0008DE8C File Offset: 0x0008C08C
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x000163E7 File Offset: 0x000145E7
		public unsafe LeaderboardEntry_t LeaderboardEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardEntry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_LeaderboardEntry)) = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0008DEB4 File Offset: 0x0008C0B4
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00016402 File Offset: 0x00014602
		public unsafe int leaderboardLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_leaderboardLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_leaderboardLen)) = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0008DEDC File Offset: 0x0008C0DC
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x0001641D File Offset: 0x0001461D
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0008DF04 File Offset: 0x0008C104
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00016438 File Offset: 0x00014638
		public unsafe int totalLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_totalLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_totalLevels)) = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0008DF2C File Offset: 0x0008C12C
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00016453 File Offset: 0x00014653
		public unsafe List<Score> scoreList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_scoreList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Score>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_scoreList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0008DF5C File Offset: 0x0008C15C
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00016472 File Offset: 0x00014672
		public unsafe bool newGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_newGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_newGame)) = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0008DF84 File Offset: 0x0008C184
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x0001648D File Offset: 0x0001468D
		public unsafe bool fromMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_fromMenu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_fromMenu)) = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0008DFAC File Offset: 0x0008C1AC
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x000164A8 File Offset: 0x000146A8
		public unsafe bool fromGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_fromGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_fromGame)) = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0008DFD4 File Offset: 0x0008C1D4
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x000164C3 File Offset: 0x000146C3
		public unsafe bool incrementedLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_incrementedLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_incrementedLevel)) = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0008DFFC File Offset: 0x0008C1FC
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x000164DE File Offset: 0x000146DE
		public unsafe string curAlbumPlayerPref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_curAlbumPlayerPref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_curAlbumPlayerPref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0008E024 File Offset: 0x0008C224
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x000164FD File Offset: 0x000146FD
		public unsafe bool localLeaderboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_localLeaderboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_localLeaderboard)) = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0008E04C File Offset: 0x0008C24C
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00016518 File Offset: 0x00014718
		public unsafe int albumIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_albumIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_albumIndex)) = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0008E074 File Offset: 0x0008C274
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00016533 File Offset: 0x00014733
		public unsafe bool playedSideTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_playedSideTitle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_playedSideTitle)) = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0008E09C File Offset: 0x0008C29C
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x0001654E File Offset: 0x0001474E
		public unsafe bool seamless
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_seamless);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_seamless)) = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0008E0C4 File Offset: 0x0008C2C4
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x00016569 File Offset: 0x00014769
		public unsafe float lastTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_lastTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_lastTime)) = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0008E0EC File Offset: 0x0008C2EC
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x00016584 File Offset: 0x00014784
		public unsafe int lastKills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_lastKills);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_lastKills)) = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0008E114 File Offset: 0x0008C314
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0001659F File Offset: 0x0001479F
		public unsafe int introTitlesShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_introTitlesShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_introTitlesShown)) = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0008E13C File Offset: 0x0008C33C
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x000165BA File Offset: 0x000147BA
		public unsafe GameObject musicSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_musicSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_musicSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0008E16C File Offset: 0x0008C36C
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x000165D9 File Offset: 0x000147D9
		public unsafe GameObject soundMan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_soundMan);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_soundMan), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0008E19C File Offset: 0x0008C39C
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x000165F8 File Offset: 0x000147F8
		public unsafe bool unlocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_unlocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_unlocking)) = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0008E1C4 File Offset: 0x0008C3C4
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x00016613 File Offset: 0x00014813
		public unsafe bool mouseControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mouseControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mouseControl)) = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x0008E1EC File Offset: 0x0008C3EC
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x0001662E File Offset: 0x0001482E
		public unsafe Vector2 mousePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mousePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mousePos)) = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x0008E214 File Offset: 0x0008C414
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x00016649 File Offset: 0x00014849
		public unsafe Vector2 prevMPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevMPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_prevMPos)) = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0008E23C File Offset: 0x0008C43C
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x00016664 File Offset: 0x00014864
		public unsafe Vector2 mouseDelt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mouseDelt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_mouseDelt)) = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0008E264 File Offset: 0x0008C464
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x0001667F File Offset: 0x0001487F
		public unsafe int bananaMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bananaMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bananaMask)) = value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x0008E28C File Offset: 0x0008C48C
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x0001669A File Offset: 0x0001489A
		public unsafe int bananaLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bananaLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bananaLevel)) = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x000166B5 File Offset: 0x000148B5
		public unsafe bool friend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_friend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_friend)) = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0008E2DC File Offset: 0x0008C4DC
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x000166D0 File Offset: 0x000148D0
		public unsafe Il2CppStringArray controlStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_controlStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_controlStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x0008E30C File Offset: 0x0008C50C
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x000166EF File Offset: 0x000148EF
		public unsafe Il2CppStructArray<int> defControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_defControls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_defControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0008E33C File Offset: 0x0008C53C
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x0001670E File Offset: 0x0001490E
		public unsafe Il2CppStructArray<KeyCode> realControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_realControls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_realControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0008E36C File Offset: 0x0008C56C
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x0001672D File Offset: 0x0001492D
		public unsafe GameObject bagHolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bagHolder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_bagHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0008E39C File Offset: 0x0008C59C
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x0001674C File Offset: 0x0001494C
		public unsafe bool steam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_steam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_steam)) = value;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x0008E3C4 File Offset: 0x0008C5C4
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x00016767 File Offset: 0x00014967
		public unsafe static RenderTexture bloodRender2D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HealthMaster.NativeFieldInfoPtr_bloodRender2D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HealthMaster.NativeFieldInfoPtr_bloodRender2D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0008E3EC File Offset: 0x0008C5EC
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x00016779 File Offset: 0x00014979
		public unsafe bool didFullScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_didFullScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_didFullScreen)) = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x0008E414 File Offset: 0x0008C614
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00016794 File Offset: 0x00014994
		public unsafe bool laptopMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_laptopMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster.NativeFieldInfoPtr_laptopMode)) = value;
			}
		}

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeFieldInfoPtr_world;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_prevTime;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_prevScore;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_guardsKilled;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_prevguardsKilled;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_extraTime;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_prevExtraTime;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_distanceTraveled;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_prevDistanceTraveled;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_steamName;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_distances;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_kills;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_scores;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_levels;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_demoLevels;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeFieldInfoPtr_labLevels;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeFieldInfoPtr_labLevelsHard;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeFieldInfoPtr_bunkerLevels;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeFieldInfoPtr_bunkerLevelsHard;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_officeLevels;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_officeLevelsHard;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_zooLevels;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_zooLevelsHard;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_single;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_singleHard;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_curLevel;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr_m_GameOverlayActivated;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardScoreUploaded;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardFindResult;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardScoresDownloaded;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamLeaderboard;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamLeaderboardEntries;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardEntry;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeFieldInfoPtr_leaderboardLen;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr_totalLevels;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_scoreList;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_newGame;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_fromMenu;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_fromGame;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_incrementedLevel;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_curAlbumPlayerPref;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr_localLeaderboard;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeFieldInfoPtr_albumIndex;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr_playedSideTitle;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_seamless;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_lastTime;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_lastKills;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_introTitlesShown;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr_musicSystem;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeFieldInfoPtr_soundMan;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeFieldInfoPtr_unlocking;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeFieldInfoPtr_mouseControl;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeFieldInfoPtr_mousePos;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeFieldInfoPtr_prevMPos;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeFieldInfoPtr_mouseDelt;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeFieldInfoPtr_bananaMask;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeFieldInfoPtr_bananaLevel;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeFieldInfoPtr_friend;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeFieldInfoPtr_controlStrings;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeFieldInfoPtr_defControls;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_realControls;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_bagHolder;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_steam;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_bloodRender2D;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_didFullScreen;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_laptopMode;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxArea_Private_Int32_Il2CppReferenceArray_1_Level_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_CreateBloodRender_Private_IEnumerator_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleAlbInd_Public_Int32_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_GetUnlockedAlbums_Public_ObscuredInt_Boolean_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_OnApeDeath_Public_Void_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_GoFriends_Public_Void_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_GoGlobal_Public_Void_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_LevelWasLoaded_Public_Void_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_UpdateJson_Public_Void_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_GetAlbumEndLine_Public_List_1_Vector2_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_GetDeaths_Public_ObscuredInt_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Single_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_AddAlbumPPref_Public_Void_String_Single_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_IncrementLevel_Public_Void_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLeaderboard_Public_Void_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_DownloadLeaderboard_Public_Void_ELeaderboardDataRequest_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_OnLeaderboardFindResult_Public_Void_LeaderboardFindResult_t_Boolean_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_OnGameOverlayActivated_Public_Void_GameOverlayActivated_t_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_OnLeaderboardScoresDownloaded_Public_Void_LeaderboardScoresDownloaded_t_Boolean_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_OnLeaderboardScoreUploaded_Private_Void_LeaderboardScoreUploaded_t_Boolean_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_ResetShit_Public_Void_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_IsThisHighScore_Public_Boolean_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Public_Void_String_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_WriteScoreboard_Public_Void_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_ReadScoreboard_Public_Void_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030C RID: 780
		[OriginalName("Assembly-CSharp.dll", "", "Levels")]
		public enum Levels
		{
			// Token: 0x0400347A RID: 13434
			lab,
			// Token: 0x0400347B RID: 13435
			labHard,
			// Token: 0x0400347C RID: 13436
			office,
			// Token: 0x0400347D RID: 13437
			officeHard,
			// Token: 0x0400347E RID: 13438
			bunker,
			// Token: 0x0400347F RID: 13439
			bunkerHard,
			// Token: 0x04003480 RID: 13440
			boat,
			// Token: 0x04003481 RID: 13441
			boatHard,
			// Token: 0x04003482 RID: 13442
			single,
			// Token: 0x04003483 RID: 13443
			singleHard
		}

		// Token: 0x0200030D RID: 781
		[OriginalName("Assembly-CSharp.dll", "", "ActionID")]
		public enum ActionID
		{
			// Token: 0x04003485 RID: 13445
			push,
			// Token: 0x04003486 RID: 13446
			grab,
			// Token: 0x04003487 RID: 13447
			lStickX,
			// Token: 0x04003488 RID: 13448
			xxx,
			// Token: 0x04003489 RID: 13449
			lStickY,
			// Token: 0x0400348A RID: 13450
			xxxx,
			// Token: 0x0400348B RID: 13451
			xxxxx,
			// Token: 0x0400348C RID: 13452
			rStickX,
			// Token: 0x0400348D RID: 13453
			rStickY,
			// Token: 0x0400348E RID: 13454
			A,
			// Token: 0x0400348F RID: 13455
			B,
			// Token: 0x04003490 RID: 13456
			Start
		}

		// Token: 0x0200030E RID: 782
		[ObfuscatedName("HealthMaster+<CreateBloodRender>d__76")]
		public sealed class _CreateBloodRender_d__76 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FA8 RID: 20392 RVA: 0x001234E0 File Offset: 0x001216E0
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateBloodRender_d__76()
			{
				Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HealthMaster>.NativeClassPtr, "<CreateBloodRender>d__76");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr);
				HealthMaster._CreateBloodRender_d__76.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, "<>1__state");
				HealthMaster._CreateBloodRender_d__76.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, "<>2__current");
				HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, 100665832);
				HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, 100665833);
				HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, 100665834);
				HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, 100665835);
				HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, 100665836);
				HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr, 100665837);
			}

			// Token: 0x06004FA9 RID: 20393 RVA: 0x001235AC File Offset: 0x001217AC
			[CallerCount(0)]
			public unsafe _CreateBloodRender_d__76(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HealthMaster._CreateBloodRender_d__76>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FAA RID: 20394 RVA: 0x001235F4 File Offset: 0x001217F4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FAB RID: 20395 RVA: 0x00123628 File Offset: 0x00121828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66426, XrefRangeEnd = 66433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D0A RID: 7434
			// (get) Token: 0x06004FAC RID: 20396 RVA: 0x00123664 File Offset: 0x00121864
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FAD RID: 20397 RVA: 0x001236A4 File Offset: 0x001218A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66433, XrefRangeEnd = 66442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D0B RID: 7435
			// (get) Token: 0x06004FAE RID: 20398 RVA: 0x001236D8 File Offset: 0x001218D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthMaster._CreateBloodRender_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FAF RID: 20399 RVA: 0x0002E925 File Offset: 0x0002CB25
			public _CreateBloodRender_d__76(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D08 RID: 7432
			// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x00123718 File Offset: 0x00121918
			// (set) Token: 0x06004FB1 RID: 20401 RVA: 0x0002E92E File Offset: 0x0002CB2E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster._CreateBloodRender_d__76.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster._CreateBloodRender_d__76.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D09 RID: 7433
			// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x00123740 File Offset: 0x00121940
			// (set) Token: 0x06004FB3 RID: 20403 RVA: 0x0002E949 File Offset: 0x0002CB49
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster._CreateBloodRender_d__76.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthMaster._CreateBloodRender_d__76.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003491 RID: 13457
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003492 RID: 13458
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003493 RID: 13459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003494 RID: 13460
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003495 RID: 13461
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003496 RID: 13462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003497 RID: 13463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003498 RID: 13464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
