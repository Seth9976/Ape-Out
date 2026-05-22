using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000038 RID: 56
	public class TimeNotificationBehaviour : PlayableBehaviour
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00016000 File Offset: 0x00014200
		// Note: this type is marked as 'beforefieldinit'.
		static TimeNotificationBehaviour()
		{
			Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimeNotificationBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr);
			TimeNotificationBehaviour.NativeFieldInfoPtr_m_Notifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, "m_Notifications");
			TimeNotificationBehaviour.NativeFieldInfoPtr_m_PreviousTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, "m_PreviousTime");
			TimeNotificationBehaviour.NativeFieldInfoPtr_m_NeedSortNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, "m_NeedSortNotifications");
			TimeNotificationBehaviour.NativeFieldInfoPtr_m_TimeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, "m_TimeSource");
			TimeNotificationBehaviour.NativeMethodInfoPtr_set_timeSource_Public_set_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664041);
			TimeNotificationBehaviour.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_Double_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664042);
			TimeNotificationBehaviour.NativeMethodInfoPtr_AddNotification_Public_Void_Double_INotification_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664043);
			TimeNotificationBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664044);
			TimeNotificationBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664045);
			TimeNotificationBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664046);
			TimeNotificationBehaviour.NativeMethodInfoPtr_SortNotifications_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664047);
			TimeNotificationBehaviour.NativeMethodInfoPtr_CanRestoreNotification_Private_Static_Boolean_NotificationEntry_FrameData_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664048);
			TimeNotificationBehaviour.NativeMethodInfoPtr_TriggerNotificationsInRange_Private_Void_Double_Double_FrameData_Playable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664049);
			TimeNotificationBehaviour.NativeMethodInfoPtr_SyncDurationWithExternalSource_Private_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664050);
			TimeNotificationBehaviour.NativeMethodInfoPtr_Trigger_internal_Private_Static_Void_Playable_PlayableOutput_byref_NotificationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664051);
			TimeNotificationBehaviour.NativeMethodInfoPtr_Restore_internal_Private_Static_Void_byref_NotificationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664052);
			TimeNotificationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, 100664053);
		}

		// Token: 0x17000178 RID: 376
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00016184 File Offset: 0x00014384
		public unsafe Playable timeSource
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_set_timeSource_Public_set_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000161C4 File Offset: 0x000143C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479161, RefRangeEnd = 479162, XrefRangeStart = 479126, XrefRangeEnd = 479161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_Double_DirectorWrapMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<TimeNotificationBehaviour>(intPtr);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00016218 File Offset: 0x00014418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479164, RefRangeEnd = 479166, XrefRangeStart = 479162, XrefRangeEnd = 479164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payload);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_AddNotification_Public_Void_Double_INotification_NotificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00016278 File Offset: 0x00014478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479166, XrefRangeEnd = 479183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGraphStart(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeNotificationBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000162C4 File Offset: 0x000144C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479183, XrefRangeEnd = 479203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeNotificationBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001631C File Offset: 0x0001451C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479203, XrefRangeEnd = 479232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareFrame(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeNotificationBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00016374 File Offset: 0x00014574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 479247, RefRangeEnd = 479250, XrefRangeStart = 479232, XrefRangeEnd = 479247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_SortNotifications_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000163A8 File Offset: 0x000145A8
		[CallerCount(0)]
		public unsafe static bool CanRestoreNotification(TimeNotificationBehaviour.NotificationEntry e, FrameData info, double currentTime, double previousTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_CanRestoreNotification_Private_Static_Boolean_NotificationEntry_FrameData_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00016418 File Offset: 0x00014618
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 479270, RefRangeEnd = 479274, XrefRangeStart = 479250, XrefRangeEnd = 479270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_TriggerNotificationsInRange_Private_Void_Double_Double_FrameData_Playable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00016490 File Offset: 0x00014690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479300, RefRangeEnd = 479301, XrefRangeStart = 479274, XrefRangeEnd = 479300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDurationWithExternalSource(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_SyncDurationWithExternalSource_Private_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000164D0 File Offset: 0x000146D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479301, XrefRangeEnd = 479307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Trigger_internal(Playable playable, PlayableOutput output, ref TimeNotificationBehaviour.NotificationEntry e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref output;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_Trigger_internal_Private_Static_Void_Playable_PlayableOutput_byref_NotificationEntry_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00016528 File Offset: 0x00014728
		[CallerCount(0)]
		public unsafe static void Restore_internal(ref TimeNotificationBehaviour.NotificationEntry e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr_Restore_internal_Private_Static_Void_byref_NotificationEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00016564 File Offset: 0x00014764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479307, XrefRangeEnd = 479317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeNotificationBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00003656 File Offset: 0x00001856
		public TimeNotificationBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000165A0 File Offset: 0x000147A0
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0000365F File Offset: 0x0000185F
		public unsafe List<TimeNotificationBehaviour.NotificationEntry> m_Notifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_Notifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeNotificationBehaviour.NotificationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_Notifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000165D0 File Offset: 0x000147D0
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0000367E File Offset: 0x0000187E
		public unsafe double m_PreviousTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_PreviousTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_PreviousTime)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000165F8 File Offset: 0x000147F8
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003699 File Offset: 0x00001899
		public unsafe bool m_NeedSortNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_NeedSortNotifications);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_NeedSortNotifications)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00016620 File Offset: 0x00014820
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x000036B4 File Offset: 0x000018B4
		public unsafe Playable m_TimeSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_TimeSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NativeFieldInfoPtr_m_TimeSource)) = value;
			}
		}

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_m_Notifications;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousTime;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedSortNotifications;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeSource;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSource_Public_set_Void_Playable_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_Double_DirectorWrapMode_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_AddNotification_Public_Void_Double_INotification_NotificationFlags_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Virtual_Void_Playable_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_SortNotifications_Private_Void_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_CanRestoreNotification_Private_Static_Boolean_NotificationEntry_FrameData_Double_Double_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_TriggerNotificationsInRange_Private_Void_Double_Double_FrameData_Playable_Boolean_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_SyncDurationWithExternalSource_Private_Void_Playable_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_internal_Private_Static_Void_Playable_PlayableOutput_byref_NotificationEntry_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_Restore_internal_Private_Static_Void_byref_NotificationEntry_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000075 RID: 117
		public sealed class NotificationEntry : ValueType
		{
			// Token: 0x06000604 RID: 1540 RVA: 0x0001B838 File Offset: 0x00019A38
			// Note: this type is marked as 'beforefieldinit'.
			static NotificationEntry()
			{
				Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, "NotificationEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr);
				TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, "time");
				TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, "payload");
				TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_notificationFired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, "notificationFired");
				TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, "flags");
				TimeNotificationBehaviour.NotificationEntry.NativeMethodInfoPtr_get_triggerInEditor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, 100664054);
				TimeNotificationBehaviour.NotificationEntry.NativeMethodInfoPtr_get_prewarm_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, 100664055);
				TimeNotificationBehaviour.NotificationEntry.NativeMethodInfoPtr_get_triggerOnce_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr, 100664056);
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001B8F0 File Offset: 0x00019AF0
			public unsafe bool triggerInEditor
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NotificationEntry.NativeMethodInfoPtr_get_triggerInEditor_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001B934 File Offset: 0x00019B34
			public unsafe bool prewarm
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NotificationEntry.NativeMethodInfoPtr_get_prewarm_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001B978 File Offset: 0x00019B78
			public unsafe bool triggerOnce
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.NotificationEntry.NativeMethodInfoPtr_get_triggerOnce_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00004216 File Offset: 0x00002416
			public NotificationEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x0000421F File Offset: 0x0000241F
			public NotificationEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeNotificationBehaviour.NotificationEntry>.NativeClassPtr))
			{
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001B9BC File Offset: 0x00019BBC
			// (set) Token: 0x0600060B RID: 1547 RVA: 0x00004231 File Offset: 0x00002431
			public unsafe double time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001B9E4 File Offset: 0x00019BE4
			// (set) Token: 0x0600060D RID: 1549 RVA: 0x0000424C File Offset: 0x0000244C
			public unsafe INotification payload
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_payload);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<INotification>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_payload), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001BA14 File Offset: 0x00019C14
			// (set) Token: 0x0600060F RID: 1551 RVA: 0x0000426B File Offset: 0x0000246B
			public unsafe bool notificationFired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_notificationFired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_notificationFired)) = value;
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001BA3C File Offset: 0x00019C3C
			// (set) Token: 0x06000611 RID: 1553 RVA: 0x00004286 File Offset: 0x00002486
			public unsafe NotificationFlags flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_flags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeNotificationBehaviour.NotificationEntry.NativeFieldInfoPtr_flags)) = value;
				}
			}

			// Token: 0x040004AE RID: 1198
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x040004AF RID: 1199
			private static readonly IntPtr NativeFieldInfoPtr_payload;

			// Token: 0x040004B0 RID: 1200
			private static readonly IntPtr NativeFieldInfoPtr_notificationFired;

			// Token: 0x040004B1 RID: 1201
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeMethodInfoPtr_get_triggerInEditor_Public_get_Boolean_0;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeMethodInfoPtr_get_prewarm_Public_get_Boolean_0;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr_get_triggerOnce_Public_get_Boolean_0;
		}

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("UnityEngine.Timeline.TimeNotificationBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000612 RID: 1554 RVA: 0x0001BA64 File Offset: 0x00019C64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeNotificationBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr);
				TimeNotificationBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr, "<>9");
				TimeNotificationBehaviour.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr, "<>9__12_0");
				TimeNotificationBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr, 100664058);
				TimeNotificationBehaviour.__c.NativeMethodInfoPtr__SortNotifications_b__12_0_Internal_Int32_NotificationEntry_NotificationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr, 100664059);
			}

			// Token: 0x06000613 RID: 1555 RVA: 0x0001BAE0 File Offset: 0x00019CE0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeNotificationBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000614 RID: 1556 RVA: 0x0001BB1C File Offset: 0x00019D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479125, XrefRangeEnd = 479126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortNotifications_b__12_0(TimeNotificationBehaviour.NotificationEntry x, TimeNotificationBehaviour.NotificationEntry y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeNotificationBehaviour.__c.NativeMethodInfoPtr__SortNotifications_b__12_0_Internal_Int32_NotificationEntry_NotificationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x000042A1 File Offset: 0x000024A1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001BB88 File Offset: 0x00019D88
			// (set) Token: 0x06000617 RID: 1559 RVA: 0x000042AA File Offset: 0x000024AA
			public unsafe static TimeNotificationBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeNotificationBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeNotificationBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeNotificationBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001BBB0 File Offset: 0x00019DB0
			// (set) Token: 0x06000619 RID: 1561 RVA: 0x000042BC File Offset: 0x000024BC
			public unsafe static Comparison<TimeNotificationBehaviour.NotificationEntry> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeNotificationBehaviour.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimeNotificationBehaviour.NotificationEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeNotificationBehaviour.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004B5 RID: 1205
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004B6 RID: 1206
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040004B7 RID: 1207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004B8 RID: 1208
			private static readonly IntPtr NativeMethodInfoPtr__SortNotifications_b__12_0_Internal_Int32_NotificationEntry_NotificationEntry_0;
		}
	}
}
