using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000022 RID: 34
	public class ScheduleRuntimeClip : RuntimeClipBase
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00012450 File Offset: 0x00010650
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduleRuntimeClip()
		{
			Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ScheduleRuntimeClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr);
			ScheduleRuntimeClip.NativeFieldInfoPtr_m_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_Clip");
			ScheduleRuntimeClip.NativeFieldInfoPtr_m_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_Playable");
			ScheduleRuntimeClip.NativeFieldInfoPtr_m_ParentMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_ParentMixer");
			ScheduleRuntimeClip.NativeFieldInfoPtr_m_StartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_StartDelay");
			ScheduleRuntimeClip.NativeFieldInfoPtr_m_FinishTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_FinishTail");
			ScheduleRuntimeClip.NativeFieldInfoPtr_m_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, "m_Started");
			ScheduleRuntimeClip.NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663901);
			ScheduleRuntimeClip.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663902);
			ScheduleRuntimeClip.NativeMethodInfoPtr_SetTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663903);
			ScheduleRuntimeClip.NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663904);
			ScheduleRuntimeClip.NativeMethodInfoPtr_get_mixer_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663905);
			ScheduleRuntimeClip.NativeMethodInfoPtr_get_playable_Public_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663906);
			ScheduleRuntimeClip.NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663907);
			ScheduleRuntimeClip.NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663908);
			ScheduleRuntimeClip.NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663909);
			ScheduleRuntimeClip.NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr, 100663910);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000125C0 File Offset: 0x000107C0
		public unsafe override double start
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477799, XrefRangeEnd = 477804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleRuntimeClip.NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00012608 File Offset: 0x00010808
		public unsafe override double duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleRuntimeClip.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00012650 File Offset: 0x00010850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477804, XrefRangeEnd = 477810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleRuntimeClip.NativeMethodInfoPtr_SetTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00012690 File Offset: 0x00010890
		public unsafe TimelineClip clip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleRuntimeClip.NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr3) : null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000126D0 File Offset: 0x000108D0
		public unsafe Playable mixer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleRuntimeClip.NativeMethodInfoPtr_get_mixer_Public_get_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0001270C File Offset: 0x0001090C
		public unsafe Playable playable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleRuntimeClip.NativeMethodInfoPtr_get_playable_Public_get_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00012748 File Offset: 0x00010948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477816, RefRangeEnd = 477817, XrefRangeStart = 477810, XrefRangeEnd = 477816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduleRuntimeClip>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipPlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentMixer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDelay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishTail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleRuntimeClip.NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000127CC File Offset: 0x000109CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477816, RefRangeEnd = 477817, XrefRangeStart = 477816, XrefRangeEnd = 477817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipPlayable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentMixer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDelay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishTail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleRuntimeClip.NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000147 RID: 327
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00012848 File Offset: 0x00010A48
		public unsafe override bool enable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477817, XrefRangeEnd = 477828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleRuntimeClip.NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00012894 File Offset: 0x00010A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477828, XrefRangeEnd = 477852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleRuntimeClip.NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000315C File Offset: 0x0000135C
		public ScheduleRuntimeClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000128EC File Offset: 0x00010AEC
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003165 File Offset: 0x00001365
		public unsafe TimelineClip m_Clip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_Clip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimelineClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0001291C File Offset: 0x00010B1C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00003184 File Offset: 0x00001384
		public unsafe Playable m_Playable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_Playable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_Playable)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00012944 File Offset: 0x00010B44
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0000319F File Offset: 0x0000139F
		public unsafe Playable m_ParentMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_ParentMixer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_ParentMixer)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0001296C File Offset: 0x00010B6C
		// (set) Token: 0x06000390 RID: 912 RVA: 0x000031BA File Offset: 0x000013BA
		public unsafe double m_StartDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_StartDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_StartDelay)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00012994 File Offset: 0x00010B94
		// (set) Token: 0x06000392 RID: 914 RVA: 0x000031D5 File Offset: 0x000013D5
		public unsafe double m_FinishTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_FinishTail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_FinishTail)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000129BC File Offset: 0x00010BBC
		// (set) Token: 0x06000394 RID: 916 RVA: 0x000031F0 File Offset: 0x000013F0
		public unsafe bool m_Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_Started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleRuntimeClip.NativeFieldInfoPtr_m_Started)) = value;
			}
		}

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_m_Clip;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_m_Playable;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentMixer;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_m_StartDelay;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishTail;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_m_Started;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Virtual_get_Double_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Double_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_TimelineClip_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_mixer_Public_get_Playable_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_get_playable_Public_get_Playable_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimelineClip_Playable_Playable_Double_Double_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Void_TimelineClip_Playable_Playable_Double_Double_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAt_Public_Virtual_Void_Double_FrameData_0;
	}
}
