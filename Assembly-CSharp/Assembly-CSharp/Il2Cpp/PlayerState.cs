using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000165 RID: 357
	public class PlayerState : State
	{
		// Token: 0x06002AD7 RID: 10967 RVA: 0x000AB198 File Offset: 0x000A9398
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerState()
		{
			Il2CppClassPointerStore<PlayerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerState>.NativeClassPtr);
			PlayerState.NativeFieldInfoPtr_lookVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "lookVect");
			PlayerState.NativeFieldInfoPtr_lookDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "lookDir");
			PlayerState.NativeFieldInfoPtr_shouldDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "shouldDir");
			PlayerState.NativeFieldInfoPtr_shouldVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "shouldVect");
			PlayerState.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "legs");
			PlayerState.NativeFieldInfoPtr_armLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "armLen");
			PlayerState.NativeFieldInfoPtr_shoulderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "shoulderWidth");
			PlayerState.NativeFieldInfoPtr_grabbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabbing");
			PlayerState.NativeFieldInfoPtr_grabbedM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabbedM");
			PlayerState.NativeFieldInfoPtr_grabbedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabbedObj");
			PlayerState.NativeFieldInfoPtr_grabbedGrabber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabbedGrabber");
			PlayerState.NativeFieldInfoPtr_grabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabbed");
			PlayerState.NativeFieldInfoPtr_hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "hand");
			PlayerState.NativeFieldInfoPtr_pushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushing");
			PlayerState.NativeFieldInfoPtr_pushPrep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushPrep");
			PlayerState.NativeFieldInfoPtr_wallPushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "wallPushing");
			PlayerState.NativeFieldInfoPtr_pushReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushReady");
			PlayerState.NativeFieldInfoPtr_pushTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushTimer");
			PlayerState.NativeFieldInfoPtr_pushTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushTime");
			PlayerState.NativeFieldInfoPtr_pushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushed");
			PlayerState.NativeFieldInfoPtr_hasGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "hasGuard");
			PlayerState.NativeFieldInfoPtr_pushedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushedSpeed");
			PlayerState.NativeFieldInfoPtr_pushedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushedList");
			PlayerState.NativeFieldInfoPtr_died = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "died");
			PlayerState.NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "room");
			PlayerState.NativeFieldInfoPtr_histList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "histList");
			PlayerState.NativeFieldInfoPtr_histTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "histTimer");
			PlayerState.NativeFieldInfoPtr_wobblePush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "wobblePush");
			PlayerState.NativeFieldInfoPtr_pushOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "pushOn");
			PlayerState.NativeFieldInfoPtr_grabCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabCol");
			PlayerState.NativeFieldInfoPtr_guardKills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "guardKills");
			PlayerState.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "text");
			PlayerState.NativeFieldInfoPtr_bloodMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "bloodMat");
			PlayerState.NativeFieldInfoPtr_deathLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "deathLine");
			PlayerState.NativeFieldInfoPtr_deathLineTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "deathLineTimer");
			PlayerState.NativeFieldInfoPtr_fleer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fleer");
			PlayerState.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "onFire");
			PlayerState.NativeFieldInfoPtr_fireTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fireTimer");
			PlayerState.NativeFieldInfoPtr_firePart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "firePart");
			PlayerState.NativeFieldInfoPtr_onFireThresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "onFireThresh");
			PlayerState.NativeFieldInfoPtr_fireHeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fireHeat");
			PlayerState.NativeFieldInfoPtr_fireImmuneTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fireImmuneTimer");
			PlayerState.NativeFieldInfoPtr_preHeadButted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "preHeadButted");
			PlayerState.NativeFieldInfoPtr_headButted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "headButted");
			PlayerState.NativeFieldInfoPtr_grabbedBigDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "grabbedBigDoor");
			PlayerState.NativeFieldInfoPtr_holdingBigDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "holdingBigDoor");
			PlayerState.NativeFieldInfoPtr_invul = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "invul");
			PlayerState.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "movement");
			PlayerState.NativeFieldInfoPtr_hands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "hands");
			PlayerState.NativeFieldInfoPtr_shotToDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "shotToDeath");
			PlayerState.NativeFieldInfoPtr_killerGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "killerGuard");
			PlayerState.NativeFieldInfoPtr_whiffedPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "whiffedPush");
			PlayerState.NativeFieldInfoPtr_tranqed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "tranqed");
			PlayerState.NativeFieldInfoPtr_tranqTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "tranqTimer");
			PlayerState.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "renderers");
			PlayerState.NativeFieldInfoPtr_lineObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "lineObj");
			PlayerState.NativeFieldInfoPtr_fellOutWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fellOutWindow");
			PlayerState.NativeFieldInfoPtr_lastLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "lastLine");
			PlayerState.NativeFieldInfoPtr_bleedDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "bleedDad");
			PlayerState.NativeFieldInfoPtr_deadLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "deadLines");
			PlayerState.NativeFieldInfoPtr_numDeadLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "numDeadLines");
			PlayerState.NativeFieldInfoPtr_echoWet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "echoWet");
			PlayerState.NativeFieldInfoPtr_echoDry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "echoDry");
			PlayerState.NativeFieldInfoPtr_unTranqed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "unTranqed");
			PlayerState.NativeFieldInfoPtr_delaypt15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "delaypt15");
			PlayerState.NativeFieldInfoPtr_onFireCueInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "onFireCueInstance");
			PlayerState.NativeFieldInfoPtr_maxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "maxBounds");
			PlayerState.NativeFieldInfoPtr_fireTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fireTrigger");
			PlayerState.NativeFieldInfoPtr_fallVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fallVel");
			PlayerState.NativeFieldInfoPtr_fallTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "fallTimer");
			PlayerState.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666694);
			PlayerState.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666695);
			PlayerState.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666696);
			PlayerState.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666697);
			PlayerState.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666698);
			PlayerState.NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666699);
			PlayerState.NativeMethodInfoPtr_History_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666700);
			PlayerState.NativeMethodInfoPtr_StopFire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666701);
			PlayerState.NativeMethodInfoPtr_UnPaintLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666702);
			PlayerState.NativeMethodInfoPtr_PaintLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666703);
			PlayerState.NativeMethodInfoPtr_DeathLineDeal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666704);
			PlayerState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666705);
			PlayerState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666706);
			PlayerState.NativeMethodInfoPtr_BlurCam_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666707);
			PlayerState.NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666708);
			PlayerState.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666709);
			PlayerState.NativeMethodInfoPtr_ChangeSortingLayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666710);
			PlayerState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, 100666711);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78978, XrefRangeEnd = 78993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000AB8DC File Offset: 0x000A9ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78993, XrefRangeEnd = 79002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000AB910 File Offset: 0x000A9B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79002, XrefRangeEnd = 79060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000AB944 File Offset: 0x000A9B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79060, XrefRangeEnd = 79087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000AB978 File Offset: 0x000A9B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79087, XrefRangeEnd = 79166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000AB9AC File Offset: 0x000A9BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79166, XrefRangeEnd = 79171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFall(Vector2 fallVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fallVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerState.NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000AB9F8 File Offset: 0x000A9BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79188, RefRangeEnd = 79189, XrefRangeStart = 79171, XrefRangeEnd = 79188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void History()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_History_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000ABA2C File Offset: 0x000A9C2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79195, RefRangeEnd = 79198, XrefRangeStart = 79189, XrefRangeEnd = 79195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_StopFire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000ABA60 File Offset: 0x000A9C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79198, XrefRangeEnd = 79202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnPaintLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_UnPaintLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000ABA94 File Offset: 0x000A9C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79225, RefRangeEnd = 79226, XrefRangeStart = 79202, XrefRangeEnd = 79225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PaintLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_PaintLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000ABAC8 File Offset: 0x000A9CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79226, XrefRangeEnd = 79230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeathLineDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_DeathLineDeal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000ABAFC File Offset: 0x000A9CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79230, XrefRangeEnd = 79256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000ABB48 File Offset: 0x000A9D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79256, XrefRangeEnd = 79336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> lest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerState.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000ABB98 File Offset: 0x000A9D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79336, XrefRangeEnd = 79339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BlurCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_BlurCam_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000ABBD8 File Offset: 0x000A9DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79339, XrefRangeEnd = 79346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTranq()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerState.NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000ABC14 File Offset: 0x000A9E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79346, XrefRangeEnd = 79362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerState.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000ABC50 File Offset: 0x000A9E50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 79365, RefRangeEnd = 79371, XrefRangeStart = 79362, XrefRangeEnd = 79365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSortingLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr_ChangeSortingLayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000ABC90 File Offset: 0x000A9E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79371, XrefRangeEnd = 79379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0001DA60 File Offset: 0x0001BC60
		public PlayerState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000ABCCC File Offset: 0x000A9ECC
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x0001DA69 File Offset: 0x0001BC69
		public unsafe Vector2 lookVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lookVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lookVect)) = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x000ABCF4 File Offset: 0x000A9EF4
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x0001DA84 File Offset: 0x0001BC84
		public unsafe int lookDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lookDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lookDir)) = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000ABD1C File Offset: 0x000A9F1C
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0001DA9F File Offset: 0x0001BC9F
		public unsafe int shouldDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shouldDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shouldDir)) = value;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000ABD44 File Offset: 0x000A9F44
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x0001DABA File Offset: 0x0001BCBA
		public unsafe Vector2 shouldVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shouldVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shouldVect)) = value;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000ABD6C File Offset: 0x000A9F6C
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0001DAD5 File Offset: 0x0001BCD5
		public unsafe Legs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Legs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000ABD9C File Offset: 0x000A9F9C
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x0001DAF4 File Offset: 0x0001BCF4
		public unsafe float armLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_armLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_armLen)) = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000ABDC4 File Offset: 0x000A9FC4
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0001DB0F File Offset: 0x0001BD0F
		public unsafe float shoulderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shoulderWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shoulderWidth)) = value;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000ABDEC File Offset: 0x000A9FEC
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x0001DB2A File Offset: 0x0001BD2A
		public unsafe bool grabbing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbing)) = value;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000ABE14 File Offset: 0x000AA014
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x0001DB45 File Offset: 0x0001BD45
		public unsafe Il2CppStructArray<bool> grabbedM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000ABE44 File Offset: 0x000AA044
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0001DB64 File Offset: 0x0001BD64
		public unsafe GameObject grabbedObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000ABE74 File Offset: 0x000AA074
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0001DB83 File Offset: 0x0001BD83
		public unsafe Grabber grabbedGrabber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedGrabber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grabber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedGrabber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000ABEA4 File Offset: 0x000AA0A4
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0001DBA2 File Offset: 0x0001BDA2
		public unsafe bool grabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbed)) = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000ABECC File Offset: 0x000AA0CC
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0001DBBD File Offset: 0x0001BDBD
		public unsafe Il2CppReferenceArray<GameObject> hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000ABEFC File Offset: 0x000AA0FC
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x0001DBDC File Offset: 0x0001BDDC
		public unsafe bool pushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushing)) = value;
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000ABF24 File Offset: 0x000AA124
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x0001DBF7 File Offset: 0x0001BDF7
		public unsafe bool pushPrep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushPrep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushPrep)) = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000ABF4C File Offset: 0x000AA14C
		// (set) Token: 0x06002B0A RID: 11018 RVA: 0x0001DC12 File Offset: 0x0001BE12
		public unsafe bool wallPushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_wallPushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_wallPushing)) = value;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000ABF74 File Offset: 0x000AA174
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x0001DC2D File Offset: 0x0001BE2D
		public unsafe bool pushReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushReady)) = value;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000ABF9C File Offset: 0x000AA19C
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x0001DC48 File Offset: 0x0001BE48
		public unsafe int pushTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushTimer)) = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000ABFC4 File Offset: 0x000AA1C4
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x0001DC63 File Offset: 0x0001BE63
		public unsafe int pushTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushTime)) = value;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x000ABFEC File Offset: 0x000AA1EC
		// (set) Token: 0x06002B12 RID: 11026 RVA: 0x0001DC7E File Offset: 0x0001BE7E
		public unsafe bool pushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushed)) = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x000AC014 File Offset: 0x000AA214
		// (set) Token: 0x06002B14 RID: 11028 RVA: 0x0001DC99 File Offset: 0x0001BE99
		public unsafe bool hasGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_hasGuard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_hasGuard)) = value;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000AC03C File Offset: 0x000AA23C
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
		public unsafe bool pushedSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushedSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushedSpeed)) = value;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x000AC064 File Offset: 0x000AA264
		// (set) Token: 0x06002B18 RID: 11032 RVA: 0x0001DCCF File Offset: 0x0001BECF
		public unsafe Il2CppReferenceArray<List<GameObject>> pushedList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushedList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushedList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x000AC094 File Offset: 0x000AA294
		// (set) Token: 0x06002B1A RID: 11034 RVA: 0x0001DCEE File Offset: 0x0001BEEE
		public unsafe bool died
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_died);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_died)) = value;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000AC0BC File Offset: 0x000AA2BC
		// (set) Token: 0x06002B1C RID: 11036 RVA: 0x0001DD09 File Offset: 0x0001BF09
		public unsafe RoomState room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_room);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoomState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_room), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000AC0EC File Offset: 0x000AA2EC
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x0001DD28 File Offset: 0x0001BF28
		public unsafe List<Vector2> histList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_histList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_histList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x000AC11C File Offset: 0x000AA31C
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x0001DD47 File Offset: 0x0001BF47
		public unsafe int histTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_histTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_histTimer)) = value;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000AC144 File Offset: 0x000AA344
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x0001DD62 File Offset: 0x0001BF62
		public unsafe bool wobblePush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_wobblePush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_wobblePush)) = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000AC16C File Offset: 0x000AA36C
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x0001DD7D File Offset: 0x0001BF7D
		public unsafe bool pushOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_pushOn)) = value;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000AC194 File Offset: 0x000AA394
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x0001DD98 File Offset: 0x0001BF98
		public unsafe Il2CppReferenceArray<GameObject> grabCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabCol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabCol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000AC1C4 File Offset: 0x000AA3C4
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x0001DDB7 File Offset: 0x0001BFB7
		public unsafe float guardKills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_guardKills);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_guardKills)) = value;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000AC1EC File Offset: 0x000AA3EC
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x0001DDD2 File Offset: 0x0001BFD2
		public unsafe Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000AC21C File Offset: 0x000AA41C
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x0001DDF1 File Offset: 0x0001BFF1
		public unsafe Material bloodMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_bloodMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_bloodMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000AC24C File Offset: 0x000AA44C
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x0001DE10 File Offset: 0x0001C010
		public unsafe LineRenderer deathLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_deathLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_deathLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000AC27C File Offset: 0x000AA47C
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x0001DE2F File Offset: 0x0001C02F
		public unsafe int deathLineTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_deathLineTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_deathLineTimer)) = value;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000AC2A4 File Offset: 0x000AA4A4
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x0001DE4A File Offset: 0x0001C04A
		public unsafe GameObject fleer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fleer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fleer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000AC2D4 File Offset: 0x000AA4D4
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x0001DE69 File Offset: 0x0001C069
		public unsafe bool onFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_onFire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_onFire)) = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000AC2FC File Offset: 0x000AA4FC
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x0001DE84 File Offset: 0x0001C084
		public unsafe int fireTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireTimer)) = value;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000AC324 File Offset: 0x000AA524
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x0001DE9F File Offset: 0x0001C09F
		public unsafe ParticleSystem firePart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_firePart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_firePart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000AC354 File Offset: 0x000AA554
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x0001DEBE File Offset: 0x0001C0BE
		public unsafe int onFireThresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_onFireThresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_onFireThresh)) = value;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000AC37C File Offset: 0x000AA57C
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0001DED9 File Offset: 0x0001C0D9
		public unsafe float fireHeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireHeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireHeat)) = value;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000AC3A4 File Offset: 0x000AA5A4
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0001DEF4 File Offset: 0x0001C0F4
		public unsafe int fireImmuneTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireImmuneTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireImmuneTimer)) = value;
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x000AC3CC File Offset: 0x000AA5CC
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x0001DF0F File Offset: 0x0001C10F
		public unsafe bool preHeadButted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_preHeadButted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_preHeadButted)) = value;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000AC3F4 File Offset: 0x000AA5F4
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x0001DF2A File Offset: 0x0001C12A
		public unsafe bool headButted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_headButted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_headButted)) = value;
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x000AC41C File Offset: 0x000AA61C
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x0001DF45 File Offset: 0x0001C145
		public unsafe bool grabbedBigDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedBigDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_grabbedBigDoor)) = value;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000AC444 File Offset: 0x000AA644
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x0001DF60 File Offset: 0x0001C160
		public unsafe bool holdingBigDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_holdingBigDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_holdingBigDoor)) = value;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000AC46C File Offset: 0x000AA66C
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x0001DF7B File Offset: 0x0001C17B
		public unsafe int invul
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_invul);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_invul)) = value;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000AC494 File Offset: 0x000AA694
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x0001DF96 File Offset: 0x0001C196
		public unsafe PlayerMovement movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000AC4C4 File Offset: 0x000AA6C4
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0001DFB5 File Offset: 0x0001C1B5
		public unsafe PlayerHands hands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_hands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerHands>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_hands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000AC4F4 File Offset: 0x000AA6F4
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
		public unsafe bool shotToDeath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shotToDeath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_shotToDeath)) = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000AC51C File Offset: 0x000AA71C
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x0001DFEF File Offset: 0x0001C1EF
		public unsafe string killerGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_killerGuard);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_killerGuard), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x000AC544 File Offset: 0x000AA744
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x0001E00E File Offset: 0x0001C20E
		public unsafe bool whiffedPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_whiffedPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_whiffedPush)) = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000AC56C File Offset: 0x000AA76C
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x0001E029 File Offset: 0x0001C229
		public unsafe bool tranqed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_tranqed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_tranqed)) = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000AC594 File Offset: 0x000AA794
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x0001E044 File Offset: 0x0001C244
		public unsafe int tranqTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_tranqTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_tranqTimer)) = value;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000AC5BC File Offset: 0x000AA7BC
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x0001E05F File Offset: 0x0001C25F
		public unsafe Il2CppReferenceArray<Renderer> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000AC5EC File Offset: 0x000AA7EC
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0001E07E File Offset: 0x0001C27E
		public unsafe LineRenderer lineObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lineObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lineObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000AC61C File Offset: 0x000AA81C
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x0001E09D File Offset: 0x0001C29D
		public unsafe bool fellOutWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fellOutWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fellOutWindow)) = value;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000AC644 File Offset: 0x000AA844
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x0001E0B8 File Offset: 0x0001C2B8
		public unsafe LineRenderer lastLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lastLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_lastLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000AC674 File Offset: 0x000AA874
		// (set) Token: 0x06002B60 RID: 11104 RVA: 0x0001E0D7 File Offset: 0x0001C2D7
		public unsafe Transform bleedDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_bleedDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_bleedDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000AC6A4 File Offset: 0x000AA8A4
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x0001E0F6 File Offset: 0x0001C2F6
		public unsafe Il2CppReferenceArray<LineRenderer> deadLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_deadLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LineRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_deadLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000AC6D4 File Offset: 0x000AA8D4
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0001E115 File Offset: 0x0001C315
		public unsafe int numDeadLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_numDeadLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_numDeadLines)) = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000AC6FC File Offset: 0x000AA8FC
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x0001E130 File Offset: 0x0001C330
		public unsafe string echoWet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_echoWet);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_echoWet), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000AC724 File Offset: 0x000AA924
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x0001E14F File Offset: 0x0001C34F
		public unsafe string echoDry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_echoDry);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_echoDry), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000AC74C File Offset: 0x000AA94C
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x0001E16E File Offset: 0x0001C36E
		public unsafe bool unTranqed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_unTranqed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_unTranqed)) = value;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x000AC774 File Offset: 0x000AA974
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x0001E189 File Offset: 0x0001C389
		public unsafe WaitForSeconds delaypt15
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_delaypt15);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_delaypt15), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x000AC7A4 File Offset: 0x000AA9A4
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		public SECTR_AudioCueInstance onFireCueInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_onFireCueInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_onFireCueInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x0001E1D6 File Offset: 0x0001C3D6
		public unsafe Bounds maxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_maxBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_maxBounds)) = value;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x000AC7FC File Offset: 0x000AA9FC
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x0001E1F1 File Offset: 0x0001C3F1
		public unsafe Il2CppReferenceArray<GameObject> fireTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fireTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000AC82C File Offset: 0x000AAA2C
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x0001E210 File Offset: 0x0001C410
		public unsafe Vector2 fallVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fallVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fallVel)) = value;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000AC854 File Offset: 0x000AAA54
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x0001E22B File Offset: 0x0001C42B
		public unsafe float fallTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fallTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState.NativeFieldInfoPtr_fallTimer)) = value;
			}
		}

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeFieldInfoPtr_lookVect;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeFieldInfoPtr_lookDir;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeFieldInfoPtr_shouldDir;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeFieldInfoPtr_shouldVect;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeFieldInfoPtr_armLen;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr_shoulderWidth;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeFieldInfoPtr_grabbing;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeFieldInfoPtr_grabbedM;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeFieldInfoPtr_grabbedObj;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeFieldInfoPtr_grabbedGrabber;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_grabbed;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_hand;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeFieldInfoPtr_pushing;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_pushPrep;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_wallPushing;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_pushReady;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_pushTimer;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_pushTime;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_pushed;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr_hasGuard;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeFieldInfoPtr_pushedSpeed;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeFieldInfoPtr_pushedList;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr_died;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeFieldInfoPtr_room;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeFieldInfoPtr_histList;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeFieldInfoPtr_histTimer;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeFieldInfoPtr_wobblePush;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr_pushOn;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_grabCol;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr_guardKills;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeFieldInfoPtr_bloodMat;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr_deathLine;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr_deathLineTimer;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr_fleer;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_fireTimer;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeFieldInfoPtr_firePart;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_onFireThresh;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeFieldInfoPtr_fireHeat;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeFieldInfoPtr_fireImmuneTimer;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeFieldInfoPtr_preHeadButted;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeFieldInfoPtr_headButted;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeFieldInfoPtr_grabbedBigDoor;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeFieldInfoPtr_holdingBigDoor;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr_invul;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeFieldInfoPtr_hands;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeFieldInfoPtr_shotToDeath;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr_killerGuard;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr_whiffedPush;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr_tranqed;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr_tranqTimer;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeFieldInfoPtr_lineObj;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr_fellOutWindow;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr_lastLine;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr_bleedDad;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_deadLines;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr_numDeadLines;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr_echoWet;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr_echoDry;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr_unTranqed;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeFieldInfoPtr_delaypt15;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeFieldInfoPtr_onFireCueInstance;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeFieldInfoPtr_maxBounds;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeFieldInfoPtr_fireTrigger;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeFieldInfoPtr_fallVel;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeFieldInfoPtr_fallTimer;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_OnFall_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_History_Public_Void_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_StopFire_Public_Void_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_UnPaintLine_Public_Void_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_PaintLine_Public_Void_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_DeathLineDeal_Public_Void_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_BlurCam_Public_IEnumerator_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_OnTranq_Public_Virtual_Void_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSortingLayer_Public_Void_Int32_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000343 RID: 835
		[ObfuscatedName("PlayerState+<BlurCam>d__83")]
		public sealed class _BlurCam_d__83 : global::Il2CppSystem.Object
		{
			// Token: 0x060052A6 RID: 21158 RVA: 0x0012C2F4 File Offset: 0x0012A4F4
			// Note: this type is marked as 'beforefieldinit'.
			static _BlurCam_d__83()
			{
				Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerState>.NativeClassPtr, "<BlurCam>d__83");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr);
				PlayerState._BlurCam_d__83.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, "<>1__state");
				PlayerState._BlurCam_d__83.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, "<>2__current");
				PlayerState._BlurCam_d__83.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, "<>4__this");
				PlayerState._BlurCam_d__83.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, 100666712);
				PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, 100666713);
				PlayerState._BlurCam_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, 100666714);
				PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, 100666715);
				PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, 100666716);
				PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr, 100666717);
			}

			// Token: 0x060052A7 RID: 21159 RVA: 0x0012C3D4 File Offset: 0x0012A5D4
			[CallerCount(0)]
			public unsafe _BlurCam_d__83(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerState._BlurCam_d__83>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState._BlurCam_d__83.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052A8 RID: 21160 RVA: 0x0012C41C File Offset: 0x0012A61C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052A9 RID: 21161 RVA: 0x0012C450 File Offset: 0x0012A650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78967, XrefRangeEnd = 78973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState._BlurCam_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E23 RID: 7715
			// (get) Token: 0x060052AA RID: 21162 RVA: 0x0012C48C File Offset: 0x0012A68C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052AB RID: 21163 RVA: 0x0012C4CC File Offset: 0x0012A6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78973, XrefRangeEnd = 78978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E24 RID: 7716
			// (get) Token: 0x060052AC RID: 21164 RVA: 0x0012C500 File Offset: 0x0012A700
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerState._BlurCam_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052AD RID: 21165 RVA: 0x000302D9 File Offset: 0x0002E4D9
			public _BlurCam_d__83(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E20 RID: 7712
			// (get) Token: 0x060052AE RID: 21166 RVA: 0x0012C540 File Offset: 0x0012A740
			// (set) Token: 0x060052AF RID: 21167 RVA: 0x000302E2 File Offset: 0x0002E4E2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState._BlurCam_d__83.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState._BlurCam_d__83.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E21 RID: 7713
			// (get) Token: 0x060052B0 RID: 21168 RVA: 0x0012C568 File Offset: 0x0012A768
			// (set) Token: 0x060052B1 RID: 21169 RVA: 0x000302FD File Offset: 0x0002E4FD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState._BlurCam_d__83.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState._BlurCam_d__83.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E22 RID: 7714
			// (get) Token: 0x060052B2 RID: 21170 RVA: 0x0012C598 File Offset: 0x0012A798
			// (set) Token: 0x060052B3 RID: 21171 RVA: 0x0003031C File Offset: 0x0002E51C
			public unsafe PlayerState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState._BlurCam_d__83.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerState._BlurCam_d__83.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003697 RID: 13975
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003698 RID: 13976
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003699 RID: 13977
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400369A RID: 13978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400369B RID: 13979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400369C RID: 13980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400369D RID: 13981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400369E RID: 13982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400369F RID: 13983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
