using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000047 RID: 71
	public class Application : Object
	{
		// Token: 0x06000209 RID: 521 RVA: 0x0001A3C0 File Offset: 0x000185C0
		// Note: this type is marked as 'beforefieldinit'.
		static Application()
		{
			Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Application");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
			Application.NativeFieldInfoPtr_lowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "lowMemory");
			Application.NativeFieldInfoPtr_s_LogCallbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandler");
			Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandlerThreaded");
			Application.NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "focusChanged");
			Application.NativeFieldInfoPtr_deepLinkActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "deepLinkActivated");
			Application.NativeFieldInfoPtr_wantsToQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "wantsToQuit");
			Application.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "quitting");
			Application.NativeFieldInfoPtr_unloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "unloading");
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663446);
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663447);
			Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663448);
			Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663449);
			Application.NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663450);
			Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663451);
			Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663452);
			Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663453);
			Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663454);
			Application.NativeMethodInfoPtr_get_temporaryCachePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663455);
			Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663456);
			Application.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663457);
			Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663458);
			Application.NativeMethodInfoPtr_set_backgroundLoadingPriority_Public_Static_set_Void_ThreadPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663459);
			Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663460);
			Application.NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663461);
			Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663462);
			Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663463);
			Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663464);
			Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663465);
			Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663466);
			Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663467);
			Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663468);
			Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663469);
			Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663470);
			Application.CancelQuitDelegateField = IL2CPP.ResolveICall<Application.CancelQuitDelegate>("UnityEngine.Application::CancelQuit");
			Application.UnloadDelegateField = IL2CPP.ResolveICall<Application.UnloadDelegate>("UnityEngine.Application::Unload");
			Application.get_isLoadingLevelDelegateField = IL2CPP.ResolveICall<Application.get_isLoadingLevelDelegate>("UnityEngine.Application::get_isLoadingLevel");
			Application.CanStreamedLevelBeLoadedDelegateField = IL2CPP.ResolveICall<Application.CanStreamedLevelBeLoadedDelegate>("UnityEngine.Application::CanStreamedLevelBeLoaded");
			Application.IsPlayingDelegateField = IL2CPP.ResolveICall<Application.IsPlayingDelegate>("UnityEngine.Application::IsPlaying");
			Application.GetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.GetBuildTagsDelegate>("UnityEngine.Application::GetBuildTags");
			Application.SetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.SetBuildTagsDelegate>("UnityEngine.Application::SetBuildTags");
			Application.get_buildGUIDDelegateField = IL2CPP.ResolveICall<Application.get_buildGUIDDelegate>("UnityEngine.Application::get_buildGUID");
			Application.set_runInBackgroundDelegateField = IL2CPP.ResolveICall<Application.set_runInBackgroundDelegate>("UnityEngine.Application::set_runInBackground");
			Application.HasProLicenseDelegateField = IL2CPP.ResolveICall<Application.HasProLicenseDelegate>("UnityEngine.Application::HasProLicense");
			Application.get_isTestRunDelegateField = IL2CPP.ResolveICall<Application.get_isTestRunDelegate>("UnityEngine.Application::get_isTestRun");
			Application.get_isHumanControllingUsDelegateField = IL2CPP.ResolveICall<Application.get_isHumanControllingUsDelegate>("UnityEngine.Application::get_isHumanControllingUs");
			Application.HasARGVDelegateField = IL2CPP.ResolveICall<Application.HasARGVDelegate>("UnityEngine.Application::HasARGV");
			Application.GetValueForARGVDelegateField = IL2CPP.ResolveICall<Application.GetValueForARGVDelegate>("UnityEngine.Application::GetValueForARGV");
			Application.get_absoluteURLDelegateField = IL2CPP.ResolveICall<Application.get_absoluteURLDelegate>("UnityEngine.Application::get_absoluteURL");
			Application.Internal_ExternalCallDelegateField = IL2CPP.ResolveICall<Application.Internal_ExternalCallDelegate>("UnityEngine.Application::Internal_ExternalCall");
			Application.get_unityVersionVerDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionVerDelegate>("UnityEngine.Application::get_unityVersionVer");
			Application.get_unityVersionMajDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMajDelegate>("UnityEngine.Application::get_unityVersionMaj");
			Application.get_unityVersionMinDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMinDelegate>("UnityEngine.Application::get_unityVersionMin");
			Application.get_versionDelegateField = IL2CPP.ResolveICall<Application.get_versionDelegate>("UnityEngine.Application::get_version");
			Application.get_installerNameDelegateField = IL2CPP.ResolveICall<Application.get_installerNameDelegate>("UnityEngine.Application::get_installerName");
			Application.get_identifierDelegateField = IL2CPP.ResolveICall<Application.get_identifierDelegate>("UnityEngine.Application::get_identifier");
			Application.get_installModeDelegateField = IL2CPP.ResolveICall<Application.get_installModeDelegate>("UnityEngine.Application::get_installMode");
			Application.get_sandboxTypeDelegateField = IL2CPP.ResolveICall<Application.get_sandboxTypeDelegate>("UnityEngine.Application::get_sandboxType");
			Application.get_companyNameDelegateField = IL2CPP.ResolveICall<Application.get_companyNameDelegate>("UnityEngine.Application::get_companyName");
			Application.get_cloudProjectIdDelegateField = IL2CPP.ResolveICall<Application.get_cloudProjectIdDelegate>("UnityEngine.Application::get_cloudProjectId");
			Application.OpenURLDelegateField = IL2CPP.ResolveICall<Application.OpenURLDelegate>("UnityEngine.Application::OpenURL");
			Application.get_targetFrameRateDelegateField = IL2CPP.ResolveICall<Application.get_targetFrameRateDelegate>("UnityEngine.Application::get_targetFrameRate");
			Application.SetLogCallbackDefinedDelegateField = IL2CPP.ResolveICall<Application.SetLogCallbackDefinedDelegate>("UnityEngine.Application::SetLogCallbackDefined");
			Application.get_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.get_stackTraceLogTypeDelegate>("UnityEngine.Application::get_stackTraceLogType");
			Application.set_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.set_stackTraceLogTypeDelegate>("UnityEngine.Application::set_stackTraceLogType");
			Application.GetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.GetStackTraceLogTypeDelegate>("UnityEngine.Application::GetStackTraceLogType");
			Application.SetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.SetStackTraceLogTypeDelegate>("UnityEngine.Application::SetStackTraceLogType");
			Application.get_consoleLogPathDelegateField = IL2CPP.ResolveICall<Application.get_consoleLogPathDelegate>("UnityEngine.Application::get_consoleLogPath");
			Application.get_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.get_backgroundLoadingPriorityDelegate>("UnityEngine.Application::get_backgroundLoadingPriority");
			Application.get_genuineDelegateField = IL2CPP.ResolveICall<Application.get_genuineDelegate>("UnityEngine.Application::get_genuine");
			Application.get_genuineCheckAvailableDelegateField = IL2CPP.ResolveICall<Application.get_genuineCheckAvailableDelegate>("UnityEngine.Application::get_genuineCheckAvailable");
			Application.RequestUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.RequestUserAuthorizationDelegate>("UnityEngine.Application::RequestUserAuthorization");
			Application.HasUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.HasUserAuthorizationDelegate>("UnityEngine.Application::HasUserAuthorization");
			Application.get_submitAnalyticsDelegateField = IL2CPP.ResolveICall<Application.get_submitAnalyticsDelegate>("UnityEngine.Application::get_submitAnalytics");
			Application.get_internetReachabilityDelegateField = IL2CPP.ResolveICall<Application.get_internetReachabilityDelegate>("UnityEngine.Application::get_internetReachability");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001A8EC File Offset: 0x00018AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486130, XrefRangeEnd = 486134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit(int exitCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001A920 File Offset: 0x00018B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0001A948 File Offset: 0x00018B48
		public unsafe static bool isPlaying
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 486138, RefRangeEnd = 486144, XrefRangeStart = 486134, XrefRangeEnd = 486138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0001A978 File Offset: 0x00018B78
		public unsafe static bool isFocused
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486148, RefRangeEnd = 486150, XrefRangeStart = 486144, XrefRangeEnd = 486148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		// (set) Token: 0x06000241 RID: 577 RVA: 0x000033F1 File Offset: 0x000015F1
		public unsafe static bool runInBackground
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Application.set_runInBackgroundDelegateField(value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0001A9D8 File Offset: 0x00018BD8
		public unsafe static bool isBatchMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486150, XrefRangeEnd = 486154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001AA08 File Offset: 0x00018C08
		public unsafe static string dataPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486154, XrefRangeEnd = 486158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0001AA34 File Offset: 0x00018C34
		public unsafe static string streamingAssetsPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486158, XrefRangeEnd = 486162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001AA60 File Offset: 0x00018C60
		public unsafe static string persistentDataPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486162, XrefRangeEnd = 486166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0001AA8C File Offset: 0x00018C8C
		public unsafe static string temporaryCachePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486166, XrefRangeEnd = 486170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_temporaryCachePath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		public unsafe static string unityVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486170, XrefRangeEnd = 486174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		public unsafe static string productName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486174, XrefRangeEnd = 486178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000349E File Offset: 0x0000169E
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0001AB10 File Offset: 0x00018D10
		public unsafe static int targetFrameRate
		{
			get
			{
				return Application.get_targetFrameRateDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486178, XrefRangeEnd = 486182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000034EB File Offset: 0x000016EB
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0001AB44 File Offset: 0x00018D44
		public unsafe static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.get_backgroundLoadingPriorityDelegateField();
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486182, XrefRangeEnd = 486186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_backgroundLoadingPriority_Public_Static_set_Void_ThreadPriority_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001AB78 File Offset: 0x00018D78
		public unsafe static RuntimePlatform platform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 486190, RefRangeEnd = 486193, XrefRangeStart = 486186, XrefRangeEnd = 486190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0001ABA8 File Offset: 0x00018DA8
		public unsafe static SystemLanguage systemLanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486193, XrefRangeEnd = 486197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486197, XrefRangeEnd = 486200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLowMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001AC00 File Offset: 0x00018E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486200, XrefRangeEnd = 486205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokedOnMainThread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001AC64 File Offset: 0x00018E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486205, XrefRangeEnd = 486220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_ApplicationWantsToQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001AC94 File Offset: 0x00018E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486220, XrefRangeEnd = 486223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001ACBC File Offset: 0x00018EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486223, XrefRangeEnd = 486226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationUnload()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486226, XrefRangeEnd = 486230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnBeforeRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001AD0C File Offset: 0x00018F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486230, XrefRangeEnd = 486235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeFocusChanged(bool focus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001AD40 File Offset: 0x00018F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486235, XrefRangeEnd = 486240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDeepLinkActivated(string url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0001AD78 File Offset: 0x00018F78
		public unsafe static bool isEditor
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000032FE File Offset: 0x000014FE
		public Application(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00003307 File Offset: 0x00001507
		public unsafe static Application.LowMemoryCallback lowMemory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_lowMemory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LowMemoryCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_lowMemory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00003319 File Offset: 0x00001519
		public unsafe static Application.LogCallback s_LogCallbackHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0000332B File Offset: 0x0000152B
		public unsafe static Application.LogCallback s_LogCallbackHandlerThreaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0001AE20 File Offset: 0x00019020
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000333D File Offset: 0x0000153D
		public unsafe static Action<bool> focusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_focusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_focusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0001AE48 File Offset: 0x00019048
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000334F File Offset: 0x0000154F
		public unsafe static Action<string> deepLinkActivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_deepLinkActivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_deepLinkActivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001AE70 File Offset: 0x00019070
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00003361 File Offset: 0x00001561
		public unsafe static Func<bool> wantsToQuit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_wantsToQuit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_wantsToQuit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0001AE98 File Offset: 0x00019098
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00003373 File Offset: 0x00001573
		public unsafe static Action quitting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_quitting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_quitting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001AEC0 File Offset: 0x000190C0
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00003385 File Offset: 0x00001585
		public unsafe static Action unloading
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_unloading, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_unloading, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003397 File Offset: 0x00001597
		public static void CancelQuit()
		{
			Application.CancelQuitDelegateField();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000033A3 File Offset: 0x000015A3
		public static void Unload()
		{
			Application.UnloadDelegateField();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000033AF File Offset: 0x000015AF
		public static bool isLoadingLevel
		{
			get
			{
				return Application.get_isLoadingLevelDelegateField();
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001AEE8 File Offset: 0x000190E8
		public static float GetStreamProgressForLevel(int levelIndex)
		{
			bool flag = levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			float num;
			if (flag)
			{
				num = 1f;
			}
			else
			{
				num = 0f;
			}
			return num;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001AF1C File Offset: 0x0001911C
		public static float GetStreamProgressForLevel(string levelName)
		{
			return 1f;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0001AF34 File Offset: 0x00019134
		public static int streamedBytes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0001AF48 File Offset: 0x00019148
		public static bool webSecurityEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001AF5C File Offset: 0x0001915C
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000033BB File Offset: 0x000015BB
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoadedDelegateField(IL2CPP.ManagedStringToIl2Cpp(levelName));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000033CD File Offset: 0x000015CD
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001AF80 File Offset: 0x00019180
		public static Il2CppStringArray GetBuildTags()
		{
			IntPtr intPtr = Application.GetBuildTagsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000033DF File Offset: 0x000015DF
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buildTags));
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0001AFA8 File Offset: 0x000191A8
		public static string buildGUID
		{
			get
			{
				IntPtr intPtr = Application.get_buildGUIDDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000033FE File Offset: 0x000015FE
		public static bool HasProLicense()
		{
			return Application.HasProLicenseDelegateField();
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000340A File Offset: 0x0000160A
		public static bool isTestRun
		{
			get
			{
				return Application.get_isTestRunDelegateField();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00003416 File Offset: 0x00001616
		public static bool isHumanControllingUs
		{
			get
			{
				return Application.get_isHumanControllingUsDelegateField();
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00003422 File Offset: 0x00001622
		public static bool HasARGV(string name)
		{
			return Application.HasARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001AFC8 File Offset: 0x000191C8
		public static string GetValueForARGV(string name)
		{
			IntPtr intPtr = Application.GetValueForARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0001AFEC File Offset: 0x000191EC
		public static string absoluteURL
		{
			get
			{
				IntPtr intPtr = Application.get_absoluteURLDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001B00C File Offset: 0x0001920C
		public static void ExternalEval(string script)
		{
			bool flag = script.Length > 0 && script.get_Chars(script.Length - 1) != ';';
			if (flag)
			{
				script = String.Concat(script, ";");
			}
			Application.Internal_ExternalCall(script);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003434 File Offset: 0x00001634
		public static void Internal_ExternalCall(string script)
		{
			Application.Internal_ExternalCallDelegateField(IL2CPP.ManagedStringToIl2Cpp(script));
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00003446 File Offset: 0x00001646
		public static int unityVersionVer
		{
			get
			{
				return Application.get_unityVersionVerDelegateField();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00003452 File Offset: 0x00001652
		public static int unityVersionMaj
		{
			get
			{
				return Application.get_unityVersionMajDelegateField();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000345E File Offset: 0x0000165E
		public static int unityVersionMin
		{
			get
			{
				return Application.get_unityVersionMinDelegateField();
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0001B054 File Offset: 0x00019254
		public static string version
		{
			get
			{
				IntPtr intPtr = Application.get_versionDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001B074 File Offset: 0x00019274
		public static string installerName
		{
			get
			{
				IntPtr intPtr = Application.get_installerNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0001B094 File Offset: 0x00019294
		public static string identifier
		{
			get
			{
				IntPtr intPtr = Application.get_identifierDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000346A File Offset: 0x0000166A
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.get_installModeDelegateField();
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003476 File Offset: 0x00001676
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.get_sandboxTypeDelegateField();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0001B0B4 File Offset: 0x000192B4
		public static string companyName
		{
			get
			{
				IntPtr intPtr = Application.get_companyNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0001B0D4 File Offset: 0x000192D4
		public static string cloudProjectId
		{
			get
			{
				IntPtr intPtr = Application.get_cloudProjectIdDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003482 File Offset: 0x00001682
		public static void OpenURL(string url)
		{
			Application.OpenURLDelegateField(IL2CPP.ManagedStringToIl2Cpp(url));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00003494 File Offset: 0x00001694
		public static void ForceCrash(int mode)
		{
			UnityEngine.Diagnostics.Utils.ForceCrash((UnityEngine.Diagnostics.ForcedCrashCategory)mode);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000034AA File Offset: 0x000016AA
		public static void SetLogCallbackDefined(bool defined)
		{
			Application.SetLogCallbackDefinedDelegateField(defined);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000034B7 File Offset: 0x000016B7
		// (set) Token: 0x06000259 RID: 601 RVA: 0x000034C3 File Offset: 0x000016C3
		public static StackTraceLogType stackTraceLogType
		{
			get
			{
				return Application.get_stackTraceLogTypeDelegateField();
			}
			set
			{
				Application.set_stackTraceLogTypeDelegateField(value);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000034D0 File Offset: 0x000016D0
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogTypeDelegateField(logType);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000034DD File Offset: 0x000016DD
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogTypeDelegateField(logType, stackTraceType);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001B0F4 File Offset: 0x000192F4
		public static string consoleLogPath
		{
			get
			{
				IntPtr intPtr = Application.get_consoleLogPathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000034F7 File Offset: 0x000016F7
		public static bool genuine
		{
			get
			{
				return Application.get_genuineDelegateField();
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00003503 File Offset: 0x00001703
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.get_genuineCheckAvailableDelegateField();
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001B114 File Offset: 0x00019314
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			IntPtr intPtr = Application.RequestUserAuthorizationDelegateField(mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000350F File Offset: 0x0000170F
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorizationDelegateField(mode);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000351C File Offset: 0x0000171C
		public static bool submitAnalytics
		{
			get
			{
				return Application.get_submitAnalyticsDelegateField();
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0001B13C File Offset: 0x0001933C
		public static bool isShowingSplashScreen
		{
			get
			{
				return !UnityEngine.Rendering.SplashScreen.isFinished;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0001B158 File Offset: 0x00019358
		public static bool isMobilePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				RuntimePlatform runtimePlatform = platform;
				return runtimePlatform == RuntimePlatform.IPhonePlayer || runtimePlatform == RuntimePlatform.Android || (runtimePlatform - RuntimePlatform.MetroPlayerX86 <= 2 && SystemInfo.deviceType == DeviceType.Handheld);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0001B198 File Offset: 0x00019398
		public static bool isConsolePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				return platform == RuntimePlatform.GameCoreXboxOne || platform == RuntimePlatform.GameCoreXboxSeries || platform == RuntimePlatform.PS4 || platform == RuntimePlatform.PS5 || platform == RuntimePlatform.Switch || platform == RuntimePlatform.XboxOne;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00003528 File Offset: 0x00001728
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.get_internetReachabilityDelegateField();
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00003534 File Offset: 0x00001734
		public static void add_lowMemory(Application.LowMemoryCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00003541 File Offset: 0x00001741
		public static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000354E File Offset: 0x0000174E
		public static void add_logMessageReceived(Application.LogCallback value)
		{
			Application.s_LogCallbackHandler = Delegate.Combine(Application.s_LogCallbackHandler, value).Cast<Application.LogCallback>();
			Application.SetLogCallbackDefined(true);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000356D File Offset: 0x0000176D
		public static void remove_logMessageReceived(Application.LogCallback value)
		{
			Application.s_LogCallbackHandler = Delegate.Remove(Application.s_LogCallbackHandler, value).Cast<Application.LogCallback>();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00003585 File Offset: 0x00001785
		public static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.s_LogCallbackHandlerThreaded = Delegate.Combine(Application.s_LogCallbackHandlerThreaded, value).Cast<Application.LogCallback>();
			Application.SetLogCallbackDefined(true);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000035A4 File Offset: 0x000017A4
		public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.s_LogCallbackHandlerThreaded = Delegate.Remove(Application.s_LogCallbackHandlerThreaded, value).Cast<Application.LogCallback>();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000035BC File Offset: 0x000017BC
		public static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001B1D4 File Offset: 0x000193D4
		public static string ObjectToJSString(Object o)
		{
			bool flag = o == null;
			string text;
			if (flag)
			{
				text = "null";
			}
			else
			{
				bool flag2 = o.TryCast<string>() != null;
				if (flag2)
				{
					string text2 = o.ToString().Replace("\\", "\\\\");
					text2 = text2.Replace("\"", "\\\"");
					text2 = text2.Replace("\n", "\\n");
					text2 = text2.Replace("\r", "\\r");
					text2 = text2.Replace("\0", "");
					text2 = text2.Replace("\u2028", "");
					text2 = text2.Replace("\u2029", "");
					text = String.Concat("\"", text2, "\"");
				}
				else
				{
					bool flag3 = o is int || o is short || o is uint || o is ushort || o is byte;
					if (flag3)
					{
						text = o.ToString();
					}
					else
					{
						bool flag4 = o is float;
						if (flag4)
						{
							NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
							text = ((float)o).ToString(numberFormat);
						}
						else
						{
							bool flag5 = o is double;
							if (flag5)
							{
								NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
								text = ((double)o).ToString(numberFormat2);
							}
							else
							{
								bool flag6 = o is char;
								if (flag6)
								{
									bool flag7 = (char)o == '"';
									if (flag7)
									{
										text = "\"\\\"\"";
									}
									else
									{
										text = String.Concat("\"", o.ToString(), "\"");
									}
								}
								else
								{
									bool flag8 = o.TryCast<IList>() != null;
									if (flag8)
									{
										IList list = o.Cast<IList>();
										StringBuilder stringBuilder = new StringBuilder();
										stringBuilder.Append("new Array(");
										int count = list.Count;
										for (int i = 0; i < count; i++)
										{
											bool flag9 = i != 0;
											if (flag9)
											{
												stringBuilder.Append(", ");
											}
											stringBuilder.Append(Application.ObjectToJSString(list[i]));
										}
										stringBuilder.Append(")");
										text = stringBuilder.ToString();
									}
									else
									{
										text = Application.ObjectToJSString(o.ToString());
									}
								}
							}
						}
					}
				}
			}
			return text;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000035C9 File Offset: 0x000017C9
		public static void ExternalCall(string functionName, Il2CppReferenceArray<Object> args)
		{
			Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000035D9 File Offset: 0x000017D9
		public static void ExternalCall(string functionName, params Object[] args)
		{
			Application.ExternalCall(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000035E7 File Offset: 0x000017E7
		public static string BuildInvocationForArguments(string functionName, Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000035F4 File Offset: 0x000017F4
		public static string BuildInvocationForArguments(string functionName, params Object[] args)
		{
			return Application.BuildInvocationForArguments(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0001B42C File Offset: 0x0001962C
		public static bool isPlayer
		{
			get
			{
				return !Application.isEditor;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001B448 File Offset: 0x00019648
		public static void DontDestroyOnLoad(Object o)
		{
			bool flag = o != null;
			if (flag)
			{
				Object.DontDestroyOnLoad(o);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003602 File Offset: 0x00001802
		public static void CaptureScreenshot(string filename, int superSize)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000360F File Offset: 0x0000180F
		public static void CaptureScreenshot(string filename)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000361C File Offset: 0x0000181C
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.RegisterCallback(value);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00003626 File Offset: 0x00001826
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.UnregisterCallback(value);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00003630 File Offset: 0x00001830
		public static void add_focusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000363D File Offset: 0x0000183D
		public static void remove_focusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000364A File Offset: 0x0000184A
		public static void add_deepLinkActivated(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00003657 File Offset: 0x00001857
		public static void remove_deepLinkActivated(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003664 File Offset: 0x00001864
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, false);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000366F File Offset: 0x0000186F
		public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, true);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000367A File Offset: 0x0000187A
		public static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001B468 File Offset: 0x00019668
		public static int levelCount
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0001B480 File Offset: 0x00019680
		public static int loadedLevel
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public static string loadedLevelName
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00003687 File Offset: 0x00001887
		public static void LoadLevel(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003692 File Offset: 0x00001892
		public static void LoadLevel(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000369D File Offset: 0x0000189D
		public static void LoadLevelAdditive(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000036A8 File Offset: 0x000018A8
		public static void LoadLevelAdditive(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001B4C0 File Offset: 0x000196C0
		public static AsyncOperation LoadLevelAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001B4DC File Offset: 0x000196DC
		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001B4F8 File Offset: 0x000196F8
		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001B514 File Offset: 0x00019714
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001B530 File Offset: 0x00019730
		public static bool UnloadLevel(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(index);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001B548 File Offset: 0x00019748
		public static bool UnloadLevel(string scenePath)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(scenePath);
		}

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_lowMemory;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandler;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandlerThreaded;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_focusChanged;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_deepLinkActivated;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_wantsToQuit;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_quitting;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_unloading;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_temporaryCachePath_Public_Static_get_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_productName_Public_Static_get_String_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundLoadingPriority_Public_Static_set_Void_ThreadPriority_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;

		// Token: 0x040001E9 RID: 489
		private static readonly Application.CancelQuitDelegate CancelQuitDelegateField;

		// Token: 0x040001EA RID: 490
		private static readonly Application.UnloadDelegate UnloadDelegateField;

		// Token: 0x040001EB RID: 491
		private static readonly Application.get_isLoadingLevelDelegate get_isLoadingLevelDelegateField;

		// Token: 0x040001EC RID: 492
		private static readonly Application.CanStreamedLevelBeLoadedDelegate CanStreamedLevelBeLoadedDelegateField;

		// Token: 0x040001ED RID: 493
		private static readonly Application.IsPlayingDelegate IsPlayingDelegateField;

		// Token: 0x040001EE RID: 494
		private static readonly Application.GetBuildTagsDelegate GetBuildTagsDelegateField;

		// Token: 0x040001EF RID: 495
		private static readonly Application.SetBuildTagsDelegate SetBuildTagsDelegateField;

		// Token: 0x040001F0 RID: 496
		private static readonly Application.get_buildGUIDDelegate get_buildGUIDDelegateField;

		// Token: 0x040001F1 RID: 497
		private static readonly Application.set_runInBackgroundDelegate set_runInBackgroundDelegateField;

		// Token: 0x040001F2 RID: 498
		private static readonly Application.HasProLicenseDelegate HasProLicenseDelegateField;

		// Token: 0x040001F3 RID: 499
		private static readonly Application.get_isTestRunDelegate get_isTestRunDelegateField;

		// Token: 0x040001F4 RID: 500
		private static readonly Application.get_isHumanControllingUsDelegate get_isHumanControllingUsDelegateField;

		// Token: 0x040001F5 RID: 501
		private static readonly Application.HasARGVDelegate HasARGVDelegateField;

		// Token: 0x040001F6 RID: 502
		private static readonly Application.GetValueForARGVDelegate GetValueForARGVDelegateField;

		// Token: 0x040001F7 RID: 503
		private static readonly Application.get_absoluteURLDelegate get_absoluteURLDelegateField;

		// Token: 0x040001F8 RID: 504
		private static readonly Application.Internal_ExternalCallDelegate Internal_ExternalCallDelegateField;

		// Token: 0x040001F9 RID: 505
		private static readonly Application.get_unityVersionVerDelegate get_unityVersionVerDelegateField;

		// Token: 0x040001FA RID: 506
		private static readonly Application.get_unityVersionMajDelegate get_unityVersionMajDelegateField;

		// Token: 0x040001FB RID: 507
		private static readonly Application.get_unityVersionMinDelegate get_unityVersionMinDelegateField;

		// Token: 0x040001FC RID: 508
		private static readonly Application.get_versionDelegate get_versionDelegateField;

		// Token: 0x040001FD RID: 509
		private static readonly Application.get_installerNameDelegate get_installerNameDelegateField;

		// Token: 0x040001FE RID: 510
		private static readonly Application.get_identifierDelegate get_identifierDelegateField;

		// Token: 0x040001FF RID: 511
		private static readonly Application.get_installModeDelegate get_installModeDelegateField;

		// Token: 0x04000200 RID: 512
		private static readonly Application.get_sandboxTypeDelegate get_sandboxTypeDelegateField;

		// Token: 0x04000201 RID: 513
		private static readonly Application.get_companyNameDelegate get_companyNameDelegateField;

		// Token: 0x04000202 RID: 514
		private static readonly Application.get_cloudProjectIdDelegate get_cloudProjectIdDelegateField;

		// Token: 0x04000203 RID: 515
		private static readonly Application.OpenURLDelegate OpenURLDelegateField;

		// Token: 0x04000204 RID: 516
		private static readonly Application.get_targetFrameRateDelegate get_targetFrameRateDelegateField;

		// Token: 0x04000205 RID: 517
		private static readonly Application.SetLogCallbackDefinedDelegate SetLogCallbackDefinedDelegateField;

		// Token: 0x04000206 RID: 518
		private static readonly Application.get_stackTraceLogTypeDelegate get_stackTraceLogTypeDelegateField;

		// Token: 0x04000207 RID: 519
		private static readonly Application.set_stackTraceLogTypeDelegate set_stackTraceLogTypeDelegateField;

		// Token: 0x04000208 RID: 520
		private static readonly Application.GetStackTraceLogTypeDelegate GetStackTraceLogTypeDelegateField;

		// Token: 0x04000209 RID: 521
		private static readonly Application.SetStackTraceLogTypeDelegate SetStackTraceLogTypeDelegateField;

		// Token: 0x0400020A RID: 522
		private static readonly Application.get_consoleLogPathDelegate get_consoleLogPathDelegateField;

		// Token: 0x0400020B RID: 523
		private static readonly Application.get_backgroundLoadingPriorityDelegate get_backgroundLoadingPriorityDelegateField;

		// Token: 0x0400020C RID: 524
		private static readonly Application.get_genuineDelegate get_genuineDelegateField;

		// Token: 0x0400020D RID: 525
		private static readonly Application.get_genuineCheckAvailableDelegate get_genuineCheckAvailableDelegateField;

		// Token: 0x0400020E RID: 526
		private static readonly Application.RequestUserAuthorizationDelegate RequestUserAuthorizationDelegateField;

		// Token: 0x0400020F RID: 527
		private static readonly Application.HasUserAuthorizationDelegate HasUserAuthorizationDelegateField;

		// Token: 0x04000210 RID: 528
		private static readonly Application.get_submitAnalyticsDelegate get_submitAnalyticsDelegateField;

		// Token: 0x04000211 RID: 529
		private static readonly Application.get_internetReachabilityDelegate get_internetReachabilityDelegateField;

		// Token: 0x0200033D RID: 829
		public sealed class LowMemoryCallback : MulticastDelegate
		{
			// Token: 0x06002492 RID: 9362 RVA: 0x0007A858 File Offset: 0x00078A58
			// Note: this type is marked as 'beforefieldinit'.
			static LowMemoryCallback()
			{
				Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LowMemoryCallback");
				Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663471);
				Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663472);
				Application.LowMemoryCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663473);
				Application.LowMemoryCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663474);
			}

			// Token: 0x06002493 RID: 9363 RVA: 0x0007A8CC File Offset: 0x00078ACC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowMemoryCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002494 RID: 9364 RVA: 0x0007A928 File Offset: 0x00078B28
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002495 RID: 9365 RVA: 0x0007A95C File Offset: 0x00078B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002496 RID: 9366 RVA: 0x0007A9C0 File Offset: 0x00078BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002497 RID: 9367 RVA: 0x00013570 File Offset: 0x00011770
			public LowMemoryCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002498 RID: 9368 RVA: 0x00013579 File Offset: 0x00011779
			public static implicit operator Application.LowMemoryCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LowMemoryCallback>(A_0);
			}

			// Token: 0x06002499 RID: 9369 RVA: 0x00013581 File Offset: 0x00011781
			public static Application.LowMemoryCallback operator +(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LowMemoryCallback>();
			}

			// Token: 0x0600249A RID: 9370 RVA: 0x0001358F File Offset: 0x0001178F
			public static Application.LowMemoryCallback operator -(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Application.LowMemoryCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001E87 RID: 7815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001E88 RID: 7816
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001E89 RID: 7817
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001E8A RID: 7818
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200033E RID: 830
		public sealed class LogCallback : MulticastDelegate
		{
			// Token: 0x0600249B RID: 9371 RVA: 0x0007AA04 File Offset: 0x00078C04
			// Note: this type is marked as 'beforefieldinit'.
			static LogCallback()
			{
				Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LogCallback");
				Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663475);
				Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663476);
				Application.LogCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_LogType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663477);
				Application.LogCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663478);
			}

			// Token: 0x0600249C RID: 9372 RVA: 0x0007AA78 File Offset: 0x00078C78
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600249D RID: 9373 RVA: 0x0007AAD4 File Offset: 0x00078CD4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486124, RefRangeEnd = 486126, XrefRangeStart = 486124, XrefRangeEnd = 486124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string condition, string stackTrace, LogType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600249E RID: 9374 RVA: 0x0007AB38 File Offset: 0x00078D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486126, XrefRangeEnd = 486130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_LogType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600249F RID: 9375 RVA: 0x0007ABD0 File Offset: 0x00078DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024A0 RID: 9376 RVA: 0x000135A0 File Offset: 0x000117A0
			public LogCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060024A1 RID: 9377 RVA: 0x000135A9 File Offset: 0x000117A9
			public static implicit operator Application.LogCallback(Action<string, string, LogType> A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LogCallback>(A_0);
			}

			// Token: 0x060024A2 RID: 9378 RVA: 0x000135B1 File Offset: 0x000117B1
			public static Application.LogCallback operator +(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LogCallback>();
			}

			// Token: 0x060024A3 RID: 9379 RVA: 0x000135BF File Offset: 0x000117BF
			public static Application.LogCallback operator -(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Application.LogCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001E8B RID: 7819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001E8C RID: 7820
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0;

			// Token: 0x04001E8D RID: 7821
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_LogType_AsyncCallback_Object_0;

			// Token: 0x04001E8E RID: 7822
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200033F RID: 831
		// (Invoke) Token: 0x060024A5 RID: 9381
		private delegate void CancelQuitDelegate();

		// Token: 0x02000340 RID: 832
		// (Invoke) Token: 0x060024A7 RID: 9383
		private delegate void UnloadDelegate();

		// Token: 0x02000341 RID: 833
		// (Invoke) Token: 0x060024A9 RID: 9385
		private delegate bool get_isLoadingLevelDelegate();

		// Token: 0x02000342 RID: 834
		// (Invoke) Token: 0x060024AB RID: 9387
		private delegate bool CanStreamedLevelBeLoadedDelegate(IntPtr levelName);

		// Token: 0x02000343 RID: 835
		// (Invoke) Token: 0x060024AD RID: 9389
		private delegate bool IsPlayingDelegate(IntPtr obj);

		// Token: 0x02000344 RID: 836
		// (Invoke) Token: 0x060024AF RID: 9391
		private delegate IntPtr GetBuildTagsDelegate();

		// Token: 0x02000345 RID: 837
		// (Invoke) Token: 0x060024B1 RID: 9393
		private delegate void SetBuildTagsDelegate(IntPtr buildTags);

		// Token: 0x02000346 RID: 838
		// (Invoke) Token: 0x060024B3 RID: 9395
		private delegate IntPtr get_buildGUIDDelegate();

		// Token: 0x02000347 RID: 839
		// (Invoke) Token: 0x060024B5 RID: 9397
		private delegate void set_runInBackgroundDelegate(bool value);

		// Token: 0x02000348 RID: 840
		// (Invoke) Token: 0x060024B7 RID: 9399
		private delegate bool HasProLicenseDelegate();

		// Token: 0x02000349 RID: 841
		// (Invoke) Token: 0x060024B9 RID: 9401
		private delegate bool get_isTestRunDelegate();

		// Token: 0x0200034A RID: 842
		// (Invoke) Token: 0x060024BB RID: 9403
		private delegate bool get_isHumanControllingUsDelegate();

		// Token: 0x0200034B RID: 843
		// (Invoke) Token: 0x060024BD RID: 9405
		private delegate bool HasARGVDelegate(IntPtr name);

		// Token: 0x0200034C RID: 844
		// (Invoke) Token: 0x060024BF RID: 9407
		private delegate IntPtr GetValueForARGVDelegate(IntPtr name);

		// Token: 0x0200034D RID: 845
		// (Invoke) Token: 0x060024C1 RID: 9409
		private delegate IntPtr get_absoluteURLDelegate();

		// Token: 0x0200034E RID: 846
		// (Invoke) Token: 0x060024C3 RID: 9411
		private delegate void Internal_ExternalCallDelegate(IntPtr script);

		// Token: 0x0200034F RID: 847
		// (Invoke) Token: 0x060024C5 RID: 9413
		private delegate int get_unityVersionVerDelegate();

		// Token: 0x02000350 RID: 848
		// (Invoke) Token: 0x060024C7 RID: 9415
		private delegate int get_unityVersionMajDelegate();

		// Token: 0x02000351 RID: 849
		// (Invoke) Token: 0x060024C9 RID: 9417
		private delegate int get_unityVersionMinDelegate();

		// Token: 0x02000352 RID: 850
		// (Invoke) Token: 0x060024CB RID: 9419
		private delegate IntPtr get_versionDelegate();

		// Token: 0x02000353 RID: 851
		// (Invoke) Token: 0x060024CD RID: 9421
		private delegate IntPtr get_installerNameDelegate();

		// Token: 0x02000354 RID: 852
		// (Invoke) Token: 0x060024CF RID: 9423
		private delegate IntPtr get_identifierDelegate();

		// Token: 0x02000355 RID: 853
		// (Invoke) Token: 0x060024D1 RID: 9425
		private delegate ApplicationInstallMode get_installModeDelegate();

		// Token: 0x02000356 RID: 854
		// (Invoke) Token: 0x060024D3 RID: 9427
		private delegate ApplicationSandboxType get_sandboxTypeDelegate();

		// Token: 0x02000357 RID: 855
		// (Invoke) Token: 0x060024D5 RID: 9429
		private delegate IntPtr get_companyNameDelegate();

		// Token: 0x02000358 RID: 856
		// (Invoke) Token: 0x060024D7 RID: 9431
		private delegate IntPtr get_cloudProjectIdDelegate();

		// Token: 0x02000359 RID: 857
		// (Invoke) Token: 0x060024D9 RID: 9433
		private delegate void OpenURLDelegate(IntPtr url);

		// Token: 0x0200035A RID: 858
		// (Invoke) Token: 0x060024DB RID: 9435
		private delegate int get_targetFrameRateDelegate();

		// Token: 0x0200035B RID: 859
		// (Invoke) Token: 0x060024DD RID: 9437
		private delegate void SetLogCallbackDefinedDelegate(bool defined);

		// Token: 0x0200035C RID: 860
		// (Invoke) Token: 0x060024DF RID: 9439
		private delegate StackTraceLogType get_stackTraceLogTypeDelegate();

		// Token: 0x0200035D RID: 861
		// (Invoke) Token: 0x060024E1 RID: 9441
		private delegate void set_stackTraceLogTypeDelegate(StackTraceLogType value);

		// Token: 0x0200035E RID: 862
		// (Invoke) Token: 0x060024E3 RID: 9443
		private delegate StackTraceLogType GetStackTraceLogTypeDelegate(LogType logType);

		// Token: 0x0200035F RID: 863
		// (Invoke) Token: 0x060024E5 RID: 9445
		private delegate void SetStackTraceLogTypeDelegate(LogType logType, StackTraceLogType stackTraceType);

		// Token: 0x02000360 RID: 864
		// (Invoke) Token: 0x060024E7 RID: 9447
		private delegate IntPtr get_consoleLogPathDelegate();

		// Token: 0x02000361 RID: 865
		// (Invoke) Token: 0x060024E9 RID: 9449
		private delegate ThreadPriority get_backgroundLoadingPriorityDelegate();

		// Token: 0x02000362 RID: 866
		// (Invoke) Token: 0x060024EB RID: 9451
		private delegate bool get_genuineDelegate();

		// Token: 0x02000363 RID: 867
		// (Invoke) Token: 0x060024ED RID: 9453
		private delegate bool get_genuineCheckAvailableDelegate();

		// Token: 0x02000364 RID: 868
		// (Invoke) Token: 0x060024EF RID: 9455
		private delegate IntPtr RequestUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x02000365 RID: 869
		// (Invoke) Token: 0x060024F1 RID: 9457
		private delegate bool HasUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x02000366 RID: 870
		// (Invoke) Token: 0x060024F3 RID: 9459
		private delegate bool get_submitAnalyticsDelegate();

		// Token: 0x02000367 RID: 871
		// (Invoke) Token: 0x060024F5 RID: 9461
		private delegate NetworkReachability get_internetReachabilityDelegate();
	}
}
