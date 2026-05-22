using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001F RID: 31
	public class RuntimeClip : RuntimeClipBase
	{
		// Token: 0x06000356 RID: 854 RVA: 0x000119E0 File Offset: 0x0000FBE0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeClip()
		{
			Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "RuntimeClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr);
			RuntimeClip.NativeFieldInfoPtr_m_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, "m_Clip");
			RuntimeClip.NativeFieldInfoPtr_m_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, "m_Playable");
			RuntimeClip.NativeFieldInfoPtr_m_ParentMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, "m_ParentMixer");
			RuntimeClip.NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663876);
			RuntimeClip.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663877);
			RuntimeClip.NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663878);
			RuntimeClip.NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663879);
			RuntimeClip.NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663880);
			RuntimeClip.NativeMethodInfoPtr_get_mixer_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663881);
			RuntimeClip.NativeMethodInfoPtr_get_playable_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663882);
			RuntimeClip.NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663883);
			RuntimeClip.NativeMethodInfoPtr_SetTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663884);
			RuntimeClip.NativeMethodInfoPtr_SetDuration_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663885);
			RuntimeClip.NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663886);
			RuntimeClip.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr, 100663887);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00011B3C File Offset: 0x0000FD3C
		public unsafe override double start
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClip.NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00011B84 File Offset: 0x0000FD84
		public unsafe override double duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477699, XrefRangeEnd = 477701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClip.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00011BCC File Offset: 0x0000FDCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477707, RefRangeEnd = 477709, XrefRangeStart = 477701, XrefRangeEnd = 477707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeClip>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipPlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentMixer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00011C34 File Offset: 0x0000FE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477707, RefRangeEnd = 477709, XrefRangeStart = 477707, XrefRangeEnd = 477709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipPlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentMixer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00011C94 File Offset: 0x0000FE94
		public unsafe TimelineClip clip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00011CD4 File Offset: 0x0000FED4
		public unsafe Playable mixer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr_get_mixer_Public_get_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00011D10 File Offset: 0x0000FF10
		public unsafe Playable playable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr_get_playable_Public_get_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000132 RID: 306
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00011D4C File Offset: 0x0000FF4C
		public unsafe override bool enable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477709, XrefRangeEnd = 477731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClip.NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00011D98 File Offset: 0x0000FF98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 477737, RefRangeEnd = 477741, XrefRangeStart = 477731, XrefRangeEnd = 477737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr_SetTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477741, XrefRangeEnd = 477747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDuration(double duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeClip.NativeMethodInfoPtr_SetDuration_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00011E18 File Offset: 0x00010018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477747, XrefRangeEnd = 477779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAt(double localTime, FrameData frameData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClip.NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00011E70 File Offset: 0x00010070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477779, XrefRangeEnd = 477783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeClip.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000030D1 File Offset: 0x000012D1
		public RuntimeClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00011EAC File Offset: 0x000100AC
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000030DA File Offset: 0x000012DA
		public unsafe TimelineClip m_Clip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeClip.NativeFieldInfoPtr_m_Clip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeClip.NativeFieldInfoPtr_m_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00011EDC File Offset: 0x000100DC
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000030F9 File Offset: 0x000012F9
		public unsafe Playable m_Playable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeClip.NativeFieldInfoPtr_m_Playable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeClip.NativeFieldInfoPtr_m_Playable)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00011F04 File Offset: 0x00010104
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003114 File Offset: 0x00001314
		public unsafe Playable m_ParentMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeClip.NativeFieldInfoPtr_m_ParentMixer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeClip.NativeFieldInfoPtr_m_ParentMixer)) = value;
			}
		}

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_m_Clip;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_m_Playable;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentMixer;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_mixer_Public_get_Playable_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_playable_Public_get_Playable_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Double_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Public_Void_Double_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
