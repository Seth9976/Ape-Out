using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000F6 RID: 246
	public class GuardGun : MonoBehaviour
	{
		// Token: 0x06001CE7 RID: 7399 RVA: 0x00085830 File Offset: 0x00083A30
		// Note: this type is marked as 'beforefieldinit'.
		static GuardGun()
		{
			Il2CppClassPointerStore<GuardGun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardGun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardGun>.NativeClassPtr);
			GuardGun.NativeFieldInfoPtr_shootLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shootLayers");
			GuardGun.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "state");
			GuardGun.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "gun");
			GuardGun.NativeFieldInfoPtr_gunTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "gunTrans");
			GuardGun.NativeFieldInfoPtr_sr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "sr");
			GuardGun.NativeFieldInfoPtr_cockTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "cockTimer");
			GuardGun.NativeFieldInfoPtr_cockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "cockTime");
			GuardGun.NativeFieldInfoPtr_shootPrepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shootPrepTime");
			GuardGun.NativeFieldInfoPtr_cocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "cocking");
			GuardGun.NativeFieldInfoPtr_cockingInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "cockingInstance");
			GuardGun.NativeFieldInfoPtr_defGunAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "defGunAng");
			GuardGun.NativeFieldInfoPtr_aimGunAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "aimGunAng");
			GuardGun.NativeFieldInfoPtr_aimSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "aimSpeed");
			GuardGun.NativeFieldInfoPtr_spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "spread");
			GuardGun.NativeFieldInfoPtr_kick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "kick");
			GuardGun.NativeFieldInfoPtr_defGunPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "defGunPos");
			GuardGun.NativeFieldInfoPtr_aimGunPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "aimGunPos");
			GuardGun.NativeFieldInfoPtr_aiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "aiming");
			GuardGun.NativeFieldInfoPtr_muzzDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "muzzDist");
			GuardGun.NativeFieldInfoPtr_flash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "flash");
			GuardGun.NativeFieldInfoPtr_shootPrep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shootPrep");
			GuardGun.NativeFieldInfoPtr_shootPrepTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shootPrepTimer");
			GuardGun.NativeFieldInfoPtr_shotArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shotArr");
			GuardGun.NativeFieldInfoPtr_cockCueDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "cockCueDelay");
			GuardGun.NativeFieldInfoPtr_sheller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "sheller");
			GuardGun.NativeFieldInfoPtr_hasShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "hasShot");
			GuardGun.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "beam");
			GuardGun.NativeFieldInfoPtr_muzzPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "muzzPos");
			GuardGun.NativeFieldInfoPtr_redBeamMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "redBeamMat");
			GuardGun.NativeFieldInfoPtr_flashlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "flashlightsOn");
			GuardGun.NativeFieldInfoPtr_igArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "igArr");
			GuardGun.NativeFieldInfoPtr_layerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "layerList");
			GuardGun.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "debugging");
			GuardGun.NativeFieldInfoPtr_debugTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "debugTxt");
			GuardGun.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "legs");
			GuardGun.NativeFieldInfoPtr_prevStealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "prevStealth");
			GuardGun.NativeFieldInfoPtr_shotGrabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shotGrabbed");
			GuardGun.NativeFieldInfoPtr_cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "cleared");
			GuardGun.NativeFieldInfoPtr_shellerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shellerPos");
			GuardGun.NativeFieldInfoPtr_shellerRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shellerRot");
			GuardGun.NativeFieldInfoPtr_shellerDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "shellerDad");
			GuardGun.NativeFieldInfoPtr_grabShootDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "grabShootDelay");
			GuardGun.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "trans");
			GuardGun.NativeFieldInfoPtr_ignoreLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "ignoreLayer");
			GuardGun.NativeFieldInfoPtr_playerString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, "playerString");
			GuardGun.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665640);
			GuardGun.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665641);
			GuardGun.NativeMethodInfoPtr_ResetSheller_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665642);
			GuardGun.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665643);
			GuardGun.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665644);
			GuardGun.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665645);
			GuardGun.NativeMethodInfoPtr_SetPrevStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665646);
			GuardGun.NativeMethodInfoPtr_Aim_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665647);
			GuardGun.NativeMethodInfoPtr_ManageCocking_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665648);
			GuardGun.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_New_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665649);
			GuardGun.NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665650);
			GuardGun.NativeMethodInfoPtr_AimAt_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665651);
			GuardGun.NativeMethodInfoPtr_RelaxGun_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665652);
			GuardGun.NativeMethodInfoPtr_MoveGun_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665653);
			GuardGun.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665654);
			GuardGun.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665655);
			GuardGun.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665656);
			GuardGun.NativeMethodInfoPtr_ShootThatShit_Public_Virtual_New_Void_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665657);
			GuardGun.NativeMethodInfoPtr_DrawTrail_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665658);
			GuardGun.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665659);
			GuardGun.NativeMethodInfoPtr_ShotEffects_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665660);
			GuardGun.NativeMethodInfoPtr_PutOnFlashLight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665661);
			GuardGun.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665662);
			GuardGun.NativeMethodInfoPtr_TakeFlashLightOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665663);
			GuardGun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGun>.NativeClassPtr, 100665664);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00085DD8 File Offset: 0x00083FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63640, XrefRangeEnd = 63654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00085E14 File Offset: 0x00084014
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 63839, RefRangeEnd = 63848, XrefRangeStart = 63654, XrefRangeEnd = 63839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00085E50 File Offset: 0x00084050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63871, RefRangeEnd = 63872, XrefRangeStart = 63848, XrefRangeEnd = 63871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetSheller()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_ResetSheller_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00085E8C File Offset: 0x0008408C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 63920, RefRangeEnd = 63923, XrefRangeStart = 63872, XrefRangeEnd = 63920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00085EC8 File Offset: 0x000840C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63923, XrefRangeEnd = 63936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00085F04 File Offset: 0x00084104
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63947, RefRangeEnd = 63951, XrefRangeStart = 63936, XrefRangeEnd = 63947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00085F40 File Offset: 0x00084140
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrevStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGun.NativeMethodInfoPtr_SetPrevStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00085F74 File Offset: 0x00084174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63951, XrefRangeEnd = 63969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Aim(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_Aim_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00085FC0 File Offset: 0x000841C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63973, RefRangeEnd = 63974, XrefRangeStart = 63969, XrefRangeEnd = 63973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ManageCocking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_ManageCocking_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00085FFC File Offset: 0x000841FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63974, XrefRangeEnd = 63984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayShotSnd(Vector3 muzzlePosition, Quaternion aimRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref muzzlePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aimRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_New_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00086054 File Offset: 0x00084254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63984, XrefRangeEnd = 63989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayCockSnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00086090 File Offset: 0x00084290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64012, RefRangeEnd = 64013, XrefRangeStart = 63989, XrefRangeEnd = 64012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AimAt(Vector2 aimPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aimPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_AimAt_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000860DC File Offset: 0x000842DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64020, RefRangeEnd = 64021, XrefRangeStart = 64013, XrefRangeEnd = 64020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RelaxGun()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGun.NativeMethodInfoPtr_RelaxGun_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00086110 File Offset: 0x00084310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64021, XrefRangeEnd = 64040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveGun()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_MoveGun_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0008614C File Offset: 0x0008434C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64040, XrefRangeEnd = 64041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00086188 File Offset: 0x00084388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64059, RefRangeEnd = 64060, XrefRangeStart = 64041, XrefRangeEnd = 64059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000861C4 File Offset: 0x000843C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64060, XrefRangeEnd = 64246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MakeBulletGo(Vector2 shotVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shotVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00086210 File Offset: 0x00084410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64246, XrefRangeEnd = 64267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShootThatShit(RaycastHit2D ray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_ShootThatShit_Public_Virtual_New_Void_RaycastHit2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0008625C File Offset: 0x0008445C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64267, XrefRangeEnd = 64273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawTrail(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_DrawTrail_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000862A8 File Offset: 0x000844A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64273, XrefRangeEnd = 64296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGun.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000862DC File Offset: 0x000844DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64296, XrefRangeEnd = 64390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShotEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_ShotEffects_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00086318 File Offset: 0x00084518
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64427, RefRangeEnd = 64430, XrefRangeStart = 64390, XrefRangeEnd = 64427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutOnFlashLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGun.NativeMethodInfoPtr_PutOnFlashLight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0008634C File Offset: 0x0008454C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64438, RefRangeEnd = 64440, XrefRangeStart = 64430, XrefRangeEnd = 64438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGun.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00086388 File Offset: 0x00084588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64476, RefRangeEnd = 64477, XrefRangeStart = 64440, XrefRangeEnd = 64476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeFlashLightOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGun.NativeMethodInfoPtr_TakeFlashLightOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000863BC File Offset: 0x000845BC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 64482, RefRangeEnd = 64492, XrefRangeStart = 64477, XrefRangeEnd = 64482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardGun()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardGun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0001456D File Offset: 0x0001276D
		public GuardGun(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000863F8 File Offset: 0x000845F8
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00014576 File Offset: 0x00012776
		public unsafe LayerMask shootLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootLayers)) = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00086420 File Offset: 0x00084620
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x00014591 File Offset: 0x00012791
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00086450 File Offset: 0x00084650
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x000145B0 File Offset: 0x000127B0
		public unsafe GameObject gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00086480 File Offset: 0x00084680
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x000145CF File Offset: 0x000127CF
		public unsafe Transform gunTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_gunTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_gunTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000864B0 File Offset: 0x000846B0
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x000145EE File Offset: 0x000127EE
		public unsafe SpriteRenderer sr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_sr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_sr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000864E0 File Offset: 0x000846E0
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x0001460D File Offset: 0x0001280D
		public unsafe int cockTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockTimer)) = value;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00086508 File Offset: 0x00084708
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00014628 File Offset: 0x00012828
		public unsafe int cockTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockTime)) = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00086530 File Offset: 0x00084730
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00014643 File Offset: 0x00012843
		public unsafe int shootPrepTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootPrepTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootPrepTime)) = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00086558 File Offset: 0x00084758
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x0001465E File Offset: 0x0001285E
		public unsafe bool cocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cocking)) = value;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00086580 File Offset: 0x00084780
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00014679 File Offset: 0x00012879
		public SECTR_AudioCueInstance cockingInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockingInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockingInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000865B0 File Offset: 0x000847B0
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x000146A7 File Offset: 0x000128A7
		public unsafe float defGunAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_defGunAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_defGunAng)) = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000865D8 File Offset: 0x000847D8
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x000146C2 File Offset: 0x000128C2
		public unsafe float aimGunAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aimGunAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aimGunAng)) = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00086600 File Offset: 0x00084800
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000146DD File Offset: 0x000128DD
		public unsafe float aimSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aimSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aimSpeed)) = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00086628 File Offset: 0x00084828
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x000146F8 File Offset: 0x000128F8
		public unsafe float spread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_spread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_spread)) = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00086650 File Offset: 0x00084850
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00014713 File Offset: 0x00012913
		public unsafe float kick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_kick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_kick)) = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00086678 File Offset: 0x00084878
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0001472E File Offset: 0x0001292E
		public unsafe Vector2 defGunPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_defGunPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_defGunPos)) = value;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x000866A0 File Offset: 0x000848A0
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00014749 File Offset: 0x00012949
		public unsafe Vector2 aimGunPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aimGunPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aimGunPos)) = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000866C8 File Offset: 0x000848C8
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00014764 File Offset: 0x00012964
		public unsafe bool aiming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aiming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_aiming)) = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000866F0 File Offset: 0x000848F0
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0001477F File Offset: 0x0001297F
		public unsafe float muzzDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_muzzDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_muzzDist)) = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00086718 File Offset: 0x00084918
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x0001479A File Offset: 0x0001299A
		public unsafe FX.FlashType flash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_flash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_flash)) = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00086740 File Offset: 0x00084940
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x000147B5 File Offset: 0x000129B5
		public unsafe bool shootPrep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootPrep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootPrep)) = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00086768 File Offset: 0x00084968
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x000147D0 File Offset: 0x000129D0
		public unsafe int shootPrepTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootPrepTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shootPrepTimer)) = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00086790 File Offset: 0x00084990
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x000147EB File Offset: 0x000129EB
		public unsafe Il2CppStructArray<Vector2> shotArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shotArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shotArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x000867C0 File Offset: 0x000849C0
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x0001480A File Offset: 0x00012A0A
		public unsafe int cockCueDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockCueDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cockCueDelay)) = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x000867E8 File Offset: 0x000849E8
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00014825 File Offset: 0x00012A25
		public unsafe ParticleSystem sheller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_sheller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_sheller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x00086818 File Offset: 0x00084A18
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00014844 File Offset: 0x00012A44
		public unsafe bool hasShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_hasShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_hasShot)) = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00086840 File Offset: 0x00084A40
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x0001485F File Offset: 0x00012A5F
		public unsafe MeshFilter beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00086870 File Offset: 0x00084A70
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0001487E File Offset: 0x00012A7E
		public unsafe Vector2 muzzPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_muzzPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_muzzPos)) = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00086898 File Offset: 0x00084A98
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00014899 File Offset: 0x00012A99
		public unsafe Material redBeamMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_redBeamMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_redBeamMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x000868C8 File Offset: 0x00084AC8
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x000148B8 File Offset: 0x00012AB8
		public unsafe bool flashlightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_flashlightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_flashlightsOn)) = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x000868F0 File Offset: 0x00084AF0
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x000148D3 File Offset: 0x00012AD3
		public unsafe Il2CppReferenceArray<GameObject> igArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_igArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_igArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00086920 File Offset: 0x00084B20
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x000148F2 File Offset: 0x00012AF2
		public unsafe Il2CppStructArray<int> layerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_layerList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_layerList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00086950 File Offset: 0x00084B50
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00014911 File Offset: 0x00012B11
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00086978 File Offset: 0x00084B78
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0001492C File Offset: 0x00012B2C
		public unsafe TextMesh debugTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_debugTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_debugTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x000869A8 File Offset: 0x00084BA8
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0001494B File Offset: 0x00012B4B
		public unsafe Legs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Legs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000869D8 File Offset: 0x00084BD8
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x0001496A File Offset: 0x00012B6A
		public unsafe bool prevStealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_prevStealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_prevStealth)) = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00086A00 File Offset: 0x00084C00
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x00014985 File Offset: 0x00012B85
		public unsafe bool shotGrabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shotGrabbed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shotGrabbed)) = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00086A28 File Offset: 0x00084C28
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x000149A0 File Offset: 0x00012BA0
		public unsafe bool cleared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cleared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_cleared)) = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00086A50 File Offset: 0x00084C50
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x000149BB File Offset: 0x00012BBB
		public unsafe Vector3 shellerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shellerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shellerPos)) = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00086A78 File Offset: 0x00084C78
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x000149D6 File Offset: 0x00012BD6
		public unsafe Quaternion shellerRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shellerRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shellerRot)) = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00086AA0 File Offset: 0x00084CA0
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x000149F1 File Offset: 0x00012BF1
		public unsafe Transform shellerDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shellerDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_shellerDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00086AD0 File Offset: 0x00084CD0
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00014A10 File Offset: 0x00012C10
		public unsafe int grabShootDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_grabShootDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_grabShootDelay)) = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00086AF8 File Offset: 0x00084CF8
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00014A2B File Offset: 0x00012C2B
		public unsafe Transform trans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_trans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00086B28 File Offset: 0x00084D28
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00014A4A File Offset: 0x00012C4A
		public unsafe int ignoreLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_ignoreLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_ignoreLayer)) = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00086B50 File Offset: 0x00084D50
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00014A65 File Offset: 0x00012C65
		public unsafe string playerString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_playerString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGun.NativeFieldInfoPtr_playerString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeFieldInfoPtr_shootLayers;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr_gunTrans;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_sr;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_cockTimer;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_cockTime;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeFieldInfoPtr_shootPrepTime;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr_cocking;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr_cockingInstance;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr_defGunAng;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr_aimGunAng;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_aimSpeed;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_spread;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_kick;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr_defGunPos;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeFieldInfoPtr_aimGunPos;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeFieldInfoPtr_aiming;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeFieldInfoPtr_muzzDist;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeFieldInfoPtr_flash;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeFieldInfoPtr_shootPrep;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeFieldInfoPtr_shootPrepTimer;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr_shotArr;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeFieldInfoPtr_cockCueDelay;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr_sheller;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_hasShot;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeFieldInfoPtr_muzzPos;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeFieldInfoPtr_redBeamMat;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr_flashlightsOn;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr_igArr;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr_layerList;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr_debugTxt;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr_prevStealth;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeFieldInfoPtr_shotGrabbed;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeFieldInfoPtr_cleared;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeFieldInfoPtr_shellerPos;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeFieldInfoPtr_shellerRot;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr_shellerDad;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr_grabShootDelay;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeFieldInfoPtr_trans;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeFieldInfoPtr_ignoreLayer;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeFieldInfoPtr_playerString;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_ResetSheller_Public_Virtual_New_Void_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_SetPrevStuff_Public_Void_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_Aim_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_ManageCocking_Public_Virtual_New_Void_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_New_Void_Vector3_Quaternion_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_New_Void_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_AimAt_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_RelaxGun_Public_Void_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_MoveGun_Public_Virtual_New_Void_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_ShootThatShit_Public_Virtual_New_Void_RaycastHit2D_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_DrawTrail_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_ShotEffects_Public_Virtual_New_Void_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_PutOnFlashLight_Public_Void_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_TakeFlashLightOff_Public_Void_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
