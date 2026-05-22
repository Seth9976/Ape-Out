using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000119 RID: 281
	public class Legs : MonoBehaviour
	{
		// Token: 0x060020FB RID: 8443 RVA: 0x0009073C File Offset: 0x0008E93C
		// Note: this type is marked as 'beforefieldinit'.
		static Legs()
		{
			Il2CppClassPointerStore<Legs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Legs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Legs>.NativeClassPtr);
			Legs.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "head");
			Legs.NativeFieldInfoPtr_shoulders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "shoulders");
			Legs.NativeFieldInfoPtr_shoulderHalves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "shoulderHalves");
			Legs.NativeFieldInfoPtr_hips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "hips");
			Legs.NativeFieldInfoPtr_thigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "thigh");
			Legs.NativeFieldInfoPtr_thighTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "thighTrans");
			Legs.NativeFieldInfoPtr_backCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "backCol");
			Legs.NativeFieldInfoPtr_backMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "backMesh");
			Legs.NativeFieldInfoPtr_lArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "lArm");
			Legs.NativeFieldInfoPtr_uArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "uArm");
			Legs.NativeFieldInfoPtr_lArmTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "lArmTrans");
			Legs.NativeFieldInfoPtr_uArmTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "uArmTrans");
			Legs.NativeFieldInfoPtr_elbow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "elbow");
			Legs.NativeFieldInfoPtr_legSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "legSpeedCurve");
			Legs.NativeFieldInfoPtr_shoulderLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "shoulderLocalPos");
			Legs.NativeFieldInfoPtr_drawnShoulderPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "drawnShoulderPos");
			Legs.NativeFieldInfoPtr_hipLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "hipLocalPos");
			Legs.NativeFieldInfoPtr_drawnHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "drawnHipPos");
			Legs.NativeFieldInfoPtr_paws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "paws");
			Legs.NativeFieldInfoPtr_cycleDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "cycleDist");
			Legs.NativeFieldInfoPtr_maxPawDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "maxPawDist");
			Legs.NativeFieldInfoPtr_swayMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "swayMult");
			Legs.NativeFieldInfoPtr_stance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "stance");
			Legs.NativeFieldInfoPtr_desStance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "desStance");
			Legs.NativeFieldInfoPtr_PAWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "PAWS");
			Legs.NativeFieldInfoPtr_LIFTTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "LIFTTIME");
			Legs.NativeFieldInfoPtr_PLACETIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "PLACETIME");
			Legs.NativeFieldInfoPtr_RUNLIFTTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "RUNLIFTTIME");
			Legs.NativeFieldInfoPtr_RUNPLACETIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "RUNPLACETIME");
			Legs.NativeFieldInfoPtr_runThresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "runThresh");
			Legs.NativeFieldInfoPtr_legWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "legWidth");
			Legs.NativeFieldInfoPtr_ankleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "ankleWidth");
			Legs.NativeFieldInfoPtr_legGirth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "legGirth");
			Legs.NativeFieldInfoPtr_uArmWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "uArmWidth");
			Legs.NativeFieldInfoPtr_lArmWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "lArmWidth");
			Legs.NativeFieldInfoPtr_uArmLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "uArmLen");
			Legs.NativeFieldInfoPtr_lArmLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "lArmLen");
			Legs.NativeFieldInfoPtr_minArmWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "minArmWidth");
			Legs.NativeFieldInfoPtr_walkUArmLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "walkUArmLen");
			Legs.NativeFieldInfoPtr_walkLArmLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "walkLArmLen");
			Legs.NativeFieldInfoPtr_upRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "upRate");
			Legs.NativeFieldInfoPtr_moveHands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "moveHands");
			Legs.NativeFieldInfoPtr_backShoulderPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "backShoulderPoint");
			Legs.NativeFieldInfoPtr_backHipPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "backHipPoint");
			Legs.NativeFieldInfoPtr_dynamicElbows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "dynamicElbows");
			Legs.NativeFieldInfoPtr_shoulderPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "shoulderPivot");
			Legs.NativeFieldInfoPtr_hipPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "hipPivot");
			Legs.NativeFieldInfoPtr_drawHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "drawHipPos");
			Legs.NativeFieldInfoPtr_drawSPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "drawSPos");
			Legs.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "time");
			Legs.NativeFieldInfoPtr_sPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "sPos");
			Legs.NativeFieldInfoPtr_prevSPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "prevSPos");
			Legs.NativeFieldInfoPtr_sVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "sVel");
			Legs.NativeFieldInfoPtr_hipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "hipPos");
			Legs.NativeFieldInfoPtr_prevHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "prevHipPos");
			Legs.NativeFieldInfoPtr_hipVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "hipVel");
			Legs.NativeFieldInfoPtr_defHipsPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "defHipsPos");
			Legs.NativeFieldInfoPtr_handsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "handsUp");
			Legs.NativeFieldInfoPtr_uLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "uLen");
			Legs.NativeFieldInfoPtr_lLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "lLen");
			Legs.NativeFieldInfoPtr_zeroing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "zeroing");
			Legs.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "zeroed");
			Legs.NativeFieldInfoPtr_zeroThresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "zeroThresh");
			Legs.NativeFieldInfoPtr_zeroTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "zeroTimer");
			Legs.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "deltaTime");
			Legs.NativeFieldInfoPtr_movedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "movedSpeed");
			Legs.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "verts");
			Legs.NativeFieldInfoPtr_ePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "ePos");
			Legs.NativeFieldInfoPtr_eDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "eDist");
			Legs.NativeFieldInfoPtr_defShoulderAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "defShoulderAng");
			Legs.NativeFieldInfoPtr_defHeadPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "defHeadPos");
			Legs.NativeFieldInfoPtr_uArmPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "uArmPercent");
			Legs.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "prevPos");
			Legs.NativeFieldInfoPtr_footAngleGuides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "footAngleGuides");
			Legs.NativeFieldInfoPtr_defScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "defScale");
			Legs.NativeFieldInfoPtr_meshesZeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "meshesZeroed");
			Legs.NativeFieldInfoPtr_onScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "onScreen");
			Legs.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "dead");
			Legs.NativeFieldInfoPtr_died = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "died");
			Legs.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Legs>.NativeClassPtr, "startRan");
			Legs.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665922);
			Legs.NativeMethodInfoPtr_OnScreenCheck_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665923);
			Legs.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665924);
			Legs.NativeMethodInfoPtr_Teleport_Public_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665925);
			Legs.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665926);
			Legs.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665927);
			Legs.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665928);
			Legs.NativeMethodInfoPtr_MoveElbows_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665929);
			Legs.NativeMethodInfoPtr_Zero_Public_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665930);
			Legs.NativeMethodInfoPtr_UpdatePaws_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665931);
			Legs.NativeMethodInfoPtr_GetJointSpeeds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665932);
			Legs.NativeMethodInfoPtr_SetTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665933);
			Legs.NativeMethodInfoPtr_SetPawPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665934);
			Legs.NativeMethodInfoPtr_PlacePaws_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665935);
			Legs.NativeMethodInfoPtr_MovePaw_Public_Void_Paw_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665936);
			Legs.NativeMethodInfoPtr_Swagger_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665937);
			Legs.NativeMethodInfoPtr_SwagHalfShoulders_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665938);
			Legs.NativeMethodInfoPtr_SwagHead_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665939);
			Legs.NativeMethodInfoPtr_RollScale_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665940);
			Legs.NativeMethodInfoPtr_StanceScale_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665941);
			Legs.NativeMethodInfoPtr_Swag_Public_Void_GameObject_Int32_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665942);
			Legs.NativeMethodInfoPtr_SetStance_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665943);
			Legs.NativeMethodInfoPtr_DrawArms_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665944);
			Legs.NativeMethodInfoPtr_DrawLegs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665945);
			Legs.NativeMethodInfoPtr_DrawBack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665946);
			Legs.NativeMethodInfoPtr_SetPrevPos_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665947);
			Legs.NativeMethodInfoPtr_InitShit_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665948);
			Legs.NativeMethodInfoPtr_ZeroPaws_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665949);
			Legs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Legs>.NativeClassPtr, 100665950);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00090FF0 File Offset: 0x0008F1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68233, RefRangeEnd = 68234, XrefRangeStart = 68176, XrefRangeEnd = 68233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0009102C File Offset: 0x0008F22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68234, XrefRangeEnd = 68241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OnScreenCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_OnScreenCheck_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00091074 File Offset: 0x0008F274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68275, RefRangeEnd = 68278, XrefRangeStart = 68241, XrefRangeEnd = 68275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000910B0 File Offset: 0x0008F2B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68336, RefRangeEnd = 68338, XrefRangeStart = 68278, XrefRangeEnd = 68336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Teleport(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_Teleport_Public_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000910FC File Offset: 0x0008F2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68370, RefRangeEnd = 68371, XrefRangeStart = 68338, XrefRangeEnd = 68370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00091138 File Offset: 0x0008F338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68371, XrefRangeEnd = 68388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0009116C File Offset: 0x0008F36C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68421, RefRangeEnd = 68423, XrefRangeStart = 68388, XrefRangeEnd = 68421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000911A8 File Offset: 0x0008F3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68430, RefRangeEnd = 68431, XrefRangeStart = 68423, XrefRangeEnd = 68430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveElbows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_MoveElbows_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000911E4 File Offset: 0x0008F3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68451, RefRangeEnd = 68452, XrefRangeStart = 68431, XrefRangeEnd = 68451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Zero(MeshFilter mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_Zero_Public_Void_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00091228 File Offset: 0x0008F428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68452, XrefRangeEnd = 68453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePaws()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_UpdatePaws_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00091264 File Offset: 0x0008F464
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 68474, RefRangeEnd = 68479, XrefRangeStart = 68453, XrefRangeEnd = 68474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetJointSpeeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_GetJointSpeeds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00091298 File Offset: 0x0008F498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68492, RefRangeEnd = 68494, XrefRangeStart = 68479, XrefRangeEnd = 68492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_SetTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000912CC File Offset: 0x0008F4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68496, RefRangeEnd = 68497, XrefRangeStart = 68494, XrefRangeEnd = 68496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPawPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_SetPawPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00091300 File Offset: 0x0008F500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68497, XrefRangeEnd = 68499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlacePaws()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_PlacePaws_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0009133C File Offset: 0x0008F53C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68527, RefRangeEnd = 68529, XrefRangeStart = 68499, XrefRangeEnd = 68527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePaw(Paw paw, Vector2 jointPos, Vector2 jointVel, int debugNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jointPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jointVel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debugNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_MovePaw_Public_Void_Paw_Vector2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000913A8 File Offset: 0x0008F5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68529, XrefRangeEnd = 68553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Swagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_Swagger_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000913E4 File Offset: 0x0008F5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68553, XrefRangeEnd = 68564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SwagHalfShoulders(int i, bool handBased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handBased;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_SwagHalfShoulders_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0009143C File Offset: 0x0008F63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68564, XrefRangeEnd = 68604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SwagHead(bool handBased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handBased;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_SwagHead_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00091488 File Offset: 0x0008F688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68604, XrefRangeEnd = 68621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RollScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_RollScale_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000914C4 File Offset: 0x0008F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68621, XrefRangeEnd = 68632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StanceScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_StanceScale_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00091500 File Offset: 0x0008F700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68677, RefRangeEnd = 68680, XrefRangeStart = 68632, XrefRangeEnd = 68677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Swag(GameObject shoulders, int pawNum, float swayMult, Vector2 transMult, Vector2 defPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shoulders);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pawNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref swayMult;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transMult;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_Swag_Public_Void_GameObject_Int32_Single_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0009157C File Offset: 0x0008F77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68680, XrefRangeEnd = 68691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_SetStance_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000915B8 File Offset: 0x0008F7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68749, RefRangeEnd = 68751, XrefRangeStart = 68691, XrefRangeEnd = 68749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawArms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_DrawArms_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000915F4 File Offset: 0x0008F7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68797, XrefRangeStart = 68751, XrefRangeEnd = 68795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLegs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr_DrawLegs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00091628 File Offset: 0x0008F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68797, XrefRangeEnd = 68843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_DrawBack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00091664 File Offset: 0x0008F864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68847, RefRangeEnd = 68848, XrefRangeStart = 68843, XrefRangeEnd = 68847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPrevPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_SetPrevPos_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000916A0 File Offset: 0x0008F8A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68943, RefRangeEnd = 68946, XrefRangeStart = 68848, XrefRangeEnd = 68943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_InitShit_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000916DC File Offset: 0x0008F8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68946, XrefRangeEnd = 68954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ZeroPaws()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Legs.NativeMethodInfoPtr_ZeroPaws_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00091718 File Offset: 0x0008F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Legs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Legs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Legs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000170BE File Offset: 0x000152BE
		public Legs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00091754 File Offset: 0x0008F954
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x000170C7 File Offset: 0x000152C7
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x00091784 File Offset: 0x0008F984
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x000170E6 File Offset: 0x000152E6
		public unsafe GameObject shoulders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000917B4 File Offset: 0x0008F9B4
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00017105 File Offset: 0x00015305
		public unsafe Il2CppReferenceArray<GameObject> shoulderHalves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulderHalves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulderHalves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000917E4 File Offset: 0x0008F9E4
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x00017124 File Offset: 0x00015324
		public unsafe GameObject hips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x00091814 File Offset: 0x0008FA14
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x00017143 File Offset: 0x00015343
		public unsafe Il2CppReferenceArray<MeshFilter> thigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_thigh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_thigh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00091844 File Offset: 0x0008FA44
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x00017162 File Offset: 0x00015362
		public unsafe Il2CppReferenceArray<Transform> thighTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_thighTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_thighTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00091874 File Offset: 0x0008FA74
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x00017181 File Offset: 0x00015381
		public unsafe GameObject backCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backCol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backCol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000918A4 File Offset: 0x0008FAA4
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x000171A0 File Offset: 0x000153A0
		public unsafe MeshFilter backMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000918D4 File Offset: 0x0008FAD4
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x000171BF File Offset: 0x000153BF
		public unsafe Il2CppReferenceArray<MeshFilter> lArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00091904 File Offset: 0x0008FB04
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x000171DE File Offset: 0x000153DE
		public unsafe Il2CppReferenceArray<MeshFilter> uArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x00091934 File Offset: 0x0008FB34
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x000171FD File Offset: 0x000153FD
		public unsafe Il2CppReferenceArray<Transform> lArmTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArmTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArmTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x00091964 File Offset: 0x0008FB64
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x0001721C File Offset: 0x0001541C
		public unsafe Il2CppReferenceArray<Transform> uArmTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00091994 File Offset: 0x0008FB94
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x0001723B File Offset: 0x0001543B
		public unsafe Il2CppReferenceArray<GameObject> elbow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_elbow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_elbow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x000919C4 File Offset: 0x0008FBC4
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x0001725A File Offset: 0x0001545A
		public unsafe AnimationCurve legSpeedCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_legSpeedCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_legSpeedCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x000919F4 File Offset: 0x0008FBF4
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x00017279 File Offset: 0x00015479
		public unsafe Vector2 shoulderLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulderLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulderLocalPos)) = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00091A1C File Offset: 0x0008FC1C
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00017294 File Offset: 0x00015494
		public unsafe Vector2 drawnShoulderPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawnShoulderPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawnShoulderPos)) = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00091A44 File Offset: 0x0008FC44
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x000172AF File Offset: 0x000154AF
		public unsafe Vector2 hipLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipLocalPos)) = value;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00091A6C File Offset: 0x0008FC6C
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x000172CA File Offset: 0x000154CA
		public unsafe Vector2 drawnHipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawnHipPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawnHipPos)) = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x00091A94 File Offset: 0x0008FC94
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x000172E5 File Offset: 0x000154E5
		public unsafe Il2CppReferenceArray<Paw> paws
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_paws);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Paw>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_paws), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00091AC4 File Offset: 0x0008FCC4
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x00017304 File Offset: 0x00015504
		public unsafe float cycleDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_cycleDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_cycleDist)) = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00091AEC File Offset: 0x0008FCEC
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x0001731F File Offset: 0x0001551F
		public unsafe float maxPawDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_maxPawDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_maxPawDist)) = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00091B14 File Offset: 0x0008FD14
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x0001733A File Offset: 0x0001553A
		public unsafe Il2CppStructArray<float> swayMult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_swayMult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_swayMult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00091B44 File Offset: 0x0008FD44
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x00017359 File Offset: 0x00015559
		public unsafe float stance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_stance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_stance)) = value;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00091B6C File Offset: 0x0008FD6C
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x00017374 File Offset: 0x00015574
		public unsafe float desStance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_desStance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_desStance)) = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00091B94 File Offset: 0x0008FD94
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x0001738F File Offset: 0x0001558F
		public unsafe Il2CppReferenceArray<GameObject> PAWS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_PAWS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_PAWS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x00091BC4 File Offset: 0x0008FDC4
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x000173AE File Offset: 0x000155AE
		public unsafe Il2CppStructArray<float> LIFTTIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_LIFTTIME);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_LIFTTIME), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x00091BF4 File Offset: 0x0008FDF4
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x000173CD File Offset: 0x000155CD
		public unsafe Il2CppStructArray<float> PLACETIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_PLACETIME);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_PLACETIME), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00091C24 File Offset: 0x0008FE24
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x000173EC File Offset: 0x000155EC
		public unsafe Il2CppStructArray<float> RUNLIFTTIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_RUNLIFTTIME);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_RUNLIFTTIME), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x00091C54 File Offset: 0x0008FE54
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x0001740B File Offset: 0x0001560B
		public unsafe Il2CppStructArray<float> RUNPLACETIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_RUNPLACETIME);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_RUNPLACETIME), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00091C84 File Offset: 0x0008FE84
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x0001742A File Offset: 0x0001562A
		public unsafe float runThresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_runThresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_runThresh)) = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00091CAC File Offset: 0x0008FEAC
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00017445 File Offset: 0x00015645
		public unsafe float legWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_legWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_legWidth)) = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x00091CD4 File Offset: 0x0008FED4
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x00017460 File Offset: 0x00015660
		public unsafe float ankleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_ankleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_ankleWidth)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x00091CFC File Offset: 0x0008FEFC
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x0001747B File Offset: 0x0001567B
		public unsafe float legGirth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_legGirth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_legGirth)) = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x00091D24 File Offset: 0x0008FF24
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x00017496 File Offset: 0x00015696
		public unsafe float uArmWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmWidth)) = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x00091D4C File Offset: 0x0008FF4C
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x000174B1 File Offset: 0x000156B1
		public unsafe float lArmWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArmWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArmWidth)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00091D74 File Offset: 0x0008FF74
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x000174CC File Offset: 0x000156CC
		public unsafe float uArmLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmLen)) = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x00091D9C File Offset: 0x0008FF9C
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x000174E7 File Offset: 0x000156E7
		public unsafe float lArmLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArmLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lArmLen)) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x00091DC4 File Offset: 0x0008FFC4
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x00017502 File Offset: 0x00015702
		public unsafe float minArmWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_minArmWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_minArmWidth)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x00091DEC File Offset: 0x0008FFEC
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x0001751D File Offset: 0x0001571D
		public unsafe float walkUArmLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_walkUArmLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_walkUArmLen)) = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x00091E14 File Offset: 0x00090014
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x00017538 File Offset: 0x00015738
		public unsafe float walkLArmLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_walkLArmLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_walkLArmLen)) = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x00091E3C File Offset: 0x0009003C
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x00017553 File Offset: 0x00015753
		public unsafe float upRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_upRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_upRate)) = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x00091E64 File Offset: 0x00090064
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x0001756E File Offset: 0x0001576E
		public unsafe bool moveHands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_moveHands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_moveHands)) = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x00091E8C File Offset: 0x0009008C
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x00017589 File Offset: 0x00015789
		public unsafe Vector2 backShoulderPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backShoulderPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backShoulderPoint)) = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x00091EB4 File Offset: 0x000900B4
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x000175A4 File Offset: 0x000157A4
		public unsafe Vector2 backHipPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backHipPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_backHipPoint)) = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x00091EDC File Offset: 0x000900DC
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x000175BF File Offset: 0x000157BF
		public unsafe bool dynamicElbows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_dynamicElbows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_dynamicElbows)) = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x00091F04 File Offset: 0x00090104
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x000175DA File Offset: 0x000157DA
		public unsafe Transform shoulderPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulderPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_shoulderPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x00091F34 File Offset: 0x00090134
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x000175F9 File Offset: 0x000157F9
		public unsafe Transform hipPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x00091F64 File Offset: 0x00090164
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x00017618 File Offset: 0x00015818
		public unsafe Il2CppStructArray<Vector2> drawHipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawHipPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawHipPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x00091F94 File Offset: 0x00090194
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x00017637 File Offset: 0x00015837
		public unsafe Il2CppStructArray<Vector2> drawSPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawSPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_drawSPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x00091FC4 File Offset: 0x000901C4
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x00017656 File Offset: 0x00015856
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x00091FEC File Offset: 0x000901EC
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x00017671 File Offset: 0x00015871
		public unsafe Il2CppStructArray<Vector2> sPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_sPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_sPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0009201C File Offset: 0x0009021C
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x00017690 File Offset: 0x00015890
		public unsafe Il2CppStructArray<Vector2> prevSPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_prevSPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_prevSPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0009204C File Offset: 0x0009024C
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x000176AF File Offset: 0x000158AF
		public unsafe Il2CppStructArray<Vector2> sVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_sVel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_sVel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0009207C File Offset: 0x0009027C
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x000176CE File Offset: 0x000158CE
		public unsafe Il2CppStructArray<Vector2> hipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x000920AC File Offset: 0x000902AC
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x000176ED File Offset: 0x000158ED
		public unsafe Il2CppStructArray<Vector2> prevHipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_prevHipPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_prevHipPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x000920DC File Offset: 0x000902DC
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x0001770C File Offset: 0x0001590C
		public unsafe Il2CppStructArray<Vector2> hipVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipVel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_hipVel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x0009210C File Offset: 0x0009030C
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x0001772B File Offset: 0x0001592B
		public unsafe Vector2 defHipsPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defHipsPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defHipsPos)) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x00092134 File Offset: 0x00090334
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00017746 File Offset: 0x00015946
		public unsafe bool handsUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_handsUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_handsUp)) = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x0009215C File Offset: 0x0009035C
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00017761 File Offset: 0x00015961
		public unsafe Il2CppStructArray<float> uLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uLen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uLen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x0009218C File Offset: 0x0009038C
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00017780 File Offset: 0x00015980
		public unsafe Il2CppStructArray<float> lLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lLen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_lLen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x000921BC File Offset: 0x000903BC
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x0001779F File Offset: 0x0001599F
		public unsafe bool zeroing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroing)) = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x000921E4 File Offset: 0x000903E4
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x000177BA File Offset: 0x000159BA
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x0009220C File Offset: 0x0009040C
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x000177D5 File Offset: 0x000159D5
		public unsafe float zeroThresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroThresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroThresh)) = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00092234 File Offset: 0x00090434
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x000177F0 File Offset: 0x000159F0
		public unsafe float zeroTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_zeroTimer)) = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x0009225C File Offset: 0x0009045C
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x0001780B File Offset: 0x00015A0B
		public unsafe float deltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_deltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_deltaTime)) = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x00092284 File Offset: 0x00090484
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x00017826 File Offset: 0x00015A26
		public unsafe float movedSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_movedSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_movedSpeed)) = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x000922AC File Offset: 0x000904AC
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x00017841 File Offset: 0x00015A41
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000922DC File Offset: 0x000904DC
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00017860 File Offset: 0x00015A60
		public unsafe Il2CppStructArray<Vector2> ePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_ePos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_ePos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x0009230C File Offset: 0x0009050C
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x0001787F File Offset: 0x00015A7F
		public unsafe Il2CppStructArray<float> eDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_eDist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_eDist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x0009233C File Offset: 0x0009053C
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0001789E File Offset: 0x00015A9E
		public unsafe Il2CppStructArray<float> defShoulderAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defShoulderAng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defShoulderAng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0009236C File Offset: 0x0009056C
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x000178BD File Offset: 0x00015ABD
		public unsafe Vector2 defHeadPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defHeadPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defHeadPos)) = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00092394 File Offset: 0x00090594
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x000178D8 File Offset: 0x00015AD8
		public unsafe float uArmPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_uArmPercent)) = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000923BC File Offset: 0x000905BC
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x000178F3 File Offset: 0x00015AF3
		public unsafe Vector2 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x000923E4 File Offset: 0x000905E4
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x0001790E File Offset: 0x00015B0E
		public unsafe Il2CppReferenceArray<Transform> footAngleGuides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_footAngleGuides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_footAngleGuides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00092414 File Offset: 0x00090614
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x0001792D File Offset: 0x00015B2D
		public unsafe float defScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_defScale)) = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x0009243C File Offset: 0x0009063C
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x00017948 File Offset: 0x00015B48
		public unsafe bool meshesZeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_meshesZeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_meshesZeroed)) = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00092464 File Offset: 0x00090664
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x00017963 File Offset: 0x00015B63
		public unsafe bool onScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_onScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_onScreen)) = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0009248C File Offset: 0x0009068C
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0001797E File Offset: 0x00015B7E
		public unsafe bool dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000924B4 File Offset: 0x000906B4
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00017999 File Offset: 0x00015B99
		public unsafe bool died
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_died);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_died)) = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000924DC File Offset: 0x000906DC
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x000179B4 File Offset: 0x00015BB4
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Legs.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr_shoulders;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_shoulderHalves;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_hips;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_thigh;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeFieldInfoPtr_thighTrans;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeFieldInfoPtr_backCol;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeFieldInfoPtr_backMesh;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeFieldInfoPtr_lArm;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeFieldInfoPtr_uArm;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeFieldInfoPtr_lArmTrans;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeFieldInfoPtr_uArmTrans;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeFieldInfoPtr_elbow;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeFieldInfoPtr_legSpeedCurve;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeFieldInfoPtr_shoulderLocalPos;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_drawnShoulderPos;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_hipLocalPos;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr_drawnHipPos;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeFieldInfoPtr_paws;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeFieldInfoPtr_cycleDist;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeFieldInfoPtr_maxPawDist;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeFieldInfoPtr_swayMult;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeFieldInfoPtr_stance;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeFieldInfoPtr_desStance;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr_PAWS;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr_LIFTTIME;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_PLACETIME;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_RUNLIFTTIME;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_RUNPLACETIME;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_runThresh;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr_legWidth;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr_ankleWidth;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeFieldInfoPtr_legGirth;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeFieldInfoPtr_uArmWidth;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr_lArmWidth;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeFieldInfoPtr_uArmLen;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr_lArmLen;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr_minArmWidth;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr_walkUArmLen;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeFieldInfoPtr_walkLArmLen;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeFieldInfoPtr_upRate;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeFieldInfoPtr_moveHands;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeFieldInfoPtr_backShoulderPoint;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeFieldInfoPtr_backHipPoint;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeFieldInfoPtr_dynamicElbows;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeFieldInfoPtr_shoulderPivot;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeFieldInfoPtr_hipPivot;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeFieldInfoPtr_drawHipPos;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeFieldInfoPtr_drawSPos;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeFieldInfoPtr_sPos;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeFieldInfoPtr_prevSPos;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_sVel;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr_hipPos;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr_prevHipPos;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_hipVel;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_defHipsPos;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_handsUp;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_uLen;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr_lLen;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_zeroing;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr_zeroThresh;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeFieldInfoPtr_zeroTimer;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeFieldInfoPtr_deltaTime;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeFieldInfoPtr_movedSpeed;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_ePos;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_eDist;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_defShoulderAng;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_defHeadPos;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr_uArmPercent;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeFieldInfoPtr_footAngleGuides;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeFieldInfoPtr_defScale;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr_meshesZeroed;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_onScreen;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_died;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_OnScreenCheck_Public_Virtual_New_Boolean_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Virtual_New_Void_Vector3_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_MoveElbows_Public_Virtual_New_Void_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_Zero_Public_Void_MeshFilter_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePaws_Public_Virtual_New_Void_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_GetJointSpeeds_Public_Void_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_SetPawPos_Public_Void_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_PlacePaws_Public_Virtual_New_Void_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_MovePaw_Public_Void_Paw_Vector2_Vector2_Int32_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_Swagger_Public_Virtual_New_Void_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_SwagHalfShoulders_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_SwagHead_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_RollScale_Public_Virtual_New_Void_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_StanceScale_Public_Virtual_New_Void_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_Swag_Public_Void_GameObject_Int32_Single_Vector2_Vector2_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_SetStance_Public_Virtual_New_Void_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_DrawArms_Public_Virtual_New_Void_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_DrawLegs_Public_Void_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_DrawBack_Public_Virtual_New_Void_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_SetPrevPos_Public_Virtual_New_Void_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_InitShit_Public_Virtual_New_Void_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_ZeroPaws_Public_Virtual_New_Void_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
