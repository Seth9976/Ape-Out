using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Core.Easing
{
	// Token: 0x0200005E RID: 94
	public class EaseCurve : global::Il2CppSystem.Object
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x0001F40C File Offset: 0x0001D60C
		// Note: this type is marked as 'beforefieldinit'.
		static EaseCurve()
		{
			Il2CppClassPointerStore<EaseCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "EaseCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr);
			EaseCurve.NativeFieldInfoPtr__animCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr, "_animCurve");
			EaseCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr, 100664364);
			EaseCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr, 100664365);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001F478 File Offset: 0x0001D678
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EaseCurve(AnimationCurve animCurve)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseCurve>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126282, XrefRangeEnd = 126288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershoot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public EaseCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001F538 File Offset: 0x0001D738
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00003DB9 File Offset: 0x00001FB9
		public unsafe AnimationCurve _animCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseCurve.NativeFieldInfoPtr__animCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseCurve.NativeFieldInfoPtr__animCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr__animCurve;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Single_Single_0;
	}
}
