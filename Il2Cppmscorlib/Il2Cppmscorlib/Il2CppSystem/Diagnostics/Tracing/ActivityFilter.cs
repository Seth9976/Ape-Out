using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051E RID: 1310
	public sealed class ActivityFilter : Object
	{
		// Token: 0x06004D25 RID: 19749 RVA: 0x001633E4 File Offset: 0x001615E4
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityFilter()
		{
			Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ActivityFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr);
			ActivityFilter.NativeFieldInfoPtr_m_activeActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_activeActivities");
			ActivityFilter.NativeFieldInfoPtr_m_rootActiveActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_rootActiveActivities");
			ActivityFilter.NativeFieldInfoPtr_m_providerGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_providerGuid");
			ActivityFilter.NativeFieldInfoPtr_m_eventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_eventId");
			ActivityFilter.NativeFieldInfoPtr_m_samplingFreq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_samplingFreq");
			ActivityFilter.NativeFieldInfoPtr_m_curSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_curSampleCount");
			ActivityFilter.NativeFieldInfoPtr_m_perEventSourceSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_perEventSourceSessionId");
			ActivityFilter.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_next");
			ActivityFilter.NativeFieldInfoPtr_m_myActivityDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "m_myActivityDelegate");
			ActivityFilter.NativeMethodInfoPtr_DisableFilter_Public_Static_Void_byref_ActivityFilter_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674809);
			ActivityFilter.NativeMethodInfoPtr_UpdateFilter_Public_Static_Void_byref_ActivityFilter_EventSource_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674810);
			ActivityFilter.NativeMethodInfoPtr_PassesActivityFilter_Public_Static_Boolean_ActivityFilter_ptr_Guid_Boolean_EventSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674811);
			ActivityFilter.NativeMethodInfoPtr_FlowActivityIfNeeded_Public_Static_Void_ActivityFilter_ptr_Guid_ptr_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674812);
			ActivityFilter.NativeMethodInfoPtr_UpdateKwdTriggers_Public_Static_Void_ActivityFilter_Guid_EventSource_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674813);
			ActivityFilter.NativeMethodInfoPtr_GetFilterAsTuple_Public_IEnumerable_1_Tuple_2_Int32_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674814);
			ActivityFilter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674815);
			ActivityFilter.NativeMethodInfoPtr__ctor_Private_Void_EventSource_Int32_Int32_Int32_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674816);
			ActivityFilter.NativeMethodInfoPtr_EnsureActivityCleanupDelegate_Private_Static_Void_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674817);
			ActivityFilter.NativeMethodInfoPtr_GetActivityDyingDelegate_Private_Static_Action_1_Guid_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674818);
			ActivityFilter.NativeMethodInfoPtr_EnableFilter_Private_Static_Boolean_byref_ActivityFilter_EventSource_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674819);
			ActivityFilter.NativeMethodInfoPtr_TrimActiveActivityStore_Private_Static_Void_ConcurrentDictionary_2_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674820);
			ActivityFilter.NativeMethodInfoPtr_GetActiveActivities_Private_Static_ConcurrentDictionary_2_Guid_Int32_ActivityFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, 100674821);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x001635CC File Offset: 0x001617CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 241397, RefRangeEnd = 241401, XrefRangeStart = 241373, XrefRangeEnd = 241397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableFilter(ref ActivityFilter filterList, EventSource source)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_DisableFilter_Public_Static_Void_byref_ActivityFilter_EventSource_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			filterList = ((intPtr4 == 0) ? null : new ActivityFilter(intPtr4));
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x0016362C File Offset: 0x0016182C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241401, XrefRangeEnd = 241432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(startEvents);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_UpdateFilter_Public_Static_Void_byref_ActivityFilter_EventSource_Int32_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			filterList = ((intPtr4 == 0) ? null : new ActivityFilter(intPtr4));
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x001636AC File Offset: 0x001618AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241467, RefRangeEnd = 241469, XrefRangeStart = 241432, XrefRangeEnd = 241467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggeringEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_PassesActivityFilter_Public_Static_Boolean_ActivityFilter_ptr_Guid_Boolean_EventSource_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x00163728 File Offset: 0x00161928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241482, RefRangeEnd = 241483, XrefRangeStart = 241469, XrefRangeEnd = 241482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = currentActivityId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_FlowActivityIfNeeded_Public_Static_Void_ActivityFilter_ptr_Guid_ptr_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00163778 File Offset: 0x00161978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241487, RefRangeEnd = 241488, XrefRangeStart = 241483, XrefRangeEnd = 241487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activityFilter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceGuid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessKeywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_UpdateKwdTriggers_Public_Static_Void_ActivityFilter_Guid_EventSource_EventKeywords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x001637DC File Offset: 0x001619DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241493, RefRangeEnd = 241494, XrefRangeStart = 241488, XrefRangeEnd = 241493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_GetFilterAsTuple_Public_IEnumerable_1_Tuple_2_Int32_Int32_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Tuple<int, int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x00163828 File Offset: 0x00161A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241502, RefRangeEnd = 241504, XrefRangeStart = 241494, XrefRangeEnd = 241502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x0016385C File Offset: 0x00161A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241531, RefRangeEnd = 241532, XrefRangeStart = 241504, XrefRangeEnd = 241531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityFilter(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingFreq;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr__ctor_Private_Void_EventSource_Int32_Int32_Int32_ActivityFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x001638E4 File Offset: 0x00161AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241532, XrefRangeEnd = 241543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureActivityCleanupDelegate(ActivityFilter filterList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_EnsureActivityCleanupDelegate_Private_Static_Void_ActivityFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x0016391C File Offset: 0x00161B1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241552, RefRangeEnd = 241555, XrefRangeStart = 241543, XrefRangeEnd = 241552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_GetActivityDyingDelegate_Private_Static_Action_1_Guid_ActivityFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Guid>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x00163960 File Offset: 0x00161B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241559, RefRangeEnd = 241561, XrefRangeStart = 241555, XrefRangeEnd = 241559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplingFreq;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_EnableFilter_Private_Static_Boolean_byref_ActivityFilter_EventSource_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			filterList = ((intPtr4 == 0) ? null : new ActivityFilter(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x001639F4 File Offset: 0x00161BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241582, RefRangeEnd = 241583, XrefRangeStart = 241561, XrefRangeEnd = 241582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_TrimActiveActivityStore_Private_Static_Void_ConcurrentDictionary_2_Guid_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00163A2C File Offset: 0x00161C2C
		[CallerCount(0)]
		public unsafe static ConcurrentDictionary<Guid, int> GetActiveActivities(ActivityFilter filterList)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.NativeMethodInfoPtr_GetActiveActivities_Private_Static_ConcurrentDictionary_2_Guid_Int32_ActivityFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Guid, int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
		public ActivityFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x00163A70 File Offset: 0x00161C70
		// (set) Token: 0x06004D35 RID: 19765 RVA: 0x0001CBD1 File Offset: 0x0001ADD1
		public unsafe ConcurrentDictionary<Guid, int> m_activeActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_activeActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Guid, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_activeActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x00163AA0 File Offset: 0x00161CA0
		// (set) Token: 0x06004D37 RID: 19767 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		public unsafe ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_rootActiveActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Guid, Tuple<Guid, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_rootActiveActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x00163AD0 File Offset: 0x00161CD0
		// (set) Token: 0x06004D39 RID: 19769 RVA: 0x0001CC0F File Offset: 0x0001AE0F
		public unsafe Guid m_providerGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_providerGuid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_providerGuid)) = value;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x00163AF8 File Offset: 0x00161CF8
		// (set) Token: 0x06004D3B RID: 19771 RVA: 0x0001CC2A File Offset: 0x0001AE2A
		public unsafe int m_eventId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_eventId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_eventId)) = value;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x00163B20 File Offset: 0x00161D20
		// (set) Token: 0x06004D3D RID: 19773 RVA: 0x0001CC45 File Offset: 0x0001AE45
		public unsafe int m_samplingFreq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_samplingFreq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_samplingFreq)) = value;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06004D3E RID: 19774 RVA: 0x00163B48 File Offset: 0x00161D48
		// (set) Token: 0x06004D3F RID: 19775 RVA: 0x0001CC60 File Offset: 0x0001AE60
		public unsafe int m_curSampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_curSampleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_curSampleCount)) = value;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x00163B70 File Offset: 0x00161D70
		// (set) Token: 0x06004D41 RID: 19777 RVA: 0x0001CC7B File Offset: 0x0001AE7B
		public unsafe int m_perEventSourceSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_perEventSourceSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_perEventSourceSessionId)) = value;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004D42 RID: 19778 RVA: 0x00163B98 File Offset: 0x00161D98
		// (set) Token: 0x06004D43 RID: 19779 RVA: 0x0001CC96 File Offset: 0x0001AE96
		public unsafe ActivityFilter m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004D44 RID: 19780 RVA: 0x00163BC8 File Offset: 0x00161DC8
		// (set) Token: 0x06004D45 RID: 19781 RVA: 0x0001CCB5 File Offset: 0x0001AEB5
		public unsafe Action<Guid> m_myActivityDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_myActivityDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Guid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.NativeFieldInfoPtr_m_myActivityDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E47 RID: 15943
		private static readonly IntPtr NativeFieldInfoPtr_m_activeActivities;

		// Token: 0x04003E48 RID: 15944
		private static readonly IntPtr NativeFieldInfoPtr_m_rootActiveActivities;

		// Token: 0x04003E49 RID: 15945
		private static readonly IntPtr NativeFieldInfoPtr_m_providerGuid;

		// Token: 0x04003E4A RID: 15946
		private static readonly IntPtr NativeFieldInfoPtr_m_eventId;

		// Token: 0x04003E4B RID: 15947
		private static readonly IntPtr NativeFieldInfoPtr_m_samplingFreq;

		// Token: 0x04003E4C RID: 15948
		private static readonly IntPtr NativeFieldInfoPtr_m_curSampleCount;

		// Token: 0x04003E4D RID: 15949
		private static readonly IntPtr NativeFieldInfoPtr_m_perEventSourceSessionId;

		// Token: 0x04003E4E RID: 15950
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x04003E4F RID: 15951
		private static readonly IntPtr NativeFieldInfoPtr_m_myActivityDelegate;

		// Token: 0x04003E50 RID: 15952
		private static readonly IntPtr NativeMethodInfoPtr_DisableFilter_Public_Static_Void_byref_ActivityFilter_EventSource_0;

		// Token: 0x04003E51 RID: 15953
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFilter_Public_Static_Void_byref_ActivityFilter_EventSource_Int32_String_0;

		// Token: 0x04003E52 RID: 15954
		private static readonly IntPtr NativeMethodInfoPtr_PassesActivityFilter_Public_Static_Boolean_ActivityFilter_ptr_Guid_Boolean_EventSource_Int32_0;

		// Token: 0x04003E53 RID: 15955
		private static readonly IntPtr NativeMethodInfoPtr_FlowActivityIfNeeded_Public_Static_Void_ActivityFilter_ptr_Guid_ptr_Guid_0;

		// Token: 0x04003E54 RID: 15956
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKwdTriggers_Public_Static_Void_ActivityFilter_Guid_EventSource_EventKeywords_0;

		// Token: 0x04003E55 RID: 15957
		private static readonly IntPtr NativeMethodInfoPtr_GetFilterAsTuple_Public_IEnumerable_1_Tuple_2_Int32_Int32_Guid_0;

		// Token: 0x04003E56 RID: 15958
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003E57 RID: 15959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EventSource_Int32_Int32_Int32_ActivityFilter_0;

		// Token: 0x04003E58 RID: 15960
		private static readonly IntPtr NativeMethodInfoPtr_EnsureActivityCleanupDelegate_Private_Static_Void_ActivityFilter_0;

		// Token: 0x04003E59 RID: 15961
		private static readonly IntPtr NativeMethodInfoPtr_GetActivityDyingDelegate_Private_Static_Action_1_Guid_ActivityFilter_0;

		// Token: 0x04003E5A RID: 15962
		private static readonly IntPtr NativeMethodInfoPtr_EnableFilter_Private_Static_Boolean_byref_ActivityFilter_EventSource_Int32_Int32_Int32_0;

		// Token: 0x04003E5B RID: 15963
		private static readonly IntPtr NativeMethodInfoPtr_TrimActiveActivityStore_Private_Static_Void_ConcurrentDictionary_2_Guid_Int32_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActivities_Private_Static_ConcurrentDictionary_2_Guid_Int32_ActivityFilter_0;

		// Token: 0x02000688 RID: 1672
		[ObfuscatedName("System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__7")]
		public sealed class _GetFilterAsTuple_d__7 : Object
		{
			// Token: 0x060058FC RID: 22780 RVA: 0x0018B6A8 File Offset: 0x001898A8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFilterAsTuple_d__7()
			{
				Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "<GetFilterAsTuple>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr);
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>1__state");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>2__current");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>4__this");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr_sourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "sourceGuid");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___3__sourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<>3__sourceGuid");
				ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr__af_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, "<af>5__1");
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674822);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674823);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674824);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Tuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674825);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674826);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674827);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674828);
				ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr, 100674829);
			}

			// Token: 0x060058FD RID: 22781 RVA: 0x0018B800 File Offset: 0x00189A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFilterAsTuple_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter._GetFilterAsTuple_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058FE RID: 22782 RVA: 0x0018B848 File Offset: 0x00189A48
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058FF RID: 22783 RVA: 0x0018B87C File Offset: 0x00189A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241345, XrefRangeEnd = 241355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001711 RID: 5905
			// (get) Token: 0x06005900 RID: 22784 RVA: 0x0018B8B8 File Offset: 0x00189AB8
			public unsafe Tuple<int, int> prop_Tuple_2_Int32_Int32_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Tuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<int, int>>(intPtr3) : null;
				}
			}

			// Token: 0x06005901 RID: 22785 RVA: 0x0018B8F8 File Offset: 0x00189AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241355, XrefRangeEnd = 241360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001712 RID: 5906
			// (get) Token: 0x06005902 RID: 22786 RVA: 0x0018B92C File Offset: 0x00189B2C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005903 RID: 22787 RVA: 0x0018B96C File Offset: 0x00189B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241360, XrefRangeEnd = 241368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Tuple<int, int>> Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Tuple<int, int>>>(intPtr3) : null;
			}

			// Token: 0x06005904 RID: 22788 RVA: 0x0018B9AC File Offset: 0x00189BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter._GetFilterAsTuple_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005905 RID: 22789 RVA: 0x0002203F File Offset: 0x0002023F
			public _GetFilterAsTuple_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700170A RID: 5898
			// (get) Token: 0x06005906 RID: 22790 RVA: 0x0018B9EC File Offset: 0x00189BEC
			// (set) Token: 0x06005907 RID: 22791 RVA: 0x00022048 File Offset: 0x00020248
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700170B RID: 5899
			// (get) Token: 0x06005908 RID: 22792 RVA: 0x0018BA14 File Offset: 0x00189C14
			// (set) Token: 0x06005909 RID: 22793 RVA: 0x00022063 File Offset: 0x00020263
			public unsafe Tuple<int, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700170C RID: 5900
			// (get) Token: 0x0600590A RID: 22794 RVA: 0x0018BA44 File Offset: 0x00189C44
			// (set) Token: 0x0600590B RID: 22795 RVA: 0x00022082 File Offset: 0x00020282
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700170D RID: 5901
			// (get) Token: 0x0600590C RID: 22796 RVA: 0x0018BA6C File Offset: 0x00189C6C
			// (set) Token: 0x0600590D RID: 22797 RVA: 0x0002209D File Offset: 0x0002029D
			public unsafe ActivityFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700170E RID: 5902
			// (get) Token: 0x0600590E RID: 22798 RVA: 0x0018BA9C File Offset: 0x00189C9C
			// (set) Token: 0x0600590F RID: 22799 RVA: 0x000220BC File Offset: 0x000202BC
			public unsafe Guid sourceGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr_sourceGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr_sourceGuid)) = value;
				}
			}

			// Token: 0x1700170F RID: 5903
			// (get) Token: 0x06005910 RID: 22800 RVA: 0x0018BAC4 File Offset: 0x00189CC4
			// (set) Token: 0x06005911 RID: 22801 RVA: 0x000220D7 File Offset: 0x000202D7
			public unsafe Guid __3__sourceGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___3__sourceGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr___3__sourceGuid)) = value;
				}
			}

			// Token: 0x17001710 RID: 5904
			// (get) Token: 0x06005912 RID: 22802 RVA: 0x0018BAEC File Offset: 0x00189CEC
			// (set) Token: 0x06005913 RID: 22803 RVA: 0x000220F2 File Offset: 0x000202F2
			public unsafe ActivityFilter _af_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr__af_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter._GetFilterAsTuple_d__7.NativeFieldInfoPtr__af_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400474B RID: 18251
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400474C RID: 18252
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400474D RID: 18253
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400474E RID: 18254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400474F RID: 18255
			private static readonly IntPtr NativeFieldInfoPtr_sourceGuid;

			// Token: 0x04004750 RID: 18256
			private static readonly IntPtr NativeFieldInfoPtr___3__sourceGuid;

			// Token: 0x04004751 RID: 18257
			private static readonly IntPtr NativeFieldInfoPtr__af_5__1;

			// Token: 0x04004752 RID: 18258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004753 RID: 18259
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004754 RID: 18260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004755 RID: 18261
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Tuple_2_Int32_Int32_0;

			// Token: 0x04004756 RID: 18262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004757 RID: 18263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004758 RID: 18264
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Tuple_2_Int32_Int32_0;

			// Token: 0x04004759 RID: 18265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000689 RID: 1673
		[ObfuscatedName("System.Diagnostics.Tracing.ActivityFilter+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06005914 RID: 22804 RVA: 0x0018BB1C File Offset: 0x00189D1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr);
				ActivityFilter.__c__DisplayClass11_0.NativeFieldInfoPtr_filterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr, "filterList");
				ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr, 100674830);
				ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__GetActivityDyingDelegate_b__0_Internal_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr, 100674831);
			}

			// Token: 0x06005915 RID: 22805 RVA: 0x0018BB84 File Offset: 0x00189D84
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005916 RID: 22806 RVA: 0x0018BBC0 File Offset: 0x00189DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241368, XrefRangeEnd = 241372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetActivityDyingDelegate_b__0(Guid oldActivity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref oldActivity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass11_0.NativeMethodInfoPtr__GetActivityDyingDelegate_b__0_Internal_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005917 RID: 22807 RVA: 0x00022111 File Offset: 0x00020311
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001713 RID: 5907
			// (get) Token: 0x06005918 RID: 22808 RVA: 0x0018BC00 File Offset: 0x00189E00
			// (set) Token: 0x06005919 RID: 22809 RVA: 0x0002211A File Offset: 0x0002031A
			public unsafe ActivityFilter filterList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass11_0.NativeFieldInfoPtr_filterList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass11_0.NativeFieldInfoPtr_filterList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400475A RID: 18266
			private static readonly IntPtr NativeFieldInfoPtr_filterList;

			// Token: 0x0400475B RID: 18267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400475C RID: 18268
			private static readonly IntPtr NativeMethodInfoPtr__GetActivityDyingDelegate_b__0_Internal_Void_Guid_0;
		}

		// Token: 0x0200068A RID: 1674
		[ObfuscatedName("System.Diagnostics.Tracing.ActivityFilter+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600591A RID: 22810 RVA: 0x0018BC30 File Offset: 0x00189E30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityFilter>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr);
				ActivityFilter.__c__DisplayClass13_0.NativeFieldInfoPtr_tickNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr, "tickNow");
				ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr, 100674832);
				ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__TrimActiveActivityStore_b__0_Internal_Int32_KeyValuePair_2_Guid_Int32_KeyValuePair_2_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr, 100674833);
			}

			// Token: 0x0600591B RID: 22811 RVA: 0x0018BC98 File Offset: 0x00189E98
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityFilter.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600591C RID: 22812 RVA: 0x0018BCD4 File Offset: 0x00189ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241372, XrefRangeEnd = 241373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TrimActiveActivityStore_b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityFilter.__c__DisplayClass13_0.NativeMethodInfoPtr__TrimActiveActivityStore_b__0_Internal_Int32_KeyValuePair_2_Guid_Int32_KeyValuePair_2_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600591D RID: 22813 RVA: 0x00022139 File Offset: 0x00020339
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001714 RID: 5908
			// (get) Token: 0x0600591E RID: 22814 RVA: 0x0018BD40 File Offset: 0x00189F40
			// (set) Token: 0x0600591F RID: 22815 RVA: 0x00022142 File Offset: 0x00020342
			public unsafe int tickNow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass13_0.NativeFieldInfoPtr_tickNow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityFilter.__c__DisplayClass13_0.NativeFieldInfoPtr_tickNow)) = value;
				}
			}

			// Token: 0x0400475D RID: 18269
			private static readonly IntPtr NativeFieldInfoPtr_tickNow;

			// Token: 0x0400475E RID: 18270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400475F RID: 18271
			private static readonly IntPtr NativeMethodInfoPtr__TrimActiveActivityStore_b__0_Internal_Int32_KeyValuePair_2_Guid_Int32_KeyValuePair_2_Guid_Int32_0;
		}
	}
}
