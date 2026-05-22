using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000161 RID: 353
	public class PlayerMovement : MonoBehaviour
	{
		// Token: 0x06002A2F RID: 10799 RVA: 0x000A9034 File Offset: 0x000A7234
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMovement()
		{
			Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr);
			PlayerMovement.NativeFieldInfoPtr_deadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "deadzone");
			PlayerMovement.NativeFieldInfoPtr_shoulders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "shoulders");
			PlayerMovement.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "head");
			PlayerMovement.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "state");
			PlayerMovement.NativeFieldInfoPtr_mover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "mover");
			PlayerMovement.NativeFieldInfoPtr_headSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "headSpeed");
			PlayerMovement.NativeFieldInfoPtr_rotSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "rotSpeed");
			PlayerMovement.NativeFieldInfoPtr_lStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lStick");
			PlayerMovement.NativeFieldInfoPtr_rStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "rStick");
			PlayerMovement.NativeFieldInfoPtr_rTrigSt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "rTrigSt");
			PlayerMovement.NativeFieldInfoPtr_lTrigSt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lTrigSt");
			PlayerMovement.NativeFieldInfoPtr_prevRTrigSt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "prevRTrigSt");
			PlayerMovement.NativeFieldInfoPtr_noGrabFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "noGrabFlag");
			PlayerMovement.NativeFieldInfoPtr_orientationFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "orientationFriction");
			PlayerMovement.NativeFieldInfoPtr_grabFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "grabFriction");
			PlayerMovement.NativeFieldInfoPtr_hands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "hands");
			PlayerMovement.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "rb");
			PlayerMovement.NativeFieldInfoPtr_prevVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "prevVel");
			PlayerMovement.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "legs");
			PlayerMovement.NativeFieldInfoPtr_soundAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "soundAnchor");
			PlayerMovement.NativeFieldInfoPtr_grabRotSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "grabRotSpeed");
			PlayerMovement.NativeFieldInfoPtr_quadRotSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "quadRotSpeed");
			PlayerMovement.NativeFieldInfoPtr_prePushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "prePushSpd");
			PlayerMovement.NativeFieldInfoPtr_COMASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "COMASS");
			PlayerMovement.NativeFieldInfoPtr_physMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "physMat");
			PlayerMovement.NativeFieldInfoPtr_stunTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "stunTimer");
			PlayerMovement.NativeFieldInfoPtr_sounder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sounder");
			PlayerMovement.NativeFieldInfoPtr_sounderRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sounderRad");
			PlayerMovement.NativeFieldInfoPtr_curStickForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "curStickForce");
			PlayerMovement.NativeFieldInfoPtr_cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "cursor");
			PlayerMovement.NativeFieldInfoPtr_prevMousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "prevMousePos");
			PlayerMovement.NativeFieldInfoPtr_prevCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "prevCamPos");
			PlayerMovement.NativeFieldInfoPtr_lastControllerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastControllerTime");
			PlayerMovement.NativeFieldInfoPtr_lastKeyboardTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastKeyboardTime");
			PlayerMovement.NativeFieldInfoPtr_keyboardTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "keyboardTexts");
			PlayerMovement.NativeFieldInfoPtr_controllerTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "controllerTexts");
			PlayerMovement.NativeFieldInfoPtr_prevKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "prevKeyboard");
			PlayerMovement.NativeFieldInfoPtr_waitformouseup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "waitformouseup");
			PlayerMovement.NativeFieldInfoPtr_carLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "carLock");
			PlayerMovement.NativeFieldInfoPtr_keepGoingLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "keepGoingLock");
			PlayerMovement.NativeFieldInfoPtr_silent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "silent");
			PlayerMovement.NativeFieldInfoPtr_grabTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "grabTimer");
			PlayerMovement.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "me");
			PlayerMovement.NativeFieldInfoPtr_switcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "switcher");
			PlayerMovement.NativeFieldInfoPtr_lastPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastPush");
			PlayerMovement.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "controller");
			PlayerMovement.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "myPos");
			PlayerMovement.NativeFieldInfoPtr_myPosV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "myPosV2");
			PlayerMovement.NativeFieldInfoPtr_angZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "angZ");
			PlayerMovement.NativeFieldInfoPtr_vel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "vel");
			PlayerMovement.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666635);
			PlayerMovement.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666636);
			PlayerMovement.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666637);
			PlayerMovement.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666638);
			PlayerMovement.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666639);
			PlayerMovement.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666640);
			PlayerMovement.NativeMethodInfoPtr_Move_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666641);
			PlayerMovement.NativeMethodInfoPtr_StickForce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666642);
			PlayerMovement.NativeMethodInfoPtr_OrientationFriction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666643);
			PlayerMovement.NativeMethodInfoPtr_NormalFriction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666644);
			PlayerMovement.NativeMethodInfoPtr_OnBlown_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666645);
			PlayerMovement.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666646);
			PlayerMovement.NativeMethodInfoPtr_OnCollisionStay2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666647);
			PlayerMovement.NativeMethodInfoPtr_SetControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666648);
			PlayerMovement.NativeMethodInfoPtr_ProcControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666649);
			PlayerMovement.NativeMethodInfoPtr_SetHeadDir_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666650);
			PlayerMovement.NativeMethodInfoPtr_RotateBody_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666651);
			PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100666652);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000A95B4 File Offset: 0x000A77B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78277, XrefRangeEnd = 78279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000A95E8 File Offset: 0x000A77E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78279, XrefRangeEnd = 78294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000A961C File Offset: 0x000A781C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78294, XrefRangeEnd = 78303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000A9650 File Offset: 0x000A7850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78303, XrefRangeEnd = 78340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000A9684 File Offset: 0x000A7884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78340, XrefRangeEnd = 78387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000A96B8 File Offset: 0x000A78B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78387, XrefRangeEnd = 78418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000A96EC File Offset: 0x000A78EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78435, RefRangeEnd = 78436, XrefRangeStart = 78418, XrefRangeEnd = 78435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Move_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000A9720 File Offset: 0x000A7920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78477, RefRangeEnd = 78478, XrefRangeStart = 78436, XrefRangeEnd = 78477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StickForce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_StickForce_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000A9754 File Offset: 0x000A7954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78488, RefRangeEnd = 78489, XrefRangeStart = 78478, XrefRangeEnd = 78488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrientationFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_OrientationFriction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000A9788 File Offset: 0x000A7988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78508, RefRangeEnd = 78509, XrefRangeStart = 78489, XrefRangeEnd = 78508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NormalFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_NormalFriction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000A97BC File Offset: 0x000A79BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78509, XrefRangeEnd = 78516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_OnBlown_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000A97FC File Offset: 0x000A79FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78516, XrefRangeEnd = 78592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000A9840 File Offset: 0x000A7A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78592, XrefRangeEnd = 78617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_OnCollisionStay2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000A9884 File Offset: 0x000A7A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78652, RefRangeEnd = 78653, XrefRangeStart = 78617, XrefRangeEnd = 78652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000A98B8 File Offset: 0x000A7AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78729, RefRangeEnd = 78730, XrefRangeStart = 78653, XrefRangeEnd = 78729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ProcControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000A98EC File Offset: 0x000A7AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78757, RefRangeEnd = 78758, XrefRangeStart = 78730, XrefRangeEnd = 78757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadDir()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetHeadDir_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000A9920 File Offset: 0x000A7B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78809, RefRangeEnd = 78810, XrefRangeStart = 78758, XrefRangeEnd = 78809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateBody()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RotateBody_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000A9954 File Offset: 0x000A7B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMovement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x0001D4B9 File Offset: 0x0001B6B9
		public PlayerMovement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000A9990 File Offset: 0x000A7B90
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x0001D4C2 File Offset: 0x0001B6C2
		public unsafe float deadzone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_deadzone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_deadzone)) = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000A99B8 File Offset: 0x000A7BB8
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x0001D4DD File Offset: 0x0001B6DD
		public unsafe GameObject shoulders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_shoulders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_shoulders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000A99E8 File Offset: 0x000A7BE8
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x0001D4FC File Offset: 0x0001B6FC
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000A9A18 File Offset: 0x000A7C18
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x0001D51B File Offset: 0x0001B71B
		public unsafe PlayerState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000A9A48 File Offset: 0x000A7C48
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x0001D53A File Offset: 0x0001B73A
		public unsafe Mover mover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_mover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_mover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000A9A78 File Offset: 0x000A7C78
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0001D559 File Offset: 0x0001B759
		public unsafe float headSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_headSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_headSpeed)) = value;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0001D574 File Offset: 0x0001B774
		public unsafe float rotSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rotSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rotSpeed)) = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000A9AC8 File Offset: 0x000A7CC8
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0001D58F File Offset: 0x0001B78F
		public unsafe Vector2 lStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lStick)) = value;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000A9AF0 File Offset: 0x000A7CF0
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x0001D5AA File Offset: 0x0001B7AA
		public unsafe Vector2 rStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rStick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rStick)) = value;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000A9B18 File Offset: 0x000A7D18
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x0001D5C5 File Offset: 0x0001B7C5
		public unsafe float rTrigSt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rTrigSt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rTrigSt)) = value;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000A9B40 File Offset: 0x000A7D40
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
		public unsafe float lTrigSt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lTrigSt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lTrigSt)) = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000A9B68 File Offset: 0x000A7D68
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x0001D5FB File Offset: 0x0001B7FB
		public unsafe float prevRTrigSt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevRTrigSt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevRTrigSt)) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000A9B90 File Offset: 0x000A7D90
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x0001D616 File Offset: 0x0001B816
		public unsafe bool noGrabFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_noGrabFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_noGrabFlag)) = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
		// (set) Token: 0x06002A5E RID: 10846 RVA: 0x0001D631 File Offset: 0x0001B831
		public unsafe float orientationFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_orientationFriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_orientationFriction)) = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000A9BE0 File Offset: 0x000A7DE0
		// (set) Token: 0x06002A60 RID: 10848 RVA: 0x0001D64C File Offset: 0x0001B84C
		public unsafe float grabFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_grabFriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_grabFriction)) = value;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000A9C08 File Offset: 0x000A7E08
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x0001D667 File Offset: 0x0001B867
		public unsafe PlayerHands hands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_hands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerHands>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_hands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x000A9C38 File Offset: 0x000A7E38
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x0001D686 File Offset: 0x0001B886
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000A9C68 File Offset: 0x000A7E68
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x0001D6A5 File Offset: 0x0001B8A5
		public unsafe Vector2 prevVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevVel)) = value;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000A9C90 File Offset: 0x000A7E90
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
		public unsafe ApeLegs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApeLegs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000A9CC0 File Offset: 0x000A7EC0
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x0001D6DF File Offset: 0x0001B8DF
		public unsafe Vector2 soundAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_soundAnchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_soundAnchor)) = value;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x000A9CE8 File Offset: 0x000A7EE8
		// (set) Token: 0x06002A6C RID: 10860 RVA: 0x0001D6FA File Offset: 0x0001B8FA
		public unsafe float grabRotSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_grabRotSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_grabRotSpeed)) = value;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x000A9D10 File Offset: 0x000A7F10
		// (set) Token: 0x06002A6E RID: 10862 RVA: 0x0001D715 File Offset: 0x0001B915
		public unsafe float quadRotSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_quadRotSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_quadRotSpeed)) = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000A9D38 File Offset: 0x000A7F38
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x0001D730 File Offset: 0x0001B930
		public unsafe float prePushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prePushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prePushSpd)) = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000A9D60 File Offset: 0x000A7F60
		// (set) Token: 0x06002A72 RID: 10866 RVA: 0x0001D74B File Offset: 0x0001B94B
		public unsafe Vector2 COMASS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_COMASS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_COMASS)) = value;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000A9D88 File Offset: 0x000A7F88
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x0001D766 File Offset: 0x0001B966
		public unsafe PhysicsMaterial2D physMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_physMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_physMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000A9DB8 File Offset: 0x000A7FB8
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x0001D785 File Offset: 0x0001B985
		public unsafe int stunTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_stunTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_stunTimer)) = value;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000A9DE0 File Offset: 0x000A7FE0
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
		public unsafe CircleCollider2D sounder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sounder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sounder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000A9E10 File Offset: 0x000A8010
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0001D7BF File Offset: 0x0001B9BF
		public unsafe float sounderRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sounderRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sounderRad)) = value;
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000A9E38 File Offset: 0x000A8038
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x0001D7DA File Offset: 0x0001B9DA
		public unsafe int curStickForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_curStickForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_curStickForce)) = value;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000A9E60 File Offset: 0x000A8060
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x0001D7F5 File Offset: 0x0001B9F5
		public unsafe GameObject cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_cursor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_cursor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000A9E90 File Offset: 0x000A8090
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x0001D814 File Offset: 0x0001BA14
		public unsafe Vector2 prevMousePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevMousePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevMousePos)) = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000A9EB8 File Offset: 0x000A80B8
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x0001D82F File Offset: 0x0001BA2F
		public unsafe Vector2 prevCamPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevCamPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevCamPos)) = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000A9EE0 File Offset: 0x000A80E0
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x0001D84A File Offset: 0x0001BA4A
		public unsafe float lastControllerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastControllerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastControllerTime)) = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000A9F08 File Offset: 0x000A8108
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0001D865 File Offset: 0x0001BA65
		public unsafe float lastKeyboardTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastKeyboardTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastKeyboardTime)) = value;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000A9F30 File Offset: 0x000A8130
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0001D880 File Offset: 0x0001BA80
		public unsafe Il2CppReferenceArray<GameObject> keyboardTexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_keyboardTexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_keyboardTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000A9F60 File Offset: 0x000A8160
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0001D89F File Offset: 0x0001BA9F
		public unsafe Il2CppReferenceArray<GameObject> controllerTexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_controllerTexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_controllerTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000A9F90 File Offset: 0x000A8190
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0001D8BE File Offset: 0x0001BABE
		public unsafe bool prevKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevKeyboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_prevKeyboard)) = value;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000A9FB8 File Offset: 0x000A81B8
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x0001D8D9 File Offset: 0x0001BAD9
		public unsafe bool waitformouseup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_waitformouseup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_waitformouseup)) = value;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000A9FE0 File Offset: 0x000A81E0
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		public unsafe bool carLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_carLock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_carLock)) = value;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000AA008 File Offset: 0x000A8208
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x0001D90F File Offset: 0x0001BB0F
		public unsafe bool keepGoingLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_keepGoingLock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_keepGoingLock)) = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000AA030 File Offset: 0x000A8230
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x0001D92A File Offset: 0x0001BB2A
		public unsafe bool silent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_silent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_silent)) = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000AA058 File Offset: 0x000A8258
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x0001D945 File Offset: 0x0001BB45
		public unsafe float grabTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_grabTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_grabTimer)) = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000AA080 File Offset: 0x000A8280
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x0001D960 File Offset: 0x0001BB60
		public unsafe static PlayerMovement me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000AA0A8 File Offset: 0x000A82A8
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x0001D972 File Offset: 0x0001BB72
		public unsafe bool switcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_switcher);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_switcher)) = value;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x000AA0D0 File Offset: 0x000A82D0
		// (set) Token: 0x06002A9C RID: 10908 RVA: 0x0001D98D File Offset: 0x0001BB8D
		public unsafe float lastPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastPush)) = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x000AA0F8 File Offset: 0x000A82F8
		// (set) Token: 0x06002A9E RID: 10910 RVA: 0x0001D9A8 File Offset: 0x0001BBA8
		public unsafe Player controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x000AA128 File Offset: 0x000A8328
		// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x0001D9C7 File Offset: 0x0001BBC7
		public unsafe Vector3 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000AA150 File Offset: 0x000A8350
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x0001D9E2 File Offset: 0x0001BBE2
		public unsafe Vector2 myPosV2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_myPosV2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_myPosV2)) = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000AA178 File Offset: 0x000A8378
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x0001D9FD File Offset: 0x0001BBFD
		public unsafe float angZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_angZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_angZ)) = value;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000AA1A0 File Offset: 0x000A83A0
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x0001DA18 File Offset: 0x0001BC18
		public unsafe Vector2 vel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_vel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_vel)) = value;
			}
		}

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeFieldInfoPtr_deadzone;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeFieldInfoPtr_shoulders;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeFieldInfoPtr_mover;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeFieldInfoPtr_headSpeed;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeFieldInfoPtr_rotSpeed;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeFieldInfoPtr_lStick;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr_rStick;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_rTrigSt;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr_lTrigSt;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr_prevRTrigSt;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr_noGrabFlag;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeFieldInfoPtr_orientationFriction;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeFieldInfoPtr_grabFriction;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeFieldInfoPtr_hands;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeFieldInfoPtr_prevVel;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeFieldInfoPtr_soundAnchor;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeFieldInfoPtr_grabRotSpeed;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeFieldInfoPtr_quadRotSpeed;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeFieldInfoPtr_prePushSpd;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeFieldInfoPtr_COMASS;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeFieldInfoPtr_physMat;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeFieldInfoPtr_stunTimer;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeFieldInfoPtr_sounder;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeFieldInfoPtr_sounderRad;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeFieldInfoPtr_curStickForce;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeFieldInfoPtr_cursor;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeFieldInfoPtr_prevMousePos;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeFieldInfoPtr_prevCamPos;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr_lastControllerTime;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeFieldInfoPtr_lastKeyboardTime;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr_keyboardTexts;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeFieldInfoPtr_controllerTexts;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeFieldInfoPtr_prevKeyboard;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeFieldInfoPtr_waitformouseup;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeFieldInfoPtr_carLock;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeFieldInfoPtr_keepGoingLock;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeFieldInfoPtr_silent;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeFieldInfoPtr_grabTimer;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeFieldInfoPtr_switcher;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeFieldInfoPtr_lastPush;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr_myPosV2;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr_angZ;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeFieldInfoPtr_vel;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Void_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_StickForce_Public_Void_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_OrientationFriction_Public_Void_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_NormalFriction_Public_Void_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Void_Vector2_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay2D_Public_Void_Collision2D_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_SetControls_Public_Void_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_ProcControls_Public_Void_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadDir_Public_Void_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_RotateBody_Public_Void_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
