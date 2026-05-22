using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000160 RID: 352
	public class PlayerHands : MonoBehaviour
	{
		// Token: 0x060029BD RID: 10685 RVA: 0x000A7C30 File Offset: 0x000A5E30
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHands()
		{
			Il2CppClassPointerStore<PlayerHands>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerHands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr);
			PlayerHands.NativeFieldInfoPtr_hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "hand");
			PlayerHands.NativeFieldInfoPtr_shouldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "shouldPos");
			PlayerHands.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "head");
			PlayerHands.NativeFieldInfoPtr_wallPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "wallPushed");
			PlayerHands.NativeFieldInfoPtr_desPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "desPos");
			PlayerHands.NativeFieldInfoPtr_handPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "handPos");
			PlayerHands.NativeFieldInfoPtr_wallPushVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "wallPushVect");
			PlayerHands.NativeFieldInfoPtr_mRelRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "mRelRot");
			PlayerHands.NativeFieldInfoPtr_mPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "mPos");
			PlayerHands.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "state");
			PlayerHands.NativeFieldInfoPtr_mover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "mover");
			PlayerHands.NativeFieldInfoPtr_pushHandSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushHandSpeed");
			PlayerHands.NativeFieldInfoPtr_pushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushSpeed");
			PlayerHands.NativeFieldInfoPtr_unPushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "unPushSpd");
			PlayerHands.NativeFieldInfoPtr_defHandSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "defHandSpeed");
			PlayerHands.NativeFieldInfoPtr_defHandPrepSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "defHandPrepSpeed");
			PlayerHands.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "prevPos");
			PlayerHands.NativeFieldInfoPtr_rightVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "rightVect");
			PlayerHands.NativeFieldInfoPtr_backVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "backVect");
			PlayerHands.NativeFieldInfoPtr_pushGo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushGo");
			PlayerHands.NativeFieldInfoPtr_prePushTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "prePushTimer");
			PlayerHands.NativeFieldInfoPtr_grabMagnetArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabMagnetArr");
			PlayerHands.NativeFieldInfoPtr_grabMagnetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabMagnetRange");
			PlayerHands.NativeFieldInfoPtr_grabbedObjRotSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabbedObjRotSpeed");
			PlayerHands.NativeFieldInfoPtr_grabbedObjDesAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabbedObjDesAng");
			PlayerHands.NativeFieldInfoPtr_locGrabbedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "locGrabbedPos");
			PlayerHands.NativeFieldInfoPtr_handLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "handLocked");
			PlayerHands.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "myPos");
			PlayerHands.NativeFieldInfoPtr_crosshair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "crosshair");
			PlayerHands.NativeFieldInfoPtr_handRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "handRb");
			PlayerHands.NativeFieldInfoPtr_pushTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushTimer");
			PlayerHands.NativeFieldInfoPtr_unPushTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "unPushTimer");
			PlayerHands.NativeFieldInfoPtr_pushBufferTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushBufferTimer");
			PlayerHands.NativeFieldInfoPtr_pushBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushBuffer");
			PlayerHands.NativeFieldInfoPtr_dJoint2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "dJoint2D");
			PlayerHands.NativeFieldInfoPtr_pushedStuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "pushedStuff");
			PlayerHands.NativeFieldInfoPtr_maxHandDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "maxHandDist");
			PlayerHands.NativeFieldInfoPtr_grabbedRotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabbedRotOffset");
			PlayerHands.NativeFieldInfoPtr_grabOffsetRotateAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabOffsetRotateAnim");
			PlayerHands.NativeFieldInfoPtr_grabRotOffsetDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabRotOffsetDist");
			PlayerHands.NativeFieldInfoPtr_grabOffsetRotTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, "grabOffsetRotTimer");
			PlayerHands.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666605);
			PlayerHands.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666606);
			PlayerHands.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666607);
			PlayerHands.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666608);
			PlayerHands.NativeMethodInfoPtr_Crosshair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666609);
			PlayerHands.NativeMethodInfoPtr_Push_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666610);
			PlayerHands.NativeMethodInfoPtr_EndPush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666611);
			PlayerHands.NativeMethodInfoPtr_UnPush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666612);
			PlayerHands.NativeMethodInfoPtr_Grab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666613);
			PlayerHands.NativeMethodInfoPtr_UpdatePos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666614);
			PlayerHands.NativeMethodInfoPtr_SetGrabDesPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666615);
			PlayerHands.NativeMethodInfoPtr_NearestGrabPt_Public_Vector2_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666616);
			PlayerHands.NativeMethodInfoPtr_PlaceGrabHands_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666617);
			PlayerHands.NativeMethodInfoPtr_PlaceGrabbedObj_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666618);
			PlayerHands.NativeMethodInfoPtr_MoveGrabbed_Public_Void_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666619);
			PlayerHands.NativeMethodInfoPtr_GrabbedMConstrain_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666620);
			PlayerHands.NativeMethodInfoPtr_GrabHit_Public_Void_Collision2D_Int32_Tags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666621);
			PlayerHands.NativeMethodInfoPtr_GrabAThing_Public_Void_GameObject_Vector2_Int32_Tags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666622);
			PlayerHands.NativeMethodInfoPtr_SetLocGrabbedPos_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666623);
			PlayerHands.NativeMethodInfoPtr_UpdateLocGrabbedPos_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666624);
			PlayerHands.NativeMethodInfoPtr_ValidGrab_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666625);
			PlayerHands.NativeMethodInfoPtr_SetPushDesPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666626);
			PlayerHands.NativeMethodInfoPtr_PlacePushHands_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666627);
			PlayerHands.NativeMethodInfoPtr_PlacePushObj_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666628);
			PlayerHands.NativeMethodInfoPtr_PushStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666629);
			PlayerHands.NativeMethodInfoPtr_PushHit_Public_Void_GameObject_Int32_Tags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666630);
			PlayerHands.NativeMethodInfoPtr_MiscHit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666631);
			PlayerHands.NativeMethodInfoPtr_MovePlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666632);
			PlayerHands.NativeMethodInfoPtr_WallConstrain_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666633);
			PlayerHands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr, 100666634);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000A81EC File Offset: 0x000A63EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77291, XrefRangeEnd = 77354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000A8220 File Offset: 0x000A6420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77354, XrefRangeEnd = 77369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000A8254 File Offset: 0x000A6454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77369, XrefRangeEnd = 77378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000A8288 File Offset: 0x000A6488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77378, XrefRangeEnd = 77393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000A82BC File Offset: 0x000A64BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77393, XrefRangeEnd = 77408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Crosshair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_Crosshair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000A82F0 File Offset: 0x000A64F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77408, XrefRangeEnd = 77411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_Push_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000A8324 File Offset: 0x000A6524
		[CallerCount(0)]
		public unsafe void EndPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_EndPush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000A8358 File Offset: 0x000A6558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77429, RefRangeEnd = 77430, XrefRangeStart = 77411, XrefRangeEnd = 77429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_UnPush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000A838C File Offset: 0x000A658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77430, XrefRangeEnd = 77433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_Grab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000A83C0 File Offset: 0x000A65C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77461, RefRangeEnd = 77462, XrefRangeStart = 77433, XrefRangeEnd = 77461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_UpdatePos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000A83F4 File Offset: 0x000A65F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77606, RefRangeEnd = 77608, XrefRangeStart = 77462, XrefRangeEnd = 77606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrabDesPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_SetGrabDesPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000A8428 File Offset: 0x000A6628
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77641, RefRangeEnd = 77644, XrefRangeStart = 77608, XrefRangeEnd = 77641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 NearestGrabPt(GameObject o, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_NearestGrabPt_Public_Vector2_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000A8484 File Offset: 0x000A6684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77681, RefRangeEnd = 77683, XrefRangeStart = 77644, XrefRangeEnd = 77681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceGrabHands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_PlaceGrabHands_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000A84B8 File Offset: 0x000A66B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77694, RefRangeEnd = 77696, XrefRangeStart = 77683, XrefRangeEnd = 77694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceGrabbedObj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_PlaceGrabbedObj_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000A84EC File Offset: 0x000A66EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77757, RefRangeEnd = 77758, XrefRangeStart = 77696, XrefRangeEnd = 77757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveGrabbed(GameObject obj, Vector2 goalPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goalPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_MoveGrabbed_Public_Void_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000A853C File Offset: 0x000A673C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77770, RefRangeEnd = 77771, XrefRangeStart = 77758, XrefRangeEnd = 77770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GrabbedMConstrain(Vector2 _mPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _mPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_GrabbedMConstrain_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000A8588 File Offset: 0x000A6788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77779, RefRangeEnd = 77780, XrefRangeStart = 77771, XrefRangeEnd = 77779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabHit(Collision2D coll, int i, Tags tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_GrabHit_Public_Void_Collision2D_Int32_Tags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000A85EC File Offset: 0x000A67EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77914, RefRangeEnd = 77916, XrefRangeStart = 77780, XrefRangeEnd = 77914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabAThing(GameObject coll, Vector2 pt, int i, Tags tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_GrabAThing_Public_Void_GameObject_Vector2_Int32_Tags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000A8660 File Offset: 0x000A6860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77927, RefRangeEnd = 77929, XrefRangeStart = 77916, XrefRangeEnd = 77927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocGrabbedPos(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_SetLocGrabbedPos_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000A86A0 File Offset: 0x000A68A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77938, XrefRangeStart = 77929, XrefRangeEnd = 77936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLocGrabbedPos(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_UpdateLocGrabbedPos_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000A86E0 File Offset: 0x000A68E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77978, RefRangeEnd = 77979, XrefRangeStart = 77938, XrefRangeEnd = 77978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidGrab(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_ValidGrab_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000A8730 File Offset: 0x000A6930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77979, RefRangeEnd = 77981, XrefRangeStart = 77979, XrefRangeEnd = 77979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPushDesPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_SetPushDesPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000A8764 File Offset: 0x000A6964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78039, RefRangeEnd = 78041, XrefRangeStart = 77981, XrefRangeEnd = 78039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlacePushHands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_PlacePushHands_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000A8798 File Offset: 0x000A6998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78136, RefRangeEnd = 78138, XrefRangeStart = 78041, XrefRangeEnd = 78136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlacePushObj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_PlacePushObj_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000A87CC File Offset: 0x000A69CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78215, RefRangeEnd = 78216, XrefRangeStart = 78138, XrefRangeEnd = 78215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_PushStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000A8800 File Offset: 0x000A6A00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78223, RefRangeEnd = 78226, XrefRangeStart = 78216, XrefRangeEnd = 78223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushHit(GameObject obj, int i, Tags tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_PushHit_Public_Void_GameObject_Int32_Tags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000A8864 File Offset: 0x000A6A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78226, XrefRangeEnd = 78253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MiscHit(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_MiscHit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000A88A4 File Offset: 0x000A6AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78265, RefRangeEnd = 78266, XrefRangeStart = 78253, XrefRangeEnd = 78265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_MovePlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000A88D8 File Offset: 0x000A6AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78266, XrefRangeEnd = 78277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WallConstrain(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr_WallConstrain_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000A8918 File Offset: 0x000A6B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHands()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHands>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x0001D021 File Offset: 0x0001B221
		public PlayerHands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x000A8954 File Offset: 0x000A6B54
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x0001D02A File Offset: 0x0001B22A
		public unsafe Il2CppReferenceArray<GameObject> hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x000A8984 File Offset: 0x000A6B84
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0001D049 File Offset: 0x0001B249
		public unsafe Il2CppStructArray<Vector2> shouldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_shouldPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_shouldPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x000A89B4 File Offset: 0x000A6BB4
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0001D068 File Offset: 0x0001B268
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000A89E4 File Offset: 0x000A6BE4
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x0001D087 File Offset: 0x0001B287
		public unsafe bool wallPushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_wallPushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_wallPushed)) = value;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000A8A0C File Offset: 0x000A6C0C
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0001D0A2 File Offset: 0x0001B2A2
		public unsafe Il2CppStructArray<Vector2> desPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_desPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_desPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000A8A3C File Offset: 0x000A6C3C
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0001D0C1 File Offset: 0x0001B2C1
		public unsafe Il2CppStructArray<Vector2> handPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_handPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_handPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000A8A6C File Offset: 0x000A6C6C
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		public unsafe Il2CppStructArray<Vector2> wallPushVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_wallPushVect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_wallPushVect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x000A8A9C File Offset: 0x000A6C9C
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x0001D0FF File Offset: 0x0001B2FF
		public unsafe float mRelRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_mRelRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_mRelRot)) = value;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000A8AC4 File Offset: 0x000A6CC4
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x0001D11A File Offset: 0x0001B31A
		public unsafe Vector2 mPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_mPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_mPos)) = value;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000A8AEC File Offset: 0x000A6CEC
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0001D135 File Offset: 0x0001B335
		public unsafe PlayerState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000A8B1C File Offset: 0x000A6D1C
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x0001D154 File Offset: 0x0001B354
		public unsafe Mover mover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_mover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_mover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000A8B4C File Offset: 0x000A6D4C
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x0001D173 File Offset: 0x0001B373
		public unsafe float pushHandSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushHandSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushHandSpeed)) = value;
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000A8B74 File Offset: 0x000A6D74
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x0001D18E File Offset: 0x0001B38E
		public unsafe float pushSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushSpeed)) = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000A8B9C File Offset: 0x000A6D9C
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x0001D1A9 File Offset: 0x0001B3A9
		public unsafe float unPushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_unPushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_unPushSpd)) = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000A8BC4 File Offset: 0x000A6DC4
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
		public unsafe float defHandSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_defHandSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_defHandSpeed)) = value;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x000A8BEC File Offset: 0x000A6DEC
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x0001D1DF File Offset: 0x0001B3DF
		public unsafe float defHandPrepSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_defHandPrepSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_defHandPrepSpeed)) = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x000A8C14 File Offset: 0x000A6E14
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x0001D1FA File Offset: 0x0001B3FA
		public unsafe Vector2 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000A8C3C File Offset: 0x000A6E3C
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x0001D215 File Offset: 0x0001B415
		public unsafe Vector2 rightVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_rightVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_rightVect)) = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000A8C64 File Offset: 0x000A6E64
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x0001D230 File Offset: 0x0001B430
		public unsafe Vector2 backVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_backVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_backVect)) = value;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000A8C8C File Offset: 0x000A6E8C
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0001D24B File Offset: 0x0001B44B
		public unsafe bool pushGo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushGo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushGo)) = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000A8CB4 File Offset: 0x000A6EB4
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0001D266 File Offset: 0x0001B466
		public unsafe int prePushTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_prePushTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_prePushTimer)) = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000A8CDC File Offset: 0x000A6EDC
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0001D281 File Offset: 0x0001B481
		public unsafe Il2CppReferenceArray<Collider2D> grabMagnetArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabMagnetArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabMagnetArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000A8D0C File Offset: 0x000A6F0C
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		public unsafe float grabMagnetRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabMagnetRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabMagnetRange)) = value;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000A8D34 File Offset: 0x000A6F34
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x0001D2BB File Offset: 0x0001B4BB
		public unsafe float grabbedObjRotSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabbedObjRotSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabbedObjRotSpeed)) = value;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000A8D5C File Offset: 0x000A6F5C
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x0001D2D6 File Offset: 0x0001B4D6
		public unsafe float grabbedObjDesAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabbedObjDesAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabbedObjDesAng)) = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000A8D84 File Offset: 0x000A6F84
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0001D2F1 File Offset: 0x0001B4F1
		public unsafe Il2CppStructArray<Vector2> locGrabbedPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_locGrabbedPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_locGrabbedPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000A8DB4 File Offset: 0x000A6FB4
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0001D310 File Offset: 0x0001B510
		public unsafe Il2CppStructArray<bool> handLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_handLocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_handLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000A8DE4 File Offset: 0x000A6FE4
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0001D32F File Offset: 0x0001B52F
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000A8E0C File Offset: 0x000A700C
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0001D34A File Offset: 0x0001B54A
		public unsafe GameObject crosshair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_crosshair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_crosshair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000A8E3C File Offset: 0x000A703C
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0001D369 File Offset: 0x0001B569
		public unsafe Il2CppReferenceArray<Rigidbody2D> handRb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_handRb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_handRb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000A8E6C File Offset: 0x000A706C
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x0001D388 File Offset: 0x0001B588
		public unsafe int pushTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushTimer)) = value;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000A8E94 File Offset: 0x000A7094
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x0001D3A3 File Offset: 0x0001B5A3
		public unsafe int unPushTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_unPushTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_unPushTimer)) = value;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000A8EBC File Offset: 0x000A70BC
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x0001D3BE File Offset: 0x0001B5BE
		public unsafe int pushBufferTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushBufferTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushBufferTimer)) = value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000A8EE4 File Offset: 0x000A70E4
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x0001D3D9 File Offset: 0x0001B5D9
		public unsafe int pushBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushBuffer)) = value;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x000A8F0C File Offset: 0x000A710C
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0001D3F4 File Offset: 0x0001B5F4
		public unsafe DistanceJoint2D dJoint2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_dJoint2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DistanceJoint2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_dJoint2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000A8F3C File Offset: 0x000A713C
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0001D413 File Offset: 0x0001B613
		public unsafe bool pushedStuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushedStuff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_pushedStuff)) = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000A8F64 File Offset: 0x000A7164
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x0001D42E File Offset: 0x0001B62E
		public unsafe float maxHandDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_maxHandDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_maxHandDist)) = value;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000A8F8C File Offset: 0x000A718C
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x0001D449 File Offset: 0x0001B649
		public unsafe float grabbedRotOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabbedRotOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabbedRotOffset)) = value;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000A8FB4 File Offset: 0x000A71B4
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x0001D464 File Offset: 0x0001B664
		public unsafe AnimationCurve grabOffsetRotateAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabOffsetRotateAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabOffsetRotateAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000A8FE4 File Offset: 0x000A71E4
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x0001D483 File Offset: 0x0001B683
		public unsafe float grabRotOffsetDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabRotOffsetDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabRotOffsetDist)) = value;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000A900C File Offset: 0x000A720C
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x0001D49E File Offset: 0x0001B69E
		public unsafe float grabOffsetRotTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabOffsetRotTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHands.NativeFieldInfoPtr_grabOffsetRotTimer)) = value;
			}
		}

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeFieldInfoPtr_hand;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeFieldInfoPtr_shouldPos;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeFieldInfoPtr_wallPushed;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeFieldInfoPtr_desPos;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeFieldInfoPtr_handPos;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeFieldInfoPtr_wallPushVect;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeFieldInfoPtr_mRelRot;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeFieldInfoPtr_mPos;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeFieldInfoPtr_mover;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeFieldInfoPtr_pushHandSpeed;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr_pushSpeed;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeFieldInfoPtr_unPushSpd;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeFieldInfoPtr_defHandSpeed;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeFieldInfoPtr_defHandPrepSpeed;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeFieldInfoPtr_rightVect;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeFieldInfoPtr_backVect;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeFieldInfoPtr_pushGo;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr_prePushTimer;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeFieldInfoPtr_grabMagnetArr;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeFieldInfoPtr_grabMagnetRange;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeFieldInfoPtr_grabbedObjRotSpeed;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeFieldInfoPtr_grabbedObjDesAng;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeFieldInfoPtr_locGrabbedPos;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeFieldInfoPtr_handLocked;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeFieldInfoPtr_crosshair;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr_handRb;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeFieldInfoPtr_pushTimer;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeFieldInfoPtr_unPushTimer;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeFieldInfoPtr_pushBufferTimer;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeFieldInfoPtr_pushBuffer;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeFieldInfoPtr_dJoint2D;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeFieldInfoPtr_pushedStuff;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeFieldInfoPtr_maxHandDist;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeFieldInfoPtr_grabbedRotOffset;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeFieldInfoPtr_grabOffsetRotateAnim;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeFieldInfoPtr_grabRotOffsetDist;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_grabOffsetRotTimer;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_Crosshair_Public_Void_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_EndPush_Public_Void_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr_UnPush_Public_Void_0;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr_Grab_Public_Void_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePos_Public_Void_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_SetGrabDesPos_Public_Void_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_NearestGrabPt_Public_Vector2_GameObject_Int32_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_PlaceGrabHands_Public_Void_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_PlaceGrabbedObj_Public_Void_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_MoveGrabbed_Public_Void_GameObject_Vector2_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_GrabbedMConstrain_Public_Vector2_Vector2_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_GrabHit_Public_Void_Collision2D_Int32_Tags_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_GrabAThing_Public_Void_GameObject_Vector2_Int32_Tags_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_SetLocGrabbedPos_Public_Void_Int32_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLocGrabbedPos_Private_Void_Int32_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_ValidGrab_Public_Boolean_GameObject_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_SetPushDesPos_Public_Void_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_PlacePushHands_Public_Void_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_PlacePushObj_Public_Void_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_PushStuff_Public_Void_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_PushHit_Public_Void_GameObject_Int32_Tags_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_MiscHit_Public_Void_Int32_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_MovePlayer_Public_Void_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_WallConstrain_Public_Void_Int32_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
