using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000002 RID: 2
	public class ActivationMixerPlayable : PlayableBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000438C File Offset: 0x0000258C
		// Note: this type is marked as 'beforefieldinit'.
		static ActivationMixerPlayable()
		{
			Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ActivationMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr);
			ActivationMixerPlayable.NativeFieldInfoPtr_m_PostPlaybackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, "m_PostPlaybackState");
			ActivationMixerPlayable.NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, "m_BoundGameObjectInitialStateIsActive");
			ActivationMixerPlayable.NativeFieldInfoPtr_m_BoundGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, "m_BoundGameObject");
			ActivationMixerPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationMixerPlayable_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663297);
			ActivationMixerPlayable.NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663298);
			ActivationMixerPlayable.NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663299);
			ActivationMixerPlayable.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663300);
			ActivationMixerPlayable.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663301);
			ActivationMixerPlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00004470 File Offset: 0x00002670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472279, XrefRangeEnd = 472285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationMixerPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationMixerPlayable_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<ActivationMixerPlayable>(intPtr);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000044F4 File Offset: 0x000026F4
		public unsafe ActivationTrack.PostPlaybackState postPlaybackState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationMixerPlayable.NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationMixerPlayable.NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00004534 File Offset: 0x00002734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472285, XrefRangeEnd = 472298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationMixerPlayable.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00004580 File Offset: 0x00002780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472298, XrefRangeEnd = 472349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessFrame(Playable playable, FrameData info, Object playerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationMixerPlayable.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000045EC File Offset: 0x000027EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivationMixerPlayable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationMixerPlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public ActivationMixerPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00004628 File Offset: 0x00002828
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe ActivationTrack.PostPlaybackState m_PostPlaybackState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationMixerPlayable.NativeFieldInfoPtr_m_PostPlaybackState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationMixerPlayable.NativeFieldInfoPtr_m_PostPlaybackState)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00004650 File Offset: 0x00002850
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe bool m_BoundGameObjectInitialStateIsActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationMixerPlayable.NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationMixerPlayable.NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00004678 File Offset: 0x00002878
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000208F File Offset: 0x0000028F
		public unsafe GameObject m_BoundGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationMixerPlayable.NativeFieldInfoPtr_m_BoundGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationMixerPlayable.NativeFieldInfoPtr_m_BoundGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_PostPlaybackState;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_BoundGameObject;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationMixerPlayable_PlayableGraph_Int32_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
