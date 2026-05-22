using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000103 RID: 259
	public class GuardState : MessageReceiver
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x00088454 File Offset: 0x00086654
		// Note: this type is marked as 'beforefieldinit'.
		static GuardState()
		{
			Il2CppClassPointerStore<GuardState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardState>.NativeClassPtr);
			GuardState.NativeFieldInfoPtr_guardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "guardType");
			GuardState.NativeFieldInfoPtr_weaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "weaponType");
			GuardState.NativeFieldInfoPtr_curMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "curMode");
			GuardState.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "gun");
			GuardState.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "head");
			GuardState.NativeFieldInfoPtr_headTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "headTrans");
			GuardState.NativeFieldInfoPtr_shotReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "shotReady");
			GuardState.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "player");
			GuardState.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "target");
			GuardState.NativeFieldInfoPtr_lastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "lastTarget");
			GuardState.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "targets");
			GuardState.NativeFieldInfoPtr_pushOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pushOrigin");
			GuardState.NativeFieldInfoPtr_mover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "mover");
			GuardState.NativeFieldInfoPtr_chaseInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "chaseInit");
			GuardState.NativeFieldInfoPtr_prePushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "prePushed");
			GuardState.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "dead");
			GuardState.NativeFieldInfoPtr_onScreenTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "onScreenTimer");
			GuardState.NativeFieldInfoPtr_statusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "statusEffects");
			GuardState.NativeFieldInfoPtr_statRemoveQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "statRemoveQ");
			GuardState.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "startPos");
			GuardState.NativeFieldInfoPtr_alerted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "alerted");
			GuardState.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "path");
			GuardState.NativeFieldInfoPtr_hasPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "hasPath");
			GuardState.NativeFieldInfoPtr_pathPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pathPending");
			GuardState.NativeFieldInfoPtr_pathID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pathID");
			GuardState.NativeFieldInfoPtr_pathFinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pathFinder");
			GuardState.NativeFieldInfoPtr_searchGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "searchGrid");
			GuardState.NativeFieldInfoPtr_curPathPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "curPathPt");
			GuardState.NativeFieldInfoPtr_idleSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "idleSpd");
			GuardState.NativeFieldInfoPtr_searchSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "searchSpd");
			GuardState.NativeFieldInfoPtr_chaseSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "chaseSpd");
			GuardState.NativeFieldInfoPtr_stalkSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "stalkSpd");
			GuardState.NativeFieldInfoPtr_attackSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "attackSpd");
			GuardState.NativeFieldInfoPtr_pushMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pushMass");
			GuardState.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "debugging");
			GuardState.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "mode");
			GuardState.NativeFieldInfoPtr_modePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "modePriority");
			GuardState.NativeFieldInfoPtr_idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "idle");
			GuardState.NativeFieldInfoPtr_stunned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "stunned");
			GuardState.NativeFieldInfoPtr_waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "waiting");
			GuardState.NativeFieldInfoPtr_searching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "searching");
			GuardState.NativeFieldInfoPtr_investigating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "investigating");
			GuardState.NativeFieldInfoPtr_lookingAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "lookingAround");
			GuardState.NativeFieldInfoPtr_chasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "chasing");
			GuardState.NativeFieldInfoPtr_stalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "stalking");
			GuardState.NativeFieldInfoPtr_attacking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "attacking");
			GuardState.NativeFieldInfoPtr_grabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "grabbed");
			GuardState.NativeFieldInfoPtr_pushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pushed");
			GuardState.NativeFieldInfoPtr_endPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "endPushed");
			GuardState.NativeFieldInfoPtr_fleeing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "fleeing");
			GuardState.NativeFieldInfoPtr_panicking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "panicking");
			GuardState.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "onFire");
			GuardState.NativeFieldInfoPtr_falling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "falling");
			GuardState.NativeFieldInfoPtr_swinging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "swinging");
			GuardState.NativeFieldInfoPtr_blind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "blind");
			GuardState.NativeFieldInfoPtr_dontFuckingMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "dontFuckingMove");
			GuardState.NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "heat");
			GuardState.NativeFieldInfoPtr_heatThresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "heatThresh");
			GuardState.NativeFieldInfoPtr_died = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "died");
			GuardState.NativeFieldInfoPtr_stalkTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "stalkTimer");
			GuardState.NativeFieldInfoPtr_squadLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "squadLeader");
			GuardState.NativeFieldInfoPtr_reinforcement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "reinforcement");
			GuardState.NativeFieldInfoPtr_follower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "follower");
			GuardState.NativeFieldInfoPtr_followPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "followPos");
			GuardState.NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "leader");
			GuardState.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "dest");
			GuardState.NativeFieldInfoPtr_hangOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "hangOut");
			GuardState.NativeFieldInfoPtr_rotVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "rotVel");
			GuardState.NativeFieldInfoPtr_curVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "curVel");
			GuardState.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "anim");
			GuardState.NativeFieldInfoPtr_grabAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "grabAnim");
			GuardState.NativeFieldInfoPtr_cowerAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "cowerAnim");
			GuardState.NativeFieldInfoPtr_fallAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "fallAnim");
			GuardState.NativeFieldInfoPtr_stunnedAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "stunnedAnim");
			GuardState.NativeFieldInfoPtr_idleAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "idleAnim");
			GuardState.NativeFieldInfoPtr_gunTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "gunTrans");
			GuardState.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "legs");
			GuardState.NativeFieldInfoPtr_legpawTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "legpawTrans");
			GuardState.NativeFieldInfoPtr_gunPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "gunPos");
			GuardState.NativeFieldInfoPtr_handPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "handPos");
			GuardState.NativeFieldInfoPtr_gunRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "gunRot");
			GuardState.NativeFieldInfoPtr_imASwingBoy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "imASwingBoy");
			GuardState.NativeFieldInfoPtr_swingDest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "swingDest");
			GuardState.NativeFieldInfoPtr_swingForceYCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "swingForceYCheck");
			GuardState.NativeFieldInfoPtr_swingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "swingCurve");
			GuardState.NativeFieldInfoPtr_runTheFuckOverHere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "runTheFuckOverHere");
			GuardState.NativeFieldInfoPtr_collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "collision");
			GuardState.NativeFieldInfoPtr_vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "vision");
			GuardState.NativeFieldInfoPtr_audioState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "audioState");
			GuardState.NativeFieldInfoPtr_audioStateTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "audioStateTrans");
			GuardState.NativeFieldInfoPtr_audioStateLocPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "audioStateLocPos");
			GuardState.NativeFieldInfoPtr_audioStateLocRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "audioStateLocRot");
			GuardState.NativeFieldInfoPtr_onScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "onScreen");
			GuardState.NativeFieldInfoPtr_defScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "defScale");
			GuardState.NativeFieldInfoPtr_ranStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "ranStart");
			GuardState.NativeFieldInfoPtr_fell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "fell");
			GuardState.NativeFieldInfoPtr_delList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "delList");
			GuardState.NativeFieldInfoPtr_grabber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "grabber");
			GuardState.NativeFieldInfoPtr_eulerZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "eulerZ");
			GuardState.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "pos");
			GuardState.NativeFieldInfoPtr_posV3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "posV3");
			GuardState.NativeFieldInfoPtr_myFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "myFire");
			GuardState.NativeFieldInfoPtr_yellingInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardState>.NativeClassPtr, "yellingInstance");
			GuardState.NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665710);
			GuardState.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665711);
			GuardState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665712);
			GuardState.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665713);
			GuardState.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665714);
			GuardState.NativeMethodInfoPtr_Yawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665715);
			GuardState.NativeMethodInfoPtr_Scratch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665716);
			GuardState.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665717);
			GuardState.NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665718);
			GuardState.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665719);
			GuardState.NativeMethodInfoPtr_Fired_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665720);
			GuardState.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665721);
			GuardState.NativeMethodInfoPtr_KilledPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665722);
			GuardState.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665723);
			GuardState.NativeMethodInfoPtr_Investigate_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665724);
			GuardState.NativeMethodInfoPtr_OnHeardNoise_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665725);
			GuardState.NativeMethodInfoPtr_Stalk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665726);
			GuardState.NativeMethodInfoPtr_UpdatePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665727);
			GuardState.NativeMethodInfoPtr_GetPath_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665728);
			GuardState.NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665729);
			GuardState.NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665730);
			GuardState.NativeMethodInfoPtr_CancelPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665731);
			GuardState.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665732);
			GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665733);
			GuardState.NativeMethodInfoPtr_MoveTowardNoDamp_Public_Void_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665734);
			GuardState.NativeMethodInfoPtr_MoveTowardNoDamp_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665735);
			GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665736);
			GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665737);
			GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665738);
			GuardState.NativeMethodInfoPtr_LookAt_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665739);
			GuardState.NativeMethodInfoPtr_GetNewMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665740);
			GuardState.NativeMethodInfoPtr_GetStatusMode_Public_GuardMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665741);
			GuardState.NativeMethodInfoPtr_GetDesiredMode_Public_Virtual_New_GuardMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665742);
			GuardState.NativeMethodInfoPtr_InitModes_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665743);
			GuardState.NativeMethodInfoPtr_ManageTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665744);
			GuardState.NativeMethodInfoPtr_OnScreen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665745);
			GuardState.NativeMethodInfoPtr_Attackable_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665746);
			GuardState.NativeMethodInfoPtr_OnSeen_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665747);
			GuardState.NativeMethodInfoPtr_Stun_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665748);
			GuardState.NativeMethodInfoPtr_Wait_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665749);
			GuardState.NativeMethodInfoPtr_Flee_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665750);
			GuardState.NativeMethodInfoPtr_Panic_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665751);
			GuardState.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665752);
			GuardState.NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665753);
			GuardState.NativeMethodInfoPtr_GetStatus_Public_StatusEffect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665754);
			GuardState.NativeMethodInfoPtr_RemoveStatus_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665755);
			GuardState.NativeMethodInfoPtr_OnPrePushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665756);
			GuardState.NativeMethodInfoPtr_OnGrabbed_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665757);
			GuardState.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665758);
			GuardState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665759);
			GuardState.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665760);
			GuardState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665761);
			GuardState.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665762);
			GuardState.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665763);
			GuardState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardState>.NativeClassPtr, 100665764);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x000890DC File Offset: 0x000872DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64768, RefRangeEnd = 64769, XrefRangeStart = 64710, XrefRangeEnd = 64768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetAllMyShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00089118 File Offset: 0x00087318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64896, RefRangeEnd = 64898, XrefRangeStart = 64769, XrefRangeEnd = 64896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00089154 File Offset: 0x00087354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64898, XrefRangeEnd = 64904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetSpeeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00089190 File Offset: 0x00087390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64904, XrefRangeEnd = 64952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000891CC File Offset: 0x000873CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64979, RefRangeEnd = 64980, XrefRangeStart = 64952, XrefRangeEnd = 64979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00089208 File Offset: 0x00087408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64980, XrefRangeEnd = 64990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Yawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Yawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0008923C File Offset: 0x0008743C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64990, XrefRangeEnd = 65000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Scratch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Scratch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00089270 File Offset: 0x00087470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65033, RefRangeEnd = 65034, XrefRangeStart = 65000, XrefRangeEnd = 65033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000892AC File Offset: 0x000874AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65034, XrefRangeEnd = 65048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFall(Vector2 fallVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fallVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000892F8 File Offset: 0x000874F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65162, RefRangeEnd = 65164, XrefRangeStart = 65048, XrefRangeEnd = 65162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00089334 File Offset: 0x00087534
		[CallerCount(0)]
		public unsafe virtual void Fired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_Fired_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00089370 File Offset: 0x00087570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65164, XrefRangeEnd = 65204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000893A4 File Offset: 0x000875A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65204, XrefRangeEnd = 65205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KilledPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_KilledPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000893D8 File Offset: 0x000875D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65205, XrefRangeEnd = 65214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0008940C File Offset: 0x0008760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65214, XrefRangeEnd = 65216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Investigate(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_Investigate_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00089458 File Offset: 0x00087658
		[CallerCount(0)]
		public unsafe void OnHeardNoise(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_OnHeardNoise_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00089498 File Offset: 0x00087698
		[CallerCount(0)]
		public unsafe void Stalk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Stalk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000894CC File Offset: 0x000876CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65216, XrefRangeEnd = 65218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_UpdatePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00089500 File Offset: 0x00087700
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65228, RefRangeEnd = 65234, XrefRangeStart = 65218, XrefRangeEnd = 65228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPath(Vector2 newDest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newDest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_GetPath_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00089540 File Offset: 0x00087740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65234, XrefRangeEnd = 65240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartNavigation(List<Vector2> ptList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ptList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00089590 File Offset: 0x00087790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65240, XrefRangeEnd = 65247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PathFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x000895CC File Offset: 0x000877CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65251, RefRangeEnd = 65254, XrefRangeStart = 65247, XrefRangeEnd = 65251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_CancelPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00089600 File Offset: 0x00087800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65259, RefRangeEnd = 65260, XrefRangeStart = 65254, XrefRangeEnd = 65259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00089684 File Offset: 0x00087884
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 65279, RefRangeEnd = 65288, XrefRangeStart = 65260, XrefRangeEnd = 65279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToward(Vector2 dest, float mSpd, float desRot, float rotSpd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotSpd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000896EC File Offset: 0x000878EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65288, XrefRangeEnd = 65296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTowardNoDamp(Vector2 dest, float mSpd, float desRot, float rotSpd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotSpd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_MoveTowardNoDamp_Public_Void_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00089754 File Offset: 0x00087954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65308, RefRangeEnd = 65309, XrefRangeStart = 65296, XrefRangeEnd = 65308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTowardNoDamp(Vector2 dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_MoveTowardNoDamp_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00089794 File Offset: 0x00087994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65309, XrefRangeEnd = 65310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToward(Vector2 dest, float rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000897E0 File Offset: 0x000879E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65315, RefRangeEnd = 65317, XrefRangeStart = 65310, XrefRangeEnd = 65315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToward(Vector2 dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00089820 File Offset: 0x00087A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65318, RefRangeEnd = 65320, XrefRangeStart = 65317, XrefRangeEnd = 65318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToward(float rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_MoveToward_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00089860 File Offset: 0x00087A60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65330, RefRangeEnd = 65338, XrefRangeStart = 65320, XrefRangeEnd = 65330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_LookAt_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000898A0 File Offset: 0x00087AA0
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 65345, RefRangeEnd = 65376, XrefRangeStart = 65338, XrefRangeEnd = 65345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNewMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_GetNewMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000898D4 File Offset: 0x00087AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65376, XrefRangeEnd = 65381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardMode GetStatusMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_GetStatusMode_Public_GuardMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr3) : null;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00089914 File Offset: 0x00087B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65397, RefRangeEnd = 65398, XrefRangeStart = 65381, XrefRangeEnd = 65397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GuardMode GetDesiredMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_GetDesiredMode_Public_Virtual_New_GuardMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr3) : null;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00089960 File Offset: 0x00087B60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 65495, RefRangeEnd = 65500, XrefRangeStart = 65398, XrefRangeEnd = 65495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_InitModes_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0008999C File Offset: 0x00087B9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 65587, RefRangeEnd = 65592, XrefRangeStart = 65500, XrefRangeEnd = 65587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManageTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_ManageTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000899D0 File Offset: 0x00087BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65596, RefRangeEnd = 65598, XrefRangeStart = 65592, XrefRangeEnd = 65596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_OnScreen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00089A0C File Offset: 0x00087C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65598, XrefRangeEnd = 65611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Attackable(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Attackable_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00089A5C File Offset: 0x00087C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65611, XrefRangeEnd = 65640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSeen(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnSeen_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00089AAC File Offset: 0x00087CAC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65661, XrefRangeStart = 65640, XrefRangeEnd = 65655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stun(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Stun_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00089AEC File Offset: 0x00087CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65676, RefRangeEnd = 65678, XrefRangeStart = 65661, XrefRangeEnd = 65676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Wait_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00089B30 File Offset: 0x00087D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65678, XrefRangeEnd = 65694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flee(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Flee_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00089B74 File Offset: 0x00087D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65694, XrefRangeEnd = 65710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Panic(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_Panic_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00089BB8 File Offset: 0x00087DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65710, XrefRangeEnd = 65722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00089BF4 File Offset: 0x00087DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65722, XrefRangeEnd = 65732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTranq()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00089C30 File Offset: 0x00087E30
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 65740, RefRangeEnd = 65751, XrefRangeStart = 65732, XrefRangeEnd = 65740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusEffect GetStatus(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_GetStatus_Public_StatusEffect_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StatusEffect>(intPtr3) : null;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00089C80 File Offset: 0x00087E80
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65769, RefRangeEnd = 65775, XrefRangeStart = 65751, XrefRangeEnd = 65769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStatus(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_RemoveStatus_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00089CC4 File Offset: 0x00087EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65775, XrefRangeEnd = 65783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPrePushed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnPrePushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00089D10 File Offset: 0x00087F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65783, XrefRangeEnd = 65800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGrabbed(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnGrabbed_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00089D5C File Offset: 0x00087F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65800, XrefRangeEnd = 65820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPushed(Vector2 a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00089DA8 File Offset: 0x00087FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65820, XrefRangeEnd = 65830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00089DF4 File Offset: 0x00087FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65830, XrefRangeEnd = 65840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSlammed(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00089E44 File Offset: 0x00088044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65840, XrefRangeEnd = 65846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00089E94 File Offset: 0x00088094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65846, XrefRangeEnd = 65849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSmashed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardState.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00089EE0 File Offset: 0x000880E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65849, XrefRangeEnd = 65858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00089F24 File Offset: 0x00088124
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65864, RefRangeEnd = 65872, XrefRangeStart = 65858, XrefRangeEnd = 65864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00014DF4 File Offset: 0x00012FF4
		public GuardState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00089F60 File Offset: 0x00088160
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x00014DFD File Offset: 0x00012FFD
		public unsafe GuardState.GuardBodyType guardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_guardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_guardType)) = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00089F88 File Offset: 0x00088188
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00014E18 File Offset: 0x00013018
		public unsafe GuardState.WeaponType weaponType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_weaponType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_weaponType)) = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00089FB0 File Offset: 0x000881B0
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00014E33 File Offset: 0x00013033
		public unsafe GuardState.Priority curMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_curMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_curMode)) = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00089FD8 File Offset: 0x000881D8
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00014E4E File Offset: 0x0001304E
		public unsafe GuardGun gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardGun>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0008A008 File Offset: 0x00088208
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00014E6D File Offset: 0x0001306D
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0008A038 File Offset: 0x00088238
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00014E8C File Offset: 0x0001308C
		public unsafe Transform headTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_headTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_headTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x0008A068 File Offset: 0x00088268
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x00014EAB File Offset: 0x000130AB
		public unsafe bool shotReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_shotReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_shotReady)) = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0008A090 File Offset: 0x00088290
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00014EC6 File Offset: 0x000130C6
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x0008A0C0 File Offset: 0x000882C0
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00014EE5 File Offset: 0x000130E5
		public unsafe GameObject target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0008A0F0 File Offset: 0x000882F0
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00014F04 File Offset: 0x00013104
		public unsafe GameObject lastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_lastTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_lastTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x0008A120 File Offset: 0x00088320
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00014F23 File Offset: 0x00013123
		public unsafe List<GameObject> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x0008A150 File Offset: 0x00088350
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00014F42 File Offset: 0x00013142
		public unsafe Vector2 pushOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pushOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pushOrigin)) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0008A178 File Offset: 0x00088378
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00014F5D File Offset: 0x0001315D
		public unsafe Mover mover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_mover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_mover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x0008A1A8 File Offset: 0x000883A8
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00014F7C File Offset: 0x0001317C
		public unsafe bool chaseInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_chaseInit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_chaseInit)) = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0008A1D0 File Offset: 0x000883D0
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00014F97 File Offset: 0x00013197
		public unsafe bool prePushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_prePushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_prePushed)) = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x0008A1F8 File Offset: 0x000883F8
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00014FB2 File Offset: 0x000131B2
		public unsafe bool dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x0008A220 File Offset: 0x00088420
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00014FCD File Offset: 0x000131CD
		public unsafe int onScreenTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_onScreenTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_onScreenTimer)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x0008A248 File Offset: 0x00088448
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00014FE8 File Offset: 0x000131E8
		public unsafe List<StatusEffect> statusEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_statusEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatusEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_statusEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x0008A278 File Offset: 0x00088478
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x00015007 File Offset: 0x00013207
		public unsafe List<string> statRemoveQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_statRemoveQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_statRemoveQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x0008A2A8 File Offset: 0x000884A8
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x00015026 File Offset: 0x00013226
		public unsafe Vector2 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x0008A2D0 File Offset: 0x000884D0
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x00015041 File Offset: 0x00013241
		public unsafe bool alerted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_alerted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_alerted)) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x0008A2F8 File Offset: 0x000884F8
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x0001505C File Offset: 0x0001325C
		public unsafe List<Vector2> path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0008A328 File Offset: 0x00088528
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0001507B File Offset: 0x0001327B
		public unsafe bool hasPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_hasPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_hasPath)) = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0008A350 File Offset: 0x00088550
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00015096 File Offset: 0x00013296
		public unsafe bool pathPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pathPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pathPending)) = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0008A378 File Offset: 0x00088578
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x000150B1 File Offset: 0x000132B1
		public unsafe int pathID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pathID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pathID)) = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x0008A3A0 File Offset: 0x000885A0
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x000150CC File Offset: 0x000132CC
		public unsafe PathFinding pathFinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pathFinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pathFinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0008A3D0 File Offset: 0x000885D0
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x000150EB File Offset: 0x000132EB
		public unsafe SearchGrid searchGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_searchGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_searchGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0008A400 File Offset: 0x00088600
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0001510A File Offset: 0x0001330A
		public unsafe int curPathPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_curPathPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_curPathPt)) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0008A428 File Offset: 0x00088628
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x00015125 File Offset: 0x00013325
		public unsafe float idleSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_idleSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_idleSpd)) = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0008A450 File Offset: 0x00088650
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00015140 File Offset: 0x00013340
		public unsafe float searchSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_searchSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_searchSpd)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0008A478 File Offset: 0x00088678
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0001515B File Offset: 0x0001335B
		public unsafe float chaseSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_chaseSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_chaseSpd)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0008A4A0 File Offset: 0x000886A0
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00015176 File Offset: 0x00013376
		public unsafe float stalkSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stalkSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stalkSpd)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0008A4C8 File Offset: 0x000886C8
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x00015191 File Offset: 0x00013391
		public unsafe float attackSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_attackSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_attackSpd)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x0008A4F0 File Offset: 0x000886F0
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x000151AC File Offset: 0x000133AC
		public unsafe float pushMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pushMass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pushMass)) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0008A518 File Offset: 0x00088718
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x000151C7 File Offset: 0x000133C7
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0008A540 File Offset: 0x00088740
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x000151E2 File Offset: 0x000133E2
		public unsafe GuardMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0008A570 File Offset: 0x00088770
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00015201 File Offset: 0x00013401
		public unsafe int modePriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_modePriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_modePriority)) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0008A598 File Offset: 0x00088798
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0001521C File Offset: 0x0001341C
		public unsafe GuardMode idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_idle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_idle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0008A5C8 File Offset: 0x000887C8
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0001523B File Offset: 0x0001343B
		public unsafe GuardMode stunned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stunned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stunned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0008A5F8 File Offset: 0x000887F8
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0001525A File Offset: 0x0001345A
		public unsafe GuardMode waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_waiting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_waiting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0008A628 File Offset: 0x00088828
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00015279 File Offset: 0x00013479
		public unsafe GuardMode searching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_searching);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_searching), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0008A658 File Offset: 0x00088858
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x00015298 File Offset: 0x00013498
		public unsafe GuardInvestigate investigating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_investigating);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardInvestigate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_investigating), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0008A688 File Offset: 0x00088888
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x000152B7 File Offset: 0x000134B7
		public unsafe GuardMode lookingAround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_lookingAround);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_lookingAround), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0008A6B8 File Offset: 0x000888B8
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x000152D6 File Offset: 0x000134D6
		public unsafe GuardMode chasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_chasing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_chasing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0008A6E8 File Offset: 0x000888E8
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x000152F5 File Offset: 0x000134F5
		public unsafe GuardMode stalking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stalking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stalking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0008A718 File Offset: 0x00088918
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x00015314 File Offset: 0x00013514
		public unsafe GuardMode attacking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_attacking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_attacking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0008A748 File Offset: 0x00088948
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x00015333 File Offset: 0x00013533
		public unsafe GuardMode grabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_grabbed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_grabbed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0008A778 File Offset: 0x00088978
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00015352 File Offset: 0x00013552
		public unsafe GuardPushed pushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pushed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardPushed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pushed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0008A7A8 File Offset: 0x000889A8
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00015371 File Offset: 0x00013571
		public unsafe GuardEndPush endPushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_endPushed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardEndPush>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_endPushed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0008A7D8 File Offset: 0x000889D8
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00015390 File Offset: 0x00013590
		public unsafe GuardFleeing fleeing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_fleeing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardFleeing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_fleeing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0008A808 File Offset: 0x00088A08
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x000153AF File Offset: 0x000135AF
		public unsafe GuardMode panicking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_panicking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_panicking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0008A838 File Offset: 0x00088A38
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x000153CE File Offset: 0x000135CE
		public unsafe GuardMode onFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_onFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_onFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0008A868 File Offset: 0x00088A68
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x000153ED File Offset: 0x000135ED
		public unsafe GuardMode falling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_falling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_falling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0008A898 File Offset: 0x00088A98
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x0001540C File Offset: 0x0001360C
		public unsafe GuardMode swinging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swinging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swinging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x0001542B File Offset: 0x0001362B
		public unsafe GuardMode blind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_blind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_blind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0008A8F8 File Offset: 0x00088AF8
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x0001544A File Offset: 0x0001364A
		public unsafe bool dontFuckingMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_dontFuckingMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_dontFuckingMove)) = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0008A920 File Offset: 0x00088B20
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x00015465 File Offset: 0x00013665
		public unsafe float heat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_heat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_heat)) = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0008A948 File Offset: 0x00088B48
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00015480 File Offset: 0x00013680
		public unsafe float heatThresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_heatThresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_heatThresh)) = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0008A970 File Offset: 0x00088B70
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0001549B File Offset: 0x0001369B
		public unsafe bool died
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_died);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_died)) = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0008A998 File Offset: 0x00088B98
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x000154B6 File Offset: 0x000136B6
		public unsafe int stalkTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stalkTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stalkTimer)) = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0008A9C0 File Offset: 0x00088BC0
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x000154D1 File Offset: 0x000136D1
		public unsafe GameObject squadLeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_squadLeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_squadLeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0008A9F0 File Offset: 0x00088BF0
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x000154F0 File Offset: 0x000136F0
		public unsafe bool reinforcement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_reinforcement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_reinforcement)) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0008AA18 File Offset: 0x00088C18
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0001550B File Offset: 0x0001370B
		public unsafe bool follower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_follower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_follower)) = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0008AA40 File Offset: 0x00088C40
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x00015526 File Offset: 0x00013726
		public unsafe Vector2 followPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_followPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_followPos)) = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0008AA68 File Offset: 0x00088C68
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x00015541 File Offset: 0x00013741
		public unsafe GameObject leader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_leader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_leader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0008AA98 File Offset: 0x00088C98
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00015560 File Offset: 0x00013760
		public unsafe Vector2 dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x0008AAC0 File Offset: 0x00088CC0
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0001557B File Offset: 0x0001377B
		public unsafe bool hangOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_hangOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_hangOut)) = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0008AAE8 File Offset: 0x00088CE8
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x00015596 File Offset: 0x00013796
		public unsafe float rotVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_rotVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_rotVel)) = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0008AB10 File Offset: 0x00088D10
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x000155B1 File Offset: 0x000137B1
		public unsafe Vector2 curVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_curVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_curVel)) = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0008AB38 File Offset: 0x00088D38
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x000155CC File Offset: 0x000137CC
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x0008AB68 File Offset: 0x00088D68
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x000155EB File Offset: 0x000137EB
		public unsafe RuntimeAnimatorController grabAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_grabAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_grabAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0008AB98 File Offset: 0x00088D98
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x0001560A File Offset: 0x0001380A
		public unsafe RuntimeAnimatorController cowerAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_cowerAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_cowerAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x0008ABC8 File Offset: 0x00088DC8
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00015629 File Offset: 0x00013829
		public unsafe RuntimeAnimatorController fallAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_fallAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_fallAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x0008ABF8 File Offset: 0x00088DF8
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00015648 File Offset: 0x00013848
		public unsafe RuntimeAnimatorController stunnedAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stunnedAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_stunnedAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0008AC28 File Offset: 0x00088E28
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x00015667 File Offset: 0x00013867
		public unsafe RuntimeAnimatorController idleAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_idleAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_idleAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x0008AC58 File Offset: 0x00088E58
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x00015686 File Offset: 0x00013886
		public unsafe Transform gunTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gunTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gunTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x0008AC88 File Offset: 0x00088E88
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x000156A5 File Offset: 0x000138A5
		public unsafe Biped legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Biped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x0008ACB8 File Offset: 0x00088EB8
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x000156C4 File Offset: 0x000138C4
		public unsafe Transform legpawTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_legpawTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_legpawTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0008ACE8 File Offset: 0x00088EE8
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x000156E3 File Offset: 0x000138E3
		public unsafe Vector3 gunPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gunPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gunPos)) = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0008AD10 File Offset: 0x00088F10
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x000156FE File Offset: 0x000138FE
		public unsafe Vector3 handPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_handPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_handPos)) = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0008AD38 File Offset: 0x00088F38
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x00015719 File Offset: 0x00013919
		public unsafe Quaternion gunRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gunRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_gunRot)) = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0008AD60 File Offset: 0x00088F60
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x00015734 File Offset: 0x00013934
		public unsafe bool imASwingBoy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_imASwingBoy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_imASwingBoy)) = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0008AD88 File Offset: 0x00088F88
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0001574F File Offset: 0x0001394F
		public unsafe Vector2 swingDest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swingDest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swingDest)) = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0008ADB0 File Offset: 0x00088FB0
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0001576A File Offset: 0x0001396A
		public unsafe bool swingForceYCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swingForceYCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swingForceYCheck)) = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x0008ADD8 File Offset: 0x00088FD8
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00015785 File Offset: 0x00013985
		public unsafe AnimationCurve swingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_swingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x0008AE08 File Offset: 0x00089008
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x000157A4 File Offset: 0x000139A4
		public unsafe Transform runTheFuckOverHere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_runTheFuckOverHere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_runTheFuckOverHere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x0008AE38 File Offset: 0x00089038
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x000157C3 File Offset: 0x000139C3
		public unsafe GuardCollision collision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_collision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardCollision>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_collision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x0008AE68 File Offset: 0x00089068
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x000157E2 File Offset: 0x000139E2
		public unsafe GuardVision vision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_vision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardVision>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_vision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0008AE98 File Offset: 0x00089098
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00015801 File Offset: 0x00013A01
		public unsafe GuardAudioState audioState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardAudioState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0008AEC8 File Offset: 0x000890C8
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x00015820 File Offset: 0x00013A20
		public unsafe Transform audioStateTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioStateTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioStateTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0008AEF8 File Offset: 0x000890F8
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0001583F File Offset: 0x00013A3F
		public unsafe Vector3 audioStateLocPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioStateLocPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioStateLocPos)) = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x0008AF20 File Offset: 0x00089120
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0001585A File Offset: 0x00013A5A
		public unsafe Quaternion audioStateLocRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioStateLocRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_audioStateLocRot)) = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0008AF48 File Offset: 0x00089148
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00015875 File Offset: 0x00013A75
		public unsafe bool onScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_onScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_onScreen)) = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0008AF70 File Offset: 0x00089170
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00015890 File Offset: 0x00013A90
		public unsafe Vector3 defScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_defScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_defScale)) = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0008AF98 File Offset: 0x00089198
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x000158AB File Offset: 0x00013AAB
		public unsafe bool ranStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_ranStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_ranStart)) = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0008AFC0 File Offset: 0x000891C0
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x000158C6 File Offset: 0x00013AC6
		public unsafe bool fell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_fell);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_fell)) = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x0008AFE8 File Offset: 0x000891E8
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x000158E1 File Offset: 0x00013AE1
		public unsafe List<int> delList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_delList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_delList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x0008B018 File Offset: 0x00089218
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x00015900 File Offset: 0x00013B00
		public unsafe Grabber grabber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_grabber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grabber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_grabber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x0008B048 File Offset: 0x00089248
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0001591F File Offset: 0x00013B1F
		public unsafe float eulerZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_eulerZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_eulerZ)) = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x0008B070 File Offset: 0x00089270
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x0001593A File Offset: 0x00013B3A
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x0008B098 File Offset: 0x00089298
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00015955 File Offset: 0x00013B55
		public unsafe Vector3 posV3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_posV3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_posV3)) = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x0008B0C0 File Offset: 0x000892C0
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x00015970 File Offset: 0x00013B70
		public unsafe Transform myFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_myFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_myFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x0008B0F0 File Offset: 0x000892F0
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0001598F File Offset: 0x00013B8F
		public SECTR_AudioCueInstance yellingInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_yellingInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardState.NativeFieldInfoPtr_yellingInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr_guardType;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_weaponType;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_curMode;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_headTrans;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr_shotReady;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr_lastTarget;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeFieldInfoPtr_pushOrigin;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr_mover;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr_chaseInit;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeFieldInfoPtr_prePushed;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr_onScreenTimer;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeFieldInfoPtr_statusEffects;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr_statRemoveQ;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr_alerted;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr_hasPath;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeFieldInfoPtr_pathPending;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeFieldInfoPtr_pathID;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeFieldInfoPtr_pathFinder;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeFieldInfoPtr_searchGrid;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr_curPathPt;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr_idleSpd;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeFieldInfoPtr_searchSpd;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeFieldInfoPtr_chaseSpd;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeFieldInfoPtr_stalkSpd;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeFieldInfoPtr_attackSpd;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_pushMass;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_modePriority;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_idle;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_stunned;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeFieldInfoPtr_waiting;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr_searching;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr_investigating;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr_lookingAround;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeFieldInfoPtr_chasing;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr_stalking;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_attacking;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeFieldInfoPtr_grabbed;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeFieldInfoPtr_pushed;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeFieldInfoPtr_endPushed;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeFieldInfoPtr_fleeing;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeFieldInfoPtr_panicking;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeFieldInfoPtr_falling;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr_swinging;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeFieldInfoPtr_blind;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeFieldInfoPtr_dontFuckingMove;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeFieldInfoPtr_heat;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeFieldInfoPtr_heatThresh;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeFieldInfoPtr_died;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeFieldInfoPtr_stalkTimer;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr_squadLeader;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr_reinforcement;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr_follower;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr_followPos;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeFieldInfoPtr_leader;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeFieldInfoPtr_hangOut;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr_rotVel;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr_curVel;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeFieldInfoPtr_grabAnim;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeFieldInfoPtr_cowerAnim;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeFieldInfoPtr_fallAnim;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeFieldInfoPtr_stunnedAnim;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeFieldInfoPtr_idleAnim;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeFieldInfoPtr_gunTrans;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeFieldInfoPtr_legpawTrans;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeFieldInfoPtr_gunPos;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr_handPos;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_gunRot;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_imASwingBoy;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr_swingDest;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr_swingForceYCheck;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_swingCurve;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeFieldInfoPtr_runTheFuckOverHere;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr_collision;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr_vision;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_audioState;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_audioStateTrans;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_audioStateLocPos;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr_audioStateLocRot;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_onScreen;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_defScale;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr_ranStart;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeFieldInfoPtr_fell;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeFieldInfoPtr_delList;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeFieldInfoPtr_grabber;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeFieldInfoPtr_eulerZ;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeFieldInfoPtr_posV3;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeFieldInfoPtr_myFire;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeFieldInfoPtr_yellingInstance;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_New_Void_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeeds_Public_Virtual_New_Void_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_Yawn_Public_Void_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_Scratch_Public_Void_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_Fired_Public_Virtual_New_Void_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_KilledPlayer_Public_Void_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_Investigate_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_OnHeardNoise_Public_Void_Vector2_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_Stalk_Public_Void_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePath_Public_Void_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Void_Vector2_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_StartNavigation_Public_Virtual_Void_List_1_Vector2_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_PathFailed_Public_Virtual_Void_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_CancelPath_Public_Void_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_Single_Single_Single_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowardNoDamp_Public_Void_Vector2_Single_Single_Single_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowardNoDamp_Public_Void_Vector2_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_Single_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_MoveToward_Public_Void_Vector2_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_MoveToward_Public_Void_Single_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector2_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_GetNewMode_Public_Void_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_GetStatusMode_Public_GuardMode_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_GetDesiredMode_Public_Virtual_New_GuardMode_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_InitModes_Public_Virtual_New_Void_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_ManageTargets_Public_Void_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_OnScreen_Public_Boolean_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_Attackable_Public_Boolean_GameObject_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_OnSeen_Public_Virtual_Void_GameObject_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_Stun_Public_Void_Int32_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_GameObject_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_Flee_Public_Void_GameObject_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_Panic_Public_Void_GameObject_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_GetStatus_Public_StatusEffect_String_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStatus_Public_Void_String_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_OnPrePushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_OnGrabbed_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000308 RID: 776
		[OriginalName("Assembly-CSharp.dll", "", "Priority")]
		public enum Priority
		{
			// Token: 0x0400344C RID: 13388
			idle,
			// Token: 0x0400344D RID: 13389
			searching,
			// Token: 0x0400344E RID: 13390
			lookingAround,
			// Token: 0x0400344F RID: 13391
			chasing,
			// Token: 0x04003450 RID: 13392
			stalking,
			// Token: 0x04003451 RID: 13393
			waiting,
			// Token: 0x04003452 RID: 13394
			investigating,
			// Token: 0x04003453 RID: 13395
			attacking,
			// Token: 0x04003454 RID: 13396
			fleeing,
			// Token: 0x04003455 RID: 13397
			panicking,
			// Token: 0x04003456 RID: 13398
			onFire,
			// Token: 0x04003457 RID: 13399
			stunned,
			// Token: 0x04003458 RID: 13400
			endPushed,
			// Token: 0x04003459 RID: 13401
			grabbed,
			// Token: 0x0400345A RID: 13402
			pushed,
			// Token: 0x0400345B RID: 13403
			falling,
			// Token: 0x0400345C RID: 13404
			swinging
		}

		// Token: 0x02000309 RID: 777
		[OriginalName("Assembly-CSharp.dll", "", "GuardBodyType")]
		public enum GuardBodyType
		{
			// Token: 0x0400345E RID: 13406
			Default,
			// Token: 0x0400345F RID: 13407
			Skinny,
			// Token: 0x04003460 RID: 13408
			Normal,
			// Token: 0x04003461 RID: 13409
			Fat
		}

		// Token: 0x0200030A RID: 778
		[OriginalName("Assembly-CSharp.dll", "", "WeaponType")]
		public enum WeaponType
		{
			// Token: 0x04003463 RID: 13411
			Default,
			// Token: 0x04003464 RID: 13412
			Rifle,
			// Token: 0x04003465 RID: 13413
			Dynamite,
			// Token: 0x04003466 RID: 13414
			MachineGun,
			// Token: 0x04003467 RID: 13415
			RocketLauncher,
			// Token: 0x04003468 RID: 13416
			ElephantGun,
			// Token: 0x04003469 RID: 13417
			FarOffSniper,
			// Token: 0x0400346A RID: 13418
			FlameThrower,
			// Token: 0x0400346B RID: 13419
			Pistol,
			// Token: 0x0400346C RID: 13420
			ShotGun,
			// Token: 0x0400346D RID: 13421
			SniperRifle,
			// Token: 0x0400346E RID: 13422
			TranqGun,
			// Token: 0x0400346F RID: 13423
			NoGun
		}
	}
}
