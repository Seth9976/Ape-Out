using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Il2CppCodeStage.AntiCheat.Detectors
{
	// Token: 0x0200020F RID: 527
	public class TimeCheatingDetector : ActDetectorBase
	{
		// Token: 0x06001D3D RID: 7485 RVA: 0x00083FC4 File Offset: 0x000821C4
		// Note: this type is marked as 'beforefieldinit'.
		static TimeCheatingDetector()
		{
			Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Detectors", "TimeCheatingDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr);
			TimeCheatingDetector.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "ComponentName");
			TimeCheatingDetector.NativeFieldInfoPtr_LogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "LogPrefix");
			TimeCheatingDetector.NativeFieldInfoPtr_instancesInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "instancesInScene");
			TimeCheatingDetector.NativeFieldInfoPtr_NtpDataBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "NtpDataBufferLength");
			TimeCheatingDetector.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "Error");
			TimeCheatingDetector.NativeFieldInfoPtr_CheckPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "CheckPassed");
			TimeCheatingDetector.NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "interval");
			TimeCheatingDetector.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "threshold");
			TimeCheatingDetector.NativeFieldInfoPtr_timeServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "timeServer");
			TimeCheatingDetector.NativeFieldInfoPtr__IsCheckingForCheat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<IsCheckingForCheat>k__BackingField");
			TimeCheatingDetector.NativeFieldInfoPtr__LastError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<LastError>k__BackingField");
			TimeCheatingDetector.NativeFieldInfoPtr__LastResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<LastResult>k__BackingField");
			TimeCheatingDetector.NativeFieldInfoPtr_date1900 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "date1900");
			TimeCheatingDetector.NativeFieldInfoPtr_cachedEndOfFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "cachedEndOfFrame");
			TimeCheatingDetector.NativeFieldInfoPtr_asyncSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "asyncSocket");
			TimeCheatingDetector.NativeFieldInfoPtr_ntpData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "ntpData");
			TimeCheatingDetector.NativeFieldInfoPtr_targetIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "targetIP");
			TimeCheatingDetector.NativeFieldInfoPtr_targetEndpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "targetEndpoint");
			TimeCheatingDetector.NativeFieldInfoPtr_connectArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "connectArgs");
			TimeCheatingDetector.NativeFieldInfoPtr_sendArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "sendArgs");
			TimeCheatingDetector.NativeFieldInfoPtr_receiveArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "receiveArgs");
			TimeCheatingDetector.NativeFieldInfoPtr_timeElapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "timeElapsed");
			TimeCheatingDetector.NativeFieldInfoPtr_lastOnlineTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "lastOnlineTime");
			TimeCheatingDetector.NativeFieldInfoPtr_gettingOnlineTimeAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "gettingOnlineTimeAsync");
			TimeCheatingDetector.NativeFieldInfoPtr_asyncError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "asyncError");
			TimeCheatingDetector.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<Instance>k__BackingField");
			TimeCheatingDetector.NativeMethodInfoPtr_add_Error_Public_add_Void_Action_1_ErrorKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668049);
			TimeCheatingDetector.NativeMethodInfoPtr_remove_Error_Public_rem_Void_Action_1_ErrorKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668050);
			TimeCheatingDetector.NativeMethodInfoPtr_add_CheckPassed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668051);
			TimeCheatingDetector.NativeMethodInfoPtr_remove_CheckPassed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668052);
			TimeCheatingDetector.NativeMethodInfoPtr_get_IsCheckingForCheat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668053);
			TimeCheatingDetector.NativeMethodInfoPtr_set_IsCheckingForCheat_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668054);
			TimeCheatingDetector.NativeMethodInfoPtr_get_LastError_Public_get_ErrorKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668055);
			TimeCheatingDetector.NativeMethodInfoPtr_set_LastError_Private_set_Void_ErrorKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668056);
			TimeCheatingDetector.NativeMethodInfoPtr_get_LastResult_Public_get_TimeCheatingDetectorResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668057);
			TimeCheatingDetector.NativeMethodInfoPtr_set_LastResult_Private_set_Void_TimeCheatingDetectorResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668058);
			TimeCheatingDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_TimeCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668059);
			TimeCheatingDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_TimeCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668060);
			TimeCheatingDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_TimeCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668061);
			TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668062);
			TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Action_1_ErrorKind_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668063);
			TimeCheatingDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_TimeCheatingDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668064);
			TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Action_1_ErrorKind_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668065);
			TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Single_Action_Action_1_ErrorKind_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668066);
			TimeCheatingDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668067);
			TimeCheatingDetector.NativeMethodInfoPtr_SetErrorCallback_Public_Static_Void_Action_1_ErrorKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668068);
			TimeCheatingDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668069);
			TimeCheatingDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668070);
			TimeCheatingDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668071);
			TimeCheatingDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668072);
			TimeCheatingDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668073);
			TimeCheatingDetector.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668074);
			TimeCheatingDetector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668075);
			TimeCheatingDetector.NativeMethodInfoPtr_ForceCheck_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668076);
			TimeCheatingDetector.NativeMethodInfoPtr_ForceCheckEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668077);
			TimeCheatingDetector.NativeMethodInfoPtr_ForceCheckTask_Public_Task_1_TimeCheatingDetectorResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668078);
			TimeCheatingDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Single_Action_Action_Action_1_ErrorKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668079);
			TimeCheatingDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668080);
			TimeCheatingDetector.NativeMethodInfoPtr_DetectorHasCallbacks_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668081);
			TimeCheatingDetector.NativeMethodInfoPtr_PauseDetector_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668082);
			TimeCheatingDetector.NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668083);
			TimeCheatingDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668084);
			TimeCheatingDetector.NativeMethodInfoPtr_CheckForCheat_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668085);
			TimeCheatingDetector.NativeMethodInfoPtr_GetOnlineTimeInternal_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668086);
			TimeCheatingDetector.NativeMethodInfoPtr_OnSocketConnectedOrSent_Private_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668087);
			TimeCheatingDetector.NativeMethodInfoPtr_OnSocketReceive_Private_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668088);
			TimeCheatingDetector.NativeMethodInfoPtr_CloseSocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668089);
			TimeCheatingDetector.NativeMethodInfoPtr_HandleSocketException_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668090);
			TimeCheatingDetector.NativeMethodInfoPtr_GetLocalTime_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668091);
			TimeCheatingDetector.NativeMethodInfoPtr_GetOnlineTime_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668092);
			TimeCheatingDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, 100668093);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00084580 File Offset: 0x00082780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28685, XrefRangeEnd = 28688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Error(Action<TimeCheatingDetector.ErrorKind> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_add_Error_Public_add_Void_Action_1_ErrorKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x000845C4 File Offset: 0x000827C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28688, XrefRangeEnd = 28691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Error(Action<TimeCheatingDetector.ErrorKind> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_remove_Error_Public_rem_Void_Action_1_ErrorKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00084608 File Offset: 0x00082808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28691, XrefRangeEnd = 28694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CheckPassed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_add_CheckPassed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0008464C File Offset: 0x0008284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28694, XrefRangeEnd = 28697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CheckPassed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_remove_CheckPassed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00084690 File Offset: 0x00082890
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x000846CC File Offset: 0x000828CC
		public unsafe bool IsCheckingForCheat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_get_IsCheckingForCheat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_set_IsCheckingForCheat_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0008470C File Offset: 0x0008290C
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00084748 File Offset: 0x00082948
		public unsafe TimeCheatingDetector.ErrorKind LastError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_get_LastError_Public_get_ErrorKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_set_LastError_Private_set_Void_ErrorKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00084788 File Offset: 0x00082988
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x000847C4 File Offset: 0x000829C4
		public unsafe TimeCheatingDetector.TimeCheatingDetectorResult LastResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_get_LastResult_Public_get_TimeCheatingDetectorResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_set_LastResult_Private_set_Void_TimeCheatingDetectorResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00084804 File Offset: 0x00082A04
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00084838 File Offset: 0x00082A38
		public unsafe static TimeCheatingDetector Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28697, XrefRangeEnd = 28699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_get_Instance_Public_Static_get_TimeCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28699, XrefRangeEnd = 28701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_TimeCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00084870 File Offset: 0x00082A70
		public unsafe static TimeCheatingDetector GetOrCreateInstance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 28744, RefRangeEnd = 28750, XrefRangeStart = 28701, XrefRangeEnd = 28744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_TimeCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr3) : null;
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000848A4 File Offset: 0x00082AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28750, XrefRangeEnd = 28752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action detectionCallback, int interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detectionCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000848E8 File Offset: 0x00082AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28752, XrefRangeEnd = 28754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action detectionCallback, Action<TimeCheatingDetector.ErrorKind> errorCallback, int interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detectionCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Action_1_ErrorKind_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00084940 File Offset: 0x00082B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28754, XrefRangeEnd = 28755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeCheatingDetector AddToSceneOrGetExisting()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_TimeCheatingDetector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr3) : null;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00084974 File Offset: 0x00082B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28755, XrefRangeEnd = 28785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(Action detectionCallback = null, Action<TimeCheatingDetector.ErrorKind> errorCallback = null, Action checkPassedCallback = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detectionCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkPassedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Action_1_ErrorKind_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000849D0 File Offset: 0x00082BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28785, XrefRangeEnd = 28787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartDetection(float intervalMinutes, Action detectionCallback = null, Action<TimeCheatingDetector.ErrorKind> errorCallback = null, Action checkPassedCallback = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intervalMinutes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detectionCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkPassedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_StartDetection_Public_Static_Void_Single_Action_Action_1_ErrorKind_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00084A38 File Offset: 0x00082C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28787, XrefRangeEnd = 28803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopDetection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_StopDetection_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00084A60 File Offset: 0x00082C60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetErrorCallback(Action<TimeCheatingDetector.ErrorKind> errorCallback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_SetErrorCallback_Public_Static_Void_Action_1_ErrorKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00084A98 File Offset: 0x00082C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28803, XrefRangeEnd = 28819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00084AC0 File Offset: 0x00082CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28819, XrefRangeEnd = 28836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00084AF4 File Offset: 0x00082CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28836, XrefRangeEnd = 28839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeCheatingDetector.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00084B30 File Offset: 0x00082D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28839, XrefRangeEnd = 28856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00084B7C File Offset: 0x00082D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLevelLoadedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00084BB0 File Offset: 0x00082DB0
		[CallerCount(0)]
		public unsafe void OnApplicationPause(bool pauseStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pauseStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00084BF0 File Offset: 0x00082DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28856, XrefRangeEnd = 28859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00084C24 File Offset: 0x00082E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28859, XrefRangeEnd = 28865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ForceCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_ForceCheck_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00084C60 File Offset: 0x00082E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28865, XrefRangeEnd = 28868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ForceCheckEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_ForceCheckEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00084CA0 File Offset: 0x00082EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28868, XrefRangeEnd = 28878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TimeCheatingDetector.TimeCheatingDetectorResult> ForceCheckTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_ForceCheckTask_Public_Task_1_TimeCheatingDetectorResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TimeCheatingDetector.TimeCheatingDetectorResult>>(intPtr3) : null;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00084CE0 File Offset: 0x00082EE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 28897, RefRangeEnd = 28903, XrefRangeStart = 28878, XrefRangeEnd = 28897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDetectionInternal(float checkInterval, Action detectionCallback, Action checkPassedCallback, Action<TimeCheatingDetector.ErrorKind> errorCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkInterval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detectionCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkPassedCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Single_Action_Action_Action_1_ErrorKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00084D58 File Offset: 0x00082F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28903, XrefRangeEnd = 28904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDetectionAutomatically()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeCheatingDetector.NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00084D94 File Offset: 0x00082F94
		[CallerCount(0)]
		public unsafe override bool DetectorHasCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeCheatingDetector.NativeMethodInfoPtr_DetectorHasCallbacks_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00084DDC File Offset: 0x00082FDC
		[CallerCount(0)]
		public unsafe override void PauseDetector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeCheatingDetector.NativeMethodInfoPtr_PauseDetector_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00084E18 File Offset: 0x00083018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28904, XrefRangeEnd = 28905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopDetectionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeCheatingDetector.NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00084E54 File Offset: 0x00083054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28905, XrefRangeEnd = 28934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeCheatingDetector.NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00084E90 File Offset: 0x00083090
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 28937, RefRangeEnd = 28940, XrefRangeStart = 28934, XrefRangeEnd = 28937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckForCheat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_CheckForCheat_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00084ED0 File Offset: 0x000830D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28940, XrefRangeEnd = 28943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetOnlineTimeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_GetOnlineTimeInternal_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00084F10 File Offset: 0x00083110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28968, RefRangeEnd = 28969, XrefRangeStart = 28943, XrefRangeEnd = 28968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSocketConnectedOrSent(global::Il2CppSystem.Object sender, SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_OnSocketConnectedOrSent_Private_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00084F64 File Offset: 0x00083164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28969, XrefRangeEnd = 28995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSocketReceive(global::Il2CppSystem.Object sender, SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_OnSocketReceive_Private_Void_Object_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00084FB8 File Offset: 0x000831B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29001, RefRangeEnd = 29003, XrefRangeStart = 28995, XrefRangeEnd = 29001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_CloseSocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00084FEC File Offset: 0x000831EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29016, RefRangeEnd = 29017, XrefRangeStart = 29003, XrefRangeEnd = 29016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSocketException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_HandleSocketException_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00085030 File Offset: 0x00083230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29017, XrefRangeEnd = 29021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLocalTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_GetLocalTime_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0008506C File Offset: 0x0008326C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29021, XrefRangeEnd = 29052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetOnlineTime(string server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(server);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr_GetOnlineTime_Public_Static_Double_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000850B0 File Offset: 0x000832B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29052, XrefRangeEnd = 29064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeCheatingDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0000A7A1 File Offset: 0x000089A1
		public TimeCheatingDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000850EC File Offset: 0x000832EC
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000A7AA File Offset: 0x000089AA
		public unsafe static string ComponentName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeCheatingDetector.NativeFieldInfoPtr_ComponentName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeCheatingDetector.NativeFieldInfoPtr_ComponentName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0008510C File Offset: 0x0008330C
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0000A7BC File Offset: 0x000089BC
		public unsafe static string LogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeCheatingDetector.NativeFieldInfoPtr_LogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeCheatingDetector.NativeFieldInfoPtr_LogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0008512C File Offset: 0x0008332C
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0000A7CE File Offset: 0x000089CE
		public unsafe static int instancesInScene
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeCheatingDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeCheatingDetector.NativeFieldInfoPtr_instancesInScene, (void*)(&value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00085148 File Offset: 0x00083348
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0000A7DC File Offset: 0x000089DC
		public unsafe static int NtpDataBufferLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeCheatingDetector.NativeFieldInfoPtr_NtpDataBufferLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeCheatingDetector.NativeFieldInfoPtr_NtpDataBufferLength, (void*)(&value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00085164 File Offset: 0x00083364
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0000A7EA File Offset: 0x000089EA
		public unsafe Action<TimeCheatingDetector.ErrorKind> Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TimeCheatingDetector.ErrorKind>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00085194 File Offset: 0x00083394
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000A809 File Offset: 0x00008A09
		public unsafe Action CheckPassed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_CheckPassed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_CheckPassed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000851C4 File Offset: 0x000833C4
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000A828 File Offset: 0x00008A28
		public unsafe float interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_interval)) = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000851EC File Offset: 0x000833EC
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000A843 File Offset: 0x00008A43
		public unsafe int threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_threshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_threshold)) = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00085214 File Offset: 0x00083414
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000A85E File Offset: 0x00008A5E
		public unsafe string timeServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_timeServer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_timeServer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0008523C File Offset: 0x0008343C
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000A87D File Offset: 0x00008A7D
		public unsafe bool _IsCheckingForCheat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr__IsCheckingForCheat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr__IsCheckingForCheat_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00085264 File Offset: 0x00083464
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000A898 File Offset: 0x00008A98
		public unsafe TimeCheatingDetector.ErrorKind _LastError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr__LastError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr__LastError_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0008528C File Offset: 0x0008348C
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000A8B3 File Offset: 0x00008AB3
		public unsafe TimeCheatingDetector.TimeCheatingDetectorResult _LastResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr__LastResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr__LastResult_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000852B4 File Offset: 0x000834B4
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0000A8CE File Offset: 0x00008ACE
		public unsafe DateTime date1900
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_date1900);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_date1900)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000852DC File Offset: 0x000834DC
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0000A8E9 File Offset: 0x00008AE9
		public unsafe WaitForEndOfFrame cachedEndOfFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_cachedEndOfFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForEndOfFrame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_cachedEndOfFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0008530C File Offset: 0x0008350C
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0000A908 File Offset: 0x00008B08
		public unsafe Socket asyncSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_asyncSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_asyncSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0008533C File Offset: 0x0008353C
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000A927 File Offset: 0x00008B27
		public unsafe Il2CppStructArray<byte> ntpData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_ntpData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_ntpData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0008536C File Offset: 0x0008356C
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000A946 File Offset: 0x00008B46
		public unsafe Il2CppStructArray<byte> targetIP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_targetIP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_targetIP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0008539C File Offset: 0x0008359C
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x0000A965 File Offset: 0x00008B65
		public unsafe IPEndPoint targetEndpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_targetEndpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_targetEndpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000853CC File Offset: 0x000835CC
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0000A984 File Offset: 0x00008B84
		public unsafe SocketAsyncEventArgs connectArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_connectArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_connectArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000853FC File Offset: 0x000835FC
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0000A9A3 File Offset: 0x00008BA3
		public unsafe SocketAsyncEventArgs sendArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_sendArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_sendArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0008542C File Offset: 0x0008362C
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000A9C2 File Offset: 0x00008BC2
		public unsafe SocketAsyncEventArgs receiveArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_receiveArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_receiveArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0008545C File Offset: 0x0008365C
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0000A9E1 File Offset: 0x00008BE1
		public unsafe float timeElapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_timeElapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_timeElapsed)) = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00085484 File Offset: 0x00083684
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0000A9FC File Offset: 0x00008BFC
		public unsafe double lastOnlineTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_lastOnlineTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_lastOnlineTime)) = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000854AC File Offset: 0x000836AC
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000AA17 File Offset: 0x00008C17
		public unsafe bool gettingOnlineTimeAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_gettingOnlineTimeAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_gettingOnlineTimeAsync)) = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000854D4 File Offset: 0x000836D4
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0000AA32 File Offset: 0x00008C32
		public unsafe TimeCheatingDetector.ErrorKind asyncError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_asyncError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector.NativeFieldInfoPtr_asyncError)) = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000854FC File Offset: 0x000836FC
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0000AA4D File Offset: 0x00008C4D
		public unsafe static TimeCheatingDetector _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeCheatingDetector.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeCheatingDetector.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeFieldInfoPtr_ComponentName;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeFieldInfoPtr_LogPrefix;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeFieldInfoPtr_instancesInScene;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeFieldInfoPtr_NtpDataBufferLength;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeFieldInfoPtr_CheckPassed;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeFieldInfoPtr_interval;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeFieldInfoPtr_timeServer;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeFieldInfoPtr__IsCheckingForCheat_k__BackingField;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeFieldInfoPtr__LastError_k__BackingField;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeFieldInfoPtr__LastResult_k__BackingField;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeFieldInfoPtr_date1900;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeFieldInfoPtr_cachedEndOfFrame;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeFieldInfoPtr_asyncSocket;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeFieldInfoPtr_ntpData;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeFieldInfoPtr_targetIP;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeFieldInfoPtr_targetEndpoint;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeFieldInfoPtr_connectArgs;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeFieldInfoPtr_sendArgs;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeFieldInfoPtr_receiveArgs;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeFieldInfoPtr_timeElapsed;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeFieldInfoPtr_lastOnlineTime;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeFieldInfoPtr_gettingOnlineTimeAsync;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeFieldInfoPtr_asyncError;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_add_Error_Public_add_Void_Action_1_ErrorKind_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_remove_Error_Public_rem_Void_Action_1_ErrorKind_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_add_CheckPassed_Public_add_Void_Action_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_remove_CheckPassed_Public_rem_Void_Action_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCheckingForCheat_Public_get_Boolean_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCheckingForCheat_Private_set_Void_Boolean_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_get_LastError_Public_get_ErrorKind_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_set_LastError_Private_set_Void_ErrorKind_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_get_LastResult_Public_get_TimeCheatingDetectorResult_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_set_LastResult_Private_set_Void_TimeCheatingDetectorResult_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TimeCheatingDetector_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_TimeCheatingDetector_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_get_GetOrCreateInstance_Private_Static_get_TimeCheatingDetector_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Int32_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Action_1_ErrorKind_Int32_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_AddToSceneOrGetExisting_Public_Static_TimeCheatingDetector_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Action_Action_1_ErrorKind_Action_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_StartDetection_Public_Static_Void_Single_Action_Action_1_ErrorKind_Action_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_StopDetection_Public_Static_Void_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorCallback_Public_Static_Void_Action_1_ErrorKind_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelWasLoadedNew_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelLoadedCallback_Private_Void_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_ForceCheck_Public_Boolean_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_ForceCheckEnumerator_Public_IEnumerator_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_ForceCheckTask_Public_Task_1_TimeCheatingDetectorResult_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionInternal_Private_Void_Single_Action_Action_Action_1_ErrorKind_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_StartDetectionAutomatically_Protected_Virtual_Void_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_DetectorHasCallbacks_Protected_Virtual_Boolean_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_PauseDetector_Protected_Virtual_Void_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_StopDetectionInternal_Protected_Virtual_Void_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Protected_Virtual_Void_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_CheckForCheat_Private_IEnumerator_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_GetOnlineTimeInternal_Private_IEnumerator_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_OnSocketConnectedOrSent_Private_Void_Object_SocketAsyncEventArgs_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_OnSocketReceive_Private_Void_Object_SocketAsyncEventArgs_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_CloseSocket_Private_Void_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_HandleSocketException_Private_Void_Exception_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTime_Private_Double_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_GetOnlineTime_Public_Static_Double_String_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002C2 RID: 706
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "TimeCheatingDetectorResult")]
		public enum TimeCheatingDetectorResult
		{
			// Token: 0x040022CE RID: 8910
			Unknown,
			// Token: 0x040022CF RID: 8911
			CheckPassed = 5,
			// Token: 0x040022D0 RID: 8912
			CheatDetected = 10,
			// Token: 0x040022D1 RID: 8913
			Error = 15
		}

		// Token: 0x020002C3 RID: 707
		[OriginalName("Assembly-CSharp-firstpass.dll", "", "ErrorKind")]
		public enum ErrorKind
		{
			// Token: 0x040022D3 RID: 8915
			NoError,
			// Token: 0x040022D4 RID: 8916
			CantResolveHost = 5,
			// Token: 0x040022D5 RID: 8917
			Unknown = 10
		}

		// Token: 0x020002C4 RID: 708
		[ObfuscatedName("CodeStage.AntiCheat.Detectors.TimeCheatingDetector+<ForceCheckEnumerator>d__61")]
		public sealed class _ForceCheckEnumerator_d__61 : global::Il2CppSystem.Object
		{
			// Token: 0x0600244A RID: 9290 RVA: 0x0009ABD8 File Offset: 0x00098DD8
			// Note: this type is marked as 'beforefieldinit'.
			static _ForceCheckEnumerator_d__61()
			{
				Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<ForceCheckEnumerator>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr);
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, "<>1__state");
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, "<>2__current");
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, "<>4__this");
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, 100668094);
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, 100668095);
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, 100668096);
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, 100668097);
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, 100668098);
				TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr, 100668099);
			}

			// Token: 0x0600244B RID: 9291 RVA: 0x0009ACB8 File Offset: 0x00098EB8
			[CallerCount(0)]
			public unsafe _ForceCheckEnumerator_d__61(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckEnumerator_d__61>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600244C RID: 9292 RVA: 0x0009AD00 File Offset: 0x00098F00
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600244D RID: 9293 RVA: 0x0009AD34 File Offset: 0x00098F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28526, XrefRangeEnd = 28531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x0600244E RID: 9294 RVA: 0x0009AD70 File Offset: 0x00098F70
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600244F RID: 9295 RVA: 0x0009ADB0 File Offset: 0x00098FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28531, XrefRangeEnd = 28536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06002450 RID: 9296 RVA: 0x0009ADE4 File Offset: 0x00098FE4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002451 RID: 9297 RVA: 0x0000DA26 File Offset: 0x0000BC26
			public _ForceCheckEnumerator_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06002452 RID: 9298 RVA: 0x0009AE24 File Offset: 0x00099024
			// (set) Token: 0x06002453 RID: 9299 RVA: 0x0000DA2F File Offset: 0x0000BC2F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06002454 RID: 9300 RVA: 0x0009AE4C File Offset: 0x0009904C
			// (set) Token: 0x06002455 RID: 9301 RVA: 0x0000DA4A File Offset: 0x0000BC4A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06002456 RID: 9302 RVA: 0x0009AE7C File Offset: 0x0009907C
			// (set) Token: 0x06002457 RID: 9303 RVA: 0x0000DA69 File Offset: 0x0000BC69
			public unsafe TimeCheatingDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckEnumerator_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022D6 RID: 8918
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022D7 RID: 8919
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040022D8 RID: 8920
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022D9 RID: 8921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022DA RID: 8922
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022DB RID: 8923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022DC RID: 8924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022DD RID: 8925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022DE RID: 8926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002C5 RID: 709
		[ObfuscatedName("CodeStage.AntiCheat.Detectors.TimeCheatingDetector+<ForceCheckTask>d__62")]
		public sealed class _ForceCheckTask_d__62 : ValueType
		{
			// Token: 0x06002458 RID: 9304 RVA: 0x0009AEAC File Offset: 0x000990AC
			// Note: this type is marked as 'beforefieldinit'.
			static _ForceCheckTask_d__62()
			{
				Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<ForceCheckTask>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr);
				TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr, "<>1__state");
				TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr, "<>t__builder");
				TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr, "<>4__this");
				TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr, "<>u__1");
				TimeCheatingDetector._ForceCheckTask_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr, 100668100);
				TimeCheatingDetector._ForceCheckTask_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr, 100668101);
			}

			// Token: 0x06002459 RID: 9305 RVA: 0x0009AF50 File Offset: 0x00099150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28536, XrefRangeEnd = 28595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckTask_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600245A RID: 9306 RVA: 0x0009AF88 File Offset: 0x00099188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28595, XrefRangeEnd = 28610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._ForceCheckTask_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600245B RID: 9307 RVA: 0x0000DA88 File Offset: 0x0000BC88
			public _ForceCheckTask_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600245C RID: 9308 RVA: 0x0000DA91 File Offset: 0x0000BC91
			public _ForceCheckTask_d__62()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeCheatingDetector._ForceCheckTask_d__62>.NativeClassPtr))
			{
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x0600245D RID: 9309 RVA: 0x0009AFD0 File Offset: 0x000991D0
			// (set) Token: 0x0600245E RID: 9310 RVA: 0x0000DAA3 File Offset: 0x0000BCA3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x0600245F RID: 9311 RVA: 0x0009AFF8 File Offset: 0x000991F8
			// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000DABE File Offset: 0x0000BCBE
			public AsyncTaskMethodBuilder<TimeCheatingDetector.TimeCheatingDetectorResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TimeCheatingDetector.TimeCheatingDetectorResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TimeCheatingDetector.TimeCheatingDetectorResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TimeCheatingDetector.TimeCheatingDetectorResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06002461 RID: 9313 RVA: 0x0009B028 File Offset: 0x00099228
			// (set) Token: 0x06002462 RID: 9314 RVA: 0x0000DAEC File Offset: 0x0000BCEC
			public unsafe TimeCheatingDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06002463 RID: 9315 RVA: 0x0009B058 File Offset: 0x00099258
			// (set) Token: 0x06002464 RID: 9316 RVA: 0x0000DB0B File Offset: 0x0000BD0B
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._ForceCheckTask_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022DF RID: 8927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022E0 RID: 8928
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022E1 RID: 8929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022E2 RID: 8930
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022E3 RID: 8931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022E4 RID: 8932
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002C6 RID: 710
		[ObfuscatedName("CodeStage.AntiCheat.Detectors.TimeCheatingDetector+<CheckForCheat>d__69")]
		public sealed class _CheckForCheat_d__69 : global::Il2CppSystem.Object
		{
			// Token: 0x06002465 RID: 9317 RVA: 0x0009B088 File Offset: 0x00099288
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckForCheat_d__69()
			{
				Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<CheckForCheat>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr);
				TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, "<>1__state");
				TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, "<>2__current");
				TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, "<>4__this");
				TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, 100668102);
				TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, 100668103);
				TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, 100668104);
				TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, 100668105);
				TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, 100668106);
				TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr, 100668107);
			}

			// Token: 0x06002466 RID: 9318 RVA: 0x0009B168 File Offset: 0x00099368
			[CallerCount(0)]
			public unsafe _CheckForCheat_d__69(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeCheatingDetector._CheckForCheat_d__69>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002467 RID: 9319 RVA: 0x0009B1B0 File Offset: 0x000993B0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002468 RID: 9320 RVA: 0x0009B1E4 File Offset: 0x000993E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28610, XrefRangeEnd = 28616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x06002469 RID: 9321 RVA: 0x0009B220 File Offset: 0x00099420
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600246A RID: 9322 RVA: 0x0009B260 File Offset: 0x00099460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28616, XrefRangeEnd = 28621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x0600246B RID: 9323 RVA: 0x0009B294 File Offset: 0x00099494
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._CheckForCheat_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600246C RID: 9324 RVA: 0x0000DB39 File Offset: 0x0000BD39
			public _CheckForCheat_d__69(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x0600246D RID: 9325 RVA: 0x0009B2D4 File Offset: 0x000994D4
			// (set) Token: 0x0600246E RID: 9326 RVA: 0x0000DB42 File Offset: 0x0000BD42
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x0600246F RID: 9327 RVA: 0x0009B2FC File Offset: 0x000994FC
			// (set) Token: 0x06002470 RID: 9328 RVA: 0x0000DB5D File Offset: 0x0000BD5D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06002471 RID: 9329 RVA: 0x0009B32C File Offset: 0x0009952C
			// (set) Token: 0x06002472 RID: 9330 RVA: 0x0000DB7C File Offset: 0x0000BD7C
			public unsafe TimeCheatingDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._CheckForCheat_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022E5 RID: 8933
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022E6 RID: 8934
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040022E7 RID: 8935
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022E8 RID: 8936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022E9 RID: 8937
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022EA RID: 8938
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022EB RID: 8939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022EC RID: 8940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022ED RID: 8941
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002C7 RID: 711
		[ObfuscatedName("CodeStage.AntiCheat.Detectors.TimeCheatingDetector+<GetOnlineTimeInternal>d__70")]
		public sealed class _GetOnlineTimeInternal_d__70 : global::Il2CppSystem.Object
		{
			// Token: 0x06002473 RID: 9331 RVA: 0x0009B35C File Offset: 0x0009955C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetOnlineTimeInternal_d__70()
			{
				Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeCheatingDetector>.NativeClassPtr, "<GetOnlineTimeInternal>d__70");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr);
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, "<>1__state");
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, "<>2__current");
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, "<>4__this");
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr__timeBeforeAsyncCall_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, "<timeBeforeAsyncCall>5__2");
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, 100668108);
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, 100668109);
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, 100668110);
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, 100668111);
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, 100668112);
				TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr, 100668113);
			}

			// Token: 0x06002474 RID: 9332 RVA: 0x0009B450 File Offset: 0x00099650
			[CallerCount(0)]
			public unsafe _GetOnlineTimeInternal_d__70(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeCheatingDetector._GetOnlineTimeInternal_d__70>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002475 RID: 9333 RVA: 0x0009B498 File Offset: 0x00099698
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002476 RID: 9334 RVA: 0x0009B4CC File Offset: 0x000996CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28621, XrefRangeEnd = 28680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06002477 RID: 9335 RVA: 0x0009B508 File Offset: 0x00099708
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002478 RID: 9336 RVA: 0x0009B548 File Offset: 0x00099748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28680, XrefRangeEnd = 28685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06002479 RID: 9337 RVA: 0x0009B57C File Offset: 0x0009977C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600247A RID: 9338 RVA: 0x0000DB9B File Offset: 0x0000BD9B
			public _GetOnlineTimeInternal_d__70(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x0600247B RID: 9339 RVA: 0x0009B5BC File Offset: 0x000997BC
			// (set) Token: 0x0600247C RID: 9340 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x0600247D RID: 9341 RVA: 0x0009B5E4 File Offset: 0x000997E4
			// (set) Token: 0x0600247E RID: 9342 RVA: 0x0000DBBF File Offset: 0x0000BDBF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x0600247F RID: 9343 RVA: 0x0009B614 File Offset: 0x00099814
			// (set) Token: 0x06002480 RID: 9344 RVA: 0x0000DBDE File Offset: 0x0000BDDE
			public unsafe TimeCheatingDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeCheatingDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06002481 RID: 9345 RVA: 0x0009B644 File Offset: 0x00099844
			// (set) Token: 0x06002482 RID: 9346 RVA: 0x0000DBFD File Offset: 0x0000BDFD
			public unsafe float _timeBeforeAsyncCall_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr__timeBeforeAsyncCall_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeCheatingDetector._GetOnlineTimeInternal_d__70.NativeFieldInfoPtr__timeBeforeAsyncCall_5__2)) = value;
				}
			}

			// Token: 0x040022EE RID: 8942
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022EF RID: 8943
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040022F0 RID: 8944
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022F1 RID: 8945
			private static readonly IntPtr NativeFieldInfoPtr__timeBeforeAsyncCall_5__2;

			// Token: 0x040022F2 RID: 8946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022F3 RID: 8947
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022F4 RID: 8948
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022F5 RID: 8949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022F6 RID: 8950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022F7 RID: 8951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
