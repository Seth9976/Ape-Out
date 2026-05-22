using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200006F RID: 111
	public class BabyMovement : MonoBehaviour
	{
		// Token: 0x06000E7E RID: 3710 RVA: 0x0005EDE8 File Offset: 0x0005CFE8
		// Note: this type is marked as 'beforefieldinit'.
		static BabyMovement()
		{
			Il2CppClassPointerStore<BabyMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BabyMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr);
			BabyMovement.NativeFieldInfoPtr_onApe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "onApe");
			BabyMovement.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "player");
			BabyMovement.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "velocity");
			BabyMovement.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "legs");
			BabyMovement.NativeFieldInfoPtr_handPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "handPos");
			BabyMovement.NativeFieldInfoPtr_shouldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "shouldPos");
			BabyMovement.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "renderers");
			BabyMovement.NativeFieldInfoPtr_truePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "truePos");
			BabyMovement.NativeFieldInfoPtr_bananaPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "bananaPos");
			BabyMovement.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, "me");
			BabyMovement.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, 100664546);
			BabyMovement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, 100664547);
			BabyMovement.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, 100664548);
			BabyMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr, 100664549);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0005EF30 File Offset: 0x0005D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45440, XrefRangeEnd = 45442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BabyMovement.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0005EF64 File Offset: 0x0005D164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45442, XrefRangeEnd = 45445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BabyMovement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0005EF98 File Offset: 0x0005D198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45445, XrefRangeEnd = 45575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BabyMovement.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0005EFCC File Offset: 0x0005D1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BabyMovement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BabyMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BabyMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0000AEC2 File Offset: 0x000090C2
		public BabyMovement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0005F008 File Offset: 0x0005D208
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0000AECB File Offset: 0x000090CB
		public unsafe bool onApe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_onApe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_onApe)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0005F030 File Offset: 0x0005D230
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x0000AEE6 File Offset: 0x000090E6
		public unsafe Transform player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0005F060 File Offset: 0x0005D260
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x0000AF05 File Offset: 0x00009105
		public unsafe Vector2 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0005F088 File Offset: 0x0005D288
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0000AF20 File Offset: 0x00009120
		public unsafe BabyLegs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BabyLegs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x0000AF3F File Offset: 0x0000913F
		public unsafe Vector2 handPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_handPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_handPos)) = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0005F0E0 File Offset: 0x0005D2E0
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x0000AF5A File Offset: 0x0000915A
		public unsafe Vector2 shouldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_shouldPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_shouldPos)) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0005F108 File Offset: 0x0005D308
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0000AF75 File Offset: 0x00009175
		public unsafe Il2CppReferenceArray<Renderer> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0005F138 File Offset: 0x0005D338
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x0000AF94 File Offset: 0x00009194
		public unsafe Vector2 truePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_truePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_truePos)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0005F160 File Offset: 0x0005D360
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x0000AFAF File Offset: 0x000091AF
		public unsafe Vector2 bananaPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_bananaPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BabyMovement.NativeFieldInfoPtr_bananaPos)) = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0005F188 File Offset: 0x0005D388
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0000AFCA File Offset: 0x000091CA
		public unsafe static BabyMovement me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BabyMovement.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BabyMovement>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BabyMovement.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_onApe;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_handPos;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_shouldPos;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_truePos;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_bananaPos;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
