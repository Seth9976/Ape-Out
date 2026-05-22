using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000CA RID: 202
	public class FX : MonoBehaviour
	{
		// Token: 0x06001740 RID: 5952 RVA: 0x00075CE0 File Offset: 0x00073EE0
		// Note: this type is marked as 'beforefieldinit'.
		static FX()
		{
			Il2CppClassPointerStore<FX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FX>.NativeClassPtr);
			FX.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "me");
			FX.NativeFieldInfoPtr_floorTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "floorTitles");
			FX.NativeFieldInfoPtr_bloodBigSplash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodBigSplash");
			FX.NativeFieldInfoPtr_bloodSpray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodSpray");
			FX.NativeFieldInfoPtr_bloodStreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodStreak");
			FX.NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "glass");
			FX.NativeFieldInfoPtr_glassDirectional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "glassDirectional");
			FX.NativeFieldInfoPtr_wallBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "wallBits");
			FX.NativeFieldInfoPtr_wallDust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "wallDust");
			FX.NativeFieldInfoPtr_metalSparks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "metalSparks");
			FX.NativeFieldInfoPtr_armorBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "armorBits");
			FX.NativeFieldInfoPtr_crateBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "crateBits");
			FX.NativeFieldInfoPtr_scorch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "scorch");
			FX.NativeFieldInfoPtr_scorchFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "scorchFire");
			FX.NativeFieldInfoPtr_apeBloodSplash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "apeBloodSplash");
			FX.NativeFieldInfoPtr_apeBloodSpray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "apeBloodSpray");
			FX.NativeFieldInfoPtr_apeBloodStreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "apeBloodStreak");
			FX.NativeFieldInfoPtr_flash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flash");
			FX.NativeFieldInfoPtr_smallFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "smallFlash");
			FX.NativeFieldInfoPtr_shotgunFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "shotgunFlash");
			FX.NativeFieldInfoPtr_tranqFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "tranqFlash");
			FX.NativeFieldInfoPtr_maxParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxParts");
			FX.NativeFieldInfoPtr_partArrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "partArrs");
			FX.NativeFieldInfoPtr_curInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "curInd");
			FX.NativeFieldInfoPtr_flashInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flashInd");
			FX.NativeFieldInfoPtr_parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "parts");
			FX.NativeFieldInfoPtr_flashobjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flashobjs");
			FX.NativeFieldInfoPtr_scorches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "scorches");
			FX.NativeFieldInfoPtr_scorchInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "scorchInd");
			FX.NativeFieldInfoPtr_bTrail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bTrail");
			FX.NativeFieldInfoPtr_bulletTrails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bulletTrails");
			FX.NativeFieldInfoPtr_bulletInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bulletInd");
			FX.NativeFieldInfoPtr_maxTrails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxTrails");
			FX.NativeFieldInfoPtr_flashPartArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flashPartArr");
			FX.NativeFieldInfoPtr_explosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "explosion");
			FX.NativeFieldInfoPtr_explosions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "explosions");
			FX.NativeFieldInfoPtr_explosionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "explosionMax");
			FX.NativeFieldInfoPtr_explosionInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "explosionInd");
			FX.NativeFieldInfoPtr_dynamite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "dynamite");
			FX.NativeFieldInfoPtr_dynamites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "dynamites");
			FX.NativeFieldInfoPtr_dynamiteMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "dynamiteMax");
			FX.NativeFieldInfoPtr_dynamiteInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "dynamiteInd");
			FX.NativeFieldInfoPtr_rocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "rocket");
			FX.NativeFieldInfoPtr_rockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "rockets");
			FX.NativeFieldInfoPtr_rocketMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "rocketMax");
			FX.NativeFieldInfoPtr_rocketInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "rocketInd");
			FX.NativeFieldInfoPtr_tranq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "tranq");
			FX.NativeFieldInfoPtr_tranqs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "tranqs");
			FX.NativeFieldInfoPtr_tranqMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "tranqMax");
			FX.NativeFieldInfoPtr_tranqInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "tranqInd");
			FX.NativeFieldInfoPtr_corpseArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "corpseArm");
			FX.NativeFieldInfoPtr_corpseHips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "corpseHips");
			FX.NativeFieldInfoPtr_corpseArmArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "corpseArmArr");
			FX.NativeFieldInfoPtr_corpseHipsArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "corpseHipsArr");
			FX.NativeFieldInfoPtr_armInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "armInd");
			FX.NativeFieldInfoPtr_hipsInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "hipsInd");
			FX.NativeFieldInfoPtr_maxHips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxHips");
			FX.NativeFieldInfoPtr_flamePart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flamePart");
			FX.NativeFieldInfoPtr_flamePartArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flamePartArr");
			FX.NativeFieldInfoPtr_flamePartInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "flamePartInd");
			FX.NativeFieldInfoPtr_maxFlame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxFlame");
			FX.NativeFieldInfoPtr_fireBlastPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "fireBlastPart");
			FX.NativeFieldInfoPtr_fireBlastPartArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "fireBlastPartArr");
			FX.NativeFieldInfoPtr_fireBlastPartInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "fireBlastPartInd");
			FX.NativeFieldInfoPtr_maxFireBlastPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxFireBlastPart");
			FX.NativeFieldInfoPtr_fireBlast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "fireBlast");
			FX.NativeFieldInfoPtr_fireBlastArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "fireBlastArr");
			FX.NativeFieldInfoPtr_fireBlastInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "fireBlastInd");
			FX.NativeFieldInfoPtr_maxFireBlast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxFireBlast");
			FX.NativeFieldInfoPtr_guardFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "guardFire");
			FX.NativeFieldInfoPtr_guardFireArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "guardFireArr");
			FX.NativeFieldInfoPtr_guardFireManagerArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "guardFireManagerArr");
			FX.NativeFieldInfoPtr_guardFireInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "guardFireInd");
			FX.NativeFieldInfoPtr_maxGuardFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxGuardFire");
			FX.NativeFieldInfoPtr_footBloodTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "footBloodTrigger");
			FX.NativeFieldInfoPtr_footBloodTriggerArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "footBloodTriggerArr");
			FX.NativeFieldInfoPtr_footBloodInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "footBloodInd");
			FX.NativeFieldInfoPtr_maxFootBloodTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxFootBloodTriggers");
			FX.NativeFieldInfoPtr_stunTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "stunTrigger");
			FX.NativeFieldInfoPtr_stunTriggerArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "stunTriggerArr");
			FX.NativeFieldInfoPtr_stunTriggerInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "stunTriggerInd");
			FX.NativeFieldInfoPtr_maxStunTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxStunTriggers");
			FX.NativeFieldInfoPtr_glassStunTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "glassStunTrigger");
			FX.NativeFieldInfoPtr_glassStunTriggerArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "glassStunTriggerArr");
			FX.NativeFieldInfoPtr_glassStunTriggerInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "glassStunTriggerInd");
			FX.NativeFieldInfoPtr_maxGlassStunTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxGlassStunTriggers");
			FX.NativeFieldInfoPtr_bloodQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodQuad");
			FX.NativeFieldInfoPtr_bloodParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodParts");
			FX.NativeFieldInfoPtr_bloodPartArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodPartArr");
			FX.NativeFieldInfoPtr_bloodData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodData");
			FX.NativeFieldInfoPtr_maxBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "maxBlood");
			FX.NativeFieldInfoPtr_bloodInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodInd");
			FX.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "dirty");
			FX.NativeFieldInfoPtr_quadWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "quadWidth");
			FX.NativeFieldInfoPtr_quadHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "quadHeight");
			FX.NativeFieldInfoPtr_mapH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "mapH");
			FX.NativeFieldInfoPtr_mapW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "mapW");
			FX.NativeFieldInfoPtr_bloodCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodCam");
			FX.NativeFieldInfoPtr_bloodBakerCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodBakerCam");
			FX.NativeFieldInfoPtr_bloodCamControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodCamControl");
			FX.NativeFieldInfoPtr_smallBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "smallBlood");
			FX.NativeFieldInfoPtr_bigBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bigBlood");
			FX.NativeFieldInfoPtr_smallApeBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "smallApeBlood");
			FX.NativeFieldInfoPtr_bigApeBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bigApeBlood");
			FX.NativeFieldInfoPtr_made = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "made");
			FX.NativeFieldInfoPtr_quadRenders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "quadRenders");
			FX.NativeFieldInfoPtr_rendInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "rendInd");
			FX.NativeFieldInfoPtr_quadInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "quadInd");
			FX.NativeFieldInfoPtr_apeBloodMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "apeBloodMask");
			FX.NativeFieldInfoPtr_humanBloodMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "humanBloodMask");
			FX.NativeFieldInfoPtr_apeBloodLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "apeBloodLayer");
			FX.NativeFieldInfoPtr_humanBloodLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "humanBloodLayer");
			FX.NativeFieldInfoPtr_bloodRender2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodRender2D");
			FX.NativeFieldInfoPtr_bloodMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX>.NativeClassPtr, "bloodMat");
			FX.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665233);
			FX.NativeMethodInfoPtr_GetQuadRend_Private_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665234);
			FX.NativeMethodInfoPtr_MakeBlood_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665235);
			FX.NativeMethodInfoPtr_MakeBloodQuadMap_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665236);
			FX.NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665237);
			FX.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665238);
			FX.NativeMethodInfoPtr_GetFlame_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665239);
			FX.NativeMethodInfoPtr_GetFireBlastPart_Public_Rigidbody2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665240);
			FX.NativeMethodInfoPtr_GetFireBlast_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665241);
			FX.NativeMethodInfoPtr_GetGuardFire_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665242);
			FX.NativeMethodInfoPtr_UnparentFire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665243);
			FX.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665244);
			FX.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665245);
			FX.NativeMethodInfoPtr_GetFootBloodTrigger_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665246);
			FX.NativeMethodInfoPtr_GetStunTrigger_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665247);
			FX.NativeMethodInfoPtr_GetGlassTrigger_Public_BoxCollider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665248);
			FX.NativeMethodInfoPtr_GetArm_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665249);
			FX.NativeMethodInfoPtr_GetHips_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665250);
			FX.NativeMethodInfoPtr_ClearAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665251);
			FX.NativeMethodInfoPtr_GetTrail_Public_BulletTrail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665252);
			FX.NativeMethodInfoPtr_ShakeScreen_Public_Static_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665253);
			FX.NativeMethodInfoPtr_Explode_Public_Explosion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665254);
			FX.NativeMethodInfoPtr_Explode_Public_Explosion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665255);
			FX.NativeMethodInfoPtr_GetDynamite_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665256);
			FX.NativeMethodInfoPtr_GetRocket_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665257);
			FX.NativeMethodInfoPtr_GetTranq_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665258);
			FX.NativeMethodInfoPtr_Scorch_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665259);
			FX.NativeMethodInfoPtr_EmitStartSize_Public_Void_ParticleType_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665260);
			FX.NativeMethodInfoPtr_Emit_Public_Void_ParticleType_Vector3_Single_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665261);
			FX.NativeMethodInfoPtr_Emit_Public_Void_BloodType_Vector3_Single_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665262);
			FX.NativeMethodInfoPtr_SetDirty_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665263);
			FX.NativeMethodInfoPtr_Emit_Public_Void_ParticleType_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665264);
			FX.NativeMethodInfoPtr_Emit_Public_Void_BloodType_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665265);
			FX.NativeMethodInfoPtr_EmitGlass_Public_Void_ParticleType_Vector3_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665266);
			FX.NativeMethodInfoPtr_EmitGlass_Public_Void_ParticleType_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665267);
			FX.NativeMethodInfoPtr_EmitFlash_Public_Void_FlashType_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665268);
			FX.NativeMethodInfoPtr_Emit_Public_Static_Void_String_Vector2_Single_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665269);
			FX.NativeMethodInfoPtr_Emit_Public_Static_Void_String_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665270);
			FX.NativeMethodInfoPtr_ClearParts_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665271);
			FX.NativeMethodInfoPtr_Rumble_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665272);
			FX.NativeMethodInfoPtr_ChangeSortingLayerAll_Public_Static_Void_GameObject_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665273);
			FX.NativeMethodInfoPtr_ChangeSortingLayer_Public_Static_Void_GameObject_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665274);
			FX.NativeMethodInfoPtr_ShowFloorTitle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665275);
			FX.NativeMethodInfoPtr_ShowFloorTitleCo_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665276);
			FX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX>.NativeClassPtr, 100665277);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0007697C File Offset: 0x00074B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56665, XrefRangeEnd = 56688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000769B0 File Offset: 0x00074BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56688, XrefRangeEnd = 56702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshRenderer GetQuadRend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetQuadRend_Private_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr3) : null;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000769F0 File Offset: 0x00074BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56702, XrefRangeEnd = 56706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeBlood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_MakeBlood_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00076A24 File Offset: 0x00074C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56706, XrefRangeEnd = 56709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MakeBloodQuadMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_MakeBloodQuadMap_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00076A64 File Offset: 0x00074C64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00076A98 File Offset: 0x00074C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56709, XrefRangeEnd = 56764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00076ACC File Offset: 0x00074CCC
		[CallerCount(0)]
		public unsafe Transform GetFlame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetFlame_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00076B0C File Offset: 0x00074D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56778, RefRangeEnd = 56781, XrefRangeStart = 56764, XrefRangeEnd = 56778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rigidbody2D GetFireBlastPart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetFireBlastPart_Public_Rigidbody2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr3) : null;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00076B4C File Offset: 0x00074D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56785, RefRangeEnd = 56787, XrefRangeStart = 56781, XrefRangeEnd = 56785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetFireBlast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetFireBlast_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00076B8C File Offset: 0x00074D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56796, RefRangeEnd = 56798, XrefRangeStart = 56787, XrefRangeEnd = 56796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetGuardFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetGuardFire_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00076BCC File Offset: 0x00074DCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56799, RefRangeEnd = 56801, XrefRangeStart = 56798, XrefRangeEnd = 56799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnparentFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_UnparentFire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00076C00 File Offset: 0x00074E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56801, XrefRangeEnd = 56803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00076C34 File Offset: 0x00074E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56803, XrefRangeEnd = 57118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00076C68 File Offset: 0x00074E68
		[CallerCount(0)]
		public unsafe GameObject GetFootBloodTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetFootBloodTrigger_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00076CA8 File Offset: 0x00074EA8
		[CallerCount(0)]
		public unsafe GameObject GetStunTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetStunTrigger_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00076CE8 File Offset: 0x00074EE8
		[CallerCount(0)]
		public unsafe BoxCollider2D GetGlassTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetGlassTrigger_Public_BoxCollider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr3) : null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00076D28 File Offset: 0x00074F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57125, RefRangeEnd = 57127, XrefRangeStart = 57118, XrefRangeEnd = 57125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetArm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetArm_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00076D68 File Offset: 0x00074F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57127, XrefRangeEnd = 57144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetHips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetHips_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00076DA8 File Offset: 0x00074FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57193, RefRangeEnd = 57195, XrefRangeStart = 57144, XrefRangeEnd = 57193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ClearAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00076DDC File Offset: 0x00074FDC
		[CallerCount(0)]
		public unsafe BulletTrail GetTrail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetTrail_Public_BulletTrail_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BulletTrail>(intPtr3) : null;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00076E1C File Offset: 0x0007501C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 57202, RefRangeEnd = 57216, XrefRangeStart = 57195, XrefRangeEnd = 57202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShakeScreen(Vector2 amount, float dur)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ShakeScreen_Public_Static_Void_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00076E5C File Offset: 0x0007505C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 57237, RefRangeEnd = 57243, XrefRangeStart = 57216, XrefRangeEnd = 57237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion Explode(Vector3 pos, float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Explode_Public_Explosion_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr3) : null;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00076EB8 File Offset: 0x000750B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57243, XrefRangeEnd = 57244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion Explode(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Explode_Public_Explosion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr3) : null;
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00076F04 File Offset: 0x00075104
		[CallerCount(0)]
		public unsafe Transform GetDynamite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetDynamite_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00076F44 File Offset: 0x00075144
		[CallerCount(0)]
		public unsafe Transform GetRocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetRocket_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00076F84 File Offset: 0x00075184
		[CallerCount(0)]
		public unsafe Transform GetTranq()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_GetTranq_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00076FC4 File Offset: 0x000751C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57251, RefRangeEnd = 57252, XrefRangeStart = 57244, XrefRangeEnd = 57251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Scorch(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Scorch_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00077004 File Offset: 0x00075204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57252, XrefRangeEnd = 57269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitStartSize(FX.ParticleType pType, Vector3 pos, float ang, int partNum, float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_EmitStartSize_Public_Void_ParticleType_Vector3_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0007707C File Offset: 0x0007527C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 57281, RefRangeEnd = 57292, XrefRangeStart = 57269, XrefRangeEnd = 57281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(FX.ParticleType pType, Vector3 pos, float ang, int partNum, Vector3 scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Emit_Public_Void_ParticleType_Vector3_Single_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000770F4 File Offset: 0x000752F4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 57314, RefRangeEnd = 57329, XrefRangeStart = 57292, XrefRangeEnd = 57314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(FX.BloodType pType, Vector3 pos, float ang, int partNum, Vector3 scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Emit_Public_Void_BloodType_Vector3_Single_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0007716C File Offset: 0x0007536C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57329, RefRangeEnd = 57333, XrefRangeStart = 57329, XrefRangeEnd = 57329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_SetDirty_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000771AC File Offset: 0x000753AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57336, RefRangeEnd = 57340, XrefRangeStart = 57333, XrefRangeEnd = 57336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(FX.ParticleType pType, Vector3 pos, float ang, int partNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Emit_Public_Void_ParticleType_Vector3_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00077214 File Offset: 0x00075414
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57343, RefRangeEnd = 57346, XrefRangeStart = 57340, XrefRangeEnd = 57343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(FX.BloodType pType, Vector3 pos, float ang, int partNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Emit_Public_Void_BloodType_Vector3_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0007727C File Offset: 0x0007547C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57377, RefRangeEnd = 57379, XrefRangeStart = 57346, XrefRangeEnd = 57377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitGlass(FX.ParticleType pType, Vector3 pos, float ang, int partNum, float scale, bool stunStuff)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stunStuff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_EmitGlass_Public_Void_ParticleType_Vector3_Single_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00077300 File Offset: 0x00075500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57379, XrefRangeEnd = 57380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitGlass(FX.ParticleType pType, Vector3 pos, float ang, int partNum, float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_EmitGlass_Public_Void_ParticleType_Vector3_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00077378 File Offset: 0x00075578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57394, RefRangeEnd = 57395, XrefRangeStart = 57380, XrefRangeEnd = 57394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitFlash(FX.FlashType pType, Vector3 pos, float ang)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_EmitFlash_Public_Void_FlashType_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000773D4 File Offset: 0x000755D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57395, XrefRangeEnd = 57425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Emit(string name, Vector2 pos, float ang, int partNum, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Emit_Public_Static_Void_String_Vector2_Single_Int32_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00077444 File Offset: 0x00075644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57425, XrefRangeEnd = 57451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Emit(string name, Vector2 pos, float ang, int partNum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Emit_Public_Static_Void_String_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000774A4 File Offset: 0x000756A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearParts()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ClearParts_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000774CC File Offset: 0x000756CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57451, XrefRangeEnd = 57453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Rumble(float l, float r, float dur)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref l;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_Rumble_Public_Static_Void_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0007751C File Offset: 0x0007571C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57466, RefRangeEnd = 57469, XrefRangeStart = 57453, XrefRangeEnd = 57466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeSortingLayerAll(GameObject obj, int layer, int subLayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ChangeSortingLayerAll_Public_Static_Void_GameObject_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00077570 File Offset: 0x00075770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57492, RefRangeEnd = 57493, XrefRangeStart = 57469, XrefRangeEnd = 57492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeSortingLayer(GameObject obj, int layer, int subLayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ChangeSortingLayer_Public_Static_Void_GameObject_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000775C4 File Offset: 0x000757C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57497, RefRangeEnd = 57501, XrefRangeStart = 57493, XrefRangeEnd = 57497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowFloorTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ShowFloorTitle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000775F8 File Offset: 0x000757F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57501, XrefRangeEnd = 57504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowFloorTitleCo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr_ShowFloorTitleCo_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00077638 File Offset: 0x00075838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57504, XrefRangeEnd = 57513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00010ABD File Offset: 0x0000ECBD
		public FX(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x00077674 File Offset: 0x00075874
		// (set) Token: 0x06001770 RID: 6000 RVA: 0x00010AC6 File Offset: 0x0000ECC6
		public unsafe static FX me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FX.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FX>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FX.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0007769C File Offset: 0x0007589C
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		public unsafe Il2CppReferenceArray<TextMesh> floorTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_floorTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_floorTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x000776CC File Offset: 0x000758CC
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x00010AF7 File Offset: 0x0000ECF7
		public unsafe ParticleSystem bloodBigSplash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodBigSplash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodBigSplash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x000776FC File Offset: 0x000758FC
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x00010B16 File Offset: 0x0000ED16
		public unsafe ParticleSystem bloodSpray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodSpray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodSpray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0007772C File Offset: 0x0007592C
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00010B35 File Offset: 0x0000ED35
		public unsafe ParticleSystem bloodStreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodStreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodStreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x0007775C File Offset: 0x0007595C
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x00010B54 File Offset: 0x0000ED54
		public unsafe ParticleSystem glass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0007778C File Offset: 0x0007598C
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x00010B73 File Offset: 0x0000ED73
		public unsafe ParticleSystem glassDirectional
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassDirectional);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassDirectional), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000777BC File Offset: 0x000759BC
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x00010B92 File Offset: 0x0000ED92
		public unsafe ParticleSystem wallBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_wallBits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_wallBits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x000777EC File Offset: 0x000759EC
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x00010BB1 File Offset: 0x0000EDB1
		public unsafe ParticleSystem wallDust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_wallDust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_wallDust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0007781C File Offset: 0x00075A1C
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		public unsafe ParticleSystem metalSparks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_metalSparks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_metalSparks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0007784C File Offset: 0x00075A4C
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x00010BEF File Offset: 0x0000EDEF
		public unsafe ParticleSystem armorBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_armorBits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_armorBits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x0007787C File Offset: 0x00075A7C
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x00010C0E File Offset: 0x0000EE0E
		public unsafe ParticleSystem crateBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_crateBits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_crateBits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000778AC File Offset: 0x00075AAC
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x00010C2D File Offset: 0x0000EE2D
		public unsafe ParticleSystem scorch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000778DC File Offset: 0x00075ADC
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public unsafe ParticleSystem scorchFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorchFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorchFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x0007790C File Offset: 0x00075B0C
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x00010C6B File Offset: 0x0000EE6B
		public unsafe ParticleSystem apeBloodSplash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodSplash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodSplash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0007793C File Offset: 0x00075B3C
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x00010C8A File Offset: 0x0000EE8A
		public unsafe ParticleSystem apeBloodSpray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodSpray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodSpray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0007796C File Offset: 0x00075B6C
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x00010CA9 File Offset: 0x0000EEA9
		public unsafe ParticleSystem apeBloodStreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodStreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodStreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0007799C File Offset: 0x00075B9C
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		public unsafe GameObject flash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000779CC File Offset: 0x00075BCC
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x00010CE7 File Offset: 0x0000EEE7
		public unsafe GameObject smallFlash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_smallFlash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_smallFlash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x000779FC File Offset: 0x00075BFC
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x00010D06 File Offset: 0x0000EF06
		public unsafe GameObject shotgunFlash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_shotgunFlash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_shotgunFlash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00077A2C File Offset: 0x00075C2C
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x00010D25 File Offset: 0x0000EF25
		public unsafe GameObject tranqFlash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqFlash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqFlash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x00077A5C File Offset: 0x00075C5C
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x00010D44 File Offset: 0x0000EF44
		public unsafe int maxParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxParts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxParts)) = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00077A84 File Offset: 0x00075C84
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x00010D5F File Offset: 0x0000EF5F
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<MyPart>> partArrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_partArrs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<MyPart>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_partArrs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00077AB4 File Offset: 0x00075CB4
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x00010D7E File Offset: 0x0000EF7E
		public unsafe Il2CppStructArray<int> curInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_curInd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_curInd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00077AE4 File Offset: 0x00075CE4
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x00010D9D File Offset: 0x0000EF9D
		public unsafe Il2CppStructArray<int> flashInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flashInd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flashInd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00077B14 File Offset: 0x00075D14
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x00010DBC File Offset: 0x0000EFBC
		public unsafe Il2CppReferenceArray<ParticleSystem> parts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_parts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_parts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00077B44 File Offset: 0x00075D44
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x00010DDB File Offset: 0x0000EFDB
		public unsafe Il2CppReferenceArray<GameObject> flashobjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flashobjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flashobjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00077B74 File Offset: 0x00075D74
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x00010DFA File Offset: 0x0000EFFA
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<ParticleSystem>> scorches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<ParticleSystem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00077BA4 File Offset: 0x00075DA4
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x00010E19 File Offset: 0x0000F019
		public unsafe int scorchInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorchInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_scorchInd)) = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00077BCC File Offset: 0x00075DCC
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x00010E34 File Offset: 0x0000F034
		public unsafe BulletTrail bTrail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bTrail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BulletTrail>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bTrail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x00077BFC File Offset: 0x00075DFC
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x00010E53 File Offset: 0x0000F053
		public unsafe Il2CppReferenceArray<BulletTrail> bulletTrails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bulletTrails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BulletTrail>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bulletTrails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x00077C2C File Offset: 0x00075E2C
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x00010E72 File Offset: 0x0000F072
		public unsafe int bulletInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bulletInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bulletInd)) = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x00077C54 File Offset: 0x00075E54
		// (set) Token: 0x060017B0 RID: 6064 RVA: 0x00010E8D File Offset: 0x0000F08D
		public unsafe int maxTrails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxTrails);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxTrails)) = value;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00077C7C File Offset: 0x00075E7C
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<MyPart>> flashPartArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flashPartArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<MyPart>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flashPartArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00077CAC File Offset: 0x00075EAC
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00010EC7 File Offset: 0x0000F0C7
		public unsafe Explosion explosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00077CDC File Offset: 0x00075EDC
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00010EE6 File Offset: 0x0000F0E6
		public unsafe Il2CppReferenceArray<Explosion> explosions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Explosion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00077D0C File Offset: 0x00075F0C
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00010F05 File Offset: 0x0000F105
		public unsafe int explosionMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosionMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosionMax)) = value;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00077D34 File Offset: 0x00075F34
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x00010F20 File Offset: 0x0000F120
		public unsafe int explosionInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosionInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_explosionInd)) = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00077D5C File Offset: 0x00075F5C
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00010F3B File Offset: 0x0000F13B
		public unsafe Transform dynamite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00077D8C File Offset: 0x00075F8C
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x00010F5A File Offset: 0x0000F15A
		public unsafe Il2CppReferenceArray<Transform> dynamites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00077DBC File Offset: 0x00075FBC
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x00010F79 File Offset: 0x0000F179
		public unsafe int dynamiteMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamiteMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamiteMax)) = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00077DE4 File Offset: 0x00075FE4
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x00010F94 File Offset: 0x0000F194
		public unsafe int dynamiteInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamiteInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dynamiteInd)) = value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00077E0C File Offset: 0x0007600C
		// (set) Token: 0x060017C4 RID: 6084 RVA: 0x00010FAF File Offset: 0x0000F1AF
		public unsafe Transform rocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00077E3C File Offset: 0x0007603C
		// (set) Token: 0x060017C6 RID: 6086 RVA: 0x00010FCE File Offset: 0x0000F1CE
		public unsafe Il2CppReferenceArray<Transform> rockets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rockets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rockets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00077E6C File Offset: 0x0007606C
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x00010FED File Offset: 0x0000F1ED
		public unsafe int rocketMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rocketMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rocketMax)) = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00077E94 File Offset: 0x00076094
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x00011008 File Offset: 0x0000F208
		public unsafe int rocketInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rocketInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rocketInd)) = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x00077EBC File Offset: 0x000760BC
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x00011023 File Offset: 0x0000F223
		public unsafe Transform tranq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00077EEC File Offset: 0x000760EC
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x00011042 File Offset: 0x0000F242
		public unsafe Il2CppReferenceArray<Transform> tranqs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x00077F1C File Offset: 0x0007611C
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00011061 File Offset: 0x0000F261
		public unsafe int tranqMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqMax)) = value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00077F44 File Offset: 0x00076144
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0001107C File Offset: 0x0000F27C
		public unsafe int tranqInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_tranqInd)) = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00077F6C File Offset: 0x0007616C
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00011097 File Offset: 0x0000F297
		public unsafe CorpseArm corpseArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CorpseArm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00077F9C File Offset: 0x0007619C
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x000110B6 File Offset: 0x0000F2B6
		public unsafe CorpseHips corpseHips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseHips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CorpseHips>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseHips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00077FCC File Offset: 0x000761CC
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x000110D5 File Offset: 0x0000F2D5
		public unsafe Il2CppReferenceArray<CorpseArm> corpseArmArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseArmArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CorpseArm>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseArmArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00077FFC File Offset: 0x000761FC
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x000110F4 File Offset: 0x0000F2F4
		public unsafe Il2CppReferenceArray<CorpseHips> corpseHipsArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseHipsArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CorpseHips>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_corpseHipsArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x0007802C File Offset: 0x0007622C
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x00011113 File Offset: 0x0000F313
		public unsafe int armInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_armInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_armInd)) = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00078054 File Offset: 0x00076254
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x0001112E File Offset: 0x0000F32E
		public unsafe int hipsInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_hipsInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_hipsInd)) = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0007807C File Offset: 0x0007627C
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00011149 File Offset: 0x0000F349
		public unsafe int maxHips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxHips);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxHips)) = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x000780A4 File Offset: 0x000762A4
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00011164 File Offset: 0x0000F364
		public unsafe Transform flamePart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flamePart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flamePart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x000780D4 File Offset: 0x000762D4
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x00011183 File Offset: 0x0000F383
		public unsafe Il2CppReferenceArray<Transform> flamePartArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flamePartArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flamePartArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00078104 File Offset: 0x00076304
		// (set) Token: 0x060017E6 RID: 6118 RVA: 0x000111A2 File Offset: 0x0000F3A2
		public unsafe int flamePartInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flamePartInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_flamePartInd)) = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0007812C File Offset: 0x0007632C
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x000111BD File Offset: 0x0000F3BD
		public unsafe int maxFlame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFlame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFlame)) = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00078154 File Offset: 0x00076354
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x000111D8 File Offset: 0x0000F3D8
		public unsafe Rigidbody2D fireBlastPart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastPart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastPart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00078184 File Offset: 0x00076384
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x000111F7 File Offset: 0x0000F3F7
		public unsafe Il2CppReferenceArray<Rigidbody2D> fireBlastPartArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastPartArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastPartArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x000781B4 File Offset: 0x000763B4
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x00011216 File Offset: 0x0000F416
		public unsafe int fireBlastPartInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastPartInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastPartInd)) = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x000781DC File Offset: 0x000763DC
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00011231 File Offset: 0x0000F431
		public unsafe int maxFireBlastPart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFireBlastPart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFireBlastPart)) = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00078204 File Offset: 0x00076404
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x0001124C File Offset: 0x0000F44C
		public unsafe Transform fireBlast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00078234 File Offset: 0x00076434
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x0001126B File Offset: 0x0000F46B
		public unsafe Il2CppReferenceArray<Transform> fireBlastArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00078264 File Offset: 0x00076464
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0001128A File Offset: 0x0000F48A
		public unsafe int fireBlastInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_fireBlastInd)) = value;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0007828C File Offset: 0x0007648C
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x000112A5 File Offset: 0x0000F4A5
		public unsafe int maxFireBlast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFireBlast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFireBlast)) = value;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000782B4 File Offset: 0x000764B4
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x000112C0 File Offset: 0x0000F4C0
		public unsafe Transform guardFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x000782E4 File Offset: 0x000764E4
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x000112DF File Offset: 0x0000F4DF
		public unsafe Il2CppReferenceArray<Transform> guardFireArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFireArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFireArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00078314 File Offset: 0x00076514
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x000112FE File Offset: 0x0000F4FE
		public unsafe Il2CppReferenceArray<FireManager> guardFireManagerArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFireManagerArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FireManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFireManagerArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00078344 File Offset: 0x00076544
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x0001131D File Offset: 0x0000F51D
		public unsafe int guardFireInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFireInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_guardFireInd)) = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0007836C File Offset: 0x0007656C
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00011338 File Offset: 0x0000F538
		public unsafe int maxGuardFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxGuardFire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxGuardFire)) = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00078394 File Offset: 0x00076594
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00011353 File Offset: 0x0000F553
		public unsafe GameObject footBloodTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_footBloodTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_footBloodTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x000783C4 File Offset: 0x000765C4
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00011372 File Offset: 0x0000F572
		public unsafe Il2CppReferenceArray<GameObject> footBloodTriggerArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_footBloodTriggerArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_footBloodTriggerArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x000783F4 File Offset: 0x000765F4
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00011391 File Offset: 0x0000F591
		public unsafe int footBloodInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_footBloodInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_footBloodInd)) = value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0007841C File Offset: 0x0007661C
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x000113AC File Offset: 0x0000F5AC
		public unsafe int maxFootBloodTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFootBloodTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxFootBloodTriggers)) = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00078444 File Offset: 0x00076644
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x000113C7 File Offset: 0x0000F5C7
		public unsafe GameObject stunTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_stunTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_stunTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00078474 File Offset: 0x00076674
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x000113E6 File Offset: 0x0000F5E6
		public unsafe Il2CppReferenceArray<GameObject> stunTriggerArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_stunTriggerArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_stunTriggerArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000784A4 File Offset: 0x000766A4
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00011405 File Offset: 0x0000F605
		public unsafe int stunTriggerInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_stunTriggerInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_stunTriggerInd)) = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000784CC File Offset: 0x000766CC
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x00011420 File Offset: 0x0000F620
		public unsafe int maxStunTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxStunTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxStunTriggers)) = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000784F4 File Offset: 0x000766F4
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0001143B File Offset: 0x0000F63B
		public unsafe GameObject glassStunTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassStunTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassStunTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00078524 File Offset: 0x00076724
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0001145A File Offset: 0x0000F65A
		public unsafe Il2CppReferenceArray<BoxCollider2D> glassStunTriggerArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassStunTriggerArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassStunTriggerArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00078554 File Offset: 0x00076754
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x00011479 File Offset: 0x0000F679
		public unsafe int glassStunTriggerInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassStunTriggerInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_glassStunTriggerInd)) = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x0007857C File Offset: 0x0007677C
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x00011494 File Offset: 0x0000F694
		public unsafe int maxGlassStunTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxGlassStunTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxGlassStunTriggers)) = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x000785A4 File Offset: 0x000767A4
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x000114AF File Offset: 0x0000F6AF
		public unsafe GameObject bloodQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000785D4 File Offset: 0x000767D4
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x000114CE File Offset: 0x0000F6CE
		public unsafe Il2CppReferenceArray<ParticleSystem> bloodParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00078604 File Offset: 0x00076804
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x000114ED File Offset: 0x0000F6ED
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<MyPart>> bloodPartArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodPartArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<MyPart>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodPartArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00078634 File Offset: 0x00076834
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0001150C File Offset: 0x0000F70C
		public NativeArray<BloodData> bloodData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodData);
				return new NativeArray<BloodData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BloodData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BloodData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00078664 File Offset: 0x00076864
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0001153A File Offset: 0x0000F73A
		public unsafe int maxBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxBlood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_maxBlood)) = value;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x0007868C File Offset: 0x0007688C
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x00011555 File Offset: 0x0000F755
		public unsafe Il2CppStructArray<int> bloodInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodInd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodInd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x000786BC File Offset: 0x000768BC
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x00011574 File Offset: 0x0000F774
		public unsafe Il2CppStructArray<bool> dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_dirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x000786EC File Offset: 0x000768EC
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00011593 File Offset: 0x0000F793
		public unsafe int quadWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadWidth)) = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00078714 File Offset: 0x00076914
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x000115AE File Offset: 0x0000F7AE
		public unsafe int quadHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadHeight)) = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0007873C File Offset: 0x0007693C
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x000115C9 File Offset: 0x0000F7C9
		public unsafe int mapH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_mapH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_mapH)) = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00078764 File Offset: 0x00076964
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x000115E4 File Offset: 0x0000F7E4
		public unsafe int mapW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_mapW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_mapW)) = value;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0007878C File Offset: 0x0007698C
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x000115FF File Offset: 0x0000F7FF
		public unsafe Camera bloodCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x000787BC File Offset: 0x000769BC
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0001161E File Offset: 0x0000F81E
		public unsafe Camera bloodBakerCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodBakerCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodBakerCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x000787EC File Offset: 0x000769EC
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0001163D File Offset: 0x0000F83D
		public unsafe BloodCam bloodCamControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodCamControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BloodCam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodCamControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0007881C File Offset: 0x00076A1C
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0001165C File Offset: 0x0000F85C
		public unsafe RenderTexture smallBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_smallBlood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_smallBlood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0007884C File Offset: 0x00076A4C
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0001167B File Offset: 0x0000F87B
		public unsafe RenderTexture bigBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bigBlood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bigBlood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0007887C File Offset: 0x00076A7C
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0001169A File Offset: 0x0000F89A
		public unsafe RenderTexture smallApeBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_smallApeBlood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_smallApeBlood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x000788AC File Offset: 0x00076AAC
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x000116B9 File Offset: 0x0000F8B9
		public unsafe RenderTexture bigApeBlood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bigApeBlood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bigApeBlood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x000788DC File Offset: 0x00076ADC
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x000116D8 File Offset: 0x0000F8D8
		public unsafe bool made
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_made);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_made)) = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00078904 File Offset: 0x00076B04
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x000116F3 File Offset: 0x0000F8F3
		public unsafe List<MeshRenderer> quadRenders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadRenders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadRenders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00078934 File Offset: 0x00076B34
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x00011712 File Offset: 0x0000F912
		public unsafe int rendInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rendInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_rendInd)) = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0007895C File Offset: 0x00076B5C
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x0001172D File Offset: 0x0000F92D
		public unsafe int quadInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_quadInd)) = value;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00078984 File Offset: 0x00076B84
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00011748 File Offset: 0x0000F948
		public unsafe int apeBloodMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodMask)) = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x000789AC File Offset: 0x00076BAC
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00011763 File Offset: 0x0000F963
		public unsafe int humanBloodMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_humanBloodMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_humanBloodMask)) = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000789D4 File Offset: 0x00076BD4
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0001177E File Offset: 0x0000F97E
		public unsafe int apeBloodLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_apeBloodLayer)) = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000789FC File Offset: 0x00076BFC
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x00011799 File Offset: 0x0000F999
		public unsafe int humanBloodLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_humanBloodLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_humanBloodLayer)) = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00078A24 File Offset: 0x00076C24
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x000117B4 File Offset: 0x0000F9B4
		public unsafe RenderTexture bloodRender2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodRender2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodRender2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00078A54 File Offset: 0x00076C54
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x000117D3 File Offset: 0x0000F9D3
		public unsafe Material bloodMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX.NativeFieldInfoPtr_bloodMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeFieldInfoPtr_floorTitles;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeFieldInfoPtr_bloodBigSplash;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeFieldInfoPtr_bloodSpray;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeFieldInfoPtr_bloodStreak;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeFieldInfoPtr_glass;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeFieldInfoPtr_glassDirectional;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeFieldInfoPtr_wallBits;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeFieldInfoPtr_wallDust;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr_metalSparks;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeFieldInfoPtr_armorBits;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr_crateBits;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeFieldInfoPtr_scorch;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeFieldInfoPtr_scorchFire;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeFieldInfoPtr_apeBloodSplash;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_apeBloodSpray;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeFieldInfoPtr_apeBloodStreak;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeFieldInfoPtr_flash;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeFieldInfoPtr_smallFlash;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeFieldInfoPtr_shotgunFlash;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr_tranqFlash;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr_maxParts;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_partArrs;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_curInd;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeFieldInfoPtr_flashInd;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeFieldInfoPtr_parts;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeFieldInfoPtr_flashobjs;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeFieldInfoPtr_scorches;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeFieldInfoPtr_scorchInd;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeFieldInfoPtr_bTrail;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeFieldInfoPtr_bulletTrails;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeFieldInfoPtr_bulletInd;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeFieldInfoPtr_maxTrails;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeFieldInfoPtr_flashPartArr;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeFieldInfoPtr_explosion;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeFieldInfoPtr_explosions;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr_explosionMax;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr_explosionInd;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr_dynamite;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr_dynamites;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeFieldInfoPtr_dynamiteMax;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeFieldInfoPtr_dynamiteInd;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeFieldInfoPtr_rocket;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeFieldInfoPtr_rockets;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeFieldInfoPtr_rocketMax;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeFieldInfoPtr_rocketInd;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeFieldInfoPtr_tranq;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeFieldInfoPtr_tranqs;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeFieldInfoPtr_tranqMax;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeFieldInfoPtr_tranqInd;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeFieldInfoPtr_corpseArm;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeFieldInfoPtr_corpseHips;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr_corpseArmArr;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr_corpseHipsArr;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr_armInd;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeFieldInfoPtr_hipsInd;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeFieldInfoPtr_maxHips;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeFieldInfoPtr_flamePart;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeFieldInfoPtr_flamePartArr;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr_flamePartInd;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr_maxFlame;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_fireBlastPart;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr_fireBlastPartArr;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr_fireBlastPartInd;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr_maxFireBlastPart;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr_fireBlast;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr_fireBlastArr;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr_fireBlastInd;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr_maxFireBlast;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_guardFire;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeFieldInfoPtr_guardFireArr;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeFieldInfoPtr_guardFireManagerArr;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeFieldInfoPtr_guardFireInd;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeFieldInfoPtr_maxGuardFire;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr_footBloodTrigger;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeFieldInfoPtr_footBloodTriggerArr;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_footBloodInd;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_maxFootBloodTriggers;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeFieldInfoPtr_stunTrigger;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeFieldInfoPtr_stunTriggerArr;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeFieldInfoPtr_stunTriggerInd;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeFieldInfoPtr_maxStunTriggers;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeFieldInfoPtr_glassStunTrigger;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeFieldInfoPtr_glassStunTriggerArr;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeFieldInfoPtr_glassStunTriggerInd;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeFieldInfoPtr_maxGlassStunTriggers;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeFieldInfoPtr_bloodQuad;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeFieldInfoPtr_bloodParts;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeFieldInfoPtr_bloodPartArr;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeFieldInfoPtr_bloodData;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr_maxBlood;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeFieldInfoPtr_bloodInd;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_quadWidth;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeFieldInfoPtr_quadHeight;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeFieldInfoPtr_mapH;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_mapW;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_bloodCam;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeFieldInfoPtr_bloodBakerCam;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr_bloodCamControl;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_smallBlood;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_bigBlood;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeFieldInfoPtr_smallApeBlood;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeFieldInfoPtr_bigApeBlood;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_made;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_quadRenders;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeFieldInfoPtr_rendInd;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_quadInd;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_apeBloodMask;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_humanBloodMask;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_apeBloodLayer;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_humanBloodLayer;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeFieldInfoPtr_bloodRender2D;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeFieldInfoPtr_bloodMat;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_GetQuadRend_Private_MeshRenderer_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_MakeBlood_Public_Void_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_MakeBloodQuadMap_Public_IEnumerator_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_GetFlame_Public_Transform_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_GetFireBlastPart_Public_Rigidbody2D_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_GetFireBlast_Public_Transform_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_GetGuardFire_Public_Transform_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_UnparentFire_Public_Void_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_GetFootBloodTrigger_Public_GameObject_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_GetStunTrigger_Public_GameObject_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_GetGlassTrigger_Public_BoxCollider2D_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_GetArm_Public_GameObject_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_GetHips_Public_GameObject_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_ClearAll_Public_Void_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_GetTrail_Public_BulletTrail_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_ShakeScreen_Public_Static_Void_Vector2_Single_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_Explode_Public_Explosion_Vector3_Single_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_Explode_Public_Explosion_Vector3_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamite_Public_Transform_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_GetRocket_Public_Transform_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_GetTranq_Public_Transform_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_Scorch_Public_Void_Vector3_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_EmitStartSize_Public_Void_ParticleType_Vector3_Single_Int32_Single_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_ParticleType_Vector3_Single_Int32_Vector3_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_BloodType_Vector3_Single_Int32_Vector3_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_Vector2_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_ParticleType_Vector3_Single_Int32_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_BloodType_Vector3_Single_Int32_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_EmitGlass_Public_Void_ParticleType_Vector3_Single_Int32_Single_Boolean_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_EmitGlass_Public_Void_ParticleType_Vector3_Single_Int32_Single_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_EmitFlash_Public_Void_FlashType_Vector3_Single_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Static_Void_String_Vector2_Single_Int32_Vector3_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Static_Void_String_Vector2_Single_Int32_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_ClearParts_Public_Static_Void_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_Rumble_Public_Static_Void_Single_Single_Single_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSortingLayerAll_Public_Static_Void_GameObject_Int32_Int32_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSortingLayer_Public_Static_Void_GameObject_Int32_Int32_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_ShowFloorTitle_Public_Void_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_ShowFloorTitleCo_Public_IEnumerator_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F5 RID: 757
		[OriginalName("Assembly-CSharp.dll", "", "ParticleType")]
		public enum ParticleType
		{
			// Token: 0x040033A2 RID: 13218
			glass,
			// Token: 0x040033A3 RID: 13219
			glassDirectional,
			// Token: 0x040033A4 RID: 13220
			wallBits,
			// Token: 0x040033A5 RID: 13221
			wallDust,
			// Token: 0x040033A6 RID: 13222
			metalSparks,
			// Token: 0x040033A7 RID: 13223
			armorBits,
			// Token: 0x040033A8 RID: 13224
			crateBits,
			// Token: 0x040033A9 RID: 13225
			scorchFire
		}

		// Token: 0x020002F6 RID: 758
		[OriginalName("Assembly-CSharp.dll", "", "BloodType")]
		public enum BloodType
		{
			// Token: 0x040033AB RID: 13227
			bloodBigSplash,
			// Token: 0x040033AC RID: 13228
			bloodSpray,
			// Token: 0x040033AD RID: 13229
			bloodStreak,
			// Token: 0x040033AE RID: 13230
			apeBloodSplash,
			// Token: 0x040033AF RID: 13231
			apeBloodSpray,
			// Token: 0x040033B0 RID: 13232
			apeBloodStreak
		}

		// Token: 0x020002F7 RID: 759
		[OriginalName("Assembly-CSharp.dll", "", "FlashType")]
		public enum FlashType
		{
			// Token: 0x040033B2 RID: 13234
			normal,
			// Token: 0x040033B3 RID: 13235
			small,
			// Token: 0x040033B4 RID: 13236
			shotgun,
			// Token: 0x040033B5 RID: 13237
			tranq
		}

		// Token: 0x020002F8 RID: 760
		[ObfuscatedName("FX+<MakeBloodQuadMap>d__120")]
		public sealed class _MakeBloodQuadMap_d__120 : global::Il2CppSystem.Object
		{
			// Token: 0x06004EE4 RID: 20196 RVA: 0x00120E80 File Offset: 0x0011F080
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeBloodQuadMap_d__120()
			{
				Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FX>.NativeClassPtr, "<MakeBloodQuadMap>d__120");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr);
				FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, "<>1__state");
				FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, "<>2__current");
				FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, "<>4__this");
				FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, 100665278);
				FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, 100665279);
				FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, 100665280);
				FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, 100665281);
				FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, 100665282);
				FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr, 100665283);
			}

			// Token: 0x06004EE5 RID: 20197 RVA: 0x00120F60 File Offset: 0x0011F160
			[CallerCount(0)]
			public unsafe _MakeBloodQuadMap_d__120(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FX._MakeBloodQuadMap_d__120>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EE6 RID: 20198 RVA: 0x00120FA8 File Offset: 0x0011F1A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE7 RID: 20199 RVA: 0x00120FDC File Offset: 0x0011F1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56610, XrefRangeEnd = 56650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CC3 RID: 7363
			// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x00121018 File Offset: 0x0011F218
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EE9 RID: 20201 RVA: 0x00121058 File Offset: 0x0011F258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56650, XrefRangeEnd = 56655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CC4 RID: 7364
			// (get) Token: 0x06004EEA RID: 20202 RVA: 0x0012108C File Offset: 0x0011F28C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._MakeBloodQuadMap_d__120.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EEB RID: 20203 RVA: 0x0002E372 File Offset: 0x0002C572
			public _MakeBloodQuadMap_d__120(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CC0 RID: 7360
			// (get) Token: 0x06004EEC RID: 20204 RVA: 0x001210CC File Offset: 0x0011F2CC
			// (set) Token: 0x06004EED RID: 20205 RVA: 0x0002E37B File Offset: 0x0002C57B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CC1 RID: 7361
			// (get) Token: 0x06004EEE RID: 20206 RVA: 0x001210F4 File Offset: 0x0011F2F4
			// (set) Token: 0x06004EEF RID: 20207 RVA: 0x0002E396 File Offset: 0x0002C596
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC2 RID: 7362
			// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x00121124 File Offset: 0x0011F324
			// (set) Token: 0x06004EF1 RID: 20209 RVA: 0x0002E3B5 File Offset: 0x0002C5B5
			public unsafe FX __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FX>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._MakeBloodQuadMap_d__120.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033B6 RID: 13238
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040033B7 RID: 13239
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040033B8 RID: 13240
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040033B9 RID: 13241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040033BA RID: 13242
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033BB RID: 13243
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040033BC RID: 13244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040033BD RID: 13245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033BE RID: 13246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002F9 RID: 761
		[ObfuscatedName("FX+<ShowFloorTitleCo>d__160")]
		public sealed class _ShowFloorTitleCo_d__160 : global::Il2CppSystem.Object
		{
			// Token: 0x06004EF2 RID: 20210 RVA: 0x00121154 File Offset: 0x0011F354
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowFloorTitleCo_d__160()
			{
				Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FX>.NativeClassPtr, "<ShowFloorTitleCo>d__160");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr);
				FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, "<>1__state");
				FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, "<>2__current");
				FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, "<>4__this");
				FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, 100665284);
				FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, 100665285);
				FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, 100665286);
				FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, 100665287);
				FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, 100665288);
				FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr, 100665289);
			}

			// Token: 0x06004EF3 RID: 20211 RVA: 0x00121234 File Offset: 0x0011F434
			[CallerCount(0)]
			public unsafe _ShowFloorTitleCo_d__160(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FX._ShowFloorTitleCo_d__160>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EF4 RID: 20212 RVA: 0x0012127C File Offset: 0x0011F47C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EF5 RID: 20213 RVA: 0x001212B0 File Offset: 0x0011F4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56655, XrefRangeEnd = 56660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CC8 RID: 7368
			// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x001212EC File Offset: 0x0011F4EC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EF7 RID: 20215 RVA: 0x0012132C File Offset: 0x0011F52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56660, XrefRangeEnd = 56665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CC9 RID: 7369
			// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x00121360 File Offset: 0x0011F560
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FX._ShowFloorTitleCo_d__160.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EF9 RID: 20217 RVA: 0x0002E3D4 File Offset: 0x0002C5D4
			public _ShowFloorTitleCo_d__160(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CC5 RID: 7365
			// (get) Token: 0x06004EFA RID: 20218 RVA: 0x001213A0 File Offset: 0x0011F5A0
			// (set) Token: 0x06004EFB RID: 20219 RVA: 0x0002E3DD File Offset: 0x0002C5DD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CC6 RID: 7366
			// (get) Token: 0x06004EFC RID: 20220 RVA: 0x001213C8 File Offset: 0x0011F5C8
			// (set) Token: 0x06004EFD RID: 20221 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC7 RID: 7367
			// (get) Token: 0x06004EFE RID: 20222 RVA: 0x001213F8 File Offset: 0x0011F5F8
			// (set) Token: 0x06004EFF RID: 20223 RVA: 0x0002E417 File Offset: 0x0002C617
			public unsafe FX __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FX>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FX._ShowFloorTitleCo_d__160.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033BF RID: 13247
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040033C0 RID: 13248
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040033C1 RID: 13249
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040033C2 RID: 13250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040033C3 RID: 13251
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033C4 RID: 13252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040033C5 RID: 13253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040033C6 RID: 13254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033C7 RID: 13255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
