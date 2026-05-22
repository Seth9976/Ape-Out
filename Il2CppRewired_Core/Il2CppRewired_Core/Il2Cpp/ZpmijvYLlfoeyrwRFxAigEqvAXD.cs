using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using Il2CppRewired.Config;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Platforms;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x02000134 RID: 308
	public class ZpmijvYLlfoeyrwRFxAigEqvAXD : PlatformInputManager
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x000AB7D0 File Offset: 0x000A99D0
		// Note: this type is marked as 'beforefieldinit'.
		static ZpmijvYLlfoeyrwRFxAigEqvAXD()
		{
			Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "", "ZpmijvYLlfoeyrwRFxAigEqvAXD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "fHwvAEhSaXstIllfGXDtviCPUrg");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "CdrTrRnhhmWjNgGjeGdDpUWMveb");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "iMzsUxaYTPYpPsSFUuSxcKuRSqt");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "atncmCoGisOlrDPqOnJLZGsHPEk");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_kbIKZmRSvXSITUWypiNmLRJFYcP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "kbIKZmRSvXSITUWypiNmLRJFYcP");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "QupTlkbJPCSxpgHQnsUQVuFrjWa");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_wABIBErUmtHNzKCranyuAoaBmOH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "wABIBErUmtHNzKCranyuAoaBmOH");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_QbbehZhAZIIuGcyHiwlDRreWerwJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "QbbehZhAZIIuGcyHiwlDRreWerwJ");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "xZDEMoVOFmiFBYuSsQfkKtLaLbQ");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "njnaoHoZTSJVhLZqASqYiMaJIAHG");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_hywPEwQdSAUklTcloCSfEzJMkvo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "hywPEwQdSAUklTcloCSfEzJMkvo");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_HoigzzvNTGVTOlBgKhZGtPWXeYe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "HoigzzvNTGVTOlBgKhZGtPWXeYe");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_PcabCvLTEseGnnDlcDbLspaGjLz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "PcabCvLTEseGnnDlcDbLspaGjLz");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_lWSOLEfaMjSUijLEoFeFGfVaDhvd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "lWSOLEfaMjSUijLEoFeFGfVaDhvd");
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670475);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670476);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670477);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670478);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670479);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670480);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670481);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670482);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670483);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670484);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670485);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670486);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_hcSOqJjlVTIebfoXJQFWxnAHypH_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670487);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670488);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670489);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670490);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670491);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670492);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_CYMTdwZEujCBzigVpVwyCVHtOio_Private_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670493);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_npuwLbSwaaIrUMtbELGugIiFNhB_Private_Void_Int32_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670494);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SbTxlMbPMbjoEFicmunSODRqAQFD_Private_Void_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670495);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_ASuIuyBFSvdYeAgwTaJnBGRjuQHL_Private_Boolean_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670496);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_UDWHjnSyMZKbhIFnGWsdjiueESP_Private_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670497);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GTnGvKfWEYaobbuLbGFnPGKXpLuA_Private_Boolean_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670498);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_vyUowQdRezXsfxwJKwKhJJVnur_Private_Void_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670499);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_dHsEAPVegRQRxTpKyLfYlrRGvre_Private_Void_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670500);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_fGWkPYrUUhFvFOGhHEIGJtIovJyu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670501);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_IgmHzNwnqNAoWHJUREsXazjvxbg_Private_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670502);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_mDteeyrByOxveqHHaIoAxNtXWPy_Private_Void_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670503);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_YoZFtSbXMAgtlDhkFDzNhVzexdkQ_Private_Void_SLKbGxbefIoyxmTrdMqskCIkfAEg_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670504);
			ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_pHhCWVTQEQWPqPMqMGCyOQIHIto_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, 100670505);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x000ABB84 File Offset: 0x000A9D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286234, XrefRangeEnd = 286260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD(UpdateLoopSetting updateLoopSetting)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoopSetting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000ABBCC File Offset: 0x000A9DCC
		public unsafe override int deviceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x000ABC14 File Offset: 0x000A9E14
		public unsafe override PlatformInputManager primaryInputManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000ABC60 File Offset: 0x000A9E60
		public unsafe override IInputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x000ABCAC File Offset: 0x000A9EAC
		public unsafe override InputSource inputSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000ABCF4 File Offset: 0x000A9EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286260, XrefRangeEnd = 286299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000ABD30 File Offset: 0x000A9F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286299, XrefRangeEnd = 286305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000ABD7C File Offset: 0x000A9F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286305, XrefRangeEnd = 286339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000ABDB8 File Offset: 0x000A9FB8
		[CallerCount(0)]
		public unsafe override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr3) : null;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000ABE04 File Offset: 0x000AA004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286339, XrefRangeEnd = 286351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assignedControllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000ABE60 File Offset: 0x000AA060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286351, XrefRangeEnd = 286352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x000ABE9C File Offset: 0x000AA09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286352, XrefRangeEnd = 286353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x000ABED8 File Offset: 0x000AA0D8
		[CallerCount(0)]
		public unsafe void hcSOqJjlVTIebfoXJQFWxnAHypH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_hcSOqJjlVTIebfoXJQFWxnAHypH_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x000ABF0C File Offset: 0x000AA10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286353, XrefRangeEnd = 286358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetUnityJoystickId(int joystickId, int unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000ABF64 File Offset: 0x000AA164
		[CallerCount(0)]
		public unsafe override IUnifiedMouseSource GetUnifiedMouseSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr3) : null;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000ABFB0 File Offset: 0x000AA1B0
		[CallerCount(0)]
		public unsafe override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr3) : null;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000ABFFC File Offset: 0x000AA1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286358, XrefRangeEnd = 286363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fMlXvfEhQMkjVaHKyHzuIdFPqib()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000AC030 File Offset: 0x000AA230
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286415, RefRangeEnd = 286418, XrefRangeStart = 286363, XrefRangeEnd = 286415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fMlXvfEhQMkjVaHKyHzuIdFPqib(Il2CppStringArray A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000AC074 File Offset: 0x000AA274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286418, XrefRangeEnd = 286421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CYMTdwZEujCBzigVpVwyCVHtOio(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_CYMTdwZEujCBzigVpVwyCVHtOio_Private_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000AC0B4 File Offset: 0x000AA2B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286454, RefRangeEnd = 286455, XrefRangeStart = 286421, XrefRangeEnd = 286454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void npuwLbSwaaIrUMtbELGugIiFNhB(int A_1, int A_2, List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_3, List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_4)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_npuwLbSwaaIrUMtbELGugIiFNhB_Private_Void_Int32_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000AC128 File Offset: 0x000AA328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286455, XrefRangeEnd = 286457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SbTxlMbPMbjoEFicmunSODRqAQFD(List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_1, int A_2, int A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_SbTxlMbPMbjoEFicmunSODRqAQFD_Private_Void_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000AC188 File Offset: 0x000AA388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286459, RefRangeEnd = 286460, XrefRangeStart = 286457, XrefRangeEnd = 286459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ASuIuyBFSvdYeAgwTaJnBGRjuQHL(List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_ASuIuyBFSvdYeAgwTaJnBGRjuQHL_Private_Boolean_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000AC1E4 File Offset: 0x000AA3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286462, RefRangeEnd = 286463, XrefRangeStart = 286460, XrefRangeEnd = 286462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UDWHjnSyMZKbhIFnGWsdjiueESP(List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_UDWHjnSyMZKbhIFnGWsdjiueESP_Private_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000AC234 File Offset: 0x000AA434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286466, RefRangeEnd = 286467, XrefRangeStart = 286463, XrefRangeEnd = 286466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GTnGvKfWEYaobbuLbGFnPGKXpLuA(List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_GTnGvKfWEYaobbuLbGFnPGKXpLuA_Private_Boolean_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000AC290 File Offset: 0x000AA490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286481, RefRangeEnd = 286483, XrefRangeStart = 286467, XrefRangeEnd = 286481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vyUowQdRezXsfxwJKwKhJJVnur(int A_1, List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_2, int A_3, List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_4, ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE A_5)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_vyUowQdRezXsfxwJKwKhJJVnur_Private_Void_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000AC310 File Offset: 0x000AA510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286502, RefRangeEnd = 286504, XrefRangeStart = 286483, XrefRangeEnd = 286502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dHsEAPVegRQRxTpKyLfYlrRGvre(int A_1, List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_2, ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_dHsEAPVegRQRxTpKyLfYlrRGvre_Private_Void_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000AC370 File Offset: 0x000AA570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286509, RefRangeEnd = 286510, XrefRangeStart = 286504, XrefRangeEnd = 286509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void fGWkPYrUUhFvFOGhHEIGJtIovJyu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_fGWkPYrUUhFvFOGhHEIGJtIovJyu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000AC3A4 File Offset: 0x000AA5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286510, XrefRangeEnd = 286512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IgmHzNwnqNAoWHJUREsXazjvxbg(Il2CppStringArray A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_IgmHzNwnqNAoWHJUREsXazjvxbg_Private_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x000AC3F4 File Offset: 0x000AA5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286512, XrefRangeEnd = 286516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mDteeyrByOxveqHHaIoAxNtXWPy(List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_1, List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> A_2, bool A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_mDteeyrByOxveqHHaIoAxNtXWPy_Private_Void_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x000AC458 File Offset: 0x000AA658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286526, RefRangeEnd = 286529, XrefRangeStart = 286516, XrefRangeEnd = 286526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void YoZFtSbXMAgtlDhkFDzNhVzexdkQ(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_YoZFtSbXMAgtlDhkFDzNhVzexdkQ_Private_Void_SLKbGxbefIoyxmTrdMqskCIkfAEg_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286529, XrefRangeEnd = 286531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void pHhCWVTQEQWPqPMqMGCyOQIHIto()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeMethodInfoPtr_pHhCWVTQEQWPqPMqMGCyOQIHIto_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0000D75F File Offset: 0x0000B95F
		public ZpmijvYLlfoeyrwRFxAigEqvAXD(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x000AC4DC File Offset: 0x000AA6DC
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x0000D768 File Offset: 0x0000B968
		public unsafe List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg> fHwvAEhSaXstIllfGXDtviCPUrg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x000AC50C File Offset: 0x000AA70C
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x0000D787 File Offset: 0x0000B987
		public unsafe int CdrTrRnhhmWjNgGjeGdDpUWMveb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb)) = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x000AC534 File Offset: 0x000AA734
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000D7A2 File Offset: 0x0000B9A2
		public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM iMzsUxaYTPYpPsSFUuSxcKuRSqt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000AC564 File Offset: 0x000AA764
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
		public unsafe bool atncmCoGisOlrDPqOnJLZGsHPEk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk)) = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000AC58C File Offset: 0x000AA78C
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		public unsafe bool kbIKZmRSvXSITUWypiNmLRJFYcP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_kbIKZmRSvXSITUWypiNmLRJFYcP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_kbIKZmRSvXSITUWypiNmLRJFYcP)) = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x000AC5B4 File Offset: 0x000AA7B4
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x0000D7F7 File Offset: 0x0000B9F7
		public unsafe UpdateLoopType QupTlkbJPCSxpgHQnsUQVuFrjWa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa)) = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x000AC5DC File Offset: 0x000AA7DC
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x0000D812 File Offset: 0x0000BA12
		public unsafe UpdateLoopType wABIBErUmtHNzKCranyuAoaBmOH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_wABIBErUmtHNzKCranyuAoaBmOH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_wABIBErUmtHNzKCranyuAoaBmOH)) = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x000AC604 File Offset: 0x000AA804
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x0000D82D File Offset: 0x0000BA2D
		public unsafe TimerAbs QbbehZhAZIIuGcyHiwlDRreWerwJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_QbbehZhAZIIuGcyHiwlDRreWerwJ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerAbs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_QbbehZhAZIIuGcyHiwlDRreWerwJ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x000AC634 File Offset: 0x000AA834
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x0000D84C File Offset: 0x0000BA4C
		public unsafe Action<int, ControllerDataUpdater> xZDEMoVOFmiFBYuSsQfkKtLaLbQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x000AC664 File Offset: 0x000AA864
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x0000D86B File Offset: 0x0000BA6B
		public unsafe PlatformInputManager njnaoHoZTSJVhLZqASqYiMaJIAHG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x000AC694 File Offset: 0x000AA894
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x0000D88A File Offset: 0x0000BA8A
		public unsafe IUnifiedKeyboardSource hywPEwQdSAUklTcloCSfEzJMkvo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_hywPEwQdSAUklTcloCSfEzJMkvo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_hywPEwQdSAUklTcloCSfEzJMkvo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x000AC6C4 File Offset: 0x000AA8C4
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x0000D8A9 File Offset: 0x0000BAA9
		public unsafe IUnifiedMouseSource HoigzzvNTGVTOlBgKhZGtPWXeYe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_HoigzzvNTGVTOlBgKhZGtPWXeYe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_HoigzzvNTGVTOlBgKhZGtPWXeYe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x000AC6F4 File Offset: 0x000AA8F4
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		public unsafe bool PcabCvLTEseGnnDlcDbLspaGjLz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_PcabCvLTEseGnnDlcDbLspaGjLz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_PcabCvLTEseGnnDlcDbLspaGjLz)) = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x000AC71C File Offset: 0x000AA91C
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x0000D8E3 File Offset: 0x0000BAE3
		public unsafe Il2CppStringArray lWSOLEfaMjSUijLEoFeFGfVaDhvd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_lWSOLEfaMjSUijLEoFeFGfVaDhvd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.NativeFieldInfoPtr_lWSOLEfaMjSUijLEoFeFGfVaDhvd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr_CdrTrRnhhmWjNgGjeGdDpUWMveb;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr_iMzsUxaYTPYpPsSFUuSxcKuRSqt;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_atncmCoGisOlrDPqOnJLZGsHPEk;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeFieldInfoPtr_kbIKZmRSvXSITUWypiNmLRJFYcP;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr_QupTlkbJPCSxpgHQnsUQVuFrjWa;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeFieldInfoPtr_wABIBErUmtHNzKCranyuAoaBmOH;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeFieldInfoPtr_QbbehZhAZIIuGcyHiwlDRreWerwJ;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeFieldInfoPtr_xZDEMoVOFmiFBYuSsQfkKtLaLbQ;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeFieldInfoPtr_njnaoHoZTSJVhLZqASqYiMaJIAHG;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeFieldInfoPtr_hywPEwQdSAUklTcloCSfEzJMkvo;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeFieldInfoPtr_HoigzzvNTGVTOlBgKhZGtPWXeYe;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeFieldInfoPtr_PcabCvLTEseGnnDlcDbLspaGjLz;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeFieldInfoPtr_lWSOLEfaMjSUijLEoFeFGfVaDhvd;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_hcSOqJjlVTIebfoXJQFWxnAHypH_Private_Void_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_fMlXvfEhQMkjVaHKyHzuIdFPqib_Private_Void_Il2CppStringArray_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_CYMTdwZEujCBzigVpVwyCVHtOio_Private_Void_UpdateLoopType_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr_npuwLbSwaaIrUMtbELGugIiFNhB_Private_Void_Int32_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_0;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_SbTxlMbPMbjoEFicmunSODRqAQFD_Private_Void_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_Int32_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_ASuIuyBFSvdYeAgwTaJnBGRjuQHL_Private_Boolean_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_UDWHjnSyMZKbhIFnGWsdjiueESP_Private_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_GTnGvKfWEYaobbuLbGFnPGKXpLuA_Private_Boolean_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_vyUowQdRezXsfxwJKwKhJJVnur_Private_Void_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_dHsEAPVegRQRxTpKyLfYlrRGvre_Private_Void_Int32_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_fGWkPYrUUhFvFOGhHEIGJtIovJyu_Private_Void_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_IgmHzNwnqNAoWHJUREsXazjvxbg_Private_Boolean_Il2CppStringArray_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_mDteeyrByOxveqHHaIoAxNtXWPy_Private_Void_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_List_1_SLKbGxbefIoyxmTrdMqskCIkfAEg_Boolean_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_YoZFtSbXMAgtlDhkFDzNhVzexdkQ_Private_Void_SLKbGxbefIoyxmTrdMqskCIkfAEg_Boolean_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_pHhCWVTQEQWPqPMqMGCyOQIHIto_Private_Void_0;

		// Token: 0x0200035C RID: 860
		public class SLKbGxbefIoyxmTrdMqskCIkfAEg : Object
		{
			// Token: 0x06004702 RID: 18178 RVA: 0x00149158 File Offset: 0x00147358
			// Note: this type is marked as 'beforefieldinit'.
			static SLKbGxbefIoyxmTrdMqskCIkfAEg()
			{
				Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "SLKbGxbefIoyxmTrdMqskCIkfAEg");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "crvdwvKXoXisViNJVdYkAthcLjLI");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "pZWfHBsUrEAGDEjTkfpYhyBeTnjl");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "pqTtSCngKtHengXqufyfMylPsXx");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "mseEbqKiQaLIYtAxXbJUlqWUGxJX");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_RyvoRWBZVRSwGYglUwVhQuXYDip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "RyvoRWBZVRSwGYglUwVhQuXYDip");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "woImURUGoBxfCkNnVjWGuFqAAXqh");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_muOQMCtGuuOdmgwyohuZzXUgaAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "muOQMCtGuuOdmgwyohuZzXUgaAI");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "BpppCsinCvwfaaBOZASWVxSBDSw");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "yHQIcUwPwDJrWehFwcGOARwxPjqk");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "fSxjFgmrrcJImiPcAahGHVTZRLqI");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "cPjEJkrEhDhuJdcyzrFQgPXblWVD");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "SoTQrZQCFIhWMAdvVQDKOQzBDyH");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_oNiAMoADeipaqQvzmEZypNDwuKab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "oNiAMoADeipaqQvzmEZypNDwuKab");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_rWiAWVoJTMblSocoQCxNUicQsuo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "rWiAWVoJTMblSocoQCxNUicQsuo");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_QiTJClSjNxhpvsohfEtfXmPbhMjA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "QiTJClSjNxhpvsohfEtfXmPbhMjA");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "iNsxDqPHPTqhYqUYyDyQzTlxlTE");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, "qgsitxtkbBVwoGBdsBDloWoQJaF");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670506);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670507);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670508);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670509);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670510);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670511);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670512);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_set_unityId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670513);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670514);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670515);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670516);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670517);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670518);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670519);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_JMVNaLNUcSoscOziXsYkoOEoxzG_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670520);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670521);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670522);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670523);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670524);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670525);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_YgCsgHfBfFwFMaYjQBDCxIiOciA_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670526);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_tBKrLfYPPsCTkwPzdLrcQWDVbK_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670527);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_kqnbjAvRtSTjtQCzpAMBiybuUGpi_Public_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670528);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670529);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670530);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_JyAuLCcojdkdaDMOXAUHzMoCjgs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670531);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_zxqRxkJsyHvgUlYXlmVgsyIPGmZ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670532);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670533);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670534);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_gxoSeeRWiLOZPArwxbwxXkkYHXA_Private_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670535);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670536);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_UnityAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670537);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_UnityButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670538);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_OdwRRPBiMlKZvRcfmxHrEanWibX_Private_Boolean_CustomCalculationSourceData_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670539);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_KVuXtmtuMLlGyXQsWCObdeJuGcGE_Private_Boolean_CustomCalculationSourceData_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670540);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_hUtmFEilDRsUfrxSBklewvPOwts_Private_Boolean_CustomCalculationSourceData_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670541);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_QAVhtpDYwocHngfgGAlpCqbRZAiM_Private_Boolean_UnityAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670542);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_yTgniHEdrsAvSWhkDJlxBFPFDUV_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670543);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_CfbXJvTwTDCGpDyvhutZklklBeuE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670544);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_cDxLVOxKafYQBWeXXmcNpOCwNoW_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670545);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_medydmGmKMpTSaSAmvsWOFRbIMg_Private_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670546);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_JpSubverIoQGOzqJJrfnnJIlmSh_Public_Static_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_SLKbGxbefIoyxmTrdMqskCIkfAEg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670547);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_TPSNcgJhBfdtybjBAcaXnFuihWaH_Public_Static_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_SLKbGxbefIoyxmTrdMqskCIkfAEg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670548);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_fBphqUFWcMXhCIEaJEmJhgFoVah_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr, 100670549);
			}

			// Token: 0x1700162D RID: 5677
			// (get) Token: 0x06004703 RID: 18179 RVA: 0x00149648 File Offset: 0x00147848
			// (set) Token: 0x06004704 RID: 18180 RVA: 0x00149684 File Offset: 0x00147884
			public unsafe virtual int rewiredId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700162E RID: 5678
			// (get) Token: 0x06004705 RID: 18181 RVA: 0x001496C4 File Offset: 0x001478C4
			// (set) Token: 0x06004706 RID: 18182 RVA: 0x00149700 File Offset: 0x00147900
			public unsafe virtual int inputManagerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700162F RID: 5679
			// (get) Token: 0x06004707 RID: 18183 RVA: 0x00149740 File Offset: 0x00147940
			public unsafe virtual string name
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 285828, RefRangeEnd = 285829, XrefRangeStart = 285826, XrefRangeEnd = 285828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001630 RID: 5680
			// (get) Token: 0x06004708 RID: 18184 RVA: 0x00149778 File Offset: 0x00147978
			public unsafe virtual Nullable<long> systemId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285829, XrefRangeEnd = 285830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
			}

			// Token: 0x17001631 RID: 5681
			// (get) Token: 0x06004709 RID: 18185 RVA: 0x001497B0 File Offset: 0x001479B0
			// (set) Token: 0x0600470A RID: 18186 RVA: 0x001497EC File Offset: 0x001479EC
			public unsafe virtual int unityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_set_unityId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001632 RID: 5682
			// (get) Token: 0x0600470B RID: 18187 RVA: 0x0014982C File Offset: 0x00147A2C
			public unsafe virtual Guid instanceGuid
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 285857, RefRangeEnd = 285858, XrefRangeStart = 285830, XrefRangeEnd = 285857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001633 RID: 5683
			// (get) Token: 0x0600470C RID: 18188 RVA: 0x00149868 File Offset: 0x00147A68
			public unsafe virtual Guid persistentGuid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285858, XrefRangeEnd = 285859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001634 RID: 5684
			// (get) Token: 0x0600470D RID: 18189 RVA: 0x001498A4 File Offset: 0x00147AA4
			public unsafe virtual Controller.Extension extension
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
				}
			}

			// Token: 0x0600470E RID: 18190 RVA: 0x001498E4 File Offset: 0x00147AE4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600470F RID: 18191 RVA: 0x00149930 File Offset: 0x00147B30
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void StopVibration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004710 RID: 18192 RVA: 0x00149964 File Offset: 0x00147B64
			[CallerCount(0)]
			public unsafe SLKbGxbefIoyxmTrdMqskCIkfAEg()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004711 RID: 18193 RVA: 0x001499A0 File Offset: 0x00147BA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285874, RefRangeEnd = 285875, XrefRangeStart = 285859, XrefRangeEnd = 285874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void JMVNaLNUcSoscOziXsYkoOEoxzG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_JMVNaLNUcSoscOziXsYkoOEoxzG_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004712 RID: 18194 RVA: 0x001499D4 File Offset: 0x00147BD4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285881, RefRangeEnd = 285884, XrefRangeStart = 285875, XrefRangeEnd = 285881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004713 RID: 18195 RVA: 0x00149A08 File Offset: 0x00147C08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285886, RefRangeEnd = 285887, XrefRangeStart = 285884, XrefRangeEnd = 285886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int fvOGAoKxBgCUFQBmLBDvnCAQduEb(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004714 RID: 18196 RVA: 0x00149A58 File Offset: 0x00147C58
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285889, RefRangeEnd = 285892, XrefRangeStart = 285887, XrefRangeEnd = 285889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VnPWGNfJWhtnojiDNiUfGdFQHpgB(BridgedControllerHWInfo A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004715 RID: 18197 RVA: 0x00149A9C File Offset: 0x00147C9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285894, RefRangeEnd = 285895, XrefRangeStart = 285892, XrefRangeEnd = 285894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VnPWGNfJWhtnojiDNiUfGdFQHpgB(BridgedController A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004716 RID: 18198 RVA: 0x00149AE0 File Offset: 0x00147CE0
			[CallerCount(0)]
			public unsafe virtual void FillData(ControllerDataUpdater dataUpdater)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004717 RID: 18199 RVA: 0x00149B24 File Offset: 0x00147D24
			[CallerCount(0)]
			public unsafe void YgCsgHfBfFwFMaYjQBDCxIiOciA(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_YgCsgHfBfFwFMaYjQBDCxIiOciA_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004718 RID: 18200 RVA: 0x00149B64 File Offset: 0x00147D64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285898, RefRangeEnd = 285899, XrefRangeStart = 285895, XrefRangeEnd = 285898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void tBKrLfYPPsCTkwPzdLrcQWDVbK()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_tBKrLfYPPsCTkwPzdLrcQWDVbK_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004719 RID: 18201 RVA: 0x00149B98 File Offset: 0x00147D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285899, XrefRangeEnd = 285903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BridgedControllerHWInfo kqnbjAvRtSTjtQCzpAMBiybuUGpi()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_kqnbjAvRtSTjtQCzpAMBiybuUGpi_Public_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedControllerHWInfo>(intPtr3) : null;
			}

			// Token: 0x0600471A RID: 18202 RVA: 0x00149BD8 File Offset: 0x00147DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285903, XrefRangeEnd = 285907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual BridgedController ToBridgedController()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedController>(intPtr3) : null;
			}

			// Token: 0x0600471B RID: 18203 RVA: 0x00149C18 File Offset: 0x00147E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285907, XrefRangeEnd = 285913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDisconnectedEventArgs>(intPtr3) : null;
			}

			// Token: 0x0600471C RID: 18204 RVA: 0x00149C58 File Offset: 0x00147E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285913, XrefRangeEnd = 285917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void JyAuLCcojdkdaDMOXAUHzMoCjgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_JyAuLCcojdkdaDMOXAUHzMoCjgs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600471D RID: 18205 RVA: 0x00149C8C File Offset: 0x00147E8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285924, RefRangeEnd = 285925, XrefRangeStart = 285917, XrefRangeEnd = 285924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void zxqRxkJsyHvgUlYXlmVgsyIPGmZ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_zxqRxkJsyHvgUlYXlmVgsyIPGmZ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600471E RID: 18206 RVA: 0x00149CC0 File Offset: 0x00147EC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285929, RefRangeEnd = 285930, XrefRangeStart = 285925, XrefRangeEnd = 285929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QLZdJmwnUkddZisUnLmixtMACSh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600471F RID: 18207 RVA: 0x00149CF4 File Offset: 0x00147EF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285952, RefRangeEnd = 285953, XrefRangeStart = 285930, XrefRangeEnd = 285952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TKtEoSLnkmsQpmZzujyGAymhyus(HardwareJoystickMap.Platform_Fallback_Base.Button A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004720 RID: 18208 RVA: 0x00149D44 File Offset: 0x00147F44
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_gxoSeeRWiLOZPArwxbwxXkkYHXA_Private_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004721 RID: 18209 RVA: 0x00149D9C File Offset: 0x00147F9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285968, RefRangeEnd = 285969, XrefRangeStart = 285953, XrefRangeEnd = 285968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float xoaCMtlomZHQljcaODELNvyPMyxM(HardwareJoystickMap.Platform_Fallback_Base.Axis A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004722 RID: 18210 RVA: 0x00149DEC File Offset: 0x00147FEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285969, RefRangeEnd = 285970, XrefRangeStart = 285969, XrefRangeEnd = 285969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float xoaCMtlomZHQljcaODELNvyPMyxM(UnityAxis A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_UnityAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004723 RID: 18211 RVA: 0x00149E38 File Offset: 0x00148038
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 285975, RefRangeEnd = 285977, XrefRangeStart = 285970, XrefRangeEnd = 285975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TKtEoSLnkmsQpmZzujyGAymhyus(UnityButton A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_UnityButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004724 RID: 18212 RVA: 0x00149E84 File Offset: 0x00148084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285977, XrefRangeEnd = 285978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool OdwRRPBiMlKZvRcfmxHrEanWibX(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData A_1, out bool A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_OdwRRPBiMlKZvRcfmxHrEanWibX_Private_Boolean_CustomCalculationSourceData_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004725 RID: 18213 RVA: 0x00149EE0 File Offset: 0x001480E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285978, XrefRangeEnd = 285980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool KVuXtmtuMLlGyXQsWCObdeJuGcGE(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData A_1, out bool A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_KVuXtmtuMLlGyXQsWCObdeJuGcGE_Private_Boolean_CustomCalculationSourceData_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004726 RID: 18214 RVA: 0x00149F3C File Offset: 0x0014813C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 285982, RefRangeEnd = 285984, XrefRangeStart = 285980, XrefRangeEnd = 285982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool hUtmFEilDRsUfrxSBklewvPOwts(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData A_1, out float A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_hUtmFEilDRsUfrxSBklewvPOwts_Private_Boolean_CustomCalculationSourceData_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004727 RID: 18215 RVA: 0x00149F98 File Offset: 0x00148198
			[CallerCount(0)]
			public unsafe bool QAVhtpDYwocHngfgGAlpCqbRZAiM(UnityAxis A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_QAVhtpDYwocHngfgGAlpCqbRZAiM_Private_Boolean_UnityAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004728 RID: 18216 RVA: 0x00149FE4 File Offset: 0x001481E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286065, RefRangeEnd = 286066, XrefRangeStart = 285984, XrefRangeEnd = 286065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void yTgniHEdrsAvSWhkDJlxBFPFDUV()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_yTgniHEdrsAvSWhkDJlxBFPFDUV_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004729 RID: 18217 RVA: 0x0014A018 File Offset: 0x00148218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286066, XrefRangeEnd = 286069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CfbXJvTwTDCGpDyvhutZklklBeuE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_CfbXJvTwTDCGpDyvhutZklklBeuE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600472A RID: 18218 RVA: 0x0014A04C File Offset: 0x0014824C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286144, RefRangeEnd = 286145, XrefRangeStart = 286069, XrefRangeEnd = 286144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string cDxLVOxKafYQBWeXXmcNpOCwNoW()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_cDxLVOxKafYQBWeXXmcNpOCwNoW_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600472B RID: 18219 RVA: 0x0014A084 File Offset: 0x00148284
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 286155, RefRangeEnd = 286159, XrefRangeStart = 286145, XrefRangeEnd = 286155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputSource medydmGmKMpTSaSAmvsWOFRbIMg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_medydmGmKMpTSaSAmvsWOFRbIMg_Private_InputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600472C RID: 18220 RVA: 0x0014A0C0 File Offset: 0x001482C0
			[CallerCount(0)]
			public unsafe static int JpSubverIoQGOzqJJrfnnJIlmSh(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_0, ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_JpSubverIoQGOzqJJrfnnJIlmSh_Public_Static_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_SLKbGxbefIoyxmTrdMqskCIkfAEg_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600472D RID: 18221 RVA: 0x0014A114 File Offset: 0x00148314
			[CallerCount(0)]
			public unsafe static int TPSNcgJhBfdtybjBAcaXnFuihWaH(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_0, ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_TPSNcgJhBfdtybjBAcaXnFuihWaH_Public_Static_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_SLKbGxbefIoyxmTrdMqskCIkfAEg_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600472E RID: 18222 RVA: 0x0014A168 File Offset: 0x00148368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286159, XrefRangeEnd = 286173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string fBphqUFWcMXhCIEaJEmJhgFoVah(string A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeMethodInfoPtr_fBphqUFWcMXhCIEaJEmJhgFoVah_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600472F RID: 18223 RVA: 0x00019BAD File Offset: 0x00017DAD
			public SLKbGxbefIoyxmTrdMqskCIkfAEg(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161C RID: 5660
			// (get) Token: 0x06004730 RID: 18224 RVA: 0x0014A1A4 File Offset: 0x001483A4
			// (set) Token: 0x06004731 RID: 18225 RVA: 0x00019BB6 File Offset: 0x00017DB6
			public unsafe int crvdwvKXoXisViNJVdYkAthcLjLI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI)) = value;
				}
			}

			// Token: 0x1700161D RID: 5661
			// (get) Token: 0x06004732 RID: 18226 RVA: 0x0014A1CC File Offset: 0x001483CC
			// (set) Token: 0x06004733 RID: 18227 RVA: 0x00019BD1 File Offset: 0x00017DD1
			public unsafe int pZWfHBsUrEAGDEjTkfpYhyBeTnjl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl)) = value;
				}
			}

			// Token: 0x1700161E RID: 5662
			// (get) Token: 0x06004734 RID: 18228 RVA: 0x0014A1F4 File Offset: 0x001483F4
			// (set) Token: 0x06004735 RID: 18229 RVA: 0x00019BEC File Offset: 0x00017DEC
			public unsafe int pqTtSCngKtHengXqufyfMylPsXx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx)) = value;
				}
			}

			// Token: 0x1700161F RID: 5663
			// (get) Token: 0x06004736 RID: 18230 RVA: 0x0014A21C File Offset: 0x0014841C
			// (set) Token: 0x06004737 RID: 18231 RVA: 0x00019C07 File Offset: 0x00017E07
			public unsafe Guid mseEbqKiQaLIYtAxXbJUlqWUGxJX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX)) = value;
				}
			}

			// Token: 0x17001620 RID: 5664
			// (get) Token: 0x06004738 RID: 18232 RVA: 0x0014A244 File Offset: 0x00148444
			// (set) Token: 0x06004739 RID: 18233 RVA: 0x00019C22 File Offset: 0x00017E22
			public unsafe string RyvoRWBZVRSwGYglUwVhQuXYDip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_RyvoRWBZVRSwGYglUwVhQuXYDip);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_RyvoRWBZVRSwGYglUwVhQuXYDip), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001621 RID: 5665
			// (get) Token: 0x0600473A RID: 18234 RVA: 0x0014A26C File Offset: 0x0014846C
			// (set) Token: 0x0600473B RID: 18235 RVA: 0x00019C41 File Offset: 0x00017E41
			public unsafe int woImURUGoBxfCkNnVjWGuFqAAXqh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh)) = value;
				}
			}

			// Token: 0x17001622 RID: 5666
			// (get) Token: 0x0600473C RID: 18236 RVA: 0x0014A294 File Offset: 0x00148494
			// (set) Token: 0x0600473D RID: 18237 RVA: 0x00019C5C File Offset: 0x00017E5C
			public unsafe string muOQMCtGuuOdmgwyohuZzXUgaAI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_muOQMCtGuuOdmgwyohuZzXUgaAI);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_muOQMCtGuuOdmgwyohuZzXUgaAI), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001623 RID: 5667
			// (get) Token: 0x0600473E RID: 18238 RVA: 0x0014A2BC File Offset: 0x001484BC
			// (set) Token: 0x0600473F RID: 18239 RVA: 0x00019C7B File Offset: 0x00017E7B
			public unsafe string BpppCsinCvwfaaBOZASWVxSBDSw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001624 RID: 5668
			// (get) Token: 0x06004740 RID: 18240 RVA: 0x0014A2E4 File Offset: 0x001484E4
			// (set) Token: 0x06004741 RID: 18241 RVA: 0x00019C9A File Offset: 0x00017E9A
			public unsafe int yHQIcUwPwDJrWehFwcGOARwxPjqk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk)) = value;
				}
			}

			// Token: 0x17001625 RID: 5669
			// (get) Token: 0x06004742 RID: 18242 RVA: 0x0014A30C File Offset: 0x0014850C
			// (set) Token: 0x06004743 RID: 18243 RVA: 0x00019CB5 File Offset: 0x00017EB5
			public unsafe int fSxjFgmrrcJImiPcAahGHVTZRLqI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI)) = value;
				}
			}

			// Token: 0x17001626 RID: 5670
			// (get) Token: 0x06004744 RID: 18244 RVA: 0x0014A334 File Offset: 0x00148534
			// (set) Token: 0x06004745 RID: 18245 RVA: 0x00019CD0 File Offset: 0x00017ED0
			public unsafe Il2CppStructArray<float> cPjEJkrEhDhuJdcyzrFQgPXblWVD
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001627 RID: 5671
			// (get) Token: 0x06004746 RID: 18246 RVA: 0x0014A364 File Offset: 0x00148564
			// (set) Token: 0x06004747 RID: 18247 RVA: 0x00019CEF File Offset: 0x00017EEF
			public unsafe Il2CppStructArray<bool> SoTQrZQCFIhWMAdvVQDKOQzBDyH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001628 RID: 5672
			// (get) Token: 0x06004748 RID: 18248 RVA: 0x0014A394 File Offset: 0x00148594
			// (set) Token: 0x06004749 RID: 18249 RVA: 0x00019D0E File Offset: 0x00017F0E
			public unsafe Il2CppStructArray<bool> oNiAMoADeipaqQvzmEZypNDwuKab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_oNiAMoADeipaqQvzmEZypNDwuKab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_oNiAMoADeipaqQvzmEZypNDwuKab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001629 RID: 5673
			// (get) Token: 0x0600474A RID: 18250 RVA: 0x0014A3C4 File Offset: 0x001485C4
			// (set) Token: 0x0600474B RID: 18251 RVA: 0x00019D2D File Offset: 0x00017F2D
			public unsafe Il2CppStructArray<float> rWiAWVoJTMblSocoQCxNUicQsuo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_rWiAWVoJTMblSocoQCxNUicQsuo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_rWiAWVoJTMblSocoQCxNUicQsuo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162A RID: 5674
			// (get) Token: 0x0600474C RID: 18252 RVA: 0x0014A3F4 File Offset: 0x001485F4
			// (set) Token: 0x0600474D RID: 18253 RVA: 0x00019D4C File Offset: 0x00017F4C
			public unsafe Il2CppStructArray<bool> QiTJClSjNxhpvsohfEtfXmPbhMjA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_QiTJClSjNxhpvsohfEtfXmPbhMjA);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_QiTJClSjNxhpvsohfEtfXmPbhMjA), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162B RID: 5675
			// (get) Token: 0x0600474E RID: 18254 RVA: 0x0014A424 File Offset: 0x00148624
			// (set) Token: 0x0600474F RID: 18255 RVA: 0x00019D6B File Offset: 0x00017F6B
			public unsafe HardwareJoystickMap_InputManager iNsxDqPHPTqhYqUYyDyQzTlxlTE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162C RID: 5676
			// (get) Token: 0x06004750 RID: 18256 RVA: 0x0014A454 File Offset: 0x00148654
			// (set) Token: 0x06004751 RID: 18257 RVA: 0x00019D8A File Offset: 0x00017F8A
			public unsafe bool qgsitxtkbBVwoGBdsBDloWoQJaF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg.NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF)) = value;
				}
			}

			// Token: 0x040039E1 RID: 14817
			private static readonly IntPtr NativeFieldInfoPtr_crvdwvKXoXisViNJVdYkAthcLjLI;

			// Token: 0x040039E2 RID: 14818
			private static readonly IntPtr NativeFieldInfoPtr_pZWfHBsUrEAGDEjTkfpYhyBeTnjl;

			// Token: 0x040039E3 RID: 14819
			private static readonly IntPtr NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx;

			// Token: 0x040039E4 RID: 14820
			private static readonly IntPtr NativeFieldInfoPtr_mseEbqKiQaLIYtAxXbJUlqWUGxJX;

			// Token: 0x040039E5 RID: 14821
			private static readonly IntPtr NativeFieldInfoPtr_RyvoRWBZVRSwGYglUwVhQuXYDip;

			// Token: 0x040039E6 RID: 14822
			private static readonly IntPtr NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh;

			// Token: 0x040039E7 RID: 14823
			private static readonly IntPtr NativeFieldInfoPtr_muOQMCtGuuOdmgwyohuZzXUgaAI;

			// Token: 0x040039E8 RID: 14824
			private static readonly IntPtr NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw;

			// Token: 0x040039E9 RID: 14825
			private static readonly IntPtr NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk;

			// Token: 0x040039EA RID: 14826
			private static readonly IntPtr NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI;

			// Token: 0x040039EB RID: 14827
			private static readonly IntPtr NativeFieldInfoPtr_cPjEJkrEhDhuJdcyzrFQgPXblWVD;

			// Token: 0x040039EC RID: 14828
			private static readonly IntPtr NativeFieldInfoPtr_SoTQrZQCFIhWMAdvVQDKOQzBDyH;

			// Token: 0x040039ED RID: 14829
			private static readonly IntPtr NativeFieldInfoPtr_oNiAMoADeipaqQvzmEZypNDwuKab;

			// Token: 0x040039EE RID: 14830
			private static readonly IntPtr NativeFieldInfoPtr_rWiAWVoJTMblSocoQCxNUicQsuo;

			// Token: 0x040039EF RID: 14831
			private static readonly IntPtr NativeFieldInfoPtr_QiTJClSjNxhpvsohfEtfXmPbhMjA;

			// Token: 0x040039F0 RID: 14832
			private static readonly IntPtr NativeFieldInfoPtr_iNsxDqPHPTqhYqUYyDyQzTlxlTE;

			// Token: 0x040039F1 RID: 14833
			private static readonly IntPtr NativeFieldInfoPtr_qgsitxtkbBVwoGBdsBDloWoQJaF;

			// Token: 0x040039F2 RID: 14834
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040039F3 RID: 14835
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0;

			// Token: 0x040039F4 RID: 14836
			private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040039F5 RID: 14837
			private static readonly IntPtr NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0;

			// Token: 0x040039F6 RID: 14838
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040039F7 RID: 14839
			private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0;

			// Token: 0x040039F8 RID: 14840
			private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040039F9 RID: 14841
			private static readonly IntPtr NativeMethodInfoPtr_set_unityId_Public_set_Void_Int32_0;

			// Token: 0x040039FA RID: 14842
			private static readonly IntPtr NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x040039FB RID: 14843
			private static readonly IntPtr NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x040039FC RID: 14844
			private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0;

			// Token: 0x040039FD RID: 14845
			private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0;

			// Token: 0x040039FE RID: 14846
			private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

			// Token: 0x040039FF RID: 14847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A00 RID: 14848
			private static readonly IntPtr NativeMethodInfoPtr_JMVNaLNUcSoscOziXsYkoOEoxzG_Public_Void_0;

			// Token: 0x04003A01 RID: 14849
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003A02 RID: 14850
			private static readonly IntPtr NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_0;

			// Token: 0x04003A03 RID: 14851
			private static readonly IntPtr NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedControllerHWInfo_0;

			// Token: 0x04003A04 RID: 14852
			private static readonly IntPtr NativeMethodInfoPtr_VnPWGNfJWhtnojiDNiUfGdFQHpgB_Private_Void_BridgedController_0;

			// Token: 0x04003A05 RID: 14853
			private static readonly IntPtr NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0;

			// Token: 0x04003A06 RID: 14854
			private static readonly IntPtr NativeMethodInfoPtr_YgCsgHfBfFwFMaYjQBDCxIiOciA_Public_Void_Int32_0;

			// Token: 0x04003A07 RID: 14855
			private static readonly IntPtr NativeMethodInfoPtr_tBKrLfYPPsCTkwPzdLrcQWDVbK_Public_Void_0;

			// Token: 0x04003A08 RID: 14856
			private static readonly IntPtr NativeMethodInfoPtr_kqnbjAvRtSTjtQCzpAMBiybuUGpi_Public_BridgedControllerHWInfo_0;

			// Token: 0x04003A09 RID: 14857
			private static readonly IntPtr NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0;

			// Token: 0x04003A0A RID: 14858
			private static readonly IntPtr NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0;

			// Token: 0x04003A0B RID: 14859
			private static readonly IntPtr NativeMethodInfoPtr_JyAuLCcojdkdaDMOXAUHzMoCjgs_Private_Void_0;

			// Token: 0x04003A0C RID: 14860
			private static readonly IntPtr NativeMethodInfoPtr_zxqRxkJsyHvgUlYXlmVgsyIPGmZ_Private_Void_0;

			// Token: 0x04003A0D RID: 14861
			private static readonly IntPtr NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_0;

			// Token: 0x04003A0E RID: 14862
			private static readonly IntPtr NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_Button_0;

			// Token: 0x04003A0F RID: 14863
			private static readonly IntPtr NativeMethodInfoPtr_gxoSeeRWiLOZPArwxbwxXkkYHXA_Private_Boolean_Single_Single_0;

			// Token: 0x04003A10 RID: 14864
			private static readonly IntPtr NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_Axis_0;

			// Token: 0x04003A11 RID: 14865
			private static readonly IntPtr NativeMethodInfoPtr_xoaCMtlomZHQljcaODELNvyPMyxM_Private_Single_UnityAxis_0;

			// Token: 0x04003A12 RID: 14866
			private static readonly IntPtr NativeMethodInfoPtr_TKtEoSLnkmsQpmZzujyGAymhyus_Private_Boolean_UnityButton_0;

			// Token: 0x04003A13 RID: 14867
			private static readonly IntPtr NativeMethodInfoPtr_OdwRRPBiMlKZvRcfmxHrEanWibX_Private_Boolean_CustomCalculationSourceData_byref_Boolean_0;

			// Token: 0x04003A14 RID: 14868
			private static readonly IntPtr NativeMethodInfoPtr_KVuXtmtuMLlGyXQsWCObdeJuGcGE_Private_Boolean_CustomCalculationSourceData_byref_Boolean_0;

			// Token: 0x04003A15 RID: 14869
			private static readonly IntPtr NativeMethodInfoPtr_hUtmFEilDRsUfrxSBklewvPOwts_Private_Boolean_CustomCalculationSourceData_byref_Single_0;

			// Token: 0x04003A16 RID: 14870
			private static readonly IntPtr NativeMethodInfoPtr_QAVhtpDYwocHngfgGAlpCqbRZAiM_Private_Boolean_UnityAxis_0;

			// Token: 0x04003A17 RID: 14871
			private static readonly IntPtr NativeMethodInfoPtr_yTgniHEdrsAvSWhkDJlxBFPFDUV_Private_Void_0;

			// Token: 0x04003A18 RID: 14872
			private static readonly IntPtr NativeMethodInfoPtr_CfbXJvTwTDCGpDyvhutZklklBeuE_Private_Void_0;

			// Token: 0x04003A19 RID: 14873
			private static readonly IntPtr NativeMethodInfoPtr_cDxLVOxKafYQBWeXXmcNpOCwNoW_Private_String_0;

			// Token: 0x04003A1A RID: 14874
			private static readonly IntPtr NativeMethodInfoPtr_medydmGmKMpTSaSAmvsWOFRbIMg_Private_InputSource_0;

			// Token: 0x04003A1B RID: 14875
			private static readonly IntPtr NativeMethodInfoPtr_JpSubverIoQGOzqJJrfnnJIlmSh_Public_Static_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_SLKbGxbefIoyxmTrdMqskCIkfAEg_0;

			// Token: 0x04003A1C RID: 14876
			private static readonly IntPtr NativeMethodInfoPtr_TPSNcgJhBfdtybjBAcaXnFuihWaH_Public_Static_Int32_SLKbGxbefIoyxmTrdMqskCIkfAEg_SLKbGxbefIoyxmTrdMqskCIkfAEg_0;

			// Token: 0x04003A1D RID: 14877
			private static readonly IntPtr NativeMethodInfoPtr_fBphqUFWcMXhCIEaJEmJhgFoVah_Private_Static_String_String_0;
		}

		// Token: 0x0200035D RID: 861
		public class knBBmjaPdrWnjApbPDVMfUScNkYM : Object
		{
			// Token: 0x06004752 RID: 18258 RVA: 0x0014A47C File Offset: 0x0014867C
			// Note: this type is marked as 'beforefieldinit'.
			static knBBmjaPdrWnjApbPDVMfUScNkYM()
			{
				Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD>.NativeClassPtr, "knBBmjaPdrWnjApbPDVMfUScNkYM");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, "WZJGJlGHePZBbvenKyBJWpZyYjh");
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670550);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670551);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_SSHSpllgEbFKZAcfnxanCbQQINM_Public_Void_SLKbGxbefIoyxmTrdMqskCIkfAEg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670552);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Public_Boolean_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670553);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_FeJBcyYKxArwGpuqyYzBzZQRSWe_Public_IEnumerable_1_npMumqzPRMzfSptDjPuTYjZdaom_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670554);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Public_Int32_npMumqzPRMzfSptDjPuTYjZdaom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670555);
				ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_erDFdKTfvESgSWsLwnpAGpsuuYq_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, 100670556);
			}

			// Token: 0x06004753 RID: 18259 RVA: 0x0014A548 File Offset: 0x00148748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286195, XrefRangeEnd = 286201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe knBBmjaPdrWnjApbPDVMfUScNkYM()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001636 RID: 5686
			// (get) Token: 0x06004754 RID: 18260 RVA: 0x0014A584 File Offset: 0x00148784
			public unsafe int rXMQXNCBXzDuFWBlvHLSlUeHjoIA
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286201, XrefRangeEnd = 286202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004755 RID: 18261 RVA: 0x0014A5C0 File Offset: 0x001487C0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 286214, RefRangeEnd = 286217, XrefRangeStart = 286202, XrefRangeEnd = 286214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SSHSpllgEbFKZAcfnxanCbQQINM(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_SSHSpllgEbFKZAcfnxanCbQQINM_Public_Void_SLKbGxbefIoyxmTrdMqskCIkfAEg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004756 RID: 18262 RVA: 0x0014A604 File Offset: 0x00148804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286217, XrefRangeEnd = 286220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool pqUmJgCiRbkfcUyrXIMmpKcRSDB(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1, ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Public_Boolean_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004757 RID: 18263 RVA: 0x0014A660 File Offset: 0x00148860
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286225, RefRangeEnd = 286226, XrefRangeStart = 286220, XrefRangeEnd = 286225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom> FeJBcyYKxArwGpuqyYzBzZQRSWe(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1, ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_FeJBcyYKxArwGpuqyYzBzZQRSWe_Public_IEnumerable_1_npMumqzPRMzfSptDjPuTYjZdaom_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>>(intPtr3) : null;
			}

			// Token: 0x06004758 RID: 18264 RVA: 0x0014A6C0 File Offset: 0x001488C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286226, XrefRangeEnd = 286228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int toLEPoWuMDQZlYmjvpYldRbMVym(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Public_Int32_npMumqzPRMzfSptDjPuTYjZdaom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004759 RID: 18265 RVA: 0x0014A710 File Offset: 0x00148910
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286233, RefRangeEnd = 286234, XrefRangeStart = 286228, XrefRangeEnd = 286233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeMethodInfoPtr_erDFdKTfvESgSWsLwnpAGpsuuYq_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600475A RID: 18266 RVA: 0x00019DA5 File Offset: 0x00017FA5
			public knBBmjaPdrWnjApbPDVMfUScNkYM(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001635 RID: 5685
			// (get) Token: 0x0600475B RID: 18267 RVA: 0x0014A75C File Offset: 0x0014895C
			// (set) Token: 0x0600475C RID: 18268 RVA: 0x00019DAE File Offset: 0x00017FAE
			public unsafe List<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom> WZJGJlGHePZBbvenKyBJWpZyYjh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A1E RID: 14878
			private static readonly IntPtr NativeFieldInfoPtr_WZJGJlGHePZBbvenKyBJWpZyYjh;

			// Token: 0x04003A1F RID: 14879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A20 RID: 14880
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04003A21 RID: 14881
			private static readonly IntPtr NativeMethodInfoPtr_SSHSpllgEbFKZAcfnxanCbQQINM_Public_Void_SLKbGxbefIoyxmTrdMqskCIkfAEg_0;

			// Token: 0x04003A22 RID: 14882
			private static readonly IntPtr NativeMethodInfoPtr_pqUmJgCiRbkfcUyrXIMmpKcRSDB_Public_Boolean_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0;

			// Token: 0x04003A23 RID: 14883
			private static readonly IntPtr NativeMethodInfoPtr_FeJBcyYKxArwGpuqyYzBzZQRSWe_Public_IEnumerable_1_npMumqzPRMzfSptDjPuTYjZdaom_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0;

			// Token: 0x04003A24 RID: 14884
			private static readonly IntPtr NativeMethodInfoPtr_toLEPoWuMDQZlYmjvpYldRbMVym_Public_Int32_npMumqzPRMzfSptDjPuTYjZdaom_0;

			// Token: 0x04003A25 RID: 14885
			private static readonly IntPtr NativeMethodInfoPtr_erDFdKTfvESgSWsLwnpAGpsuuYq_Private_Void_Int32_Int32_0;

			// Token: 0x02000570 RID: 1392
			[OriginalName("Rewired_Core.dll", "", "QMzNwdSamLElDnBdjAwLYtYrSsE")]
			public enum QMzNwdSamLElDnBdjAwLYtYrSsE
			{
				// Token: 0x04004B75 RID: 19317
				CJqwAGOvfKqegUKvkxHubbFWiii,
				// Token: 0x04004B76 RID: 19318
				mIwObrpcXMetJnzJmAveEOGSsTo
			}

			// Token: 0x02000571 RID: 1393
			public class npMumqzPRMzfSptDjPuTYjZdaom : Object
			{
				// Token: 0x06005C6A RID: 23658 RVA: 0x00194B14 File Offset: 0x00192D14
				// Note: this type is marked as 'beforefieldinit'.
				static npMumqzPRMzfSptDjPuTYjZdaom()
				{
					Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, "npMumqzPRMzfSptDjPuTYjZdaom");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, "hpzYzQnGpdPZaJsQiWRLTcVKQEz");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, "woImURUGoBxfCkNnVjWGuFqAAXqh");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, "pdbGhwbnviCDKxCDecODnVAdAFp");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, "jlHBGpOvqXeiAbLzalgkocNbBdX");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, "BpppCsinCvwfaaBOZASWVxSBDSw");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Boolean_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, 100670557);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr, 100670558);
				}

				// Token: 0x06005C6B RID: 23659 RVA: 0x00194BCC File Offset: 0x00192DCC
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 286174, RefRangeEnd = 286177, XrefRangeStart = 286173, XrefRangeEnd = 286174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool fvOGAoKxBgCUFQBmLBDvnCAQduEb(ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg A_1, ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE A_2)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Boolean_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06005C6C RID: 23660 RVA: 0x00194C28 File Offset: 0x00192E28
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe npMumqzPRMzfSptDjPuTYjZdaom()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005C6D RID: 23661 RVA: 0x00022E49 File Offset: 0x00021049
				public npMumqzPRMzfSptDjPuTYjZdaom(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001CB2 RID: 7346
				// (get) Token: 0x06005C6E RID: 23662 RVA: 0x00194C64 File Offset: 0x00192E64
				// (set) Token: 0x06005C6F RID: 23663 RVA: 0x00022E52 File Offset: 0x00021052
				public unsafe int hpzYzQnGpdPZaJsQiWRLTcVKQEz
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz)) = value;
					}
				}

				// Token: 0x17001CB3 RID: 7347
				// (get) Token: 0x06005C70 RID: 23664 RVA: 0x00194C8C File Offset: 0x00192E8C
				// (set) Token: 0x06005C71 RID: 23665 RVA: 0x00022E6D File Offset: 0x0002106D
				public unsafe int woImURUGoBxfCkNnVjWGuFqAAXqh
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh)) = value;
					}
				}

				// Token: 0x17001CB4 RID: 7348
				// (get) Token: 0x06005C72 RID: 23666 RVA: 0x00194CB4 File Offset: 0x00192EB4
				// (set) Token: 0x06005C73 RID: 23667 RVA: 0x00022E88 File Offset: 0x00021088
				public unsafe string pdbGhwbnviCDKxCDecODnVAdAFp
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001CB5 RID: 7349
				// (get) Token: 0x06005C74 RID: 23668 RVA: 0x00194CDC File Offset: 0x00192EDC
				// (set) Token: 0x06005C75 RID: 23669 RVA: 0x00022EA7 File Offset: 0x000210A7
				public unsafe int jlHBGpOvqXeiAbLzalgkocNbBdX
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX)) = value;
					}
				}

				// Token: 0x17001CB6 RID: 7350
				// (get) Token: 0x06005C76 RID: 23670 RVA: 0x00194D04 File Offset: 0x00192F04
				// (set) Token: 0x06005C77 RID: 23671 RVA: 0x00022EC2 File Offset: 0x000210C2
				public unsafe string BpppCsinCvwfaaBOZASWVxSBDSw
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom.NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04004B77 RID: 19319
				private static readonly IntPtr NativeFieldInfoPtr_hpzYzQnGpdPZaJsQiWRLTcVKQEz;

				// Token: 0x04004B78 RID: 19320
				private static readonly IntPtr NativeFieldInfoPtr_woImURUGoBxfCkNnVjWGuFqAAXqh;

				// Token: 0x04004B79 RID: 19321
				private static readonly IntPtr NativeFieldInfoPtr_pdbGhwbnviCDKxCDecODnVAdAFp;

				// Token: 0x04004B7A RID: 19322
				private static readonly IntPtr NativeFieldInfoPtr_jlHBGpOvqXeiAbLzalgkocNbBdX;

				// Token: 0x04004B7B RID: 19323
				private static readonly IntPtr NativeFieldInfoPtr_BpppCsinCvwfaaBOZASWVxSBDSw;

				// Token: 0x04004B7C RID: 19324
				private static readonly IntPtr NativeMethodInfoPtr_fvOGAoKxBgCUFQBmLBDvnCAQduEb_Public_Boolean_SLKbGxbefIoyxmTrdMqskCIkfAEg_QMzNwdSamLElDnBdjAwLYtYrSsE_0;

				// Token: 0x04004B7D RID: 19325
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x02000572 RID: 1394
			public sealed class VWzCtflexGPuMcCKhhVAhwesIgd : Object
			{
				// Token: 0x06005C78 RID: 23672 RVA: 0x00194D2C File Offset: 0x00192F2C
				// Note: this type is marked as 'beforefieldinit'.
				static VWzCtflexGPuMcCKhhVAhwesIgd()
				{
					Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>.NativeClassPtr, "VWzCtflexGPuMcCKhhVAhwesIgd");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "nfdVmUBPUJnDFGllTjkjmnPgqRn");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "VwnghVzQOWJgAIuSwPgHwssqrse");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "SlayLftkgZoHYdeBJnNWQUqLKTb");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "yInDBaNvWqaWwtCWTdvLCMKfjvXu");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_WJjFfTrygGvqzWjCQalQKmzVLmpj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "WJjFfTrygGvqzWjCQalQKmzVLmpj");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, "jNBFAEjkzgoEDtIarJoUKhfdWwep");
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_FallbackInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_npMumqzPRMzfSptDjPuTYjZdaom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670559);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670560);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670561);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_FallbackInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_npMumqzPRMzfSptDjPuTYjZdaom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670562);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670563);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670564);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670565);
					ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr, 100670566);
				}

				// Token: 0x06005C79 RID: 23673 RVA: 0x00194EC0 File Offset: 0x001930C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286177, XrefRangeEnd = 286185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom> System_Collections_Generic_IEnumerable_Rewired_FallbackInputManager_JoystickRecords_Record__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_FallbackInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_npMumqzPRMzfSptDjPuTYjZdaom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>>(intPtr3) : null;
				}

				// Token: 0x06005C7A RID: 23674 RVA: 0x00194F00 File Offset: 0x00193100
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x06005C7B RID: 23675 RVA: 0x00194F40 File Offset: 0x00193140
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286185, XrefRangeEnd = 286190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001CC1 RID: 7361
				// (get) Token: 0x06005C7C RID: 23676 RVA: 0x00194F7C File Offset: 0x0019317C
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom lczgMWafozMpHMOzIUEmfdhGVwe
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_FallbackInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_npMumqzPRMzfSptDjPuTYjZdaom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>(intPtr3) : null;
					}
				}

				// Token: 0x06005C7D RID: 23677 RVA: 0x00194FBC File Offset: 0x001931BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286190, XrefRangeEnd = 286195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005C7E RID: 23678 RVA: 0x00194FF0 File Offset: 0x001931F0
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17001CC2 RID: 7362
				// (get) Token: 0x06005C7F RID: 23679 RVA: 0x00195024 File Offset: 0x00193224
				public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06005C80 RID: 23680 RVA: 0x00195064 File Offset: 0x00193264
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe VWzCtflexGPuMcCKhhVAhwesIgd(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005C81 RID: 23681 RVA: 0x00022EE1 File Offset: 0x000210E1
				public VWzCtflexGPuMcCKhhVAhwesIgd(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001CB7 RID: 7351
				// (get) Token: 0x06005C82 RID: 23682 RVA: 0x001950AC File Offset: 0x001932AC
				// (set) Token: 0x06005C83 RID: 23683 RVA: 0x00022EEA File Offset: 0x000210EA
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom NuVnrlTavvGYEgMZhwgjSLwilSSG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.npMumqzPRMzfSptDjPuTYjZdaom>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CB8 RID: 7352
				// (get) Token: 0x06005C84 RID: 23684 RVA: 0x001950DC File Offset: 0x001932DC
				// (set) Token: 0x06005C85 RID: 23685 RVA: 0x00022F09 File Offset: 0x00021109
				public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
					}
				}

				// Token: 0x17001CB9 RID: 7353
				// (get) Token: 0x06005C86 RID: 23686 RVA: 0x00195104 File Offset: 0x00193304
				// (set) Token: 0x06005C87 RID: 23687 RVA: 0x00022F24 File Offset: 0x00021124
				public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
					}
				}

				// Token: 0x17001CBA RID: 7354
				// (get) Token: 0x06005C88 RID: 23688 RVA: 0x0019512C File Offset: 0x0019332C
				// (set) Token: 0x06005C89 RID: 23689 RVA: 0x00022F3F File Offset: 0x0002113F
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM HbFBVXVdulMdGSmvVCgeOcAyoyn
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CBB RID: 7355
				// (get) Token: 0x06005C8A RID: 23690 RVA: 0x0019515C File Offset: 0x0019335C
				// (set) Token: 0x06005C8B RID: 23691 RVA: 0x00022F5E File Offset: 0x0002115E
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg nfdVmUBPUJnDFGllTjkjmnPgqRn
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CBC RID: 7356
				// (get) Token: 0x06005C8C RID: 23692 RVA: 0x0019518C File Offset: 0x0019338C
				// (set) Token: 0x06005C8D RID: 23693 RVA: 0x00022F7D File Offset: 0x0002117D
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg VwnghVzQOWJgAIuSwPgHwssqrse
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZpmijvYLlfoeyrwRFxAigEqvAXD.SLKbGxbefIoyxmTrdMqskCIkfAEg>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CBD RID: 7357
				// (get) Token: 0x06005C8E RID: 23694 RVA: 0x001951BC File Offset: 0x001933BC
				// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00022F9C File Offset: 0x0002119C
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE SlayLftkgZoHYdeBJnNWQUqLKTb
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb)) = value;
					}
				}

				// Token: 0x17001CBE RID: 7358
				// (get) Token: 0x06005C90 RID: 23696 RVA: 0x001951E4 File Offset: 0x001933E4
				// (set) Token: 0x06005C91 RID: 23697 RVA: 0x00022FB7 File Offset: 0x000211B7
				public unsafe ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.QMzNwdSamLElDnBdjAwLYtYrSsE yInDBaNvWqaWwtCWTdvLCMKfjvXu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu)) = value;
					}
				}

				// Token: 0x17001CBF RID: 7359
				// (get) Token: 0x06005C92 RID: 23698 RVA: 0x0019520C File Offset: 0x0019340C
				// (set) Token: 0x06005C93 RID: 23699 RVA: 0x00022FD2 File Offset: 0x000211D2
				public unsafe int WJjFfTrygGvqzWjCQalQKmzVLmpj
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_WJjFfTrygGvqzWjCQalQKmzVLmpj);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_WJjFfTrygGvqzWjCQalQKmzVLmpj)) = value;
					}
				}

				// Token: 0x17001CC0 RID: 7360
				// (get) Token: 0x06005C94 RID: 23700 RVA: 0x00195234 File Offset: 0x00193434
				// (set) Token: 0x06005C95 RID: 23701 RVA: 0x00022FED File Offset: 0x000211ED
				public unsafe int jNBFAEjkzgoEDtIarJoUKhfdWwep
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZpmijvYLlfoeyrwRFxAigEqvAXD.knBBmjaPdrWnjApbPDVMfUScNkYM.VWzCtflexGPuMcCKhhVAhwesIgd.NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep)) = value;
					}
				}

				// Token: 0x04004B7E RID: 19326
				private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

				// Token: 0x04004B7F RID: 19327
				private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

				// Token: 0x04004B80 RID: 19328
				private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

				// Token: 0x04004B81 RID: 19329
				private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

				// Token: 0x04004B82 RID: 19330
				private static readonly IntPtr NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn;

				// Token: 0x04004B83 RID: 19331
				private static readonly IntPtr NativeFieldInfoPtr_VwnghVzQOWJgAIuSwPgHwssqrse;

				// Token: 0x04004B84 RID: 19332
				private static readonly IntPtr NativeFieldInfoPtr_SlayLftkgZoHYdeBJnNWQUqLKTb;

				// Token: 0x04004B85 RID: 19333
				private static readonly IntPtr NativeFieldInfoPtr_yInDBaNvWqaWwtCWTdvLCMKfjvXu;

				// Token: 0x04004B86 RID: 19334
				private static readonly IntPtr NativeFieldInfoPtr_WJjFfTrygGvqzWjCQalQKmzVLmpj;

				// Token: 0x04004B87 RID: 19335
				private static readonly IntPtr NativeFieldInfoPtr_jNBFAEjkzgoEDtIarJoUKhfdWwep;

				// Token: 0x04004B88 RID: 19336
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_FallbackInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_npMumqzPRMzfSptDjPuTYjZdaom_0;

				// Token: 0x04004B89 RID: 19337
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

				// Token: 0x04004B8A RID: 19338
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04004B8B RID: 19339
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_FallbackInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_npMumqzPRMzfSptDjPuTYjZdaom_0;

				// Token: 0x04004B8C RID: 19340
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04004B8D RID: 19341
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04004B8E RID: 19342
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004B8F RID: 19343
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
			}
		}
	}
}
