using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000035 RID: 53
	public class SECTR_AudioCue : ScriptableObject
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x0004D8A8 File Offset: 0x0004BAA8
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioCue()
		{
			Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioCue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr);
			SECTR_AudioCue.NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "template");
			SECTR_AudioCue.NativeFieldInfoPtr_bus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "bus");
			SECTR_AudioCue.NativeFieldInfoPtr_clipPlaybackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "clipPlaybackIndex");
			SECTR_AudioCue.NativeFieldInfoPtr_needsShuffling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "needsShuffling");
			SECTR_AudioCue.NativeFieldInfoPtr_pingPongIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "pingPongIncrement");
			SECTR_AudioCue.NativeFieldInfoPtr_LoopThroughCued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "LoopThroughCued");
			SECTR_AudioCue.NativeFieldInfoPtr_RollOffCurveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "RollOffCurveIndex");
			SECTR_AudioCue.NativeFieldInfoPtr_AudioClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "AudioClips");
			SECTR_AudioCue.NativeFieldInfoPtr_ClipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "ClipCount");
			SECTR_AudioCue.NativeFieldInfoPtr_PlaybackMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "PlaybackMode");
			SECTR_AudioCue.NativeFieldInfoPtr_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "HDR");
			SECTR_AudioCue.NativeFieldInfoPtr_Loudness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Loudness");
			SECTR_AudioCue.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Volume");
			SECTR_AudioCue.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Pitch");
			SECTR_AudioCue.NativeFieldInfoPtr_Loops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Loops");
			SECTR_AudioCue.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Priority");
			SECTR_AudioCue.NativeFieldInfoPtr_BypassEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "BypassEffects");
			SECTR_AudioCue.NativeFieldInfoPtr_MaxInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "MaxInstances");
			SECTR_AudioCue.NativeFieldInfoPtr_FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "FadeInTime");
			SECTR_AudioCue.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "FadeOutTime");
			SECTR_AudioCue.NativeFieldInfoPtr_Spatialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Spatialization");
			SECTR_AudioCue.NativeFieldInfoPtr_Spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Spread");
			SECTR_AudioCue.NativeFieldInfoPtr_Pan2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Pan2D");
			SECTR_AudioCue.NativeFieldInfoPtr_Falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Falloff");
			SECTR_AudioCue.NativeFieldInfoPtr_ResonanceSourceDirectivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "ResonanceSourceDirectivity");
			SECTR_AudioCue.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "MaxDistance");
			SECTR_AudioCue.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "MinDistance");
			SECTR_AudioCue.NativeFieldInfoPtr_DopplerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "DopplerLevel");
			SECTR_AudioCue.NativeFieldInfoPtr_ProximityLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "ProximityLimit");
			SECTR_AudioCue.NativeFieldInfoPtr_ProximityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "ProximityRange");
			SECTR_AudioCue.NativeFieldInfoPtr_OcclusionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "OcclusionScale");
			SECTR_AudioCue.NativeFieldInfoPtr_PlayProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "PlayProbability");
			SECTR_AudioCue.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Delay");
			SECTR_AudioCue.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "Prefab");
			SECTR_AudioCue.NativeFieldInfoPtr_ControlParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "ControlParams");
			SECTR_AudioCue.NativeMethodInfoPtr_set_Template_Public_set_Void_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663933);
			SECTR_AudioCue.NativeMethodInfoPtr_get_Template_Public_get_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663934);
			SECTR_AudioCue.NativeMethodInfoPtr_set_Bus_Public_set_Void_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663935);
			SECTR_AudioCue.NativeMethodInfoPtr_get_Bus_Public_get_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663936);
			SECTR_AudioCue.NativeMethodInfoPtr_get_SourceCue_Public_get_SECTR_AudioCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663937);
			SECTR_AudioCue.NativeMethodInfoPtr_get_Is3D_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663938);
			SECTR_AudioCue.NativeMethodInfoPtr_get_IsLocal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663939);
			SECTR_AudioCue.NativeMethodInfoPtr_get_ClipIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663940);
			SECTR_AudioCue.NativeMethodInfoPtr_GetNextClip_Public_ClipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663941);
			SECTR_AudioCue.NativeMethodInfoPtr_MinClipLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663942);
			SECTR_AudioCue.NativeMethodInfoPtr_MaxClipLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663943);
			SECTR_AudioCue.NativeMethodInfoPtr_ResetClipIndex_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663944);
			SECTR_AudioCue.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663945);
			SECTR_AudioCue.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663946);
			SECTR_AudioCue.NativeMethodInfoPtr__ShuffleClips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663947);
			SECTR_AudioCue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, 100663948);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0004DD18 File Offset: 0x0004BF18
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x0004DCD4 File Offset: 0x0004BED4
		public unsafe SECTR_AudioCue Template
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_get_Template_Public_get_SECTR_AudioCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37144, XrefRangeEnd = 37175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_set_Template_Public_set_Void_SECTR_AudioCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0004DD9C File Offset: 0x0004BF9C
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0004DD58 File Offset: 0x0004BF58
		public unsafe SECTR_AudioBus Bus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_get_Bus_Public_get_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37175, XrefRangeEnd = 37191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_set_Bus_Public_set_Void_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0004DDDC File Offset: 0x0004BFDC
		public unsafe SECTR_AudioCue SourceCue
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 37203, RefRangeEnd = 37228, XrefRangeStart = 37191, XrefRangeEnd = 37203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_get_SourceCue_Public_get_SECTR_AudioCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr3) : null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0004DE1C File Offset: 0x0004C01C
		public unsafe bool Is3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_get_Is3D_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0004DE58 File Offset: 0x0004C058
		public unsafe bool IsLocal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_get_IsLocal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0004DE94 File Offset: 0x0004C094
		public unsafe int ClipIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_get_ClipIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0004DED0 File Offset: 0x0004C0D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37244, RefRangeEnd = 37245, XrefRangeStart = 37228, XrefRangeEnd = 37244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCue.ClipData GetNextClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_GetNextClip_Public_ClipData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue.ClipData>(intPtr3) : null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0004DF10 File Offset: 0x0004C110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37245, XrefRangeEnd = 37252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MinClipLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_MinClipLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0004DF4C File Offset: 0x0004C14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37252, XrefRangeEnd = 37258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MaxClipLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_MaxClipLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0004DF88 File Offset: 0x0004C188
		[CallerCount(0)]
		public unsafe void ResetClipIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_ResetClipIndex_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0004DFBC File Offset: 0x0004C1BC
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0004DFF0 File Offset: 0x0004C1F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0004E024 File Offset: 0x0004C224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37258, XrefRangeEnd = 37264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShuffleClips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr__ShuffleClips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0004E058 File Offset: 0x0004C258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37264, XrefRangeEnd = 37283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00007BAE File Offset: 0x00005DAE
		public SECTR_AudioCue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0004E094 File Offset: 0x0004C294
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00007BB7 File Offset: 0x00005DB7
		public unsafe SECTR_AudioCue template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0004E0C4 File Offset: 0x0004C2C4
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00007BD6 File Offset: 0x00005DD6
		public unsafe SECTR_AudioBus bus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_bus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_bus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0004E0F4 File Offset: 0x0004C2F4
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public unsafe int clipPlaybackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_clipPlaybackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_clipPlaybackIndex)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0004E11C File Offset: 0x0004C31C
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00007C10 File Offset: 0x00005E10
		public unsafe bool needsShuffling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_needsShuffling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_needsShuffling)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0004E144 File Offset: 0x0004C344
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00007C2B File Offset: 0x00005E2B
		public unsafe bool pingPongIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_pingPongIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_pingPongIncrement)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0004E16C File Offset: 0x0004C36C
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00007C46 File Offset: 0x00005E46
		public unsafe bool LoopThroughCued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_LoopThroughCued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_LoopThroughCued)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0004E194 File Offset: 0x0004C394
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00007C61 File Offset: 0x00005E61
		public unsafe int RollOffCurveIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_RollOffCurveIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_RollOffCurveIndex)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0004E1BC File Offset: 0x0004C3BC
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00007C7C File Offset: 0x00005E7C
		public unsafe List<SECTR_AudioCue.ClipData> AudioClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_AudioClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioCue.ClipData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_AudioClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0004E1EC File Offset: 0x0004C3EC
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00007C9B File Offset: 0x00005E9B
		public unsafe int ClipCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ClipCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ClipCount)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0004E214 File Offset: 0x0004C414
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00007CB6 File Offset: 0x00005EB6
		public unsafe SECTR_AudioCue.PlaybackModes PlaybackMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_PlaybackMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_PlaybackMode)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0004E23C File Offset: 0x0004C43C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00007CD1 File Offset: 0x00005ED1
		public unsafe bool HDR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_HDR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_HDR)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0004E264 File Offset: 0x0004C464
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00007CEC File Offset: 0x00005EEC
		public unsafe Vector2 Loudness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Loudness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Loudness)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0004E28C File Offset: 0x0004C48C
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00007D07 File Offset: 0x00005F07
		public unsafe Vector2 Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00007D22 File Offset: 0x00005F22
		public unsafe Vector2 Pitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Pitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Pitch)) = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00007D3D File Offset: 0x00005F3D
		public unsafe bool Loops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Loops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Loops)) = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0004E304 File Offset: 0x0004C504
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00007D58 File Offset: 0x00005F58
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0004E32C File Offset: 0x0004C52C
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00007D73 File Offset: 0x00005F73
		public unsafe bool BypassEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_BypassEffects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_BypassEffects)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0004E354 File Offset: 0x0004C554
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00007D8E File Offset: 0x00005F8E
		public unsafe int MaxInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_MaxInstances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_MaxInstances)) = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0004E37C File Offset: 0x0004C57C
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00007DA9 File Offset: 0x00005FA9
		public unsafe float FadeInTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_FadeInTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_FadeInTime)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00007DC4 File Offset: 0x00005FC4
		public unsafe float FadeOutTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_FadeOutTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_FadeOutTime)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0004E3CC File Offset: 0x0004C5CC
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00007DDF File Offset: 0x00005FDF
		public unsafe SECTR_AudioCue.Spatializations Spatialization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Spatialization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Spatialization)) = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0004E3F4 File Offset: 0x0004C5F4
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00007DFA File Offset: 0x00005FFA
		public unsafe float Spread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Spread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Spread)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0004E41C File Offset: 0x0004C61C
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00007E15 File Offset: 0x00006015
		public unsafe float Pan2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Pan2D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Pan2D)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0004E444 File Offset: 0x0004C644
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00007E30 File Offset: 0x00006030
		public unsafe SECTR_AudioCue.FalloffTypes Falloff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Falloff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Falloff)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0004E46C File Offset: 0x0004C66C
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00007E4B File Offset: 0x0000604B
		public unsafe float ResonanceSourceDirectivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ResonanceSourceDirectivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ResonanceSourceDirectivity)) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0004E494 File Offset: 0x0004C694
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00007E66 File Offset: 0x00006066
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00007E81 File Offset: 0x00006081
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0004E4E4 File Offset: 0x0004C6E4
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00007E9C File Offset: 0x0000609C
		public unsafe float DopplerLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_DopplerLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_DopplerLevel)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0004E50C File Offset: 0x0004C70C
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00007EB7 File Offset: 0x000060B7
		public unsafe int ProximityLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ProximityLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ProximityLimit)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0004E534 File Offset: 0x0004C734
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00007ED2 File Offset: 0x000060D2
		public unsafe float ProximityRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ProximityRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ProximityRange)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0004E55C File Offset: 0x0004C75C
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00007EED File Offset: 0x000060ED
		public unsafe float OcclusionScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_OcclusionScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_OcclusionScale)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0004E584 File Offset: 0x0004C784
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00007F08 File Offset: 0x00006108
		public unsafe float PlayProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_PlayProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_PlayProbability)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0004E5AC File Offset: 0x0004C7AC
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00007F23 File Offset: 0x00006123
		public unsafe Vector2 Delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Delay)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0004E5D4 File Offset: 0x0004C7D4
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00007F3E File Offset: 0x0000613E
		public unsafe GameObject Prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0004E604 File Offset: 0x0004C804
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00007F5D File Offset: 0x0000615D
		public unsafe List<SECTR_CueParam> ControlParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ControlParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_CueParam>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.NativeFieldInfoPtr_ControlParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_template;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_bus;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_clipPlaybackIndex;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_needsShuffling;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_pingPongIncrement;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_LoopThroughCued;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_RollOffCurveIndex;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_AudioClips;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_ClipCount;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_PlaybackMode;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_HDR;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_Loudness;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_Pitch;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_Loops;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_BypassEffects;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_MaxInstances;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_FadeInTime;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutTime;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_Spatialization;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_Spread;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_Pan2D;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_Falloff;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_ResonanceSourceDirectivity;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_DopplerLevel;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_ProximityLimit;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_ProximityRange;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionScale;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_PlayProbability;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_Delay;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_Prefab;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_ControlParams;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_SECTR_AudioCue_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_get_Template_Public_get_SECTR_AudioCue_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_set_Bus_Public_set_Void_SECTR_AudioBus_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_get_Bus_Public_get_SECTR_AudioBus_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceCue_Public_get_SECTR_AudioCue_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3D_Public_get_Boolean_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocal_Public_get_Boolean_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_get_ClipIndex_Public_get_Int32_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_GetNextClip_Public_ClipData_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_MinClipLength_Public_Single_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_MaxClipLength_Public_Single_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_ResetClipIndex_Public_Void_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr__ShuffleClips_Private_Void_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B1 RID: 689
		[OriginalName("Assembly-CSharp.dll", "", "PlaybackModes")]
		public enum PlaybackModes
		{
			// Token: 0x04003110 RID: 12560
			Random,
			// Token: 0x04003111 RID: 12561
			Shuffle,
			// Token: 0x04003112 RID: 12562
			Loop,
			// Token: 0x04003113 RID: 12563
			PingPong,
			// Token: 0x04003114 RID: 12564
			LoopThrough,
			// Token: 0x04003115 RID: 12565
			PlatformSpecific
		}

		// Token: 0x020002B2 RID: 690
		[OriginalName("Assembly-CSharp.dll", "", "FalloffTypes")]
		public enum FalloffTypes
		{
			// Token: 0x04003117 RID: 12567
			Linear,
			// Token: 0x04003118 RID: 12568
			Logrithmic
		}

		// Token: 0x020002B3 RID: 691
		[OriginalName("Assembly-CSharp.dll", "", "Spatializations")]
		public enum Spatializations
		{
			// Token: 0x0400311A RID: 12570
			Simple2D,
			// Token: 0x0400311B RID: 12571
			Infinite3D,
			// Token: 0x0400311C RID: 12572
			Local3D,
			// Token: 0x0400311D RID: 12573
			Occludable3D,
			// Token: 0x0400311E RID: 12574
			ResonanceOccludable,
			// Token: 0x0400311F RID: 12575
			ResonanceNoOcclusion
		}

		// Token: 0x020002B4 RID: 692
		[Serializable]
		public class ClipData : global::Il2CppSystem.Object
		{
			// Token: 0x06004AF7 RID: 19191 RVA: 0x001155DC File Offset: 0x001137DC
			// Note: this type is marked as 'beforefieldinit'.
			static ClipData()
			{
				Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_AudioCue>.NativeClassPtr, "ClipData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr);
				SECTR_AudioCue.ClipData.NativeFieldInfoPtr_clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, "clip");
				SECTR_AudioCue.ClipData.NativeFieldInfoPtr_playedInShuffle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, "playedInShuffle");
				SECTR_AudioCue.ClipData.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, "volume");
				SECTR_AudioCue.ClipData.NativeFieldInfoPtr_bakeTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, "bakeTimestamp");
				SECTR_AudioCue.ClipData.NativeFieldInfoPtr_HDRCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, "HDRCurve");
				SECTR_AudioCue.ClipData.NativeMethodInfoPtr__ctor_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, 100663949);
				SECTR_AudioCue.ClipData.NativeMethodInfoPtr_get_Clip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, 100663950);
				SECTR_AudioCue.ClipData.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, 100663951);
				SECTR_AudioCue.ClipData.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, 100663952);
				SECTR_AudioCue.ClipData.NativeMethodInfoPtr_get_PlayedInShuffle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, 100663953);
				SECTR_AudioCue.ClipData.NativeMethodInfoPtr_set_PlayedInShuffle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr, 100663954);
			}

			// Token: 0x06004AF8 RID: 19192 RVA: 0x001156E4 File Offset: 0x001138E4
			[CallerCount(0)]
			public unsafe ClipData(AudioClip clip)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioCue.ClipData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.ClipData.NativeMethodInfoPtr__ctor_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001B42 RID: 6978
			// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x00115730 File Offset: 0x00113930
			public unsafe AudioClip Clip
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.ClipData.NativeMethodInfoPtr_get_Clip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
				}
			}

			// Token: 0x17001B43 RID: 6979
			// (get) Token: 0x06004AFA RID: 19194 RVA: 0x00115770 File Offset: 0x00113970
			// (set) Token: 0x06004AFB RID: 19195 RVA: 0x001157AC File Offset: 0x001139AC
			public unsafe float Volume
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.ClipData.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.ClipData.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001B44 RID: 6980
			// (get) Token: 0x06004AFC RID: 19196 RVA: 0x001157EC File Offset: 0x001139EC
			// (set) Token: 0x06004AFD RID: 19197 RVA: 0x00115828 File Offset: 0x00113A28
			public unsafe bool PlayedInShuffle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.ClipData.NativeMethodInfoPtr_get_PlayedInShuffle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioCue.ClipData.NativeMethodInfoPtr_set_PlayedInShuffle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004AFE RID: 19198 RVA: 0x0002C1AD File Offset: 0x0002A3AD
			public ClipData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B3D RID: 6973
			// (get) Token: 0x06004AFF RID: 19199 RVA: 0x00115868 File Offset: 0x00113A68
			// (set) Token: 0x06004B00 RID: 19200 RVA: 0x0002C1B6 File Offset: 0x0002A3B6
			public unsafe AudioClip clip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_clip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_clip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3E RID: 6974
			// (get) Token: 0x06004B01 RID: 19201 RVA: 0x00115898 File Offset: 0x00113A98
			// (set) Token: 0x06004B02 RID: 19202 RVA: 0x0002C1D5 File Offset: 0x0002A3D5
			public unsafe bool playedInShuffle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_playedInShuffle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_playedInShuffle)) = value;
				}
			}

			// Token: 0x17001B3F RID: 6975
			// (get) Token: 0x06004B03 RID: 19203 RVA: 0x001158C0 File Offset: 0x00113AC0
			// (set) Token: 0x06004B04 RID: 19204 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
			public unsafe float volume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_volume)) = value;
				}
			}

			// Token: 0x17001B40 RID: 6976
			// (get) Token: 0x06004B05 RID: 19205 RVA: 0x001158E8 File Offset: 0x00113AE8
			// (set) Token: 0x06004B06 RID: 19206 RVA: 0x0002C20B File Offset: 0x0002A40B
			public unsafe SECTR_ULong bakeTimestamp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_bakeTimestamp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_ULong>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_bakeTimestamp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B41 RID: 6977
			// (get) Token: 0x06004B07 RID: 19207 RVA: 0x00115918 File Offset: 0x00113B18
			// (set) Token: 0x06004B08 RID: 19208 RVA: 0x0002C22A File Offset: 0x0002A42A
			public unsafe AnimationCurve HDRCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_HDRCurve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioCue.ClipData.NativeFieldInfoPtr_HDRCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003120 RID: 12576
			private static readonly IntPtr NativeFieldInfoPtr_clip;

			// Token: 0x04003121 RID: 12577
			private static readonly IntPtr NativeFieldInfoPtr_playedInShuffle;

			// Token: 0x04003122 RID: 12578
			private static readonly IntPtr NativeFieldInfoPtr_volume;

			// Token: 0x04003123 RID: 12579
			private static readonly IntPtr NativeFieldInfoPtr_bakeTimestamp;

			// Token: 0x04003124 RID: 12580
			private static readonly IntPtr NativeFieldInfoPtr_HDRCurve;

			// Token: 0x04003125 RID: 12581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AudioClip_0;

			// Token: 0x04003126 RID: 12582
			private static readonly IntPtr NativeMethodInfoPtr_get_Clip_Public_get_AudioClip_0;

			// Token: 0x04003127 RID: 12583
			private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

			// Token: 0x04003128 RID: 12584
			private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;

			// Token: 0x04003129 RID: 12585
			private static readonly IntPtr NativeMethodInfoPtr_get_PlayedInShuffle_Public_get_Boolean_0;

			// Token: 0x0400312A RID: 12586
			private static readonly IntPtr NativeMethodInfoPtr_set_PlayedInShuffle_Public_set_Void_Boolean_0;
		}
	}
}
