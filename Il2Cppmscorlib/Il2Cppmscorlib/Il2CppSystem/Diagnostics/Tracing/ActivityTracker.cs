using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050F RID: 1295
	public class ActivityTracker : Object
	{
		// Token: 0x06004C37 RID: 19511 RVA: 0x0015FF9C File Offset: 0x0015E19C
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityTracker()
		{
			Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ActivityTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr);
			ActivityTracker.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "m_current");
			ActivityTracker.NativeFieldInfoPtr_m_checkedForEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "m_checkedForEnable");
			ActivityTracker.NativeFieldInfoPtr_s_activityTrackerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "s_activityTrackerInstance");
			ActivityTracker.NativeFieldInfoPtr_m_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "m_nextId");
			ActivityTracker.NativeMethodInfoPtr_OnStart_Public_Void_String_String_Int32_byref_Guid_byref_Guid_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674694);
			ActivityTracker.NativeMethodInfoPtr_OnStop_Public_Void_String_String_Int32_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674695);
			ActivityTracker.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674696);
			ActivityTracker.NativeMethodInfoPtr_get_Instance_Public_Static_get_ActivityTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674697);
			ActivityTracker.NativeMethodInfoPtr_FindActiveActivity_Private_ActivityInfo_String_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674698);
			ActivityTracker.NativeMethodInfoPtr_NormalizeActivityName_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674699);
			ActivityTracker.NativeMethodInfoPtr_ActivityChanging_Private_Void_AsyncLocalValueChangedArgs_1_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674700);
			ActivityTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, 100674701);
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x001600BC File Offset: 0x0015E2BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240613, RefRangeEnd = 240615, XrefRangeStart = 240572, XrefRangeEnd = 240613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &activityId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &relatedActivityId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_OnStart_Public_Void_String_String_Int32_byref_Guid_byref_Guid_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x0016014C File Offset: 0x0015E34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240652, RefRangeEnd = 240655, XrefRangeStart = 240615, XrefRangeEnd = 240652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStop(string providerName, string activityName, int task, ref Guid activityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &activityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_OnStop_Public_Void_String_String_Int32_byref_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x001601C0 File Offset: 0x0015E3C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240665, RefRangeEnd = 240666, XrefRangeStart = 240655, XrefRangeEnd = 240665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x001601F4 File Offset: 0x0015E3F4
		public unsafe static ActivityTracker Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240666, XrefRangeEnd = 240670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_get_Instance_Public_Static_get_ActivityTracker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTracker>(intPtr3) : null;
			}
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00160228 File Offset: 0x0015E428
		[CallerCount(0)]
		public unsafe ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_FindActiveActivity_Private_ActivityInfo_String_ActivityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTracker.ActivityInfo>(intPtr3) : null;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x0016028C File Offset: 0x0015E48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240688, RefRangeEnd = 240690, XrefRangeStart = 240670, XrefRangeEnd = 240688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NormalizeActivityName(string providerName, string activityName, int task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref task;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_NormalizeActivityName_Private_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x001602F4 File Offset: 0x0015E4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240690, XrefRangeEnd = 240702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr_ActivityChanging_Private_Void_AsyncLocalValueChangedArgs_1_ActivityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x0016033C File Offset: 0x0015E53C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTracker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x0001C4F7 File Offset: 0x0001A6F7
		public ActivityTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x00160378 File Offset: 0x0015E578
		// (set) Token: 0x06004C42 RID: 19522 RVA: 0x0001C500 File Offset: 0x0001A700
		public unsafe AsyncLocal<ActivityTracker.ActivityInfo> m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<ActivityTracker.ActivityInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06004C43 RID: 19523 RVA: 0x001603A8 File Offset: 0x0015E5A8
		// (set) Token: 0x06004C44 RID: 19524 RVA: 0x0001C51F File Offset: 0x0001A71F
		public unsafe bool m_checkedForEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_checkedForEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.NativeFieldInfoPtr_m_checkedForEnable)) = value;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06004C45 RID: 19525 RVA: 0x001603D0 File Offset: 0x0015E5D0
		// (set) Token: 0x06004C46 RID: 19526 RVA: 0x0001C53A File Offset: 0x0001A73A
		public unsafe static ActivityTracker s_activityTrackerInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActivityTracker.NativeFieldInfoPtr_s_activityTrackerInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTracker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivityTracker.NativeFieldInfoPtr_s_activityTrackerInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x001603F8 File Offset: 0x0015E5F8
		// (set) Token: 0x06004C48 RID: 19528 RVA: 0x0001C54C File Offset: 0x0001A74C
		public unsafe static long m_nextId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ActivityTracker.NativeFieldInfoPtr_m_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivityTracker.NativeFieldInfoPtr_m_nextId, (void*)(&value));
			}
		}

		// Token: 0x04003D87 RID: 15751
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x04003D88 RID: 15752
		private static readonly IntPtr NativeFieldInfoPtr_m_checkedForEnable;

		// Token: 0x04003D89 RID: 15753
		private static readonly IntPtr NativeFieldInfoPtr_s_activityTrackerInstance;

		// Token: 0x04003D8A RID: 15754
		private static readonly IntPtr NativeFieldInfoPtr_m_nextId;

		// Token: 0x04003D8B RID: 15755
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Void_String_String_Int32_byref_Guid_byref_Guid_EventActivityOptions_0;

		// Token: 0x04003D8C RID: 15756
		private static readonly IntPtr NativeMethodInfoPtr_OnStop_Public_Void_String_String_Int32_byref_Guid_0;

		// Token: 0x04003D8D RID: 15757
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04003D8E RID: 15758
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ActivityTracker_0;

		// Token: 0x04003D8F RID: 15759
		private static readonly IntPtr NativeMethodInfoPtr_FindActiveActivity_Private_ActivityInfo_String_ActivityInfo_0;

		// Token: 0x04003D90 RID: 15760
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeActivityName_Private_String_String_String_Int32_0;

		// Token: 0x04003D91 RID: 15761
		private static readonly IntPtr NativeMethodInfoPtr_ActivityChanging_Private_Void_AsyncLocalValueChangedArgs_1_ActivityInfo_0;

		// Token: 0x04003D92 RID: 15762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000681 RID: 1665
		public class ActivityInfo : Object
		{
			// Token: 0x060058CA RID: 22730 RVA: 0x0018ADA4 File Offset: 0x00188FA4
			// Note: this type is marked as 'beforefieldinit'.
			static ActivityInfo()
			{
				Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityTracker>.NativeClassPtr, "ActivityInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr);
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_name");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_uniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_uniqueId");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_guid");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityPathGuidOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_activityPathGuidOffset");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_level");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_eventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_eventOptions");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_lastChildID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_lastChildID");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_stopped");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_creator");
				ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityIdToRestore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, "m_activityIdToRestore");
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_ActivityInfo_Guid_EventActivityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674703);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_get_ActivityId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674704);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_Path_Public_Static_String_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674705);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674706);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_LiveActivities_Public_Static_String_ActivityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674707);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CanBeOrphan_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674708);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateActivityPathGuid_Private_Void_byref_Guid_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674709);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateOverflowGuid_Private_Void_ptr_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674710);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_AddIdToGuid_Private_Static_Int32_ptr_Guid_Int32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674711);
				ActivityTracker.ActivityInfo.NativeMethodInfoPtr_WriteNibble_Private_Static_Void_byref_ptr_Byte_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr, 100674712);
			}

			// Token: 0x060058CB RID: 22731 RVA: 0x0018AF60 File Offset: 0x00189160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240487, XrefRangeEnd = 240494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActivityInfo(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityTracker.ActivityInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(creator);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIDToRestore;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_ActivityInfo_Guid_EventActivityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001707 RID: 5895
			// (get) Token: 0x060058CC RID: 22732 RVA: 0x0018AFE8 File Offset: 0x001891E8
			public unsafe Guid ActivityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_get_ActivityId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060058CD RID: 22733 RVA: 0x0018B024 File Offset: 0x00189224
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240505, RefRangeEnd = 240507, XrefRangeStart = 240494, XrefRangeEnd = 240505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Path(ActivityTracker.ActivityInfo activityInfo)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(activityInfo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_Path_Public_Static_String_ActivityInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060058CE RID: 22734 RVA: 0x0018B060 File Offset: 0x00189260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240507, XrefRangeEnd = 240543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivityTracker.ActivityInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060058CF RID: 22735 RVA: 0x0018B0A4 File Offset: 0x001892A4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 240549, RefRangeEnd = 240552, XrefRangeStart = 240543, XrefRangeEnd = 240549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string LiveActivities(ActivityTracker.ActivityInfo list)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_LiveActivities_Public_Static_String_ActivityInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060058D0 RID: 22736 RVA: 0x0018B0E0 File Offset: 0x001892E0
			[CallerCount(0)]
			public unsafe bool CanBeOrphan()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CanBeOrphan_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058D1 RID: 22737 RVA: 0x0018B11C File Offset: 0x0018931C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240552, XrefRangeEnd = 240558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &idRet;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &activityPathGuidOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateActivityPathGuid_Private_Void_byref_Guid_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058D2 RID: 22738 RVA: 0x0018B168 File Offset: 0x00189368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240558, XrefRangeEnd = 240559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateOverflowGuid(Guid* outPtr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = outPtr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_CreateOverflowGuid_Private_Void_ptr_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058D3 RID: 22739 RVA: 0x0018B1A8 File Offset: 0x001893A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 240565, RefRangeEnd = 240572, XrefRangeStart = 240559, XrefRangeEnd = 240565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = false)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = outPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref whereToAddId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overflow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_AddIdToGuid_Private_Static_Int32_ptr_Guid_Int32_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058D4 RID: 22740 RVA: 0x0018B210 File Offset: 0x00189410
			[CallerCount(0)]
			public unsafe static void WriteNibble(ref byte* ptr, byte* endPtr, uint value)
			{
				IntPtr* ptr2;
				IntPtr intPtr;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr3 = ref *ptr2;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(ptr);
					ptr3 = &intPtr;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = endPtr;
				ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityTracker.ActivityInfo.NativeMethodInfoPtr_WriteNibble_Private_Static_Void_byref_ptr_Byte_ptr_Byte_UInt32_0, 0, (void**)ptr2, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				ptr = ((intPtr4 == 0) ? null : new byte*(intPtr4));
			}

			// Token: 0x060058D5 RID: 22741 RVA: 0x00021E4C File Offset: 0x0002004C
			public ActivityInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016FD RID: 5885
			// (get) Token: 0x060058D6 RID: 22742 RVA: 0x0018B278 File Offset: 0x00189478
			// (set) Token: 0x060058D7 RID: 22743 RVA: 0x00021E55 File Offset: 0x00020055
			public unsafe string m_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170016FE RID: 5886
			// (get) Token: 0x060058D8 RID: 22744 RVA: 0x0018B2A0 File Offset: 0x001894A0
			// (set) Token: 0x060058D9 RID: 22745 RVA: 0x00021E74 File Offset: 0x00020074
			public unsafe long m_uniqueId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_uniqueId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_uniqueId)) = value;
				}
			}

			// Token: 0x170016FF RID: 5887
			// (get) Token: 0x060058DA RID: 22746 RVA: 0x0018B2C8 File Offset: 0x001894C8
			// (set) Token: 0x060058DB RID: 22747 RVA: 0x00021E8F File Offset: 0x0002008F
			public unsafe Guid m_guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_guid)) = value;
				}
			}

			// Token: 0x17001700 RID: 5888
			// (get) Token: 0x060058DC RID: 22748 RVA: 0x0018B2F0 File Offset: 0x001894F0
			// (set) Token: 0x060058DD RID: 22749 RVA: 0x00021EAA File Offset: 0x000200AA
			public unsafe int m_activityPathGuidOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityPathGuidOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityPathGuidOffset)) = value;
				}
			}

			// Token: 0x17001701 RID: 5889
			// (get) Token: 0x060058DE RID: 22750 RVA: 0x0018B318 File Offset: 0x00189518
			// (set) Token: 0x060058DF RID: 22751 RVA: 0x00021EC5 File Offset: 0x000200C5
			public unsafe int m_level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_level)) = value;
				}
			}

			// Token: 0x17001702 RID: 5890
			// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0018B340 File Offset: 0x00189540
			// (set) Token: 0x060058E1 RID: 22753 RVA: 0x00021EE0 File Offset: 0x000200E0
			public unsafe EventActivityOptions m_eventOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_eventOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_eventOptions)) = value;
				}
			}

			// Token: 0x17001703 RID: 5891
			// (get) Token: 0x060058E2 RID: 22754 RVA: 0x0018B368 File Offset: 0x00189568
			// (set) Token: 0x060058E3 RID: 22755 RVA: 0x00021EFB File Offset: 0x000200FB
			public unsafe long m_lastChildID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_lastChildID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_lastChildID)) = value;
				}
			}

			// Token: 0x17001704 RID: 5892
			// (get) Token: 0x060058E4 RID: 22756 RVA: 0x0018B390 File Offset: 0x00189590
			// (set) Token: 0x060058E5 RID: 22757 RVA: 0x00021F16 File Offset: 0x00020116
			public unsafe int m_stopped
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_stopped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_stopped)) = value;
				}
			}

			// Token: 0x17001705 RID: 5893
			// (get) Token: 0x060058E6 RID: 22758 RVA: 0x0018B3B8 File Offset: 0x001895B8
			// (set) Token: 0x060058E7 RID: 22759 RVA: 0x00021F31 File Offset: 0x00020131
			public unsafe ActivityTracker.ActivityInfo m_creator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_creator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTracker.ActivityInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_creator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001706 RID: 5894
			// (get) Token: 0x060058E8 RID: 22760 RVA: 0x0018B3E8 File Offset: 0x001895E8
			// (set) Token: 0x060058E9 RID: 22761 RVA: 0x00021F50 File Offset: 0x00020150
			public unsafe Guid m_activityIdToRestore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityIdToRestore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTracker.ActivityInfo.NativeFieldInfoPtr_m_activityIdToRestore)) = value;
				}
			}

			// Token: 0x04004720 RID: 18208
			private static readonly IntPtr NativeFieldInfoPtr_m_name;

			// Token: 0x04004721 RID: 18209
			private static readonly IntPtr NativeFieldInfoPtr_m_uniqueId;

			// Token: 0x04004722 RID: 18210
			private static readonly IntPtr NativeFieldInfoPtr_m_guid;

			// Token: 0x04004723 RID: 18211
			private static readonly IntPtr NativeFieldInfoPtr_m_activityPathGuidOffset;

			// Token: 0x04004724 RID: 18212
			private static readonly IntPtr NativeFieldInfoPtr_m_level;

			// Token: 0x04004725 RID: 18213
			private static readonly IntPtr NativeFieldInfoPtr_m_eventOptions;

			// Token: 0x04004726 RID: 18214
			private static readonly IntPtr NativeFieldInfoPtr_m_lastChildID;

			// Token: 0x04004727 RID: 18215
			private static readonly IntPtr NativeFieldInfoPtr_m_stopped;

			// Token: 0x04004728 RID: 18216
			private static readonly IntPtr NativeFieldInfoPtr_m_creator;

			// Token: 0x04004729 RID: 18217
			private static readonly IntPtr NativeFieldInfoPtr_m_activityIdToRestore;

			// Token: 0x0400472A RID: 18218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_ActivityInfo_Guid_EventActivityOptions_0;

			// Token: 0x0400472B RID: 18219
			private static readonly IntPtr NativeMethodInfoPtr_get_ActivityId_Public_get_Guid_0;

			// Token: 0x0400472C RID: 18220
			private static readonly IntPtr NativeMethodInfoPtr_Path_Public_Static_String_ActivityInfo_0;

			// Token: 0x0400472D RID: 18221
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0400472E RID: 18222
			private static readonly IntPtr NativeMethodInfoPtr_LiveActivities_Public_Static_String_ActivityInfo_0;

			// Token: 0x0400472F RID: 18223
			private static readonly IntPtr NativeMethodInfoPtr_CanBeOrphan_Public_Boolean_0;

			// Token: 0x04004730 RID: 18224
			private static readonly IntPtr NativeMethodInfoPtr_CreateActivityPathGuid_Private_Void_byref_Guid_byref_Int32_0;

			// Token: 0x04004731 RID: 18225
			private static readonly IntPtr NativeMethodInfoPtr_CreateOverflowGuid_Private_Void_ptr_Guid_0;

			// Token: 0x04004732 RID: 18226
			private static readonly IntPtr NativeMethodInfoPtr_AddIdToGuid_Private_Static_Int32_ptr_Guid_Int32_UInt32_Boolean_0;

			// Token: 0x04004733 RID: 18227
			private static readonly IntPtr NativeMethodInfoPtr_WriteNibble_Private_Static_Void_byref_ptr_Byte_ptr_Byte_UInt32_0;
		}
	}
}
