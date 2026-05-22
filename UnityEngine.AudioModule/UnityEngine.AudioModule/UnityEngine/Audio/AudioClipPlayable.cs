using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct AudioClipPlayable
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00005EF0 File Offset: 0x000040F0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClipPlayable()
		{
			Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr);
			AudioClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, "m_Handle");
			AudioClipPlayable.NativeMethodInfoPtr_Create_Public_Static_AudioClipPlayable_PlayableGraph_AudioClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663411);
			AudioClipPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AudioClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663412);
			AudioClipPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663413);
			AudioClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663414);
			AudioClipPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663415);
			AudioClipPlayable.NativeMethodInfoPtr_op_Explicit_Public_Static_AudioClipPlayable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663416);
			AudioClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663417);
			AudioClipPlayable.NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663418);
			AudioClipPlayable.NativeMethodInfoPtr_SetStereoPan_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663419);
			AudioClipPlayable.NativeMethodInfoPtr_SetSpatialBlend_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663420);
			AudioClipPlayable.NativeMethodInfoPtr_Seek_Public_Void_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663421);
			AudioClipPlayable.NativeMethodInfoPtr_SetVolumeInternal_Private_Static_Void_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663422);
			AudioClipPlayable.NativeMethodInfoPtr_SetStereoPanInternal_Private_Static_Void_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663423);
			AudioClipPlayable.NativeMethodInfoPtr_SetSpatialBlendInternal_Private_Static_Void_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663424);
			AudioClipPlayable.NativeMethodInfoPtr_SetStartDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663425);
			AudioClipPlayable.NativeMethodInfoPtr_SetPauseDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663426);
			AudioClipPlayable.NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Private_Static_Boolean_byref_PlayableGraph_AudioClip_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663427);
			AudioClipPlayable.GetClipInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetClipInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetClipInternal");
			AudioClipPlayable.SetClipInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetClipInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetClipInternal");
			AudioClipPlayable.GetLoopedInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetLoopedInternal");
			AudioClipPlayable.SetLoopedInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetLoopedInternal");
			AudioClipPlayable.GetVolumeInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetVolumeInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetVolumeInternal");
			AudioClipPlayable.GetStereoPanInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetStereoPanInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStereoPanInternal");
			AudioClipPlayable.GetSpatialBlendInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetSpatialBlendInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetSpatialBlendInternal");
			AudioClipPlayable.GetIsChannelPlayingInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetIsChannelPlayingInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetIsChannelPlayingInternal");
			AudioClipPlayable.GetStartDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetStartDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStartDelayInternal");
			AudioClipPlayable.GetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetPauseDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetPauseDelayInternal");
			AudioClipPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.ValidateTypeDelegate>("UnityEngine.Audio.AudioClipPlayable::ValidateType");
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006130 File Offset: 0x00004330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485339, RefRangeEnd = 485340, XrefRangeStart = 485284, XrefRangeEnd = 485339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref looping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_Create_Public_Static_AudioClipPlayable_PlayableGraph_AudioClip_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006190 File Offset: 0x00004390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485340, XrefRangeEnd = 485358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref looping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AudioClip_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000061F0 File Offset: 0x000043F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485358, XrefRangeEnd = 485362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClipPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006224 File Offset: 0x00004424
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006254 File Offset: 0x00004454
		[CallerCount(0)]
		public unsafe static implicit operator Playable(AudioClipPlayable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioClipPlayable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006294 File Offset: 0x00004494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 485378, RefRangeEnd = 485381, XrefRangeStart = 485362, XrefRangeEnd = 485378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator AudioClipPlayable(Playable playable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_op_Explicit_Public_Static_AudioClipPlayable_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000062D4 File Offset: 0x000044D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485381, XrefRangeEnd = 485388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AudioClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006314 File Offset: 0x00004514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485400, RefRangeEnd = 485402, XrefRangeStart = 485388, XrefRangeEnd = 485400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006348 File Offset: 0x00004548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485414, RefRangeEnd = 485416, XrefRangeStart = 485402, XrefRangeEnd = 485414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoPan(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetStereoPan_Internal_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000637C File Offset: 0x0000457C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485428, RefRangeEnd = 485430, XrefRangeStart = 485416, XrefRangeEnd = 485428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpatialBlend(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetSpatialBlend_Internal_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000063B0 File Offset: 0x000045B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485444, RefRangeEnd = 485445, XrefRangeStart = 485430, XrefRangeEnd = 485444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Seek(double startTime, double startDelay, double duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_Seek_Public_Void_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006400 File Offset: 0x00004600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485445, XrefRangeEnd = 485449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVolumeInternal(ref PlayableHandle hdl, float volume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hdl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetVolumeInternal_Private_Static_Void_byref_PlayableHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006440 File Offset: 0x00004640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485449, XrefRangeEnd = 485453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hdl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoPan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetStereoPanInternal_Private_Static_Void_byref_PlayableHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006480 File Offset: 0x00004680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485453, XrefRangeEnd = 485457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hdl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spatialBlend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetSpatialBlendInternal_Private_Static_Void_byref_PlayableHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000064C0 File Offset: 0x000046C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485457, XrefRangeEnd = 485461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hdl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetStartDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006500 File Offset: 0x00004700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485465, RefRangeEnd = 485466, XrefRangeStart = 485461, XrefRangeEnd = 485465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hdl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_SetPauseDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006540 File Offset: 0x00004740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485466, XrefRangeEnd = 485470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref looping;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Private_Static_Boolean_byref_PlayableGraph_AudioClip_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000268A File Offset: 0x0000088A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000065AC File Offset: 0x000047AC
		public AudioClip GetClip()
		{
			return AudioClipPlayable.GetClipInternal(ref this.m_Handle);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000269C File Offset: 0x0000089C
		public void SetClip(AudioClip value)
		{
			AudioClipPlayable.SetClipInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000065CC File Offset: 0x000047CC
		public bool GetLooped()
		{
			return AudioClipPlayable.GetLoopedInternal(ref this.m_Handle);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000026AC File Offset: 0x000008AC
		public void SetLooped(bool value)
		{
			AudioClipPlayable.SetLoopedInternal(ref this.m_Handle, value);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000065EC File Offset: 0x000047EC
		public float GetVolume()
		{
			return AudioClipPlayable.GetVolumeInternal(ref this.m_Handle);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000660C File Offset: 0x0000480C
		public float GetStereoPan()
		{
			return AudioClipPlayable.GetStereoPanInternal(ref this.m_Handle);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000662C File Offset: 0x0000482C
		public float GetSpatialBlend()
		{
			return AudioClipPlayable.GetSpatialBlendInternal(ref this.m_Handle);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000664C File Offset: 0x0000484C
		public bool IsPlaying()
		{
			return this.IsChannelPlaying();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006664 File Offset: 0x00004864
		public bool IsChannelPlaying()
		{
			return AudioClipPlayable.GetIsChannelPlayingInternal(ref this.m_Handle);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006684 File Offset: 0x00004884
		public double GetStartDelay()
		{
			return AudioClipPlayable.GetStartDelayInternal(ref this.m_Handle);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000026BC File Offset: 0x000008BC
		public void SetStartDelay(double value)
		{
			AudioClipPlayable.SetStartDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000066A4 File Offset: 0x000048A4
		public double GetPauseDelay()
		{
			return AudioClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000066C4 File Offset: 0x000048C4
		public void GetPauseDelay(double value)
		{
			double pauseDelayInternal = AudioClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
			bool flag = this.m_Handle.GetPlayState() == PlayState.Playing && (value < 0.05 || (pauseDelayInternal != 0.0 && pauseDelayInternal < 0.05));
			if (flag)
			{
				throw new ArgumentException(String.Concat("AudioClipPlayable.pauseDelay: Setting new delay when existing delay is too small or 0.0 (", pauseDelayInternal.ToString(), "), audio system will not be able to change in time"));
			}
			AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000026CC File Offset: 0x000008CC
		public void Seek(double startTime, double startDelay)
		{
			this.Seek(startTime, startDelay, 0.0);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006748 File Offset: 0x00004948
		public static AudioClip GetClipInternal(ref PlayableHandle hdl)
		{
			IntPtr intPtr = AudioClipPlayable.GetClipInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000026E1 File Offset: 0x000008E1
		public static void SetClipInternal(ref PlayableHandle hdl, AudioClip clip)
		{
			AudioClipPlayable.SetClipInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026F4 File Offset: 0x000008F4
		public static bool GetLoopedInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetLoopedInternalDelegateField(ref hdl);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002701 File Offset: 0x00000901
		public static void SetLoopedInternal(ref PlayableHandle hdl, bool looped)
		{
			AudioClipPlayable.SetLoopedInternalDelegateField(ref hdl, looped);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000270F File Offset: 0x0000090F
		public static float GetVolumeInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetVolumeInternalDelegateField(ref hdl);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000271C File Offset: 0x0000091C
		public static float GetStereoPanInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetStereoPanInternalDelegateField(ref hdl);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002729 File Offset: 0x00000929
		public static float GetSpatialBlendInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetSpatialBlendInternalDelegateField(ref hdl);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002736 File Offset: 0x00000936
		public static bool GetIsChannelPlayingInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetIsChannelPlayingInternalDelegateField(ref hdl);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002743 File Offset: 0x00000943
		public static double GetStartDelayInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetStartDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002750 File Offset: 0x00000950
		public static double GetPauseDelayInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetPauseDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000275D File Offset: 0x0000095D
		public static bool ValidateType(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioClipPlayable_PlayableGraph_AudioClip_Boolean_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AudioClip_Boolean_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioClipPlayable_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AudioClipPlayable_Playable_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoPan_Internal_Void_Single_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_SetSpatialBlend_Internal_Void_Single_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Void_Double_Double_Double_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_SetVolumeInternal_Private_Static_Void_byref_PlayableHandle_Single_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoPanInternal_Private_Static_Void_byref_PlayableHandle_Single_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_SetSpatialBlendInternal_Private_Static_Void_byref_PlayableHandle_Single_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_SetStartDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_SetPauseDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Private_Static_Boolean_byref_PlayableGraph_AudioClip_Boolean_byref_PlayableHandle_0;

		// Token: 0x040000EE RID: 238
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040000EF RID: 239
		private static readonly AudioClipPlayable.GetClipInternalDelegate GetClipInternalDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly AudioClipPlayable.SetClipInternalDelegate SetClipInternalDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly AudioClipPlayable.GetLoopedInternalDelegate GetLoopedInternalDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly AudioClipPlayable.SetLoopedInternalDelegate SetLoopedInternalDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly AudioClipPlayable.GetVolumeInternalDelegate GetVolumeInternalDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly AudioClipPlayable.GetStereoPanInternalDelegate GetStereoPanInternalDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly AudioClipPlayable.GetSpatialBlendInternalDelegate GetSpatialBlendInternalDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly AudioClipPlayable.GetIsChannelPlayingInternalDelegate GetIsChannelPlayingInternalDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly AudioClipPlayable.GetStartDelayInternalDelegate GetStartDelayInternalDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly AudioClipPlayable.GetPauseDelayInternalDelegate GetPauseDelayInternalDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly AudioClipPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060002A4 RID: 676
		private delegate IntPtr GetClipInternalDelegate(IntPtr hdl);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060002A6 RID: 678
		private delegate void SetClipInternalDelegate(IntPtr hdl, IntPtr clip);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060002A8 RID: 680
		private delegate bool GetLoopedInternalDelegate(IntPtr hdl);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060002AA RID: 682
		private delegate void SetLoopedInternalDelegate(IntPtr hdl, bool looped);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060002AC RID: 684
		private delegate float GetVolumeInternalDelegate(IntPtr hdl);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060002AE RID: 686
		private delegate float GetStereoPanInternalDelegate(IntPtr hdl);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060002B0 RID: 688
		private delegate float GetSpatialBlendInternalDelegate(IntPtr hdl);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060002B2 RID: 690
		private delegate bool GetIsChannelPlayingInternalDelegate(IntPtr hdl);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060002B4 RID: 692
		private delegate double GetStartDelayInternalDelegate(IntPtr hdl);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060002B6 RID: 694
		private delegate double GetPauseDelayInternalDelegate(IntPtr hdl);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060002B8 RID: 696
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
