using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001B RID: 27
	[StructLayout(2)]
	public struct AnimationClipPlayable
	{
		// Token: 0x060002AD RID: 685 RVA: 0x0000A7A0 File Offset: 0x000089A0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationClipPlayable()
		{
			Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr);
			AnimationClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, "m_Handle");
			AnimationClipPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationClipPlayable_PlayableGraph_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663374);
			AnimationClipPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663375);
			AnimationClipPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663376);
			AnimationClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663377);
			AnimationClipPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663378);
			AnimationClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663379);
			AnimationClipPlayable.NativeMethodInfoPtr_SetApplyFootIK_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663380);
			AnimationClipPlayable.NativeMethodInfoPtr_SetRemoveStartOffset_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663381);
			AnimationClipPlayable.NativeMethodInfoPtr_SetOverrideLoopTime_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663382);
			AnimationClipPlayable.NativeMethodInfoPtr_SetLoopTime_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663383);
			AnimationClipPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_AnimationClip_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663384);
			AnimationClipPlayable.NativeMethodInfoPtr_SetApplyFootIKInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663385);
			AnimationClipPlayable.NativeMethodInfoPtr_SetRemoveStartOffsetInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663386);
			AnimationClipPlayable.NativeMethodInfoPtr_SetOverrideLoopTimeInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663387);
			AnimationClipPlayable.NativeMethodInfoPtr_SetLoopTimeInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663388);
			AnimationClipPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_AnimationClip_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, 100663389);
			AnimationClipPlayable.GetAnimationClipInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetAnimationClipInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetAnimationClipInternal");
			AnimationClipPlayable.GetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetApplyFootIKInternal");
			AnimationClipPlayable.GetApplyPlayableIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetApplyPlayableIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetApplyPlayableIKInternal");
			AnimationClipPlayable.SetApplyPlayableIKInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetApplyPlayableIKInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetApplyPlayableIKInternal");
			AnimationClipPlayable.GetRemoveStartOffsetInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetRemoveStartOffsetInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetRemoveStartOffsetInternal");
			AnimationClipPlayable.GetOverrideLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetOverrideLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetOverrideLoopTimeInternal");
			AnimationClipPlayable.GetLoopTimeInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetLoopTimeInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetLoopTimeInternal");
			AnimationClipPlayable.GetSampleRateInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.GetSampleRateInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::GetSampleRateInternal");
			AnimationClipPlayable.SetSampleRateInternalDelegateField = IL2CPP.ResolveICall<AnimationClipPlayable.SetSampleRateInternalDelegate>("UnityEngine.Animations.AnimationClipPlayable::SetSampleRateInternal");
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000A9AC File Offset: 0x00008BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484005, RefRangeEnd = 484006, XrefRangeStart = 483970, XrefRangeEnd = 484005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationClipPlayable_PlayableGraph_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A9FC File Offset: 0x00008BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484006, XrefRangeEnd = 484024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000AA4C File Offset: 0x00008C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484024, XrefRangeEnd = 484028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClipPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000AA80 File Offset: 0x00008C80
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		[CallerCount(0)]
		public unsafe static implicit operator Playable(AnimationClipPlayable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationClipPlayable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484028, XrefRangeEnd = 484035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000AB30 File Offset: 0x00008D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484035, XrefRangeEnd = 484039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetApplyFootIK(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetApplyFootIK_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000AB64 File Offset: 0x00008D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484039, XrefRangeEnd = 484043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRemoveStartOffset(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetRemoveStartOffset_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000AB98 File Offset: 0x00008D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484043, XrefRangeEnd = 484047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideLoopTime(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetOverrideLoopTime_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000ABCC File Offset: 0x00008DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484047, XrefRangeEnd = 484051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLoopTime(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetLoopTime_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000AC00 File Offset: 0x00008E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484051, XrefRangeEnd = 484053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_AnimationClip_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000AC60 File Offset: 0x00008E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetApplyFootIKInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetRemoveStartOffsetInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetOverrideLoopTimeInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000AD20 File Offset: 0x00008F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLoopTimeInternal(ref PlayableHandle handle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_SetLoopTimeInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000AD60 File Offset: 0x00008F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484053, XrefRangeEnd = 484057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClipPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_AnimationClip_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003B98 File Offset: 0x00001D98
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		public static explicit operator AnimationClipPlayable(Playable playable)
		{
			return new AnimationClipPlayable(playable.GetHandle());
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		public AnimationClip GetAnimationClip()
		{
			return AnimationClipPlayable.GetAnimationClipInternal(ref this.m_Handle);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000AE00 File Offset: 0x00009000
		public bool GetApplyFootIK()
		{
			return AnimationClipPlayable.GetApplyFootIKInternal(ref this.m_Handle);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000AE20 File Offset: 0x00009020
		public bool GetApplyPlayableIK()
		{
			return AnimationClipPlayable.GetApplyPlayableIKInternal(ref this.m_Handle);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003BAA File Offset: 0x00001DAA
		public void SetApplyPlayableIK(bool value)
		{
			AnimationClipPlayable.SetApplyPlayableIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000AE40 File Offset: 0x00009040
		public bool GetRemoveStartOffset()
		{
			return AnimationClipPlayable.GetRemoveStartOffsetInternal(ref this.m_Handle);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000AE60 File Offset: 0x00009060
		public bool GetOverrideLoopTime()
		{
			return AnimationClipPlayable.GetOverrideLoopTimeInternal(ref this.m_Handle);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000AE80 File Offset: 0x00009080
		public bool GetLoopTime()
		{
			return AnimationClipPlayable.GetLoopTimeInternal(ref this.m_Handle);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public float GetSampleRate()
		{
			return AnimationClipPlayable.GetSampleRateInternal(ref this.m_Handle);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003BBA File Offset: 0x00001DBA
		public void SetSampleRate(float value)
		{
			AnimationClipPlayable.SetSampleRateInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public static AnimationClip GetAnimationClipInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimationClipPlayable.GetAnimationClipInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003BCA File Offset: 0x00001DCA
		public static bool GetApplyFootIKInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetApplyFootIKInternalDelegateField(ref handle);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003BD7 File Offset: 0x00001DD7
		public static bool GetApplyPlayableIKInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetApplyPlayableIKInternalDelegateField(ref handle);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationClipPlayable.SetApplyPlayableIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public static bool GetRemoveStartOffsetInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetRemoveStartOffsetInternalDelegateField(ref handle);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003BFF File Offset: 0x00001DFF
		public static bool GetOverrideLoopTimeInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetOverrideLoopTimeInternalDelegateField(ref handle);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00003C0C File Offset: 0x00001E0C
		public static bool GetLoopTimeInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetLoopTimeInternalDelegateField(ref handle);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003C19 File Offset: 0x00001E19
		public static float GetSampleRateInternal(ref PlayableHandle handle)
		{
			return AnimationClipPlayable.GetSampleRateInternalDelegateField(ref handle);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003C26 File Offset: 0x00001E26
		public static void SetSampleRateInternal(ref PlayableHandle handle, float value)
		{
			AnimationClipPlayable.SetSampleRateInternalDelegateField(ref handle, value);
		}

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationClipPlayable_PlayableGraph_AnimationClip_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AnimationClip_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationClipPlayable_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationClipPlayable_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_SetApplyFootIK_Public_Void_Boolean_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_SetRemoveStartOffset_Internal_Void_Boolean_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideLoopTime_Internal_Void_Boolean_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_SetLoopTime_Internal_Void_Boolean_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_AnimationClip_byref_PlayableHandle_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SetApplyFootIKInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_SetRemoveStartOffsetInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideLoopTimeInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_SetLoopTimeInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_AnimationClip_byref_PlayableHandle_0;

		// Token: 0x040001B5 RID: 437
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040001B6 RID: 438
		private static readonly AnimationClipPlayable.GetAnimationClipInternalDelegate GetAnimationClipInternalDelegateField;

		// Token: 0x040001B7 RID: 439
		private static readonly AnimationClipPlayable.GetApplyFootIKInternalDelegate GetApplyFootIKInternalDelegateField;

		// Token: 0x040001B8 RID: 440
		private static readonly AnimationClipPlayable.GetApplyPlayableIKInternalDelegate GetApplyPlayableIKInternalDelegateField;

		// Token: 0x040001B9 RID: 441
		private static readonly AnimationClipPlayable.SetApplyPlayableIKInternalDelegate SetApplyPlayableIKInternalDelegateField;

		// Token: 0x040001BA RID: 442
		private static readonly AnimationClipPlayable.GetRemoveStartOffsetInternalDelegate GetRemoveStartOffsetInternalDelegateField;

		// Token: 0x040001BB RID: 443
		private static readonly AnimationClipPlayable.GetOverrideLoopTimeInternalDelegate GetOverrideLoopTimeInternalDelegateField;

		// Token: 0x040001BC RID: 444
		private static readonly AnimationClipPlayable.GetLoopTimeInternalDelegate GetLoopTimeInternalDelegateField;

		// Token: 0x040001BD RID: 445
		private static readonly AnimationClipPlayable.GetSampleRateInternalDelegate GetSampleRateInternalDelegateField;

		// Token: 0x040001BE RID: 446
		private static readonly AnimationClipPlayable.SetSampleRateInternalDelegate SetSampleRateInternalDelegateField;

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x0600079F RID: 1951
		private delegate IntPtr GetAnimationClipInternalDelegate(IntPtr handle);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x060007A1 RID: 1953
		private delegate bool GetApplyFootIKInternalDelegate(IntPtr handle);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x060007A3 RID: 1955
		private delegate bool GetApplyPlayableIKInternalDelegate(IntPtr handle);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x060007A5 RID: 1957
		private delegate void SetApplyPlayableIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x060007A7 RID: 1959
		private delegate bool GetRemoveStartOffsetInternalDelegate(IntPtr handle);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x060007A9 RID: 1961
		private delegate bool GetOverrideLoopTimeInternalDelegate(IntPtr handle);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x060007AB RID: 1963
		private delegate bool GetLoopTimeInternalDelegate(IntPtr handle);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x060007AD RID: 1965
		private delegate float GetSampleRateInternalDelegate(IntPtr handle);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x060007AF RID: 1967
		private delegate void SetSampleRateInternalDelegate(IntPtr handle, float value);
	}
}
