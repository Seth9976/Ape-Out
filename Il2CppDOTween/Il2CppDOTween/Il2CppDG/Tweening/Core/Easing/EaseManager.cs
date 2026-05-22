using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core.Easing
{
	// Token: 0x0200005D RID: 93
	public static class EaseManager : Object
	{
		// Token: 0x0600059D RID: 1437 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		// Note: this type is marked as 'beforefieldinit'.
		static EaseManager()
		{
			Il2CppClassPointerStore<EaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "EaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseManager>.NativeClassPtr);
			EaseManager.NativeFieldInfoPtr__PiOver2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, "_PiOver2");
			EaseManager.NativeFieldInfoPtr__TwoPi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, "_TwoPi");
			EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Tween_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664322);
			EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Ease_EaseFunction_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664323);
			EaseManager.NativeMethodInfoPtr_ToEaseFunction_Public_Static_EaseFunction_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664324);
			EaseManager.NativeMethodInfoPtr_IsFlashEase_Internal_Static_Boolean_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664325);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0001F250 File Offset: 0x0001D450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126091, XrefRangeEnd = 126092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Tween_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 126208, RefRangeEnd = 126234, XrefRangeStart = 126092, XrefRangeEnd = 126208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref easeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customEase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Ease_EaseFunction_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001F354 File Offset: 0x0001D554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126281, RefRangeEnd = 126282, XrefRangeStart = 126234, XrefRangeEnd = 126281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction ToEaseFunction(Ease ease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ease;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_ToEaseFunction_Public_Static_EaseFunction_Ease_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001F394 File Offset: 0x0001D594
		[CallerCount(0)]
		public unsafe static bool IsFlashEase(Ease ease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ease;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_IsFlashEase_Internal_Static_Boolean_Ease_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00003D8B File Offset: 0x00001F8B
		public EaseManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00003D94 File Offset: 0x00001F94
		public unsafe static float _PiOver2
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(EaseManager.NativeFieldInfoPtr__PiOver2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EaseManager.NativeFieldInfoPtr__PiOver2, (void*)(&value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00003DA2 File Offset: 0x00001FA2
		public unsafe static float _TwoPi
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(EaseManager.NativeFieldInfoPtr__TwoPi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EaseManager.NativeFieldInfoPtr__TwoPi, (void*)(&value));
			}
		}

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr__PiOver2;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr__TwoPi;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_Tween_Single_Single_Single_Single_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_Ease_EaseFunction_Single_Single_Single_Single_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_ToEaseFunction_Public_Static_EaseFunction_Ease_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_IsFlashEase_Internal_Static_Boolean_Ease_0;

		// Token: 0x020000F4 RID: 244
		[ObfuscatedName("DG.Tweening.Core.Easing.EaseManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060008E6 RID: 2278 RVA: 0x00029D18 File Offset: 0x00027F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr);
				EaseManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9");
				EaseManager.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_0");
				EaseManager.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_1");
				EaseManager.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_2");
				EaseManager.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_3");
				EaseManager.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_4");
				EaseManager.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_5");
				EaseManager.__c.NativeFieldInfoPtr___9__4_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_6");
				EaseManager.__c.NativeFieldInfoPtr___9__4_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_7");
				EaseManager.__c.NativeFieldInfoPtr___9__4_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_8");
				EaseManager.__c.NativeFieldInfoPtr___9__4_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_9");
				EaseManager.__c.NativeFieldInfoPtr___9__4_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_10");
				EaseManager.__c.NativeFieldInfoPtr___9__4_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_11");
				EaseManager.__c.NativeFieldInfoPtr___9__4_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_12");
				EaseManager.__c.NativeFieldInfoPtr___9__4_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_13");
				EaseManager.__c.NativeFieldInfoPtr___9__4_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_14");
				EaseManager.__c.NativeFieldInfoPtr___9__4_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_15");
				EaseManager.__c.NativeFieldInfoPtr___9__4_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_16");
				EaseManager.__c.NativeFieldInfoPtr___9__4_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_17");
				EaseManager.__c.NativeFieldInfoPtr___9__4_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_18");
				EaseManager.__c.NativeFieldInfoPtr___9__4_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_19");
				EaseManager.__c.NativeFieldInfoPtr___9__4_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_20");
				EaseManager.__c.NativeFieldInfoPtr___9__4_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_21");
				EaseManager.__c.NativeFieldInfoPtr___9__4_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_22");
				EaseManager.__c.NativeFieldInfoPtr___9__4_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_23");
				EaseManager.__c.NativeFieldInfoPtr___9__4_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_24");
				EaseManager.__c.NativeFieldInfoPtr___9__4_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_25");
				EaseManager.__c.NativeFieldInfoPtr___9__4_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_26");
				EaseManager.__c.NativeFieldInfoPtr___9__4_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_27");
				EaseManager.__c.NativeFieldInfoPtr___9__4_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_28");
				EaseManager.__c.NativeFieldInfoPtr___9__4_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_29");
				EaseManager.__c.NativeFieldInfoPtr___9__4_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_30");
				EaseManager.__c.NativeFieldInfoPtr___9__4_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_31");
				EaseManager.__c.NativeFieldInfoPtr___9__4_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_32");
				EaseManager.__c.NativeFieldInfoPtr___9__4_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_33");
				EaseManager.__c.NativeFieldInfoPtr___9__4_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_34");
				EaseManager.__c.NativeFieldInfoPtr___9__4_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_35");
				EaseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664327);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_0_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664328);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_1_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664329);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_2_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664330);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_3_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664331);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_4_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664332);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_5_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664333);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_6_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664334);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_7_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664335);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_8_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664336);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_9_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664337);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_10_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664338);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_11_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664339);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_12_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664340);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_13_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664341);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_14_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664342);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_15_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664343);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_16_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664344);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_17_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664345);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_18_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664346);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_19_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664347);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_20_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664348);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_21_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664349);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_22_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664350);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_23_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664351);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_24_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664352);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_25_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664353);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_26_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664354);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_27_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664355);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_28_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664356);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_29_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664357);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_30_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664358);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_31_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664359);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_32_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664360);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_33_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664361);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_34_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664362);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_35_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664363);
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x0002A30C File Offset: 0x0002850C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008E8 RID: 2280 RVA: 0x0002A348 File Offset: 0x00028548
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_0(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_0_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008E9 RID: 2281 RVA: 0x0002A3BC File Offset: 0x000285BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126019, XrefRangeEnd = 126023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_1(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_1_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x0002A430 File Offset: 0x00028630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126023, XrefRangeEnd = 126027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_2(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_2_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008EB RID: 2283 RVA: 0x0002A4A4 File Offset: 0x000286A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126027, XrefRangeEnd = 126031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_3(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_3_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008EC RID: 2284 RVA: 0x0002A518 File Offset: 0x00028718
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_4(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_4_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x0002A58C File Offset: 0x0002878C
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_5(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_5_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008EE RID: 2286 RVA: 0x0002A600 File Offset: 0x00028800
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_6(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_6_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x0002A674 File Offset: 0x00028874
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_7(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_7_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x0002A6E8 File Offset: 0x000288E8
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_8(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_8_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x0002A75C File Offset: 0x0002895C
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_9(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_9_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F2 RID: 2290 RVA: 0x0002A7D0 File Offset: 0x000289D0
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_10(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_10_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F3 RID: 2291 RVA: 0x0002A844 File Offset: 0x00028A44
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_11(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_11_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F4 RID: 2292 RVA: 0x0002A8B8 File Offset: 0x00028AB8
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_12(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_12_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F5 RID: 2293 RVA: 0x0002A92C File Offset: 0x00028B2C
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_13(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_13_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x0002A9A0 File Offset: 0x00028BA0
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_14(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_14_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x0002AA14 File Offset: 0x00028C14
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_15(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_15_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x0002AA88 File Offset: 0x00028C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126031, XrefRangeEnd = 126035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_16(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_16_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x0002AAFC File Offset: 0x00028CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126035, XrefRangeEnd = 126036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_17(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_17_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008FA RID: 2298 RVA: 0x0002AB70 File Offset: 0x00028D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126036, XrefRangeEnd = 126037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_18(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_18_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008FB RID: 2299 RVA: 0x0002ABE4 File Offset: 0x00028DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126037, XrefRangeEnd = 126042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_19(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_19_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008FC RID: 2300 RVA: 0x0002AC58 File Offset: 0x00028E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126042, XrefRangeEnd = 126045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_20(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_20_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x0002ACCC File Offset: 0x00028ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126045, XrefRangeEnd = 126050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_21(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_21_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x0002AD40 File Offset: 0x00028F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126050, XrefRangeEnd = 126059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_22(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_22_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x0002ADB4 File Offset: 0x00028FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126059, XrefRangeEnd = 126069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_23(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_23_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x0002AE28 File Offset: 0x00029028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126069, XrefRangeEnd = 126084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_24(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_24_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000901 RID: 2305 RVA: 0x0002AE9C File Offset: 0x0002909C
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_25(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_25_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000902 RID: 2306 RVA: 0x0002AF10 File Offset: 0x00029110
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_26(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_26_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000903 RID: 2307 RVA: 0x0002AF84 File Offset: 0x00029184
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_27(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_27_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000904 RID: 2308 RVA: 0x0002AFF8 File Offset: 0x000291F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126084, XrefRangeEnd = 126085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_28(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_28_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x0002B06C File Offset: 0x0002926C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126085, XrefRangeEnd = 126086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_29(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_29_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x0002B0E0 File Offset: 0x000292E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126086, XrefRangeEnd = 126087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_30(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_30_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x0002B154 File Offset: 0x00029354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126087, XrefRangeEnd = 126088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_31(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_31_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x0002B1C8 File Offset: 0x000293C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126088, XrefRangeEnd = 126089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_32(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_32_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x0002B23C File Offset: 0x0002943C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126089, XrefRangeEnd = 126090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_33(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_33_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x0002B2B0 File Offset: 0x000294B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126090, XrefRangeEnd = 126091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_34(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_34_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x0002B324 File Offset: 0x00029524
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_35(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_35_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x00005210 File Offset: 0x00003410
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x0600090D RID: 2317 RVA: 0x0002B398 File Offset: 0x00029598
			// (set) Token: 0x0600090E RID: 2318 RVA: 0x00005219 File Offset: 0x00003419
			public unsafe static EaseManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002B3C0 File Offset: 0x000295C0
			// (set) Token: 0x06000910 RID: 2320 RVA: 0x0000522B File Offset: 0x0000342B
			public unsafe static EaseFunction __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06000911 RID: 2321 RVA: 0x0002B3E8 File Offset: 0x000295E8
			// (set) Token: 0x06000912 RID: 2322 RVA: 0x0000523D File Offset: 0x0000343D
			public unsafe static EaseFunction __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x06000913 RID: 2323 RVA: 0x0002B410 File Offset: 0x00029610
			// (set) Token: 0x06000914 RID: 2324 RVA: 0x0000524F File Offset: 0x0000344F
			public unsafe static EaseFunction __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x06000915 RID: 2325 RVA: 0x0002B438 File Offset: 0x00029638
			// (set) Token: 0x06000916 RID: 2326 RVA: 0x00005261 File Offset: 0x00003461
			public unsafe static EaseFunction __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06000917 RID: 2327 RVA: 0x0002B460 File Offset: 0x00029660
			// (set) Token: 0x06000918 RID: 2328 RVA: 0x00005273 File Offset: 0x00003473
			public unsafe static EaseFunction __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002B488 File Offset: 0x00029688
			// (set) Token: 0x0600091A RID: 2330 RVA: 0x00005285 File Offset: 0x00003485
			public unsafe static EaseFunction __9__4_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002B4B0 File Offset: 0x000296B0
			// (set) Token: 0x0600091C RID: 2332 RVA: 0x00005297 File Offset: 0x00003497
			public unsafe static EaseFunction __9__4_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002B4D8 File Offset: 0x000296D8
			// (set) Token: 0x0600091E RID: 2334 RVA: 0x000052A9 File Offset: 0x000034A9
			public unsafe static EaseFunction __9__4_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x0600091F RID: 2335 RVA: 0x0002B500 File Offset: 0x00029700
			// (set) Token: 0x06000920 RID: 2336 RVA: 0x000052BB File Offset: 0x000034BB
			public unsafe static EaseFunction __9__4_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x06000921 RID: 2337 RVA: 0x0002B528 File Offset: 0x00029728
			// (set) Token: 0x06000922 RID: 2338 RVA: 0x000052CD File Offset: 0x000034CD
			public unsafe static EaseFunction __9__4_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000923 RID: 2339 RVA: 0x0002B550 File Offset: 0x00029750
			// (set) Token: 0x06000924 RID: 2340 RVA: 0x000052DF File Offset: 0x000034DF
			public unsafe static EaseFunction __9__4_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000925 RID: 2341 RVA: 0x0002B578 File Offset: 0x00029778
			// (set) Token: 0x06000926 RID: 2342 RVA: 0x000052F1 File Offset: 0x000034F1
			public unsafe static EaseFunction __9__4_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002B5A0 File Offset: 0x000297A0
			// (set) Token: 0x06000928 RID: 2344 RVA: 0x00005303 File Offset: 0x00003503
			public unsafe static EaseFunction __9__4_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002B5C8 File Offset: 0x000297C8
			// (set) Token: 0x0600092A RID: 2346 RVA: 0x00005315 File Offset: 0x00003515
			public unsafe static EaseFunction __9__4_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x0600092B RID: 2347 RVA: 0x0002B5F0 File Offset: 0x000297F0
			// (set) Token: 0x0600092C RID: 2348 RVA: 0x00005327 File Offset: 0x00003527
			public unsafe static EaseFunction __9__4_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x0600092D RID: 2349 RVA: 0x0002B618 File Offset: 0x00029818
			// (set) Token: 0x0600092E RID: 2350 RVA: 0x00005339 File Offset: 0x00003539
			public unsafe static EaseFunction __9__4_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002B640 File Offset: 0x00029840
			// (set) Token: 0x06000930 RID: 2352 RVA: 0x0000534B File Offset: 0x0000354B
			public unsafe static EaseFunction __9__4_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x06000931 RID: 2353 RVA: 0x0002B668 File Offset: 0x00029868
			// (set) Token: 0x06000932 RID: 2354 RVA: 0x0000535D File Offset: 0x0000355D
			public unsafe static EaseFunction __9__4_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x06000933 RID: 2355 RVA: 0x0002B690 File Offset: 0x00029890
			// (set) Token: 0x06000934 RID: 2356 RVA: 0x0000536F File Offset: 0x0000356F
			public unsafe static EaseFunction __9__4_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000935 RID: 2357 RVA: 0x0002B6B8 File Offset: 0x000298B8
			// (set) Token: 0x06000936 RID: 2358 RVA: 0x00005381 File Offset: 0x00003581
			public unsafe static EaseFunction __9__4_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002B6E0 File Offset: 0x000298E0
			// (set) Token: 0x06000938 RID: 2360 RVA: 0x00005393 File Offset: 0x00003593
			public unsafe static EaseFunction __9__4_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x06000939 RID: 2361 RVA: 0x0002B708 File Offset: 0x00029908
			// (set) Token: 0x0600093A RID: 2362 RVA: 0x000053A5 File Offset: 0x000035A5
			public unsafe static EaseFunction __9__4_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x0600093B RID: 2363 RVA: 0x0002B730 File Offset: 0x00029930
			// (set) Token: 0x0600093C RID: 2364 RVA: 0x000053B7 File Offset: 0x000035B7
			public unsafe static EaseFunction __9__4_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002B758 File Offset: 0x00029958
			// (set) Token: 0x0600093E RID: 2366 RVA: 0x000053C9 File Offset: 0x000035C9
			public unsafe static EaseFunction __9__4_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002B780 File Offset: 0x00029980
			// (set) Token: 0x06000940 RID: 2368 RVA: 0x000053DB File Offset: 0x000035DB
			public unsafe static EaseFunction __9__4_24
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_24, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_24, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002B7A8 File Offset: 0x000299A8
			// (set) Token: 0x06000942 RID: 2370 RVA: 0x000053ED File Offset: 0x000035ED
			public unsafe static EaseFunction __9__4_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000943 RID: 2371 RVA: 0x0002B7D0 File Offset: 0x000299D0
			// (set) Token: 0x06000944 RID: 2372 RVA: 0x000053FF File Offset: 0x000035FF
			public unsafe static EaseFunction __9__4_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000945 RID: 2373 RVA: 0x0002B7F8 File Offset: 0x000299F8
			// (set) Token: 0x06000946 RID: 2374 RVA: 0x00005411 File Offset: 0x00003611
			public unsafe static EaseFunction __9__4_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000947 RID: 2375 RVA: 0x0002B820 File Offset: 0x00029A20
			// (set) Token: 0x06000948 RID: 2376 RVA: 0x00005423 File Offset: 0x00003623
			public unsafe static EaseFunction __9__4_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000949 RID: 2377 RVA: 0x0002B848 File Offset: 0x00029A48
			// (set) Token: 0x0600094A RID: 2378 RVA: 0x00005435 File Offset: 0x00003635
			public unsafe static EaseFunction __9__4_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002B870 File Offset: 0x00029A70
			// (set) Token: 0x0600094C RID: 2380 RVA: 0x00005447 File Offset: 0x00003647
			public unsafe static EaseFunction __9__4_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x0600094D RID: 2381 RVA: 0x0002B898 File Offset: 0x00029A98
			// (set) Token: 0x0600094E RID: 2382 RVA: 0x00005459 File Offset: 0x00003659
			public unsafe static EaseFunction __9__4_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x0600094F RID: 2383 RVA: 0x0002B8C0 File Offset: 0x00029AC0
			// (set) Token: 0x06000950 RID: 2384 RVA: 0x0000546B File Offset: 0x0000366B
			public unsafe static EaseFunction __9__4_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000951 RID: 2385 RVA: 0x0002B8E8 File Offset: 0x00029AE8
			// (set) Token: 0x06000952 RID: 2386 RVA: 0x0000547D File Offset: 0x0000367D
			public unsafe static EaseFunction __9__4_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000953 RID: 2387 RVA: 0x0002B910 File Offset: 0x00029B10
			// (set) Token: 0x06000954 RID: 2388 RVA: 0x0000548F File Offset: 0x0000368F
			public unsafe static EaseFunction __9__4_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x06000955 RID: 2389 RVA: 0x0002B938 File Offset: 0x00029B38
			// (set) Token: 0x06000956 RID: 2390 RVA: 0x000054A1 File Offset: 0x000036A1
			public unsafe static EaseFunction __9__4_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000696 RID: 1686
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000697 RID: 1687
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04000698 RID: 1688
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04000699 RID: 1689
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x0400069A RID: 1690
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x0400069B RID: 1691
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x0400069C RID: 1692
			private static readonly IntPtr NativeFieldInfoPtr___9__4_5;

			// Token: 0x0400069D RID: 1693
			private static readonly IntPtr NativeFieldInfoPtr___9__4_6;

			// Token: 0x0400069E RID: 1694
			private static readonly IntPtr NativeFieldInfoPtr___9__4_7;

			// Token: 0x0400069F RID: 1695
			private static readonly IntPtr NativeFieldInfoPtr___9__4_8;

			// Token: 0x040006A0 RID: 1696
			private static readonly IntPtr NativeFieldInfoPtr___9__4_9;

			// Token: 0x040006A1 RID: 1697
			private static readonly IntPtr NativeFieldInfoPtr___9__4_10;

			// Token: 0x040006A2 RID: 1698
			private static readonly IntPtr NativeFieldInfoPtr___9__4_11;

			// Token: 0x040006A3 RID: 1699
			private static readonly IntPtr NativeFieldInfoPtr___9__4_12;

			// Token: 0x040006A4 RID: 1700
			private static readonly IntPtr NativeFieldInfoPtr___9__4_13;

			// Token: 0x040006A5 RID: 1701
			private static readonly IntPtr NativeFieldInfoPtr___9__4_14;

			// Token: 0x040006A6 RID: 1702
			private static readonly IntPtr NativeFieldInfoPtr___9__4_15;

			// Token: 0x040006A7 RID: 1703
			private static readonly IntPtr NativeFieldInfoPtr___9__4_16;

			// Token: 0x040006A8 RID: 1704
			private static readonly IntPtr NativeFieldInfoPtr___9__4_17;

			// Token: 0x040006A9 RID: 1705
			private static readonly IntPtr NativeFieldInfoPtr___9__4_18;

			// Token: 0x040006AA RID: 1706
			private static readonly IntPtr NativeFieldInfoPtr___9__4_19;

			// Token: 0x040006AB RID: 1707
			private static readonly IntPtr NativeFieldInfoPtr___9__4_20;

			// Token: 0x040006AC RID: 1708
			private static readonly IntPtr NativeFieldInfoPtr___9__4_21;

			// Token: 0x040006AD RID: 1709
			private static readonly IntPtr NativeFieldInfoPtr___9__4_22;

			// Token: 0x040006AE RID: 1710
			private static readonly IntPtr NativeFieldInfoPtr___9__4_23;

			// Token: 0x040006AF RID: 1711
			private static readonly IntPtr NativeFieldInfoPtr___9__4_24;

			// Token: 0x040006B0 RID: 1712
			private static readonly IntPtr NativeFieldInfoPtr___9__4_25;

			// Token: 0x040006B1 RID: 1713
			private static readonly IntPtr NativeFieldInfoPtr___9__4_26;

			// Token: 0x040006B2 RID: 1714
			private static readonly IntPtr NativeFieldInfoPtr___9__4_27;

			// Token: 0x040006B3 RID: 1715
			private static readonly IntPtr NativeFieldInfoPtr___9__4_28;

			// Token: 0x040006B4 RID: 1716
			private static readonly IntPtr NativeFieldInfoPtr___9__4_29;

			// Token: 0x040006B5 RID: 1717
			private static readonly IntPtr NativeFieldInfoPtr___9__4_30;

			// Token: 0x040006B6 RID: 1718
			private static readonly IntPtr NativeFieldInfoPtr___9__4_31;

			// Token: 0x040006B7 RID: 1719
			private static readonly IntPtr NativeFieldInfoPtr___9__4_32;

			// Token: 0x040006B8 RID: 1720
			private static readonly IntPtr NativeFieldInfoPtr___9__4_33;

			// Token: 0x040006B9 RID: 1721
			private static readonly IntPtr NativeFieldInfoPtr___9__4_34;

			// Token: 0x040006BA RID: 1722
			private static readonly IntPtr NativeFieldInfoPtr___9__4_35;

			// Token: 0x040006BB RID: 1723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040006BC RID: 1724
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_0_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006BD RID: 1725
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_1_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006BE RID: 1726
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_2_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006BF RID: 1727
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_3_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C0 RID: 1728
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_4_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C1 RID: 1729
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_5_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C2 RID: 1730
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_6_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C3 RID: 1731
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_7_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C4 RID: 1732
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_8_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C5 RID: 1733
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_9_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C6 RID: 1734
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_10_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C7 RID: 1735
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_11_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C8 RID: 1736
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_12_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006C9 RID: 1737
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_13_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006CA RID: 1738
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_14_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006CB RID: 1739
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_15_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006CC RID: 1740
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_16_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006CD RID: 1741
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_17_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006CE RID: 1742
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_18_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006CF RID: 1743
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_19_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D0 RID: 1744
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_20_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D1 RID: 1745
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_21_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D2 RID: 1746
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_22_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D3 RID: 1747
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_23_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D4 RID: 1748
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_24_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D5 RID: 1749
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_25_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D6 RID: 1750
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_26_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D7 RID: 1751
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_27_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D8 RID: 1752
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_28_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006D9 RID: 1753
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_29_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006DA RID: 1754
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_30_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006DB RID: 1755
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_31_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006DC RID: 1756
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_32_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006DD RID: 1757
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_33_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006DE RID: 1758
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_34_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x040006DF RID: 1759
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_35_Internal_Single_Single_Single_Single_Single_0;
		}
	}
}
