using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000015 RID: 21
	public class ResonanceAudioListener : MonoBehaviour
	{
		// Token: 0x0600032F RID: 815 RVA: 0x0003CC30 File Offset: 0x0003AE30
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioListener()
		{
			Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr);
			ResonanceAudioListener.NativeFieldInfoPtr_globalGainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "globalGainDb");
			ResonanceAudioListener.NativeFieldInfoPtr_occlusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "occlusionMask");
			ResonanceAudioListener.NativeFieldInfoPtr_stereoSpeakerModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "stereoSpeakerModeEnabled");
			ResonanceAudioListener.NativeFieldInfoPtr_recorderSeamless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "recorderSeamless");
			ResonanceAudioListener.NativeFieldInfoPtr_recorderSourceTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "recorderSourceTag");
			ResonanceAudioListener.NativeFieldInfoPtr__IsRecording_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "<IsRecording>k__BackingField");
			ResonanceAudioListener.NativeFieldInfoPtr_recorderFoldout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "recorderFoldout");
			ResonanceAudioListener.NativeFieldInfoPtr_recorderTaggedSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "recorderTaggedSources");
			ResonanceAudioListener.NativeFieldInfoPtr_recorderStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, "recorderStartTime");
			ResonanceAudioListener.NativeMethodInfoPtr_get_IsRecording_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663488);
			ResonanceAudioListener.NativeMethodInfoPtr_set_IsRecording_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663489);
			ResonanceAudioListener.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663490);
			ResonanceAudioListener.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663491);
			ResonanceAudioListener.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663492);
			ResonanceAudioListener.NativeMethodInfoPtr_GetCurrentRecordDuration_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663493);
			ResonanceAudioListener.NativeMethodInfoPtr_StartSoundfieldRecorder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663494);
			ResonanceAudioListener.NativeMethodInfoPtr_StopSoundfieldRecorder_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663495);
			ResonanceAudioListener.NativeMethodInfoPtr_UpdateTaggedSources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663496);
			ResonanceAudioListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr, 100663497);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0003CDDC File Offset: 0x0003AFDC
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0003CE18 File Offset: 0x0003B018
		public unsafe bool IsRecording
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_get_IsRecording_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_set_IsRecording_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0003CE58 File Offset: 0x0003B058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33533, XrefRangeEnd = 33535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0003CE8C File Offset: 0x0003B08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33535, XrefRangeEnd = 33537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33537, XrefRangeEnd = 33551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0003CEF4 File Offset: 0x0003B0F4
		[CallerCount(0)]
		public unsafe double GetCurrentRecordDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_GetCurrentRecordDuration_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0003CF30 File Offset: 0x0003B130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33551, XrefRangeEnd = 33562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSoundfieldRecorder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_StartSoundfieldRecorder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0003CF64 File Offset: 0x0003B164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33562, XrefRangeEnd = 33573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSoundfieldRecorder(string filePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_StopSoundfieldRecorder_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33573, XrefRangeEnd = 33590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTaggedSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr_UpdateTaggedSources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0003CFDC File Offset: 0x0003B1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33590, XrefRangeEnd = 33595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00004363 File Offset: 0x00002563
		public ResonanceAudioListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0003D018 File Offset: 0x0003B218
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000436C File Offset: 0x0000256C
		public unsafe float globalGainDb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_globalGainDb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_globalGainDb)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0003D040 File Offset: 0x0003B240
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00004387 File Offset: 0x00002587
		public unsafe LayerMask occlusionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_occlusionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_occlusionMask)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0003D068 File Offset: 0x0003B268
		// (set) Token: 0x06000340 RID: 832 RVA: 0x000043A2 File Offset: 0x000025A2
		public unsafe bool stereoSpeakerModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_stereoSpeakerModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_stereoSpeakerModeEnabled)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0003D090 File Offset: 0x0003B290
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000043BD File Offset: 0x000025BD
		public unsafe bool recorderSeamless
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderSeamless);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderSeamless)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0003D0B8 File Offset: 0x0003B2B8
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000043D8 File Offset: 0x000025D8
		public unsafe string recorderSourceTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderSourceTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderSourceTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000043F7 File Offset: 0x000025F7
		public unsafe bool _IsRecording_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr__IsRecording_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr__IsRecording_k__BackingField)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0003D108 File Offset: 0x0003B308
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00004412 File Offset: 0x00002612
		public unsafe bool recorderFoldout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderFoldout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderFoldout)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0003D130 File Offset: 0x0003B330
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0000442D File Offset: 0x0000262D
		public unsafe List<AudioSource> recorderTaggedSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderTaggedSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderTaggedSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0003D160 File Offset: 0x0003B360
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0000444C File Offset: 0x0000264C
		public unsafe double recorderStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioListener.NativeFieldInfoPtr_recorderStartTime)) = value;
			}
		}

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_globalGainDb;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMask;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_stereoSpeakerModeEnabled;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_recorderSeamless;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_recorderSourceTag;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr__IsRecording_k__BackingField;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_recorderFoldout;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_recorderTaggedSources;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_recorderStartTime;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRecording_Public_get_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRecording_Private_set_Void_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentRecordDuration_Public_Double_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_StartSoundfieldRecorder_Public_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_StopSoundfieldRecorder_Public_Void_String_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTaggedSources_Private_Void_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
