using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000508 RID: 1288
	public class EventSource : Object
	{
		// Token: 0x06004B37 RID: 19255 RVA: 0x0015BD74 File Offset: 0x00159F74
		// Note: this type is marked as 'beforefieldinit'.
		static EventSource()
		{
			Il2CppClassPointerStore<EventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource>.NativeClassPtr);
			EventSource.NativeFieldInfoPtr_providerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "providerMetadata");
			EventSource.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_name");
			EventSource.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_id");
			EventSource.NativeFieldInfoPtr_m_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_guid");
			EventSource.NativeFieldInfoPtr_m_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_eventData");
			EventSource.NativeFieldInfoPtr_m_rawManifest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_rawManifest");
			EventSource.NativeFieldInfoPtr_m_eventCommandExecuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_eventCommandExecuted");
			EventSource.NativeFieldInfoPtr_m_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_config");
			EventSource.NativeFieldInfoPtr_m_eventSourceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_eventSourceEnabled");
			EventSource.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_level");
			EventSource.NativeFieldInfoPtr_m_matchAnyKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_matchAnyKeyword");
			EventSource.NativeFieldInfoPtr_m_Dispatchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_Dispatchers");
			EventSource.NativeFieldInfoPtr_m_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_provider");
			EventSource.NativeFieldInfoPtr_m_completelyInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_completelyInited");
			EventSource.NativeFieldInfoPtr_m_constructionException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_constructionException");
			EventSource.NativeFieldInfoPtr_m_outOfBandMessageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_outOfBandMessageCount");
			EventSource.NativeFieldInfoPtr_m_deferredCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_deferredCommands");
			EventSource.NativeFieldInfoPtr_m_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_traits");
			EventSource.NativeFieldInfoPtr_s_currentPid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "s_currentPid");
			EventSource.NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_EventSourceExceptionRecurenceCount");
			EventSource.NativeFieldInfoPtr_m_curLiveSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_curLiveSessions");
			EventSource.NativeFieldInfoPtr_m_etwSessionIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_etwSessionIdMap");
			EventSource.NativeFieldInfoPtr_m_legacySessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_legacySessions");
			EventSource.NativeFieldInfoPtr_m_keywordTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_keywordTriggers");
			EventSource.NativeFieldInfoPtr_m_activityFilteringForETWEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_activityFilteringForETWEnabled");
			EventSource.NativeFieldInfoPtr_s_activityDying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "s_activityDying");
			EventSource.NativeFieldInfoPtr_m_activityTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "m_activityTracker");
			EventSource.NativeFieldInfoPtr_namespaceBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "namespaceBytes");
			EventSource.NativeFieldInfoPtr_AspNetEventSourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "AspNetEventSourceGuid");
			EventSource.NativeMethodInfoPtr_WriteMultiMerge_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674549);
			EventSource.NativeMethodInfoPtr_WriteMultiMergeInner_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674550);
			EventSource.NativeMethodInfoPtr_WriteMultiMerge_Internal_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674551);
			EventSource.NativeMethodInfoPtr_WriteCleanup_Private_Void_ptr_GCHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674552);
			EventSource.NativeMethodInfoPtr_InitializeProviderMetadata_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674553);
			EventSource.NativeMethodInfoPtr_AddValueToMetaData_Private_Static_Int32_List_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674554);
			EventSource.NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674555);
			EventSource.NativeMethodInfoPtr_UpdateDescriptor_Private_NameInfo_String_TraceLoggingEventTypes_byref_EventSourceOptions_byref_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674556);
			EventSource.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674557);
			EventSource.NativeMethodInfoPtr_get_Guid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674558);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674559);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674560);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_EventChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674561);
			EventSource.NativeMethodInfoPtr_GetGuid_Public_Static_Guid_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674562);
			EventSource.NativeMethodInfoPtr_GetName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674563);
			EventSource.NativeMethodInfoPtr_SetCurrentThreadActivityId_Public_Static_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674564);
			EventSource.NativeMethodInfoPtr_get_CurrentThreadActivityId_Public_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674565);
			EventSource.NativeMethodInfoPtr_get_InternalCurrentThreadActivityId_Internal_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674566);
			EventSource.NativeMethodInfoPtr_get_FallbackActivityId_Internal_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674567);
			EventSource.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674568);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674569);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674570);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674571);
			EventSource.NativeMethodInfoPtr_OnEventCommand_Protected_Virtual_New_Void_EventCommandEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674572);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674573);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674574);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674575);
			EventSource.NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674576);
			EventSource.NativeMethodInfoPtr_WriteEventWithRelatedActivityIdCore_Protected_Void_Int32_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674577);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674578);
			EventSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674579);
			EventSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674580);
			EventSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674581);
			EventSource.NativeMethodInfoPtr_WriteStringToListener_Internal_Void_EventListener_String_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674582);
			EventSource.NativeMethodInfoPtr_WriteEventRaw_Private_Void_String_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674583);
			EventSource.NativeMethodInfoPtr_Initialize_Private_Void_Guid_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674584);
			EventSource.NativeMethodInfoPtr_GetName_Private_Static_String_Type_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674585);
			EventSource.NativeMethodInfoPtr_GenerateGuidFromName_Private_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674586);
			EventSource.NativeMethodInfoPtr_DecodeObject_Private_Object_Int32_Int32_byref_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674587);
			EventSource.NativeMethodInfoPtr_GetDispatcher_Private_EventDispatcher_EventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674588);
			EventSource.NativeMethodInfoPtr_WriteEventVarargs_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674589);
			EventSource.NativeMethodInfoPtr_SerializeEventArgs_Private_Il2CppReferenceArray_1_Object_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674590);
			EventSource.NativeMethodInfoPtr_LogEventArgsMismatches_Private_Void_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674591);
			EventSource.NativeMethodInfoPtr_GetParamLengthIncludingByteArray_Private_Int32_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674592);
			EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674593);
			EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674594);
			EventSource.NativeMethodInfoPtr_DispatchToAllListeners_Private_Void_Int32_ptr_Guid_EventWrittenEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674595);
			EventSource.NativeMethodInfoPtr_WriteEventString_Private_Void_EventLevel_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674596);
			EventSource.NativeMethodInfoPtr_WriteStringToAllListeners_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674597);
			EventSource.NativeMethodInfoPtr_GetEtwSessionMask_Private_SessionMask_Int32_ptr_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674598);
			EventSource.NativeMethodInfoPtr_IsEnabledByDefault_Private_Boolean_Int32_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674599);
			EventSource.NativeMethodInfoPtr_IsEnabledCommon_Private_Boolean_Boolean_EventLevel_EventKeywords_EventLevel_EventKeywords_EventChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674600);
			EventSource.NativeMethodInfoPtr_ThrowEventSourceException_Private_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674601);
			EventSource.NativeMethodInfoPtr_ValidateEventOpcodeForTransfer_Private_Void_byref_EventMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674602);
			EventSource.NativeMethodInfoPtr_GetOpcodeWithDefault_Internal_Static_EventOpcode_EventOpcode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674603);
			EventSource.NativeMethodInfoPtr_SendCommand_Internal_Void_EventListener_Int32_Int32_EventCommand_Boolean_EventLevel_EventKeywords_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674604);
			EventSource.NativeMethodInfoPtr_DoCommand_Internal_Void_EventCommandEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674605);
			EventSource.NativeMethodInfoPtr_UpdateEtwSession_Internal_Void_Int32_Int32_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674606);
			EventSource.NativeMethodInfoPtr_ParseCommandArgs_Internal_Static_Boolean_IDictionary_2_String_String_byref_Boolean_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674607);
			EventSource.NativeMethodInfoPtr_UpdateKwdTriggers_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674608);
			EventSource.NativeMethodInfoPtr_EnableEventForDispatcher_Internal_Boolean_EventDispatcher_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674609);
			EventSource.NativeMethodInfoPtr_AnyEventEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674610);
			EventSource.NativeMethodInfoPtr_get_IsDisposed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674611);
			EventSource.NativeMethodInfoPtr_EnsureDescriptorsInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674612);
			EventSource.NativeMethodInfoPtr_SendManifest_Private_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674613);
			EventSource.NativeMethodInfoPtr_GetCustomAttributeHelper_Internal_Static_Attribute_MemberInfo_Type_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674614);
			EventSource.NativeMethodInfoPtr_AttributeTypeNamesMatch_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674615);
			EventSource.NativeMethodInfoPtr_GetEventSourceBaseType_Private_Static_Type_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674616);
			EventSource.NativeMethodInfoPtr_CreateManifestAndDescriptors_Private_Static_Il2CppStructArray_1_Byte_Type_String_EventSource_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674617);
			EventSource.NativeMethodInfoPtr_RemoveFirstArgIfRelatedActivityId_Private_Static_Boolean_byref_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674618);
			EventSource.NativeMethodInfoPtr_AddProviderEnumKind_Private_Static_Void_ManifestBuilder_FieldInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674619);
			EventSource.NativeMethodInfoPtr_AddEventDescriptor_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_String_EventAttribute_Il2CppReferenceArray_1_ParameterInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674620);
			EventSource.NativeMethodInfoPtr_TrimEventDescriptors_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674621);
			EventSource.NativeMethodInfoPtr_AddListener_Internal_Void_EventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674622);
			EventSource.NativeMethodInfoPtr_DebugCheckEvent_Private_Static_Void_byref_Dictionary_2_String_String_Il2CppReferenceArray_1_EventMetadata_MethodInfo_EventAttribute_ManifestBuilder_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674623);
			EventSource.NativeMethodInfoPtr_GetHelperCallFirstArg_Private_Static_Int32_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674624);
			EventSource.NativeMethodInfoPtr_ReportOutOfBandMessage_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674625);
			EventSource.NativeMethodInfoPtr_ValidateSettings_Private_EventSourceSettings_EventSourceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674626);
			EventSource.NativeMethodInfoPtr_get_ThrowOnEventWriteErrors_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674627);
			EventSource.NativeMethodInfoPtr_get_SelfDescribingEvents_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674628);
			EventSource.NativeMethodInfoPtr_ReportActivitySamplingInfo_Private_Void_EventListener_SessionMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674629);
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x0015C63C File Offset: 0x0015A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238027, XrefRangeEnd = 238030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteMultiMerge_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x0015C6DC File Offset: 0x0015A8DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238067, RefRangeEnd = 238069, XrefRangeStart = 238030, XrefRangeEnd = 238067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteMultiMergeInner_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x0015C77C File Offset: 0x0015A97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238096, RefRangeEnd = 238097, XrefRangeStart = 238069, XrefRangeEnd = 238096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteMultiMerge_Internal_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x0015C808 File Offset: 0x0015AA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238097, XrefRangeEnd = 238102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCleanup(GCHandle* pPins, int cPins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pPins;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cPins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteCleanup_Private_Void_ptr_GCHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x0015C854 File Offset: 0x0015AA54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238148, RefRangeEnd = 238149, XrefRangeStart = 238102, XrefRangeEnd = 238148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeProviderMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_InitializeProviderMetadata_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x0015C888 File Offset: 0x0015AA88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238169, RefRangeEnd = 238170, XrefRangeStart = 238149, XrefRangeEnd = 238169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddValueToMetaData(List<byte> metaData, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddValueToMetaData_Private_Static_Int32_List_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x0015C8DC File Offset: 0x0015AADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238170, RefRangeEnd = 238172, XrefRangeStart = 238170, XrefRangeEnd = 238170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x0015C91C File Offset: 0x0015AB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238172, XrefRangeEnd = 238178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_UpdateDescriptor_Private_NameInfo_String_TraceLoggingEventTypes_byref_EventSourceOptions_byref_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x0015C99C File Offset: 0x0015AB9C
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x0015C9D4 File Offset: 0x0015ABD4
		public unsafe Guid Guid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_Guid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x0015CA10 File Offset: 0x0015AC10
		[CallerCount(0)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x0015CA4C File Offset: 0x0015AC4C
		[CallerCount(0)]
		public unsafe bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x0015CAA4 File Offset: 0x0015ACA4
		[CallerCount(0)]
		public unsafe bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_EventChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x0015CB0C File Offset: 0x0015AD0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238197, RefRangeEnd = 238200, XrefRangeStart = 238178, XrefRangeEnd = 238197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GetGuid(Type eventSourceType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetGuid_Public_Static_Guid_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x0015CB50 File Offset: 0x0015AD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238200, XrefRangeEnd = 238204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Type eventSourceType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x0015CB8C File Offset: 0x0015AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238204, XrefRangeEnd = 238245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCurrentThreadActivityId(Guid activityId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SetCurrentThreadActivityId_Public_Static_Void_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x0015CBC0 File Offset: 0x0015ADC0
		public unsafe static Guid CurrentThreadActivityId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238245, XrefRangeEnd = 238246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_CurrentThreadActivityId_Public_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x0015CBF0 File Offset: 0x0015ADF0
		public unsafe static Guid InternalCurrentThreadActivityId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 238259, RefRangeEnd = 238263, XrefRangeStart = 238246, XrefRangeEnd = 238259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_InternalCurrentThreadActivityId_Internal_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0015CC20 File Offset: 0x0015AE20
		public unsafe static Guid FallbackActivityId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 238268, RefRangeEnd = 238270, XrefRangeStart = 238263, XrefRangeEnd = 238268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_FallbackActivityId_Internal_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x0015CC50 File Offset: 0x0015AE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238270, XrefRangeEnd = 238288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x0015CC94 File Offset: 0x0015AE94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238298, RefRangeEnd = 238301, XrefRangeStart = 238288, XrefRangeEnd = 238298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x0015CCD0 File Offset: 0x0015AED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238301, XrefRangeEnd = 238311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(EventSourceSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x0015CD18 File Offset: 0x0015AF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238311, XrefRangeEnd = 238321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(EventSourceSettings settings, [Optional] Il2CppStringArray traits)
		{
			if (traits == null)
			{
				traits = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(traits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x0015CD80 File Offset: 0x0015AF80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEventCommand(EventCommandEventArgs command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_OnEventCommand_Protected_Virtual_New_Void_EventCommandEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x0015CDD0 File Offset: 0x0015AFD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238323, RefRangeEnd = 238325, XrefRangeStart = 238321, XrefRangeEnd = 238323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, int arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x0015CE1C File Offset: 0x0015B01C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 238330, RefRangeEnd = 238337, XrefRangeStart = 238325, XrefRangeEnd = 238330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x0015CE80 File Offset: 0x0015B080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238341, RefRangeEnd = 238342, XrefRangeStart = 238337, XrefRangeEnd = 238341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x0015CEF8 File Offset: 0x0015B0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238342, XrefRangeEnd = 238343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x0015CF54 File Offset: 0x0015B154
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 238389, RefRangeEnd = 238393, XrefRangeStart = 238343, XrefRangeEnd = 238389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventWithRelatedActivityIdCore_Protected_Void_Int32_ptr_Guid_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x0015CFBC File Offset: 0x0015B1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238393, XrefRangeEnd = 238394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0015D01C File Offset: 0x0015B21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238398, RefRangeEnd = 238399, XrefRangeStart = 238394, XrefRangeEnd = 238398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x0015D050 File Offset: 0x0015B250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238399, XrefRangeEnd = 238406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x0015D09C File Offset: 0x0015B29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238406, XrefRangeEnd = 238407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x0015D0D8 File Offset: 0x0015B2D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238427, RefRangeEnd = 238429, XrefRangeStart = 238407, XrefRangeEnd = 238427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStringToListener(EventListener listener, string msg, SessionMask m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteStringToListener_Internal_Void_EventListener_String_SessionMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x0015D13C File Offset: 0x0015B33C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238441, RefRangeEnd = 238443, XrefRangeStart = 238429, XrefRangeEnd = 238441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDescriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventRaw_Private_Void_String_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x0015D1C4 File Offset: 0x0015B3C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238492, RefRangeEnd = 238495, XrefRangeStart = 238443, XrefRangeEnd = 238492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Guid eventSourceGuid, string eventSourceName, Il2CppStringArray traits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventSourceGuid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventSourceName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(traits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_Initialize_Private_Void_Guid_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x0015D228 File Offset: 0x0015B428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 238509, RefRangeEnd = 238513, XrefRangeStart = 238495, XrefRangeEnd = 238509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Type eventSourceType, EventManifestOptions flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetName_Private_Static_String_Type_EventManifestOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0015D274 File Offset: 0x0015B474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238527, RefRangeEnd = 238528, XrefRangeStart = 238513, XrefRangeEnd = 238527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GenerateGuidFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GenerateGuidFromName_Private_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x0015D2B8 File Offset: 0x0015B4B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238773, RefRangeEnd = 238774, XrefRangeStart = 238528, XrefRangeEnd = 238773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DecodeObject(int eventId, int parameterId, ref EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameterId;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DecodeObject_Private_Object_Int32_Int32_byref_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new EventSource.EventData*(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x0015D33C File Offset: 0x0015B53C
		[CallerCount(0)]
		public unsafe EventDispatcher GetDispatcher(EventListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetDispatcher_Private_EventDispatcher_EventListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x0015D38C File Offset: 0x0015B58C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238827, RefRangeEnd = 238830, XrefRangeStart = 238774, XrefRangeEnd = 238827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventVarargs(int eventId, Guid* childActivityID, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventVarargs_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x0015D3EC File Offset: 0x0015B5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238841, RefRangeEnd = 238842, XrefRangeStart = 238830, XrefRangeEnd = 238841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> SerializeEventArgs(int eventId, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SerializeEventArgs_Private_Il2CppReferenceArray_1_Object_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0015D44C File Offset: 0x0015B64C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238860, RefRangeEnd = 238861, XrefRangeStart = 238842, XrefRangeEnd = 238860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogEventArgsMismatches(Il2CppReferenceArray<ParameterInfo> infos, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(infos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_LogEventArgsMismatches_Private_Void_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x0015D4A0 File Offset: 0x0015B6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238861, XrefRangeEnd = 238868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParamLengthIncludingByteArray(Il2CppReferenceArray<ParameterInfo> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetParamLengthIncludingByteArray_Private_Int32_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x0015D4F0 File Offset: 0x0015B6F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238905, RefRangeEnd = 238906, XrefRangeStart = 238868, XrefRangeEnd = 238905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x0015D558 File Offset: 0x0015B758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238921, RefRangeEnd = 238923, XrefRangeStart = 238906, XrefRangeEnd = 238921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToAllListeners(int eventId, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x0015D5C4 File Offset: 0x0015B7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238930, RefRangeEnd = 238931, XrefRangeStart = 238923, XrefRangeEnd = 238930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCallbackArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DispatchToAllListeners_Private_Void_Int32_ptr_Guid_EventWrittenEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x0015D624 File Offset: 0x0015B824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238959, RefRangeEnd = 238961, XrefRangeStart = 238931, XrefRangeEnd = 238959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventString(EventLevel level, long keywords, string msgString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msgString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventString_Private_Void_EventLevel_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x0015D684 File Offset: 0x0015B884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238996, RefRangeEnd = 238997, XrefRangeStart = 238961, XrefRangeEnd = 238996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStringToAllListeners(string eventName, string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteStringToAllListeners_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x0015D6D8 File Offset: 0x0015B8D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239013, RefRangeEnd = 239015, XrefRangeStart = 238997, XrefRangeEnd = 239013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetEtwSessionMask_Private_SessionMask_Int32_ptr_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x0015D730 File Offset: 0x0015B930
		[CallerCount(0)]
		public unsafe bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMatchAnyKeyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabledByDefault_Private_Boolean_Int32_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x0015D7A4 File Offset: 0x0015B9A4
		[CallerCount(0)]
		public unsafe bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMatchAnyKeyword;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventKeywords;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventChannel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabledCommon_Private_Boolean_Boolean_EventLevel_EventKeywords_EventLevel_EventKeywords_EventChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x0015D834 File Offset: 0x0015BA34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 239092, RefRangeEnd = 239103, XrefRangeStart = 239015, XrefRangeEnd = 239092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowEventSourceException(string eventName, Exception innerEx = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerEx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ThrowEventSourceException_Private_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x0015D888 File Offset: 0x0015BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239103, XrefRangeEnd = 239104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEventOpcodeForTransfer(ref EventSource.EventMetadata eventData, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventData));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ValidateEventOpcodeForTransfer_Private_Void_byref_EventMetadata_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x0015D8E4 File Offset: 0x0015BAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239104, XrefRangeEnd = 239110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetOpcodeWithDefault_Internal_Static_EventOpcode_EventOpcode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x0015D934 File Offset: 0x0015BB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239125, RefRangeEnd = 239126, XrefRangeStart = 239110, XrefRangeEnd = 239125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> commandArguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref command;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeyword;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SendCommand_Internal_Void_EventListener_Int32_Int32_EventCommand_Boolean_EventLevel_EventKeywords_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x0015D9E0 File Offset: 0x0015BBE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239223, RefRangeEnd = 239225, XrefRangeStart = 239126, XrefRangeEnd = 239223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCommand(EventCommandEventArgs commandArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DoCommand_Internal_Void_EventCommandEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x0015DA24 File Offset: 0x0015BC24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239238, RefRangeEnd = 239240, XrefRangeStart = 239225, XrefRangeEnd = 239238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sessionIdBit;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activityFilters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref participateInSampling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_UpdateEtwSession_Internal_Void_Int32_Int32_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x0015DAA0 File Offset: 0x0015BCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239274, RefRangeEnd = 239275, XrefRangeStart = 239240, XrefRangeEnd = 239274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseCommandArgs(IDictionary<string, string> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandArguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &participateInSampling;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sessionIdBit;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ParseCommandArgs_Internal_Static_Boolean_IDictionary_2_String_String_byref_Boolean_byref_String_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			activityFilters = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x0015DB18 File Offset: 0x0015BD18
		[CallerCount(0)]
		public unsafe void UpdateKwdTriggers(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_UpdateKwdTriggers_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x0015DB58 File Offset: 0x0015BD58
		[CallerCount(0)]
		public unsafe bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_EnableEventForDispatcher_Internal_Boolean_EventDispatcher_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x0015DBC4 File Offset: 0x0015BDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239275, XrefRangeEnd = 239276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyEventEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AnyEventEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x0015DC00 File Offset: 0x0015BE00
		public unsafe bool IsDisposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_IsDisposed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x0015DC3C File Offset: 0x0015BE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239309, RefRangeEnd = 239310, XrefRangeStart = 239276, XrefRangeEnd = 239309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureDescriptorsInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_EnsureDescriptorsInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x0015DC70 File Offset: 0x0015BE70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239330, RefRangeEnd = 239334, XrefRangeStart = 239310, XrefRangeEnd = 239330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendManifest(Il2CppStructArray<byte> rawManifest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawManifest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_SendManifest_Private_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x0015DCC0 File Offset: 0x0015BEC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239347, RefRangeEnd = 239350, XrefRangeStart = 239334, XrefRangeEnd = 239347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = EventManifestOptions.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetCustomAttributeHelper_Internal_Static_Attribute_MemberInfo_Type_EventManifestOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x0015DD24 File Offset: 0x0015BF24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239362, RefRangeEnd = 239365, XrefRangeStart = 239350, XrefRangeEnd = 239362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedAttributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AttributeTypeNamesMatch_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x0015DD78 File Offset: 0x0015BF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239365, XrefRangeEnd = 239377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowEventSourceOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectionOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetEventSourceBaseType_Private_Static_Type_Type_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x0015DDD8 File Offset: 0x0015BFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239422, RefRangeEnd = 239423, XrefRangeStart = 239377, XrefRangeEnd = 239422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = EventManifestOptions.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventSourceDllName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_CreateManifestAndDescriptors_Private_Static_Il2CppStructArray_1_Byte_Type_String_EventSource_EventManifestOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x0015DE50 File Offset: 0x0015C050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239423, XrefRangeEnd = 239438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveFirstArgIfRelatedActivityId(ref Il2CppReferenceArray<ParameterInfo> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_RemoveFirstArgIfRelatedActivityId_Private_Static_Boolean_byref_Il2CppReferenceArray_1_ParameterInfo_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<ParameterInfo>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x0015DEA8 File Offset: 0x0015C0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239438, XrefRangeEnd = 239486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manifest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(staticField);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerEnumKind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddProviderEnumKind_Private_Static_Void_ManifestBuilder_FieldInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x0015DF04 File Offset: 0x0015C104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239486, XrefRangeEnd = 239497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddEventDescriptor(ref Il2CppReferenceArray<EventSource.EventMetadata> eventData, string eventName, EventAttribute eventAttribute, Il2CppReferenceArray<ParameterInfo> eventParameters, bool hasRelatedActivityID)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventParameters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRelatedActivityID;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddEventDescriptor_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_String_EventAttribute_Il2CppReferenceArray_1_ParameterInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			eventData = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<EventSource.EventMetadata>(intPtr4));
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x0015DF94 File Offset: 0x0015C194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239497, XrefRangeEnd = 239503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrimEventDescriptors(ref Il2CppReferenceArray<EventSource.EventMetadata> eventData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_TrimEventDescriptors_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				eventData = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<EventSource.EventMetadata>(intPtr4));
			}
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x0015DFE0 File Offset: 0x0015C1E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239516, RefRangeEnd = 239517, XrefRangeStart = 239503, XrefRangeEnd = 239516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(EventListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_AddListener_Internal_Void_EventListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x0015E024 File Offset: 0x0015C224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239517, XrefRangeEnd = 239640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DebugCheckEvent(ref Dictionary<string, string> eventsByName, Il2CppReferenceArray<EventSource.EventMetadata> eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(eventsByName);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manifest);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_DebugCheckEvent_Private_Static_Void_byref_Dictionary_2_String_String_Il2CppReferenceArray_1_EventMetadata_MethodInfo_EventAttribute_ManifestBuilder_EventManifestOptions_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			eventsByName = ((intPtr4 == 0) ? null : new Dictionary<string, string>(intPtr4));
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x0015E0C8 File Offset: 0x0015C2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239641, RefRangeEnd = 239642, XrefRangeStart = 239640, XrefRangeEnd = 239641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHelperCallFirstArg(MethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_GetHelperCallFirstArg_Private_Static_Int32_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x0015E10C File Offset: 0x0015C30C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 239657, RefRangeEnd = 239670, XrefRangeStart = 239642, XrefRangeEnd = 239657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportOutOfBandMessage(string msg, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ReportOutOfBandMessage_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x0015E15C File Offset: 0x0015C35C
		[CallerCount(0)]
		public unsafe EventSourceSettings ValidateSettings(EventSourceSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ValidateSettings_Private_EventSourceSettings_EventSourceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x0015E1A8 File Offset: 0x0015C3A8
		public unsafe bool ThrowOnEventWriteErrors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_ThrowOnEventWriteErrors_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x0015E1E4 File Offset: 0x0015C3E4
		public unsafe bool SelfDescribingEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_get_SelfDescribingEvents_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x0015E220 File Offset: 0x0015C420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239718, RefRangeEnd = 239719, XrefRangeStart = 239670, XrefRangeEnd = 239718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_ReportActivitySamplingInfo_Private_Void_EventListener_SessionMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x0001BE2B File Offset: 0x0001A02B
		public unsafe void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params Object[] values)
		{
			this.WriteMultiMerge(eventName, ref options, eventTypes, activityID, childActivityID, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x0001BE41 File Offset: 0x0001A041
		public unsafe void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, params Object[] values)
		{
			this.WriteMultiMergeInner(eventName, ref options, eventTypes, activityID, childActivityID, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x0001BE57 File Offset: 0x0001A057
		public EventSource(EventSourceSettings settings, params string[] traits)
			: this(settings, new Il2CppStringArray(traits))
		{
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x0001BE66 File Offset: 0x0001A066
		public void WriteEvent(int eventId, params Object[] args)
		{
			this.WriteEvent(eventId, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x0001BE75 File Offset: 0x0001A075
		public unsafe void WriteToAllListeners(int eventId, Guid* childActivityID, params Object[] args)
		{
			this.WriteToAllListeners(eventId, childActivityID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x0001BE85 File Offset: 0x0001A085
		public EventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x0015E270 File Offset: 0x0015C470
		// (set) Token: 0x06004B90 RID: 19344 RVA: 0x0001BE8E File Offset: 0x0001A08E
		public unsafe Il2CppStructArray<byte> providerMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_providerMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_providerMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x0015E2A0 File Offset: 0x0015C4A0
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x0001BEAD File Offset: 0x0001A0AD
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x0015E2C8 File Offset: 0x0015C4C8
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x0001BECC File Offset: 0x0001A0CC
		public unsafe int m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x0015E2F0 File Offset: 0x0015C4F0
		// (set) Token: 0x06004B96 RID: 19350 RVA: 0x0001BEE7 File Offset: 0x0001A0E7
		public unsafe Guid m_guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_guid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_guid)) = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x0015E318 File Offset: 0x0015C518
		// (set) Token: 0x06004B98 RID: 19352 RVA: 0x0001BF02 File Offset: 0x0001A102
		public unsafe Il2CppReferenceArray<EventSource.EventMetadata> m_eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventSource.EventMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x0015E348 File Offset: 0x0015C548
		// (set) Token: 0x06004B9A RID: 19354 RVA: 0x0001BF21 File Offset: 0x0001A121
		public unsafe Il2CppStructArray<byte> m_rawManifest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_rawManifest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_rawManifest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x0015E378 File Offset: 0x0015C578
		// (set) Token: 0x06004B9C RID: 19356 RVA: 0x0001BF40 File Offset: 0x0001A140
		public unsafe EventHandler<EventCommandEventArgs> m_eventCommandExecuted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventCommandExecuted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<EventCommandEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventCommandExecuted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x0015E3A8 File Offset: 0x0015C5A8
		// (set) Token: 0x06004B9E RID: 19358 RVA: 0x0001BF5F File Offset: 0x0001A15F
		public unsafe EventSourceSettings m_config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_config);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_config)) = value;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x0015E3D0 File Offset: 0x0015C5D0
		// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x0001BF7A File Offset: 0x0001A17A
		public unsafe bool m_eventSourceEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventSourceEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_eventSourceEnabled)) = value;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x0015E3F8 File Offset: 0x0015C5F8
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x0001BF95 File Offset: 0x0001A195
		public unsafe EventLevel m_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_level)) = value;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x0015E420 File Offset: 0x0015C620
		// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public unsafe EventKeywords m_matchAnyKeyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_matchAnyKeyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_matchAnyKeyword)) = value;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x0015E448 File Offset: 0x0015C648
		// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x0001BFCB File Offset: 0x0001A1CB
		public unsafe EventDispatcher m_Dispatchers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_Dispatchers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_Dispatchers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x0015E478 File Offset: 0x0015C678
		// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x0001BFEA File Offset: 0x0001A1EA
		public unsafe EventSource.OverideEventProvider m_provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource.OverideEventProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x0015E4A8 File Offset: 0x0015C6A8
		// (set) Token: 0x06004BAA RID: 19370 RVA: 0x0001C009 File Offset: 0x0001A209
		public unsafe bool m_completelyInited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_completelyInited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_completelyInited)) = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06004BAB RID: 19371 RVA: 0x0015E4D0 File Offset: 0x0015C6D0
		// (set) Token: 0x06004BAC RID: 19372 RVA: 0x0001C024 File Offset: 0x0001A224
		public unsafe Exception m_constructionException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_constructionException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_constructionException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06004BAD RID: 19373 RVA: 0x0015E500 File Offset: 0x0015C700
		// (set) Token: 0x06004BAE RID: 19374 RVA: 0x0001C043 File Offset: 0x0001A243
		public unsafe byte m_outOfBandMessageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_outOfBandMessageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_outOfBandMessageCount)) = value;
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06004BAF RID: 19375 RVA: 0x0015E528 File Offset: 0x0015C728
		// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x0001C05E File Offset: 0x0001A25E
		public unsafe EventCommandEventArgs m_deferredCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_deferredCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCommandEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_deferredCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x0015E558 File Offset: 0x0015C758
		// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x0001C07D File Offset: 0x0001A27D
		public unsafe Il2CppStringArray m_traits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_traits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_traits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x0015E588 File Offset: 0x0015C788
		// (set) Token: 0x06004BB4 RID: 19380 RVA: 0x0001C09C File Offset: 0x0001A29C
		public unsafe static uint s_currentPid
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_s_currentPid, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_s_currentPid, (void*)(&value));
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x0015E5A4 File Offset: 0x0015C7A4
		// (set) Token: 0x06004BB6 RID: 19382 RVA: 0x0001C0AA File Offset: 0x0001A2AA
		public unsafe static byte m_EventSourceExceptionRecurenceCount
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount, (void*)(&value));
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x0015E5C0 File Offset: 0x0015C7C0
		// (set) Token: 0x06004BB8 RID: 19384 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		public unsafe SessionMask m_curLiveSessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_curLiveSessions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_curLiveSessions)) = value;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x0015E5E8 File Offset: 0x0015C7E8
		// (set) Token: 0x06004BBA RID: 19386 RVA: 0x0001C0D3 File Offset: 0x0001A2D3
		public unsafe Il2CppReferenceArray<EtwSession> m_etwSessionIdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_etwSessionIdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EtwSession>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_etwSessionIdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06004BBB RID: 19387 RVA: 0x0015E618 File Offset: 0x0015C818
		// (set) Token: 0x06004BBC RID: 19388 RVA: 0x0001C0F2 File Offset: 0x0001A2F2
		public unsafe List<EtwSession> m_legacySessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_legacySessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EtwSession>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_legacySessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06004BBD RID: 19389 RVA: 0x0015E648 File Offset: 0x0015C848
		// (set) Token: 0x06004BBE RID: 19390 RVA: 0x0001C111 File Offset: 0x0001A311
		public unsafe long m_keywordTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_keywordTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_keywordTriggers)) = value;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x0015E670 File Offset: 0x0015C870
		// (set) Token: 0x06004BC0 RID: 19392 RVA: 0x0001C12C File Offset: 0x0001A32C
		public unsafe SessionMask m_activityFilteringForETWEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityFilteringForETWEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityFilteringForETWEnabled)) = value;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x0015E698 File Offset: 0x0015C898
		// (set) Token: 0x06004BC2 RID: 19394 RVA: 0x0001C147 File Offset: 0x0001A347
		public unsafe static Action<Guid> s_activityDying
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_s_activityDying, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_s_activityDying, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x0015E6C0 File Offset: 0x0015C8C0
		// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x0001C159 File Offset: 0x0001A359
		public unsafe ActivityTracker m_activityTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr_m_activityTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x0015E6F0 File Offset: 0x0015C8F0
		// (set) Token: 0x06004BC6 RID: 19398 RVA: 0x0001C178 File Offset: 0x0001A378
		public unsafe static Il2CppStructArray<byte> namespaceBytes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_namespaceBytes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_namespaceBytes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x0015E718 File Offset: 0x0015C918
		// (set) Token: 0x06004BC8 RID: 19400 RVA: 0x0001C18A File Offset: 0x0001A38A
		public unsafe static Guid AspNetEventSourceGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(EventSource.NativeFieldInfoPtr_AspNetEventSourceGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSource.NativeFieldInfoPtr_AspNetEventSourceGuid, (void*)(&value));
			}
		}

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeFieldInfoPtr_providerMetadata;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeFieldInfoPtr_m_guid;

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeFieldInfoPtr_m_eventData;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeFieldInfoPtr_m_rawManifest;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeFieldInfoPtr_m_eventCommandExecuted;

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeFieldInfoPtr_m_config;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeFieldInfoPtr_m_eventSourceEnabled;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeFieldInfoPtr_m_level;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeFieldInfoPtr_m_matchAnyKeyword;

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatchers;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeFieldInfoPtr_m_provider;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeFieldInfoPtr_m_completelyInited;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeFieldInfoPtr_m_constructionException;

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeFieldInfoPtr_m_outOfBandMessageCount;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeFieldInfoPtr_m_deferredCommands;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeFieldInfoPtr_m_traits;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeFieldInfoPtr_s_currentPid;

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSourceExceptionRecurenceCount;

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeFieldInfoPtr_m_curLiveSessions;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeFieldInfoPtr_m_etwSessionIdMap;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeFieldInfoPtr_m_legacySessions;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeFieldInfoPtr_m_keywordTriggers;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilteringForETWEnabled;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeFieldInfoPtr_s_activityDying;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeFieldInfoPtr_m_activityTracker;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeFieldInfoPtr_namespaceBytes;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeFieldInfoPtr_AspNetEventSourceGuid;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeMethodInfoPtr_WriteMultiMerge_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeMethodInfoPtr_WriteMultiMergeInner_Private_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeMethodInfoPtr_WriteMultiMerge_Internal_Void_String_byref_EventSourceOptions_TraceLoggingEventTypes_ptr_Guid_ptr_Guid_ptr_EventData_0;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeMethodInfoPtr_WriteCleanup_Private_Void_ptr_GCHandle_Int32_0;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProviderMetadata_Private_Void_0;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeMethodInfoPtr_AddValueToMetaData_Private_Static_Int32_List_1_Byte_String_0;

		// Token: 0x04003CF3 RID: 15603
		private static readonly IntPtr NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0;

		// Token: 0x04003CF4 RID: 15604
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDescriptor_Private_NameInfo_String_TraceLoggingEventTypes_byref_EventSourceOptions_byref_EventDescriptor_0;

		// Token: 0x04003CF5 RID: 15605
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003CF6 RID: 15606
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_get_Guid_0;

		// Token: 0x04003CF7 RID: 15607
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x04003CF8 RID: 15608
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0;

		// Token: 0x04003CF9 RID: 15609
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_EventChannel_0;

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeMethodInfoPtr_GetGuid_Public_Static_Guid_Type_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_Type_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentThreadActivityId_Public_Static_Void_Guid_0;

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadActivityId_Public_Static_get_Guid_0;

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrentThreadActivityId_Internal_Static_get_Guid_0;

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackActivityId_Internal_Static_get_Guid_0;

		// Token: 0x04003D00 RID: 15616
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003D01 RID: 15617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003D02 RID: 15618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0;

		// Token: 0x04003D03 RID: 15619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_Il2CppStringArray_0;

		// Token: 0x04003D04 RID: 15620
		private static readonly IntPtr NativeMethodInfoPtr_OnEventCommand_Protected_Virtual_New_Void_EventCommandEventArgs_0;

		// Token: 0x04003D05 RID: 15621
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0;

		// Token: 0x04003D06 RID: 15622
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_0;

		// Token: 0x04003D07 RID: 15623
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0;

		// Token: 0x04003D08 RID: 15624
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0;

		// Token: 0x04003D09 RID: 15625
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventWithRelatedActivityIdCore_Protected_Void_Int32_ptr_Guid_Int32_ptr_EventData_0;

		// Token: 0x04003D0A RID: 15626
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003D0B RID: 15627
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003D0C RID: 15628
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04003D0D RID: 15629
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToListener_Internal_Void_EventListener_String_SessionMask_0;

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventRaw_Private_Void_String_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0;

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Guid_String_Il2CppStringArray_0;

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_Static_String_Type_EventManifestOptions_0;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGuidFromName_Private_Static_Guid_String_0;

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeMethodInfoPtr_DecodeObject_Private_Object_Int32_Int32_byref_ptr_EventData_0;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeMethodInfoPtr_GetDispatcher_Private_EventDispatcher_EventListener_0;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventVarargs_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeMethodInfoPtr_SerializeEventArgs_Private_Il2CppReferenceArray_1_Object_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeMethodInfoPtr_LogEventArgsMismatches_Private_Void_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr_GetParamLengthIncludingByteArray_Private_Int32_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Int32_ptr_EventData_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAllListeners_Private_Void_Int32_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeMethodInfoPtr_DispatchToAllListeners_Private_Void_Int32_ptr_Guid_EventWrittenEventArgs_0;

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventString_Private_Void_EventLevel_Int64_String_0;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToAllListeners_Private_Void_String_String_0;

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeMethodInfoPtr_GetEtwSessionMask_Private_SessionMask_Int32_ptr_Guid_0;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledByDefault_Private_Boolean_Int32_Boolean_EventLevel_EventKeywords_0;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledCommon_Private_Boolean_Boolean_EventLevel_EventKeywords_EventLevel_EventKeywords_EventChannel_0;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeMethodInfoPtr_ThrowEventSourceException_Private_Void_String_Exception_0;

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEventOpcodeForTransfer_Private_Void_byref_EventMetadata_String_0;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeMethodInfoPtr_GetOpcodeWithDefault_Internal_Static_EventOpcode_EventOpcode_String_0;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeMethodInfoPtr_SendCommand_Internal_Void_EventListener_Int32_Int32_EventCommand_Boolean_EventLevel_EventKeywords_IDictionary_2_String_String_0;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_DoCommand_Internal_Void_EventCommandEventArgs_0;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEtwSession_Internal_Void_Int32_Int32_Boolean_String_Boolean_0;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeMethodInfoPtr_ParseCommandArgs_Internal_Static_Boolean_IDictionary_2_String_String_byref_Boolean_byref_String_byref_Int32_0;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKwdTriggers_Internal_Void_Boolean_0;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr_EnableEventForDispatcher_Internal_Boolean_EventDispatcher_Int32_Boolean_0;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeMethodInfoPtr_AnyEventEnabled_Private_Boolean_0;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisposed_Private_get_Boolean_0;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDescriptorsInitialized_Private_Void_0;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeMethodInfoPtr_SendManifest_Private_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributeHelper_Internal_Static_Attribute_MemberInfo_Type_EventManifestOptions_0;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeMethodInfoPtr_AttributeTypeNamesMatch_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeMethodInfoPtr_GetEventSourceBaseType_Private_Static_Type_Type_Boolean_Boolean_0;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeMethodInfoPtr_CreateManifestAndDescriptors_Private_Static_Il2CppStructArray_1_Byte_Type_String_EventSource_EventManifestOptions_0;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFirstArgIfRelatedActivityId_Private_Static_Boolean_byref_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeMethodInfoPtr_AddProviderEnumKind_Private_Static_Void_ManifestBuilder_FieldInfo_String_0;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeMethodInfoPtr_AddEventDescriptor_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_String_EventAttribute_Il2CppReferenceArray_1_ParameterInfo_Boolean_0;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeMethodInfoPtr_TrimEventDescriptors_Private_Static_Void_byref_Il2CppReferenceArray_1_EventMetadata_0;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Internal_Void_EventListener_0;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeMethodInfoPtr_DebugCheckEvent_Private_Static_Void_byref_Dictionary_2_String_String_Il2CppReferenceArray_1_EventMetadata_MethodInfo_EventAttribute_ManifestBuilder_EventManifestOptions_0;

		// Token: 0x04003D38 RID: 15672
		private static readonly IntPtr NativeMethodInfoPtr_GetHelperCallFirstArg_Private_Static_Int32_MethodInfo_0;

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeMethodInfoPtr_ReportOutOfBandMessage_Internal_Void_String_Boolean_0;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSettings_Private_EventSourceSettings_EventSourceSettings_0;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowOnEventWriteErrors_Private_get_Boolean_0;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeMethodInfoPtr_get_SelfDescribingEvents_Private_get_Boolean_0;

		// Token: 0x04003D3D RID: 15677
		private static readonly IntPtr NativeMethodInfoPtr_ReportActivitySamplingInfo_Private_Void_EventListener_SessionMask_0;

		// Token: 0x0200067C RID: 1660
		[StructLayout(2)]
		public struct EventData
		{
			// Token: 0x06005880 RID: 22656 RVA: 0x0018A0D0 File Offset: 0x001882D0
			// Note: this type is marked as 'beforefieldinit'.
			static EventData()
			{
				Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "EventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr);
				EventSource.EventData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "m_Ptr");
				EventSource.EventData.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "m_Size");
				EventSource.EventData.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "m_Reserved");
				EventSource.EventData.NativeMethodInfoPtr_get_DataPointer_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674631);
				EventSource.EventData.NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674632);
				EventSource.EventData.NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674633);
				EventSource.EventData.NativeMethodInfoPtr_SetMetadata_Internal_Void_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674634);
			}

			// Token: 0x170016E6 RID: 5862
			// (get) Token: 0x06005881 RID: 22657 RVA: 0x0018A188 File Offset: 0x00188388
			// (set) Token: 0x06005882 RID: 22658 RVA: 0x0018A1B8 File Offset: 0x001883B8
			public unsafe IntPtr DataPointer
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_get_DataPointer_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170016E7 RID: 5863
			// (set) Token: 0x06005883 RID: 22659 RVA: 0x0018A1EC File Offset: 0x001883EC
			public unsafe int Size
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005884 RID: 22660 RVA: 0x0018A220 File Offset: 0x00188420
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 237985, RefRangeEnd = 237991, XrefRangeStart = 237982, XrefRangeEnd = 237985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetMetadata(byte* pointer, int size, int reserved)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pointer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_SetMetadata_Internal_Void_ptr_Byte_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005885 RID: 22661 RVA: 0x00021B9F File Offset: 0x0001FD9F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, ref this));
			}

			// Token: 0x040046F1 RID: 18161
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x040046F2 RID: 18162
			private static readonly IntPtr NativeFieldInfoPtr_m_Size;

			// Token: 0x040046F3 RID: 18163
			private static readonly IntPtr NativeFieldInfoPtr_m_Reserved;

			// Token: 0x040046F4 RID: 18164
			private static readonly IntPtr NativeMethodInfoPtr_get_DataPointer_Public_get_IntPtr_0;

			// Token: 0x040046F5 RID: 18165
			private static readonly IntPtr NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0;

			// Token: 0x040046F6 RID: 18166
			private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0;

			// Token: 0x040046F7 RID: 18167
			private static readonly IntPtr NativeMethodInfoPtr_SetMetadata_Internal_Void_ptr_Byte_Int32_Int32_0;

			// Token: 0x040046F8 RID: 18168
			[FieldOffset(0)]
			public long m_Ptr;

			// Token: 0x040046F9 RID: 18169
			[FieldOffset(8)]
			public int m_Size;

			// Token: 0x040046FA RID: 18170
			[FieldOffset(12)]
			public int m_Reserved;
		}

		// Token: 0x0200067D RID: 1661
		public sealed class Sha1ForNonSecretPurposes : ValueType
		{
			// Token: 0x06005886 RID: 22662 RVA: 0x0018A270 File Offset: 0x00188470
			// Note: this type is marked as 'beforefieldinit'.
			static Sha1ForNonSecretPurposes()
			{
				Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "Sha1ForNonSecretPurposes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr);
				EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, "length");
				EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, "w");
				EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, "pos");
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674635);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674636);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674637);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Finish_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674638);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Drain_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674639);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674640);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol5_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674641);
				EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol30_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr, 100674642);
			}

			// Token: 0x06005887 RID: 22663 RVA: 0x0018A378 File Offset: 0x00188578
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 237994, RefRangeEnd = 237995, XrefRangeStart = 237991, XrefRangeEnd = 237994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005888 RID: 22664 RVA: 0x0018A3B0 File Offset: 0x001885B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 237996, RefRangeEnd = 237997, XrefRangeStart = 237995, XrefRangeEnd = 237996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Append(byte input)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005889 RID: 22665 RVA: 0x0018A3F4 File Offset: 0x001885F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237997, XrefRangeEnd = 237999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Append(Il2CppStructArray<byte> input)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Append_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600588A RID: 22666 RVA: 0x0018A43C File Offset: 0x0018863C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 238009, RefRangeEnd = 238010, XrefRangeStart = 237999, XrefRangeEnd = 238009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Finish(Il2CppStructArray<byte> output)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Finish_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600588B RID: 22667 RVA: 0x0018A484 File Offset: 0x00188684
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 238010, RefRangeEnd = 238023, XrefRangeStart = 238010, XrefRangeEnd = 238010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Drain()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Drain_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600588C RID: 22668 RVA: 0x0018A4BC File Offset: 0x001886BC
			[CallerCount(0)]
			public unsafe static uint Rol1(uint input)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600588D RID: 22669 RVA: 0x0018A4FC File Offset: 0x001886FC
			[CallerCount(0)]
			public unsafe static uint Rol5(uint input)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol5_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600588E RID: 22670 RVA: 0x0018A53C File Offset: 0x0018873C
			[CallerCount(0)]
			public unsafe static uint Rol30(uint input)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.Sha1ForNonSecretPurposes.NativeMethodInfoPtr_Rol30_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600588F RID: 22671 RVA: 0x00021BB1 File Offset: 0x0001FDB1
			public Sha1ForNonSecretPurposes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005890 RID: 22672 RVA: 0x00021BBA File Offset: 0x0001FDBA
			public Sha1ForNonSecretPurposes()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource.Sha1ForNonSecretPurposes>.NativeClassPtr))
			{
			}

			// Token: 0x170016E8 RID: 5864
			// (get) Token: 0x06005891 RID: 22673 RVA: 0x0018A57C File Offset: 0x0018877C
			// (set) Token: 0x06005892 RID: 22674 RVA: 0x00021BCC File Offset: 0x0001FDCC
			public unsafe long length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x170016E9 RID: 5865
			// (get) Token: 0x06005893 RID: 22675 RVA: 0x0018A5A4 File Offset: 0x001887A4
			// (set) Token: 0x06005894 RID: 22676 RVA: 0x00021BE7 File Offset: 0x0001FDE7
			public unsafe Il2CppStructArray<uint> w
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_w);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_w), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016EA RID: 5866
			// (get) Token: 0x06005895 RID: 22677 RVA: 0x0018A5D4 File Offset: 0x001887D4
			// (set) Token: 0x06005896 RID: 22678 RVA: 0x00021C06 File Offset: 0x0001FE06
			public unsafe int pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.Sha1ForNonSecretPurposes.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x040046FB RID: 18171
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x040046FC RID: 18172
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x040046FD RID: 18173
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040046FE RID: 18174
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

			// Token: 0x040046FF RID: 18175
			private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Byte_0;

			// Token: 0x04004700 RID: 18176
			private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004701 RID: 18177
			private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004702 RID: 18178
			private static readonly IntPtr NativeMethodInfoPtr_Drain_Private_Void_0;

			// Token: 0x04004703 RID: 18179
			private static readonly IntPtr NativeMethodInfoPtr_Rol1_Private_Static_UInt32_UInt32_0;

			// Token: 0x04004704 RID: 18180
			private static readonly IntPtr NativeMethodInfoPtr_Rol5_Private_Static_UInt32_UInt32_0;

			// Token: 0x04004705 RID: 18181
			private static readonly IntPtr NativeMethodInfoPtr_Rol30_Private_Static_UInt32_UInt32_0;
		}

		// Token: 0x0200067E RID: 1662
		public class OverideEventProvider : EventProvider
		{
			// Token: 0x06005897 RID: 22679 RVA: 0x0018A5FC File Offset: 0x001887FC
			// Note: this type is marked as 'beforefieldinit'.
			static OverideEventProvider()
			{
				Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "OverideEventProvider");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr);
				EventSource.OverideEventProvider.NativeFieldInfoPtr_m_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr, "m_eventSource");
				EventSource.OverideEventProvider.NativeMethodInfoPtr__ctor_Public_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr, 100674643);
				EventSource.OverideEventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr, 100674644);
			}

			// Token: 0x06005898 RID: 22680 RVA: 0x0018A664 File Offset: 0x00188864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238023, XrefRangeEnd = 238026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverideEventProvider(EventSource eventSource)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource.OverideEventProvider>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.OverideEventProvider.NativeMethodInfoPtr__ctor_Public_Void_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005899 RID: 22681 RVA: 0x0018A6B0 File Offset: 0x001888B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238026, XrefRangeEnd = 238027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref command;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.OverideEventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600589A RID: 22682 RVA: 0x00021C21 File Offset: 0x0001FE21
			public OverideEventProvider(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016EB RID: 5867
			// (get) Token: 0x0600589B RID: 22683 RVA: 0x0018A728 File Offset: 0x00188928
			// (set) Token: 0x0600589C RID: 22684 RVA: 0x00021C2A File Offset: 0x0001FE2A
			public unsafe EventSource m_eventSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.OverideEventProvider.NativeFieldInfoPtr_m_eventSource);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.OverideEventProvider.NativeFieldInfoPtr_m_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004706 RID: 18182
			private static readonly IntPtr NativeFieldInfoPtr_m_eventSource;

			// Token: 0x04004707 RID: 18183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSource_0;

			// Token: 0x04004708 RID: 18184
			private static readonly IntPtr NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0;
		}

		// Token: 0x0200067F RID: 1663
		public sealed class EventMetadata : ValueType
		{
			// Token: 0x0600589D RID: 22685 RVA: 0x0018A758 File Offset: 0x00188958
			// Note: this type is marked as 'beforefieldinit'.
			static EventMetadata()
			{
				Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "EventMetadata");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr);
				EventSource.EventMetadata.NativeFieldInfoPtr_Descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Descriptor");
				EventSource.EventMetadata.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Tags");
				EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForAnyListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "EnabledForAnyListener");
				EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForETW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "EnabledForETW");
				EventSource.EventMetadata.NativeFieldInfoPtr_HasRelatedActivityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "HasRelatedActivityID");
				EventSource.EventMetadata.NativeFieldInfoPtr_TriggersActivityTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "TriggersActivityTracking");
				EventSource.EventMetadata.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Name");
				EventSource.EventMetadata.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Message");
				EventSource.EventMetadata.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "Parameters");
				EventSource.EventMetadata.NativeFieldInfoPtr_TraceLoggingEventTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "TraceLoggingEventTypes");
				EventSource.EventMetadata.NativeFieldInfoPtr_ActivityOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr, "ActivityOptions");
			}

			// Token: 0x0600589E RID: 22686 RVA: 0x00021C49 File Offset: 0x0001FE49
			public EventMetadata(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600589F RID: 22687 RVA: 0x00021C52 File Offset: 0x0001FE52
			public EventMetadata()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource.EventMetadata>.NativeClassPtr))
			{
			}

			// Token: 0x170016EC RID: 5868
			// (get) Token: 0x060058A0 RID: 22688 RVA: 0x0018A860 File Offset: 0x00188A60
			// (set) Token: 0x060058A1 RID: 22689 RVA: 0x00021C64 File Offset: 0x0001FE64
			public unsafe EventDescriptor Descriptor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Descriptor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Descriptor)) = value;
				}
			}

			// Token: 0x170016ED RID: 5869
			// (get) Token: 0x060058A2 RID: 22690 RVA: 0x0018A888 File Offset: 0x00188A88
			// (set) Token: 0x060058A3 RID: 22691 RVA: 0x00021C7F File Offset: 0x0001FE7F
			public unsafe EventTags Tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Tags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Tags)) = value;
				}
			}

			// Token: 0x170016EE RID: 5870
			// (get) Token: 0x060058A4 RID: 22692 RVA: 0x0018A8B0 File Offset: 0x00188AB0
			// (set) Token: 0x060058A5 RID: 22693 RVA: 0x00021C9A File Offset: 0x0001FE9A
			public unsafe bool EnabledForAnyListener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForAnyListener);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForAnyListener)) = value;
				}
			}

			// Token: 0x170016EF RID: 5871
			// (get) Token: 0x060058A6 RID: 22694 RVA: 0x0018A8D8 File Offset: 0x00188AD8
			// (set) Token: 0x060058A7 RID: 22695 RVA: 0x00021CB5 File Offset: 0x0001FEB5
			public unsafe bool EnabledForETW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForETW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_EnabledForETW)) = value;
				}
			}

			// Token: 0x170016F0 RID: 5872
			// (get) Token: 0x060058A8 RID: 22696 RVA: 0x0018A900 File Offset: 0x00188B00
			// (set) Token: 0x060058A9 RID: 22697 RVA: 0x00021CD0 File Offset: 0x0001FED0
			public unsafe bool HasRelatedActivityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_HasRelatedActivityID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_HasRelatedActivityID)) = value;
				}
			}

			// Token: 0x170016F1 RID: 5873
			// (get) Token: 0x060058AA RID: 22698 RVA: 0x0018A928 File Offset: 0x00188B28
			// (set) Token: 0x060058AB RID: 22699 RVA: 0x00021CEB File Offset: 0x0001FEEB
			public unsafe byte TriggersActivityTracking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TriggersActivityTracking);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TriggersActivityTracking)) = value;
				}
			}

			// Token: 0x170016F2 RID: 5874
			// (get) Token: 0x060058AC RID: 22700 RVA: 0x0018A950 File Offset: 0x00188B50
			// (set) Token: 0x060058AD RID: 22701 RVA: 0x00021D06 File Offset: 0x0001FF06
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170016F3 RID: 5875
			// (get) Token: 0x060058AE RID: 22702 RVA: 0x0018A978 File Offset: 0x00188B78
			// (set) Token: 0x060058AF RID: 22703 RVA: 0x00021D25 File Offset: 0x0001FF25
			public unsafe string Message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170016F4 RID: 5876
			// (get) Token: 0x060058B0 RID: 22704 RVA: 0x0018A9A0 File Offset: 0x00188BA0
			// (set) Token: 0x060058B1 RID: 22705 RVA: 0x00021D44 File Offset: 0x0001FF44
			public unsafe Il2CppReferenceArray<ParameterInfo> Parameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Parameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_Parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F5 RID: 5877
			// (get) Token: 0x060058B2 RID: 22706 RVA: 0x0018A9D0 File Offset: 0x00188BD0
			// (set) Token: 0x060058B3 RID: 22707 RVA: 0x00021D63 File Offset: 0x0001FF63
			public unsafe TraceLoggingEventTypes TraceLoggingEventTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TraceLoggingEventTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingEventTypes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_TraceLoggingEventTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F6 RID: 5878
			// (get) Token: 0x060058B4 RID: 22708 RVA: 0x0018AA00 File Offset: 0x00188C00
			// (set) Token: 0x060058B5 RID: 22709 RVA: 0x00021D82 File Offset: 0x0001FF82
			public unsafe EventActivityOptions ActivityOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_ActivityOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.EventMetadata.NativeFieldInfoPtr_ActivityOptions)) = value;
				}
			}

			// Token: 0x04004709 RID: 18185
			private static readonly IntPtr NativeFieldInfoPtr_Descriptor;

			// Token: 0x0400470A RID: 18186
			private static readonly IntPtr NativeFieldInfoPtr_Tags;

			// Token: 0x0400470B RID: 18187
			private static readonly IntPtr NativeFieldInfoPtr_EnabledForAnyListener;

			// Token: 0x0400470C RID: 18188
			private static readonly IntPtr NativeFieldInfoPtr_EnabledForETW;

			// Token: 0x0400470D RID: 18189
			private static readonly IntPtr NativeFieldInfoPtr_HasRelatedActivityID;

			// Token: 0x0400470E RID: 18190
			private static readonly IntPtr NativeFieldInfoPtr_TriggersActivityTracking;

			// Token: 0x0400470F RID: 18191
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04004710 RID: 18192
			private static readonly IntPtr NativeFieldInfoPtr_Message;

			// Token: 0x04004711 RID: 18193
			private static readonly IntPtr NativeFieldInfoPtr_Parameters;

			// Token: 0x04004712 RID: 18194
			private static readonly IntPtr NativeFieldInfoPtr_TraceLoggingEventTypes;

			// Token: 0x04004713 RID: 18195
			private static readonly IntPtr NativeFieldInfoPtr_ActivityOptions;
		}
	}
}
