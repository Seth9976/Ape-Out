using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2CppAudioHelm
{
	// Token: 0x02000280 RID: 640
	public class HelmAudioInit : MonoBehaviour
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x0010B3E4 File Offset: 0x001095E4
		// Note: this type is marked as 'beforefieldinit'.
		static HelmAudioInit()
		{
			Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "HelmAudioInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr);
			HelmAudioInit.NativeFieldInfoPtr_warnedNoAudioGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, "warnedNoAudioGroup");
			HelmAudioInit.NativeFieldInfoPtr_synthesizerMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, "synthesizerMixerGroup");
			HelmAudioInit.NativeFieldInfoPtr_spatializerMixerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, "spatializerMixerGroup");
			HelmAudioInit.NativeFieldInfoPtr_sendAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, "sendAudioSource");
			HelmAudioInit.NativeFieldInfoPtr_wasSpatialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, "wasSpatialized");
			HelmAudioInit.NativeMethodInfoPtr_GetChannel_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, 100670655);
			HelmAudioInit.NativeMethodInfoPtr_SetupSpatialization_Private_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, 100670656);
			HelmAudioInit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, 100670657);
			HelmAudioInit.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, 100670658);
			HelmAudioInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr, 100670659);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0010B4DC File Offset: 0x001096DC
		[CallerCount(0)]
		public unsafe int GetChannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelmAudioInit.NativeMethodInfoPtr_GetChannel_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0010B518 File Offset: 0x00109718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116842, RefRangeEnd = 116843, XrefRangeStart = 116759, XrefRangeEnd = 116842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSpatialization(AudioSource audioComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelmAudioInit.NativeMethodInfoPtr_SetupSpatialization_Private_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0010B55C File Offset: 0x0010975C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116843, XrefRangeEnd = 116859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelmAudioInit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0010B590 File Offset: 0x00109790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116859, XrefRangeEnd = 116908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelmAudioInit.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0010B5C4 File Offset: 0x001097C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelmAudioInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelmAudioInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelmAudioInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x0002A229 File Offset: 0x00028429
		public HelmAudioInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x0010B600 File Offset: 0x00109800
		// (set) Token: 0x06004786 RID: 18310 RVA: 0x0002A232 File Offset: 0x00028432
		public unsafe bool warnedNoAudioGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_warnedNoAudioGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_warnedNoAudioGroup)) = value;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06004787 RID: 18311 RVA: 0x0010B628 File Offset: 0x00109828
		// (set) Token: 0x06004788 RID: 18312 RVA: 0x0002A24D File Offset: 0x0002844D
		public unsafe AudioMixerGroup synthesizerMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_synthesizerMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_synthesizerMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x0010B658 File Offset: 0x00109858
		// (set) Token: 0x0600478A RID: 18314 RVA: 0x0002A26C File Offset: 0x0002846C
		public unsafe AudioMixerGroup spatializerMixerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_spatializerMixerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_spatializerMixerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600478B RID: 18315 RVA: 0x0010B688 File Offset: 0x00109888
		// (set) Token: 0x0600478C RID: 18316 RVA: 0x0002A28B File Offset: 0x0002848B
		public unsafe AudioSource sendAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_sendAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_sendAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x0600478D RID: 18317 RVA: 0x0010B6B8 File Offset: 0x001098B8
		// (set) Token: 0x0600478E RID: 18318 RVA: 0x0002A2AA File Offset: 0x000284AA
		public unsafe bool wasSpatialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_wasSpatialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelmAudioInit.NativeFieldInfoPtr_wasSpatialized)) = value;
			}
		}

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeFieldInfoPtr_warnedNoAudioGroup;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeFieldInfoPtr_synthesizerMixerGroup;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeFieldInfoPtr_spatializerMixerGroup;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeFieldInfoPtr_sendAudioSource;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeFieldInfoPtr_wasSpatialized;

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeMethodInfoPtr_GetChannel_Private_Int32_0;

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeMethodInfoPtr_SetupSpatialization_Private_Void_AudioSource_0;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
