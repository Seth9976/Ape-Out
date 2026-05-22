using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000030 RID: 48
	public class ActivationControlPlayable : PlayableBehaviour
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x000144E8 File Offset: 0x000126E8
		// Note: this type is marked as 'beforefieldinit'.
		static ActivationControlPlayable()
		{
			Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ActivationControlPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr);
			ActivationControlPlayable.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, "gameObject");
			ActivationControlPlayable.NativeFieldInfoPtr_postPlayback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, "postPlayback");
			ActivationControlPlayable.NativeFieldInfoPtr_m_InitialState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, "m_InitialState");
			ActivationControlPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationControlPlayable_PlayableGraph_GameObject_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663983);
			ActivationControlPlayable.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663984);
			ActivationControlPlayable.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663985);
			ActivationControlPlayable.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663986);
			ActivationControlPlayable.NativeMethodInfoPtr_OnGraphStart_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663987);
			ActivationControlPlayable.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663988);
			ActivationControlPlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr, 100663989);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000145E0 File Offset: 0x000127E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478470, RefRangeEnd = 478471, XrefRangeStart = 478442, XrefRangeEnd = 478470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, ActivationControlPlayable.PostPlaybackState postPlaybackState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref postPlaybackState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationControlPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationControlPlayable_PlayableGraph_GameObject_PostPlaybackState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<ActivationControlPlayable>(intPtr);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00014638 File Offset: 0x00012838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478471, XrefRangeEnd = 478485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationControlPlayable.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00014690 File Offset: 0x00012890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478485, XrefRangeEnd = 478498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationControlPlayable.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000146E8 File Offset: 0x000128E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478498, XrefRangeEnd = 478512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessFrame(Playable playable, FrameData info, Object userData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationControlPlayable.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00014754 File Offset: 0x00012954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478512, XrefRangeEnd = 478526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGraphStart(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationControlPlayable.NativeMethodInfoPtr_OnGraphStart_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000147A0 File Offset: 0x000129A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478526, XrefRangeEnd = 478539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivationControlPlayable.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000147EC File Offset: 0x000129EC
		[CallerCount(0)]
		public unsafe ActivationControlPlayable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivationControlPlayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationControlPlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003496 File Offset: 0x00001696
		public ActivationControlPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00014828 File Offset: 0x00012A28
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0000349F File Offset: 0x0000169F
		public unsafe GameObject gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationControlPlayable.NativeFieldInfoPtr_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationControlPlayable.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00014858 File Offset: 0x00012A58
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x000034BE File Offset: 0x000016BE
		public unsafe ActivationControlPlayable.PostPlaybackState postPlayback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationControlPlayable.NativeFieldInfoPtr_postPlayback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationControlPlayable.NativeFieldInfoPtr_postPlayback)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00014880 File Offset: 0x00012A80
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x000034D9 File Offset: 0x000016D9
		public unsafe ActivationControlPlayable.InitialState m_InitialState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationControlPlayable.NativeFieldInfoPtr_m_InitialState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivationControlPlayable.NativeFieldInfoPtr_m_InitialState)) = value;
			}
		}

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_postPlayback;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialState;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationControlPlayable_PlayableGraph_GameObject_PostPlaybackState_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Virtual_Void_Playable_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000073 RID: 115
		[OriginalName("Unity.Timeline.dll", "", "PostPlaybackState")]
		public enum PostPlaybackState
		{
			// Token: 0x040004A7 RID: 1191
			Active,
			// Token: 0x040004A8 RID: 1192
			Inactive,
			// Token: 0x040004A9 RID: 1193
			Revert
		}

		// Token: 0x02000074 RID: 116
		[OriginalName("Unity.Timeline.dll", "", "InitialState")]
		public enum InitialState
		{
			// Token: 0x040004AB RID: 1195
			Unset,
			// Token: 0x040004AC RID: 1196
			Active,
			// Token: 0x040004AD RID: 1197
			Inactive
		}
	}
}
