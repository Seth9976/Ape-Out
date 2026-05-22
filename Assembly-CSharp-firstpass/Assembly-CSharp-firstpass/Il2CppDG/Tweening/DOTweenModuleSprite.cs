using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001F0 RID: 496
	public static class DOTweenModuleSprite : global::Il2CppSystem.Object
	{
		// Token: 0x06001954 RID: 6484 RVA: 0x00072384 File Offset: 0x00070584
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModuleSprite()
		{
			Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModuleSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr);
			DOTweenModuleSprite.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_SpriteRenderer_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, 100667117);
			DOTweenModuleSprite.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_SpriteRenderer_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, 100667118);
			DOTweenModuleSprite.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_SpriteRenderer_Gradient_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, 100667119);
			DOTweenModuleSprite.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_SpriteRenderer_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, 100667120);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00072404 File Offset: 0x00070604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21424, RefRangeEnd = 21425, XrefRangeStart = 21398, XrefRangeEnd = 21424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_SpriteRenderer_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00072464 File Offset: 0x00070664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21425, XrefRangeEnd = 21446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_SpriteRenderer_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000724C4 File Offset: 0x000706C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21446, XrefRangeEnd = 21467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gradient);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_SpriteRenderer_Gradient_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00072528 File Offset: 0x00070728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21467, XrefRangeEnd = 21496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_SpriteRenderer_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00009F07 File Offset: 0x00008107
		public DOTweenModuleSprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_SpriteRenderer_Color_Single_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_SpriteRenderer_Single_Single_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_SpriteRenderer_Gradient_Single_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_SpriteRenderer_Color_Single_0;

		// Token: 0x02000284 RID: 644
		[ObfuscatedName("DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022BB RID: 8891 RVA: 0x00095DA0 File Offset: 0x00093FA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr);
				DOTweenModuleSprite.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr, "target");
				DOTweenModuleSprite.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr, 100667121);
				DOTweenModuleSprite.__c__DisplayClass0_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr, 100667122);
				DOTweenModuleSprite.__c__DisplayClass0_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr, 100667123);
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x00095E1C File Offset: 0x0009401C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x00095E58 File Offset: 0x00094058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21390, XrefRangeEnd = 21392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass0_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022BE RID: 8894 RVA: 0x00095E94 File Offset: 0x00094094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21392, XrefRangeEnd = 21394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass0_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022BF RID: 8895 RVA: 0x0000D01D File Offset: 0x0000B21D
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00095ED4 File Offset: 0x000940D4
			// (set) Token: 0x060022C1 RID: 8897 RVA: 0x0000D026 File Offset: 0x0000B226
			public unsafe SpriteRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B0 RID: 8624
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021B1 RID: 8625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021B2 RID: 8626
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040021B3 RID: 8627
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000285 RID: 645
		[ObfuscatedName("DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022C2 RID: 8898 RVA: 0x00095F04 File Offset: 0x00094104
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr);
				DOTweenModuleSprite.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr, "target");
				DOTweenModuleSprite.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr, 100667124);
				DOTweenModuleSprite.__c__DisplayClass1_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr, 100667125);
				DOTweenModuleSprite.__c__DisplayClass1_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr, 100667126);
			}

			// Token: 0x060022C3 RID: 8899 RVA: 0x00095F80 File Offset: 0x00094180
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x00095FBC File Offset: 0x000941BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass1_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x00095FF8 File Offset: 0x000941F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass1_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022C6 RID: 8902 RVA: 0x0000D045 File Offset: 0x0000B245
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00096038 File Offset: 0x00094238
			// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0000D04E File Offset: 0x0000B24E
			public unsafe SpriteRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B4 RID: 8628
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021B5 RID: 8629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021B6 RID: 8630
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x040021B7 RID: 8631
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000286 RID: 646
		[ObfuscatedName("DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022C9 RID: 8905 RVA: 0x00096068 File Offset: 0x00094268
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleSprite>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr);
				DOTweenModuleSprite.__c__DisplayClass3_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr, "to");
				DOTweenModuleSprite.__c__DisplayClass3_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr, "target");
				DOTweenModuleSprite.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr, 100667127);
				DOTweenModuleSprite.__c__DisplayClass3_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr, 100667128);
				DOTweenModuleSprite.__c__DisplayClass3_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr, 100667129);
			}

			// Token: 0x060022CA RID: 8906 RVA: 0x000960F8 File Offset: 0x000942F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleSprite.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022CB RID: 8907 RVA: 0x00096134 File Offset: 0x00094334
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass3_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022CC RID: 8908 RVA: 0x00096170 File Offset: 0x00094370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21394, XrefRangeEnd = 21398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleSprite.__c__DisplayClass3_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022CD RID: 8909 RVA: 0x0000D06D File Offset: 0x0000B26D
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x060022CE RID: 8910 RVA: 0x000961B0 File Offset: 0x000943B0
			// (set) Token: 0x060022CF RID: 8911 RVA: 0x0000D076 File Offset: 0x0000B276
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass3_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass3_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000961D8 File Offset: 0x000943D8
			// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0000D091 File Offset: 0x0000B291
			public unsafe SpriteRenderer target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass3_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleSprite.__c__DisplayClass3_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B8 RID: 8632
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040021B9 RID: 8633
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021BA RID: 8634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021BB RID: 8635
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x040021BC RID: 8636
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}
	}
}
