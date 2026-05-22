using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000017 RID: 23
	public static class TimelineClipCapsExtensions : Object
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
		// Note: this type is marked as 'beforefieldinit'.
		static TimelineClipCapsExtensions()
		{
			Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineClipCapsExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsLooping_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663771);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsExtrapolation_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663772);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsClipIn_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663773);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsSpeedMultiplier_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663774);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsBlending_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663775);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_HasAll_Public_Static_Boolean_ClipCaps_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663776);
			TimelineClipCapsExtensions.NativeMethodInfoPtr_HasAny_Public_Static_Boolean_ClipCaps_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663777);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000F07C File Offset: 0x0000D27C
		[CallerCount(0)]
		public unsafe static bool SupportsLooping(this TimelineClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsLooping_Public_Static_Boolean_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[CallerCount(0)]
		public unsafe static bool SupportsExtrapolation(this TimelineClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsExtrapolation_Public_Static_Boolean_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000F104 File Offset: 0x0000D304
		[CallerCount(0)]
		public unsafe static bool SupportsClipIn(this TimelineClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsClipIn_Public_Static_Boolean_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000F148 File Offset: 0x0000D348
		[CallerCount(0)]
		public unsafe static bool SupportsSpeedMultiplier(this TimelineClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsSpeedMultiplier_Public_Static_Boolean_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000F18C File Offset: 0x0000D38C
		[CallerCount(0)]
		public unsafe static bool SupportsBlending(this TimelineClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_SupportsBlending_Public_Static_Boolean_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		[CallerCount(0)]
		public unsafe static bool HasAll(this ClipCaps caps, ClipCaps flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_HasAll_Public_Static_Boolean_ClipCaps_ClipCaps_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000F21C File Offset: 0x0000D41C
		[CallerCount(0)]
		public unsafe static bool HasAny(this ClipCaps caps, ClipCaps flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineClipCapsExtensions.NativeMethodInfoPtr_HasAny_Public_Static_Boolean_ClipCaps_ClipCaps_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002D79 File Offset: 0x00000F79
		public TimelineClipCapsExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_SupportsLooping_Public_Static_Boolean_TimelineClip_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_SupportsExtrapolation_Public_Static_Boolean_TimelineClip_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_SupportsClipIn_Public_Static_Boolean_TimelineClip_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_SupportsSpeedMultiplier_Public_Static_Boolean_TimelineClip_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_SupportsBlending_Public_Static_Boolean_TimelineClip_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_HasAll_Public_Static_Boolean_ClipCaps_ClipCaps_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_HasAny_Public_Static_Boolean_ClipCaps_ClipCaps_0;
	}
}
