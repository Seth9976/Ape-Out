using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001C RID: 28
	public class ResonanceAudioSource : MonoBehaviour
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0003E968 File Offset: 0x0003CB68
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioSource()
		{
			Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr);
			ResonanceAudioSource.NativeFieldInfoPtr_bypassRoomEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "bypassRoomEffects");
			ResonanceAudioSource.NativeFieldInfoPtr_directivityAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "directivityAlpha");
			ResonanceAudioSource.NativeFieldInfoPtr_directivitySharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "directivitySharpness");
			ResonanceAudioSource.NativeFieldInfoPtr_listenerDirectivityAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "listenerDirectivityAlpha");
			ResonanceAudioSource.NativeFieldInfoPtr_listenerDirectivitySharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "listenerDirectivitySharpness");
			ResonanceAudioSource.NativeFieldInfoPtr_gainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "gainDb");
			ResonanceAudioSource.NativeFieldInfoPtr_nearFieldEffectEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "nearFieldEffectEnabled");
			ResonanceAudioSource.NativeFieldInfoPtr_nearFieldEffectGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "nearFieldEffectGain");
			ResonanceAudioSource.NativeFieldInfoPtr_occlusionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "occlusionEnabled");
			ResonanceAudioSource.NativeFieldInfoPtr_occlusionIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "occlusionIntensity");
			ResonanceAudioSource.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "quality");
			ResonanceAudioSource.NativeFieldInfoPtr__audioSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "<audioSource>k__BackingField");
			ResonanceAudioSource.NativeFieldInfoPtr_currentOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "currentOcclusion");
			ResonanceAudioSource.NativeFieldInfoPtr_nextOcclusionUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, "nextOcclusionUpdate");
			ResonanceAudioSource.NativeMethodInfoPtr_get_Directivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663551);
			ResonanceAudioSource.NativeMethodInfoPtr_set_Directivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663552);
			ResonanceAudioSource.NativeMethodInfoPtr_get_audioSource_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663553);
			ResonanceAudioSource.NativeMethodInfoPtr_set_audioSource_Private_set_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663554);
			ResonanceAudioSource.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663555);
			ResonanceAudioSource.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663556);
			ResonanceAudioSource.NativeMethodInfoPtr_CalculateOcclusion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663557);
			ResonanceAudioSource.NativeMethodInfoPtr_UpdateSource_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663558);
			ResonanceAudioSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr, 100663559);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0003EB64 File Offset: 0x0003CD64
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0003EBA0 File Offset: 0x0003CDA0
		public unsafe float Directivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_get_Directivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_set_Directivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0003EBE0 File Offset: 0x0003CDE0
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0003EC20 File Offset: 0x0003CE20
		public unsafe AudioSource audioSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_get_audioSource_Public_get_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_set_audioSource_Private_set_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0003EC64 File Offset: 0x0003CE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34299, XrefRangeEnd = 34302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0003EC98 File Offset: 0x0003CE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34302, XrefRangeEnd = 34309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0003ECCC File Offset: 0x0003CECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34319, RefRangeEnd = 34321, XrefRangeStart = 34309, XrefRangeEnd = 34319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateOcclusion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_CalculateOcclusion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0003ED00 File Offset: 0x0003CF00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34353, RefRangeEnd = 34355, XrefRangeStart = 34321, XrefRangeEnd = 34353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr_UpdateSource_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0003ED34 File Offset: 0x0003CF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34355, XrefRangeEnd = 34358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000048A6 File Offset: 0x00002AA6
		public ResonanceAudioSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0003ED70 File Offset: 0x0003CF70
		// (set) Token: 0x060003DC RID: 988 RVA: 0x000048AF File Offset: 0x00002AAF
		public unsafe bool bypassRoomEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_bypassRoomEffects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_bypassRoomEffects)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0003ED98 File Offset: 0x0003CF98
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000048CA File Offset: 0x00002ACA
		public unsafe float directivityAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_directivityAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_directivityAlpha)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000048E5 File Offset: 0x00002AE5
		public unsafe float directivitySharpness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_directivitySharpness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_directivitySharpness)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0003EDE8 File Offset: 0x0003CFE8
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00004900 File Offset: 0x00002B00
		public unsafe float listenerDirectivityAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_listenerDirectivityAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_listenerDirectivityAlpha)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0003EE10 File Offset: 0x0003D010
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0000491B File Offset: 0x00002B1B
		public unsafe float listenerDirectivitySharpness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_listenerDirectivitySharpness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_listenerDirectivitySharpness)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0003EE38 File Offset: 0x0003D038
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00004936 File Offset: 0x00002B36
		public unsafe float gainDb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_gainDb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_gainDb)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0003EE60 File Offset: 0x0003D060
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00004951 File Offset: 0x00002B51
		public unsafe bool nearFieldEffectEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_nearFieldEffectEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_nearFieldEffectEnabled)) = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0003EE88 File Offset: 0x0003D088
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0000496C File Offset: 0x00002B6C
		public unsafe float nearFieldEffectGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_nearFieldEffectGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_nearFieldEffectGain)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00004987 File Offset: 0x00002B87
		public unsafe bool occlusionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_occlusionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_occlusionEnabled)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0003EED8 File Offset: 0x0003D0D8
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x000049A2 File Offset: 0x00002BA2
		public unsafe float occlusionIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_occlusionIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_occlusionIntensity)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0003EF00 File Offset: 0x0003D100
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000049BD File Offset: 0x00002BBD
		public unsafe ResonanceAudioSource.Quality quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_quality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_quality)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0003EF28 File Offset: 0x0003D128
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000049D8 File Offset: 0x00002BD8
		public unsafe AudioSource _audioSource_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr__audioSource_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr__audioSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0003EF58 File Offset: 0x0003D158
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000049F7 File Offset: 0x00002BF7
		public unsafe float currentOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_currentOcclusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_currentOcclusion)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0003EF80 File Offset: 0x0003D180
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00004A12 File Offset: 0x00002C12
		public unsafe float nextOcclusionUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_nextOcclusionUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioSource.NativeFieldInfoPtr_nextOcclusionUpdate)) = value;
			}
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_bypassRoomEffects;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_directivityAlpha;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_directivitySharpness;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_listenerDirectivityAlpha;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_listenerDirectivitySharpness;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_gainDb;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_nearFieldEffectEnabled;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_nearFieldEffectGain;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_occlusionEnabled;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_occlusionIntensity;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_quality;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr__audioSource_k__BackingField;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_currentOcclusion;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_nextOcclusionUpdate;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_get_Directivity_Public_get_Single_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_set_Directivity_Public_set_Void_Single_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_audioSource_Public_get_AudioSource_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_set_audioSource_Private_set_Void_AudioSource_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOcclusion_Public_Void_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSource_Private_Void_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002A4 RID: 676
		[OriginalName("Assembly-CSharp.dll", "", "Quality")]
		public enum Quality
		{
			// Token: 0x04003095 RID: 12437
			Stereo,
			// Token: 0x04003096 RID: 12438
			Low,
			// Token: 0x04003097 RID: 12439
			High
		}

		// Token: 0x020002A5 RID: 677
		[OriginalName("Assembly-CSharp.dll", "", "EffectData")]
		public enum EffectData
		{
			// Token: 0x04003099 RID: 12441
			Id,
			// Token: 0x0400309A RID: 12442
			DistanceAttenuation,
			// Token: 0x0400309B RID: 12443
			RoomEffectsGain,
			// Token: 0x0400309C RID: 12444
			Gain,
			// Token: 0x0400309D RID: 12445
			DirectivityAlpha,
			// Token: 0x0400309E RID: 12446
			DirectivitySharpness,
			// Token: 0x0400309F RID: 12447
			ListenerDirectivityAlpha,
			// Token: 0x040030A0 RID: 12448
			ListenerDirectivitySharpness,
			// Token: 0x040030A1 RID: 12449
			Occlusion,
			// Token: 0x040030A2 RID: 12450
			Quality,
			// Token: 0x040030A3 RID: 12451
			NearFieldEffectGain,
			// Token: 0x040030A4 RID: 12452
			Volume
		}
	}
}
