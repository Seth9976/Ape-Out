using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000009 RID: 9
	public static class DOVirtual : global::Il2CppSystem.Object
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00008314 File Offset: 0x00006514
		// Note: this type is marked as 'beforefieldinit'.
		static DOVirtual()
		{
			Il2CppClassPointerStore<DOVirtual>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "DOVirtual");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr);
			DOVirtual.NativeMethodInfoPtr_Float_Public_Static_Tweener_Single_Single_Single_TweenCallback_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663393);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663394);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663395);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663396);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663397);
			DOVirtual.NativeMethodInfoPtr_DelayedCall_Public_Static_Tween_Single_TweenCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663398);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000083BC File Offset: 0x000065BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118849, XrefRangeEnd = 118875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onVirtualUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_Float_Public_Static_Tweener_Single_Single_Single_TweenCallback_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000842C File Offset: 0x0000662C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118880, RefRangeEnd = 118885, XrefRangeStart = 118875, XrefRangeEnd = 118880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008494 File Offset: 0x00006694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118885, XrefRangeEnd = 118890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000850C File Offset: 0x0000670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118890, XrefRangeEnd = 118891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008590 File Offset: 0x00006790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118891, XrefRangeEnd = 118904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easeCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000085FC File Offset: 0x000067FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118904, XrefRangeEnd = 118917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_DelayedCall_Public_Static_Tween_Single_TweenCallback_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr3) : null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002280 File Offset: 0x00000480
		public DOVirtual(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Float_Public_Static_Tweener_Single_Single_Single_TweenCallback_1_Single_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_Single_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_AnimationCurve_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_DelayedCall_Public_Static_Tween_Single_TweenCallback_Boolean_0;

		// Token: 0x02000064 RID: 100
		[ObfuscatedName("DG.Tweening.DOVirtual+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005C9 RID: 1481 RVA: 0x0001FB98 File Offset: 0x0001DD98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr);
				DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, "val");
				DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_onVirtualUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, "onVirtualUpdate");
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663399);
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663400);
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663401);
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663402);
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0001FC3C File Offset: 0x0001DE3C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x0001FC78 File Offset: 0x0001DE78
			[CallerCount(0)]
			public unsafe float _Float_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
			[CallerCount(0)]
			public unsafe void _Float_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x0001FCF4 File Offset: 0x0001DEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118845, XrefRangeEnd = 118849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Float_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x00003E65 File Offset: 0x00002065
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001FD28 File Offset: 0x0001DF28
			// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00003E6E File Offset: 0x0000206E
			public unsafe float val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001FD50 File Offset: 0x0001DF50
			// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00003E89 File Offset: 0x00002089
			public unsafe TweenCallback<float> onVirtualUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_onVirtualUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_onVirtualUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x040004AD RID: 1197
			private static readonly IntPtr NativeFieldInfoPtr_onVirtualUpdate;

			// Token: 0x040004AE RID: 1198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004AF RID: 1199
			private static readonly IntPtr NativeMethodInfoPtr__Float_b__0_Internal_Single_0;

			// Token: 0x040004B0 RID: 1200
			private static readonly IntPtr NativeMethodInfoPtr__Float_b__1_Internal_Void_Single_0;

			// Token: 0x040004B1 RID: 1201
			private static readonly IntPtr NativeMethodInfoPtr__Float_b__2_Internal_Void_0;
		}
	}
}
