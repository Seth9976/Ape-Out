using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000EF RID: 239
	public class GuardCollision : MonoBehaviour
	{
		// Token: 0x06001C62 RID: 7266 RVA: 0x000840A4 File Offset: 0x000822A4
		// Note: this type is marked as 'beforefieldinit'.
		static GuardCollision()
		{
			Il2CppClassPointerStore<GuardCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardCollision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr);
			GuardCollision.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "state");
			GuardCollision.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "player");
			GuardCollision.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "dead");
			GuardCollision.NativeFieldInfoPtr_mover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "mover");
			GuardCollision.NativeFieldInfoPtr_moveAwayArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "moveAwayArr");
			GuardCollision.NativeFieldInfoPtr_myTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "myTags");
			GuardCollision.NativeFieldInfoPtr_collisionRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "collisionRan");
			GuardCollision.NativeFieldInfoPtr_pushTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "pushTimer");
			GuardCollision.NativeFieldInfoPtr_wallColl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "wallColl");
			GuardCollision.NativeFieldInfoPtr_defWallColly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "defWallColly");
			GuardCollision.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "mask");
			GuardCollision.NativeFieldInfoPtr_enemyLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "enemyLayer");
			GuardCollision.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, "startRan");
			GuardCollision.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665605);
			GuardCollision.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665606);
			GuardCollision.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665607);
			GuardCollision.NativeMethodInfoPtr_LocallyAvoid_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665608);
			GuardCollision.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665609);
			GuardCollision.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665610);
			GuardCollision.NativeMethodInfoPtr_HitWall_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665611);
			GuardCollision.NativeMethodInfoPtr_HitOtherGuard_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665612);
			GuardCollision.NativeMethodInfoPtr_HitDude_Public_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665613);
			GuardCollision.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665614);
			GuardCollision.NativeMethodInfoPtr_SpawnLimbs_Public_Virtual_New_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665615);
			GuardCollision.NativeMethodInfoPtr_Spurt_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665616);
			GuardCollision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr, 100665617);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000842DC File Offset: 0x000824DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62938, XrefRangeEnd = 62949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00084318 File Offset: 0x00082518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62949, XrefRangeEnd = 62956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00084354 File Offset: 0x00082554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62990, RefRangeEnd = 62992, XrefRangeStart = 62956, XrefRangeEnd = 62990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00084390 File Offset: 0x00082590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63043, RefRangeEnd = 63044, XrefRangeStart = 62992, XrefRangeEnd = 63043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocallyAvoid(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardCollision.NativeMethodInfoPtr_LocallyAvoid_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x000843D0 File Offset: 0x000825D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63044, XrefRangeEnd = 63056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0008440C File Offset: 0x0008260C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63056, XrefRangeEnd = 63068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardCollision.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00084450 File Offset: 0x00082650
		[CallerCount(0)]
		public unsafe virtual void HitWall(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_HitWall_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0008449C File Offset: 0x0008269C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63068, XrefRangeEnd = 63076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitOtherGuard(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardCollision.NativeMethodInfoPtr_HitOtherGuard_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000844E0 File Offset: 0x000826E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63076, XrefRangeEnd = 63080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HitDude(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_HitDude_Public_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00084530 File Offset: 0x00082730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63239, RefRangeEnd = 63241, XrefRangeStart = 63080, XrefRangeEnd = 63239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Die(Vector2 pt, bool arms, bool hips, bool hitOther = false, bool diedByExplosion = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arms;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hips;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitOther;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref diedByExplosion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000845B4 File Offset: 0x000827B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63241, XrefRangeEnd = 63423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SpawnLimbs(Vector2 pt, bool hips)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hips;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardCollision.NativeMethodInfoPtr_SpawnLimbs_Public_Virtual_New_Void_Vector2_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0008460C File Offset: 0x0008280C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63423, XrefRangeEnd = 63440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spurt(bool three60)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref three60;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardCollision.NativeMethodInfoPtr_Spurt_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0008464C File Offset: 0x0008284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardCollision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardCollision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardCollision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0001403D File Offset: 0x0001223D
		public GuardCollision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00084688 File Offset: 0x00082888
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00014046 File Offset: 0x00012246
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000846B8 File Offset: 0x000828B8
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x00014065 File Offset: 0x00012265
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x000846E8 File Offset: 0x000828E8
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00014084 File Offset: 0x00012284
		public unsafe bool dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00084710 File Offset: 0x00082910
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0001409F File Offset: 0x0001229F
		public unsafe Mover mover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_mover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_mover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00084740 File Offset: 0x00082940
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x000140BE File Offset: 0x000122BE
		public unsafe Il2CppReferenceArray<Collider2D> moveAwayArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_moveAwayArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_moveAwayArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00084770 File Offset: 0x00082970
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x000140DD File Offset: 0x000122DD
		public unsafe Tags myTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_myTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_myTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000847A0 File Offset: 0x000829A0
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x000140FC File Offset: 0x000122FC
		public unsafe bool collisionRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_collisionRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_collisionRan)) = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x000847C8 File Offset: 0x000829C8
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x00014117 File Offset: 0x00012317
		public unsafe int pushTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_pushTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_pushTimer)) = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000847F0 File Offset: 0x000829F0
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x00014132 File Offset: 0x00012332
		public unsafe BoxCollider2D wallColl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_wallColl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_wallColl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00084820 File Offset: 0x00082A20
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x00014151 File Offset: 0x00012351
		public unsafe float defWallColly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_defWallColly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_defWallColly)) = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00084848 File Offset: 0x00082A48
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x0001416C File Offset: 0x0001236C
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00084870 File Offset: 0x00082A70
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00014187 File Offset: 0x00012387
		public unsafe int enemyLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_enemyLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_enemyLayer)) = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00084898 File Offset: 0x00082A98
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x000141A2 File Offset: 0x000123A2
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardCollision.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeFieldInfoPtr_mover;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeFieldInfoPtr_moveAwayArr;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_myTags;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_collisionRan;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_pushTimer;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_wallColl;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeFieldInfoPtr_defWallColly;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_enemyLayer;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_LocallyAvoid_Public_Void_Single_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_HitWall_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_HitOtherGuard_Public_Void_GameObject_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_HitDude_Public_Virtual_New_Void_GameObject_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_New_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_SpawnLimbs_Public_Virtual_New_Void_Vector2_Boolean_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_Spurt_Public_Void_Boolean_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
