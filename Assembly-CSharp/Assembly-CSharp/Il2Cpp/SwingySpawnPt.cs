using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C0 RID: 448
	public class SwingySpawnPt : MonoBehaviour
	{
		// Token: 0x0600314F RID: 12623 RVA: 0x000BC018 File Offset: 0x000BA218
		// Note: this type is marked as 'beforefieldinit'.
		static SwingySpawnPt()
		{
			Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwingySpawnPt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr);
			SwingySpawnPt.NativeFieldInfoPtr_guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "guard");
			SwingySpawnPt.NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "chance");
			SwingySpawnPt.NativeFieldInfoPtr_swingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "swingCurve");
			SwingySpawnPt.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "line");
			SwingySpawnPt.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "state");
			SwingySpawnPt.NativeFieldInfoPtr_botPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "botPos");
			SwingySpawnPt.NativeFieldInfoPtr_baselinePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "baselinePos");
			SwingySpawnPt.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, "startRan");
			SwingySpawnPt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, 100667158);
			SwingySpawnPt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, 100667159);
			SwingySpawnPt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr, 100667160);
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000BC124 File Offset: 0x000BA324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85290, RefRangeEnd = 85291, XrefRangeStart = 85211, XrefRangeEnd = 85290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingySpawnPt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000BC158 File Offset: 0x000BA358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85291, XrefRangeEnd = 85309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingySpawnPt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000BC18C File Offset: 0x000BA38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85309, XrefRangeEnd = 85312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwingySpawnPt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwingySpawnPt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwingySpawnPt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00021CFD File Offset: 0x0001FEFD
		public SwingySpawnPt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x000BC1C8 File Offset: 0x000BA3C8
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x00021D06 File Offset: 0x0001FF06
		public unsafe GameObject guard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_guard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_guard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x00021D25 File Offset: 0x0001FF25
		public unsafe float chance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_chance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_chance)) = value;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x000BC220 File Offset: 0x000BA420
		// (set) Token: 0x06003159 RID: 12633 RVA: 0x00021D40 File Offset: 0x0001FF40
		public unsafe AnimationCurve swingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_swingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_swingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x000BC250 File Offset: 0x000BA450
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x00021D5F File Offset: 0x0001FF5F
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x000BC280 File Offset: 0x000BA480
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x00021D7E File Offset: 0x0001FF7E
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x000BC2B0 File Offset: 0x000BA4B0
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x00021D9D File Offset: 0x0001FF9D
		public unsafe Vector3 botPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_botPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_botPos)) = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x000BC2D8 File Offset: 0x000BA4D8
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x00021DB8 File Offset: 0x0001FFB8
		public unsafe Vector3 baselinePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_baselinePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_baselinePos)) = value;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x000BC300 File Offset: 0x000BA500
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x00021DD3 File Offset: 0x0001FFD3
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwingySpawnPt.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeFieldInfoPtr_guard;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeFieldInfoPtr_chance;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeFieldInfoPtr_swingCurve;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeFieldInfoPtr_botPos;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr_baselinePos;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
