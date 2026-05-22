using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000032 RID: 50
	public class DirectorControlPlayable : PlayableBehaviour
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00014DA4 File Offset: 0x00012FA4
		// Note: this type is marked as 'beforefieldinit'.
		static DirectorControlPlayable()
		{
			Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "DirectorControlPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr);
			DirectorControlPlayable.NativeFieldInfoPtr_director = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "director");
			DirectorControlPlayable.NativeFieldInfoPtr_m_SyncTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "m_SyncTime");
			DirectorControlPlayable.NativeFieldInfoPtr_m_AssetDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, "m_AssetDuration");
			DirectorControlPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_DirectorControlPlayable_PlayableGraph_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664002);
			DirectorControlPlayable.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664003);
			DirectorControlPlayable.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664004);
			DirectorControlPlayable.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664005);
			DirectorControlPlayable.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664006);
			DirectorControlPlayable.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664007);
			DirectorControlPlayable.NativeMethodInfoPtr_SyncSpeed_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664008);
			DirectorControlPlayable.NativeMethodInfoPtr_SyncPlayState_Private_Void_PlayableGraph_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664009);
			DirectorControlPlayable.NativeMethodInfoPtr_DetectDiscontinuity_Private_Boolean_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664010);
			DirectorControlPlayable.NativeMethodInfoPtr_DetectOutOfSync_Private_Boolean_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664011);
			DirectorControlPlayable.NativeMethodInfoPtr_UpdateTime_Private_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664012);
			DirectorControlPlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr, 100664013);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00014F00 File Offset: 0x00013100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478584, RefRangeEnd = 478585, XrefRangeStart = 478556, XrefRangeEnd = 478584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(director);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_DirectorControlPlayable_PlayableGraph_PlayableDirector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<DirectorControlPlayable>(intPtr);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00014F4C File Offset: 0x0001314C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478585, XrefRangeEnd = 478611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirectorControlPlayable.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00014F98 File Offset: 0x00013198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478611, XrefRangeEnd = 478655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareFrame(Playable playable, FrameData info)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirectorControlPlayable.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00014FF0 File Offset: 0x000131F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478655, XrefRangeEnd = 478680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirectorControlPlayable.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00015048 File Offset: 0x00013248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478680, XrefRangeEnd = 478705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirectorControlPlayable.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000150A0 File Offset: 0x000132A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478705, XrefRangeEnd = 478734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirectorControlPlayable.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001510C File Offset: 0x0001330C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478754, RefRangeEnd = 478755, XrefRangeStart = 478734, XrefRangeEnd = 478754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSpeed(double speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr_SyncSpeed_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001514C File Offset: 0x0001334C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478755, XrefRangeEnd = 478762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPlayState(PlayableGraph graph, double playableTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playableTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr_SyncPlayState_Private_Void_PlayableGraph_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00015198 File Offset: 0x00013398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478780, RefRangeEnd = 478781, XrefRangeStart = 478762, XrefRangeEnd = 478780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DetectDiscontinuity(Playable playable, FrameData info)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr_DetectDiscontinuity_Private_Boolean_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000151F0 File Offset: 0x000133F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478800, RefRangeEnd = 478801, XrefRangeStart = 478781, XrefRangeEnd = 478800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DetectOutOfSync(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr_DetectOutOfSync_Private_Boolean_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001523C File Offset: 0x0001343C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478823, RefRangeEnd = 478824, XrefRangeStart = 478801, XrefRangeEnd = 478823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr_UpdateTime_Private_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001527C File Offset: 0x0001347C
		[CallerCount(0)]
		public unsafe DirectorControlPlayable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectorControlPlayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectorControlPlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000034FD File Offset: 0x000016FD
		public DirectorControlPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x000152B8 File Offset: 0x000134B8
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00003506 File Offset: 0x00001706
		public unsafe PlayableDirector director
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectorControlPlayable.NativeFieldInfoPtr_director);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectorControlPlayable.NativeFieldInfoPtr_director), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x000152E8 File Offset: 0x000134E8
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00003525 File Offset: 0x00001725
		public unsafe bool m_SyncTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectorControlPlayable.NativeFieldInfoPtr_m_SyncTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectorControlPlayable.NativeFieldInfoPtr_m_SyncTime)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00015310 File Offset: 0x00013510
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003540 File Offset: 0x00001740
		public unsafe double m_AssetDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectorControlPlayable.NativeFieldInfoPtr_m_AssetDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectorControlPlayable.NativeFieldInfoPtr_m_AssetDuration)) = value;
			}
		}

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_director;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_m_SyncTime;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetDuration;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_DirectorControlPlayable_PlayableGraph_PlayableDirector_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_SyncSpeed_Private_Void_Double_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_SyncPlayState_Private_Void_PlayableGraph_Double_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_DetectDiscontinuity_Private_Boolean_Playable_FrameData_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_DetectOutOfSync_Private_Boolean_Playable_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_Playable_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
