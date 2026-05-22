using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Platforms.Custom;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.InputManagers
{
	// Token: 0x02000133 RID: 307
	public class CustomInputManager : PlatformInputManager
	{
		// Token: 0x0600210E RID: 8462 RVA: 0x000AA994 File Offset: 0x000A8B94
		// Note: this type is marked as 'beforefieldinit'.
		static CustomInputManager()
		{
			Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.InputManagers", "CustomInputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr);
			CustomInputManager.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "fHwvAEhSaXstIllfGXDtviCPUrg");
			CustomInputManager.NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "CdrTrRnhhmWjNgGjeGdDpUWMveb");
			CustomInputManager.NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "iMzsUxaYTPYpPsSFUuSxcKuRSqt");
			CustomInputManager.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "QupTlkbJPCSxpgHQnsUQVuFrjWa");
			CustomInputManager.NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "xZDEMoVOFmiFBYuSsQfkKtLaLbQ");
			CustomInputManager.NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "njnaoHoZTSJVhLZqASqYiMaJIAHG");
			CustomInputManager.NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "uttMJqcLfYdWZEQhIkhkhdPemTU");
			CustomInputManager.NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "atncmCoGisOlrDPqOnJLZGsHPEk");
			CustomInputManager.NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "KBBgQNqLExsQOICFAVdFQGIYFoT");
			CustomInputManager.NativeFieldInfoPtr_FxaXGzCMEHRYZVWiFXczgKzVeyf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "FxaXGzCMEHRYZVWiFXczgKzVeyf");
			CustomInputManager.NativeMethodInfoPtr__ctor_Public_Void_CustomInputSource_UpdateLoopSetting_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670393);
			CustomInputManager.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670394);
			CustomInputManager.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670395);
			CustomInputManager.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670396);
			CustomInputManager.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670397);
			CustomInputManager.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670398);
			CustomInputManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670399);
			CustomInputManager.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670400);
			CustomInputManager.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670401);
			CustomInputManager.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670402);
			CustomInputManager.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670403);
			CustomInputManager.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670404);
			CustomInputManager.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670405);
			CustomInputManager.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670406);
			CustomInputManager.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670407);
			CustomInputManager.NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_Il2CppReferenceArray_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670408);
			CustomInputManager.NativeMethodInfoPtr_CYMTdwZEujCBzigVpVwyCVHtOio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670409);
			CustomInputManager.NativeMethodInfoPtr_npuwLbSwaaIrUMtbELGugIiFNhB_Private_Void_Int32_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670410);
			CustomInputManager.NativeMethodInfoPtr_SbTxlMbPMbjoEFicmunSODRqAQFD_Private_Void_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670411);
			CustomInputManager.NativeMethodInfoPtr_ASuIuyBFSvdYeAgwTaJnBGRjuQHL_Private_Boolean_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670412);
			CustomInputManager.NativeMethodInfoPtr_UDWHjnSyMZKbhIFnGWsdjiueESP_Private_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670413);
			CustomInputManager.NativeMethodInfoPtr_GTnGvKfWEYaobbuLbGFnPGKXpLuA_Private_Boolean_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670414);
			CustomInputManager.NativeMethodInfoPtr_vyUowQdRezXsfxwJKwKhJJVnur_Private_Void_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670415);
			CustomInputManager.NativeMethodInfoPtr_dHsEAPVegRQRxTpKyLfYlrRGvre_Private_Void_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670416);
			CustomInputManager.NativeMethodInfoPtr_fGWkPYrUUhFvFOGhHEIGJtIovJyu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670417);
			CustomInputManager.NativeMethodInfoPtr_IgmHzNwnqNAoWHJUREsXazjvxbg_Private_Boolean_Il2CppReferenceArray_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670418);
			CustomInputManager.NativeMethodInfoPtr_mDteeyrByOxveqHHaIoAxNtXWPy_Private_Void_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670419);
			CustomInputManager.NativeMethodInfoPtr_YoZFtSbXMAgtlDhkFDzNhVzexdkQ_Private_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670420);
			CustomInputManager.NativeMethodInfoPtr_vTsBUvJVaLExwHfGWhZiSIQGNmV_Private_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, 100670421);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000AACD0 File Offset: 0x000A8ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285621, XrefRangeEnd = 285636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomInputManager(CustomInputSource customInputSource, UpdateLoopSetting updateLoopSetting, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customInputSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoopSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getNewJoystickId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr__ctor_Public_Void_CustomInputSource_UpdateLoopSetting_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000AAD50 File Offset: 0x000A8F50
		public unsafe override int deviceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x000AAD98 File Offset: 0x000A8F98
		public unsafe override PlatformInputManager primaryInputManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000AADE4 File Offset: 0x000A8FE4
		public unsafe override IInputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x000AAE30 File Offset: 0x000A9030
		public unsafe override InputSource inputSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000AAE78 File Offset: 0x000A9078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285636, XrefRangeEnd = 285651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000AAEB4 File Offset: 0x000A90B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285651, XrefRangeEnd = 285657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000AAF00 File Offset: 0x000A9100
		[CallerCount(0)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000AAF3C File Offset: 0x000A913C
		[CallerCount(0)]
		public unsafe override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr3) : null;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000AAF88 File Offset: 0x000A9188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285657, XrefRangeEnd = 285669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputManagerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000AAFE4 File Offset: 0x000A91E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285669, XrefRangeEnd = 285670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000AB020 File Offset: 0x000A9220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285670, XrefRangeEnd = 285671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000AB05C File Offset: 0x000A925C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnityJoystickId(int joystickId, int unityJoystickIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000AB0B4 File Offset: 0x000A92B4
		[CallerCount(0)]
		public unsafe override IUnifiedMouseSource GetUnifiedMouseSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr3) : null;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000AB100 File Offset: 0x000A9300
		[CallerCount(0)]
		public unsafe override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputManager.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr3) : null;
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000AB14C File Offset: 0x000A934C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285710, RefRangeEnd = 285712, XrefRangeStart = 285671, XrefRangeEnd = 285710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fMlXvfEhQMkjVaHKyHzuIdFPqib(Il2CppReferenceArray<CustomInputSource.Joystick> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_Il2CppReferenceArray_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000AB190 File Offset: 0x000A9390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285712, XrefRangeEnd = 285715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CYMTdwZEujCBzigVpVwyCVHtOio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_CYMTdwZEujCBzigVpVwyCVHtOio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000AB1C4 File Offset: 0x000A93C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285748, RefRangeEnd = 285749, XrefRangeStart = 285715, XrefRangeEnd = 285748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void npuwLbSwaaIrUMtbELGugIiFNhB(int A_1, int A_2, List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_3, List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_npuwLbSwaaIrUMtbELGugIiFNhB_Private_Void_Int32_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000AB238 File Offset: 0x000A9438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285749, XrefRangeEnd = 285751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SbTxlMbPMbjoEFicmunSODRqAQFD(List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_1, int A_2, int A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_SbTxlMbPMbjoEFicmunSODRqAQFD_Private_Void_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x000AB298 File Offset: 0x000A9498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285753, RefRangeEnd = 285754, XrefRangeStart = 285751, XrefRangeEnd = 285753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ASuIuyBFSvdYeAgwTaJnBGRjuQHL(List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_ASuIuyBFSvdYeAgwTaJnBGRjuQHL_Private_Boolean_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000AB2F4 File Offset: 0x000A94F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285756, RefRangeEnd = 285757, XrefRangeStart = 285754, XrefRangeEnd = 285756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UDWHjnSyMZKbhIFnGWsdjiueESP(List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_UDWHjnSyMZKbhIFnGWsdjiueESP_Private_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000AB344 File Offset: 0x000A9544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285760, RefRangeEnd = 285761, XrefRangeStart = 285757, XrefRangeEnd = 285760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GTnGvKfWEYaobbuLbGFnPGKXpLuA(List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_GTnGvKfWEYaobbuLbGFnPGKXpLuA_Private_Boolean_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000AB3A0 File Offset: 0x000A95A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285767, RefRangeEnd = 285769, XrefRangeStart = 285761, XrefRangeEnd = 285767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vyUowQdRezXsfxwJKwKhJJVnur(int A_1, List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_2, int A_3, List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_4, CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_vyUowQdRezXsfxwJKwKhJJVnur_Private_Void_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000AB420 File Offset: 0x000A9620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285788, RefRangeEnd = 285790, XrefRangeStart = 285769, XrefRangeEnd = 285788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dHsEAPVegRQRxTpKyLfYlrRGvre(int A_1, List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_2, CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_dHsEAPVegRQRxTpKyLfYlrRGvre_Private_Void_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000AB480 File Offset: 0x000A9680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285790, XrefRangeEnd = 285793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fGWkPYrUUhFvFOGhHEIGJtIovJyu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_fGWkPYrUUhFvFOGhHEIGJtIovJyu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000AB4B4 File Offset: 0x000A96B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285797, RefRangeEnd = 285799, XrefRangeStart = 285793, XrefRangeEnd = 285797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IgmHzNwnqNAoWHJUREsXazjvxbg(Il2CppReferenceArray<CustomInputSource.Joystick> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_IgmHzNwnqNAoWHJUREsXazjvxbg_Private_Boolean_Il2CppReferenceArray_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000AB504 File Offset: 0x000A9704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285799, XrefRangeEnd = 285803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mDteeyrByOxveqHHaIoAxNtXWPy(List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_1, List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> A_2, bool A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_mDteeyrByOxveqHHaIoAxNtXWPy_Private_Void_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000AB568 File Offset: 0x000A9768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285814, RefRangeEnd = 285816, XrefRangeStart = 285803, XrefRangeEnd = 285814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YoZFtSbXMAgtlDhkFDzNhVzexdkQ(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_YoZFtSbXMAgtlDhkFDzNhVzexdkQ_Private_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000AB5B8 File Offset: 0x000A97B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285816, XrefRangeEnd = 285826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vTsBUvJVaLExwHfGWhZiSIQGNmV(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.NativeMethodInfoPtr_vTsBUvJVaLExwHfGWhZiSIQGNmV_Private_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0000D62C File Offset: 0x0000B82C
		public CustomInputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000AB608 File Offset: 0x000A9808
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x0000D635 File Offset: 0x0000B835
		public unsafe List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT> fHwvAEhSaXstIllfGXDtviCPUrg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000AB638 File Offset: 0x000A9838
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0000D654 File Offset: 0x0000B854
		public unsafe int CdrTrRnhhmWjNgGjeGdDpUWMveb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb)) = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000AB660 File Offset: 0x000A9860
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0000D66F File Offset: 0x0000B86F
		public unsafe CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC iMzsUxaYTPYpPsSFUuSxcKuRSqt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000AB690 File Offset: 0x000A9890
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000D68E File Offset: 0x0000B88E
		public unsafe UpdateLoopType QupTlkbJPCSxpgHQnsUQVuFrjWa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa)) = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000AB6B8 File Offset: 0x000A98B8
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000D6A9 File Offset: 0x0000B8A9
		public unsafe Action<int, ControllerDataUpdater> xZDEMoVOFmiFBYuSsQfkKtLaLbQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000AB6E8 File Offset: 0x000A98E8
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		public unsafe PlatformInputManager njnaoHoZTSJVhLZqASqYiMaJIAHG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000AB718 File Offset: 0x000A9918
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000D6E7 File Offset: 0x0000B8E7
		public unsafe CustomInputSource uttMJqcLfYdWZEQhIkhkhdPemTU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000AB748 File Offset: 0x000A9948
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000D706 File Offset: 0x0000B906
		public unsafe bool atncmCoGisOlrDPqOnJLZGsHPEk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk)) = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000AB770 File Offset: 0x000A9970
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x0000D721 File Offset: 0x0000B921
		public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> KBBgQNqLExsQOICFAVdFQGIYFoT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000AB7A0 File Offset: 0x000A99A0
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x0000D740 File Offset: 0x0000B940
		public unsafe Func<int> FxaXGzCMEHRYZVWiFXczgKzVeyf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_FxaXGzCMEHRYZVWiFXczgKzVeyf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.NativeFieldInfoPtr_FxaXGzCMEHRYZVWiFXczgKzVeyf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeFieldInfoPtr_FxaXGzCMEHRYZVWiFXczgKzVeyf;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomInputSource_UpdateLoopSetting_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_Il2CppReferenceArray_1_Joystick_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_CYMTdwZEujCBzigVpVwyCVHtOio_Private_Void_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_npuwLbSwaaIrUMtbELGugIiFNhB_Private_Void_Int32_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_SbTxlMbPMbjoEFicmunSODRqAQFD_Private_Void_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_Int32_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_ASuIuyBFSvdYeAgwTaJnBGRjuQHL_Private_Boolean_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_UDWHjnSyMZKbhIFnGWsdjiueESP_Private_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_GTnGvKfWEYaobbuLbGFnPGKXpLuA_Private_Boolean_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_vyUowQdRezXsfxwJKwKhJJVnur_Private_Void_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_dHsEAPVegRQRxTpKyLfYlrRGvre_Private_Void_Int32_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_fGWkPYrUUhFvFOGhHEIGJtIovJyu_Private_Void_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_IgmHzNwnqNAoWHJUREsXazjvxbg_Private_Boolean_Il2CppReferenceArray_1_Joystick_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_mDteeyrByOxveqHHaIoAxNtXWPy_Private_Void_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_List_1_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_YoZFtSbXMAgtlDhkFDzNhVzexdkQ_Private_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_vTsBUvJVaLExwHfGWhZiSIQGNmV_Private_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_Boolean_0;

		// Token: 0x0200035A RID: 858
		public class KiqJQMbxOBuxPvYVtxIuneAPeNT : Object
		{
			// Token: 0x060046AD RID: 18093 RVA: 0x00147D44 File Offset: 0x00145F44
			// Note: this type is marked as 'beforefieldinit'.
			static KiqJQMbxOBuxPvYVtxIuneAPeNT()
			{
				Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "KiqJQMbxOBuxPvYVtxIuneAPeNT");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "tamJGhaDrwcqghjueRIJXoQsGYe");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "uttMJqcLfYdWZEQhIkhkhdPemTU");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "sZKOvZaohDAzdPVObwABOvwFgQN");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "crvdwvKXoXisViNJVdYkAthcLjLI");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "pZWfHBsUrEAGDEjTkfpYhyBeTnjl");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "gvXnpGAuHOwyyLxuGQastVwuaHQ");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "pqTtSCngKtHengXqufyfMylPsXx");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "mseEbqKiQaLIYtAxXbJUlqWUGxJX");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_sISrYvnWommyRozqFjxbdKzpeHh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "sISrYvnWommyRozqFjxbdKzpeHh");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_SoPbgUcviXTbvEAGDncQljncILZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "SoPbgUcviXTbvEAGDncQljncILZ");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "yHQIcUwPwDJrWehFwcGOARwxPjqk");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "fSxjFgmrrcJImiPcAahGHVTZRLqI");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "cPjEJkrEhDhuJdcyzrFQgPXblWVD");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "SoTQrZQCFIhWMAdvVQDKOQzBDyH");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "iNsxDqPHPTqhYqUYyDyQzTlxlTE");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_BWlTpNqHTVLoRoCLeGfURlMHoTq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "BWlTpNqHTVLoRoCLeGfURlMHoTq");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "qgsitxtkbBVwoGBdsBDloWoQJaF");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, "KBBgQNqLExsQOICFAVdFQGIYFoT");
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_hardwareButtonCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670422);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_hardwareAxisCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670423);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670424);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670425);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670426);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670427);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670428);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670429);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670430);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670431);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670432);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670433);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670434);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670435);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr__ctor_Public_Void_CustomInputSource_Nullable_1_Int64_Int32_Joystick_InputSource_Extension_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670436);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_yBrYeUxifbbrwCEIrxFURhlDbvk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670437);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670438);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670439);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670440);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670441);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670442);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_kqnbjAvRtSTjtQCzpAMBiybuUGpi_Public_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670443);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670444);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670445);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_zxqRxkJsyHvgUlYXlmVgsyIPGmZ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670446);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670447);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670448);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_gxoSeeRWiLOZPArwxbwxXkkYHXA_Private_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670449);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670450);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670451);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670452);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_yTgniHEdrsAvSWhkDJlxBFPFDUV_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670453);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_CfbXJvTwTDCGpDyvhutZklklBeuE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670454);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_cDxLVOxKafYQBWeXXmcNpOCwNoW_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670455);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_JpSubverIoQGOzqJJrfnnJIlmSh_Public_Static_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_KiqJQMbxOBuxPvYVtxIuneAPeNT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670456);
				CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_eQADvpcGTIbGLYfwFzEyJBrRYKF_Public_Static_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_KiqJQMbxOBuxPvYVtxIuneAPeNT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr, 100670457);
			}

			// Token: 0x17001610 RID: 5648
			// (get) Token: 0x060046AE RID: 18094 RVA: 0x001481A8 File Offset: 0x001463A8
			public unsafe int FgDAICasOxrXytbHHIHnbKtAFKka
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_hardwareButtonCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001611 RID: 5649
			// (get) Token: 0x060046AF RID: 18095 RVA: 0x001481E4 File Offset: 0x001463E4
			public unsafe int QqegAawzYBskKLHXHDzdZmtIjWg
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_hardwareAxisCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001612 RID: 5650
			// (get) Token: 0x060046B0 RID: 18096 RVA: 0x00148220 File Offset: 0x00146420
			// (set) Token: 0x060046B1 RID: 18097 RVA: 0x0014825C File Offset: 0x0014645C
			public unsafe virtual int rewiredId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001613 RID: 5651
			// (get) Token: 0x060046B2 RID: 18098 RVA: 0x0014829C File Offset: 0x0014649C
			// (set) Token: 0x060046B3 RID: 18099 RVA: 0x001482D8 File Offset: 0x001464D8
			public unsafe virtual int inputManagerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001614 RID: 5652
			// (get) Token: 0x060046B4 RID: 18100 RVA: 0x00148318 File Offset: 0x00146518
			public unsafe virtual string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285406, XrefRangeEnd = 285408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001615 RID: 5653
			// (get) Token: 0x060046B5 RID: 18101 RVA: 0x00148350 File Offset: 0x00146550
			public unsafe virtual Nullable<long> systemId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
			}

			// Token: 0x17001616 RID: 5654
			// (get) Token: 0x060046B6 RID: 18102 RVA: 0x00148388 File Offset: 0x00146588
			public unsafe virtual int unityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001617 RID: 5655
			// (get) Token: 0x060046B7 RID: 18103 RVA: 0x001483C4 File Offset: 0x001465C4
			public unsafe virtual Guid instanceGuid
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 285421, RefRangeEnd = 285422, XrefRangeStart = 285408, XrefRangeEnd = 285421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001618 RID: 5656
			// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00148400 File Offset: 0x00146600
			public unsafe virtual Guid persistentGuid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285422, XrefRangeEnd = 285423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001619 RID: 5657
			// (get) Token: 0x060046B9 RID: 18105 RVA: 0x0014843C File Offset: 0x0014663C
			public unsafe virtual Controller.Extension extension
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
				}
			}

			// Token: 0x060046BA RID: 18106 RVA: 0x0014847C File Offset: 0x0014667C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetVibration(float amount, int motorIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref amount;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046BB RID: 18107 RVA: 0x001484C8 File Offset: 0x001466C8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void StopVibration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046BC RID: 18108 RVA: 0x001484FC File Offset: 0x001466FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285443, RefRangeEnd = 285444, XrefRangeStart = 285423, XrefRangeEnd = 285443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KiqJQMbxOBuxPvYVtxIuneAPeNT(CustomInputSource customInputSource, Nullable<long> systemJoystickId, int unityJoystickId, CustomInputSource.Joystick joystick, InputSource inputSource, Controller.Extension controllerExtension, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(customInputSource);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(systemJoystickId));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerExtension);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr__ctor_Public_Void_CustomInputSource_Nullable_1_Int64_Int32_Joystick_InputSource_Extension_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046BD RID: 18109 RVA: 0x001485B4 File Offset: 0x001467B4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285444, RefRangeEnd = 285447, XrefRangeStart = 285444, XrefRangeEnd = 285444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void yBrYeUxifbbrwCEIrxFURhlDbvk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_yBrYeUxifbbrwCEIrxFURhlDbvk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046BE RID: 18110 RVA: 0x001485E8 File Offset: 0x001467E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285447, XrefRangeEnd = 285449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046BF RID: 18111 RVA: 0x0014861C File Offset: 0x0014681C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285451, RefRangeEnd = 285452, XrefRangeStart = 285449, XrefRangeEnd = 285451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int fvOGAoKxBgCUFQBmLBDvnCAQduEb(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046C0 RID: 18112 RVA: 0x0014866C File Offset: 0x0014686C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 285453, RefRangeEnd = 285457, XrefRangeStart = 285452, XrefRangeEnd = 285453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VnPWGNfJWhtnojiDNiUfGdFQHpgB(BridgedControllerHWInfo A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060046C1 RID: 18113 RVA: 0x001486B0 File Offset: 0x001468B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 285459, RefRangeEnd = 285461, XrefRangeStart = 285457, XrefRangeEnd = 285459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VnPWGNfJWhtnojiDNiUfGdFQHpgB(BridgedController A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060046C2 RID: 18114 RVA: 0x001486F4 File Offset: 0x001468F4
			[CallerCount(0)]
			public unsafe virtual void FillData(ControllerDataUpdater dataUpdater)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060046C3 RID: 18115 RVA: 0x00148738 File Offset: 0x00146938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285461, XrefRangeEnd = 285465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BridgedControllerHWInfo kqnbjAvRtSTjtQCzpAMBiybuUGpi()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_kqnbjAvRtSTjtQCzpAMBiybuUGpi_Public_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedControllerHWInfo>(intPtr3) : null;
			}

			// Token: 0x060046C4 RID: 18116 RVA: 0x00148778 File Offset: 0x00146978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285465, XrefRangeEnd = 285469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual BridgedController ToBridgedController()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedController>(intPtr3) : null;
			}

			// Token: 0x060046C5 RID: 18117 RVA: 0x001487B8 File Offset: 0x001469B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285469, XrefRangeEnd = 285475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDisconnectedEventArgs>(intPtr3) : null;
			}

			// Token: 0x060046C6 RID: 18118 RVA: 0x001487F8 File Offset: 0x001469F8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 285479, RefRangeEnd = 285483, XrefRangeStart = 285475, XrefRangeEnd = 285479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void zxqRxkJsyHvgUlYXlmVgsyIPGmZ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_zxqRxkJsyHvgUlYXlmVgsyIPGmZ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046C7 RID: 18119 RVA: 0x0014882C File Offset: 0x00146A2C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 285487, RefRangeEnd = 285491, XrefRangeStart = 285483, XrefRangeEnd = 285487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QLZdJmwnUkddZisUnLmixtMACSh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046C8 RID: 18120 RVA: 0x00148860 File Offset: 0x00146A60
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285491, RefRangeEnd = 285492, XrefRangeStart = 285491, XrefRangeEnd = 285491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TKtEoSLnkmsQpmZzujyGAymhyus(HardwareJoystickMap.Platform_Custom.Button A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046C9 RID: 18121 RVA: 0x001488B0 File Offset: 0x00146AB0
			[CallerCount(0)]
			public unsafe bool gxoSeeRWiLOZPArwxbwxXkkYHXA(float A_1, float A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_gxoSeeRWiLOZPArwxbwxXkkYHXA_Private_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060046CA RID: 18122 RVA: 0x00148908 File Offset: 0x00146B08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285492, RefRangeEnd = 285493, XrefRangeStart = 285492, XrefRangeEnd = 285492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float xoaCMtlomZHQljcaODELNvyPMyxM(HardwareJoystickMap.Platform_Custom.Axis A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046CB RID: 18123 RVA: 0x00148958 File Offset: 0x00146B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285493, XrefRangeEnd = 285494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float xoaCMtlomZHQljcaODELNvyPMyxM(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046CC RID: 18124 RVA: 0x001489A4 File Offset: 0x00146BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285494, XrefRangeEnd = 285495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TKtEoSLnkmsQpmZzujyGAymhyus(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046CD RID: 18125 RVA: 0x001489F0 File Offset: 0x00146BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285495, XrefRangeEnd = 285503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void yTgniHEdrsAvSWhkDJlxBFPFDUV()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_yTgniHEdrsAvSWhkDJlxBFPFDUV_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046CE RID: 18126 RVA: 0x00148A24 File Offset: 0x00146C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285503, XrefRangeEnd = 285506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CfbXJvTwTDCGpDyvhutZklklBeuE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_CfbXJvTwTDCGpDyvhutZklklBeuE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046CF RID: 18127 RVA: 0x00148A58 File Offset: 0x00146C58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285558, RefRangeEnd = 285559, XrefRangeStart = 285506, XrefRangeEnd = 285558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string cDxLVOxKafYQBWeXXmcNpOCwNoW()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_cDxLVOxKafYQBWeXXmcNpOCwNoW_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060046D0 RID: 18128 RVA: 0x00148A90 File Offset: 0x00146C90
			[CallerCount(0)]
			public unsafe static int JpSubverIoQGOzqJJrfnnJIlmSh(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_0, CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_JpSubverIoQGOzqJJrfnnJIlmSh_Public_Static_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_KiqJQMbxOBuxPvYVtxIuneAPeNT_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060046D1 RID: 18129 RVA: 0x00148AE4 File Offset: 0x00146CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285559, XrefRangeEnd = 285561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int eQADvpcGTIbGLYfwFzEyJBrRYKF(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_0, CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeMethodInfoPtr_eQADvpcGTIbGLYfwFzEyJBrRYKF_Public_Static_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_KiqJQMbxOBuxPvYVtxIuneAPeNT_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060046D2 RID: 18130 RVA: 0x0001995F File Offset: 0x00017B5F
			public KiqJQMbxOBuxPvYVtxIuneAPeNT(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015FE RID: 5630
			// (get) Token: 0x060046D3 RID: 18131 RVA: 0x00148B38 File Offset: 0x00146D38
			// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00019968 File Offset: 0x00017B68
			public unsafe InputSource tamJGhaDrwcqghjueRIJXoQsGYe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe)) = value;
				}
			}

			// Token: 0x170015FF RID: 5631
			// (get) Token: 0x060046D5 RID: 18133 RVA: 0x00148B60 File Offset: 0x00146D60
			// (set) Token: 0x060046D6 RID: 18134 RVA: 0x00019983 File Offset: 0x00017B83
			public unsafe CustomInputSource uttMJqcLfYdWZEQhIkhkhdPemTU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001600 RID: 5632
			// (get) Token: 0x060046D7 RID: 18135 RVA: 0x00148B90 File Offset: 0x00146D90
			// (set) Token: 0x060046D8 RID: 18136 RVA: 0x000199A2 File Offset: 0x00017BA2
			public unsafe Controller.Extension sZKOvZaohDAzdPVObwABOvwFgQN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001601 RID: 5633
			// (get) Token: 0x060046D9 RID: 18137 RVA: 0x00148BC0 File Offset: 0x00146DC0
			// (set) Token: 0x060046DA RID: 18138 RVA: 0x000199C1 File Offset: 0x00017BC1
			public unsafe int crvdwvKXoXisViNJVdYkAthcLjLI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI)) = value;
				}
			}

			// Token: 0x17001602 RID: 5634
			// (get) Token: 0x060046DB RID: 18139 RVA: 0x00148BE8 File Offset: 0x00146DE8
			// (set) Token: 0x060046DC RID: 18140 RVA: 0x000199DC File Offset: 0x00017BDC
			public unsafe int pZWfHBsUrEAGDEjTkfpYhyBeTnjl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl)) = value;
				}
			}

			// Token: 0x17001603 RID: 5635
			// (get) Token: 0x060046DD RID: 18141 RVA: 0x00148C10 File Offset: 0x00146E10
			// (set) Token: 0x060046DE RID: 18142 RVA: 0x000199F7 File Offset: 0x00017BF7
			public Nullable<long> gvXnpGAuHOwyyLxuGQastVwuaHQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ);
					return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001604 RID: 5636
			// (get) Token: 0x060046DF RID: 18143 RVA: 0x00148C40 File Offset: 0x00146E40
			// (set) Token: 0x060046E0 RID: 18144 RVA: 0x00019A25 File Offset: 0x00017C25
			public unsafe int pqTtSCngKtHengXqufyfMylPsXx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx)) = value;
				}
			}

			// Token: 0x17001605 RID: 5637
			// (get) Token: 0x060046E1 RID: 18145 RVA: 0x00148C68 File Offset: 0x00146E68
			// (set) Token: 0x060046E2 RID: 18146 RVA: 0x00019A40 File Offset: 0x00017C40
			public unsafe Guid mseEbqKiQaLIYtAxXbJUlqWUGxJX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX)) = value;
				}
			}

			// Token: 0x17001606 RID: 5638
			// (get) Token: 0x060046E3 RID: 18147 RVA: 0x00148C90 File Offset: 0x00146E90
			// (set) Token: 0x060046E4 RID: 18148 RVA: 0x00019A5B File Offset: 0x00017C5B
			public unsafe string sISrYvnWommyRozqFjxbdKzpeHh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_sISrYvnWommyRozqFjxbdKzpeHh);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_sISrYvnWommyRozqFjxbdKzpeHh), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001607 RID: 5639
			// (get) Token: 0x060046E5 RID: 18149 RVA: 0x00148CB8 File Offset: 0x00146EB8
			// (set) Token: 0x060046E6 RID: 18150 RVA: 0x00019A7A File Offset: 0x00017C7A
			public unsafe string SoPbgUcviXTbvEAGDncQljncILZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_SoPbgUcviXTbvEAGDncQljncILZ);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_SoPbgUcviXTbvEAGDncQljncILZ), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001608 RID: 5640
			// (get) Token: 0x060046E7 RID: 18151 RVA: 0x00148CE0 File Offset: 0x00146EE0
			// (set) Token: 0x060046E8 RID: 18152 RVA: 0x00019A99 File Offset: 0x00017C99
			public unsafe int yHQIcUwPwDJrWehFwcGOARwxPjqk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk)) = value;
				}
			}

			// Token: 0x17001609 RID: 5641
			// (get) Token: 0x060046E9 RID: 18153 RVA: 0x00148D08 File Offset: 0x00146F08
			// (set) Token: 0x060046EA RID: 18154 RVA: 0x00019AB4 File Offset: 0x00017CB4
			public unsafe int fSxjFgmrrcJImiPcAahGHVTZRLqI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI)) = value;
				}
			}

			// Token: 0x1700160A RID: 5642
			// (get) Token: 0x060046EB RID: 18155 RVA: 0x00148D30 File Offset: 0x00146F30
			// (set) Token: 0x060046EC RID: 18156 RVA: 0x00019ACF File Offset: 0x00017CCF
			public unsafe Il2CppStructArray<float> cPjEJkrEhDhuJdcyzrFQgPXblWVD
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160B RID: 5643
			// (get) Token: 0x060046ED RID: 18157 RVA: 0x00148D60 File Offset: 0x00146F60
			// (set) Token: 0x060046EE RID: 18158 RVA: 0x00019AEE File Offset: 0x00017CEE
			public unsafe Il2CppStructArray<bool> SoTQrZQCFIhWMAdvVQDKOQzBDyH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160C RID: 5644
			// (get) Token: 0x060046EF RID: 18159 RVA: 0x00148D90 File Offset: 0x00146F90
			// (set) Token: 0x060046F0 RID: 18160 RVA: 0x00019B0D File Offset: 0x00017D0D
			public unsafe HardwareJoystickMap_InputManager iNsxDqPHPTqhYqUYyDyQzTlxlTE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160D RID: 5645
			// (get) Token: 0x060046F1 RID: 18161 RVA: 0x00148DC0 File Offset: 0x00146FC0
			// (set) Token: 0x060046F2 RID: 18162 RVA: 0x00019B2C File Offset: 0x00017D2C
			public unsafe CustomInputSource.Joystick BWlTpNqHTVLoRoCLeGfURlMHoTq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_BWlTpNqHTVLoRoCLeGfURlMHoTq);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputSource.Joystick>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_BWlTpNqHTVLoRoCLeGfURlMHoTq), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160E RID: 5646
			// (get) Token: 0x060046F3 RID: 18163 RVA: 0x00148DF0 File Offset: 0x00146FF0
			// (set) Token: 0x060046F4 RID: 18164 RVA: 0x00019B4B File Offset: 0x00017D4B
			public unsafe bool qgsitxtkbBVwoGBdsBDloWoQJaF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF)) = value;
				}
			}

			// Token: 0x1700160F RID: 5647
			// (get) Token: 0x060046F5 RID: 18165 RVA: 0x00148E18 File Offset: 0x00147018
			// (set) Token: 0x060046F6 RID: 18166 RVA: 0x00019B66 File Offset: 0x00017D66
			public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> KBBgQNqLExsQOICFAVdFQGIYFoT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT.NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039A3 RID: 14755
			private static readonly IntPtr NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe;

			// Token: 0x040039A4 RID: 14756
			private static readonly IntPtr NativeFieldInfoPtr_uttMJqcLfYdWZEQhIkhkhdPemTU;

			// Token: 0x040039A5 RID: 14757
			private static readonly IntPtr NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN;

			// Token: 0x040039A6 RID: 14758
			private static readonly IntPtr NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI;

			// Token: 0x040039A7 RID: 14759
			private static readonly IntPtr NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl;

			// Token: 0x040039A8 RID: 14760
			private static readonly IntPtr NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ;

			// Token: 0x040039A9 RID: 14761
			private static readonly IntPtr NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx;

			// Token: 0x040039AA RID: 14762
			private static readonly IntPtr NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX;

			// Token: 0x040039AB RID: 14763
			private static readonly IntPtr NativeFieldInfoPtr_sISrYvnWommyRozqFjxbdKzpeHh;

			// Token: 0x040039AC RID: 14764
			private static readonly IntPtr NativeFieldInfoPtr_SoPbgUcviXTbvEAGDncQljncILZ;

			// Token: 0x040039AD RID: 14765
			private static readonly IntPtr NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk;

			// Token: 0x040039AE RID: 14766
			private static readonly IntPtr NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI;

			// Token: 0x040039AF RID: 14767
			private static readonly IntPtr NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD;

			// Token: 0x040039B0 RID: 14768
			private static readonly IntPtr NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH;

			// Token: 0x040039B1 RID: 14769
			private static readonly IntPtr NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE;

			// Token: 0x040039B2 RID: 14770
			private static readonly IntPtr NativeFieldInfoPtr_BWlTpNqHTVLoRoCLeGfURlMHoTq;

			// Token: 0x040039B3 RID: 14771
			private static readonly IntPtr NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF;

			// Token: 0x040039B4 RID: 14772
			private static readonly IntPtr NativeFieldInfoPtr_KBBgQNqLExsQOICFAVdFQGIYFoT;

			// Token: 0x040039B5 RID: 14773
			private static readonly IntPtr NativeMethodInfoPtr_get_hardwareButtonCount_Public_get_Int32_0;

			// Token: 0x040039B6 RID: 14774
			private static readonly IntPtr NativeMethodInfoPtr_get_hardwareAxisCount_Public_get_Int32_0;

			// Token: 0x040039B7 RID: 14775
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040039B8 RID: 14776
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0;

			// Token: 0x040039B9 RID: 14777
			private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040039BA RID: 14778
			private static readonly IntPtr NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0;

			// Token: 0x040039BB RID: 14779
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040039BC RID: 14780
			private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0;

			// Token: 0x040039BD RID: 14781
			private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040039BE RID: 14782
			private static readonly IntPtr NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x040039BF RID: 14783
			private static readonly IntPtr NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x040039C0 RID: 14784
			private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0;

			// Token: 0x040039C1 RID: 14785
			private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0;

			// Token: 0x040039C2 RID: 14786
			private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

			// Token: 0x040039C3 RID: 14787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomInputSource_Nullable_1_Int64_Int32_Joystick_InputSource_Extension_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0;

			// Token: 0x040039C4 RID: 14788
			private static readonly IntPtr NativeMethodInfoPtr_yBrYeUxifbbrwCEIrxFURhlDbvk_Public_Void_0;

			// Token: 0x040039C5 RID: 14789
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

			// Token: 0x040039C6 RID: 14790
			private static readonly IntPtr NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_0;

			// Token: 0x040039C7 RID: 14791
			private static readonly IntPtr NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedControllerHWInfo_0;

			// Token: 0x040039C8 RID: 14792
			private static readonly IntPtr NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedController_0;

			// Token: 0x040039C9 RID: 14793
			private static readonly IntPtr NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0;

			// Token: 0x040039CA RID: 14794
			private static readonly IntPtr NativeMethodInfoPtr_kqnbjAvRtSTjtQCzpAMBiybuUGpi_Public_BridgedControllerHWInfo_0;

			// Token: 0x040039CB RID: 14795
			private static readonly IntPtr NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0;

			// Token: 0x040039CC RID: 14796
			private static readonly IntPtr NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0;

			// Token: 0x040039CD RID: 14797
			private static readonly IntPtr NativeMethodInfoPtr_zxqRxkJsyHvgUlYXlmVgsyIPGmZ_Private_Void_0;

			// Token: 0x040039CE RID: 14798
			private static readonly IntPtr NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_0;

			// Token: 0x040039CF RID: 14799
			private static readonly IntPtr NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Button_0;

			// Token: 0x040039D0 RID: 14800
			private static readonly IntPtr NativeMethodInfoPtr_gxoSeeRWiLOZPArwxbwxXkkYHXA_Private_Boolean_Single_Single_0;

			// Token: 0x040039D1 RID: 14801
			private static readonly IntPtr NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Axis_0;

			// Token: 0x040039D2 RID: 14802
			private static readonly IntPtr NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Int32_0;

			// Token: 0x040039D3 RID: 14803
			private static readonly IntPtr NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Int32_0;

			// Token: 0x040039D4 RID: 14804
			private static readonly IntPtr NativeMethodInfoPtr_yTgniHEdrsAvSWhkDJlxBFPFDUV_Private_Void_0;

			// Token: 0x040039D5 RID: 14805
			private static readonly IntPtr NativeMethodInfoPtr_CfbXJvTwTDCGpDyvhutZklklBeuE_Private_Void_0;

			// Token: 0x040039D6 RID: 14806
			private static readonly IntPtr NativeMethodInfoPtr_cDxLVOxKafYQBWeXXmcNpOCwNoW_Private_String_0;

			// Token: 0x040039D7 RID: 14807
			private static readonly IntPtr NativeMethodInfoPtr_JpSubverIoQGOzqJJrfnnJIlmSh_Public_Static_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_KiqJQMbxOBuxPvYVtxIuneAPeNT_0;

			// Token: 0x040039D8 RID: 14808
			private static readonly IntPtr NativeMethodInfoPtr_eQADvpcGTIbGLYfwFzEyJBrRYKF_Public_Static_Int32_KiqJQMbxOBuxPvYVtxIuneAPeNT_KiqJQMbxOBuxPvYVtxIuneAPeNT_0;
		}

		// Token: 0x0200035B RID: 859
		public class curFhilNzVaJcbOqCbXkGzRDgqVC : Object
		{
			// Token: 0x060046F7 RID: 18167 RVA: 0x00148E48 File Offset: 0x00147048
			// Note: this type is marked as 'beforefieldinit'.
			static curFhilNzVaJcbOqCbXkGzRDgqVC()
			{
				Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputManager>.NativeClassPtr, "curFhilNzVaJcbOqCbXkGzRDgqVC");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, "WZJGJlGHePZBbvenKyBJWpZyYjh");
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670458);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670459);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_SSHSpllgEbFKZAcfnxanCbQQINM_Public_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670460);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Public_Boolean_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670461);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_FeJBcyYKxArwGpuqyYzBzZQRSWe_Public_IEnumerable_1_uNXeXLZTbCCZJrBvwrJREILquhh_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670462);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Public_Int32_uNXeXLZTbCCZJrBvwrJREILquhh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670463);
				CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_erDFdKTfvESgSWsLwnpAGpsuuYq_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, 100670464);
			}

			// Token: 0x060046F8 RID: 18168 RVA: 0x00148F14 File Offset: 0x00147114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285585, XrefRangeEnd = 285591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe curFhilNzVaJcbOqCbXkGzRDgqVC()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700161B RID: 5659
			// (get) Token: 0x060046F9 RID: 18169 RVA: 0x00148F50 File Offset: 0x00147150
			public unsafe int rXMQXNCBXzDuFWBlvHLSlUeHjoIA
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285591, XrefRangeEnd = 285592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046FA RID: 18170 RVA: 0x00148F8C File Offset: 0x0014718C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285601, RefRangeEnd = 285604, XrefRangeStart = 285592, XrefRangeEnd = 285601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SSHSpllgEbFKZAcfnxanCbQQINM(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_SSHSpllgEbFKZAcfnxanCbQQINM_Public_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060046FB RID: 18171 RVA: 0x00148FD0 File Offset: 0x001471D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285604, XrefRangeEnd = 285607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool pqUmJgCiRbkfcUyrXIMmpKcRSDB(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1, CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Public_Boolean_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060046FC RID: 18172 RVA: 0x0014902C File Offset: 0x0014722C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285612, RefRangeEnd = 285613, XrefRangeStart = 285607, XrefRangeEnd = 285612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh> FeJBcyYKxArwGpuqyYzBzZQRSWe(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1, CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_FeJBcyYKxArwGpuqyYzBzZQRSWe_Public_IEnumerable_1_uNXeXLZTbCCZJrBvwrJREILquhh_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>>(intPtr3) : null;
			}

			// Token: 0x060046FD RID: 18173 RVA: 0x0014908C File Offset: 0x0014728C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285613, XrefRangeEnd = 285615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int toLEPoWuMDQZlYmjvpYldRbMVym(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Public_Int32_uNXeXLZTbCCZJrBvwrJREILquhh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046FE RID: 18174 RVA: 0x001490DC File Offset: 0x001472DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285620, RefRangeEnd = 285621, XrefRangeStart = 285615, XrefRangeEnd = 285620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void erDFdKTfvESgSWsLwnpAGpsuuYq(int A_1, int A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeMethodInfoPtr_erDFdKTfvESgSWsLwnpAGpsuuYq_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046FF RID: 18175 RVA: 0x00019B85 File Offset: 0x00017D85
			public curFhilNzVaJcbOqCbXkGzRDgqVC(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161A RID: 5658
			// (get) Token: 0x06004700 RID: 18176 RVA: 0x00149128 File Offset: 0x00147328
			// (set) Token: 0x06004701 RID: 18177 RVA: 0x00019B8E File Offset: 0x00017D8E
			public unsafe List<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh> WZJGJlGHePZBbvenKyBJWpZyYjh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039D9 RID: 14809
			private static readonly IntPtr NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh;

			// Token: 0x040039DA RID: 14810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040039DB RID: 14811
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x040039DC RID: 14812
			private static readonly IntPtr NativeMethodInfoPtr_SSHSpllgEbFKZAcfnxanCbQQINM_Public_Void_KiqJQMbxOBuxPvYVtxIuneAPeNT_0;

			// Token: 0x040039DD RID: 14813
			private static readonly IntPtr NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Public_Boolean_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0;

			// Token: 0x040039DE RID: 14814
			private static readonly IntPtr NativeMethodInfoPtr_FeJBcyYKxArwGpuqyYzBzZQRSWe_Public_IEnumerable_1_uNXeXLZTbCCZJrBvwrJREILquhh_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0;

			// Token: 0x040039DF RID: 14815
			private static readonly IntPtr NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Public_Int32_uNXeXLZTbCCZJrBvwrJREILquhh_0;

			// Token: 0x040039E0 RID: 14816
			private static readonly IntPtr NativeMethodInfoPtr_erDFdKTfvESgSWsLwnpAGpsuuYq_Private_Void_Int32_Int32_0;

			// Token: 0x0200056D RID: 1389
			[OriginalName("Rewired_Core.dll", "", "JADRmMJRwbnagDacdeQTpUezKjv")]
			public enum JADRmMJRwbnagDacdeQTpUezKjv
			{
				// Token: 0x04004B58 RID: 19288
				CJqwAGOvfKqegUKvkxHubbFWiii,
				// Token: 0x04004B59 RID: 19289
				mIwObrpcXMetJnzJmAveEOGSsTo
			}

			// Token: 0x0200056E RID: 1390
			public class uNXeXLZTbCCZJrBvwrJREILquhh : Object
			{
				// Token: 0x06005C3C RID: 23612 RVA: 0x00194328 File Offset: 0x00192528
				// Note: this type is marked as 'beforefieldinit'.
				static uNXeXLZTbCCZJrBvwrJREILquhh()
				{
					Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, "uNXeXLZTbCCZJrBvwrJREILquhh");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, "hpzYzQnGpdPZaJsQiWRLTcVKQEz");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_VepFqqkakAOqenohtPUjCogBBFon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, "VepFqqkakAOqenohtPUjCogBBFon");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, "pdbGhwbnviCDKxCDecODnVAdAFp");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, "jlHBGpOvqXeiAbLzalgkocNbBdX");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, "fSxjFgmrrcJImiPcAahGHVTZRLqI");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, "yHQIcUwPwDJrWehFwcGOARwxPjqk");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeMethodInfoPtr__ctor_Public_Void_Int32_Nullable_1_Int64_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, 100670465);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Boolean_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr, 100670466);
				}

				// Token: 0x06005C3D RID: 23613 RVA: 0x001943F4 File Offset: 0x001925F4
				[CallerCount(0)]
				public unsafe uNXeXLZTbCCZJrBvwrJREILquhh(int rewiredId, Nullable<long> systemId, string systemControllerName, int lastInputManagerId, int buttonCount, int axisCount)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref rewiredId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(systemId));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemControllerName);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastInputManagerId;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeMethodInfoPtr__ctor_Public_Void_Int32_Nullable_1_Int64_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005C3E RID: 23614 RVA: 0x00194490 File Offset: 0x00192690
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 285564, RefRangeEnd = 285567, XrefRangeStart = 285561, XrefRangeEnd = 285564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool fvOGAoKxBgCUFQBmLBDvnCAQduEb(CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT A_1, CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv A_2)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Boolean_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06005C3F RID: 23615 RVA: 0x00022C60 File Offset: 0x00020E60
				public uNXeXLZTbCCZJrBvwrJREILquhh(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001CA0 RID: 7328
				// (get) Token: 0x06005C40 RID: 23616 RVA: 0x001944EC File Offset: 0x001926EC
				// (set) Token: 0x06005C41 RID: 23617 RVA: 0x00022C69 File Offset: 0x00020E69
				public unsafe int hpzYzQnGpdPZaJsQiWRLTcVKQEz
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz)) = value;
					}
				}

				// Token: 0x17001CA1 RID: 7329
				// (get) Token: 0x06005C42 RID: 23618 RVA: 0x00194514 File Offset: 0x00192714
				// (set) Token: 0x06005C43 RID: 23619 RVA: 0x00022C84 File Offset: 0x00020E84
				public Nullable<long> VepFqqkakAOqenohtPUjCogBBFon
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_VepFqqkakAOqenohtPUjCogBBFon);
						return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_VepFqqkakAOqenohtPUjCogBBFon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17001CA2 RID: 7330
				// (get) Token: 0x06005C44 RID: 23620 RVA: 0x00194544 File Offset: 0x00192744
				// (set) Token: 0x06005C45 RID: 23621 RVA: 0x00022CB2 File Offset: 0x00020EB2
				public unsafe string pdbGhwbnviCDKxCDecODnVAdAFp
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001CA3 RID: 7331
				// (get) Token: 0x06005C46 RID: 23622 RVA: 0x0019456C File Offset: 0x0019276C
				// (set) Token: 0x06005C47 RID: 23623 RVA: 0x00022CD1 File Offset: 0x00020ED1
				public unsafe int jlHBGpOvqXeiAbLzalgkocNbBdX
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX)) = value;
					}
				}

				// Token: 0x17001CA4 RID: 7332
				// (get) Token: 0x06005C48 RID: 23624 RVA: 0x00194594 File Offset: 0x00192794
				// (set) Token: 0x06005C49 RID: 23625 RVA: 0x00022CEC File Offset: 0x00020EEC
				public unsafe int fSxjFgmrrcJImiPcAahGHVTZRLqI
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI)) = value;
					}
				}

				// Token: 0x17001CA5 RID: 7333
				// (get) Token: 0x06005C4A RID: 23626 RVA: 0x001945BC File Offset: 0x001927BC
				// (set) Token: 0x06005C4B RID: 23627 RVA: 0x00022D07 File Offset: 0x00020F07
				public unsafe int yHQIcUwPwDJrWehFwcGOARwxPjqk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk)) = value;
					}
				}

				// Token: 0x04004B5A RID: 19290
				private static readonly IntPtr NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz;

				// Token: 0x04004B5B RID: 19291
				private static readonly IntPtr NativeFieldInfoPtr_VepFqqkakAOqenohtPUjCogBBFon;

				// Token: 0x04004B5C RID: 19292
				private static readonly IntPtr NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp;

				// Token: 0x04004B5D RID: 19293
				private static readonly IntPtr NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX;

				// Token: 0x04004B5E RID: 19294
				private static readonly IntPtr NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI;

				// Token: 0x04004B5F RID: 19295
				private static readonly IntPtr NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk;

				// Token: 0x04004B60 RID: 19296
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Nullable_1_Int64_String_Int32_Int32_Int32_0;

				// Token: 0x04004B61 RID: 19297
				private static readonly IntPtr NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Boolean_KiqJQMbxOBuxPvYVtxIuneAPeNT_JADRmMJRwbnagDacdeQTpUezKjv_0;
			}

			// Token: 0x0200056F RID: 1391
			public sealed class xOxBRZJmaAoKyzbaKZRropyDlOd : Object
			{
				// Token: 0x06005C4C RID: 23628 RVA: 0x001945E4 File Offset: 0x001927E4
				// Note: this type is marked as 'beforefieldinit'.
				static xOxBRZJmaAoKyzbaKZRropyDlOd()
				{
					Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>.NativeClassPtr, "xOxBRZJmaAoKyzbaKZRropyDlOd");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "nfdVmUBPUJnDFGllTjkjmnPgqRn");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "VwnghVzQOWJgAIuSwPgHwssqrse");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "SlayLftkgZoHYdeBJnNWQUqLKTb");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "yInDBaNvWqaWwtCWTdvLCMKfjvXu");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_DwGLJCFpnXdeuwHJttQAsgQOWph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "DwGLJCFpnXdeuwHJttQAsgQOWph");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, "hAStVwJVMBBvRtdqjAJKGEgHfju");
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_uNXeXLZTbCCZJrBvwrJREILquhh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670467);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670468);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670469);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_uNXeXLZTbCCZJrBvwrJREILquhh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670470);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670471);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670472);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670473);
					CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr, 100670474);
				}

				// Token: 0x06005C4D RID: 23629 RVA: 0x00194778 File Offset: 0x00192978
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285567, XrefRangeEnd = 285575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh> System_Collections_Generic_IEnumerable_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_uNXeXLZTbCCZJrBvwrJREILquhh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>>(intPtr3) : null;
				}

				// Token: 0x06005C4E RID: 23630 RVA: 0x001947B8 File Offset: 0x001929B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x06005C4F RID: 23631 RVA: 0x001947F8 File Offset: 0x001929F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285575, XrefRangeEnd = 285580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001CB0 RID: 7344
				// (get) Token: 0x06005C50 RID: 23632 RVA: 0x00194834 File Offset: 0x00192A34
				public unsafe CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh RxEsaVfFUTPBEvUOoHXRZcYdvuB
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_uNXeXLZTbCCZJrBvwrJREILquhh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>(intPtr3) : null;
					}
				}

				// Token: 0x06005C51 RID: 23633 RVA: 0x00194874 File Offset: 0x00192A74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285580, XrefRangeEnd = 285585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005C52 RID: 23634 RVA: 0x001948A8 File Offset: 0x00192AA8
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17001CB1 RID: 7345
				// (get) Token: 0x06005C53 RID: 23635 RVA: 0x001948DC File Offset: 0x00192ADC
				public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06005C54 RID: 23636 RVA: 0x0019491C File Offset: 0x00192B1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe xOxBRZJmaAoKyzbaKZRropyDlOd(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005C55 RID: 23637 RVA: 0x00022D22 File Offset: 0x00020F22
				public xOxBRZJmaAoKyzbaKZRropyDlOd(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001CA6 RID: 7334
				// (get) Token: 0x06005C56 RID: 23638 RVA: 0x00194964 File Offset: 0x00192B64
				// (set) Token: 0x06005C57 RID: 23639 RVA: 0x00022D2B File Offset: 0x00020F2B
				public unsafe CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh NuVnrlTavvGYEgMZhwgjSLwilSSG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.uNXeXLZTbCCZJrBvwrJREILquhh>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CA7 RID: 7335
				// (get) Token: 0x06005C58 RID: 23640 RVA: 0x00194994 File Offset: 0x00192B94
				// (set) Token: 0x06005C59 RID: 23641 RVA: 0x00022D4A File Offset: 0x00020F4A
				public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
					}
				}

				// Token: 0x17001CA8 RID: 7336
				// (get) Token: 0x06005C5A RID: 23642 RVA: 0x001949BC File Offset: 0x00192BBC
				// (set) Token: 0x06005C5B RID: 23643 RVA: 0x00022D65 File Offset: 0x00020F65
				public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
					}
				}

				// Token: 0x17001CA9 RID: 7337
				// (get) Token: 0x06005C5C RID: 23644 RVA: 0x001949E4 File Offset: 0x00192BE4
				// (set) Token: 0x06005C5D RID: 23645 RVA: 0x00022D80 File Offset: 0x00020F80
				public unsafe CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC HbFBVXVdulMdGSmvVCgeOcAyoyn
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CAA RID: 7338
				// (get) Token: 0x06005C5E RID: 23646 RVA: 0x00194A14 File Offset: 0x00192C14
				// (set) Token: 0x06005C5F RID: 23647 RVA: 0x00022D9F File Offset: 0x00020F9F
				public unsafe CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT nfdVmUBPUJnDFGllTjkjmnPgqRn
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CAB RID: 7339
				// (get) Token: 0x06005C60 RID: 23648 RVA: 0x00194A44 File Offset: 0x00192C44
				// (set) Token: 0x06005C61 RID: 23649 RVA: 0x00022DBE File Offset: 0x00020FBE
				public unsafe CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT VwnghVzQOWJgAIuSwPgHwssqrse
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomInputManager.KiqJQMbxOBuxPvYVtxIuneAPeNT>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CAC RID: 7340
				// (get) Token: 0x06005C62 RID: 23650 RVA: 0x00194A74 File Offset: 0x00192C74
				// (set) Token: 0x06005C63 RID: 23651 RVA: 0x00022DDD File Offset: 0x00020FDD
				public unsafe CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv SlayLftkgZoHYdeBJnNWQUqLKTb
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb)) = value;
					}
				}

				// Token: 0x17001CAD RID: 7341
				// (get) Token: 0x06005C64 RID: 23652 RVA: 0x00194A9C File Offset: 0x00192C9C
				// (set) Token: 0x06005C65 RID: 23653 RVA: 0x00022DF8 File Offset: 0x00020FF8
				public unsafe CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.JADRmMJRwbnagDacdeQTpUezKjv yInDBaNvWqaWwtCWTdvLCMKfjvXu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu)) = value;
					}
				}

				// Token: 0x17001CAE RID: 7342
				// (get) Token: 0x06005C66 RID: 23654 RVA: 0x00194AC4 File Offset: 0x00192CC4
				// (set) Token: 0x06005C67 RID: 23655 RVA: 0x00022E13 File Offset: 0x00021013
				public unsafe int DwGLJCFpnXdeuwHJttQAsgQOWph
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_DwGLJCFpnXdeuwHJttQAsgQOWph);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_DwGLJCFpnXdeuwHJttQAsgQOWph)) = value;
					}
				}

				// Token: 0x17001CAF RID: 7343
				// (get) Token: 0x06005C68 RID: 23656 RVA: 0x00194AEC File Offset: 0x00192CEC
				// (set) Token: 0x06005C69 RID: 23657 RVA: 0x00022E2E File Offset: 0x0002102E
				public unsafe int hAStVwJVMBBvRtdqjAJKGEgHfju
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputManager.curFhilNzVaJcbOqCbXkGzRDgqVC.xOxBRZJmaAoKyzbaKZRropyDlOd.NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju)) = value;
					}
				}

				// Token: 0x04004B62 RID: 19298
				private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

				// Token: 0x04004B63 RID: 19299
				private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

				// Token: 0x04004B64 RID: 19300
				private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

				// Token: 0x04004B65 RID: 19301
				private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

				// Token: 0x04004B66 RID: 19302
				private static readonly IntPtr NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn;

				// Token: 0x04004B67 RID: 19303
				private static readonly IntPtr NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse;

				// Token: 0x04004B68 RID: 19304
				private static readonly IntPtr NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb;

				// Token: 0x04004B69 RID: 19305
				private static readonly IntPtr NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu;

				// Token: 0x04004B6A RID: 19306
				private static readonly IntPtr NativeFieldInfoPtr_DwGLJCFpnXdeuwHJttQAsgQOWph;

				// Token: 0x04004B6B RID: 19307
				private static readonly IntPtr NativeFieldInfoPtr_hAStVwJVMBBvRtdqjAJKGEgHfju;

				// Token: 0x04004B6C RID: 19308
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_uNXeXLZTbCCZJrBvwrJREILquhh_0;

				// Token: 0x04004B6D RID: 19309
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

				// Token: 0x04004B6E RID: 19310
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04004B6F RID: 19311
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_InputManagers_CustomInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_uNXeXLZTbCCZJrBvwrJREILquhh_0;

				// Token: 0x04004B70 RID: 19312
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04004B71 RID: 19313
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04004B72 RID: 19314
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004B73 RID: 19315
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
			}
		}
	}
}
