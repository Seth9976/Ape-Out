using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000063 RID: 99
	public class UnarmedGuard : MonoBehaviour
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x0005BD5C File Offset: 0x00059F5C
		// Note: this type is marked as 'beforefieldinit'.
		static UnarmedGuard()
		{
			Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnarmedGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr);
			UnarmedGuard.NativeFieldInfoPtr_frameScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "frameScale");
			UnarmedGuard.NativeFieldInfoPtr_ren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "ren");
			UnarmedGuard.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "state");
			UnarmedGuard.NativeFieldInfoPtr_nextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "nextState");
			UnarmedGuard.NativeFieldInfoPtr_jumpTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "jumpTimer");
			UnarmedGuard.NativeFieldInfoPtr_grounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "grounded");
			UnarmedGuard.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "col");
			UnarmedGuard.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "rb");
			UnarmedGuard.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "frame");
			UnarmedGuard.NativeFieldInfoPtr_animCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "animCounter");
			UnarmedGuard.NativeFieldInfoPtr_runAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "runAnim");
			UnarmedGuard.NativeFieldInfoPtr_jumpAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "jumpAnim");
			UnarmedGuard.NativeFieldInfoPtr_climbAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "climbAnim");
			UnarmedGuard.NativeFieldInfoPtr_climbEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "climbEnd");
			UnarmedGuard.NativeFieldInfoPtr_waitAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "waitAnim");
			UnarmedGuard.NativeFieldInfoPtr_winAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "winAnim");
			UnarmedGuard.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "path");
			UnarmedGuard.NativeFieldInfoPtr_currentTargetNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "currentTargetNode");
			UnarmedGuard.NativeFieldInfoPtr_prevNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "prevNode");
			UnarmedGuard.NativeFieldInfoPtr_targetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "targetIndex");
			UnarmedGuard.NativeFieldInfoPtr_particleDad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "particleDad");
			UnarmedGuard.NativeFieldInfoPtr_jumpOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "jumpOffsets");
			UnarmedGuard.NativeFieldInfoPtr_floorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "floorPos");
			UnarmedGuard.NativeFieldInfoPtr_splatSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "splatSound");
			UnarmedGuard.NativeFieldInfoPtr_jumpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "jumpSound");
			UnarmedGuard.NativeFieldInfoPtr_footStepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "footStepSounds");
			UnarmedGuard.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "source");
			UnarmedGuard.NativeFieldInfoPtr_jumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "jumpDuration");
			UnarmedGuard.NativeFieldInfoPtr_idleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "idleTimer");
			UnarmedGuard.NativeFieldInfoPtr_mouthLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "mouthLines");
			UnarmedGuard.NativeFieldInfoPtr_climbSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "climbSpeed");
			UnarmedGuard.NativeFieldInfoPtr_runSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, "runSpeed");
			UnarmedGuard.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, 100664468);
			UnarmedGuard.NativeMethodInfoPtr_Die_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, 100664469);
			UnarmedGuard.NativeMethodInfoPtr_LoadIt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, 100664470);
			UnarmedGuard.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, 100664471);
			UnarmedGuard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr, 100664472);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0005C070 File Offset: 0x0005A270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43875, XrefRangeEnd = 43907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnarmedGuard.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0005C0A4 File Offset: 0x0005A2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43938, RefRangeEnd = 43939, XrefRangeStart = 43907, XrefRangeEnd = 43938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die(Vector3 barrelVel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref barrelVel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnarmedGuard.NativeMethodInfoPtr_Die_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0005C0E4 File Offset: 0x0005A2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43939, XrefRangeEnd = 43943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnarmedGuard.NativeMethodInfoPtr_LoadIt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0005C118 File Offset: 0x0005A318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43943, XrefRangeEnd = 44047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnarmedGuard.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0005C14C File Offset: 0x0005A34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44047, XrefRangeEnd = 44056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnarmedGuard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnarmedGuard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnarmedGuard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0000A112 File Offset: 0x00008312
		public UnarmedGuard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0005C188 File Offset: 0x0005A388
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0000A11B File Offset: 0x0000831B
		public unsafe int frameScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_frameScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_frameScale)) = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x0000A136 File Offset: 0x00008336
		public unsafe SpriteRenderer ren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_ren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_ren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x0000A155 File Offset: 0x00008355
		public unsafe int state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0005C208 File Offset: 0x0005A408
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0000A170 File Offset: 0x00008370
		public unsafe int nextState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_nextState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_nextState)) = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0005C230 File Offset: 0x0005A430
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x0000A18B File Offset: 0x0000838B
		public unsafe int jumpTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpTimer)) = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0005C258 File Offset: 0x0005A458
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x0000A1A6 File Offset: 0x000083A6
		public unsafe bool grounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_grounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_grounded)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0005C280 File Offset: 0x0005A480
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0000A1C1 File Offset: 0x000083C1
		public unsafe BoxCollider2D col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0000A1E0 File Offset: 0x000083E0
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x0000A1FF File Offset: 0x000083FF
		public unsafe int frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_frame)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0005C308 File Offset: 0x0005A508
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x0000A21A File Offset: 0x0000841A
		public unsafe int animCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_animCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_animCounter)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0005C330 File Offset: 0x0005A530
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x0000A235 File Offset: 0x00008435
		public unsafe Il2CppReferenceArray<Sprite> runAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_runAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_runAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0005C360 File Offset: 0x0005A560
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x0000A254 File Offset: 0x00008454
		public unsafe Il2CppReferenceArray<Sprite> jumpAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0005C390 File Offset: 0x0005A590
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x0000A273 File Offset: 0x00008473
		public unsafe Il2CppReferenceArray<Sprite> climbAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_climbAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_climbAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0005C3C0 File Offset: 0x0005A5C0
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x0000A292 File Offset: 0x00008492
		public unsafe Il2CppReferenceArray<Sprite> climbEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_climbEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_climbEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0005C3F0 File Offset: 0x0005A5F0
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0000A2B1 File Offset: 0x000084B1
		public unsafe Il2CppReferenceArray<Sprite> waitAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_waitAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_waitAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0005C420 File Offset: 0x0005A620
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public unsafe Il2CppReferenceArray<Sprite> winAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_winAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_winAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0005C450 File Offset: 0x0005A650
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0000A2EF File Offset: 0x000084EF
		public unsafe Il2CppReferenceArray<PathNode> path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0005C480 File Offset: 0x0005A680
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x0000A30E File Offset: 0x0000850E
		public unsafe PathNode currentTargetNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_currentTargetNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_currentTargetNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0005C4B0 File Offset: 0x0005A6B0
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x0000A32D File Offset: 0x0000852D
		public unsafe PathNode prevNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_prevNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_prevNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0005C4E0 File Offset: 0x0005A6E0
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x0000A34C File Offset: 0x0000854C
		public unsafe int targetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_targetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_targetIndex)) = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0005C508 File Offset: 0x0005A708
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0000A367 File Offset: 0x00008567
		public unsafe GameObject particleDad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_particleDad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_particleDad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0005C538 File Offset: 0x0005A738
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x0000A386 File Offset: 0x00008586
		public unsafe Il2CppStructArray<int> jumpOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpOffsets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0005C568 File Offset: 0x0005A768
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x0000A3A5 File Offset: 0x000085A5
		public unsafe Vector3 floorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_floorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_floorPos)) = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x0005C590 File Offset: 0x0005A790
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x0000A3C0 File Offset: 0x000085C0
		public unsafe AudioClip splatSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_splatSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_splatSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0000A3DF File Offset: 0x000085DF
		public unsafe AudioClip jumpSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0005C5F0 File Offset: 0x0005A7F0
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0000A3FE File Offset: 0x000085FE
		public unsafe Il2CppReferenceArray<AudioClip> footStepSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_footStepSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_footStepSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0005C620 File Offset: 0x0005A820
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0000A41D File Offset: 0x0000861D
		public unsafe AudioSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0005C650 File Offset: 0x0005A850
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0000A43C File Offset: 0x0000863C
		public unsafe int jumpDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_jumpDuration)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0005C678 File Offset: 0x0005A878
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0000A457 File Offset: 0x00008657
		public unsafe int idleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_idleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_idleTimer)) = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x0000A472 File Offset: 0x00008672
		public unsafe GameObject mouthLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_mouthLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_mouthLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x0000A491 File Offset: 0x00008691
		public unsafe float climbSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_climbSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_climbSpeed)) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x0005C6F8 File Offset: 0x0005A8F8
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x0000A4AC File Offset: 0x000086AC
		public unsafe float runSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_runSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnarmedGuard.NativeFieldInfoPtr_runSpeed)) = value;
			}
		}

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_frameScale;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_ren;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_nextState;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_jumpTimer;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_grounded;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_frame;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_animCounter;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_runAnim;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_jumpAnim;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_climbAnim;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_climbEnd;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr_waitAnim;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr_winAnim;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr_currentTargetNode;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_prevNode;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr_targetIndex;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr_particleDad;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_jumpOffsets;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_floorPos;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_splatSound;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_jumpSound;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_footStepSounds;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_jumpDuration;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_idleTimer;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_mouthLines;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_climbSpeed;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_runSpeed;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Void_Vector3_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_LoadIt_Private_Void_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
