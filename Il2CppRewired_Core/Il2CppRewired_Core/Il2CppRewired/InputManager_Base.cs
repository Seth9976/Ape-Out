using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Data;
using Il2CppRewired.Platforms;
using Il2CppRewired.Utils.Interfaces;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000126 RID: 294
	public class InputManager_Base : MonoBehaviour
	{
		// Token: 0x06001E14 RID: 7700 RVA: 0x0009E6A8 File Offset: 0x0009C8A8
		// Note: this type is marked as 'beforefieldinit'.
		static InputManager_Base()
		{
			Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputManager_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr);
			InputManager_Base.NativeFieldInfoPtr__dontDestroyOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "_dontDestroyOnLoad");
			InputManager_Base.NativeFieldInfoPtr__userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "_userData");
			InputManager_Base.NativeFieldInfoPtr__controllerDataFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "_controllerDataFiles");
			InputManager_Base.NativeFieldInfoPtr_isCompiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "isCompiling");
			InputManager_Base.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "hvGDCWectQgzwVNffhRCeUEVaDyy");
			InputManager_Base.NativeFieldInfoPtr_nCCNTyXaZCYHfZzBINQMJsLESHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "nCCNTyXaZCYHfZzBINQMJsLESHE");
			InputManager_Base.NativeFieldInfoPtr_editorPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "editorPlatform");
			InputManager_Base.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "platform");
			InputManager_Base.NativeFieldInfoPtr_webplayerPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "webplayerPlatform");
			InputManager_Base.NativeFieldInfoPtr_isEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "isEditor");
			InputManager_Base.NativeFieldInfoPtr__detectedPlatformInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "_detectedPlatformInEditor");
			InputManager_Base.NativeFieldInfoPtr_scriptingBackend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "scriptingBackend");
			InputManager_Base.NativeFieldInfoPtr_scriptingAPILevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "scriptingAPILevel");
			InputManager_Base.NativeFieldInfoPtr_uZodrEAfQwyAbZYKqydqlGKDHqp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "uZodrEAfQwyAbZYKqydqlGKDHqp");
			InputManager_Base.NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, "VMmRDxhNSPbrsfKODOcAglexlrh");
			InputManager_Base.NativeMethodInfoPtr_get_userData_Public_get_UserData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669839);
			InputManager_Base.NativeMethodInfoPtr_set_userData_Internal_set_Void_UserData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669840);
			InputManager_Base.NativeMethodInfoPtr_get_dataFiles_Public_get_ControllerDataFiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669841);
			InputManager_Base.NativeMethodInfoPtr_set_dataFiles_Public_set_Void_ControllerDataFiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669842);
			InputManager_Base.NativeMethodInfoPtr_get_runInEditMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669843);
			InputManager_Base.NativeMethodInfoPtr_set_runInEditMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669844);
			InputManager_Base.NativeMethodInfoPtr_get_isRunningInEditMode_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669845);
			InputManager_Base.NativeMethodInfoPtr_DontDestroyOnLoad_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669846);
			InputManager_Base.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669847);
			InputManager_Base.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669848);
			InputManager_Base.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669849);
			InputManager_Base.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669850);
			InputManager_Base.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669851);
			InputManager_Base.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669852);
			InputManager_Base.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669853);
			InputManager_Base.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669854);
			InputManager_Base.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669855);
			InputManager_Base.NativeMethodInfoPtr_OnGUIUpdate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669856);
			InputManager_Base.NativeMethodInfoPtr_DoUpdate_Internal_Void_UpdateLoopType_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669857);
			InputManager_Base.NativeMethodInfoPtr_TryStartRunInEditMode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669858);
			InputManager_Base.NativeMethodInfoPtr_TryStopRunInEditMode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669859);
			InputManager_Base.NativeMethodInfoPtr_XonaxgWaVHwqyBbpiclcsfIyFcdc_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669860);
			InputManager_Base.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669861);
			InputManager_Base.NativeMethodInfoPtr_JpbYlmHfSRgtYeOHysZqxevWWxB_Private_Object_ConfigVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669862);
			InputManager_Base.NativeMethodInfoPtr_TWwsUwjawQEOuUhEKbCrjhrWmfLs_Private_List_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669863);
			InputManager_Base.NativeMethodInfoPtr_umWCXBCzkqBJHIfTqdlVBeZkgPdz_Private_List_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669864);
			InputManager_Base.NativeMethodInfoPtr_PdtFrGhjSEDkYihghqpSUXiNEzO_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669865);
			InputManager_Base.NativeMethodInfoPtr_mTBjLXkdYdhLEnHKlMPqwdhxGmx_Private_Void_List_1_TextAsset_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669866);
			InputManager_Base.NativeMethodInfoPtr_KxuwdvaDuCNpQshKGwMeTSrwVth_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669867);
			InputManager_Base.NativeMethodInfoPtr_zhKzUWndDySFzuFMyRufceaPmEL_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669868);
			InputManager_Base.NativeMethodInfoPtr_XBZyRoBPQbFdJECkUxkGOKgNJqLj_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669869);
			InputManager_Base.NativeMethodInfoPtr_mcdIbTiZudDNTjaoosoOLqQkcKU_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669870);
			InputManager_Base.NativeMethodInfoPtr_RecompileStart_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669871);
			InputManager_Base.NativeMethodInfoPtr_RecompileEnd_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669872);
			InputManager_Base.NativeMethodInfoPtr_OnSceneLoaded_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669873);
			InputManager_Base.NativeMethodInfoPtr_wiikQiEpjWuMqfGsBlXDmiJaFBs_Private_Void_uiNYagTAaSzNgsgJeiORQecTmFp_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669874);
			InputManager_Base.NativeMethodInfoPtr_ResetAll_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669875);
			InputManager_Base.NativeMethodInfoPtr_GetEditorPlatform_Internal_EditorPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669876);
			InputManager_Base.NativeMethodInfoPtr_GetSupportedEditModeControllerTypes_Internal_Void_byref_Boolean_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669877);
			InputManager_Base.NativeMethodInfoPtr_IsEditModeSupported_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669878);
			InputManager_Base.NativeMethodInfoPtr_OnInitialized_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669879);
			InputManager_Base.NativeMethodInfoPtr_OnDeinitialized_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669880);
			InputManager_Base.NativeMethodInfoPtr_DetectPlatform_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669881);
			InputManager_Base.NativeMethodInfoPtr_CheckRecompile_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669882);
			InputManager_Base.NativeMethodInfoPtr_GetExternalTools_Protected_Abstract_Virtual_New_IExternalTools_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669883);
			InputManager_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669884);
			InputManager_Base.NativeMethodInfoPtr_AejtpkEpSPcYGnuOZIwYLTbngIL_Private_Boolean_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr, 100669885);
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0009EBB0 File Offset: 0x0009CDB0
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0009EBF0 File Offset: 0x0009CDF0
		public unsafe UserData userData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_get_userData_Public_get_UserData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserData>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_set_userData_Internal_set_Void_UserData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0009EC34 File Offset: 0x0009CE34
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x0009EC74 File Offset: 0x0009CE74
		public unsafe ControllerDataFiles dataFiles
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_get_dataFiles_Public_get_ControllerDataFiles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDataFiles>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280855, XrefRangeEnd = 280860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_set_dataFiles_Public_set_Void_ControllerDataFiles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0009ECB8 File Offset: 0x0009CEB8
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x0009ECF4 File Offset: 0x0009CEF4
		public unsafe bool runInEditMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_get_runInEditMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280860, XrefRangeEnd = 280872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_set_runInEditMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0009ED34 File Offset: 0x0009CF34
		public unsafe bool isRunningInEditMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280872, XrefRangeEnd = 280881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_get_isRunningInEditMode_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0009ED70 File Offset: 0x0009CF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280894, RefRangeEnd = 280895, XrefRangeStart = 280881, XrefRangeEnd = 280894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontDestroyOnLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_DontDestroyOnLoad_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0009EDA4 File Offset: 0x0009CFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280895, XrefRangeEnd = 280900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0009EDD8 File Offset: 0x0009CFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280900, XrefRangeEnd = 280909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0009EE0C File Offset: 0x0009D00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280909, XrefRangeEnd = 280912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0009EE40 File Offset: 0x0009D040
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 280935, RefRangeEnd = 280953, XrefRangeStart = 280912, XrefRangeEnd = 280935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0009EE74 File Offset: 0x0009D074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280953, XrefRangeEnd = 280970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool isFocused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isFocused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0009EEB4 File Offset: 0x0009D0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280970, XrefRangeEnd = 280980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0009EEE8 File Offset: 0x0009D0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280980, XrefRangeEnd = 280986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0009EF1C File Offset: 0x0009D11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280986, XrefRangeEnd = 280992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0009EF50 File Offset: 0x0009D150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280992, XrefRangeEnd = 281004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0009EF84 File Offset: 0x0009D184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281004, XrefRangeEnd = 281010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUIUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_OnGUIUpdate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0009EFB8 File Offset: 0x0009D1B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281025, RefRangeEnd = 281029, XrefRangeStart = 281010, XrefRangeEnd = 281025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoopType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoopSettingBit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_DoUpdate_Internal_Void_UpdateLoopType_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0009F004 File Offset: 0x0009D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281029, XrefRangeEnd = 281038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartRunInEditMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_TryStartRunInEditMode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0009F038 File Offset: 0x0009D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281038, XrefRangeEnd = 281039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStopRunInEditMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_TryStopRunInEditMode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0009F06C File Offset: 0x0009D26C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 281044, RefRangeEnd = 281061, XrefRangeStart = 281039, XrefRangeEnd = 281044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool XonaxgWaVHwqyBbpiclcsfIyFcdc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_XonaxgWaVHwqyBbpiclcsfIyFcdc_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0009F0A8 File Offset: 0x0009D2A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281153, RefRangeEnd = 281156, XrefRangeStart = 281061, XrefRangeEnd = 281153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dwHOFmApnpWkXreTmwZYsRXRrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0009F0DC File Offset: 0x0009D2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281156, XrefRangeEnd = 281167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Il2CppSystem.Object JpbYlmHfSRgtYeOHysZqxevWWxB(ConfigVars A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_JpbYlmHfSRgtYeOHysZqxevWWxB_Private_Object_ConfigVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0009F12C File Offset: 0x0009D32C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281235, RefRangeEnd = 281236, XrefRangeStart = 281167, XrefRangeEnd = 281235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Assembly> TWwsUwjawQEOuUhEKbCrjhrWmfLs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_TWwsUwjawQEOuUhEKbCrjhrWmfLs_Private_List_1_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Assembly>>(intPtr3) : null;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0009F16C File Offset: 0x0009D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281236, XrefRangeEnd = 281273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Assembly> umWCXBCzkqBJHIfTqdlVBeZkgPdz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_umWCXBCzkqBJHIfTqdlVBeZkgPdz_Private_List_1_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Assembly>>(intPtr3) : null;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0009F1AC File Offset: 0x0009D3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281273, XrefRangeEnd = 281300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PdtFrGhjSEDkYihghqpSUXiNEzO()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_PdtFrGhjSEDkYihghqpSUXiNEzO_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0009F1EC File Offset: 0x0009D3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281326, RefRangeEnd = 281327, XrefRangeStart = 281300, XrefRangeEnd = 281326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mTBjLXkdYdhLEnHKlMPqwdhxGmx(List<TextAsset> A_1, List<string> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_mTBjLXkdYdhLEnHKlMPqwdhxGmx_Private_Void_List_1_TextAsset_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0009F240 File Offset: 0x0009D440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281327, XrefRangeEnd = 281330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string KxuwdvaDuCNpQshKGwMeTSrwVth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_KxuwdvaDuCNpQshKGwMeTSrwVth_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0009F278 File Offset: 0x0009D478
		[CallerCount(0)]
		public unsafe bool zhKzUWndDySFzuFMyRufceaPmEL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_zhKzUWndDySFzuFMyRufceaPmEL_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0009F2B4 File Offset: 0x0009D4B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281348, RefRangeEnd = 281352, XrefRangeStart = 281330, XrefRangeEnd = 281348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string XBZyRoBPQbFdJECkUxkGOKgNJqLj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_XBZyRoBPQbFdJECkUxkGOKgNJqLj_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0009F2EC File Offset: 0x0009D4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281352, XrefRangeEnd = 281359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool mcdIbTiZudDNTjaoosoOLqQkcKU()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_mcdIbTiZudDNTjaoosoOLqQkcKU_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0009F328 File Offset: 0x0009D528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281359, XrefRangeEnd = 281372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecompileStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_RecompileStart_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0009F35C File Offset: 0x0009D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281372, XrefRangeEnd = 281374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecompileEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_RecompileEnd_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0009F390 File Offset: 0x0009D590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_OnSceneLoaded_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0009F3C4 File Offset: 0x0009D5C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281392, RefRangeEnd = 281396, XrefRangeStart = 281374, XrefRangeEnd = 281392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void wiikQiEpjWuMqfGsBlXDmiJaFBs(InputManager_Base.uiNYagTAaSzNgsgJeiORQecTmFp A_1, string A_2, Exception A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_wiikQiEpjWuMqfGsBlXDmiJaFBs_Private_Void_uiNYagTAaSzNgsgJeiORQecTmFp_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0009F428 File Offset: 0x0009D628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281396, XrefRangeEnd = 281398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_ResetAll_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0009F45C File Offset: 0x0009D65C
		[CallerCount(0)]
		public unsafe EditorPlatform GetEditorPlatform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_GetEditorPlatform_Internal_EditorPlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0009F498 File Offset: 0x0009D698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281398, XrefRangeEnd = 281400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &keyboardSupported;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mouseSupported;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &joystickSupported;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_GetSupportedEditModeControllerTypes_Internal_Void_byref_Boolean_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0009F4F4 File Offset: 0x0009D6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281400, XrefRangeEnd = 281404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEditModeSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_IsEditModeSupported_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0009F530 File Offset: 0x0009D730
		[CallerCount(0)]
		public unsafe virtual void OnInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputManager_Base.NativeMethodInfoPtr_OnInitialized_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0009F56C File Offset: 0x0009D76C
		[CallerCount(0)]
		public unsafe virtual void OnDeinitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputManager_Base.NativeMethodInfoPtr_OnDeinitialized_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0009F5A8 File Offset: 0x0009D7A8
		[CallerCount(0)]
		public unsafe virtual void DetectPlatform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputManager_Base.NativeMethodInfoPtr_DetectPlatform_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0009F5E4 File Offset: 0x0009D7E4
		[CallerCount(0)]
		public unsafe virtual void CheckRecompile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputManager_Base.NativeMethodInfoPtr_CheckRecompile_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0009F620 File Offset: 0x0009D820
		[CallerCount(0)]
		public unsafe virtual IExternalTools GetExternalTools()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputManager_Base.NativeMethodInfoPtr_GetExternalTools_Protected_Abstract_Virtual_New_IExternalTools_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IExternalTools>(intPtr3) : null;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0009F66C File Offset: 0x0009D86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputManager_Base()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0009F6A8 File Offset: 0x0009D8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281404, XrefRangeEnd = 281407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AejtpkEpSPcYGnuOZIwYLTbngIL(Assembly A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager_Base.NativeMethodInfoPtr_AejtpkEpSPcYGnuOZIwYLTbngIL_Private_Boolean_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0000C6E7 File Offset: 0x0000A8E7
		public InputManager_Base(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0009F6F8 File Offset: 0x0009D8F8
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public unsafe bool _dontDestroyOnLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__dontDestroyOnLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__dontDestroyOnLoad)) = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0009F720 File Offset: 0x0009D920
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x0000C70B File Offset: 0x0000A90B
		public unsafe UserData _userData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__userData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__userData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0009F750 File Offset: 0x0009D950
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0000C72A File Offset: 0x0000A92A
		public unsafe ControllerDataFiles _controllerDataFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__controllerDataFiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerDataFiles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__controllerDataFiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0009F780 File Offset: 0x0009D980
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0000C749 File Offset: 0x0000A949
		public unsafe bool isCompiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_isCompiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_isCompiling)) = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x0009F7A8 File Offset: 0x0009D9A8
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x0000C764 File Offset: 0x0000A964
		public unsafe bool hvGDCWectQgzwVNffhRCeUEVaDyy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy)) = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0009F7D0 File Offset: 0x0009D9D0
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0000C77F File Offset: 0x0000A97F
		public unsafe bool nCCNTyXaZCYHfZzBINQMJsLESHE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_nCCNTyXaZCYHfZzBINQMJsLESHE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_nCCNTyXaZCYHfZzBINQMJsLESHE)) = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0009F7F8 File Offset: 0x0009D9F8
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x0000C79A File Offset: 0x0000A99A
		public unsafe EditorPlatform editorPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_editorPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_editorPlatform)) = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x0009F820 File Offset: 0x0009DA20
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x0000C7B5 File Offset: 0x0000A9B5
		public unsafe Il2CppRewired.Platforms.Platform platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_platform)) = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0009F848 File Offset: 0x0009DA48
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		public unsafe WebplayerPlatform webplayerPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_webplayerPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_webplayerPlatform)) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x0009F870 File Offset: 0x0009DA70
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x0000C7EB File Offset: 0x0000A9EB
		public unsafe bool isEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_isEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_isEditor)) = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x0009F898 File Offset: 0x0009DA98
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0000C806 File Offset: 0x0000AA06
		public unsafe bool _detectedPlatformInEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__detectedPlatformInEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr__detectedPlatformInEditor)) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0009F8C0 File Offset: 0x0009DAC0
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x0000C821 File Offset: 0x0000AA21
		public unsafe ScriptingBackend scriptingBackend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_scriptingBackend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_scriptingBackend)) = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x0009F8E8 File Offset: 0x0009DAE8
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x0000C83C File Offset: 0x0000AA3C
		public unsafe ScriptingAPILevel scriptingAPILevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_scriptingAPILevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_scriptingAPILevel)) = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x0009F910 File Offset: 0x0009DB10
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x0000C857 File Offset: 0x0000AA57
		public unsafe bool uZodrEAfQwyAbZYKqydqlGKDHqp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_uZodrEAfQwyAbZYKqydqlGKDHqp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_uZodrEAfQwyAbZYKqydqlGKDHqp)) = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x0009F938 File Offset: 0x0009DB38
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x0000C872 File Offset: 0x0000AA72
		public unsafe bool VMmRDxhNSPbrsfKODOcAglexlrh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputManager_Base.NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh)) = value;
			}
		}

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeFieldInfoPtr__dontDestroyOnLoad;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeFieldInfoPtr__userData;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeFieldInfoPtr__controllerDataFiles;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeFieldInfoPtr_isCompiling;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeFieldInfoPtr_nCCNTyXaZCYHfZzBINQMJsLESHE;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr_editorPlatform;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr_platform;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr_webplayerPlatform;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr_isEditor;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeFieldInfoPtr__detectedPlatformInEditor;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeFieldInfoPtr_scriptingBackend;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeFieldInfoPtr_scriptingAPILevel;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeFieldInfoPtr_uZodrEAfQwyAbZYKqydqlGKDHqp;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_get_userData_Public_get_UserData_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_set_userData_Internal_set_Void_UserData_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_get_dataFiles_Public_get_ControllerDataFiles_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_set_dataFiles_Public_set_Void_ControllerDataFiles_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_get_runInEditMode_Public_get_Boolean_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_set_runInEditMode_Public_set_Void_Boolean_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_get_isRunningInEditMode_Internal_get_Boolean_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Internal_Void_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_OnGUIUpdate_Internal_Void_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Internal_Void_UpdateLoopType_UpdateLoopSetting_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_TryStartRunInEditMode_Internal_Void_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_TryStopRunInEditMode_Internal_Void_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_XonaxgWaVHwqyBbpiclcsfIyFcdc_Private_Boolean_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_JpbYlmHfSRgtYeOHysZqxevWWxB_Private_Object_ConfigVars_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_TWwsUwjawQEOuUhEKbCrjhrWmfLs_Private_List_1_Assembly_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_umWCXBCzkqBJHIfTqdlVBeZkgPdz_Private_List_1_Assembly_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_PdtFrGhjSEDkYihghqpSUXiNEzO_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_mTBjLXkdYdhLEnHKlMPqwdhxGmx_Private_Void_List_1_TextAsset_List_1_String_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_KxuwdvaDuCNpQshKGwMeTSrwVth_Private_String_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_zhKzUWndDySFzuFMyRufceaPmEL_Private_Boolean_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_XBZyRoBPQbFdJECkUxkGOKgNJqLj_Private_String_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_mcdIbTiZudDNTjaoosoOLqQkcKU_Private_Boolean_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_RecompileStart_Protected_Void_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_RecompileEnd_Protected_Void_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneLoaded_Protected_Void_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_wiikQiEpjWuMqfGsBlXDmiJaFBs_Private_Void_uiNYagTAaSzNgsgJeiORQecTmFp_String_Exception_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_ResetAll_Internal_Void_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_GetEditorPlatform_Internal_EditorPlatform_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_GetSupportedEditModeControllerTypes_Internal_Void_byref_Boolean_byref_Boolean_byref_Boolean_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_IsEditModeSupported_Internal_Boolean_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_OnDeinitialized_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_DetectPlatform_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_CheckRecompile_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_GetExternalTools_Protected_Abstract_Virtual_New_IExternalTools_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_AejtpkEpSPcYGnuOZIwYLTbngIL_Private_Boolean_Assembly_0;

		// Token: 0x0200033C RID: 828
		[OriginalName("Rewired_Core.dll", "", "uiNYagTAaSzNgsgJeiORQecTmFp")]
		public enum uiNYagTAaSzNgsgJeiORQecTmFp
		{
			// Token: 0x04003922 RID: 14626
			AWpBHWJjSQNhbfMQaEKGJTzvNIdG,
			// Token: 0x04003923 RID: 14627
			xozDTcGUrsCTUDmjINWIvPSceAOJ,
			// Token: 0x04003924 RID: 14628
			YiVgBkjsDaQfFayyOxYvgPqUSGH
		}
	}
}
