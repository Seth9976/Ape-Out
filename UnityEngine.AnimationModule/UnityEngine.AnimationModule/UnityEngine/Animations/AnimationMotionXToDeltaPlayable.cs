using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct AnimationMotionXToDeltaPlayable
	{
		// Token: 0x06000368 RID: 872 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMotionXToDeltaPlayable()
		{
			Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationMotionXToDeltaPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr);
			AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_Handle");
			AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationMotionXToDeltaPlayable_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663410);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663411);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663412);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663413);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663414);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663415);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_SetAbsoluteMotion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663416);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663417);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_SetAbsoluteMotionInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663418);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663420);
			AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::IsAbsoluteMotionInternal");
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000BF10 File Offset: 0x0000A110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484296, RefRangeEnd = 484297, XrefRangeStart = 484276, XrefRangeEnd = 484296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationMotionXToDeltaPlayable_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000BF50 File Offset: 0x0000A150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484319, RefRangeEnd = 484320, XrefRangeStart = 484297, XrefRangeEnd = 484319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000BF90 File Offset: 0x0000A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484320, XrefRangeEnd = 484324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		[CallerCount(0)]
		public unsafe static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationMotionXToDeltaPlayable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000C034 File Offset: 0x0000A234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484324, XrefRangeEnd = 484331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000C074 File Offset: 0x0000A274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484338, RefRangeEnd = 484339, XrefRangeStart = 484331, XrefRangeEnd = 484338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAbsoluteMotion(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_SetAbsoluteMotion_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484339, XrefRangeEnd = 484344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484344, XrefRangeEnd = 484375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_SetAbsoluteMotionInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000C134 File Offset: 0x0000A334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484375, XrefRangeEnd = 484379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000040F8 File Offset: 0x000022F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000C180 File Offset: 0x0000A380
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000410A File Offset: 0x0000230A
		public unsafe static AnimationMotionXToDeltaPlayable m_NullPlayable
		{
			get
			{
				AnimationMotionXToDeltaPlayable animationMotionXToDeltaPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationMotionXToDeltaPlayable));
				return animationMotionXToDeltaPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000C19C File Offset: 0x0000A39C
		public static AnimationMotionXToDeltaPlayable Null
		{
			get
			{
				return AnimationMotionXToDeltaPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		public static explicit operator AnimationMotionXToDeltaPlayable(Playable playable)
		{
			return new AnimationMotionXToDeltaPlayable(playable.GetHandle());
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public bool IsAbsoluteMotion()
		{
			return AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternal(ref this.m_Handle);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00004118 File Offset: 0x00002318
		public static bool IsAbsoluteMotionInternal(ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegateField(ref handle);
		}

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationMotionXToDeltaPlayable_PlayableGraph_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationMotionXToDeltaPlayable_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_SetAbsoluteMotion_Public_Void_Boolean_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_SetAbsoluteMotionInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x0400020C RID: 524
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400020D RID: 525
		private static readonly AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegate IsAbsoluteMotionInternalDelegateField;

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x060007FF RID: 2047
		private delegate bool IsAbsoluteMotionInternalDelegate(IntPtr handle);
	}
}
