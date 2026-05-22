using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct AnimationLayerMixerPlayable
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0000B53C File Offset: 0x0000973C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationLayerMixerPlayable()
		{
			Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationLayerMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr);
			AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, "m_Handle");
			AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationLayerMixerPlayable_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663390);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663391);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663392);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663393);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationLayerMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663394);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663395);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_SetLayerMaskFromAvatarMask_Public_Void_UInt32_AvatarMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663396);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663397);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_SetLayerMaskFromAvatarMaskInternal_Private_Static_Void_byref_PlayableHandle_UInt32_AvatarMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663398);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663400);
			AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal");
			AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal");
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000B67C File Offset: 0x0000987C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484077, RefRangeEnd = 484079, XrefRangeStart = 484057, XrefRangeEnd = 484077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationLayerMixerPlayable_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000B6C8 File Offset: 0x000098C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484109, RefRangeEnd = 484110, XrefRangeStart = 484079, XrefRangeEnd = 484109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000B714 File Offset: 0x00009914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484110, XrefRangeEnd = 484114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationLayerMixerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000B748 File Offset: 0x00009948
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000B778 File Offset: 0x00009978
		[CallerCount(0)]
		public unsafe static implicit operator Playable(AnimationLayerMixerPlayable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationLayerMixerPlayable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000B7B8 File Offset: 0x000099B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484114, XrefRangeEnd = 484121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationLayerMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000B7F8 File Offset: 0x000099F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484162, RefRangeEnd = 484163, XrefRangeStart = 484121, XrefRangeEnd = 484162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_SetLayerMaskFromAvatarMask_Public_Void_UInt32_AvatarMask_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000B83C File Offset: 0x00009A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484163, XrefRangeEnd = 484168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000B888 File Offset: 0x00009A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484168, XrefRangeEnd = 484199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_SetLayerMaskFromAvatarMaskInternal_Private_Static_Void_byref_PlayableHandle_UInt32_AvatarMask_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000B8DC File Offset: 0x00009ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484199, XrefRangeEnd = 484203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000409B File Offset: 0x0000229B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000B928 File Offset: 0x00009B28
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000040AD File Offset: 0x000022AD
		public unsafe static AnimationLayerMixerPlayable m_NullPlayable
		{
			get
			{
				AnimationLayerMixerPlayable animationLayerMixerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationLayerMixerPlayable));
				return animationLayerMixerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000B944 File Offset: 0x00009B44
		public static AnimationLayerMixerPlayable Null
		{
			get
			{
				return AnimationLayerMixerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000B95C File Offset: 0x00009B5C
		public static explicit operator AnimationLayerMixerPlayable(Playable playable)
		{
			return new AnimationLayerMixerPlayable(playable.GetHandle());
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000B97C File Offset: 0x00009B7C
		public bool IsLayerAdditive(uint layerIndex)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			return AnimationLayerMixerPlayable.IsLayerAdditiveInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		public void SetLayerAdditive(uint layerIndex, bool value)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			AnimationLayerMixerPlayable.SetLayerAdditiveInternal(ref this.m_Handle, layerIndex, value);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000040BB File Offset: 0x000022BB
		public static bool IsLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex)
		{
			return AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000040C9 File Offset: 0x000022C9
		public static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value)
		{
			AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegateField(ref handle, layerIndex, value);
		}

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationLayerMixerPlayable_PlayableGraph_Int32_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationLayerMixerPlayable_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerMaskFromAvatarMask_Public_Void_UInt32_AvatarMask_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerMaskFromAvatarMaskInternal_Private_Static_Void_byref_PlayableHandle_UInt32_AvatarMask_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x040001F2 RID: 498
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040001F3 RID: 499
		private static readonly AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegate IsLayerAdditiveInternalDelegateField;

		// Token: 0x040001F4 RID: 500
		private static readonly AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegate SetLayerAdditiveInternalDelegateField;

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060007FB RID: 2043
		private delegate bool IsLayerAdditiveInternalDelegate(IntPtr handle, uint layerIndex);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060007FD RID: 2045
		private delegate void SetLayerAdditiveInternalDelegate(IntPtr handle, uint layerIndex, bool value);
	}
}
