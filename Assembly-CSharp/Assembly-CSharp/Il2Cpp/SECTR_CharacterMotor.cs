using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000055 RID: 85
	public class SECTR_CharacterMotor : MonoBehaviour
	{
		// Token: 0x06000C58 RID: 3160 RVA: 0x000594F8 File Offset: 0x000576F8
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_CharacterMotor()
		{
			Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_CharacterMotor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr);
			SECTR_CharacterMotor.NativeFieldInfoPtr_canControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "canControl");
			SECTR_CharacterMotor.NativeFieldInfoPtr_lastGroundNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "lastGroundNormal");
			SECTR_CharacterMotor.NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "cachedTransform");
			SECTR_CharacterMotor.NativeFieldInfoPtr_cachedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "cachedController");
			SECTR_CharacterMotor.NativeFieldInfoPtr_lastFootstepPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "lastFootstepPosition");
			SECTR_CharacterMotor.NativeFieldInfoPtr_defaultHitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "defaultHitMaterial");
			SECTR_CharacterMotor.NativeFieldInfoPtr_inputMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "inputMoveDirection");
			SECTR_CharacterMotor.NativeFieldInfoPtr_inputJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "inputJump");
			SECTR_CharacterMotor.NativeFieldInfoPtr_grounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "grounded");
			SECTR_CharacterMotor.NativeFieldInfoPtr_groundNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "groundNormal");
			SECTR_CharacterMotor.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "movement");
			SECTR_CharacterMotor.NativeFieldInfoPtr_jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "jumping");
			SECTR_CharacterMotor.NativeFieldInfoPtr_movingPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "movingPlatform");
			SECTR_CharacterMotor.NativeFieldInfoPtr_sliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "sliding");
			SECTR_CharacterMotor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664382);
			SECTR_CharacterMotor.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664383);
			SECTR_CharacterMotor.NativeMethodInfoPtr_ApplyInputVelocityChange_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664384);
			SECTR_CharacterMotor.NativeMethodInfoPtr_ApplyGravityAndJumping_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664385);
			SECTR_CharacterMotor.NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664386);
			SECTR_CharacterMotor.NativeMethodInfoPtr_SubtractNewPlatformVelocity_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664387);
			SECTR_CharacterMotor.NativeMethodInfoPtr_MoveWithPlatform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664388);
			SECTR_CharacterMotor.NativeMethodInfoPtr_GetDesiredHorizontalVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664389);
			SECTR_CharacterMotor.NativeMethodInfoPtr_AdjustGroundVelocityToNormal_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664390);
			SECTR_CharacterMotor.NativeMethodInfoPtr_IsGroundedTest_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664391);
			SECTR_CharacterMotor.NativeMethodInfoPtr_GetMaxAcceleration_Private_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664392);
			SECTR_CharacterMotor.NativeMethodInfoPtr_CalculateJumpVerticalSpeed_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664393);
			SECTR_CharacterMotor.NativeMethodInfoPtr_TooSteep_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664394);
			SECTR_CharacterMotor.NativeMethodInfoPtr_MaxSpeedInDirection_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664395);
			SECTR_CharacterMotor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, 100664396);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0005976C File Offset: 0x0005796C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42672, XrefRangeEnd = 42689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000597A0 File Offset: 0x000579A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42689, XrefRangeEnd = 42827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000597D4 File Offset: 0x000579D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42846, RefRangeEnd = 42847, XrefRangeStart = 42827, XrefRangeEnd = 42846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ApplyInputVelocityChange(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref velocity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_ApplyInputVelocityChange_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00059820 File Offset: 0x00057A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42884, RefRangeEnd = 42885, XrefRangeStart = 42847, XrefRangeEnd = 42884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ApplyGravityAndJumping(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref velocity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_ApplyGravityAndJumping_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0005986C File Offset: 0x00057A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42885, XrefRangeEnd = 42924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControllerColliderHit(ControllerColliderHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000598B0 File Offset: 0x00057AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42924, XrefRangeEnd = 42927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SubtractNewPlatformVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_SubtractNewPlatformVelocity_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000598F0 File Offset: 0x00057AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42939, RefRangeEnd = 42941, XrefRangeStart = 42927, XrefRangeEnd = 42939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveWithPlatform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_MoveWithPlatform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0005992C File Offset: 0x00057B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42949, RefRangeEnd = 42950, XrefRangeStart = 42941, XrefRangeEnd = 42949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDesiredHorizontalVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_GetDesiredHorizontalVelocity_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00059968 File Offset: 0x00057B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42957, RefRangeEnd = 42958, XrefRangeStart = 42950, XrefRangeEnd = 42957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hVelocity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref groundNormal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_AdjustGroundVelocityToNormal_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000599C0 File Offset: 0x00057BC0
		[CallerCount(0)]
		public unsafe bool IsGroundedTest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_IsGroundedTest_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000599FC File Offset: 0x00057BFC
		[CallerCount(0)]
		public unsafe float GetMaxAcceleration(bool grounded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref grounded;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_GetMaxAcceleration_Private_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00059A48 File Offset: 0x00057C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42958, RefRangeEnd = 42959, XrefRangeStart = 42958, XrefRangeEnd = 42958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateJumpVerticalSpeed(float targetJumpHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetJumpHeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_CalculateJumpVerticalSpeed_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00059A94 File Offset: 0x00057C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42962, RefRangeEnd = 42965, XrefRangeStart = 42959, XrefRangeEnd = 42962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TooSteep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_TooSteep_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00059AD0 File Offset: 0x00057CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42967, RefRangeEnd = 42968, XrefRangeStart = 42965, XrefRangeEnd = 42967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MaxSpeedInDirection(Vector3 desiredMovementDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desiredMovementDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr_MaxSpeedInDirection_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00059B1C File Offset: 0x00057D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42968, XrefRangeEnd = 42994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_CharacterMotor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000097D4 File Offset: 0x000079D4
		public SECTR_CharacterMotor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00059B58 File Offset: 0x00057D58
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x000097DD File Offset: 0x000079DD
		public unsafe bool canControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_canControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_canControl)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00059B80 File Offset: 0x00057D80
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x000097F8 File Offset: 0x000079F8
		public unsafe Vector3 lastGroundNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_lastGroundNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_lastGroundNormal)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00059BA8 File Offset: 0x00057DA8
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00009813 File Offset: 0x00007A13
		public unsafe Transform cachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_cachedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_cachedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00059BD8 File Offset: 0x00057DD8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00009832 File Offset: 0x00007A32
		public unsafe CharacterController cachedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_cachedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_cachedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00059C08 File Offset: 0x00057E08
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00009851 File Offset: 0x00007A51
		public unsafe Vector3 lastFootstepPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_lastFootstepPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_lastFootstepPosition)) = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00059C30 File Offset: 0x00057E30
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x0000986C File Offset: 0x00007A6C
		public unsafe PhysicMaterial defaultHitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_defaultHitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_defaultHitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00059C60 File Offset: 0x00057E60
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0000988B File Offset: 0x00007A8B
		public unsafe Vector3 inputMoveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_inputMoveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_inputMoveDirection)) = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00059C88 File Offset: 0x00057E88
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000098A6 File Offset: 0x00007AA6
		public unsafe bool inputJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_inputJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_inputJump)) = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00059CB0 File Offset: 0x00057EB0
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x000098C1 File Offset: 0x00007AC1
		public unsafe bool grounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_grounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_grounded)) = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00059CD8 File Offset: 0x00057ED8
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000098DC File Offset: 0x00007ADC
		public unsafe Vector3 groundNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_groundNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_groundNormal)) = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00059D00 File Offset: 0x00057F00
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x000098F7 File Offset: 0x00007AF7
		public unsafe SECTR_CharacterMotor.CharacterMotorMovement movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterMotor.CharacterMotorMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00059D30 File Offset: 0x00057F30
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00009916 File Offset: 0x00007B16
		public unsafe SECTR_CharacterMotor.CharacterMotorJumping jumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_jumping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterMotor.CharacterMotorJumping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_jumping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00059D60 File Offset: 0x00057F60
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00009935 File Offset: 0x00007B35
		public unsafe SECTR_CharacterMotor.CharacterMotorMovingPlatform movingPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_movingPlatform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterMotor.CharacterMotorMovingPlatform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_movingPlatform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00059D90 File Offset: 0x00057F90
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00009954 File Offset: 0x00007B54
		public unsafe SECTR_CharacterMotor.CharacterMotorSliding sliding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_sliding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterMotor.CharacterMotorSliding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.NativeFieldInfoPtr_sliding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_canControl;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_lastGroundNormal;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_cachedController;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_lastFootstepPosition;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr_defaultHitMaterial;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr_inputMoveDirection;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_inputJump;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeFieldInfoPtr_grounded;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeFieldInfoPtr_groundNormal;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr_jumping;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_movingPlatform;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_sliding;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputVelocityChange_Private_Vector3_Vector3_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGravityAndJumping_Private_Vector3_Vector3_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_SubtractNewPlatformVelocity_Private_IEnumerator_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_MoveWithPlatform_Private_Boolean_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_GetDesiredHorizontalVelocity_Private_Vector3_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_AdjustGroundVelocityToNormal_Private_Vector3_Vector3_Vector3_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_IsGroundedTest_Private_Boolean_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxAcceleration_Private_Single_Boolean_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_CalculateJumpVerticalSpeed_Private_Single_Single_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_TooSteep_Private_Boolean_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_MaxSpeedInDirection_Private_Single_Vector3_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002C5 RID: 709
		[Serializable]
		public class CharacterMotorMovement : global::Il2CppSystem.Object
		{
			// Token: 0x06004C1F RID: 19487 RVA: 0x00118C64 File Offset: 0x00116E64
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterMotorMovement()
			{
				Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "CharacterMotorMovement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr);
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxForwardSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "maxForwardSpeed");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxSidewaysSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "maxSidewaysSpeed");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxBackwardsSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "maxBackwardsSpeed");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_slopeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "slopeSpeedMultiplier");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxGroundAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "maxGroundAcceleration");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxAirAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "maxAirAcceleration");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "gravity");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxFallSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "maxFallSpeed");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_footstepDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "footstepDistance");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_pushPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "pushPower");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_collisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "collisionFlags");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "velocity");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_frameVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "frameVelocity");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "hitPoint");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_lastHitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "lastHitPoint");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_hitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, "hitMaterial");
				SECTR_CharacterMotor.CharacterMotorMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr, 100664397);
			}

			// Token: 0x06004C20 RID: 19488 RVA: 0x00118DE4 File Offset: 0x00116FE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42642, RefRangeEnd = 42643, XrefRangeStart = 42630, XrefRangeEnd = 42642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterMotorMovement()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovement>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.CharacterMotorMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C21 RID: 19489 RVA: 0x0002CC7F File Offset: 0x0002AE7F
			public CharacterMotorMovement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BB7 RID: 7095
			// (get) Token: 0x06004C22 RID: 19490 RVA: 0x00118E20 File Offset: 0x00117020
			// (set) Token: 0x06004C23 RID: 19491 RVA: 0x0002CC88 File Offset: 0x0002AE88
			public unsafe float maxForwardSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxForwardSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxForwardSpeed)) = value;
				}
			}

			// Token: 0x17001BB8 RID: 7096
			// (get) Token: 0x06004C24 RID: 19492 RVA: 0x00118E48 File Offset: 0x00117048
			// (set) Token: 0x06004C25 RID: 19493 RVA: 0x0002CCA3 File Offset: 0x0002AEA3
			public unsafe float maxSidewaysSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxSidewaysSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxSidewaysSpeed)) = value;
				}
			}

			// Token: 0x17001BB9 RID: 7097
			// (get) Token: 0x06004C26 RID: 19494 RVA: 0x00118E70 File Offset: 0x00117070
			// (set) Token: 0x06004C27 RID: 19495 RVA: 0x0002CCBE File Offset: 0x0002AEBE
			public unsafe float maxBackwardsSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxBackwardsSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxBackwardsSpeed)) = value;
				}
			}

			// Token: 0x17001BBA RID: 7098
			// (get) Token: 0x06004C28 RID: 19496 RVA: 0x00118E98 File Offset: 0x00117098
			// (set) Token: 0x06004C29 RID: 19497 RVA: 0x0002CCD9 File Offset: 0x0002AED9
			public unsafe AnimationCurve slopeSpeedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_slopeSpeedMultiplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_slopeSpeedMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBB RID: 7099
			// (get) Token: 0x06004C2A RID: 19498 RVA: 0x00118EC8 File Offset: 0x001170C8
			// (set) Token: 0x06004C2B RID: 19499 RVA: 0x0002CCF8 File Offset: 0x0002AEF8
			public unsafe float maxGroundAcceleration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxGroundAcceleration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxGroundAcceleration)) = value;
				}
			}

			// Token: 0x17001BBC RID: 7100
			// (get) Token: 0x06004C2C RID: 19500 RVA: 0x00118EF0 File Offset: 0x001170F0
			// (set) Token: 0x06004C2D RID: 19501 RVA: 0x0002CD13 File Offset: 0x0002AF13
			public unsafe float maxAirAcceleration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxAirAcceleration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxAirAcceleration)) = value;
				}
			}

			// Token: 0x17001BBD RID: 7101
			// (get) Token: 0x06004C2E RID: 19502 RVA: 0x00118F18 File Offset: 0x00117118
			// (set) Token: 0x06004C2F RID: 19503 RVA: 0x0002CD2E File Offset: 0x0002AF2E
			public unsafe float gravity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_gravity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_gravity)) = value;
				}
			}

			// Token: 0x17001BBE RID: 7102
			// (get) Token: 0x06004C30 RID: 19504 RVA: 0x00118F40 File Offset: 0x00117140
			// (set) Token: 0x06004C31 RID: 19505 RVA: 0x0002CD49 File Offset: 0x0002AF49
			public unsafe float maxFallSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxFallSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_maxFallSpeed)) = value;
				}
			}

			// Token: 0x17001BBF RID: 7103
			// (get) Token: 0x06004C32 RID: 19506 RVA: 0x00118F68 File Offset: 0x00117168
			// (set) Token: 0x06004C33 RID: 19507 RVA: 0x0002CD64 File Offset: 0x0002AF64
			public unsafe float footstepDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_footstepDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_footstepDistance)) = value;
				}
			}

			// Token: 0x17001BC0 RID: 7104
			// (get) Token: 0x06004C34 RID: 19508 RVA: 0x00118F90 File Offset: 0x00117190
			// (set) Token: 0x06004C35 RID: 19509 RVA: 0x0002CD7F File Offset: 0x0002AF7F
			public unsafe float pushPower
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_pushPower);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_pushPower)) = value;
				}
			}

			// Token: 0x17001BC1 RID: 7105
			// (get) Token: 0x06004C36 RID: 19510 RVA: 0x00118FB8 File Offset: 0x001171B8
			// (set) Token: 0x06004C37 RID: 19511 RVA: 0x0002CD9A File Offset: 0x0002AF9A
			public unsafe CollisionFlags collisionFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_collisionFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_collisionFlags)) = value;
				}
			}

			// Token: 0x17001BC2 RID: 7106
			// (get) Token: 0x06004C38 RID: 19512 RVA: 0x00118FE0 File Offset: 0x001171E0
			// (set) Token: 0x06004C39 RID: 19513 RVA: 0x0002CDB5 File Offset: 0x0002AFB5
			public unsafe Vector3 velocity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_velocity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_velocity)) = value;
				}
			}

			// Token: 0x17001BC3 RID: 7107
			// (get) Token: 0x06004C3A RID: 19514 RVA: 0x00119008 File Offset: 0x00117208
			// (set) Token: 0x06004C3B RID: 19515 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
			public unsafe Vector3 frameVelocity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_frameVelocity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_frameVelocity)) = value;
				}
			}

			// Token: 0x17001BC4 RID: 7108
			// (get) Token: 0x06004C3C RID: 19516 RVA: 0x00119030 File Offset: 0x00117230
			// (set) Token: 0x06004C3D RID: 19517 RVA: 0x0002CDEB File Offset: 0x0002AFEB
			public unsafe Vector3 hitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_hitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_hitPoint)) = value;
				}
			}

			// Token: 0x17001BC5 RID: 7109
			// (get) Token: 0x06004C3E RID: 19518 RVA: 0x00119058 File Offset: 0x00117258
			// (set) Token: 0x06004C3F RID: 19519 RVA: 0x0002CE06 File Offset: 0x0002B006
			public unsafe Vector3 lastHitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_lastHitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_lastHitPoint)) = value;
				}
			}

			// Token: 0x17001BC6 RID: 7110
			// (get) Token: 0x06004C40 RID: 19520 RVA: 0x00119080 File Offset: 0x00117280
			// (set) Token: 0x06004C41 RID: 19521 RVA: 0x0002CE21 File Offset: 0x0002B021
			public unsafe PhysicMaterial hitMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_hitMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovement.NativeFieldInfoPtr_hitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031E8 RID: 12776
			private static readonly IntPtr NativeFieldInfoPtr_maxForwardSpeed;

			// Token: 0x040031E9 RID: 12777
			private static readonly IntPtr NativeFieldInfoPtr_maxSidewaysSpeed;

			// Token: 0x040031EA RID: 12778
			private static readonly IntPtr NativeFieldInfoPtr_maxBackwardsSpeed;

			// Token: 0x040031EB RID: 12779
			private static readonly IntPtr NativeFieldInfoPtr_slopeSpeedMultiplier;

			// Token: 0x040031EC RID: 12780
			private static readonly IntPtr NativeFieldInfoPtr_maxGroundAcceleration;

			// Token: 0x040031ED RID: 12781
			private static readonly IntPtr NativeFieldInfoPtr_maxAirAcceleration;

			// Token: 0x040031EE RID: 12782
			private static readonly IntPtr NativeFieldInfoPtr_gravity;

			// Token: 0x040031EF RID: 12783
			private static readonly IntPtr NativeFieldInfoPtr_maxFallSpeed;

			// Token: 0x040031F0 RID: 12784
			private static readonly IntPtr NativeFieldInfoPtr_footstepDistance;

			// Token: 0x040031F1 RID: 12785
			private static readonly IntPtr NativeFieldInfoPtr_pushPower;

			// Token: 0x040031F2 RID: 12786
			private static readonly IntPtr NativeFieldInfoPtr_collisionFlags;

			// Token: 0x040031F3 RID: 12787
			private static readonly IntPtr NativeFieldInfoPtr_velocity;

			// Token: 0x040031F4 RID: 12788
			private static readonly IntPtr NativeFieldInfoPtr_frameVelocity;

			// Token: 0x040031F5 RID: 12789
			private static readonly IntPtr NativeFieldInfoPtr_hitPoint;

			// Token: 0x040031F6 RID: 12790
			private static readonly IntPtr NativeFieldInfoPtr_lastHitPoint;

			// Token: 0x040031F7 RID: 12791
			private static readonly IntPtr NativeFieldInfoPtr_hitMaterial;

			// Token: 0x040031F8 RID: 12792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C6 RID: 710
		[OriginalName("Assembly-CSharp.dll", "", "MovementTransferOnJump")]
		public enum MovementTransferOnJump
		{
			// Token: 0x040031FA RID: 12794
			None,
			// Token: 0x040031FB RID: 12795
			InitTransfer,
			// Token: 0x040031FC RID: 12796
			PermaTransfer,
			// Token: 0x040031FD RID: 12797
			PermaLocked
		}

		// Token: 0x020002C7 RID: 711
		[Serializable]
		public class CharacterMotorJumping : global::Il2CppSystem.Object
		{
			// Token: 0x06004C42 RID: 19522 RVA: 0x001190B0 File Offset: 0x001172B0
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterMotorJumping()
			{
				Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "CharacterMotorJumping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr);
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "enabled");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_baseHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "baseHeight");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_extraHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "extraHeight");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_perpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "perpAmount");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_steepPerpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "steepPerpAmount");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "jumping");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_holdingJumpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "holdingJumpButton");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_lastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "lastStartTime");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_lastButtonDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "lastButtonDownTime");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_jumpDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, "jumpDir");
				SECTR_CharacterMotor.CharacterMotorJumping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr, 100664398);
			}

			// Token: 0x06004C43 RID: 19523 RVA: 0x001191B8 File Offset: 0x001173B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42643, XrefRangeEnd = 42645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterMotorJumping()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorJumping>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.CharacterMotorJumping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C44 RID: 19524 RVA: 0x0002CE40 File Offset: 0x0002B040
			public CharacterMotorJumping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BC7 RID: 7111
			// (get) Token: 0x06004C45 RID: 19525 RVA: 0x001191F4 File Offset: 0x001173F4
			// (set) Token: 0x06004C46 RID: 19526 RVA: 0x0002CE49 File Offset: 0x0002B049
			public unsafe bool enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_enabled)) = value;
				}
			}

			// Token: 0x17001BC8 RID: 7112
			// (get) Token: 0x06004C47 RID: 19527 RVA: 0x0011921C File Offset: 0x0011741C
			// (set) Token: 0x06004C48 RID: 19528 RVA: 0x0002CE64 File Offset: 0x0002B064
			public unsafe float baseHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_baseHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_baseHeight)) = value;
				}
			}

			// Token: 0x17001BC9 RID: 7113
			// (get) Token: 0x06004C49 RID: 19529 RVA: 0x00119244 File Offset: 0x00117444
			// (set) Token: 0x06004C4A RID: 19530 RVA: 0x0002CE7F File Offset: 0x0002B07F
			public unsafe float extraHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_extraHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_extraHeight)) = value;
				}
			}

			// Token: 0x17001BCA RID: 7114
			// (get) Token: 0x06004C4B RID: 19531 RVA: 0x0011926C File Offset: 0x0011746C
			// (set) Token: 0x06004C4C RID: 19532 RVA: 0x0002CE9A File Offset: 0x0002B09A
			public unsafe float perpAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_perpAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_perpAmount)) = value;
				}
			}

			// Token: 0x17001BCB RID: 7115
			// (get) Token: 0x06004C4D RID: 19533 RVA: 0x00119294 File Offset: 0x00117494
			// (set) Token: 0x06004C4E RID: 19534 RVA: 0x0002CEB5 File Offset: 0x0002B0B5
			public unsafe float steepPerpAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_steepPerpAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_steepPerpAmount)) = value;
				}
			}

			// Token: 0x17001BCC RID: 7116
			// (get) Token: 0x06004C4F RID: 19535 RVA: 0x001192BC File Offset: 0x001174BC
			// (set) Token: 0x06004C50 RID: 19536 RVA: 0x0002CED0 File Offset: 0x0002B0D0
			public unsafe bool jumping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_jumping);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_jumping)) = value;
				}
			}

			// Token: 0x17001BCD RID: 7117
			// (get) Token: 0x06004C51 RID: 19537 RVA: 0x001192E4 File Offset: 0x001174E4
			// (set) Token: 0x06004C52 RID: 19538 RVA: 0x0002CEEB File Offset: 0x0002B0EB
			public unsafe bool holdingJumpButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_holdingJumpButton);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_holdingJumpButton)) = value;
				}
			}

			// Token: 0x17001BCE RID: 7118
			// (get) Token: 0x06004C53 RID: 19539 RVA: 0x0011930C File Offset: 0x0011750C
			// (set) Token: 0x06004C54 RID: 19540 RVA: 0x0002CF06 File Offset: 0x0002B106
			public unsafe float lastStartTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_lastStartTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_lastStartTime)) = value;
				}
			}

			// Token: 0x17001BCF RID: 7119
			// (get) Token: 0x06004C55 RID: 19541 RVA: 0x00119334 File Offset: 0x00117534
			// (set) Token: 0x06004C56 RID: 19542 RVA: 0x0002CF21 File Offset: 0x0002B121
			public unsafe float lastButtonDownTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_lastButtonDownTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_lastButtonDownTime)) = value;
				}
			}

			// Token: 0x17001BD0 RID: 7120
			// (get) Token: 0x06004C57 RID: 19543 RVA: 0x0011935C File Offset: 0x0011755C
			// (set) Token: 0x06004C58 RID: 19544 RVA: 0x0002CF3C File Offset: 0x0002B13C
			public unsafe Vector3 jumpDir
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_jumpDir);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorJumping.NativeFieldInfoPtr_jumpDir)) = value;
				}
			}

			// Token: 0x040031FE RID: 12798
			private static readonly IntPtr NativeFieldInfoPtr_enabled;

			// Token: 0x040031FF RID: 12799
			private static readonly IntPtr NativeFieldInfoPtr_baseHeight;

			// Token: 0x04003200 RID: 12800
			private static readonly IntPtr NativeFieldInfoPtr_extraHeight;

			// Token: 0x04003201 RID: 12801
			private static readonly IntPtr NativeFieldInfoPtr_perpAmount;

			// Token: 0x04003202 RID: 12802
			private static readonly IntPtr NativeFieldInfoPtr_steepPerpAmount;

			// Token: 0x04003203 RID: 12803
			private static readonly IntPtr NativeFieldInfoPtr_jumping;

			// Token: 0x04003204 RID: 12804
			private static readonly IntPtr NativeFieldInfoPtr_holdingJumpButton;

			// Token: 0x04003205 RID: 12805
			private static readonly IntPtr NativeFieldInfoPtr_lastStartTime;

			// Token: 0x04003206 RID: 12806
			private static readonly IntPtr NativeFieldInfoPtr_lastButtonDownTime;

			// Token: 0x04003207 RID: 12807
			private static readonly IntPtr NativeFieldInfoPtr_jumpDir;

			// Token: 0x04003208 RID: 12808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C8 RID: 712
		[Serializable]
		public class CharacterMotorMovingPlatform : global::Il2CppSystem.Object
		{
			// Token: 0x06004C59 RID: 19545 RVA: 0x00119384 File Offset: 0x00117584
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterMotorMovingPlatform()
			{
				Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "CharacterMotorMovingPlatform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr);
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "enabled");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_movementTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "movementTransfer");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_hitPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "hitPlatform");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activePlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "activePlatform");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeLocalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "activeLocalPoint");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeGlobalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "activeGlobalPoint");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "activeLocalRotation");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeGlobalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "activeGlobalRotation");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_lastMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "lastMatrix");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_platformVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "platformVelocity");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_newPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, "newPlatform");
				SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr, 100664399);
			}

			// Token: 0x06004C5A RID: 19546 RVA: 0x001194A0 File Offset: 0x001176A0
			[CallerCount(0)]
			public unsafe CharacterMotorMovingPlatform()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorMovingPlatform>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C5B RID: 19547 RVA: 0x0002CF57 File Offset: 0x0002B157
			public CharacterMotorMovingPlatform(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BD1 RID: 7121
			// (get) Token: 0x06004C5C RID: 19548 RVA: 0x001194DC File Offset: 0x001176DC
			// (set) Token: 0x06004C5D RID: 19549 RVA: 0x0002CF60 File Offset: 0x0002B160
			public unsafe bool enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_enabled)) = value;
				}
			}

			// Token: 0x17001BD2 RID: 7122
			// (get) Token: 0x06004C5E RID: 19550 RVA: 0x00119504 File Offset: 0x00117704
			// (set) Token: 0x06004C5F RID: 19551 RVA: 0x0002CF7B File Offset: 0x0002B17B
			public unsafe SECTR_CharacterMotor.MovementTransferOnJump movementTransfer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_movementTransfer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_movementTransfer)) = value;
				}
			}

			// Token: 0x17001BD3 RID: 7123
			// (get) Token: 0x06004C60 RID: 19552 RVA: 0x0011952C File Offset: 0x0011772C
			// (set) Token: 0x06004C61 RID: 19553 RVA: 0x0002CF96 File Offset: 0x0002B196
			public unsafe Transform hitPlatform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_hitPlatform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_hitPlatform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD4 RID: 7124
			// (get) Token: 0x06004C62 RID: 19554 RVA: 0x0011955C File Offset: 0x0011775C
			// (set) Token: 0x06004C63 RID: 19555 RVA: 0x0002CFB5 File Offset: 0x0002B1B5
			public unsafe Transform activePlatform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activePlatform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activePlatform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD5 RID: 7125
			// (get) Token: 0x06004C64 RID: 19556 RVA: 0x0011958C File Offset: 0x0011778C
			// (set) Token: 0x06004C65 RID: 19557 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
			public unsafe Vector3 activeLocalPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeLocalPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeLocalPoint)) = value;
				}
			}

			// Token: 0x17001BD6 RID: 7126
			// (get) Token: 0x06004C66 RID: 19558 RVA: 0x001195B4 File Offset: 0x001177B4
			// (set) Token: 0x06004C67 RID: 19559 RVA: 0x0002CFEF File Offset: 0x0002B1EF
			public unsafe Vector3 activeGlobalPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeGlobalPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeGlobalPoint)) = value;
				}
			}

			// Token: 0x17001BD7 RID: 7127
			// (get) Token: 0x06004C68 RID: 19560 RVA: 0x001195DC File Offset: 0x001177DC
			// (set) Token: 0x06004C69 RID: 19561 RVA: 0x0002D00A File Offset: 0x0002B20A
			public unsafe Quaternion activeLocalRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeLocalRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeLocalRotation)) = value;
				}
			}

			// Token: 0x17001BD8 RID: 7128
			// (get) Token: 0x06004C6A RID: 19562 RVA: 0x00119604 File Offset: 0x00117804
			// (set) Token: 0x06004C6B RID: 19563 RVA: 0x0002D025 File Offset: 0x0002B225
			public unsafe Quaternion activeGlobalRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeGlobalRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_activeGlobalRotation)) = value;
				}
			}

			// Token: 0x17001BD9 RID: 7129
			// (get) Token: 0x06004C6C RID: 19564 RVA: 0x0011962C File Offset: 0x0011782C
			// (set) Token: 0x06004C6D RID: 19565 RVA: 0x0002D040 File Offset: 0x0002B240
			public unsafe Matrix4x4 lastMatrix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_lastMatrix);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_lastMatrix)) = value;
				}
			}

			// Token: 0x17001BDA RID: 7130
			// (get) Token: 0x06004C6E RID: 19566 RVA: 0x00119654 File Offset: 0x00117854
			// (set) Token: 0x06004C6F RID: 19567 RVA: 0x0002D05B File Offset: 0x0002B25B
			public unsafe Vector3 platformVelocity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_platformVelocity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_platformVelocity)) = value;
				}
			}

			// Token: 0x17001BDB RID: 7131
			// (get) Token: 0x06004C70 RID: 19568 RVA: 0x0011967C File Offset: 0x0011787C
			// (set) Token: 0x06004C71 RID: 19569 RVA: 0x0002D076 File Offset: 0x0002B276
			public unsafe bool newPlatform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_newPlatform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorMovingPlatform.NativeFieldInfoPtr_newPlatform)) = value;
				}
			}

			// Token: 0x04003209 RID: 12809
			private static readonly IntPtr NativeFieldInfoPtr_enabled;

			// Token: 0x0400320A RID: 12810
			private static readonly IntPtr NativeFieldInfoPtr_movementTransfer;

			// Token: 0x0400320B RID: 12811
			private static readonly IntPtr NativeFieldInfoPtr_hitPlatform;

			// Token: 0x0400320C RID: 12812
			private static readonly IntPtr NativeFieldInfoPtr_activePlatform;

			// Token: 0x0400320D RID: 12813
			private static readonly IntPtr NativeFieldInfoPtr_activeLocalPoint;

			// Token: 0x0400320E RID: 12814
			private static readonly IntPtr NativeFieldInfoPtr_activeGlobalPoint;

			// Token: 0x0400320F RID: 12815
			private static readonly IntPtr NativeFieldInfoPtr_activeLocalRotation;

			// Token: 0x04003210 RID: 12816
			private static readonly IntPtr NativeFieldInfoPtr_activeGlobalRotation;

			// Token: 0x04003211 RID: 12817
			private static readonly IntPtr NativeFieldInfoPtr_lastMatrix;

			// Token: 0x04003212 RID: 12818
			private static readonly IntPtr NativeFieldInfoPtr_platformVelocity;

			// Token: 0x04003213 RID: 12819
			private static readonly IntPtr NativeFieldInfoPtr_newPlatform;

			// Token: 0x04003214 RID: 12820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C9 RID: 713
		[Serializable]
		public class CharacterMotorSliding : global::Il2CppSystem.Object
		{
			// Token: 0x06004C72 RID: 19570 RVA: 0x001196A4 File Offset: 0x001178A4
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterMotorSliding()
			{
				Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "CharacterMotorSliding");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr);
				SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr, "enabled");
				SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_slidingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr, "slidingSpeed");
				SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_sidewaysControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr, "sidewaysControl");
				SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_speedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr, "speedControl");
				SECTR_CharacterMotor.CharacterMotorSliding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr, 100664400);
			}

			// Token: 0x06004C73 RID: 19571 RVA: 0x00119734 File Offset: 0x00117934
			[CallerCount(0)]
			public unsafe CharacterMotorSliding()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterMotor.CharacterMotorSliding>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor.CharacterMotorSliding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C74 RID: 19572 RVA: 0x0002D091 File Offset: 0x0002B291
			public CharacterMotorSliding(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BDC RID: 7132
			// (get) Token: 0x06004C75 RID: 19573 RVA: 0x00119770 File Offset: 0x00117970
			// (set) Token: 0x06004C76 RID: 19574 RVA: 0x0002D09A File Offset: 0x0002B29A
			public unsafe bool enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_enabled)) = value;
				}
			}

			// Token: 0x17001BDD RID: 7133
			// (get) Token: 0x06004C77 RID: 19575 RVA: 0x00119798 File Offset: 0x00117998
			// (set) Token: 0x06004C78 RID: 19576 RVA: 0x0002D0B5 File Offset: 0x0002B2B5
			public unsafe float slidingSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_slidingSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_slidingSpeed)) = value;
				}
			}

			// Token: 0x17001BDE RID: 7134
			// (get) Token: 0x06004C79 RID: 19577 RVA: 0x001197C0 File Offset: 0x001179C0
			// (set) Token: 0x06004C7A RID: 19578 RVA: 0x0002D0D0 File Offset: 0x0002B2D0
			public unsafe float sidewaysControl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_sidewaysControl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_sidewaysControl)) = value;
				}
			}

			// Token: 0x17001BDF RID: 7135
			// (get) Token: 0x06004C7B RID: 19579 RVA: 0x001197E8 File Offset: 0x001179E8
			// (set) Token: 0x06004C7C RID: 19580 RVA: 0x0002D0EB File Offset: 0x0002B2EB
			public unsafe float speedControl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_speedControl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor.CharacterMotorSliding.NativeFieldInfoPtr_speedControl)) = value;
				}
			}

			// Token: 0x04003215 RID: 12821
			private static readonly IntPtr NativeFieldInfoPtr_enabled;

			// Token: 0x04003216 RID: 12822
			private static readonly IntPtr NativeFieldInfoPtr_slidingSpeed;

			// Token: 0x04003217 RID: 12823
			private static readonly IntPtr NativeFieldInfoPtr_sidewaysControl;

			// Token: 0x04003218 RID: 12824
			private static readonly IntPtr NativeFieldInfoPtr_speedControl;

			// Token: 0x04003219 RID: 12825
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CA RID: 714
		[ObfuscatedName("SECTR_CharacterMotor+<SubtractNewPlatformVelocity>d__24")]
		public sealed class _SubtractNewPlatformVelocity_d__24 : global::Il2CppSystem.Object
		{
			// Token: 0x06004C7D RID: 19581 RVA: 0x00119810 File Offset: 0x00117A10
			// Note: this type is marked as 'beforefieldinit'.
			static _SubtractNewPlatformVelocity_d__24()
			{
				Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CharacterMotor>.NativeClassPtr, "<SubtractNewPlatformVelocity>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr);
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, "<>1__state");
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, "<>2__current");
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, "<>4__this");
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr__platform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, "<platform>5__2");
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, 100664401);
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, 100664402);
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, 100664403);
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, 100664404);
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, 100664405);
				SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr, 100664406);
			}

			// Token: 0x06004C7E RID: 19582 RVA: 0x00119904 File Offset: 0x00117B04
			[CallerCount(0)]
			public unsafe _SubtractNewPlatformVelocity_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C7F RID: 19583 RVA: 0x0011994C File Offset: 0x00117B4C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C80 RID: 19584 RVA: 0x00119980 File Offset: 0x00117B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42645, XrefRangeEnd = 42667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BE4 RID: 7140
			// (get) Token: 0x06004C81 RID: 19585 RVA: 0x001199BC File Offset: 0x00117BBC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004C82 RID: 19586 RVA: 0x001199FC File Offset: 0x00117BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42667, XrefRangeEnd = 42672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BE5 RID: 7141
			// (get) Token: 0x06004C83 RID: 19587 RVA: 0x00119A30 File Offset: 0x00117C30
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004C84 RID: 19588 RVA: 0x0002D106 File Offset: 0x0002B306
			public _SubtractNewPlatformVelocity_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BE0 RID: 7136
			// (get) Token: 0x06004C85 RID: 19589 RVA: 0x00119A70 File Offset: 0x00117C70
			// (set) Token: 0x06004C86 RID: 19590 RVA: 0x0002D10F File Offset: 0x0002B30F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BE1 RID: 7137
			// (get) Token: 0x06004C87 RID: 19591 RVA: 0x00119A98 File Offset: 0x00117C98
			// (set) Token: 0x06004C88 RID: 19592 RVA: 0x0002D12A File Offset: 0x0002B32A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE2 RID: 7138
			// (get) Token: 0x06004C89 RID: 19593 RVA: 0x00119AC8 File Offset: 0x00117CC8
			// (set) Token: 0x06004C8A RID: 19594 RVA: 0x0002D149 File Offset: 0x0002B349
			public unsafe SECTR_CharacterMotor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterMotor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE3 RID: 7139
			// (get) Token: 0x06004C8B RID: 19595 RVA: 0x00119AF8 File Offset: 0x00117CF8
			// (set) Token: 0x06004C8C RID: 19596 RVA: 0x0002D168 File Offset: 0x0002B368
			public unsafe Transform _platform_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr__platform_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterMotor._SubtractNewPlatformVelocity_d__24.NativeFieldInfoPtr__platform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400321A RID: 12826
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400321B RID: 12827
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400321C RID: 12828
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400321D RID: 12829
			private static readonly IntPtr NativeFieldInfoPtr__platform_5__2;

			// Token: 0x0400321E RID: 12830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400321F RID: 12831
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003220 RID: 12832
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003221 RID: 12833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003222 RID: 12834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003223 RID: 12835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
