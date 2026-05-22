using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000025 RID: 37
	[StructLayout(2)]
	public struct AnimationRemoveScalePlayable
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationRemoveScalePlayable()
		{
			Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationRemoveScalePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr);
			AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, "m_Handle");
			AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationRemoveScalePlayable_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663447);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663448);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663449);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663450);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationRemoveScalePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663451);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663452);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663453);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663455);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484570, RefRangeEnd = 484571, XrefRangeStart = 484550, XrefRangeEnd = 484570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_Create_Public_Static_AnimationRemoveScalePlayable_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000D000 File Offset: 0x0000B200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484601, RefRangeEnd = 484602, XrefRangeStart = 484571, XrefRangeEnd = 484601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000D04C File Offset: 0x0000B24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484602, XrefRangeEnd = 484606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationRemoveScalePlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000D080 File Offset: 0x0000B280
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[CallerCount(0)]
		public unsafe static implicit operator Playable(AnimationRemoveScalePlayable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationRemoveScalePlayable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484606, XrefRangeEnd = 484612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationRemoveScalePlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000D130 File Offset: 0x0000B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484612, XrefRangeEnd = 484617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000D17C File Offset: 0x0000B37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484617, XrefRangeEnd = 484621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000042E4 File Offset: 0x000024E4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000042F6 File Offset: 0x000024F6
		public unsafe static AnimationRemoveScalePlayable m_NullPlayable
		{
			get
			{
				AnimationRemoveScalePlayable animationRemoveScalePlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationRemoveScalePlayable));
				return animationRemoveScalePlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		public static AnimationRemoveScalePlayable Null
		{
			get
			{
				return AnimationRemoveScalePlayable.m_NullPlayable;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		public static explicit operator AnimationRemoveScalePlayable(Playable playable)
		{
			return new AnimationRemoveScalePlayable(playable.GetHandle());
		}

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationRemoveScalePlayable_PlayableGraph_Int32_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationRemoveScalePlayable_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x04000247 RID: 583
		[FieldOffset(0)]
		public PlayableHandle m_Handle;
	}
}
