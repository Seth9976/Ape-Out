using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000EC RID: 236
	public class GuardAttacking : GuardMode
	{
		// Token: 0x06001C1B RID: 7195 RVA: 0x0008357C File Offset: 0x0008177C
		// Note: this type is marked as 'beforefieldinit'.
		static GuardAttacking()
		{
			Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardAttacking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr);
			GuardAttacking.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "gun");
			GuardAttacking.NativeFieldInfoPtr_strafeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "strafeSpeed");
			GuardAttacking.NativeFieldInfoPtr_desDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "desDist");
			GuardAttacking.NativeFieldInfoPtr_circRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "circRad");
			GuardAttacking.NativeFieldInfoPtr_stateTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "stateTransform");
			GuardAttacking.NativeFieldInfoPtr_enemyMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "enemyMask");
			GuardAttacking.NativeFieldInfoPtr_obstacleMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "obstacleMask");
			GuardAttacking.NativeFieldInfoPtr_glassMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "glassMask");
			GuardAttacking.NativeFieldInfoPtr_grabMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "grabMask");
			GuardAttacking.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "targetPos");
			GuardAttacking.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "myPos");
			GuardAttacking.NativeFieldInfoPtr_gunPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "gunPos");
			GuardAttacking.NativeFieldInfoPtr_gunVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "gunVect");
			GuardAttacking.NativeFieldInfoPtr_rVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "rVect");
			GuardAttacking.NativeFieldInfoPtr_toTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "toTarget");
			GuardAttacking.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "hit");
			GuardAttacking.NativeFieldInfoPtr_ignoreRaycastLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "ignoreRaycastLayer");
			GuardAttacking.NativeFieldInfoPtr_stateObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "stateObj");
			GuardAttacking.NativeFieldInfoPtr_shimmied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, "shimmied");
			GuardAttacking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665592);
			GuardAttacking.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665593);
			GuardAttacking.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665594);
			GuardAttacking.NativeMethodInfoPtr_Move_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665595);
			GuardAttacking.NativeMethodInfoPtr_GuardShimmy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665596);
			GuardAttacking.NativeMethodInfoPtr_GlassShimmy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665597);
			GuardAttacking.NativeMethodInfoPtr_ShieldCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr, 100665598);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000837B4 File Offset: 0x000819B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 62693, RefRangeEnd = 62699, XrefRangeStart = 62642, XrefRangeEnd = 62693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardAttacking(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardAttacking>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAttacking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0008381C File Offset: 0x00081A1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 62714, RefRangeEnd = 62717, XrefRangeStart = 62699, XrefRangeEnd = 62714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardAttacking.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00083858 File Offset: 0x00081A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62741, RefRangeEnd = 62742, XrefRangeStart = 62717, XrefRangeEnd = 62741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardAttacking.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00083894 File Offset: 0x00081A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62776, RefRangeEnd = 62777, XrefRangeStart = 62742, XrefRangeEnd = 62776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardAttacking.NativeMethodInfoPtr_Move_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000838D0 File Offset: 0x00081AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62813, RefRangeEnd = 62814, XrefRangeStart = 62777, XrefRangeEnd = 62813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuardShimmy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAttacking.NativeMethodInfoPtr_GuardShimmy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00083904 File Offset: 0x00081B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62814, XrefRangeEnd = 62832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GlassShimmy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardAttacking.NativeMethodInfoPtr_GlassShimmy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00083940 File Offset: 0x00081B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62855, RefRangeEnd = 62856, XrefRangeStart = 62832, XrefRangeEnd = 62855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShieldCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardAttacking.NativeMethodInfoPtr_ShieldCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00013D58 File Offset: 0x00011F58
		public GuardAttacking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00083974 File Offset: 0x00081B74
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00013D61 File Offset: 0x00011F61
		public unsafe GuardGun gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardGun>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000839A4 File Offset: 0x00081BA4
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00013D80 File Offset: 0x00011F80
		public unsafe float strafeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_strafeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_strafeSpeed)) = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000839CC File Offset: 0x00081BCC
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00013D9B File Offset: 0x00011F9B
		public unsafe float desDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_desDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_desDist)) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000839F4 File Offset: 0x00081BF4
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00013DB6 File Offset: 0x00011FB6
		public unsafe float circRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_circRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_circRad)) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00083A1C File Offset: 0x00081C1C
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00013DD1 File Offset: 0x00011FD1
		public unsafe Transform stateTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_stateTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_stateTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00083A4C File Offset: 0x00081C4C
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00013DF0 File Offset: 0x00011FF0
		public unsafe int enemyMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_enemyMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_enemyMask)) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00083A74 File Offset: 0x00081C74
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x00013E0B File Offset: 0x0001200B
		public unsafe int obstacleMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_obstacleMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_obstacleMask)) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00083A9C File Offset: 0x00081C9C
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00013E26 File Offset: 0x00012026
		public unsafe int glassMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_glassMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_glassMask)) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00083AC4 File Offset: 0x00081CC4
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x00013E41 File Offset: 0x00012041
		public unsafe int grabMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_grabMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_grabMask)) = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00083AEC File Offset: 0x00081CEC
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00013E5C File Offset: 0x0001205C
		public unsafe Vector2 targetPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_targetPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_targetPos)) = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00083B14 File Offset: 0x00081D14
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00013E77 File Offset: 0x00012077
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00083B3C File Offset: 0x00081D3C
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x00013E92 File Offset: 0x00012092
		public unsafe Vector2 gunPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_gunPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_gunPos)) = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00083B64 File Offset: 0x00081D64
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x00013EAD File Offset: 0x000120AD
		public unsafe Vector2 gunVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_gunVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_gunVect)) = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00083B8C File Offset: 0x00081D8C
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00013EC8 File Offset: 0x000120C8
		public unsafe Vector2 rVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_rVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_rVect)) = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00083BB4 File Offset: 0x00081DB4
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00013EE3 File Offset: 0x000120E3
		public unsafe Vector2 toTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_toTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_toTarget)) = value;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00083BDC File Offset: 0x00081DDC
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00013EFE File Offset: 0x000120FE
		public unsafe RaycastHit2D hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_hit)) = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00083C04 File Offset: 0x00081E04
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x00013F19 File Offset: 0x00012119
		public unsafe int ignoreRaycastLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_ignoreRaycastLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_ignoreRaycastLayer)) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00083C2C File Offset: 0x00081E2C
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x00013F34 File Offset: 0x00012134
		public unsafe GameObject stateObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_stateObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_stateObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00083C5C File Offset: 0x00081E5C
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x00013F53 File Offset: 0x00012153
		public unsafe bool shimmied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_shimmied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardAttacking.NativeFieldInfoPtr_shimmied)) = value;
			}
		}

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_strafeSpeed;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr_desDist;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_circRad;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_stateTransform;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_enemyMask;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_obstacleMask;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr_glassMask;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_grabMask;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_targetPos;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeFieldInfoPtr_gunPos;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr_gunVect;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr_rVect;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_toTarget;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr_ignoreRaycastLayer;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_stateObj;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_shimmied;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Virtual_New_Void_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_GuardShimmy_Public_Void_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_GlassShimmy_Public_Virtual_New_Void_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_ShieldCheck_Public_Void_0;
	}
}
