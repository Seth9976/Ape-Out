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
	// Token: 0x020001EF RID: 495
	public static class DOTweenModulePhysics2D : global::Il2CppSystem.Object
	{
		// Token: 0x0600194D RID: 6477 RVA: 0x000720B4 File Offset: 0x000702B4
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModulePhysics2D()
		{
			Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModulePhysics2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr);
			DOTweenModulePhysics2D.NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, 100667097);
			DOTweenModulePhysics2D.NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, 100667098);
			DOTweenModulePhysics2D.NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, 100667099);
			DOTweenModulePhysics2D.NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Rigidbody2D_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, 100667100);
			DOTweenModulePhysics2D.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody2D_Vector2_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, 100667101);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00072148 File Offset: 0x00070348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21247, XrefRangeEnd = 21268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000721B8 File Offset: 0x000703B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21268, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00072228 File Offset: 0x00070428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21289, XrefRangeEnd = 21310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00072298 File Offset: 0x00070498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21310, XrefRangeEnd = 21331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Rigidbody2D_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000722F8 File Offset: 0x000704F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21331, XrefRangeEnd = 21390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpPower;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numJumps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody2D_Vector2_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00009EFE File Offset: 0x000080FE
		public DOTweenModulePhysics2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_DOMove_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Vector2_Single_Boolean_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Single_Single_Boolean_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_DOMoveY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Rigidbody2D_Single_Single_Boolean_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_DORotate_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Rigidbody2D_Single_Single_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_DOJump_Public_Static_Sequence_Rigidbody2D_Vector2_Single_Int32_Single_Boolean_0;

		// Token: 0x0200027F RID: 639
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600228C RID: 8844 RVA: 0x00095550 File Offset: 0x00093750
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass0_0>.NativeClassPtr);
				DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass0_0>.NativeClassPtr, "target");
				DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass0_0>.NativeClassPtr, 100667102);
				DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass0_0>.NativeClassPtr, 100667103);
			}

			// Token: 0x0600228D RID: 8845 RVA: 0x000955B8 File Offset: 0x000937B8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600228E RID: 8846 RVA: 0x000955F4 File Offset: 0x000937F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21230, XrefRangeEnd = 21232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOMove_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeMethodInfoPtr__DOMove_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600228F RID: 8847 RVA: 0x0000CEAB File Offset: 0x0000B0AB
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06002290 RID: 8848 RVA: 0x00095630 File Offset: 0x00093830
			// (set) Token: 0x06002291 RID: 8849 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
			public unsafe Rigidbody2D target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002196 RID: 8598
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002197 RID: 8599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002198 RID: 8600
			private static readonly IntPtr NativeMethodInfoPtr__DOMove_b__0_Internal_Vector2_0;
		}

		// Token: 0x02000280 RID: 640
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002292 RID: 8850 RVA: 0x00095660 File Offset: 0x00093860
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass1_0>.NativeClassPtr);
				DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass1_0>.NativeClassPtr, "target");
				DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass1_0>.NativeClassPtr, 100667104);
				DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass1_0>.NativeClassPtr, 100667105);
			}

			// Token: 0x06002293 RID: 8851 RVA: 0x000956C8 File Offset: 0x000938C8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002294 RID: 8852 RVA: 0x00095704 File Offset: 0x00093904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOMoveX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002295 RID: 8853 RVA: 0x0000CED3 File Offset: 0x0000B0D3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06002296 RID: 8854 RVA: 0x00095740 File Offset: 0x00093940
			// (set) Token: 0x06002297 RID: 8855 RVA: 0x0000CEDC File Offset: 0x0000B0DC
			public unsafe Rigidbody2D target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002199 RID: 8601
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400219A RID: 8602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400219B RID: 8603
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveX_b__0_Internal_Vector2_0;
		}

		// Token: 0x02000281 RID: 641
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002298 RID: 8856 RVA: 0x00095770 File Offset: 0x00093970
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass2_0>.NativeClassPtr);
				DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass2_0>.NativeClassPtr, "target");
				DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass2_0>.NativeClassPtr, 100667106);
				DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass2_0>.NativeClassPtr, 100667107);
			}

			// Token: 0x06002299 RID: 8857 RVA: 0x000957D8 File Offset: 0x000939D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600229A RID: 8858 RVA: 0x00095814 File Offset: 0x00093A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOMoveY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600229B RID: 8859 RVA: 0x0000CEFB File Offset: 0x0000B0FB
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x0600229C RID: 8860 RVA: 0x00095850 File Offset: 0x00093A50
			// (set) Token: 0x0600229D RID: 8861 RVA: 0x0000CF04 File Offset: 0x0000B104
			public unsafe Rigidbody2D target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass2_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400219C RID: 8604
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400219D RID: 8605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400219E RID: 8606
			private static readonly IntPtr NativeMethodInfoPtr__DOMoveY_b__0_Internal_Vector2_0;
		}

		// Token: 0x02000282 RID: 642
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600229E RID: 8862 RVA: 0x00095880 File Offset: 0x00093A80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass3_0>.NativeClassPtr);
				DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass3_0>.NativeClassPtr, "target");
				DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass3_0>.NativeClassPtr, 100667108);
				DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass3_0>.NativeClassPtr, 100667109);
			}

			// Token: 0x0600229F RID: 8863 RVA: 0x000958E8 File Offset: 0x00093AE8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A0 RID: 8864 RVA: 0x00095924 File Offset: 0x00093B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21232, XrefRangeEnd = 21237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DORotate_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeMethodInfoPtr__DORotate_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022A1 RID: 8865 RVA: 0x0000CF23 File Offset: 0x0000B123
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00095960 File Offset: 0x00093B60
			// (set) Token: 0x060022A3 RID: 8867 RVA: 0x0000CF2C File Offset: 0x0000B12C
			public unsafe Rigidbody2D target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass3_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400219F RID: 8607
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021A0 RID: 8608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021A1 RID: 8609
			private static readonly IntPtr NativeMethodInfoPtr__DORotate_b__0_Internal_Single_0;
		}

		// Token: 0x02000283 RID: 643
		[ObfuscatedName("DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022A4 RID: 8868 RVA: 0x00095990 File Offset: 0x00093B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModulePhysics2D>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "target");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "startPosY");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "offsetYSet");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "offsetY");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "s");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "endValue");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_yTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, "yTween");
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667110);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667111);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667112);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667113);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667114);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667115);
				DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr, 100667116);
			}

			// Token: 0x060022A5 RID: 8869 RVA: 0x00095AD4 File Offset: 0x00093CD4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModulePhysics2D.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A6 RID: 8870 RVA: 0x00095B10 File Offset: 0x00093D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022A7 RID: 8871 RVA: 0x00095B4C File Offset: 0x00093D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21237, XrefRangeEnd = 21239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022A8 RID: 8872 RVA: 0x00095B8C File Offset: 0x00093D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21239, XrefRangeEnd = 21241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A9 RID: 8873 RVA: 0x00095BC0 File Offset: 0x00093DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOJump_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__3_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022AA RID: 8874 RVA: 0x00095BFC File Offset: 0x00093DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__4(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__4_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022AB RID: 8875 RVA: 0x00095C3C File Offset: 0x00093E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21241, XrefRangeEnd = 21247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJump_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeMethodInfoPtr__DOJump_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022AC RID: 8876 RVA: 0x0000CF4B File Offset: 0x0000B14B
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x060022AD RID: 8877 RVA: 0x00095C70 File Offset: 0x00093E70
			// (set) Token: 0x060022AE RID: 8878 RVA: 0x0000CF54 File Offset: 0x0000B154
			public unsafe Rigidbody2D target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x060022AF RID: 8879 RVA: 0x00095CA0 File Offset: 0x00093EA0
			// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0000CF73 File Offset: 0x0000B173
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x060022B1 RID: 8881 RVA: 0x00095CC8 File Offset: 0x00093EC8
			// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0000CF8E File Offset: 0x0000B18E
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00095CF0 File Offset: 0x00093EF0
			// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0000CFA9 File Offset: 0x0000B1A9
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00095D18 File Offset: 0x00093F18
			// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x060022B7 RID: 8887 RVA: 0x00095D48 File Offset: 0x00093F48
			// (set) Token: 0x060022B8 RID: 8888 RVA: 0x0000CFE3 File Offset: 0x0000B1E3
			public unsafe Vector2 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x060022B9 RID: 8889 RVA: 0x00095D70 File Offset: 0x00093F70
			// (set) Token: 0x060022BA RID: 8890 RVA: 0x0000CFFE File Offset: 0x0000B1FE
			public unsafe Tween yTween
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_yTween);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModulePhysics2D.__c__DisplayClass4_0.NativeFieldInfoPtr_yTween), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021A2 RID: 8610
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021A3 RID: 8611
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x040021A4 RID: 8612
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x040021A5 RID: 8613
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x040021A6 RID: 8614
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x040021A7 RID: 8615
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x040021A8 RID: 8616
			private static readonly IntPtr NativeFieldInfoPtr_yTween;

			// Token: 0x040021A9 RID: 8617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021AA RID: 8618
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__0_Internal_Vector2_0;

			// Token: 0x040021AB RID: 8619
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__1_Internal_Void_Vector2_0;

			// Token: 0x040021AC RID: 8620
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__2_Internal_Void_0;

			// Token: 0x040021AD RID: 8621
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__3_Internal_Vector2_0;

			// Token: 0x040021AE RID: 8622
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__4_Internal_Void_Vector2_0;

			// Token: 0x040021AF RID: 8623
			private static readonly IntPtr NativeMethodInfoPtr__DOJump_b__5_Internal_Void_0;
		}
	}
}
