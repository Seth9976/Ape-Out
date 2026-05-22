using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200005F RID: 95
	public class PanickingGorilla : MonoBehaviour
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x0005B3E4 File Offset: 0x000595E4
		// Note: this type is marked as 'beforefieldinit'.
		static PanickingGorilla()
		{
			Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PanickingGorilla");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr);
			PanickingGorilla.NativeFieldInfoPtr_ren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "ren");
			PanickingGorilla.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "state");
			PanickingGorilla.NativeFieldInfoPtr_pickupSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "pickupSprite");
			PanickingGorilla.NativeFieldInfoPtr_holdingSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "holdingSprite");
			PanickingGorilla.NativeFieldInfoPtr_idleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "idleSprite");
			PanickingGorilla.NativeFieldInfoPtr_throwSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "throwSprite");
			PanickingGorilla.NativeFieldInfoPtr_stateTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "stateTimer");
			PanickingGorilla.NativeFieldInfoPtr_barrelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "barrelPrefab");
			PanickingGorilla.NativeFieldInfoPtr_barrelSpawnPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "barrelSpawnPos");
			PanickingGorilla.NativeFieldInfoPtr_pickupSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "pickupSound");
			PanickingGorilla.NativeFieldInfoPtr_throwSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "throwSound");
			PanickingGorilla.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "source");
			PanickingGorilla.NativeFieldInfoPtr_rTrigSt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "rTrigSt");
			PanickingGorilla.NativeFieldInfoPtr_lTrigSt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "lTrigSt");
			PanickingGorilla.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, "controller");
			PanickingGorilla.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, 100664460);
			PanickingGorilla.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, 100664461);
			PanickingGorilla.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr, 100664462);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0005B57C File Offset: 0x0005977C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43718, XrefRangeEnd = 43732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanickingGorilla.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0005B5B0 File Offset: 0x000597B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43732, XrefRangeEnd = 43762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanickingGorilla.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0005B5E4 File Offset: 0x000597E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanickingGorilla()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanickingGorilla>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanickingGorilla.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00009DFD File Offset: 0x00007FFD
		public PanickingGorilla(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0005B620 File Offset: 0x00059820
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00009E06 File Offset: 0x00008006
		public unsafe SpriteRenderer ren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_ren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_ren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0005B650 File Offset: 0x00059850
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00009E25 File Offset: 0x00008025
		public unsafe int state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0005B678 File Offset: 0x00059878
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00009E40 File Offset: 0x00008040
		public unsafe Sprite pickupSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_pickupSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_pickupSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0005B6A8 File Offset: 0x000598A8
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00009E5F File Offset: 0x0000805F
		public unsafe Sprite holdingSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_holdingSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_holdingSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0005B6D8 File Offset: 0x000598D8
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00009E7E File Offset: 0x0000807E
		public unsafe Sprite idleSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_idleSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_idleSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0005B708 File Offset: 0x00059908
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00009E9D File Offset: 0x0000809D
		public unsafe Sprite throwSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_throwSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_throwSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0005B738 File Offset: 0x00059938
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00009EBC File Offset: 0x000080BC
		public unsafe float stateTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_stateTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_stateTimer)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0005B760 File Offset: 0x00059960
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00009ED7 File Offset: 0x000080D7
		public unsafe GameObject barrelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_barrelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_barrelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0005B790 File Offset: 0x00059990
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00009EF6 File Offset: 0x000080F6
		public unsafe Transform barrelSpawnPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_barrelSpawnPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_barrelSpawnPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0005B7C0 File Offset: 0x000599C0
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00009F15 File Offset: 0x00008115
		public unsafe AudioClip pickupSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_pickupSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_pickupSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0005B7F0 File Offset: 0x000599F0
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00009F34 File Offset: 0x00008134
		public unsafe AudioClip throwSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_throwSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_throwSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0005B820 File Offset: 0x00059A20
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00009F53 File Offset: 0x00008153
		public unsafe AudioSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0005B850 File Offset: 0x00059A50
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00009F72 File Offset: 0x00008172
		public unsafe float rTrigSt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_rTrigSt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_rTrigSt)) = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0005B878 File Offset: 0x00059A78
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00009F8D File Offset: 0x0000818D
		public unsafe float lTrigSt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_lTrigSt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_lTrigSt)) = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0005B8A0 File Offset: 0x00059AA0
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00009FA8 File Offset: 0x000081A8
		public unsafe Player controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanickingGorilla.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_ren;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_pickupSprite;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_holdingSprite;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_idleSprite;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_throwSprite;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_stateTimer;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_barrelPrefab;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_barrelSpawnPos;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_pickupSound;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_throwSound;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_rTrigSt;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_lTrigSt;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
