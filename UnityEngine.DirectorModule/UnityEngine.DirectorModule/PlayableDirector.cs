using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000002 RID: 2
	public class PlayableDirector : Behaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000022F0 File Offset: 0x000004F0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableDirector()
		{
			Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.DirectorModule.dll", "UnityEngine.Playables", "PlayableDirector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr);
			PlayableDirector.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "played");
			PlayableDirector.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "paused");
			PlayableDirector.NativeFieldInfoPtr_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "stopped");
			PlayableDirector.NativeMethodInfoPtr_get_extrapolationMode_Public_get_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663297);
			PlayableDirector.NativeMethodInfoPtr_get_playableAsset_Public_get_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663298);
			PlayableDirector.NativeMethodInfoPtr_get_playableGraph_Public_get_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663299);
			PlayableDirector.NativeMethodInfoPtr_set_time_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663300);
			PlayableDirector.NativeMethodInfoPtr_get_time_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663301);
			PlayableDirector.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663302);
			PlayableDirector.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663303);
			PlayableDirector.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663304);
			PlayableDirector.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663305);
			PlayableDirector.NativeMethodInfoPtr_GetReferenceValue_Public_Virtual_Final_New_Object_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663306);
			PlayableDirector.NativeMethodInfoPtr_GetGenericBinding_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663307);
			PlayableDirector.NativeMethodInfoPtr_GetWrapMode_Private_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663308);
			PlayableDirector.NativeMethodInfoPtr_GetGraphHandle_Private_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663309);
			PlayableDirector.NativeMethodInfoPtr_Internal_GetPlayableAsset_Private_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663310);
			PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663311);
			PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663312);
			PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663313);
			PlayableDirector.NativeMethodInfoPtr_GetReferenceValue_Injected_Private_Virtual_Final_New_Object_byref_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663314);
			PlayableDirector.NativeMethodInfoPtr_GetGraphHandle_Injected_Private_Void_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663315);
			PlayableDirector.set_timeUpdateModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.set_timeUpdateModeDelegate>("UnityEngine.Playables.PlayableDirector::set_timeUpdateMode");
			PlayableDirector.get_timeUpdateModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_timeUpdateModeDelegate>("UnityEngine.Playables.PlayableDirector::get_timeUpdateMode");
			PlayableDirector.set_initialTimeDelegateField = IL2CPP.ResolveICall<PlayableDirector.set_initialTimeDelegate>("UnityEngine.Playables.PlayableDirector::set_initialTime");
			PlayableDirector.get_initialTimeDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_initialTimeDelegate>("UnityEngine.Playables.PlayableDirector::get_initialTime");
			PlayableDirector.get_durationDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_durationDelegate>("UnityEngine.Playables.PlayableDirector::get_duration");
			PlayableDirector.ResumeDelegateField = IL2CPP.ResolveICall<PlayableDirector.ResumeDelegate>("UnityEngine.Playables.PlayableDirector::Resume");
			PlayableDirector.RebuildGraphDelegateField = IL2CPP.ResolveICall<PlayableDirector.RebuildGraphDelegate>("UnityEngine.Playables.PlayableDirector::RebuildGraph");
			PlayableDirector.ClearGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.ClearGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::ClearGenericBinding");
			PlayableDirector.RebindPlayableGraphOutputsDelegateField = IL2CPP.ResolveICall<PlayableDirector.RebindPlayableGraphOutputsDelegate>("UnityEngine.Playables.PlayableDirector::RebindPlayableGraphOutputs");
			PlayableDirector.ProcessPendingGraphChangesDelegateField = IL2CPP.ResolveICall<PlayableDirector.ProcessPendingGraphChangesDelegate>("UnityEngine.Playables.PlayableDirector::ProcessPendingGraphChanges");
			PlayableDirector.HasGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.HasGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::HasGenericBinding");
			PlayableDirector.GetPlayStateDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetPlayStateDelegate>("UnityEngine.Playables.PlayableDirector::GetPlayState");
			PlayableDirector.SetWrapModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetWrapModeDelegate>("UnityEngine.Playables.PlayableDirector::SetWrapMode");
			PlayableDirector.EvaluateNextFrameDelegateField = IL2CPP.ResolveICall<PlayableDirector.EvaluateNextFrameDelegate>("UnityEngine.Playables.PlayableDirector::EvaluateNextFrame");
			PlayableDirector.SetPlayOnAwakeDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetPlayOnAwakeDelegate>("UnityEngine.Playables.PlayableDirector::SetPlayOnAwake");
			PlayableDirector.GetPlayOnAwakeDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetPlayOnAwakeDelegate>("UnityEngine.Playables.PlayableDirector::GetPlayOnAwake");
			PlayableDirector.Internal_SetGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.Internal_SetGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::Internal_SetGenericBinding");
			PlayableDirector.SetPlayableAssetDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetPlayableAssetDelegate>("UnityEngine.Playables.PlayableDirector::SetPlayableAsset");
			PlayableDirector.ResetFrameTimingDelegateField = IL2CPP.ResolveICall<PlayableDirector.ResetFrameTimingDelegate>("UnityEngine.Playables.PlayableDirector::ResetFrameTiming");
			PlayableDirector.ClearReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<PlayableDirector.ClearReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::ClearReferenceValue_Injected");
			PlayableDirector.SetReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::SetReferenceValue_Injected");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002614 File Offset: 0x00000814
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020B6 File Offset: 0x000002B6
		public unsafe DirectorWrapMode extrapolationMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 504801, RefRangeEnd = 504803, XrefRangeStart = 504797, XrefRangeEnd = 504801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_get_extrapolationMode_Public_get_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetWrapMode(value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002650 File Offset: 0x00000850
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020C1 File Offset: 0x000002C1
		public unsafe PlayableAsset playableAsset
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 504806, RefRangeEnd = 504820, XrefRangeStart = 504803, XrefRangeEnd = 504806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_get_playableAsset_Public_get_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr3) : null;
			}
			set
			{
				this.SetPlayableAsset(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002690 File Offset: 0x00000890
		public unsafe PlayableGraph playableGraph
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504820, XrefRangeEnd = 504822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_get_playableGraph_Public_get_PlayableGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000270C File Offset: 0x0000090C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000026CC File Offset: 0x000008CC
		public unsafe double time
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504828, XrefRangeEnd = 504832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_get_time_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 504826, RefRangeEnd = 504828, XrefRangeStart = 504822, XrefRangeEnd = 504826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_set_time_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002748 File Offset: 0x00000948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504836, RefRangeEnd = 504837, XrefRangeStart = 504832, XrefRangeEnd = 504836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000277C File Offset: 0x0000097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504837, XrefRangeEnd = 504841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000027B0 File Offset: 0x000009B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504841, XrefRangeEnd = 504845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027E4 File Offset: 0x000009E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504849, RefRangeEnd = 504850, XrefRangeStart = 504845, XrefRangeEnd = 504849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002818 File Offset: 0x00000A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504850, XrefRangeEnd = 504852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetReferenceValue(PropertyName id, out bool idValid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idValid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_GetReferenceValue_Public_Virtual_Final_New_Object_PropertyName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002874 File Offset: 0x00000A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504856, RefRangeEnd = 504857, XrefRangeStart = 504852, XrefRangeEnd = 504856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetGenericBinding(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_GetGenericBinding_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000028C4 File Offset: 0x00000AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 504801, RefRangeEnd = 504803, XrefRangeStart = 504801, XrefRangeEnd = 504803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectorWrapMode GetWrapMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_GetWrapMode_Private_DirectorWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002900 File Offset: 0x00000B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504857, XrefRangeEnd = 504859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableGraph GetGraphHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_GetGraphHandle_Private_PlayableGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000293C File Offset: 0x00000B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504859, XrefRangeEnd = 504863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObject Internal_GetPlayableAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_Internal_GetPlayableAsset_Private_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000297C File Offset: 0x00000B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504863, XrefRangeEnd = 504866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnPlayableDirectorPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000029B0 File Offset: 0x00000BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504866, XrefRangeEnd = 504869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnPlayableDirectorPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029E4 File Offset: 0x00000BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504869, XrefRangeEnd = 504872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnPlayableDirectorStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A18 File Offset: 0x00000C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504872, XrefRangeEnd = 504876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idValid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_GetReferenceValue_Injected_Private_Virtual_Final_New_Object_byref_PropertyName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A74 File Offset: 0x00000C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504876, XrefRangeEnd = 504880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetGraphHandle_Injected(out PlayableGraph ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_GetGraphHandle_Injected_Private_Void_byref_PlayableGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		public PlayableDirector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002AB4 File Offset: 0x00000CB4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe Action<PlayableDirector> played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_played);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_played), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002AE4 File Offset: 0x00000CE4
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe Action<PlayableDirector> paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_paused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_paused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002B14 File Offset: 0x00000D14
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002097 File Offset: 0x00000297
		public unsafe Action<PlayableDirector> stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_stopped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_stopped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002B44 File Offset: 0x00000D44
		public PlayState state
		{
			get
			{
				return this.GetPlayState();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002B5C File Offset: 0x00000D5C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000020CC File Offset: 0x000002CC
		public bool playOnAwake
		{
			get
			{
				return this.GetPlayOnAwake();
			}
			set
			{
				this.SetPlayOnAwake(value);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020D7 File Offset: 0x000002D7
		public void DeferredEvaluate()
		{
			this.EvaluateNextFrame();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002B74 File Offset: 0x00000D74
		public void Play(PlayableAsset asset)
		{
			bool flag = asset == null;
			if (flag)
			{
				throw new ArgumentNullException("asset");
			}
			this.Play(asset, this.extrapolationMode);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public void Play(PlayableAsset asset, DirectorWrapMode mode)
		{
			bool flag = asset == null;
			if (flag)
			{
				throw new ArgumentNullException("asset");
			}
			this.playableAsset = asset;
			this.extrapolationMode = mode;
			this.Play();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020E1 File Offset: 0x000002E1
		public void SetGenericBinding(Object key, Object value)
		{
			this.Internal_SetGenericBinding(key, value);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000020ED File Offset: 0x000002ED
		public DirectorUpdateMode timeUpdateMode
		{
			get
			{
				return PlayableDirector.get_timeUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlayableDirector.set_timeUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002125 File Offset: 0x00000325
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002112 File Offset: 0x00000312
		public double initialTime
		{
			get
			{
				return PlayableDirector.get_initialTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlayableDirector.set_initialTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002137 File Offset: 0x00000337
		public double duration
		{
			get
			{
				return PlayableDirector.get_durationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002149 File Offset: 0x00000349
		public void Resume()
		{
			PlayableDirector.ResumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000215B File Offset: 0x0000035B
		public void RebuildGraph()
		{
			PlayableDirector.RebuildGraphDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000216D File Offset: 0x0000036D
		public void ClearReferenceValue(PropertyName id)
		{
			this.ClearReferenceValue_Injected(ref id);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002177 File Offset: 0x00000377
		public void SetReferenceValue(PropertyName id, Object value)
		{
			this.SetReferenceValue_Injected(ref id, value);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002182 File Offset: 0x00000382
		public void ClearGenericBinding(Object key)
		{
			PlayableDirector.ClearGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000219A File Offset: 0x0000039A
		public void RebindPlayableGraphOutputs()
		{
			PlayableDirector.RebindPlayableGraphOutputsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021AC File Offset: 0x000003AC
		public void ProcessPendingGraphChanges()
		{
			PlayableDirector.ProcessPendingGraphChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021BE File Offset: 0x000003BE
		public bool HasGenericBinding(Object key)
		{
			return PlayableDirector.HasGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021D6 File Offset: 0x000003D6
		public PlayState GetPlayState()
		{
			return PlayableDirector.GetPlayStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000021E8 File Offset: 0x000003E8
		public void SetWrapMode(DirectorWrapMode mode)
		{
			PlayableDirector.SetWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021FB File Offset: 0x000003FB
		public void EvaluateNextFrame()
		{
			PlayableDirector.EvaluateNextFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000220D File Offset: 0x0000040D
		public void SetPlayOnAwake(bool on)
		{
			PlayableDirector.SetPlayOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), on);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002220 File Offset: 0x00000420
		public bool GetPlayOnAwake()
		{
			return PlayableDirector.GetPlayOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002232 File Offset: 0x00000432
		public void Internal_SetGenericBinding(Object key, Object value)
		{
			PlayableDirector.Internal_SetGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key), IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002250 File Offset: 0x00000450
		public void SetPlayableAsset(ScriptableObject asset)
		{
			PlayableDirector.SetPlayableAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(asset));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002268 File Offset: 0x00000468
		public void add_played(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002275 File Offset: 0x00000475
		public void remove_played(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002282 File Offset: 0x00000482
		public void add_paused(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000228F File Offset: 0x0000048F
		public void remove_paused(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000229C File Offset: 0x0000049C
		public void add_stopped(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000022A9 File Offset: 0x000004A9
		public void remove_stopped(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022B6 File Offset: 0x000004B6
		public static void ResetFrameTiming()
		{
			PlayableDirector.ResetFrameTimingDelegateField();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022C2 File Offset: 0x000004C2
		public void ClearReferenceValue_Injected(ref PropertyName id)
		{
			PlayableDirector.ClearReferenceValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref id);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022D5 File Offset: 0x000004D5
		public void SetReferenceValue_Injected(ref PropertyName id, Object value)
		{
			PlayableDirector.SetReferenceValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref id, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_stopped;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_extrapolationMode_Public_get_DirectorWrapMode_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_playableAsset_Public_get_PlayableAsset_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_playableGraph_Public_get_PlayableGraph_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Double_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Double_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_GetReferenceValue_Public_Virtual_Final_New_Object_PropertyName_byref_Boolean_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericBinding_Public_Object_Object_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetWrapMode_Private_DirectorWrapMode_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphHandle_Private_PlayableGraph_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPlayableAsset_Private_ScriptableObject_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_GetReferenceValue_Injected_Private_Virtual_Final_New_Object_byref_PropertyName_byref_Boolean_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphHandle_Injected_Private_Void_byref_PlayableGraph_0;

		// Token: 0x04000017 RID: 23
		private static readonly PlayableDirector.set_timeUpdateModeDelegate set_timeUpdateModeDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly PlayableDirector.get_timeUpdateModeDelegate get_timeUpdateModeDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly PlayableDirector.set_initialTimeDelegate set_initialTimeDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly PlayableDirector.get_initialTimeDelegate get_initialTimeDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly PlayableDirector.get_durationDelegate get_durationDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly PlayableDirector.ResumeDelegate ResumeDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly PlayableDirector.RebuildGraphDelegate RebuildGraphDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly PlayableDirector.ClearGenericBindingDelegate ClearGenericBindingDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly PlayableDirector.RebindPlayableGraphOutputsDelegate RebindPlayableGraphOutputsDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly PlayableDirector.ProcessPendingGraphChangesDelegate ProcessPendingGraphChangesDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly PlayableDirector.HasGenericBindingDelegate HasGenericBindingDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly PlayableDirector.GetPlayStateDelegate GetPlayStateDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly PlayableDirector.SetWrapModeDelegate SetWrapModeDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly PlayableDirector.EvaluateNextFrameDelegate EvaluateNextFrameDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly PlayableDirector.SetPlayOnAwakeDelegate SetPlayOnAwakeDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly PlayableDirector.GetPlayOnAwakeDelegate GetPlayOnAwakeDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly PlayableDirector.Internal_SetGenericBindingDelegate Internal_SetGenericBindingDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly PlayableDirector.SetPlayableAssetDelegate SetPlayableAssetDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly PlayableDirector.ResetFrameTimingDelegate ResetFrameTimingDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly PlayableDirector.ClearReferenceValue_InjectedDelegate ClearReferenceValue_InjectedDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly PlayableDirector.SetReferenceValue_InjectedDelegate SetReferenceValue_InjectedDelegateField;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate void set_timeUpdateModeDelegate(IntPtr @this, DirectorUpdateMode value);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate DirectorUpdateMode get_timeUpdateModeDelegate(IntPtr @this);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate void set_initialTimeDelegate(IntPtr @this, double value);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate double get_initialTimeDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate double get_durationDelegate(IntPtr @this);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate void ResumeDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate void RebuildGraphDelegate(IntPtr @this);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate void ClearGenericBindingDelegate(IntPtr @this, IntPtr key);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate void RebindPlayableGraphOutputsDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate void ProcessPendingGraphChangesDelegate(IntPtr @this);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate bool HasGenericBindingDelegate(IntPtr @this, IntPtr key);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate PlayState GetPlayStateDelegate(IntPtr @this);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600005B RID: 91
		private delegate void SetWrapModeDelegate(IntPtr @this, DirectorWrapMode mode);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600005D RID: 93
		private delegate void EvaluateNextFrameDelegate(IntPtr @this);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600005F RID: 95
		private delegate void SetPlayOnAwakeDelegate(IntPtr @this, bool on);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000061 RID: 97
		private delegate bool GetPlayOnAwakeDelegate(IntPtr @this);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000063 RID: 99
		private delegate void Internal_SetGenericBindingDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000065 RID: 101
		private delegate void SetPlayableAssetDelegate(IntPtr @this, IntPtr asset);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000067 RID: 103
		private delegate void ResetFrameTimingDelegate();

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000069 RID: 105
		private delegate void ClearReferenceValue_InjectedDelegate(IntPtr @this, IntPtr id);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600006B RID: 107
		private delegate void SetReferenceValue_InjectedDelegate(IntPtr @this, IntPtr id, IntPtr value);
	}
}
