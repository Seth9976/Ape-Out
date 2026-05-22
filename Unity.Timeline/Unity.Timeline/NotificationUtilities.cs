using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004C RID: 76
	public static class NotificationUtilities : Object
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x000182B8 File Offset: 0x000164B8
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationUtilities()
		{
			Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "NotificationUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr);
			NotificationUtilities.NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr, 100664118);
			NotificationUtilities.NativeMethodInfoPtr_TrackTypeSupportsNotifications_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr, 100664119);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00018310 File Offset: 0x00016510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479820, RefRangeEnd = 479821, XrefRangeStart = 479753, XrefRangeEnd = 479820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, GameObject go)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(markers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationUtilities.NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ScriptPlayable<TimeNotificationBehaviour>(intPtr);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001836C File Offset: 0x0001656C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479836, RefRangeEnd = 479837, XrefRangeStart = 479821, XrefRangeEnd = 479836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrackTypeSupportsNotifications(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationUtilities.NativeMethodInfoPtr_TrackTypeSupportsNotifications_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00003A9D File Offset: 0x00001C9D
		public NotificationUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_GameObject_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_TrackTypeSupportsNotifications_Public_Static_Boolean_Type_0;
	}
}
