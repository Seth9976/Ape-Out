using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core.Easing
{
	// Token: 0x0200005C RID: 92
	public static class Bounce : Object
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0001F004 File Offset: 0x0001D204
		// Note: this type is marked as 'beforefieldinit'.
		static Bounce()
		{
			Il2CppClassPointerStore<Bounce>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "Bounce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounce>.NativeClassPtr);
			Bounce.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounce>.NativeClassPtr, 100664319);
			Bounce.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounce>.NativeClassPtr, 100664320);
			Bounce.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounce>.NativeClassPtr, 100664321);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001F070 File Offset: 0x0001D270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126013, RefRangeEnd = 126015, XrefRangeStart = 126013, XrefRangeEnd = 126013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounce.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126015, RefRangeEnd = 126017, XrefRangeStart = 126015, XrefRangeEnd = 126015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounce.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001F140 File Offset: 0x0001D340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126017, RefRangeEnd = 126019, XrefRangeStart = 126017, XrefRangeEnd = 126017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounce.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00003D82 File Offset: 0x00001F82
		public Bounce(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0;
	}
}
