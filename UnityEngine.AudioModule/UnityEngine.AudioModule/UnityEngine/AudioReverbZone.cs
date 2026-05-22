using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public sealed class AudioReverbZone : Behaviour
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000579C File Offset: 0x0000399C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioReverbZone()
		{
			Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioReverbZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr);
			AudioReverbZone.NativeMethodInfoPtr_set_reverbPreset_Public_set_Void_AudioReverbPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663395);
			AudioReverbZone.NativeMethodInfoPtr_set_room_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663396);
			AudioReverbZone.NativeMethodInfoPtr_set_roomHF_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663397);
			AudioReverbZone.NativeMethodInfoPtr_set_roomLF_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663398);
			AudioReverbZone.NativeMethodInfoPtr_set_decayTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663399);
			AudioReverbZone.NativeMethodInfoPtr_set_decayHFRatio_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663400);
			AudioReverbZone.NativeMethodInfoPtr_set_reflections_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663401);
			AudioReverbZone.NativeMethodInfoPtr_set_reflectionsDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663402);
			AudioReverbZone.NativeMethodInfoPtr_set_reverb_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663403);
			AudioReverbZone.NativeMethodInfoPtr_set_reverbDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663404);
			AudioReverbZone.NativeMethodInfoPtr_set_HFReference_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663405);
			AudioReverbZone.NativeMethodInfoPtr_set_LFReference_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663406);
			AudioReverbZone.NativeMethodInfoPtr_set_diffusion_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663407);
			AudioReverbZone.NativeMethodInfoPtr_set_density_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioReverbZone>.NativeClassPtr, 100663408);
			AudioReverbZone.get_minDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_minDistanceDelegate>("UnityEngine.AudioReverbZone::get_minDistance");
			AudioReverbZone.set_minDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_minDistanceDelegate>("UnityEngine.AudioReverbZone::set_minDistance");
			AudioReverbZone.get_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_maxDistanceDelegate>("UnityEngine.AudioReverbZone::get_maxDistance");
			AudioReverbZone.set_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_maxDistanceDelegate>("UnityEngine.AudioReverbZone::set_maxDistance");
			AudioReverbZone.get_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbPresetDelegate>("UnityEngine.AudioReverbZone::get_reverbPreset");
			AudioReverbZone.get_roomDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomDelegate>("UnityEngine.AudioReverbZone::get_room");
			AudioReverbZone.get_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomHFDelegate>("UnityEngine.AudioReverbZone::get_roomHF");
			AudioReverbZone.get_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomLFDelegate>("UnityEngine.AudioReverbZone::get_roomLF");
			AudioReverbZone.get_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_decayTimeDelegate>("UnityEngine.AudioReverbZone::get_decayTime");
			AudioReverbZone.get_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_decayHFRatioDelegate>("UnityEngine.AudioReverbZone::get_decayHFRatio");
			AudioReverbZone.get_reflectionsDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reflectionsDelegate>("UnityEngine.AudioReverbZone::get_reflections");
			AudioReverbZone.get_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reflectionsDelayDelegate>("UnityEngine.AudioReverbZone::get_reflectionsDelay");
			AudioReverbZone.get_reverbDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbDelegate>("UnityEngine.AudioReverbZone::get_reverb");
			AudioReverbZone.get_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbDelayDelegate>("UnityEngine.AudioReverbZone::get_reverbDelay");
			AudioReverbZone.get_HFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_HFReferenceDelegate>("UnityEngine.AudioReverbZone::get_HFReference");
			AudioReverbZone.get_LFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_LFReferenceDelegate>("UnityEngine.AudioReverbZone::get_LFReference");
			AudioReverbZone.get_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_diffusionDelegate>("UnityEngine.AudioReverbZone::get_diffusion");
			AudioReverbZone.get_densityDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_densityDelegate>("UnityEngine.AudioReverbZone::get_density");
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002530 File Offset: 0x00000730
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000059F4 File Offset: 0x00003BF4
		public unsafe AudioReverbPreset reverbPreset
		{
			get
			{
				return AudioReverbZone.get_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485220, XrefRangeEnd = 485224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_reverbPreset_Public_set_Void_AudioReverbPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002542 File Offset: 0x00000742
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00005A34 File Offset: 0x00003C34
		public unsafe int room
		{
			get
			{
				return AudioReverbZone.get_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485224, XrefRangeEnd = 485228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_room_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002554 File Offset: 0x00000754
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00005A74 File Offset: 0x00003C74
		public unsafe int roomHF
		{
			get
			{
				return AudioReverbZone.get_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485228, XrefRangeEnd = 485232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_roomHF_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002566 File Offset: 0x00000766
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public unsafe int roomLF
		{
			get
			{
				return AudioReverbZone.get_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485232, XrefRangeEnd = 485236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_roomLF_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002578 File Offset: 0x00000778
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public unsafe float decayTime
		{
			get
			{
				return AudioReverbZone.get_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485236, XrefRangeEnd = 485240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_decayTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000258A File Offset: 0x0000078A
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00005B34 File Offset: 0x00003D34
		public unsafe float decayHFRatio
		{
			get
			{
				return AudioReverbZone.get_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485240, XrefRangeEnd = 485244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_decayHFRatio_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000259C File Offset: 0x0000079C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00005B74 File Offset: 0x00003D74
		public unsafe int reflections
		{
			get
			{
				return AudioReverbZone.get_reflectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485244, XrefRangeEnd = 485248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_reflections_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000025AE File Offset: 0x000007AE
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public unsafe float reflectionsDelay
		{
			get
			{
				return AudioReverbZone.get_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485248, XrefRangeEnd = 485252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_reflectionsDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000025C0 File Offset: 0x000007C0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public unsafe int reverb
		{
			get
			{
				return AudioReverbZone.get_reverbDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485252, XrefRangeEnd = 485256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_reverb_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00005C34 File Offset: 0x00003E34
		public unsafe float reverbDelay
		{
			get
			{
				return AudioReverbZone.get_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485256, XrefRangeEnd = 485260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_reverbDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000025E4 File Offset: 0x000007E4
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00005C74 File Offset: 0x00003E74
		public unsafe float HFReference
		{
			get
			{
				return AudioReverbZone.get_HFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485260, XrefRangeEnd = 485264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_HFReference_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000025F6 File Offset: 0x000007F6
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00005CB4 File Offset: 0x00003EB4
		public unsafe float LFReference
		{
			get
			{
				return AudioReverbZone.get_LFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485264, XrefRangeEnd = 485268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_LFReference_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002616 File Offset: 0x00000816
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public unsafe float diffusion
		{
			get
			{
				return AudioReverbZone.get_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485268, XrefRangeEnd = 485272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_diffusion_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00005D34 File Offset: 0x00003F34
		public unsafe float density
		{
			get
			{
				return AudioReverbZone.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485272, XrefRangeEnd = 485276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioReverbZone.NativeMethodInfoPtr_set_density_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000024DD File Offset: 0x000006DD
		public AudioReverbZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000024E6 File Offset: 0x000006E6
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000024F8 File Offset: 0x000006F8
		public float minDistance
		{
			get
			{
				return AudioReverbZone.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000250B File Offset: 0x0000070B
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000251D File Offset: 0x0000071D
		public float maxDistance
		{
			get
			{
				return AudioReverbZone.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005D74 File Offset: 0x00003F74
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002608 File Offset: 0x00000808
		public float roomRolloffFactor
		{
			get
			{
				Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
				return 10f;
			}
			set
			{
				Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
			}
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_set_reverbPreset_Public_set_Void_AudioReverbPreset_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_set_room_Public_set_Void_Int32_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_set_roomHF_Public_set_Void_Int32_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_set_roomLF_Public_set_Void_Int32_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_set_decayTime_Public_set_Void_Single_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_set_decayHFRatio_Public_set_Void_Single_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_set_reflections_Public_set_Void_Int32_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionsDelay_Public_set_Void_Single_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_set_reverb_Public_set_Void_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_reverbDelay_Public_set_Void_Single_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_set_HFReference_Public_set_Void_Single_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_set_LFReference_Public_set_Void_Single_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_set_diffusion_Public_set_Void_Single_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_set_density_Public_set_Void_Single_0;

		// Token: 0x040000C4 RID: 196
		private static readonly AudioReverbZone.get_minDistanceDelegate get_minDistanceDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly AudioReverbZone.set_minDistanceDelegate set_minDistanceDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly AudioReverbZone.get_maxDistanceDelegate get_maxDistanceDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly AudioReverbZone.set_maxDistanceDelegate set_maxDistanceDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly AudioReverbZone.get_reverbPresetDelegate get_reverbPresetDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly AudioReverbZone.get_roomDelegate get_roomDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly AudioReverbZone.get_roomHFDelegate get_roomHFDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly AudioReverbZone.get_roomLFDelegate get_roomLFDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly AudioReverbZone.get_decayTimeDelegate get_decayTimeDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly AudioReverbZone.get_decayHFRatioDelegate get_decayHFRatioDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly AudioReverbZone.get_reflectionsDelegate get_reflectionsDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly AudioReverbZone.get_reflectionsDelayDelegate get_reflectionsDelayDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly AudioReverbZone.get_reverbDelegate get_reverbDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly AudioReverbZone.get_reverbDelayDelegate get_reverbDelayDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly AudioReverbZone.get_HFReferenceDelegate get_HFReferenceDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly AudioReverbZone.get_LFReferenceDelegate get_LFReferenceDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly AudioReverbZone.get_diffusionDelegate get_diffusionDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly AudioReverbZone.get_densityDelegate get_densityDelegateField;

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000278 RID: 632
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600027A RID: 634
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600027C RID: 636
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600027E RID: 638
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000280 RID: 640
		private delegate AudioReverbPreset get_reverbPresetDelegate(IntPtr @this);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000282 RID: 642
		private delegate int get_roomDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000284 RID: 644
		private delegate int get_roomHFDelegate(IntPtr @this);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000286 RID: 646
		private delegate int get_roomLFDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000288 RID: 648
		private delegate float get_decayTimeDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600028A RID: 650
		private delegate float get_decayHFRatioDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600028C RID: 652
		private delegate int get_reflectionsDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x0600028E RID: 654
		private delegate float get_reflectionsDelayDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000290 RID: 656
		private delegate int get_reverbDelegate(IntPtr @this);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000292 RID: 658
		private delegate float get_reverbDelayDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000294 RID: 660
		private delegate float get_HFReferenceDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000296 RID: 662
		private delegate float get_LFReferenceDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000298 RID: 664
		private delegate float get_diffusionDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600029A RID: 666
		private delegate float get_densityDelegate(IntPtr @this);
	}
}
