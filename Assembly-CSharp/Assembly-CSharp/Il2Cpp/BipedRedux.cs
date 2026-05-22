using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200007B RID: 123
	public class BipedRedux : MonoBehaviour
	{
		// Token: 0x06001017 RID: 4119 RVA: 0x00063230 File Offset: 0x00061430
		// Note: this type is marked as 'beforefieldinit'.
		static BipedRedux()
		{
			Il2CppClassPointerStore<BipedRedux>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BipedRedux");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr);
			BipedRedux.NativeFieldInfoPtr_shoulders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "shoulders");
			BipedRedux.NativeFieldInfoPtr_hips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "hips");
			BipedRedux.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "head");
			BipedRedux.NativeFieldInfoPtr_defHeadPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "defHeadPos");
			BipedRedux.NativeFieldInfoPtr_defShoulderPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "defShoulderPos");
			BipedRedux.NativeFieldInfoPtr_defHipsPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "defHipsPos");
			BipedRedux.NativeFieldInfoPtr_shoulderParalax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "shoulderParalax");
			BipedRedux.NativeFieldInfoPtr_hipParalax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "hipParalax");
			BipedRedux.NativeFieldInfoPtr_headParalax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "headParalax");
			BipedRedux.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "state");
			BipedRedux.NativeFieldInfoPtr_lean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "lean");
			BipedRedux.NativeFieldInfoPtr_curLean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "curLean");
			BipedRedux.NativeFieldInfoPtr_leanVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "leanVel");
			BipedRedux.NativeFieldInfoPtr_trueHipsPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "trueHipsPos");
			BipedRedux.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "myPos");
			BipedRedux.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "trans");
			BipedRedux.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, "position");
			BipedRedux.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, 100664659);
			BipedRedux.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, 100664660);
			BipedRedux.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, 100664661);
			BipedRedux.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr, 100664662);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00063404 File Offset: 0x00061604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47787, XrefRangeEnd = 47813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BipedRedux.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00063438 File Offset: 0x00061638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47813, XrefRangeEnd = 47833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BipedRedux.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0006346C File Offset: 0x0006166C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47833, XrefRangeEnd = 47873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BipedRedux.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000634A0 File Offset: 0x000616A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BipedRedux()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BipedRedux>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BipedRedux.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0000BEFF File Offset: 0x0000A0FF
		public BipedRedux(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x000634DC File Offset: 0x000616DC
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x0000BF08 File Offset: 0x0000A108
		public unsafe Transform shoulders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_shoulders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_shoulders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x0006350C File Offset: 0x0006170C
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x0000BF27 File Offset: 0x0000A127
		public unsafe Transform hips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_hips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_hips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0006353C File Offset: 0x0006173C
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x0000BF46 File Offset: 0x0000A146
		public unsafe Transform head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0006356C File Offset: 0x0006176C
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x0000BF65 File Offset: 0x0000A165
		public unsafe Vector3 defHeadPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_defHeadPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_defHeadPos)) = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00063594 File Offset: 0x00061794
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x0000BF80 File Offset: 0x0000A180
		public unsafe Vector3 defShoulderPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_defShoulderPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_defShoulderPos)) = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x000635BC File Offset: 0x000617BC
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x0000BF9B File Offset: 0x0000A19B
		public unsafe Vector3 defHipsPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_defHipsPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_defHipsPos)) = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x000635E4 File Offset: 0x000617E4
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x0000BFB6 File Offset: 0x0000A1B6
		public unsafe float shoulderParalax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_shoulderParalax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_shoulderParalax)) = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0006360C File Offset: 0x0006180C
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x0000BFD1 File Offset: 0x0000A1D1
		public unsafe float hipParalax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_hipParalax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_hipParalax)) = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00063634 File Offset: 0x00061834
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public unsafe float headParalax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_headParalax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_headParalax)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0006365C File Offset: 0x0006185C
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x0000C007 File Offset: 0x0000A207
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0006368C File Offset: 0x0006188C
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0000C026 File Offset: 0x0000A226
		public unsafe float lean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_lean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_lean)) = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x000636B4 File Offset: 0x000618B4
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x0000C041 File Offset: 0x0000A241
		public unsafe Vector2 curLean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_curLean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_curLean)) = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x000636DC File Offset: 0x000618DC
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x0000C05C File Offset: 0x0000A25C
		public unsafe Vector2 leanVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_leanVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_leanVel)) = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00063704 File Offset: 0x00061904
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x0000C077 File Offset: 0x0000A277
		public unsafe Vector2 trueHipsPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_trueHipsPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_trueHipsPos)) = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0006372C File Offset: 0x0006192C
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x0000C092 File Offset: 0x0000A292
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00063754 File Offset: 0x00061954
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0000C0AD File Offset: 0x0000A2AD
		public unsafe Transform trans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_trans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00063784 File Offset: 0x00061984
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BipedRedux.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr_shoulders;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr_hips;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_defHeadPos;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_defShoulderPos;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_defHipsPos;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_shoulderParalax;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_hipParalax;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_headParalax;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_lean;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_curLean;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_leanVel;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_trueHipsPos;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr_trans;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
