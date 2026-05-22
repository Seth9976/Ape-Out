using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core.Easing
{
	// Token: 0x0200005F RID: 95
	public static class Flash : Object
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x0001F568 File Offset: 0x0001D768
		// Note: this type is marked as 'beforefieldinit'.
		static Flash()
		{
			Il2CppClassPointerStore<Flash>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "Flash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flash>.NativeClassPtr);
			Flash.NativeMethodInfoPtr_Ease_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664366);
			Flash.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664367);
			Flash.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664368);
			Flash.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664369);
			Flash.NativeMethodInfoPtr_WeightedEase_Private_Static_Single_Single_Single_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664370);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001F5FC File Offset: 0x0001D7FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126293, RefRangeEnd = 126295, XrefRangeStart = 126288, XrefRangeEnd = 126293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Ease(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_Ease_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001F664 File Offset: 0x0001D864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126300, RefRangeEnd = 126302, XrefRangeStart = 126295, XrefRangeEnd = 126300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseIn(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001F6CC File Offset: 0x0001D8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126307, RefRangeEnd = 126309, XrefRangeStart = 126302, XrefRangeEnd = 126307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOut(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001F734 File Offset: 0x0001D934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126315, RefRangeEnd = 126317, XrefRangeStart = 126309, XrefRangeEnd = 126315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001F79C File Offset: 0x0001D99C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126331, RefRangeEnd = 126335, XrefRangeStart = 126317, XrefRangeEnd = 126331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overshootOrAmplitude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepDuration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_WeightedEase_Private_Static_Single_Single_Single_Int32_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00003DD8 File Offset: 0x00001FD8
		public Flash(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_Ease_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_WeightedEase_Private_Static_Single_Single_Single_Int32_Single_Single_Single_0;
	}
}
