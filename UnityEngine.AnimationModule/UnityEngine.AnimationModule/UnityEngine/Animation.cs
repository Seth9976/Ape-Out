using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class Animation : Behaviour
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000060C0 File Offset: 0x000042C0
		// Note: this type is marked as 'beforefieldinit'.
		static Animation()
		{
			Il2CppClassPointerStore<Animation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Animation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animation>.NativeClassPtr);
			Animation.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation>.NativeClassPtr, 100663312);
			Animation.NativeMethodInfoPtr_GetStateAtIndex_Internal_AnimationState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation>.NativeClassPtr, 100663313);
			Animation.NativeMethodInfoPtr_GetStateCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation>.NativeClassPtr, 100663314);
			Animation.get_clipDelegateField = IL2CPP.ResolveICall<Animation.get_clipDelegate>("UnityEngine.Animation::get_clip");
			Animation.set_clipDelegateField = IL2CPP.ResolveICall<Animation.set_clipDelegate>("UnityEngine.Animation::set_clip");
			Animation.get_playAutomaticallyDelegateField = IL2CPP.ResolveICall<Animation.get_playAutomaticallyDelegate>("UnityEngine.Animation::get_playAutomatically");
			Animation.set_playAutomaticallyDelegateField = IL2CPP.ResolveICall<Animation.set_playAutomaticallyDelegate>("UnityEngine.Animation::set_playAutomatically");
			Animation.get_wrapModeDelegateField = IL2CPP.ResolveICall<Animation.get_wrapModeDelegate>("UnityEngine.Animation::get_wrapMode");
			Animation.set_wrapModeDelegateField = IL2CPP.ResolveICall<Animation.set_wrapModeDelegate>("UnityEngine.Animation::set_wrapMode");
			Animation.StopDelegateField = IL2CPP.ResolveICall<Animation.StopDelegate>("UnityEngine.Animation::Stop");
			Animation.StopNamedDelegateField = IL2CPP.ResolveICall<Animation.StopNamedDelegate>("UnityEngine.Animation::StopNamed");
			Animation.RewindDelegateField = IL2CPP.ResolveICall<Animation.RewindDelegate>("UnityEngine.Animation::Rewind");
			Animation.RewindNamedDelegateField = IL2CPP.ResolveICall<Animation.RewindNamedDelegate>("UnityEngine.Animation::RewindNamed");
			Animation.SampleDelegateField = IL2CPP.ResolveICall<Animation.SampleDelegate>("UnityEngine.Animation::Sample");
			Animation.get_isPlayingDelegateField = IL2CPP.ResolveICall<Animation.get_isPlayingDelegate>("UnityEngine.Animation::get_isPlaying");
			Animation.IsPlayingDelegateField = IL2CPP.ResolveICall<Animation.IsPlayingDelegate>("UnityEngine.Animation::IsPlaying");
			Animation.PlayDefaultAnimationDelegateField = IL2CPP.ResolveICall<Animation.PlayDefaultAnimationDelegate>("UnityEngine.Animation::PlayDefaultAnimation");
			Animation.PlayDelegateField = IL2CPP.ResolveICall<Animation.PlayDelegate>("UnityEngine.Animation::Play");
			Animation.CrossFadeDelegateField = IL2CPP.ResolveICall<Animation.CrossFadeDelegate>("UnityEngine.Animation::CrossFade");
			Animation.BlendDelegateField = IL2CPP.ResolveICall<Animation.BlendDelegate>("UnityEngine.Animation::Blend");
			Animation.CrossFadeQueuedDelegateField = IL2CPP.ResolveICall<Animation.CrossFadeQueuedDelegate>("UnityEngine.Animation::CrossFadeQueued");
			Animation.PlayQueuedDelegateField = IL2CPP.ResolveICall<Animation.PlayQueuedDelegate>("UnityEngine.Animation::PlayQueued");
			Animation.AddClipDelegateField = IL2CPP.ResolveICall<Animation.AddClipDelegate>("UnityEngine.Animation::AddClip");
			Animation.RemoveClipDelegateField = IL2CPP.ResolveICall<Animation.RemoveClipDelegate>("UnityEngine.Animation::RemoveClip");
			Animation.RemoveClipNamedDelegateField = IL2CPP.ResolveICall<Animation.RemoveClipNamedDelegate>("UnityEngine.Animation::RemoveClipNamed");
			Animation.GetClipCountDelegateField = IL2CPP.ResolveICall<Animation.GetClipCountDelegate>("UnityEngine.Animation::GetClipCount");
			Animation.SyncLayerDelegateField = IL2CPP.ResolveICall<Animation.SyncLayerDelegate>("UnityEngine.Animation::SyncLayer");
			Animation.GetStateDelegateField = IL2CPP.ResolveICall<Animation.GetStateDelegate>("UnityEngine.Animation::GetState");
			Animation.get_animatePhysicsDelegateField = IL2CPP.ResolveICall<Animation.get_animatePhysicsDelegate>("UnityEngine.Animation::get_animatePhysics");
			Animation.set_animatePhysicsDelegateField = IL2CPP.ResolveICall<Animation.set_animatePhysicsDelegate>("UnityEngine.Animation::set_animatePhysics");
			Animation.get_animateOnlyIfVisibleDelegateField = IL2CPP.ResolveICall<Animation.get_animateOnlyIfVisibleDelegate>("UnityEngine.Animation::get_animateOnlyIfVisible");
			Animation.set_animateOnlyIfVisibleDelegateField = IL2CPP.ResolveICall<Animation.set_animateOnlyIfVisibleDelegate>("UnityEngine.Animation::set_animateOnlyIfVisible");
			Animation.get_cullingTypeDelegateField = IL2CPP.ResolveICall<Animation.get_cullingTypeDelegate>("UnityEngine.Animation::get_cullingType");
			Animation.set_cullingTypeDelegateField = IL2CPP.ResolveICall<Animation.set_cullingTypeDelegate>("UnityEngine.Animation::set_cullingType");
			Animation.get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Animation.get_localBounds_InjectedDelegate>("UnityEngine.Animation::get_localBounds_Injected");
			Animation.set_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Animation.set_localBounds_InjectedDelegate>("UnityEngine.Animation::set_localBounds_Injected");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000631C File Offset: 0x0000451C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483743, XrefRangeEnd = 483746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000635C File Offset: 0x0000455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483746, XrefRangeEnd = 483750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationState GetStateAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.NativeMethodInfoPtr_GetStateAtIndex_Internal_AnimationState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr3) : null;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000063A8 File Offset: 0x000045A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483750, XrefRangeEnd = 483754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStateCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.NativeMethodInfoPtr_GetStateCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002087 File Offset: 0x00000287
		public Animation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000063E4 File Offset: 0x000045E4
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002090 File Offset: 0x00000290
		public AnimationClip clip
		{
			get
			{
				IntPtr intPtr = Animation.get_clipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				Animation.set_clipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020A8 File Offset: 0x000002A8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020BA File Offset: 0x000002BA
		public bool playAutomatically
		{
			get
			{
				return Animation.get_playAutomaticallyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_playAutomaticallyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000020CD File Offset: 0x000002CD
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020DF File Offset: 0x000002DF
		public WrapMode wrapMode
		{
			get
			{
				return Animation.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020F2 File Offset: 0x000002F2
		public void Stop()
		{
			Animation.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002104 File Offset: 0x00000304
		public void Stop(string name)
		{
			this.StopNamed(name);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000210F File Offset: 0x0000030F
		public void StopNamed(string name)
		{
			Animation.StopNamedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002127 File Offset: 0x00000327
		public void Rewind()
		{
			Animation.RewindDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002139 File Offset: 0x00000339
		public void Rewind(string name)
		{
			this.RewindNamed(name);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002144 File Offset: 0x00000344
		public void RewindNamed(string name)
		{
			Animation.RewindNamedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000215C File Offset: 0x0000035C
		public void Sample()
		{
			Animation.SampleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000216E File Offset: 0x0000036E
		public bool isPlaying
		{
			get
			{
				return Animation.get_isPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002180 File Offset: 0x00000380
		public bool IsPlaying(string name)
		{
			return Animation.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x17000005 RID: 5
		public AnimationState this[string name]
		{
			get
			{
				return this.GetState(name);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000642C File Offset: 0x0000462C
		public bool Play()
		{
			return this.Play(PlayMode.StopSameLayer);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006448 File Offset: 0x00004648
		public bool Play(PlayMode mode)
		{
			return this.PlayDefaultAnimation(mode);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002198 File Offset: 0x00000398
		public bool PlayDefaultAnimation(PlayMode mode)
		{
			return Animation.PlayDefaultAnimationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00006464 File Offset: 0x00004664
		public bool Play(string animation)
		{
			return this.Play(animation, PlayMode.StopSameLayer);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021AB File Offset: 0x000003AB
		public bool Play(string animation, PlayMode mode)
		{
			return Animation.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), mode);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021C4 File Offset: 0x000003C4
		public void CrossFade(string animation)
		{
			this.CrossFade(animation, 0.3f);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021D4 File Offset: 0x000003D4
		public void CrossFade(string animation, float fadeLength)
		{
			this.CrossFade(animation, fadeLength, PlayMode.StopSameLayer);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021E1 File Offset: 0x000003E1
		public void CrossFade(string animation, float fadeLength, PlayMode mode)
		{
			Animation.CrossFadeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), fadeLength, mode);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021FB File Offset: 0x000003FB
		public void Blend(string animation)
		{
			this.Blend(animation, 1f);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000220B File Offset: 0x0000040B
		public void Blend(string animation, float targetWeight)
		{
			this.Blend(animation, targetWeight, 0.3f);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000221C File Offset: 0x0000041C
		public void Blend(string animation, float targetWeight, float fadeLength)
		{
			Animation.BlendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), targetWeight, fadeLength);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006480 File Offset: 0x00004680
		public AnimationState CrossFadeQueued(string animation)
		{
			return this.CrossFadeQueued(animation, 0.3f);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000064A0 File Offset: 0x000046A0
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			return this.CrossFadeQueued(animation, fadeLength, QueueMode.CompleteOthers);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000064BC File Offset: 0x000046BC
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			return this.CrossFadeQueued(animation, fadeLength, queue, PlayMode.StopSameLayer);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000064D8 File Offset: 0x000046D8
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode)
		{
			IntPtr intPtr = Animation.CrossFadeQueuedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), fadeLength, queue, mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006510 File Offset: 0x00004710
		public AnimationState PlayQueued(string animation)
		{
			return this.PlayQueued(animation, QueueMode.CompleteOthers);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000652C File Offset: 0x0000472C
		public AnimationState PlayQueued(string animation, QueueMode queue)
		{
			return this.PlayQueued(animation, queue, PlayMode.StopSameLayer);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006548 File Offset: 0x00004748
		public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode)
		{
			IntPtr intPtr = Animation.PlayQueuedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(animation), queue, mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002236 File Offset: 0x00000436
		public void AddClip(AnimationClip clip, string newName)
		{
			this.AddClip(clip, newName, int.MinValue, int.MaxValue);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000224C File Offset: 0x0000044C
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
			this.AddClip(clip, newName, firstFrame, lastFrame, false);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000225C File Offset: 0x0000045C
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame)
		{
			Animation.AddClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.ManagedStringToIl2Cpp(newName), firstFrame, lastFrame, addLoopFrame);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000227F File Offset: 0x0000047F
		public void RemoveClip(AnimationClip clip)
		{
			Animation.RemoveClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002297 File Offset: 0x00000497
		public void RemoveClip(string clipName)
		{
			this.RemoveClipNamed(clipName);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022A2 File Offset: 0x000004A2
		public void RemoveClipNamed(string clipName)
		{
			Animation.RemoveClipNamedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(clipName));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022BA File Offset: 0x000004BA
		public int GetClipCount()
		{
			return Animation.GetClipCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000657C File Offset: 0x0000477C
		public bool Play(AnimationPlayMode mode)
		{
			return this.PlayDefaultAnimation((PlayMode)mode);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006598 File Offset: 0x00004798
		public bool Play(string animation, AnimationPlayMode mode)
		{
			return this.Play(animation, (PlayMode)mode);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000022CC File Offset: 0x000004CC
		public void SyncLayer(int layer)
		{
			Animation.SyncLayerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layer);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000065B4 File Offset: 0x000047B4
		public AnimationState GetState(string name)
		{
			IntPtr intPtr = Animation.GetStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000065E8 File Offset: 0x000047E8
		public AnimationClip GetClip(string name)
		{
			AnimationState state = this.GetState(name);
			bool flag = state;
			AnimationClip animationClip;
			if (flag)
			{
				animationClip = state.clip;
			}
			else
			{
				animationClip = null;
			}
			return animationClip;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000022DF File Offset: 0x000004DF
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000022F1 File Offset: 0x000004F1
		public bool animatePhysics
		{
			get
			{
				return Animation.get_animatePhysicsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_animatePhysicsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002304 File Offset: 0x00000504
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002316 File Offset: 0x00000516
		public bool animateOnlyIfVisible
		{
			get
			{
				return Animation.get_animateOnlyIfVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_animateOnlyIfVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002329 File Offset: 0x00000529
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000233B File Offset: 0x0000053B
		public AnimationCullingType cullingType
		{
			get
			{
				return Animation.get_cullingTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Animation.set_cullingTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000234E File Offset: 0x0000054E
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002358 File Offset: 0x00000558
		public void get_localBounds_Injected(out Bounds ret)
		{
			Animation.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000236B File Offset: 0x0000056B
		public void set_localBounds_Injected(ref Bounds value)
		{
			Animation.set_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_GetStateAtIndex_Internal_AnimationState_Int32_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetStateCount_Internal_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly Animation.get_clipDelegate get_clipDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly Animation.set_clipDelegate set_clipDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly Animation.get_playAutomaticallyDelegate get_playAutomaticallyDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly Animation.set_playAutomaticallyDelegate set_playAutomaticallyDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly Animation.get_wrapModeDelegate get_wrapModeDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly Animation.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly Animation.StopDelegate StopDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly Animation.StopNamedDelegate StopNamedDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly Animation.RewindDelegate RewindDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly Animation.RewindNamedDelegate RewindNamedDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly Animation.SampleDelegate SampleDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly Animation.get_isPlayingDelegate get_isPlayingDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly Animation.IsPlayingDelegate IsPlayingDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly Animation.PlayDefaultAnimationDelegate PlayDefaultAnimationDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly Animation.PlayDelegate PlayDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly Animation.CrossFadeDelegate CrossFadeDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly Animation.BlendDelegate BlendDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly Animation.CrossFadeQueuedDelegate CrossFadeQueuedDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly Animation.PlayQueuedDelegate PlayQueuedDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly Animation.AddClipDelegate AddClipDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly Animation.RemoveClipDelegate RemoveClipDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly Animation.RemoveClipNamedDelegate RemoveClipNamedDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Animation.GetClipCountDelegate GetClipCountDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Animation.SyncLayerDelegate SyncLayerDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Animation.GetStateDelegate GetStateDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Animation.get_animatePhysicsDelegate get_animatePhysicsDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Animation.set_animatePhysicsDelegate set_animatePhysicsDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Animation.get_animateOnlyIfVisibleDelegate get_animateOnlyIfVisibleDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Animation.set_animateOnlyIfVisibleDelegate set_animateOnlyIfVisibleDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Animation.get_cullingTypeDelegate get_cullingTypeDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Animation.set_cullingTypeDelegate set_cullingTypeDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Animation.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Animation.set_localBounds_InjectedDelegate set_localBounds_InjectedDelegateField;

		// Token: 0x0200005F RID: 95
		public sealed class Enumerator : Object
		{
			// Token: 0x060005A5 RID: 1445 RVA: 0x0000F53C File Offset: 0x0000D73C
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Animation>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr);
				Animation.Enumerator.NativeFieldInfoPtr_m_Outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr, "m_Outer");
				Animation.Enumerator.NativeFieldInfoPtr_m_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr, "m_CurrentIndex");
				Animation.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Animation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr, 100663315);
				Animation.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr, 100663316);
				Animation.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr, 100663317);
				Animation.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr, 100663318);
			}

			// Token: 0x060005A6 RID: 1446 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
			[CallerCount(0)]
			public unsafe Enumerator(Animation outer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Animation.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(outer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Animation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0000F62C File Offset: 0x0000D82C
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483736, XrefRangeEnd = 483741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x0000F66C File Offset: 0x0000D86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483741, XrefRangeEnd = 483743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animation.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x000058B1 File Offset: 0x00003AB1
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000F6DC File Offset: 0x0000D8DC
			// (set) Token: 0x060005AC RID: 1452 RVA: 0x000058BA File Offset: 0x00003ABA
			public unsafe Animation m_Outer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Animation.Enumerator.NativeFieldInfoPtr_m_Outer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Animation.Enumerator.NativeFieldInfoPtr_m_Outer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000F70C File Offset: 0x0000D90C
			// (set) Token: 0x060005AE RID: 1454 RVA: 0x000058D9 File Offset: 0x00003AD9
			public unsafe int m_CurrentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Animation.Enumerator.NativeFieldInfoPtr_m_CurrentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Animation.Enumerator.NativeFieldInfoPtr_m_CurrentIndex)) = value;
				}
			}

			// Token: 0x0400042F RID: 1071
			private static readonly IntPtr NativeFieldInfoPtr_m_Outer;

			// Token: 0x04000430 RID: 1072
			private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndex;

			// Token: 0x04000431 RID: 1073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Animation_0;

			// Token: 0x04000432 RID: 1074
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04000433 RID: 1075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04000434 RID: 1076
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060005B0 RID: 1456
		private delegate IntPtr get_clipDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060005B2 RID: 1458
		private delegate void set_clipDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060005B4 RID: 1460
		private delegate bool get_playAutomaticallyDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060005B6 RID: 1462
		private delegate void set_playAutomaticallyDelegate(IntPtr @this, bool value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060005B8 RID: 1464
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060005BA RID: 1466
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060005BC RID: 1468
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060005BE RID: 1470
		private delegate void StopNamedDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060005C0 RID: 1472
		private delegate void RewindDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060005C2 RID: 1474
		private delegate void RewindNamedDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060005C4 RID: 1476
		private delegate void SampleDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060005C6 RID: 1478
		private delegate bool get_isPlayingDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060005C8 RID: 1480
		private delegate bool IsPlayingDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060005CA RID: 1482
		private delegate bool PlayDefaultAnimationDelegate(IntPtr @this, PlayMode mode);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060005CC RID: 1484
		private delegate bool PlayDelegate(IntPtr @this, IntPtr animation, PlayMode mode);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060005CE RID: 1486
		private delegate void CrossFadeDelegate(IntPtr @this, IntPtr animation, float fadeLength, PlayMode mode);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060005D0 RID: 1488
		private delegate void BlendDelegate(IntPtr @this, IntPtr animation, float targetWeight, float fadeLength);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060005D2 RID: 1490
		private delegate IntPtr CrossFadeQueuedDelegate(IntPtr @this, IntPtr animation, float fadeLength, QueueMode queue, PlayMode mode);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060005D4 RID: 1492
		private delegate IntPtr PlayQueuedDelegate(IntPtr @this, IntPtr animation, QueueMode queue, PlayMode mode);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060005D6 RID: 1494
		private delegate void AddClipDelegate(IntPtr @this, IntPtr clip, IntPtr newName, int firstFrame, int lastFrame, bool addLoopFrame);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060005D8 RID: 1496
		private delegate void RemoveClipDelegate(IntPtr @this, IntPtr clip);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060005DA RID: 1498
		private delegate void RemoveClipNamedDelegate(IntPtr @this, IntPtr clipName);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060005DC RID: 1500
		private delegate int GetClipCountDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060005DE RID: 1502
		private delegate void SyncLayerDelegate(IntPtr @this, int layer);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060005E0 RID: 1504
		private delegate IntPtr GetStateDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060005E2 RID: 1506
		private delegate bool get_animatePhysicsDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060005E4 RID: 1508
		private delegate void set_animatePhysicsDelegate(IntPtr @this, bool value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060005E6 RID: 1510
		private delegate bool get_animateOnlyIfVisibleDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060005E8 RID: 1512
		private delegate void set_animateOnlyIfVisibleDelegate(IntPtr @this, bool value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060005EA RID: 1514
		private delegate AnimationCullingType get_cullingTypeDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060005EC RID: 1516
		private delegate void set_cullingTypeDelegate(IntPtr @this, AnimationCullingType value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060005EE RID: 1518
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060005F0 RID: 1520
		private delegate void set_localBounds_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
