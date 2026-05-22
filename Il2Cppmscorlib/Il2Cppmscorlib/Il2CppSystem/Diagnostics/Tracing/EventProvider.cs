using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000514 RID: 1300
	public class EventProvider : Object
	{
		// Token: 0x06004C60 RID: 19552 RVA: 0x00160B00 File Offset: 0x0015ED00
		// Note: this type is marked as 'beforefieldinit'.
		static EventProvider()
		{
			Il2CppClassPointerStore<EventProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider>.NativeClassPtr);
			EventProvider.NativeFieldInfoPtr_m_setInformationMissing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_setInformationMissing");
			EventProvider.NativeFieldInfoPtr_m_etwCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_etwCallback");
			EventProvider.NativeFieldInfoPtr_m_thisGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_thisGCHandle");
			EventProvider.NativeFieldInfoPtr_m_regHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_regHandle");
			EventProvider.NativeFieldInfoPtr_m_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_level");
			EventProvider.NativeFieldInfoPtr_m_anyKeywordMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_anyKeywordMask");
			EventProvider.NativeFieldInfoPtr_m_allKeywordMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_allKeywordMask");
			EventProvider.NativeFieldInfoPtr_m_liveSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_liveSessions");
			EventProvider.NativeFieldInfoPtr_m_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_enabled");
			EventProvider.NativeFieldInfoPtr_m_providerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_providerId");
			EventProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_disposed");
			EventProvider.NativeFieldInfoPtr_s_returnCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "s_returnCode");
			EventProvider.NativeFieldInfoPtr_nibblebits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "nibblebits");
			EventProvider.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674731);
			EventProvider.NativeMethodInfoPtr_Register_Internal_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674732);
			EventProvider.NativeMethodInfoPtr_SetInformation_Internal_Int32_EVENT_INFO_CLASS_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674733);
			EventProvider.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674734);
			EventProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674735);
			EventProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674736);
			EventProvider.NativeMethodInfoPtr_Deregister_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674737);
			EventProvider.NativeMethodInfoPtr_EtwEnableCallBack_Private_Static_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674738);
			EventProvider.NativeMethodInfoPtr_EtwEnableCallBackImpl_Private_Void_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674739);
			EventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_New_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674740);
			EventProvider.NativeMethodInfoPtr_get_Level_Protected_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674741);
			EventProvider.NativeMethodInfoPtr_get_MatchAnyKeyword_Protected_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674742);
			EventProvider.NativeMethodInfoPtr_FindNull_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674743);
			EventProvider.NativeMethodInfoPtr_GetSessions_Private_List_1_Tuple_2_SessionInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674744);
			EventProvider.NativeMethodInfoPtr_GetSessionInfoCallback_Private_Static_Void_Int32_Int64_byref_List_1_SessionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674745);
			EventProvider.NativeMethodInfoPtr_GetSessionInfo_Private_Void_Action_2_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674746);
			EventProvider.NativeMethodInfoPtr_IndexOfSessionInList_Private_Static_Int32_List_1_SessionInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674747);
			EventProvider.NativeMethodInfoPtr_GetDataFromController_Private_Boolean_Int32_ptr_EVENT_FILTER_DESCRIPTOR_byref_ControllerCommand_byref_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674748);
			EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674749);
			EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674750);
			EventProvider.NativeMethodInfoPtr_GetLastWriteEventError_Public_Static_WriteEventErrorCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674751);
			EventProvider.NativeMethodInfoPtr_SetLastError_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674752);
			EventProvider.NativeMethodInfoPtr_EncodeObject_Private_Static_Object_byref_Object_byref_ptr_EventData_byref_ptr_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674753);
			EventProvider.NativeMethodInfoPtr_WriteEvent_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674754);
			EventProvider.NativeMethodInfoPtr_WriteEvent_FamOrAssem_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674755);
			EventProvider.NativeMethodInfoPtr_WriteEventRaw_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674756);
			EventProvider.NativeMethodInfoPtr_EventUnregister_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674757);
			EventProvider.NativeMethodInfoPtr_bitcount_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674758);
			EventProvider.NativeMethodInfoPtr_bitindex_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100674759);
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x00160E78 File Offset: 0x0015F078
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x00160EB4 File Offset: 0x0015F0B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240743, RefRangeEnd = 240744, XrefRangeStart = 240734, XrefRangeEnd = 240743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(Guid providerGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref providerGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_Register_Internal_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x00160EF4 File Offset: 0x0015F0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240756, RefRangeEnd = 240757, XrefRangeStart = 240744, XrefRangeEnd = 240756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventInfoClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_SetInformation_Internal_Int32_EVENT_INFO_CLASS_ptr_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x00160F58 File Offset: 0x0015F158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240757, XrefRangeEnd = 240761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00160F8C File Offset: 0x0015F18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240761, XrefRangeEnd = 240772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x00160FD8 File Offset: 0x0015F1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00161014 File Offset: 0x0015F214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240772, XrefRangeEnd = 240775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_Deregister_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00161048 File Offset: 0x0015F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240775, XrefRangeEnd = 240789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EtwEnableCallBack([In] ref Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &sourceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anyKeyword;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allKeyword;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EtwEnableCallBack_Private_Static_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x001610D0 File Offset: 0x0015F2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240835, RefRangeEnd = 240836, XrefRangeStart = 240789, XrefRangeEnd = 240835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EtwEnableCallBackImpl([In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anyKeyword;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allKeyword;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EtwEnableCallBackImpl_Private_Void_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00161148 File Offset: 0x0015F348
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventProvider.NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_New_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06004C6B RID: 19563 RVA: 0x001611C0 File Offset: 0x0015F3C0
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_get_Level_Protected_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x001611FC File Offset: 0x0015F3FC
		public unsafe EventKeywords MatchAnyKeyword
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_get_MatchAnyKeyword_Protected_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00161238 File Offset: 0x0015F438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240836, XrefRangeEnd = 240837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNull(Il2CppStructArray<byte> buffer, int idx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_FindNull_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00161288 File Offset: 0x0015F488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240882, RefRangeEnd = 240883, XrefRangeStart = 240837, XrefRangeEnd = 240882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tuple<EventProvider.SessionInfo, bool>> GetSessions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetSessions_Private_List_1_Tuple_2_SessionInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tuple<EventProvider.SessionInfo, bool>>>(intPtr3) : null;
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x001612C8 File Offset: 0x0015F4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240903, RefRangeEnd = 240904, XrefRangeStart = 240883, XrefRangeEnd = 240903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EventProvider.SessionInfo> sessionList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sessionList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetSessionInfoCallback_Private_Static_Void_Int32_Int64_byref_List_1_SessionInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sessionList = ((intPtr4 == 0) ? null : new List<EventProvider.SessionInfo>(intPtr4));
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00161330 File Offset: 0x0015F530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240916, RefRangeEnd = 240917, XrefRangeStart = 240904, XrefRangeEnd = 240916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSessionInfo(Action<int, long> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetSessionInfo_Private_Void_Action_2_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00161374 File Offset: 0x0015F574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240920, RefRangeEnd = 240922, XrefRangeStart = 240917, XrefRangeEnd = 240920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfSessionInList(List<EventProvider.SessionInfo> sessions, int etwSessionId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sessions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_IndexOfSessionInList_Private_Static_Int32_List_1_SessionInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x001613C4 File Offset: 0x0015F5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240922, XrefRangeEnd = 240931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out Il2CppStructArray<byte> data, out int dataStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &command;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataStart;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetDataFromController_Private_Boolean_Int32_ptr_EVENT_FILTER_DESCRIPTOR_byref_ControllerCommand_byref_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x0016145C File Offset: 0x0015F65C
		[CallerCount(0)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00161498 File Offset: 0x0015F698
		[CallerCount(0)]
		public unsafe bool IsEnabled(byte level, long keywords)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_IsEnabled_Public_Boolean_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x001614F0 File Offset: 0x0015F6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240931, XrefRangeEnd = 240936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventProvider.WriteEventErrorCode GetLastWriteEventError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_GetLastWriteEventError_Public_Static_WriteEventErrorCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00161520 File Offset: 0x0015F720
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 240941, RefRangeEnd = 240945, XrefRangeStart = 240936, XrefRangeEnd = 240941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLastError(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_SetLastError_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00161554 File Offset: 0x0015F754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241075, RefRangeEnd = 241076, XrefRangeStart = 240945, XrefRangeEnd = 241075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object EncodeObject(ref Object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(dataDescriptor);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(dataBuffer);
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &totalEventSize;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EncodeObject_Private_Static_Object_byref_Object_byref_ptr_EventData_byref_ptr_Byte_byref_UInt32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			data = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr2;
			dataDescriptor = ((intPtr7 == 0) ? null : new EventProvider.EventData*(intPtr7));
			IntPtr intPtr8 = intPtr3;
			dataBuffer = ((intPtr8 == 0) ? null : new byte*(intPtr8));
			IntPtr intPtr9 = intPtr4;
			return (intPtr9 != 0) ? Il2CppObjectPool.Get<Object>(intPtr9) : null;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00161610 File Offset: 0x0015F810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241165, RefRangeEnd = 241167, XrefRangeStart = 241076, XrefRangeEnd = 241165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, [Optional] Il2CppReferenceArray<Object> eventPayload)
		{
			if (eventPayload == null)
			{
				eventPayload = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &eventDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_WriteEvent_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00161694 File Offset: 0x0015F894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 241179, RefRangeEnd = 241183, XrefRangeStart = 241167, XrefRangeEnd = 241179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &eventDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = childActivityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_WriteEvent_FamOrAssem_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00161714 File Offset: 0x0015F914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241183, XrefRangeEnd = 241195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &eventDescriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_WriteEventRaw_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00161794 File Offset: 0x0015F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241195, XrefRangeEnd = 241197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint EventUnregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_EventUnregister_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x001617D0 File Offset: 0x0015F9D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241201, RefRangeEnd = 241204, XrefRangeStart = 241197, XrefRangeEnd = 241201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int bitcount(uint n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_bitcount_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x00161810 File Offset: 0x0015FA10
		[CallerCount(0)]
		public unsafe static int bitindex(uint n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.NativeMethodInfoPtr_bitindex_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x0001C587 File Offset: 0x0001A787
		public unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, params Object[] eventPayload)
		{
			return this.WriteEvent(ref eventDescriptor, activityID, childActivityID, new Il2CppReferenceArray<Object>(eventPayload));
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x0001C599 File Offset: 0x0001A799
		public EventProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06004C80 RID: 19584 RVA: 0x00161850 File Offset: 0x0015FA50
		// (set) Token: 0x06004C81 RID: 19585 RVA: 0x0001C5A2 File Offset: 0x0001A7A2
		public unsafe static bool m_setInformationMissing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EventProvider.NativeFieldInfoPtr_m_setInformationMissing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventProvider.NativeFieldInfoPtr_m_setInformationMissing, (void*)(&value));
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06004C82 RID: 19586 RVA: 0x0016186C File Offset: 0x0015FA6C
		// (set) Token: 0x06004C83 RID: 19587 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		public unsafe UnsafeNativeMethods.ManifestEtw.EtwEnableCallback m_etwCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_etwCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_etwCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06004C84 RID: 19588 RVA: 0x0016189C File Offset: 0x0015FA9C
		// (set) Token: 0x06004C85 RID: 19589 RVA: 0x0001C5CF File Offset: 0x0001A7CF
		public unsafe GCHandle m_thisGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_thisGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_thisGCHandle)) = value;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06004C86 RID: 19590 RVA: 0x001618C4 File Offset: 0x0015FAC4
		// (set) Token: 0x06004C87 RID: 19591 RVA: 0x0001C5EA File Offset: 0x0001A7EA
		public unsafe long m_regHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_regHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_regHandle)) = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x001618EC File Offset: 0x0015FAEC
		// (set) Token: 0x06004C89 RID: 19593 RVA: 0x0001C605 File Offset: 0x0001A805
		public unsafe byte m_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_level)) = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06004C8A RID: 19594 RVA: 0x00161914 File Offset: 0x0015FB14
		// (set) Token: 0x06004C8B RID: 19595 RVA: 0x0001C620 File Offset: 0x0001A820
		public unsafe long m_anyKeywordMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_anyKeywordMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_anyKeywordMask)) = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06004C8C RID: 19596 RVA: 0x0016193C File Offset: 0x0015FB3C
		// (set) Token: 0x06004C8D RID: 19597 RVA: 0x0001C63B File Offset: 0x0001A83B
		public unsafe long m_allKeywordMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_allKeywordMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_allKeywordMask)) = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06004C8E RID: 19598 RVA: 0x00161964 File Offset: 0x0015FB64
		// (set) Token: 0x06004C8F RID: 19599 RVA: 0x0001C656 File Offset: 0x0001A856
		public unsafe List<EventProvider.SessionInfo> m_liveSessions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_liveSessions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventProvider.SessionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_liveSessions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x00161994 File Offset: 0x0015FB94
		// (set) Token: 0x06004C91 RID: 19601 RVA: 0x0001C675 File Offset: 0x0001A875
		public unsafe bool m_enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_enabled)) = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06004C92 RID: 19602 RVA: 0x001619BC File Offset: 0x0015FBBC
		// (set) Token: 0x06004C93 RID: 19603 RVA: 0x0001C690 File Offset: 0x0001A890
		public unsafe Guid m_providerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_providerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_providerId)) = value;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x001619E4 File Offset: 0x0015FBE4
		// (set) Token: 0x06004C95 RID: 19605 RVA: 0x0001C6AB File Offset: 0x0001A8AB
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x00161A0C File Offset: 0x0015FC0C
		// (set) Token: 0x06004C97 RID: 19607 RVA: 0x0001C6C6 File Offset: 0x0001A8C6
		public unsafe static EventProvider.WriteEventErrorCode s_returnCode
		{
			get
			{
				EventProvider.WriteEventErrorCode writeEventErrorCode;
				IL2CPP.il2cpp_field_static_get_value(EventProvider.NativeFieldInfoPtr_s_returnCode, (void*)(&writeEventErrorCode));
				return writeEventErrorCode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventProvider.NativeFieldInfoPtr_s_returnCode, (void*)(&value));
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x00161A28 File Offset: 0x0015FC28
		// (set) Token: 0x06004C99 RID: 19609 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		public unsafe static Il2CppStructArray<int> nibblebits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventProvider.NativeFieldInfoPtr_nibblebits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventProvider.NativeFieldInfoPtr_nibblebits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeFieldInfoPtr_m_setInformationMissing;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeFieldInfoPtr_m_etwCallback;

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeFieldInfoPtr_m_thisGCHandle;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeFieldInfoPtr_m_regHandle;

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeFieldInfoPtr_m_level;

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeFieldInfoPtr_m_anyKeywordMask;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeFieldInfoPtr_m_allKeywordMask;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeFieldInfoPtr_m_liveSessions;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeFieldInfoPtr_m_enabled;

		// Token: 0x04003DC8 RID: 15816
		private static readonly IntPtr NativeFieldInfoPtr_m_providerId;

		// Token: 0x04003DC9 RID: 15817
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04003DCA RID: 15818
		private static readonly IntPtr NativeFieldInfoPtr_s_returnCode;

		// Token: 0x04003DCB RID: 15819
		private static readonly IntPtr NativeFieldInfoPtr_nibblebits;

		// Token: 0x04003DCC RID: 15820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04003DCD RID: 15821
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Void_Guid_0;

		// Token: 0x04003DCE RID: 15822
		private static readonly IntPtr NativeMethodInfoPtr_SetInformation_Internal_Int32_EVENT_INFO_CLASS_ptr_Void_Int32_0;

		// Token: 0x04003DCF RID: 15823
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003DD0 RID: 15824
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04003DD1 RID: 15825
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003DD2 RID: 15826
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Private_Void_0;

		// Token: 0x04003DD3 RID: 15827
		private static readonly IntPtr NativeMethodInfoPtr_EtwEnableCallBack_Private_Static_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0;

		// Token: 0x04003DD4 RID: 15828
		private static readonly IntPtr NativeMethodInfoPtr_EtwEnableCallBackImpl_Private_Void_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_0;

		// Token: 0x04003DD5 RID: 15829
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerCommand_Protected_Virtual_New_Void_ControllerCommand_IDictionary_2_String_String_Int32_Int32_0;

		// Token: 0x04003DD6 RID: 15830
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Protected_get_EventLevel_0;

		// Token: 0x04003DD7 RID: 15831
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchAnyKeyword_Protected_get_EventKeywords_0;

		// Token: 0x04003DD8 RID: 15832
		private static readonly IntPtr NativeMethodInfoPtr_FindNull_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04003DD9 RID: 15833
		private static readonly IntPtr NativeMethodInfoPtr_GetSessions_Private_List_1_Tuple_2_SessionInfo_Boolean_0;

		// Token: 0x04003DDA RID: 15834
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionInfoCallback_Private_Static_Void_Int32_Int64_byref_List_1_SessionInfo_0;

		// Token: 0x04003DDB RID: 15835
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionInfo_Private_Void_Action_2_Int32_Int64_0;

		// Token: 0x04003DDC RID: 15836
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfSessionInList_Private_Static_Int32_List_1_SessionInfo_Int32_0;

		// Token: 0x04003DDD RID: 15837
		private static readonly IntPtr NativeMethodInfoPtr_GetDataFromController_Private_Boolean_Int32_ptr_EVENT_FILTER_DESCRIPTOR_byref_ControllerCommand_byref_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04003DDE RID: 15838
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x04003DDF RID: 15839
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_Byte_Int64_0;

		// Token: 0x04003DE0 RID: 15840
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWriteEventError_Public_Static_WriteEventErrorCode_0;

		// Token: 0x04003DE1 RID: 15841
		private static readonly IntPtr NativeMethodInfoPtr_SetLastError_Private_Static_Void_Int32_0;

		// Token: 0x04003DE2 RID: 15842
		private static readonly IntPtr NativeMethodInfoPtr_EncodeObject_Private_Static_Object_byref_Object_byref_ptr_EventData_byref_ptr_Byte_byref_UInt32_0;

		// Token: 0x04003DE3 RID: 15843
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003DE4 RID: 15844
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_FamOrAssem_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0;

		// Token: 0x04003DE5 RID: 15845
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventRaw_Internal_Boolean_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_IntPtr_0;

		// Token: 0x04003DE6 RID: 15846
		private static readonly IntPtr NativeMethodInfoPtr_EventUnregister_Private_UInt32_0;

		// Token: 0x04003DE7 RID: 15847
		private static readonly IntPtr NativeMethodInfoPtr_bitcount_Private_Static_Int32_UInt32_0;

		// Token: 0x04003DE8 RID: 15848
		private static readonly IntPtr NativeMethodInfoPtr_bitindex_Private_Static_Int32_UInt32_0;

		// Token: 0x02000683 RID: 1667
		[StructLayout(2)]
		public struct EventData
		{
			// Token: 0x060058EE RID: 22766 RVA: 0x0018B42C File Offset: 0x0018962C
			// Note: this type is marked as 'beforefieldinit'.
			static EventData()
			{
				Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "EventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr);
				EventProvider.EventData.NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, "Ptr");
				EventProvider.EventData.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, "Size");
				EventProvider.EventData.NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, "Reserved");
			}

			// Token: 0x060058EF RID: 22767 RVA: 0x00021FB6 File Offset: 0x000201B6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventProvider.EventData>.NativeClassPtr, ref this));
			}

			// Token: 0x04004735 RID: 18229
			private static readonly IntPtr NativeFieldInfoPtr_Ptr;

			// Token: 0x04004736 RID: 18230
			private static readonly IntPtr NativeFieldInfoPtr_Size;

			// Token: 0x04004737 RID: 18231
			private static readonly IntPtr NativeFieldInfoPtr_Reserved;

			// Token: 0x04004738 RID: 18232
			[FieldOffset(0)]
			public ulong Ptr;

			// Token: 0x04004739 RID: 18233
			[FieldOffset(8)]
			public uint Size;

			// Token: 0x0400473A RID: 18234
			[FieldOffset(12)]
			public uint Reserved;
		}

		// Token: 0x02000684 RID: 1668
		[StructLayout(2)]
		public struct SessionInfo
		{
			// Token: 0x060058F0 RID: 22768 RVA: 0x0018B494 File Offset: 0x00189694
			// Note: this type is marked as 'beforefieldinit'.
			static SessionInfo()
			{
				Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "SessionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr);
				EventProvider.SessionInfo.NativeFieldInfoPtr_sessionIdBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, "sessionIdBit");
				EventProvider.SessionInfo.NativeFieldInfoPtr_etwSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, "etwSessionId");
				EventProvider.SessionInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, 100674761);
			}

			// Token: 0x060058F1 RID: 22769 RVA: 0x0018B4FC File Offset: 0x001896FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SessionInfo(int sessionIdBit_, int etwSessionId_)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sessionIdBit_;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId_;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.SessionInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058F2 RID: 22770 RVA: 0x00021FC8 File Offset: 0x000201C8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventProvider.SessionInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x0400473B RID: 18235
			private static readonly IntPtr NativeFieldInfoPtr_sessionIdBit;

			// Token: 0x0400473C RID: 18236
			private static readonly IntPtr NativeFieldInfoPtr_etwSessionId;

			// Token: 0x0400473D RID: 18237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;

			// Token: 0x0400473E RID: 18238
			[FieldOffset(0)]
			public int sessionIdBit;

			// Token: 0x0400473F RID: 18239
			[FieldOffset(4)]
			public int etwSessionId;
		}

		// Token: 0x02000685 RID: 1669
		[OriginalName("mscorlib.dll", "", "WriteEventErrorCode")]
		public enum WriteEventErrorCode
		{
			// Token: 0x04004741 RID: 18241
			NoError,
			// Token: 0x04004742 RID: 18242
			NoFreeBuffers,
			// Token: 0x04004743 RID: 18243
			EventTooBig,
			// Token: 0x04004744 RID: 18244
			NullInput,
			// Token: 0x04004745 RID: 18245
			TooManyArgs,
			// Token: 0x04004746 RID: 18246
			Other
		}

		// Token: 0x02000686 RID: 1670
		public sealed class MonoPInvokeCallbackAttribute : Attribute
		{
			// Token: 0x060058F3 RID: 22771 RVA: 0x00021FDA File Offset: 0x000201DA
			// Note: this type is marked as 'beforefieldinit'.
			static MonoPInvokeCallbackAttribute()
			{
				Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "MonoPInvokeCallbackAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr);
				EventProvider.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr, 100674762);
			}

			// Token: 0x060058F4 RID: 22772 RVA: 0x0018B53C File Offset: 0x0018973C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MonoPInvokeCallbackAttribute(Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventProvider.MonoPInvokeCallbackAttribute>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058F5 RID: 22773 RVA: 0x0002200E File Offset: 0x0002020E
			public MonoPInvokeCallbackAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004747 RID: 18247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}

		// Token: 0x02000687 RID: 1671
		[ObfuscatedName("System.Diagnostics.Tracing.EventProvider+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Object
		{
			// Token: 0x060058F6 RID: 22774 RVA: 0x0018B588 File Offset: 0x00189788
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr);
				EventProvider.__c__DisplayClass44_0.NativeFieldInfoPtr_liveSessionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr, "liveSessionList");
				EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr, 100674763);
				EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__GetSessions_b__0_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr, 100674764);
			}

			// Token: 0x060058F7 RID: 22775 RVA: 0x0018B5F0 File Offset: 0x001897F0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventProvider.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058F8 RID: 22776 RVA: 0x0018B62C File Offset: 0x0018982C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240730, XrefRangeEnd = 240734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetSessions_b__0(int etwSessionId, long matchAllKeywords)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref etwSessionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventProvider.__c__DisplayClass44_0.NativeMethodInfoPtr__GetSessions_b__0_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058F9 RID: 22777 RVA: 0x00022017 File Offset: 0x00020217
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001709 RID: 5897
			// (get) Token: 0x060058FA RID: 22778 RVA: 0x0018B678 File Offset: 0x00189878
			// (set) Token: 0x060058FB RID: 22779 RVA: 0x00022020 File Offset: 0x00020220
			public unsafe List<EventProvider.SessionInfo> liveSessionList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.__c__DisplayClass44_0.NativeFieldInfoPtr_liveSessionList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventProvider.SessionInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventProvider.__c__DisplayClass44_0.NativeFieldInfoPtr_liveSessionList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004748 RID: 18248
			private static readonly IntPtr NativeFieldInfoPtr_liveSessionList;

			// Token: 0x04004749 RID: 18249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400474A RID: 18250
			private static readonly IntPtr NativeMethodInfoPtr__GetSessions_b__0_Internal_Void_Int32_Int64_0;
		}
	}
}
