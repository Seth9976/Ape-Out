using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x0200000B RID: 11
	public class EaseFactory : global::Il2CppSystem.Object
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000865C File Offset: 0x0000685C
		// Note: this type is marked as 'beforefieldinit'.
		static EaseFactory()
		{
			Il2CppClassPointerStore<EaseFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "EaseFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr);
			EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_Nullable_1_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663403);
			EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663404);
			EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_EaseFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663405);
			EaseFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663406);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000086DC File Offset: 0x000068DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118924, XrefRangeEnd = 118932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction StopMotion(int motionFps, Nullable<Ease> ease = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motionFps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ease));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_Nullable_1_Ease_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008734 File Offset: 0x00006934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118932, XrefRangeEnd = 118941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motionFps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008788 File Offset: 0x00006988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118949, RefRangeEnd = 118951, XrefRangeStart = 118941, XrefRangeEnd = 118949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction StopMotion(int motionFps, EaseFunction customEase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motionFps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customEase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_EaseFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000087DC File Offset: 0x000069DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EaseFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002289 File Offset: 0x00000489
		public EaseFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_Nullable_1_Ease_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_AnimationCurve_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_EaseFunction_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000065 RID: 101
		[ObfuscatedName("DG.Tweening.EaseFactory+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060005D3 RID: 1491 RVA: 0x0001FD80 File Offset: 0x0001DF80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr);
				EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_motionDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, "motionDelay");
				EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_customEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, "customEase");
				EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, 100663407);
				EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__StopMotion_b__0_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, 100663408);
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x0001FDFC File Offset: 0x0001DFFC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x0001FE38 File Offset: 0x0001E038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118917, XrefRangeEnd = 118924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _StopMotion_b__0(float time, float duration, float overshootOrAmplitude, float period)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__StopMotion_b__0_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x00003EA8 File Offset: 0x000020A8
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001FEAC File Offset: 0x0001E0AC
			// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00003EB1 File Offset: 0x000020B1
			public unsafe float motionDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_motionDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_motionDelay)) = value;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001FED4 File Offset: 0x0001E0D4
			// (set) Token: 0x060005DA RID: 1498 RVA: 0x00003ECC File Offset: 0x000020CC
			public unsafe EaseFunction customEase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_customEase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_customEase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeFieldInfoPtr_motionDelay;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeFieldInfoPtr_customEase;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004B5 RID: 1205
			private static readonly IntPtr NativeMethodInfoPtr__StopMotion_b__0_Internal_Single_Single_Single_Single_Single_0;
		}
	}
}
