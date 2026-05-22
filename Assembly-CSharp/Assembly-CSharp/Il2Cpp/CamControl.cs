using System;
using Il2CppAudioHelm;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x0200009E RID: 158
	public class CamControl : MonoBehaviour
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x00069AA8 File Offset: 0x00067CA8
		// Note: this type is marked as 'beforefieldinit'.
		static CamControl()
		{
			Il2CppClassPointerStore<CamControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CamControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl>.NativeClassPtr);
			CamControl.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "me");
			CamControl.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "player");
			CamControl.NativeFieldInfoPtr_pState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "pState");
			CamControl.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "head");
			CamControl.NativeFieldInfoPtr_lookBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "lookBias");
			CamControl.NativeFieldInfoPtr_pushTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "pushTrack");
			CamControl.NativeFieldInfoPtr_justTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "justTracked");
			CamControl.NativeFieldInfoPtr_tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "tracked");
			CamControl.NativeFieldInfoPtr_prevTrackedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "prevTrackedPos");
			CamControl.NativeFieldInfoPtr_trackTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "trackTimer");
			CamControl.NativeFieldInfoPtr_newTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "newTrack");
			CamControl.NativeFieldInfoPtr_initTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "initTimer");
			CamControl.NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "room");
			CamControl.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "dead");
			CamControl.NativeFieldInfoPtr_freed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "freed");
			CamControl.NativeFieldInfoPtr_shaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shaking");
			CamControl.NativeFieldInfoPtr_shakeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shakeAmount");
			CamControl.NativeFieldInfoPtr_truePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "truePos");
			CamControl.NativeFieldInfoPtr_shakeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shakeTimer");
			CamControl.NativeFieldInfoPtr_guardsKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "guardsKilled");
			CamControl.NativeFieldInfoPtr_dying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "dying");
			CamControl.NativeFieldInfoPtr_backgrnds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "backgrnds");
			CamControl.NativeFieldInfoPtr_flash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "flash");
			CamControl.NativeFieldInfoPtr_flashMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "flashMats");
			CamControl.NativeFieldInfoPtr_gameEndText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "gameEndText");
			CamControl.NativeFieldInfoPtr_blackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "blackScreen");
			CamControl.NativeFieldInfoPtr_duckedSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "duckedSnap");
			CamControl.NativeFieldInfoPtr_normalSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "normalSnap");
			CamControl.NativeFieldInfoPtr_pMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "pMove");
			CamControl.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "cam");
			CamControl.NativeFieldInfoPtr_lives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "lives");
			CamControl.NativeFieldInfoPtr_livesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "livesText");
			CamControl.NativeFieldInfoPtr_gameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "gameOver");
			CamControl.NativeFieldInfoPtr_leaderboarded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "leaderboarded");
			CamControl.NativeFieldInfoPtr_leaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "leaderboard");
			CamControl.NativeFieldInfoPtr_uploadCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "uploadCalled");
			CamControl.NativeFieldInfoPtr_killsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "killsText");
			CamControl.NativeFieldInfoPtr_timeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "timeText");
			CamControl.NativeFieldInfoPtr_bonusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "bonusText");
			CamControl.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "scoreText");
			CamControl.NativeFieldInfoPtr_scoreTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "scoreTitle");
			CamControl.NativeFieldInfoPtr_killsScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "killsScoreText");
			CamControl.NativeFieldInfoPtr_timeScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "timeScoreText");
			CamControl.NativeFieldInfoPtr_bonusScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "bonusScoreText");
			CamControl.NativeFieldInfoPtr_endLevelUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "endLevelUI");
			CamControl.NativeFieldInfoPtr_levelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "levelText");
			CamControl.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "velocity");
			CamControl.NativeFieldInfoPtr_enterInitScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "enterInitScreen");
			CamControl.NativeFieldInfoPtr_pastInitScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "pastInitScreen");
			CamControl.NativeFieldInfoPtr_addedScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "addedScore");
			CamControl.NativeFieldInfoPtr_zoomedOutFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "zoomedOutFlag");
			CamControl.NativeFieldInfoPtr_camLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "camLocked");
			CamControl.NativeFieldInfoPtr_lockedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "lockedPos");
			CamControl.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "offSet");
			CamControl.NativeFieldInfoPtr_flashTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "flashTimer");
			CamControl.NativeFieldInfoPtr_flashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "flashing");
			CamControl.NativeFieldInfoPtr_flashCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "flashCol");
			CamControl.NativeFieldInfoPtr_stencilQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "stencilQuad");
			CamControl.NativeFieldInfoPtr_stencils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "stencils");
			CamControl.NativeFieldInfoPtr_retryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "retryText");
			CamControl.NativeFieldInfoPtr_albumEndings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "albumEndings");
			CamControl.NativeFieldInfoPtr_albumEndDeathText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "albumEndDeathText");
			CamControl.NativeFieldInfoPtr_albumEndTimeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "albumEndTimeText");
			CamControl.NativeFieldInfoPtr_officeViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "officeViews");
			CamControl.NativeFieldInfoPtr_turnOnForDeathScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "turnOnForDeathScreen");
			CamControl.NativeFieldInfoPtr_officeDeadStuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "officeDeadStuff");
			CamControl.NativeFieldInfoPtr_nonStencilFloorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "nonStencilFloorMat");
			CamControl.NativeFieldInfoPtr_stencilFloorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "stencilFloorMat");
			CamControl.NativeFieldInfoPtr_hurtFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "hurtFlash");
			CamControl.NativeFieldInfoPtr_baseSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "baseSize");
			CamControl.NativeFieldInfoPtr_desPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "desPos");
			CamControl.NativeFieldInfoPtr_albumUnlockScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "albumUnlockScreens");
			CamControl.NativeFieldInfoPtr_boatSway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "boatSway");
			CamControl.NativeFieldInfoPtr_boatSwayCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "boatSwayCurve");
			CamControl.NativeFieldInfoPtr_whiteScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "whiteScreen");
			CamControl.NativeFieldInfoPtr_arcadeModeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "arcadeModeUI");
			CamControl.NativeFieldInfoPtr_notePlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "notePlayed");
			CamControl.NativeFieldInfoPtr_deadText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadText");
			CamControl.NativeFieldInfoPtr_discText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "discText");
			CamControl.NativeFieldInfoPtr_deadCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadCam");
			CamControl.NativeFieldInfoPtr_deadQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadQuad");
			CamControl.NativeFieldInfoPtr_deadStencilQuadPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadStencilQuadPrefab");
			CamControl.NativeFieldInfoPtr_deadStencils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadStencils");
			CamControl.NativeFieldInfoPtr_deathRenders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deathRenders");
			CamControl.NativeFieldInfoPtr_cameraWobble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "cameraWobble");
			CamControl.NativeFieldInfoPtr_deadBlackQuadPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadBlackQuadPrefab");
			CamControl.NativeFieldInfoPtr_deadBlackQuads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadBlackQuads");
			CamControl.NativeFieldInfoPtr_stencilStrip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "stencilStrip");
			CamControl.NativeFieldInfoPtr_floorQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "floorQuad");
			CamControl.NativeFieldInfoPtr_distTraved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "distTraved");
			CamControl.NativeFieldInfoPtr_fullScreenStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "fullScreenStencil");
			CamControl.NativeFieldInfoPtr_leaderHeading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "leaderHeading");
			CamControl.NativeFieldInfoPtr_prevStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "prevStick");
			CamControl.NativeFieldInfoPtr_deathNotesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deathNotesPlayed");
			CamControl.NativeFieldInfoPtr_lastNoteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "lastNoteTime");
			CamControl.NativeFieldInfoPtr_startedReloadingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "startedReloadingLevel");
			CamControl.NativeFieldInfoPtr_finishedDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "finishedDeath");
			CamControl.NativeFieldInfoPtr_screenShakeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "screenShakeAmount");
			CamControl.NativeFieldInfoPtr_beatArcade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "beatArcade");
			CamControl.NativeFieldInfoPtr_tickingInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "tickingInstance");
			CamControl.NativeFieldInfoPtr_shakeVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shakeVel");
			CamControl.NativeFieldInfoPtr_shakeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shakeOffset");
			CamControl.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "prevPos");
			CamControl.NativeFieldInfoPtr_prevPosV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "prevPosV2");
			CamControl.NativeFieldInfoPtr_deadFloorQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "deadFloorQuad");
			CamControl.NativeFieldInfoPtr_localHighScoreScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "localHighScoreScreen");
			CamControl.NativeFieldInfoPtr_highScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "highScore");
			CamControl.NativeFieldInfoPtr_thisScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "thisScore");
			CamControl.NativeFieldInfoPtr_numThisScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "numThisScore");
			CamControl.NativeFieldInfoPtr_shakeDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shakeDecay");
			CamControl.NativeFieldInfoPtr_shakeMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shakeMult");
			CamControl.NativeFieldInfoPtr_amountMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "amountMult");
			CamControl.NativeFieldInfoPtr_textLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "textLoader");
			CamControl.NativeFieldInfoPtr_menuRestarting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "menuRestarting");
			CamControl.NativeFieldInfoPtr_shadowCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shadowCam");
			CamControl.NativeFieldInfoPtr_shadowQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "shadowQuad");
			CamControl.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664885);
			CamControl.NativeMethodInfoPtr_SetFloorQuadMat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664886);
			CamControl.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664887);
			CamControl.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664888);
			CamControl.NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664889);
			CamControl.NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664890);
			CamControl.NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664891);
			CamControl.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664892);
			CamControl.NativeMethodInfoPtr_GiveInputBack_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664893);
			CamControl.NativeMethodInfoPtr_LockCamera_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664894);
			CamControl.NativeMethodInfoPtr_UnlockCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664895);
			CamControl.NativeMethodInfoPtr_CancelShake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664896);
			CamControl.NativeMethodInfoPtr_Shake_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664897);
			CamControl.NativeMethodInfoPtr_OnPusher_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664898);
			CamControl.NativeMethodInfoPtr_OnEndPush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664899);
			CamControl.NativeMethodInfoPtr_Death_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664900);
			CamControl.NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664901);
			CamControl.NativeMethodInfoPtr_Flash_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664902);
			CamControl.NativeMethodInfoPtr_HurtFlash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664903);
			CamControl.NativeMethodInfoPtr_Flash_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664904);
			CamControl.NativeMethodInfoPtr_FlashCo_Private_IEnumerator_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664905);
			CamControl.NativeMethodInfoPtr_DeadTrailer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664906);
			CamControl.NativeMethodInfoPtr_FellOutWindow_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664907);
			CamControl.NativeMethodInfoPtr_NotePlayed_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664908);
			CamControl.NativeMethodInfoPtr_SetNotePlayed_Private_Void_Note_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664909);
			CamControl.NativeMethodInfoPtr_TransitionFailSafe_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664910);
			CamControl.NativeMethodInfoPtr_EndTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664911);
			CamControl.NativeMethodInfoPtr_DeadCam_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664912);
			CamControl.NativeMethodInfoPtr_ResetStencilMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664913);
			CamControl.NativeMethodInfoPtr_GenerateStencilMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664914);
			CamControl.NativeMethodInfoPtr_AlbumEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664915);
			CamControl.NativeMethodInfoPtr_SaveMyWin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664916);
			CamControl.NativeMethodInfoPtr_AlbumEnder_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664917);
			CamControl.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664918);
			CamControl.NativeMethodInfoPtr_StringifyTime_Public_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664919);
			CamControl.NativeMethodInfoPtr_GetTime_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664920);
			CamControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664921);
			CamControl.NativeMethodInfoPtr__DeadCam_b__143_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664922);
			CamControl.NativeMethodInfoPtr__DeadCam_b__143_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664923);
			CamControl.NativeMethodInfoPtr__DeadCam_b__143_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664924);
			CamControl.NativeMethodInfoPtr__DeadCam_b__143_3_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl>.NativeClassPtr, 100664925);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0006A71C File Offset: 0x0006891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50743, XrefRangeEnd = 50755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0006A750 File Offset: 0x00068950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50755, XrefRangeEnd = 50772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloorQuadMat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_SetFloorQuadMat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0006A784 File Offset: 0x00068984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50772, XrefRangeEnd = 50778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0006A7B8 File Offset: 0x000689B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50778, XrefRangeEnd = 50830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0006A7EC File Offset: 0x000689EC
		[CallerCount(0)]
		public unsafe bool OnScreen(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0006A838 File Offset: 0x00068A38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 50830, RefRangeEnd = 50835, XrefRangeStart = 50830, XrefRangeEnd = 50830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnScreen(Vector2 pt, float percentBuf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentBuf;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0006A890 File Offset: 0x00068A90
		[CallerCount(0)]
		public unsafe bool OnScreen(Vector3 pt, float percentBuf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentBuf;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0006A8E8 File Offset: 0x00068AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50835, XrefRangeEnd = 51192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0006A91C File Offset: 0x00068B1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51195, RefRangeEnd = 51197, XrefRangeStart = 51192, XrefRangeEnd = 51195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GiveInputBack(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_GiveInputBack_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0006A968 File Offset: 0x00068B68
		[CallerCount(0)]
		public unsafe void LockCamera(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_LockCamera_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0006A9A8 File Offset: 0x00068BA8
		[CallerCount(0)]
		public unsafe void UnlockCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_UnlockCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0006A9DC File Offset: 0x00068BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51197, XrefRangeEnd = 51199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelShake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_CancelShake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0006AA10 File Offset: 0x00068C10
		[CallerCount(0)]
		public unsafe void Shake(Vector2 amount, float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Shake_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0006AA5C File Offset: 0x00068C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51199, XrefRangeEnd = 51201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPusher(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_OnPusher_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0006AAA0 File Offset: 0x00068CA0
		[CallerCount(0)]
		public unsafe void OnEndPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_OnEndPush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0006AAD4 File Offset: 0x00068CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51264, RefRangeEnd = 51265, XrefRangeStart = 51201, XrefRangeEnd = 51264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Death()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Death_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0006AB08 File Offset: 0x00068D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51265, XrefRangeEnd = 51268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Bullshit(float blamo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blamo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0006AB54 File Offset: 0x00068D54
		[CallerCount(0)]
		public unsafe void Flash(Color col, float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref col;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Flash_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0006ABA0 File Offset: 0x00068DA0
		[CallerCount(0)]
		public unsafe void HurtFlash(float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dur;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_HurtFlash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0006ABE0 File Offset: 0x00068DE0
		[CallerCount(0)]
		public unsafe void Flash(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref col;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Flash_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0006AC20 File Offset: 0x00068E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51268, XrefRangeEnd = 51271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FlashCo(Color col, int dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref col;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_FlashCo_Private_IEnumerator_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0006AC7C File Offset: 0x00068E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51271, XrefRangeEnd = 51274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeadTrailer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_DeadTrailer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0006ACBC File Offset: 0x00068EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51274, XrefRangeEnd = 51277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FellOutWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_FellOutWindow_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0006ACFC File Offset: 0x00068EFC
		[CallerCount(0)]
		public unsafe bool NotePlayed(int thresh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thresh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_NotePlayed_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0006AD48 File Offset: 0x00068F48
		[CallerCount(0)]
		public unsafe void SetNotePlayed(Note boop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref boop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_SetNotePlayed_Private_Void_Note_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0006AD88 File Offset: 0x00068F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51277, XrefRangeEnd = 51280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TransitionFailSafe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_TransitionFailSafe_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0006ADC8 File Offset: 0x00068FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51280, XrefRangeEnd = 51284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_EndTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0006ADFC File Offset: 0x00068FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51284, XrefRangeEnd = 51287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeadCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_DeadCam_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0006AE3C File Offset: 0x0006903C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51294, RefRangeEnd = 51295, XrefRangeStart = 51287, XrefRangeEnd = 51294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStencilMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_ResetStencilMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0006AE70 File Offset: 0x00069070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51319, RefRangeEnd = 51320, XrefRangeStart = 51295, XrefRangeEnd = 51319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateStencilMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_GenerateStencilMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0006AEA4 File Offset: 0x000690A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 51324, RefRangeEnd = 51328, XrefRangeStart = 51320, XrefRangeEnd = 51324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlbumEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_AlbumEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0006AED8 File Offset: 0x000690D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51585, RefRangeEnd = 51586, XrefRangeStart = 51328, XrefRangeEnd = 51585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveMyWin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_SaveMyWin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0006AF0C File Offset: 0x0006910C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51586, XrefRangeEnd = 51589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AlbumEnder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_AlbumEnder_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0006AF4C File Offset: 0x0006914C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51614, RefRangeEnd = 51615, XrefRangeStart = 51589, XrefRangeEnd = 51614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_Free_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0006AF80 File Offset: 0x00069180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51706, RefRangeEnd = 51708, XrefRangeStart = 51615, XrefRangeEnd = 51706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string StringifyTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_StringifyTime_Public_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0006AFC4 File Offset: 0x000691C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51708, XrefRangeEnd = 51716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr_GetTime_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0006AFFC File Offset: 0x000691FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51716, XrefRangeEnd = 51725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CamControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0006B038 File Offset: 0x00069238
		[CallerCount(0)]
		public unsafe bool _DeadCam_b__143_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr__DeadCam_b__143_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0006B074 File Offset: 0x00069274
		[CallerCount(0)]
		public unsafe bool _DeadCam_b__143_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr__DeadCam_b__143_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0006B0B0 File Offset: 0x000692B0
		[CallerCount(0)]
		public unsafe bool _DeadCam_b__143_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr__DeadCam_b__143_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0006B0EC File Offset: 0x000692EC
		[CallerCount(0)]
		public unsafe bool _DeadCam_b__143_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl.NativeMethodInfoPtr__DeadCam_b__143_3_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0000DA22 File Offset: 0x0000BC22
		public CamControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x0006B128 File Offset: 0x00069328
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x0000DA2B File Offset: 0x0000BC2B
		public unsafe static CamControl me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CamControl.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CamControl.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x0006B150 File Offset: 0x00069350
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x0000DA3D File Offset: 0x0000BC3D
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x0006B180 File Offset: 0x00069380
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		public unsafe PlayerState pState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x0006B1B0 File Offset: 0x000693B0
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x0000DA7B File Offset: 0x0000BC7B
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x0006B1E0 File Offset: 0x000693E0
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x0000DA9A File Offset: 0x0000BC9A
		public unsafe float lookBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lookBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lookBias)) = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0006B208 File Offset: 0x00069408
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x0000DAB5 File Offset: 0x0000BCB5
		public unsafe bool pushTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pushTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pushTrack)) = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x0006B230 File Offset: 0x00069430
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		public unsafe bool justTracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_justTracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_justTracked)) = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0006B258 File Offset: 0x00069458
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x0000DAEB File Offset: 0x0000BCEB
		public unsafe Transform tracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_tracked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_tracked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0006B288 File Offset: 0x00069488
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x0000DB0A File Offset: 0x0000BD0A
		public unsafe Vector2 prevTrackedPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevTrackedPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevTrackedPos)) = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0006B2B0 File Offset: 0x000694B0
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x0000DB25 File Offset: 0x0000BD25
		public unsafe float trackTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_trackTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_trackTimer)) = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0006B2D8 File Offset: 0x000694D8
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x0000DB40 File Offset: 0x0000BD40
		public unsafe bool newTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_newTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_newTrack)) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0006B300 File Offset: 0x00069500
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x0000DB5B File Offset: 0x0000BD5B
		public unsafe float initTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_initTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_initTimer)) = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x0006B328 File Offset: 0x00069528
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x0000DB76 File Offset: 0x0000BD76
		public unsafe RoomState room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_room);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoomState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_room), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x0006B358 File Offset: 0x00069558
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x0000DB95 File Offset: 0x0000BD95
		public unsafe bool dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x0006B380 File Offset: 0x00069580
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public unsafe bool freed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_freed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_freed)) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x0006B3A8 File Offset: 0x000695A8
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x0000DBCB File Offset: 0x0000BDCB
		public unsafe bool shaking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shaking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shaking)) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0006B3D0 File Offset: 0x000695D0
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x0000DBE6 File Offset: 0x0000BDE6
		public unsafe Vector2 shakeAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeAmount)) = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0006B3F8 File Offset: 0x000695F8
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x0000DC01 File Offset: 0x0000BE01
		public unsafe Vector2 truePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_truePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_truePos)) = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0006B420 File Offset: 0x00069620
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		public unsafe float shakeTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeTimer)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x0006B448 File Offset: 0x00069648
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x0000DC37 File Offset: 0x0000BE37
		public unsafe int guardsKilled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_guardsKilled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_guardsKilled)) = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x0006B470 File Offset: 0x00069670
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x0000DC52 File Offset: 0x0000BE52
		public unsafe bool dying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_dying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_dying)) = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0006B498 File Offset: 0x00069698
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x0000DC6D File Offset: 0x0000BE6D
		public unsafe Il2CppReferenceArray<GameObject> backgrnds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_backgrnds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_backgrnds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0006B4C8 File Offset: 0x000696C8
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		public unsafe SpriteRenderer flash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0006B4F8 File Offset: 0x000696F8
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0000DCAB File Offset: 0x0000BEAB
		public unsafe Il2CppReferenceArray<Material> flashMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0006B528 File Offset: 0x00069728
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x0000DCCA File Offset: 0x0000BECA
		public unsafe GameObject gameEndText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_gameEndText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_gameEndText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x0006B558 File Offset: 0x00069758
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x0000DCE9 File Offset: 0x0000BEE9
		public unsafe GameObject blackScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_blackScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_blackScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0006B588 File Offset: 0x00069788
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x0000DD08 File Offset: 0x0000BF08
		public unsafe AudioMixerSnapshot duckedSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_duckedSnap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_duckedSnap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0006B5B8 File Offset: 0x000697B8
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0000DD27 File Offset: 0x0000BF27
		public unsafe AudioMixerSnapshot normalSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_normalSnap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_normalSnap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0006B5E8 File Offset: 0x000697E8
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0000DD46 File Offset: 0x0000BF46
		public unsafe PlayerMovement pMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0006B618 File Offset: 0x00069818
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x0000DD65 File Offset: 0x0000BF65
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0006B648 File Offset: 0x00069848
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x0000DD84 File Offset: 0x0000BF84
		public unsafe GameObject lives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0006B678 File Offset: 0x00069878
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x0000DDA3 File Offset: 0x0000BFA3
		public unsafe Text livesText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_livesText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_livesText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0006B6A8 File Offset: 0x000698A8
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x0000DDC2 File Offset: 0x0000BFC2
		public unsafe GameObject gameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_gameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_gameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0006B6D8 File Offset: 0x000698D8
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x0000DDE1 File Offset: 0x0000BFE1
		public unsafe bool leaderboarded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_leaderboarded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_leaderboarded)) = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0006B700 File Offset: 0x00069900
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		public unsafe GameObject leaderboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_leaderboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_leaderboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x0006B730 File Offset: 0x00069930
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x0000DE1B File Offset: 0x0000C01B
		public unsafe bool uploadCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_uploadCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_uploadCalled)) = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x0006B758 File Offset: 0x00069958
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x0000DE36 File Offset: 0x0000C036
		public unsafe Text killsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_killsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_killsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0006B788 File Offset: 0x00069988
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x0000DE55 File Offset: 0x0000C055
		public unsafe Text timeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_timeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_timeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0006B7B8 File Offset: 0x000699B8
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x0000DE74 File Offset: 0x0000C074
		public unsafe Text bonusText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_bonusText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_bonusText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0006B7E8 File Offset: 0x000699E8
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x0000DE93 File Offset: 0x0000C093
		public unsafe Text scoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_scoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0006B818 File Offset: 0x00069A18
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x0000DEB2 File Offset: 0x0000C0B2
		public unsafe Text scoreTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_scoreTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_scoreTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0006B848 File Offset: 0x00069A48
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x0000DED1 File Offset: 0x0000C0D1
		public unsafe Text killsScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_killsScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_killsScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0006B878 File Offset: 0x00069A78
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		public unsafe Text timeScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_timeScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_timeScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0006B8A8 File Offset: 0x00069AA8
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x0000DF0F File Offset: 0x0000C10F
		public unsafe Text bonusScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_bonusScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_bonusScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0006B8D8 File Offset: 0x00069AD8
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x0000DF2E File Offset: 0x0000C12E
		public unsafe GameObject endLevelUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_endLevelUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_endLevelUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0006B908 File Offset: 0x00069B08
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x0000DF4D File Offset: 0x0000C14D
		public unsafe Text levelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_levelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_levelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0006B938 File Offset: 0x00069B38
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x0000DF6C File Offset: 0x0000C16C
		public unsafe Vector2 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0006B960 File Offset: 0x00069B60
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0000DF87 File Offset: 0x0000C187
		public unsafe GameObject enterInitScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_enterInitScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_enterInitScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0006B990 File Offset: 0x00069B90
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x0000DFA6 File Offset: 0x0000C1A6
		public unsafe bool pastInitScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pastInitScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_pastInitScreen)) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0006B9B8 File Offset: 0x00069BB8
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x0000DFC1 File Offset: 0x0000C1C1
		public unsafe bool addedScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_addedScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_addedScore)) = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0006B9E0 File Offset: 0x00069BE0
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		public unsafe bool zoomedOutFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_zoomedOutFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_zoomedOutFlag)) = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0006BA08 File Offset: 0x00069C08
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0000DFF7 File Offset: 0x0000C1F7
		public unsafe bool camLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_camLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_camLocked)) = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0006BA30 File Offset: 0x00069C30
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x0000E012 File Offset: 0x0000C212
		public unsafe Vector2 lockedPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lockedPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lockedPos)) = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0006BA58 File Offset: 0x00069C58
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0000E02D File Offset: 0x0000C22D
		public unsafe Vector2 offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x0006BA80 File Offset: 0x00069C80
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x0000E048 File Offset: 0x0000C248
		public unsafe float flashTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashTimer)) = value;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0006BAA8 File Offset: 0x00069CA8
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000E063 File Offset: 0x0000C263
		public unsafe bool flashing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashing)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0006BAD0 File Offset: 0x00069CD0
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000E07E File Offset: 0x0000C27E
		public unsafe Color flashCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_flashCol)) = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0006BAF8 File Offset: 0x00069CF8
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0000E099 File Offset: 0x0000C299
		public unsafe GameObject stencilQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencilQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencilQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0006BB28 File Offset: 0x00069D28
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		public unsafe Il2CppReferenceArray<GameObject> stencils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0006BB58 File Offset: 0x00069D58
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
		public unsafe GameObject retryText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_retryText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_retryText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0006BB88 File Offset: 0x00069D88
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		public unsafe Il2CppReferenceArray<GameObject> albumEndings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumEndings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumEndings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0006BBB8 File Offset: 0x00069DB8
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x0000E115 File Offset: 0x0000C315
		public unsafe Il2CppReferenceArray<TextMesh> albumEndDeathText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumEndDeathText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumEndDeathText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0006BBE8 File Offset: 0x00069DE8
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x0000E134 File Offset: 0x0000C334
		public unsafe Il2CppReferenceArray<TextMesh> albumEndTimeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumEndTimeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumEndTimeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0006BC18 File Offset: 0x00069E18
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x0000E153 File Offset: 0x0000C353
		public unsafe List<OfficeViewManager> officeViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_officeViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<OfficeViewManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_officeViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0006BC48 File Offset: 0x00069E48
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0000E172 File Offset: 0x0000C372
		public unsafe List<GameObject> turnOnForDeathScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_turnOnForDeathScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_turnOnForDeathScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0006BC78 File Offset: 0x00069E78
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x0000E191 File Offset: 0x0000C391
		public unsafe GameObject officeDeadStuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_officeDeadStuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_officeDeadStuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0006BCA8 File Offset: 0x00069EA8
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		public unsafe Material nonStencilFloorMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_nonStencilFloorMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_nonStencilFloorMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0006BCD8 File Offset: 0x00069ED8
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x0000E1CF File Offset: 0x0000C3CF
		public unsafe Material stencilFloorMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencilFloorMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencilFloorMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0006BD08 File Offset: 0x00069F08
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0000E1EE File Offset: 0x0000C3EE
		public unsafe bool hurtFlash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_hurtFlash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_hurtFlash)) = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0006BD30 File Offset: 0x00069F30
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0000E209 File Offset: 0x0000C409
		public unsafe float baseSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_baseSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_baseSize)) = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0006BD58 File Offset: 0x00069F58
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000E224 File Offset: 0x0000C424
		public unsafe Vector2 desPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_desPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_desPos)) = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x0006BD80 File Offset: 0x00069F80
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x0000E23F File Offset: 0x0000C43F
		public unsafe Il2CppReferenceArray<GameObject> albumUnlockScreens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumUnlockScreens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_albumUnlockScreens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0006BDB0 File Offset: 0x00069FB0
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0000E25E File Offset: 0x0000C45E
		public unsafe float boatSway
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_boatSway);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_boatSway)) = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0006BDD8 File Offset: 0x00069FD8
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x0000E279 File Offset: 0x0000C479
		public unsafe AnimationCurve boatSwayCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_boatSwayCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_boatSwayCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0006BE08 File Offset: 0x0006A008
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x0000E298 File Offset: 0x0000C498
		public unsafe GameObject whiteScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_whiteScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_whiteScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0006BE38 File Offset: 0x0006A038
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x0000E2B7 File Offset: 0x0000C4B7
		public unsafe Il2CppReferenceArray<TextMesh> arcadeModeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_arcadeModeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_arcadeModeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0006BE68 File Offset: 0x0006A068
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000E2D6 File Offset: 0x0000C4D6
		public unsafe bool notePlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_notePlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_notePlayed)) = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0006BE90 File Offset: 0x0006A090
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x0000E2F1 File Offset: 0x0000C4F1
		public unsafe GameObject deadText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0006BEC0 File Offset: 0x0006A0C0
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0000E310 File Offset: 0x0000C510
		public unsafe Il2CppReferenceArray<GameObject> discText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_discText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_discText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0006BEF0 File Offset: 0x0006A0F0
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000E32F File Offset: 0x0000C52F
		public unsafe Camera deadCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0006BF20 File Offset: 0x0006A120
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000E34E File Offset: 0x0000C54E
		public unsafe GameObject deadQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0006BF50 File Offset: 0x0006A150
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000E36D File Offset: 0x0000C56D
		public unsafe GameObject deadStencilQuadPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadStencilQuadPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadStencilQuadPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0006BF80 File Offset: 0x0006A180
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000E38C File Offset: 0x0000C58C
		public unsafe Il2CppReferenceArray<GameObject> deadStencils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadStencils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadStencils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0006BFB0 File Offset: 0x0006A1B0
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0000E3AB File Offset: 0x0000C5AB
		public unsafe Il2CppReferenceArray<RenderTexture> deathRenders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deathRenders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deathRenders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0006BFE0 File Offset: 0x0006A1E0
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x0000E3CA File Offset: 0x0000C5CA
		public unsafe Transform cameraWobble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_cameraWobble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_cameraWobble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0006C010 File Offset: 0x0006A210
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x0000E3E9 File Offset: 0x0000C5E9
		public unsafe GameObject deadBlackQuadPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadBlackQuadPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadBlackQuadPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0006C040 File Offset: 0x0006A240
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x0000E408 File Offset: 0x0000C608
		public unsafe Il2CppReferenceArray<GameObject> deadBlackQuads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadBlackQuads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadBlackQuads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0006C070 File Offset: 0x0006A270
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000E427 File Offset: 0x0000C627
		public unsafe GameObject stencilStrip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencilStrip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_stencilStrip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0006C0A0 File Offset: 0x0006A2A0
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x0000E446 File Offset: 0x0000C646
		public unsafe GameObject floorQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_floorQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_floorQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x0006C0D0 File Offset: 0x0006A2D0
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x0000E465 File Offset: 0x0000C665
		public unsafe float distTraved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_distTraved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_distTraved)) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0006C0F8 File Offset: 0x0006A2F8
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x0000E480 File Offset: 0x0000C680
		public unsafe GameObject fullScreenStencil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_fullScreenStencil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_fullScreenStencil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0006C128 File Offset: 0x0006A328
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x0000E49F File Offset: 0x0000C69F
		public unsafe Text leaderHeading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_leaderHeading);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_leaderHeading), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0006C158 File Offset: 0x0006A358
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x0000E4BE File Offset: 0x0000C6BE
		public unsafe float prevStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevStick)) = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x0006C180 File Offset: 0x0006A380
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x0000E4D9 File Offset: 0x0000C6D9
		public unsafe int deathNotesPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deathNotesPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deathNotesPlayed)) = value;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0006C1A8 File Offset: 0x0006A3A8
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public unsafe float lastNoteTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lastNoteTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_lastNoteTime)) = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0006C1D0 File Offset: 0x0006A3D0
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x0000E50F File Offset: 0x0000C70F
		public unsafe bool startedReloadingLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_startedReloadingLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_startedReloadingLevel)) = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0006C1F8 File Offset: 0x0006A3F8
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0000E52A File Offset: 0x0000C72A
		public unsafe bool finishedDeath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_finishedDeath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_finishedDeath)) = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0006C220 File Offset: 0x0006A420
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x0000E545 File Offset: 0x0000C745
		public unsafe float screenShakeAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_screenShakeAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_screenShakeAmount)) = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0006C248 File Offset: 0x0006A448
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x0000E560 File Offset: 0x0000C760
		public unsafe bool beatArcade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_beatArcade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_beatArcade)) = value;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0006C270 File Offset: 0x0006A470
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x0000E57B File Offset: 0x0000C77B
		public SECTR_AudioCueInstance tickingInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_tickingInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_tickingInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0006C2A0 File Offset: 0x0006A4A0
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0000E5A9 File Offset: 0x0000C7A9
		public unsafe Vector2 shakeVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeVel)) = value;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0006C2C8 File Offset: 0x0006A4C8
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
		public unsafe Vector2 shakeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeOffset)) = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0006C2F0 File Offset: 0x0006A4F0
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x0000E5DF File Offset: 0x0000C7DF
		public unsafe Vector3 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0006C318 File Offset: 0x0006A518
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0000E5FA File Offset: 0x0000C7FA
		public unsafe Vector2 prevPosV2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevPosV2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_prevPosV2)) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0006C340 File Offset: 0x0006A540
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x0000E615 File Offset: 0x0000C815
		public unsafe GameObject deadFloorQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadFloorQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_deadFloorQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0006C370 File Offset: 0x0006A570
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0000E634 File Offset: 0x0000C834
		public unsafe GameObject localHighScoreScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_localHighScoreScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_localHighScoreScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0006C3A0 File Offset: 0x0006A5A0
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0000E653 File Offset: 0x0000C853
		public unsafe TextMesh highScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_highScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_highScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0006C3D0 File Offset: 0x0006A5D0
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0000E672 File Offset: 0x0000C872
		public unsafe TextMesh thisScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_thisScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_thisScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0006C400 File Offset: 0x0006A600
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000E691 File Offset: 0x0000C891
		public unsafe TextMesh numThisScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_numThisScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_numThisScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0006C430 File Offset: 0x0006A630
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
		public unsafe float shakeDecay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeDecay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeDecay)) = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0006C458 File Offset: 0x0006A658
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0000E6CB File Offset: 0x0000C8CB
		public unsafe float shakeMult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeMult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shakeMult)) = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0006C480 File Offset: 0x0006A680
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0000E6E6 File Offset: 0x0000C8E6
		public unsafe float amountMult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_amountMult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_amountMult)) = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0006C4A8 File Offset: 0x0006A6A8
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0000E701 File Offset: 0x0000C901
		public unsafe GameObject textLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_textLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_textLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0006C4D8 File Offset: 0x0006A6D8
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x0000E720 File Offset: 0x0000C920
		public unsafe bool menuRestarting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_menuRestarting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_menuRestarting)) = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0006C500 File Offset: 0x0006A700
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0000E73B File Offset: 0x0000C93B
		public unsafe GameObject shadowCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shadowCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shadowCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0006C530 File Offset: 0x0006A730
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x0000E75A File Offset: 0x0000C95A
		public unsafe GameObject shadowQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shadowQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl.NativeFieldInfoPtr_shadowQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr_pState;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeFieldInfoPtr_lookBias;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_pushTrack;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_justTracked;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_tracked;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_prevTrackedPos;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_trackTimer;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_newTrack;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_initTimer;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_room;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_freed;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeFieldInfoPtr_shaking;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr_shakeAmount;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr_truePos;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_shakeTimer;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_guardsKilled;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_dying;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr_backgrnds;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_flash;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_flashMats;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_gameEndText;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_blackScreen;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_duckedSnap;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_normalSnap;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_pMove;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_lives;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_livesText;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_gameOver;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_leaderboarded;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr_leaderboard;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeFieldInfoPtr_uploadCalled;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr_killsText;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr_timeText;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeFieldInfoPtr_bonusText;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeFieldInfoPtr_scoreText;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_scoreTitle;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr_killsScoreText;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr_timeScoreText;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeFieldInfoPtr_bonusScoreText;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_endLevelUI;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr_levelText;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeFieldInfoPtr_enterInitScreen;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_pastInitScreen;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr_addedScore;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_zoomedOutFlag;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr_camLocked;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr_lockedPos;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_flashTimer;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_flashing;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr_flashCol;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeFieldInfoPtr_stencilQuad;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_stencils;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeFieldInfoPtr_retryText;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeFieldInfoPtr_albumEndings;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeFieldInfoPtr_albumEndDeathText;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeFieldInfoPtr_albumEndTimeText;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeFieldInfoPtr_officeViews;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_turnOnForDeathScreen;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeFieldInfoPtr_officeDeadStuff;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr_nonStencilFloorMat;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeFieldInfoPtr_stencilFloorMat;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_hurtFlash;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeFieldInfoPtr_baseSize;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr_desPos;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeFieldInfoPtr_albumUnlockScreens;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeFieldInfoPtr_boatSway;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeFieldInfoPtr_boatSwayCurve;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeFieldInfoPtr_whiteScreen;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeFieldInfoPtr_arcadeModeUI;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeFieldInfoPtr_notePlayed;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeFieldInfoPtr_deadText;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeFieldInfoPtr_discText;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr_deadCam;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_deadQuad;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr_deadStencilQuadPrefab;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr_deadStencils;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_deathRenders;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_cameraWobble;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeFieldInfoPtr_deadBlackQuadPrefab;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr_deadBlackQuads;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeFieldInfoPtr_stencilStrip;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr_floorQuad;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeFieldInfoPtr_distTraved;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeFieldInfoPtr_fullScreenStencil;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeFieldInfoPtr_leaderHeading;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeFieldInfoPtr_prevStick;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeFieldInfoPtr_deathNotesPlayed;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeFieldInfoPtr_lastNoteTime;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeFieldInfoPtr_startedReloadingLevel;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeFieldInfoPtr_finishedDeath;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeFieldInfoPtr_screenShakeAmount;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeFieldInfoPtr_beatArcade;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeFieldInfoPtr_tickingInstance;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_shakeVel;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_shakeOffset;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_prevPosV2;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_deadFloorQuad;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_localHighScoreScreen;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_highScore;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_thisScore;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_numThisScore;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr_shakeDecay;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr_shakeMult;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_amountMult;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_textLoader;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_menuRestarting;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_shadowCam;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_shadowQuad;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_SetFloorQuadMat_Public_Void_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector2_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector2_Single_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_OnScreen_Public_Boolean_Vector3_Single_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_GiveInputBack_Private_IEnumerator_Single_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_LockCamera_Public_Void_Vector2_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_UnlockCamera_Public_Void_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_CancelShake_Public_Void_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_Shake_Public_Void_Vector2_Single_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_OnPusher_Public_Void_GameObject_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_OnEndPush_Public_Void_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_Death_Public_Void_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Public_Void_Color_Single_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_HurtFlash_Public_Void_Single_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Public_Void_Color_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_FlashCo_Private_IEnumerator_Color_Int32_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_DeadTrailer_Private_IEnumerator_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_FellOutWindow_Private_IEnumerator_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_NotePlayed_Private_Boolean_Int32_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_SetNotePlayed_Private_Void_Note_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_TransitionFailSafe_Private_IEnumerator_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_EndTrack_Public_Void_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_DeadCam_Private_IEnumerator_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_ResetStencilMap_Public_Void_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStencilMap_Private_Void_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_AlbumEnd_Public_Void_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_SaveMyWin_Public_Void_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_AlbumEnder_Private_IEnumerator_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_StringifyTime_Public_String_Single_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Private_String_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr__DeadCam_b__143_0_Private_Boolean_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr__DeadCam_b__143_1_Private_Boolean_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr__DeadCam_b__143_2_Private_Boolean_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr__DeadCam_b__143_3_Private_Boolean_0;

		// Token: 0x020002E5 RID: 741
		[ObfuscatedName("CamControl+<GiveInputBack>d__124")]
		public sealed class _GiveInputBack_d__124 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DE6 RID: 19942 RVA: 0x0011DEE4 File Offset: 0x0011C0E4
			// Note: this type is marked as 'beforefieldinit'.
			static _GiveInputBack_d__124()
			{
				Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<GiveInputBack>d__124");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr);
				CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, "<>1__state");
				CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, "<>2__current");
				CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, "<>4__this");
				CamControl._GiveInputBack_d__124.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, "time");
				CamControl._GiveInputBack_d__124.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, 100664926);
				CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, 100664927);
				CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, 100664928);
				CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, 100664929);
				CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, 100664930);
				CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr, 100664931);
			}

			// Token: 0x06004DE7 RID: 19943 RVA: 0x0011DFD8 File Offset: 0x0011C1D8
			[CallerCount(0)]
			public unsafe _GiveInputBack_d__124(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._GiveInputBack_d__124>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._GiveInputBack_d__124.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DE8 RID: 19944 RVA: 0x0011E020 File Offset: 0x0011C220
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DE9 RID: 19945 RVA: 0x0011E054 File Offset: 0x0011C254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50276, XrefRangeEnd = 50280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C63 RID: 7267
			// (get) Token: 0x06004DEA RID: 19946 RVA: 0x0011E090 File Offset: 0x0011C290
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DEB RID: 19947 RVA: 0x0011E0D0 File Offset: 0x0011C2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50280, XrefRangeEnd = 50285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C64 RID: 7268
			// (get) Token: 0x06004DEC RID: 19948 RVA: 0x0011E104 File Offset: 0x0011C304
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._GiveInputBack_d__124.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DED RID: 19949 RVA: 0x0002DB5E File Offset: 0x0002BD5E
			public _GiveInputBack_d__124(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C5F RID: 7263
			// (get) Token: 0x06004DEE RID: 19950 RVA: 0x0011E144 File Offset: 0x0011C344
			// (set) Token: 0x06004DEF RID: 19951 RVA: 0x0002DB67 File Offset: 0x0002BD67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C60 RID: 7264
			// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x0011E16C File Offset: 0x0011C36C
			// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x0002DB82 File Offset: 0x0002BD82
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C61 RID: 7265
			// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x0011E19C File Offset: 0x0011C39C
			// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x0002DBA1 File Offset: 0x0002BDA1
			public unsafe CamControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C62 RID: 7266
			// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x0011E1CC File Offset: 0x0011C3CC
			// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x0002DBC0 File Offset: 0x0002BDC0
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._GiveInputBack_d__124.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x040032FF RID: 13055
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003300 RID: 13056
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003301 RID: 13057
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003302 RID: 13058
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04003303 RID: 13059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003304 RID: 13060
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003305 RID: 13061
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003306 RID: 13062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003307 RID: 13063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003308 RID: 13064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002E6 RID: 742
		[ObfuscatedName("CamControl+<Bullshit>d__132")]
		public sealed class _Bullshit_d__132 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DF6 RID: 19958 RVA: 0x0011E1F4 File Offset: 0x0011C3F4
			// Note: this type is marked as 'beforefieldinit'.
			static _Bullshit_d__132()
			{
				Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<Bullshit>d__132");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr);
				CamControl._Bullshit_d__132.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, "<>1__state");
				CamControl._Bullshit_d__132.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, "<>2__current");
				CamControl._Bullshit_d__132.NativeFieldInfoPtr_blamo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, "blamo");
				CamControl._Bullshit_d__132.NativeFieldInfoPtr__tim_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, "<tim>5__2");
				CamControl._Bullshit_d__132.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, 100664932);
				CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, 100664933);
				CamControl._Bullshit_d__132.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, 100664934);
				CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, 100664935);
				CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, 100664936);
				CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr, 100664937);
			}

			// Token: 0x06004DF7 RID: 19959 RVA: 0x0011E2E8 File Offset: 0x0011C4E8
			[CallerCount(0)]
			public unsafe _Bullshit_d__132(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._Bullshit_d__132>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._Bullshit_d__132.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DF8 RID: 19960 RVA: 0x0011E330 File Offset: 0x0011C530
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DF9 RID: 19961 RVA: 0x0011E364 File Offset: 0x0011C564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50285, XrefRangeEnd = 50288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._Bullshit_d__132.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C69 RID: 7273
			// (get) Token: 0x06004DFA RID: 19962 RVA: 0x0011E3A0 File Offset: 0x0011C5A0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DFB RID: 19963 RVA: 0x0011E3E0 File Offset: 0x0011C5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50288, XrefRangeEnd = 50293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C6A RID: 7274
			// (get) Token: 0x06004DFC RID: 19964 RVA: 0x0011E414 File Offset: 0x0011C614
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._Bullshit_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DFD RID: 19965 RVA: 0x0002DBDB File Offset: 0x0002BDDB
			public _Bullshit_d__132(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C65 RID: 7269
			// (get) Token: 0x06004DFE RID: 19966 RVA: 0x0011E454 File Offset: 0x0011C654
			// (set) Token: 0x06004DFF RID: 19967 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C66 RID: 7270
			// (get) Token: 0x06004E00 RID: 19968 RVA: 0x0011E47C File Offset: 0x0011C67C
			// (set) Token: 0x06004E01 RID: 19969 RVA: 0x0002DBFF File Offset: 0x0002BDFF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C67 RID: 7271
			// (get) Token: 0x06004E02 RID: 19970 RVA: 0x0011E4AC File Offset: 0x0011C6AC
			// (set) Token: 0x06004E03 RID: 19971 RVA: 0x0002DC1E File Offset: 0x0002BE1E
			public unsafe float blamo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr_blamo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr_blamo)) = value;
				}
			}

			// Token: 0x17001C68 RID: 7272
			// (get) Token: 0x06004E04 RID: 19972 RVA: 0x0011E4D4 File Offset: 0x0011C6D4
			// (set) Token: 0x06004E05 RID: 19973 RVA: 0x0002DC39 File Offset: 0x0002BE39
			public unsafe float _tim_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr__tim_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._Bullshit_d__132.NativeFieldInfoPtr__tim_5__2)) = value;
				}
			}

			// Token: 0x04003309 RID: 13065
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400330A RID: 13066
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400330B RID: 13067
			private static readonly IntPtr NativeFieldInfoPtr_blamo;

			// Token: 0x0400330C RID: 13068
			private static readonly IntPtr NativeFieldInfoPtr__tim_5__2;

			// Token: 0x0400330D RID: 13069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400330E RID: 13070
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400330F RID: 13071
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003310 RID: 13072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003311 RID: 13073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003312 RID: 13074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002E7 RID: 743
		[ObfuscatedName("CamControl+<FlashCo>d__136")]
		public sealed class _FlashCo_d__136 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E06 RID: 19974 RVA: 0x0011E4FC File Offset: 0x0011C6FC
			// Note: this type is marked as 'beforefieldinit'.
			static _FlashCo_d__136()
			{
				Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<FlashCo>d__136");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr);
				CamControl._FlashCo_d__136.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, "<>1__state");
				CamControl._FlashCo_d__136.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, "<>2__current");
				CamControl._FlashCo_d__136.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, "<>4__this");
				CamControl._FlashCo_d__136.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, "col");
				CamControl._FlashCo_d__136.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, "dur");
				CamControl._FlashCo_d__136.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, "<i>5__2");
				CamControl._FlashCo_d__136.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, 100664938);
				CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, 100664939);
				CamControl._FlashCo_d__136.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, 100664940);
				CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, 100664941);
				CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, 100664942);
				CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr, 100664943);
			}

			// Token: 0x06004E07 RID: 19975 RVA: 0x0011E618 File Offset: 0x0011C818
			[CallerCount(0)]
			public unsafe _FlashCo_d__136(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._FlashCo_d__136>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FlashCo_d__136.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E08 RID: 19976 RVA: 0x0011E660 File Offset: 0x0011C860
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E09 RID: 19977 RVA: 0x0011E694 File Offset: 0x0011C894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50293, XrefRangeEnd = 50303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FlashCo_d__136.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C71 RID: 7281
			// (get) Token: 0x06004E0A RID: 19978 RVA: 0x0011E6D0 File Offset: 0x0011C8D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E0B RID: 19979 RVA: 0x0011E710 File Offset: 0x0011C910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50303, XrefRangeEnd = 50308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C72 RID: 7282
			// (get) Token: 0x06004E0C RID: 19980 RVA: 0x0011E744 File Offset: 0x0011C944
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FlashCo_d__136.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E0D RID: 19981 RVA: 0x0002DC54 File Offset: 0x0002BE54
			public _FlashCo_d__136(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C6B RID: 7275
			// (get) Token: 0x06004E0E RID: 19982 RVA: 0x0011E784 File Offset: 0x0011C984
			// (set) Token: 0x06004E0F RID: 19983 RVA: 0x0002DC5D File Offset: 0x0002BE5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C6C RID: 7276
			// (get) Token: 0x06004E10 RID: 19984 RVA: 0x0011E7AC File Offset: 0x0011C9AC
			// (set) Token: 0x06004E11 RID: 19985 RVA: 0x0002DC78 File Offset: 0x0002BE78
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C6D RID: 7277
			// (get) Token: 0x06004E12 RID: 19986 RVA: 0x0011E7DC File Offset: 0x0011C9DC
			// (set) Token: 0x06004E13 RID: 19987 RVA: 0x0002DC97 File Offset: 0x0002BE97
			public unsafe CamControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C6E RID: 7278
			// (get) Token: 0x06004E14 RID: 19988 RVA: 0x0011E80C File Offset: 0x0011CA0C
			// (set) Token: 0x06004E15 RID: 19989 RVA: 0x0002DCB6 File Offset: 0x0002BEB6
			public unsafe Color col
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr_col);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr_col)) = value;
				}
			}

			// Token: 0x17001C6F RID: 7279
			// (get) Token: 0x06004E16 RID: 19990 RVA: 0x0011E834 File Offset: 0x0011CA34
			// (set) Token: 0x06004E17 RID: 19991 RVA: 0x0002DCD1 File Offset: 0x0002BED1
			public unsafe int dur
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr_dur);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr_dur)) = value;
				}
			}

			// Token: 0x17001C70 RID: 7280
			// (get) Token: 0x06004E18 RID: 19992 RVA: 0x0011E85C File Offset: 0x0011CA5C
			// (set) Token: 0x06004E19 RID: 19993 RVA: 0x0002DCEC File Offset: 0x0002BEEC
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FlashCo_d__136.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04003313 RID: 13075
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003314 RID: 13076
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003315 RID: 13077
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003316 RID: 13078
			private static readonly IntPtr NativeFieldInfoPtr_col;

			// Token: 0x04003317 RID: 13079
			private static readonly IntPtr NativeFieldInfoPtr_dur;

			// Token: 0x04003318 RID: 13080
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04003319 RID: 13081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400331A RID: 13082
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400331B RID: 13083
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400331C RID: 13084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400331D RID: 13085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400331E RID: 13086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002E8 RID: 744
		[ObfuscatedName("CamControl+<DeadTrailer>d__137")]
		public sealed class _DeadTrailer_d__137 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E1A RID: 19994 RVA: 0x0011E884 File Offset: 0x0011CA84
			// Note: this type is marked as 'beforefieldinit'.
			static _DeadTrailer_d__137()
			{
				Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<DeadTrailer>d__137");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr);
				CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, "<>1__state");
				CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, "<>2__current");
				CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, "<>4__this");
				CamControl._DeadTrailer_d__137.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, 100664944);
				CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, 100664945);
				CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, 100664946);
				CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, 100664947);
				CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, 100664948);
				CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr, 100664949);
			}

			// Token: 0x06004E1B RID: 19995 RVA: 0x0011E964 File Offset: 0x0011CB64
			[CallerCount(0)]
			public unsafe _DeadTrailer_d__137(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._DeadTrailer_d__137>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadTrailer_d__137.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E1C RID: 19996 RVA: 0x0011E9AC File Offset: 0x0011CBAC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E1D RID: 19997 RVA: 0x0011E9E0 File Offset: 0x0011CBE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50308, XrefRangeEnd = 50328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C76 RID: 7286
			// (get) Token: 0x06004E1E RID: 19998 RVA: 0x0011EA1C File Offset: 0x0011CC1C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E1F RID: 19999 RVA: 0x0011EA5C File Offset: 0x0011CC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50328, XrefRangeEnd = 50333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C77 RID: 7287
			// (get) Token: 0x06004E20 RID: 20000 RVA: 0x0011EA90 File Offset: 0x0011CC90
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadTrailer_d__137.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E21 RID: 20001 RVA: 0x0002DD07 File Offset: 0x0002BF07
			public _DeadTrailer_d__137(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C73 RID: 7283
			// (get) Token: 0x06004E22 RID: 20002 RVA: 0x0011EAD0 File Offset: 0x0011CCD0
			// (set) Token: 0x06004E23 RID: 20003 RVA: 0x0002DD10 File Offset: 0x0002BF10
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C74 RID: 7284
			// (get) Token: 0x06004E24 RID: 20004 RVA: 0x0011EAF8 File Offset: 0x0011CCF8
			// (set) Token: 0x06004E25 RID: 20005 RVA: 0x0002DD2B File Offset: 0x0002BF2B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C75 RID: 7285
			// (get) Token: 0x06004E26 RID: 20006 RVA: 0x0011EB28 File Offset: 0x0011CD28
			// (set) Token: 0x06004E27 RID: 20007 RVA: 0x0002DD4A File Offset: 0x0002BF4A
			public unsafe CamControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadTrailer_d__137.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400331F RID: 13087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003320 RID: 13088
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003321 RID: 13089
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003322 RID: 13090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003323 RID: 13091
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003324 RID: 13092
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003325 RID: 13093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003326 RID: 13094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003327 RID: 13095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002E9 RID: 745
		[ObfuscatedName("CamControl+<FellOutWindow>d__138")]
		public sealed class _FellOutWindow_d__138 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E28 RID: 20008 RVA: 0x0011EB58 File Offset: 0x0011CD58
			// Note: this type is marked as 'beforefieldinit'.
			static _FellOutWindow_d__138()
			{
				Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<FellOutWindow>d__138");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr);
				CamControl._FellOutWindow_d__138.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, "<>1__state");
				CamControl._FellOutWindow_d__138.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, "<>2__current");
				CamControl._FellOutWindow_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, 100664950);
				CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, 100664951);
				CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, 100664952);
				CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, 100664953);
				CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, 100664954);
				CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr, 100664955);
			}

			// Token: 0x06004E29 RID: 20009 RVA: 0x0011EC24 File Offset: 0x0011CE24
			[CallerCount(0)]
			public unsafe _FellOutWindow_d__138(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._FellOutWindow_d__138>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FellOutWindow_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E2A RID: 20010 RVA: 0x0011EC6C File Offset: 0x0011CE6C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E2B RID: 20011 RVA: 0x0011ECA0 File Offset: 0x0011CEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50333, XrefRangeEnd = 50369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C7A RID: 7290
			// (get) Token: 0x06004E2C RID: 20012 RVA: 0x0011ECDC File Offset: 0x0011CEDC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E2D RID: 20013 RVA: 0x0011ED1C File Offset: 0x0011CF1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50369, XrefRangeEnd = 50374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C7B RID: 7291
			// (get) Token: 0x06004E2E RID: 20014 RVA: 0x0011ED50 File Offset: 0x0011CF50
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._FellOutWindow_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E2F RID: 20015 RVA: 0x0002DD69 File Offset: 0x0002BF69
			public _FellOutWindow_d__138(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C78 RID: 7288
			// (get) Token: 0x06004E30 RID: 20016 RVA: 0x0011ED90 File Offset: 0x0011CF90
			// (set) Token: 0x06004E31 RID: 20017 RVA: 0x0002DD72 File Offset: 0x0002BF72
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FellOutWindow_d__138.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FellOutWindow_d__138.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C79 RID: 7289
			// (get) Token: 0x06004E32 RID: 20018 RVA: 0x0011EDB8 File Offset: 0x0011CFB8
			// (set) Token: 0x06004E33 RID: 20019 RVA: 0x0002DD8D File Offset: 0x0002BF8D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FellOutWindow_d__138.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._FellOutWindow_d__138.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003328 RID: 13096
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003329 RID: 13097
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400332A RID: 13098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400332B RID: 13099
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400332C RID: 13100
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400332D RID: 13101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400332E RID: 13102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400332F RID: 13103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002EA RID: 746
		[ObfuscatedName("CamControl+<TransitionFailSafe>d__141")]
		public sealed class _TransitionFailSafe_d__141 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E34 RID: 20020 RVA: 0x0011EDE8 File Offset: 0x0011CFE8
			// Note: this type is marked as 'beforefieldinit'.
			static _TransitionFailSafe_d__141()
			{
				Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<TransitionFailSafe>d__141");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr);
				CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, "<>1__state");
				CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, "<>2__current");
				CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, "<>4__this");
				CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, 100664956);
				CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, 100664957);
				CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, 100664958);
				CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, 100664959);
				CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, 100664960);
				CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr, 100664961);
			}

			// Token: 0x06004E35 RID: 20021 RVA: 0x0011EEC8 File Offset: 0x0011D0C8
			[CallerCount(0)]
			public unsafe _TransitionFailSafe_d__141(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._TransitionFailSafe_d__141>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E36 RID: 20022 RVA: 0x0011EF10 File Offset: 0x0011D110
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E37 RID: 20023 RVA: 0x0011EF44 File Offset: 0x0011D144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50374, XrefRangeEnd = 50377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C7F RID: 7295
			// (get) Token: 0x06004E38 RID: 20024 RVA: 0x0011EF80 File Offset: 0x0011D180
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E39 RID: 20025 RVA: 0x0011EFC0 File Offset: 0x0011D1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50377, XrefRangeEnd = 50382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C80 RID: 7296
			// (get) Token: 0x06004E3A RID: 20026 RVA: 0x0011EFF4 File Offset: 0x0011D1F4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._TransitionFailSafe_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E3B RID: 20027 RVA: 0x0002DDAC File Offset: 0x0002BFAC
			public _TransitionFailSafe_d__141(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C7C RID: 7292
			// (get) Token: 0x06004E3C RID: 20028 RVA: 0x0011F034 File Offset: 0x0011D234
			// (set) Token: 0x06004E3D RID: 20029 RVA: 0x0002DDB5 File Offset: 0x0002BFB5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C7D RID: 7293
			// (get) Token: 0x06004E3E RID: 20030 RVA: 0x0011F05C File Offset: 0x0011D25C
			// (set) Token: 0x06004E3F RID: 20031 RVA: 0x0002DDD0 File Offset: 0x0002BFD0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C7E RID: 7294
			// (get) Token: 0x06004E40 RID: 20032 RVA: 0x0011F08C File Offset: 0x0011D28C
			// (set) Token: 0x06004E41 RID: 20033 RVA: 0x0002DDEF File Offset: 0x0002BFEF
			public unsafe CamControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._TransitionFailSafe_d__141.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003330 RID: 13104
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003331 RID: 13105
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003332 RID: 13106
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003333 RID: 13107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003334 RID: 13108
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003335 RID: 13109
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003336 RID: 13110
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003337 RID: 13111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003338 RID: 13112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002EB RID: 747
		[ObfuscatedName("CamControl+<DeadCam>d__143")]
		public sealed class _DeadCam_d__143 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E42 RID: 20034 RVA: 0x0011F0BC File Offset: 0x0011D2BC
			// Note: this type is marked as 'beforefieldinit'.
			static _DeadCam_d__143()
			{
				Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<DeadCam>d__143");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr);
				CamControl._DeadCam_d__143.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<>1__state");
				CamControl._DeadCam_d__143.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<>2__current");
				CamControl._DeadCam_d__143.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<>4__this");
				CamControl._DeadCam_d__143.NativeFieldInfoPtr__desSize_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<desSize>5__2");
				CamControl._DeadCam_d__143.NativeFieldInfoPtr__desPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<desPos>5__3");
				CamControl._DeadCam_d__143.NativeFieldInfoPtr__offSet_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<offSet>5__4");
				CamControl._DeadCam_d__143.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, "<i>5__5");
				CamControl._DeadCam_d__143.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, 100664962);
				CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, 100664963);
				CamControl._DeadCam_d__143.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, 100664964);
				CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, 100664965);
				CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, 100664966);
				CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr, 100664967);
			}

			// Token: 0x06004E43 RID: 20035 RVA: 0x0011F1EC File Offset: 0x0011D3EC
			[CallerCount(0)]
			public unsafe _DeadCam_d__143(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._DeadCam_d__143>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadCam_d__143.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E44 RID: 20036 RVA: 0x0011F234 File Offset: 0x0011D434
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E45 RID: 20037 RVA: 0x0011F268 File Offset: 0x0011D468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50382, XrefRangeEnd = 50611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadCam_d__143.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C88 RID: 7304
			// (get) Token: 0x06004E46 RID: 20038 RVA: 0x0011F2A4 File Offset: 0x0011D4A4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E47 RID: 20039 RVA: 0x0011F2E4 File Offset: 0x0011D4E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50611, XrefRangeEnd = 50616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C89 RID: 7305
			// (get) Token: 0x06004E48 RID: 20040 RVA: 0x0011F318 File Offset: 0x0011D518
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._DeadCam_d__143.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E49 RID: 20041 RVA: 0x0002DE0E File Offset: 0x0002C00E
			public _DeadCam_d__143(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C81 RID: 7297
			// (get) Token: 0x06004E4A RID: 20042 RVA: 0x0011F358 File Offset: 0x0011D558
			// (set) Token: 0x06004E4B RID: 20043 RVA: 0x0002DE17 File Offset: 0x0002C017
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C82 RID: 7298
			// (get) Token: 0x06004E4C RID: 20044 RVA: 0x0011F380 File Offset: 0x0011D580
			// (set) Token: 0x06004E4D RID: 20045 RVA: 0x0002DE32 File Offset: 0x0002C032
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C83 RID: 7299
			// (get) Token: 0x06004E4E RID: 20046 RVA: 0x0011F3B0 File Offset: 0x0011D5B0
			// (set) Token: 0x06004E4F RID: 20047 RVA: 0x0002DE51 File Offset: 0x0002C051
			public unsafe CamControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C84 RID: 7300
			// (get) Token: 0x06004E50 RID: 20048 RVA: 0x0011F3E0 File Offset: 0x0011D5E0
			// (set) Token: 0x06004E51 RID: 20049 RVA: 0x0002DE70 File Offset: 0x0002C070
			public unsafe float _desSize_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__desSize_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__desSize_5__2)) = value;
				}
			}

			// Token: 0x17001C85 RID: 7301
			// (get) Token: 0x06004E52 RID: 20050 RVA: 0x0011F408 File Offset: 0x0011D608
			// (set) Token: 0x06004E53 RID: 20051 RVA: 0x0002DE8B File Offset: 0x0002C08B
			public unsafe Vector2 _desPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__desPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__desPos_5__3)) = value;
				}
			}

			// Token: 0x17001C86 RID: 7302
			// (get) Token: 0x06004E54 RID: 20052 RVA: 0x0011F430 File Offset: 0x0011D630
			// (set) Token: 0x06004E55 RID: 20053 RVA: 0x0002DEA6 File Offset: 0x0002C0A6
			public unsafe Vector3 _offSet_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__offSet_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__offSet_5__4)) = value;
				}
			}

			// Token: 0x17001C87 RID: 7303
			// (get) Token: 0x06004E56 RID: 20054 RVA: 0x0011F458 File Offset: 0x0011D658
			// (set) Token: 0x06004E57 RID: 20055 RVA: 0x0002DEC1 File Offset: 0x0002C0C1
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._DeadCam_d__143.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04003339 RID: 13113
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400333A RID: 13114
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400333B RID: 13115
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400333C RID: 13116
			private static readonly IntPtr NativeFieldInfoPtr__desSize_5__2;

			// Token: 0x0400333D RID: 13117
			private static readonly IntPtr NativeFieldInfoPtr__desPos_5__3;

			// Token: 0x0400333E RID: 13118
			private static readonly IntPtr NativeFieldInfoPtr__offSet_5__4;

			// Token: 0x0400333F RID: 13119
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04003340 RID: 13120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003341 RID: 13121
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003342 RID: 13122
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003343 RID: 13123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003344 RID: 13124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003345 RID: 13125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002EC RID: 748
		[ObfuscatedName("CamControl+<AlbumEnder>d__148")]
		public sealed class _AlbumEnder_d__148 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E58 RID: 20056 RVA: 0x0011F480 File Offset: 0x0011D680
			// Note: this type is marked as 'beforefieldinit'.
			static _AlbumEnder_d__148()
			{
				Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CamControl>.NativeClassPtr, "<AlbumEnder>d__148");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr);
				CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, "<>1__state");
				CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, "<>2__current");
				CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, "<>4__this");
				CamControl._AlbumEnder_d__148.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, "<i>5__2");
				CamControl._AlbumEnder_d__148.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, 100664968);
				CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, 100664969);
				CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, 100664970);
				CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, 100664971);
				CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, 100664972);
				CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr, 100664973);
			}

			// Token: 0x06004E59 RID: 20057 RVA: 0x0011F574 File Offset: 0x0011D774
			[CallerCount(0)]
			public unsafe _AlbumEnder_d__148(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamControl._AlbumEnder_d__148>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._AlbumEnder_d__148.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E5A RID: 20058 RVA: 0x0011F5BC File Offset: 0x0011D7BC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E5B RID: 20059 RVA: 0x0011F5F0 File Offset: 0x0011D7F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50616, XrefRangeEnd = 50738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C8E RID: 7310
			// (get) Token: 0x06004E5C RID: 20060 RVA: 0x0011F62C File Offset: 0x0011D82C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E5D RID: 20061 RVA: 0x0011F66C File Offset: 0x0011D86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50738, XrefRangeEnd = 50743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C8F RID: 7311
			// (get) Token: 0x06004E5E RID: 20062 RVA: 0x0011F6A0 File Offset: 0x0011D8A0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamControl._AlbumEnder_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E5F RID: 20063 RVA: 0x0002DEDC File Offset: 0x0002C0DC
			public _AlbumEnder_d__148(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C8A RID: 7306
			// (get) Token: 0x06004E60 RID: 20064 RVA: 0x0011F6E0 File Offset: 0x0011D8E0
			// (set) Token: 0x06004E61 RID: 20065 RVA: 0x0002DEE5 File Offset: 0x0002C0E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C8B RID: 7307
			// (get) Token: 0x06004E62 RID: 20066 RVA: 0x0011F708 File Offset: 0x0011D908
			// (set) Token: 0x06004E63 RID: 20067 RVA: 0x0002DF00 File Offset: 0x0002C100
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C8C RID: 7308
			// (get) Token: 0x06004E64 RID: 20068 RVA: 0x0011F738 File Offset: 0x0011D938
			// (set) Token: 0x06004E65 RID: 20069 RVA: 0x0002DF1F File Offset: 0x0002C11F
			public unsafe CamControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C8D RID: 7309
			// (get) Token: 0x06004E66 RID: 20070 RVA: 0x0011F768 File Offset: 0x0011D968
			// (set) Token: 0x06004E67 RID: 20071 RVA: 0x0002DF3E File Offset: 0x0002C13E
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CamControl._AlbumEnder_d__148.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04003346 RID: 13126
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003347 RID: 13127
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003348 RID: 13128
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003349 RID: 13129
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400334A RID: 13130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400334B RID: 13131
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400334C RID: 13132
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400334D RID: 13133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400334E RID: 13134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400334F RID: 13135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
