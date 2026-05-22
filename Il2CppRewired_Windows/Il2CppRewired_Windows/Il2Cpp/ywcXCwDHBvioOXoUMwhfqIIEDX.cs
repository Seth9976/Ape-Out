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
using Il2CppRewired.Utils.Classes.Data;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x0200000B RID: 11
	public class ywcXCwDHBvioOXoUMwhfqIIEDX : PlatformInputManager
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000BE98 File Offset: 0x0000A098
		// Note: this type is marked as 'beforefieldinit'.
		static ywcXCwDHBvioOXoUMwhfqIIEDX()
		{
			Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "ywcXCwDHBvioOXoUMwhfqIIEDX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_rpqPaWSQWIkiOAfZVIdvTcjKAdV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "rpqPaWSQWIkiOAfZVIdvTcjKAdV");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_oNfkxYIAzFHuBAVEwgyvzhRWIJI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "oNfkxYIAzFHuBAVEwgyvzhRWIJI");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "VnLufxclyjGsMiGdTbUEAvtMFIT");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "gZEqoosEOGLFarcAdrRuSzTDTbJ");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "OGMAvYfEinNsarzsJCSCDmxKLFH");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_EMADpnrjPGqREOMHHjnuapxKQZM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "EMADpnrjPGqREOMHHjnuapxKQZM");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "xSmScWUrtttKopPpVEMnBxFcRXCS");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_SrqzsXQfGxxLkHFtLzuLuvHggkH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "SrqzsXQfGxxLkHFtLzuLuvHggkH");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "XgoiTRQUwWofwNpljdXDpYGrJws");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "HpCxuedDaobbAMjVDkAdFgnGlZr");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "MMZGKCecFzCSjjpobYLpwBUdwTl");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "MbJqwIRGZjMByqVJbovfaJVENbo");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_hniAgNVyqkErumJPXpeheLByNho = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "hniAgNVyqkErumJPXpeheLByNho");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_HxRmmcCrisjjefZlIStWLDZFGYVr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "HxRmmcCrisjjefZlIStWLDZFGYVr");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_NFwKcIjrZkMoiBEUwuKLXwWIogF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "NFwKcIjrZkMoiBEUwuKLXwWIogF");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "rlvhAvIIAgpzhGBspLOycKQmvkk");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "LakZHHdbozgBEgMhvUQKIaOsnnRh");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "swOzpxtgHdYlzNpDnxeXdFTTYrt");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "bAJbZUeRbxcwwdOPEAlIzFuHOjFq");
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_set_useXInput_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663365);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_IntPtr_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663366);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663367);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663368);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663369);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663370);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663371);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663372);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663373);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663374);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663375);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663376);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663377);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663378);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663379);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663380);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_DOtZFoPISBlRmBZmWXLeooOlsJx_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663381);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_nUYkbMQGVGGFomYIYzWpddZDAWo_Private_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663382);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_tovcOpHbECiuVOgwphJdMHIACcAe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663383);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_ADWFpmGnZeGcjEFYjJwQLrsvEsMe_Private_Void_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663384);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_zulVMSQVXbOdtZJgLnCboljZaji_Private_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_DMMGgLblCGPuiOGzYlOxiKOJqkqD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663385);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_eUzGvVUIDBdVAlTwoSBTtvOgnkA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663386);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_ehbhoQsRTbPsMsRpabDWrdgddmH_Private_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663387);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_exGmXxEDGdDUjPciPZnhaLBfcRa_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663388);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_RILvUEHqHImXpPCOJUkVLtrWrcb_Private_Void_Int32_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663389);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_qyJAFNQSxZQeRPMJIUlWtHQetPp_Private_Boolean_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663390);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_qkhSrSJBYhuwODeqVgWOAprxBhM_Private_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663391);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_knYfclcTzqWOQszkLRzAvrLkhCM_Private_Boolean_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663392);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_VAJvFwueMAlPhoBbQOgviANMjaD_Private_Void_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663393);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_FLJDHmUfZvztSSljfKRvIaGPIoQh_Private_Void_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663394);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_kxWbhrhqsolWqShUGIHarQbrYPol_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663395);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_CDmuLAoFhwtaSWPsPbdneZlYfjKs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663396);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663397);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_qCXWcepcJrbsdOZfKVkyJUauWqE_Private_Boolean_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663398);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_fQgfztDwUDUNJOBmZpOcNxfRKsd_Private_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663399);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_MCgSEQNrgvEGbagLgasSJfLlcuC_Private_Boolean_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663400);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SXGflLsFwiXQRfevxwahWooILCt_Private_Void_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663401);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663402);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_IOrkaQXLGpOjfAKliuKmlSVeUTl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663403);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_EnXbTpIVKXeroPUHvejSvtWDJKJv_Private_Void_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663404);
			ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_gXpSbeOfQpSJvyffCaiRkmliKqc_Private_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, 100663405);
		}

		// Token: 0x1700002B RID: 43
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000C378 File Offset: 0x0000A578
		public unsafe virtual bool wfvqYGGPIizvUGgiRDuPHaBxHJUC
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_set_useXInput_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349234, RefRangeEnd = 349235, XrefRangeStart = 349194, XrefRangeEnd = 349234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX(UpdateLoopSetting updateLoopSetting, bool useXInput, IntPtr windowHandle, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoopSetting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useXInput;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref windowHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getNewJoystickId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_IntPtr_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000C444 File Offset: 0x0000A644
		public unsafe override int deviceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000C48C File Offset: 0x0000A68C
		public unsafe override PlatformInputManager primaryInputManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		public unsafe override IInputSource inputSource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349235, XrefRangeEnd = 349239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000C524 File Offset: 0x0000A724
		public unsafe override InputSource inputSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000C56C File Offset: 0x0000A76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349239, XrefRangeEnd = 349255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349255, XrefRangeEnd = 349268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349268, XrefRangeEnd = 349287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000C630 File Offset: 0x0000A830
		[CallerCount(0)]
		public unsafe override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr3) : null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000C67C File Offset: 0x0000A87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349287, XrefRangeEnd = 349306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349306, XrefRangeEnd = 349308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000C714 File Offset: 0x0000A914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349308, XrefRangeEnd = 349310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000C750 File Offset: 0x0000A950
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		[CallerCount(0)]
		public unsafe override IUnifiedMouseSource GetUnifiedMouseSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		[CallerCount(0)]
		public unsafe override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr3) : null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000C840 File Offset: 0x0000AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349310, XrefRangeEnd = 349318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DOtZFoPISBlRmBZmWXLeooOlsJx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_DOtZFoPISBlRmBZmWXLeooOlsJx_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000C874 File Offset: 0x0000AA74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 349426, RefRangeEnd = 349429, XrefRangeStart = 349318, XrefRangeEnd = 349426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW> nUYkbMQGVGGFomYIYzWpddZDAWo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_nUYkbMQGVGGFomYIYzWpddZDAWo_Private_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>>(intPtr3) : null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349429, XrefRangeEnd = 349431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void tovcOpHbECiuVOgwphJdMHIACcAe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_tovcOpHbECiuVOgwphJdMHIACcAe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 349470, RefRangeEnd = 349474, XrefRangeStart = 349431, XrefRangeEnd = 349470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ADWFpmGnZeGcjEFYjJwQLrsvEsMe(List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_ADWFpmGnZeGcjEFYjJwQLrsvEsMe_Private_Void_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C92C File Offset: 0x0000AB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349504, RefRangeEnd = 349505, XrefRangeStart = 349474, XrefRangeEnd = 349504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zulVMSQVXbOdtZJgLnCboljZaji(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1, DMMGgLblCGPuiOGzYlOxiKOJqkqD A_2, out string A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_zulVMSQVXbOdtZJgLnCboljZaji_Private_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_DMMGgLblCGPuiOGzYlOxiKOJqkqD_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			A_3 = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C99C File Offset: 0x0000AB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349516, RefRangeEnd = 349517, XrefRangeStart = 349505, XrefRangeEnd = 349516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void eUzGvVUIDBdVAlTwoSBTtvOgnkA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_eUzGvVUIDBdVAlTwoSBTtvOgnkA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349526, RefRangeEnd = 349527, XrefRangeStart = 349517, XrefRangeEnd = 349526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<aebqsBAEhVilJeqHZosRvGGRxlb> ehbhoQsRTbPsMsRpabDWrdgddmH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_ehbhoQsRTbPsMsRpabDWrdgddmH_Private_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<aebqsBAEhVilJeqHZosRvGGRxlb>>(intPtr3) : null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000CA10 File Offset: 0x0000AC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349527, XrefRangeEnd = 349529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void exGmXxEDGdDUjPciPZnhaLBfcRa()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_exGmXxEDGdDUjPciPZnhaLBfcRa_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000CA44 File Offset: 0x0000AC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349567, RefRangeEnd = 349568, XrefRangeStart = 349529, XrefRangeEnd = 349567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RILvUEHqHImXpPCOJUkVLtrWrcb(int A_1, int A_2, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_3, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_4)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_RILvUEHqHImXpPCOJUkVLtrWrcb_Private_Void_Int32_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349570, RefRangeEnd = 349571, XrefRangeStart = 349568, XrefRangeEnd = 349570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qyJAFNQSxZQeRPMJIUlWtHQetPp(List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_qyJAFNQSxZQeRPMJIUlWtHQetPp_Private_Boolean_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000CB14 File Offset: 0x0000AD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349573, RefRangeEnd = 349574, XrefRangeStart = 349571, XrefRangeEnd = 349573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int qkhSrSJBYhuwODeqVgWOAprxBhM(List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_qkhSrSJBYhuwODeqVgWOAprxBhM_Private_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000CB64 File Offset: 0x0000AD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349577, RefRangeEnd = 349578, XrefRangeStart = 349574, XrefRangeEnd = 349577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool knYfclcTzqWOQszkLRzAvrLkhCM(List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_knYfclcTzqWOQszkLRzAvrLkhCM_Private_Boolean_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349578, XrefRangeEnd = 349585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VAJvFwueMAlPhoBbQOgviANMjaD(int A_1, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_2, int A_3, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_4, ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.dPjibqvlOuPAdLsHbQeuqCgpqFl A_5)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_VAJvFwueMAlPhoBbQOgviANMjaD_Private_Void_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000CC40 File Offset: 0x0000AE40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349604, RefRangeEnd = 349606, XrefRangeStart = 349585, XrefRangeEnd = 349604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FLJDHmUfZvztSSljfKRvIaGPIoQh(int A_1, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_2, ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.dPjibqvlOuPAdLsHbQeuqCgpqFl A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_FLJDHmUfZvztSSljfKRvIaGPIoQh_Private_Void_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349627, RefRangeEnd = 349628, XrefRangeStart = 349606, XrefRangeEnd = 349627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void kxWbhrhqsolWqShUGIHarQbrYPol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_kxWbhrhqsolWqShUGIHarQbrYPol_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349628, XrefRangeEnd = 349632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CDmuLAoFhwtaSWPsPbdneZlYfjKs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_CDmuLAoFhwtaSWPsPbdneZlYfjKs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349632, XrefRangeEnd = 349646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BYAEaHJnSzdqqawqWqIvjtCnpnz(List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349667, RefRangeEnd = 349669, XrefRangeStart = 349646, XrefRangeEnd = 349667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qCXWcepcJrbsdOZfKVkyJUauWqE(IList<aebqsBAEhVilJeqHZosRvGGRxlb> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_qCXWcepcJrbsdOZfKVkyJUauWqE_Private_Boolean_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349684, RefRangeEnd = 349685, XrefRangeStart = 349669, XrefRangeEnd = 349684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool fQgfztDwUDUNJOBmZpOcNxfRKsd(Guid A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_fQgfztDwUDUNJOBmZpOcNxfRKsd_Private_Boolean_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349695, RefRangeEnd = 349696, XrefRangeStart = 349685, XrefRangeEnd = 349695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MCgSEQNrgvEGbagLgasSJfLlcuC(IList<aebqsBAEhVilJeqHZosRvGGRxlb> A_1, Guid A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_MCgSEQNrgvEGbagLgasSJfLlcuC_Private_Boolean_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000CE44 File Offset: 0x0000B044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349707, RefRangeEnd = 349709, XrefRangeStart = 349696, XrefRangeEnd = 349707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SXGflLsFwiXQRfevxwahWooILCt(List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_1, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_2, bool A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_SXGflLsFwiXQRfevxwahWooILCt_Private_Void_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349719, RefRangeEnd = 349720, XrefRangeStart = 349709, XrefRangeEnd = 349719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void uRkEmxgrfgrTYABDMNLqkschCkE(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349720, XrefRangeEnd = 349722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IOrkaQXLGpOjfAKliuKmlSVeUTl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_IOrkaQXLGpOjfAKliuKmlSVeUTl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000CF34 File Offset: 0x0000B134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349722, XrefRangeEnd = 349729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnXbTpIVKXeroPUHvejSvtWDJKJv(List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_1, List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_EnXbTpIVKXeroPUHvejSvtWDJKJv_Private_Void_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000CF88 File Offset: 0x0000B188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349729, XrefRangeEnd = 349730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW> gXpSbeOfQpSJvyffCaiRkmliKqc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeMethodInfoPtr_gXpSbeOfQpSJvyffCaiRkmliKqc_Private_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>>(intPtr3) : null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000022F7 File Offset: 0x000004F7
		public ywcXCwDHBvioOXoUMwhfqIIEDX(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002300 File Offset: 0x00000500
		public unsafe IntPtr rpqPaWSQWIkiOAfZVIdvTcjKAdV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_rpqPaWSQWIkiOAfZVIdvTcjKAdV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_rpqPaWSQWIkiOAfZVIdvTcjKAdV)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000231B File Offset: 0x0000051B
		public unsafe lYzRVWAYwwjqOQjIKypoKfLheCI oNfkxYIAzFHuBAVEwgyvzhRWIJI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_oNfkxYIAzFHuBAVEwgyvzhRWIJI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<lYzRVWAYwwjqOQjIKypoKfLheCI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_oNfkxYIAzFHuBAVEwgyvzhRWIJI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000D020 File Offset: 0x0000B220
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000233A File Offset: 0x0000053A
		public unsafe List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw> VnLufxclyjGsMiGdTbUEAvtMFIT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000D050 File Offset: 0x0000B250
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe int gZEqoosEOGLFarcAdrRuSzTDTbJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000D078 File Offset: 0x0000B278
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002374 File Offset: 0x00000574
		public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld OGMAvYfEinNsarzsJCSCDmxKLFH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002393 File Offset: 0x00000593
		public unsafe bool EMADpnrjPGqREOMHHjnuapxKQZM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_EMADpnrjPGqREOMHHjnuapxKQZM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_EMADpnrjPGqREOMHHjnuapxKQZM)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000023AE File Offset: 0x000005AE
		public unsafe bool xSmScWUrtttKopPpVEMnBxFcRXCS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000023C9 File Offset: 0x000005C9
		public unsafe UpdateLoopSetting SrqzsXQfGxxLkHFtLzuLuvHggkH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_SrqzsXQfGxxLkHFtLzuLuvHggkH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_SrqzsXQfGxxLkHFtLzuLuvHggkH)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000D120 File Offset: 0x0000B320
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000023E4 File Offset: 0x000005E4
		public unsafe Action<int, ControllerDataUpdater> XgoiTRQUwWofwNpljdXDpYGrJws
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000D150 File Offset: 0x0000B350
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002403 File Offset: 0x00000603
		public unsafe PlatformInputManager HpCxuedDaobbAMjVDkAdFgnGlZr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000D180 File Offset: 0x0000B380
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002422 File Offset: 0x00000622
		public unsafe TimerRealTime MMZGKCecFzCSjjpobYLpwBUdwTl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerRealTime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002441 File Offset: 0x00000641
		public unsafe MixEZdcyOILrKdCCWuLKJJMVEyRk<bool> MbJqwIRGZjMByqVJbovfaJVENbo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixEZdcyOILrKdCCWuLKJJMVEyRk<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002460 File Offset: 0x00000660
		public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr hniAgNVyqkErumJPXpeheLByNho
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_hniAgNVyqkErumJPXpeheLByNho);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_hniAgNVyqkErumJPXpeheLByNho), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000D210 File Offset: 0x0000B410
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000247F File Offset: 0x0000067F
		public unsafe int HxRmmcCrisjjefZlIStWLDZFGYVr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_HxRmmcCrisjjefZlIStWLDZFGYVr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_HxRmmcCrisjjefZlIStWLDZFGYVr)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000D238 File Offset: 0x0000B438
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe int NFwKcIjrZkMoiBEUwuKLXwWIogF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_NFwKcIjrZkMoiBEUwuKLXwWIogF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_NFwKcIjrZkMoiBEUwuKLXwWIogF)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000024B5 File Offset: 0x000006B5
		public unsafe MixEZdcyOILrKdCCWuLKJJMVEyRk<List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>> rlvhAvIIAgpzhGBspLOycKQmvkk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixEZdcyOILrKdCCWuLKJJMVEyRk<List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000D290 File Offset: 0x0000B490
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000024D4 File Offset: 0x000006D4
		public unsafe Object LakZHHdbozgBEgMhvUQKIaOsnnRh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024F3 File Offset: 0x000006F3
		public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> swOzpxtgHdYlzNpDnxeXdFTTYrt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002512 File Offset: 0x00000712
		public unsafe Func<int> bAJbZUeRbxcwwdOPEAlIzFuHOjFq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_rpqPaWSQWIkiOAfZVIdvTcjKAdV;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_oNfkxYIAzFHuBAVEwgyvzhRWIJI;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_EMADpnrjPGqREOMHHjnuapxKQZM;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_SrqzsXQfGxxLkHFtLzuLuvHggkH;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_hniAgNVyqkErumJPXpeheLByNho;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_HxRmmcCrisjjefZlIStWLDZFGYVr;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_NFwKcIjrZkMoiBEUwuKLXwWIogF;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_set_useXInput_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_IntPtr_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_DOtZFoPISBlRmBZmWXLeooOlsJx_Private_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_nUYkbMQGVGGFomYIYzWpddZDAWo_Private_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_tovcOpHbECiuVOgwphJdMHIACcAe_Private_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_ADWFpmGnZeGcjEFYjJwQLrsvEsMe_Private_Void_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_zulVMSQVXbOdtZJgLnCboljZaji_Private_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_DMMGgLblCGPuiOGzYlOxiKOJqkqD_byref_String_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_eUzGvVUIDBdVAlTwoSBTtvOgnkA_Private_Void_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_ehbhoQsRTbPsMsRpabDWrdgddmH_Private_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_exGmXxEDGdDUjPciPZnhaLBfcRa_Private_Void_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_RILvUEHqHImXpPCOJUkVLtrWrcb_Private_Void_Int32_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_qyJAFNQSxZQeRPMJIUlWtHQetPp_Private_Boolean_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_qkhSrSJBYhuwODeqVgWOAprxBhM_Private_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_knYfclcTzqWOQszkLRzAvrLkhCM_Private_Boolean_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_VAJvFwueMAlPhoBbQOgviANMjaD_Private_Void_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_FLJDHmUfZvztSSljfKRvIaGPIoQh_Private_Void_Int32_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_kxWbhrhqsolWqShUGIHarQbrYPol_Private_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_CDmuLAoFhwtaSWPsPbdneZlYfjKs_Private_Void_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_qCXWcepcJrbsdOZfKVkyJUauWqE_Private_Boolean_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_fQgfztDwUDUNJOBmZpOcNxfRKsd_Private_Boolean_Guid_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_MCgSEQNrgvEGbagLgasSJfLlcuC_Private_Boolean_IList_1_aebqsBAEhVilJeqHZosRvGGRxlb_Guid_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_SXGflLsFwiXQRfevxwahWooILCt_Private_Void_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_IOrkaQXLGpOjfAKliuKmlSVeUTl_Private_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_EnXbTpIVKXeroPUHvejSvtWDJKJv_Private_Void_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_List_1_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_gXpSbeOfQpSJvyffCaiRkmliKqc_Private_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0;

		// Token: 0x020000B6 RID: 182
		public class iHSGdmFZhWkJBBLEQPSmDckqrFUw : Object
		{
			// Token: 0x06000C4B RID: 3147 RVA: 0x00035598 File Offset: 0x00033798
			// Note: this type is marked as 'beforefieldinit'.
			static iHSGdmFZhWkJBBLEQPSmDckqrFUw()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "iHSGdmFZhWkJBBLEQPSmDckqrFUw");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "GNKcpIRbTxVSstxcCBqZKkcbietE");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "JFhGUotVGyvgqRcgpmFnXSQrssJ");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "WmRdwFvHdKGkxAZMIAvntNHLbaxg");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "WLPWeHrDCPCLfETsRQYzcumJyOe");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "xAEQkKEmsgGlqDEpuAlHEcNWauNE");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "lqBzATSuHgWwXfTJMPicOqKhLIc");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_bArWKXqJfPoaoIGnCMdYqoSRdOw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "bArWKXqJfPoaoIGnCMdYqoSRdOw");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "xcraKzUBKKbqrrMoJhsaaxGOFXRT");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "XweWIFEyvCMnXulreJEhSfAAWOo");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "ePNBvlGnonVgXbSNyjfUvrOPppq");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "pFkVRJEPoSBxlAjsHKMcxCzbNGQ");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "lzufHdDGBKQEIiVjiKYtKEEDzaGM");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "BLfxWbmyTsFYizOjLnroMuVRaUd");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "zRSLRumgAHYvaVfMhktxhOcdJEz");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "AvCqApdLGDXHFPBkTTaAQSVHPfK");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "UOiadLOPlNhsLbNzLGQXTPSGUrP");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xuEqFOsehiRavyALxlGGzCCzqoA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "xuEqFOsehiRavyALxlGGzCCzqoA");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "xnwhPiSLJZAWeXtpbVDLHoIbBMl");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "ilvTWYfRywhZpsIyUtQNREFcjLsj");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "uJThHFvMnnGWlhGgONRMIioDKZOj");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "fMsDvvtAhFIJLgiqYmvGYlgVARM");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "OZweyeiUbnDOuxpLuoupDMKOgVli");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "DvJhuGjaHKRdHunWyrEKRNDBrab");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "CwSFCVqDCbrQyrvPmmvtgaAynZj");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "sHeRoiRHkuXpbNwEMmzznSiAEVf");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "OHFiyNAurvAHndtKvlMxUsQwcRc");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "swOzpxtgHdYlzNpDnxeXdFTTYrt");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "lNjuiEzDctUBliWAKQtnwVRUssh");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "KmDzQOsJBlrBVPwQvpSIJVwVAej");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, "qCyeROasFnJmaEJMACZydOijuQgZ");
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663406);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663407);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663408);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663409);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663410);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663411);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663412);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663413);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663414);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663415);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663416);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663417);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr__ctor_Public_Void_TttPXAkanrujAZxEVnuNwvIODaB_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663418);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_jgeCBEMtzKMTxBWHKEzsNZSbcZA_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663419);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663420);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663421);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663422);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663423);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Private_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663424);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663425);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663426);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_VmiVIlKWEBlLoMJdCnarRONAJqD_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663427);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_WEOaJEBvHWsfDwuxnYgvTkTvLxZ_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663428);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663429);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663430);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_MnKfNqjxLlxeBKgTKVckDkWYfiXR_Private_Void_Axis_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663431);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_MCTjNTarCEETqZZnpAEOspBfjIV_Private_Void_Button_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663432);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663433);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_DirectInputAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663434);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_Button_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663435);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_vHPFVpeYMSXPpVGDKlRsxYWNAxN_Private_Boolean_Int32_Int32_HatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663436);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_mARCrvdmUYeEwAQXLmQRoaZYrBx_Private_Single_Int32_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663437);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_kJNGlsEDqDckESXjfROGpyQJlMx_Private_Boolean_CustomCalculationSourceData_Il2CppStructArray_1_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663438);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ROElGxvxwjOsQqbtUxHVBlYTlwS_Private_Boolean_CustomCalculationSourceData_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663439);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_eJqOxNBuOQSNBgbLPUtHZbPgVfC_Private_ControlDeviceType_NjSaotJqTqBjFgJfQtXFAQMDfCL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663440);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663441);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_UvMBqJGTnIKBwBtTdbzqNPjaUYJe_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663442);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663443);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663444);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_GSGWoDIqRLoSTVEGPZGnWuXPYcg_Private_Il2CppReferenceArray_1_UnknownControllerHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663445);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663446);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663447);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663448);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_rLdrhGzCsEudhqVRALmAGTDyhaD_Public_Static_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663449);
				ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_MdlbbWPBfliYJpFiRWMnbrISlOH_Public_Static_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr, 100663450);
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00035BA0 File Offset: 0x00033DA0
			// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00035BDC File Offset: 0x00033DDC
			public unsafe virtual int rewiredId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00035C1C File Offset: 0x00033E1C
			// (set) Token: 0x06000C4F RID: 3151 RVA: 0x00035C58 File Offset: 0x00033E58
			public unsafe virtual int inputManagerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00035C98 File Offset: 0x00033E98
			public unsafe virtual string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348164, XrefRangeEnd = 348166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00035CD0 File Offset: 0x00033ED0
			public unsafe virtual Nullable<long> systemId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348166, XrefRangeEnd = 348167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00035D08 File Offset: 0x00033F08
			public unsafe virtual int unityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00035D44 File Offset: 0x00033F44
			public unsafe virtual Controller.Extension extension
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
				}
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00035D84 File Offset: 0x00033F84
			public unsafe virtual Guid instanceGuid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00035DC0 File Offset: 0x00033FC0
			public unsafe virtual Guid persistentGuid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C56 RID: 3158 RVA: 0x00035DFC File Offset: 0x00033FFC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C57 RID: 3159 RVA: 0x00035E48 File Offset: 0x00034048
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void StopVibration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C58 RID: 3160 RVA: 0x00035E7C File Offset: 0x0003407C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348167, RefRangeEnd = 348168, XrefRangeStart = 348167, XrefRangeEnd = 348167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe iHSGdmFZhWkJBBLEQPSmDckqrFUw(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceJoystick);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr__ctor_Public_Void_TttPXAkanrujAZxEVnuNwvIODaB_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C59 RID: 3161 RVA: 0x00035EDC File Offset: 0x000340DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348202, RefRangeEnd = 348203, XrefRangeStart = 348168, XrefRangeEnd = 348202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void jgeCBEMtzKMTxBWHKEzsNZSbcZA()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_jgeCBEMtzKMTxBWHKEzsNZSbcZA_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C5A RID: 3162 RVA: 0x00035F10 File Offset: 0x00034110
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348206, RefRangeEnd = 348208, XrefRangeStart = 348203, XrefRangeEnd = 348206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void nmYEDBcicBHXDwuAcMZQWyZRpHE(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x00035F54 File Offset: 0x00034154
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348229, RefRangeEnd = 348231, XrefRangeStart = 348208, XrefRangeEnd = 348229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x00035F88 File Offset: 0x00034188
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348231, RefRangeEnd = 348232, XrefRangeStart = 348231, XrefRangeEnd = 348231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void FillData(ControllerDataUpdater dataUpdater)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x00035FCC File Offset: 0x000341CC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348239, RefRangeEnd = 348241, XrefRangeStart = 348232, XrefRangeEnd = 348239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int PpfFXDqHyUXaiMeJUppAtMDNqvi(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C5E RID: 3166 RVA: 0x0003601C File Offset: 0x0003421C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348241, XrefRangeEnd = 348245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BridgedControllerHWInfo QkACchszAolJQBMMsHcyPLktlPB()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Private_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedControllerHWInfo>(intPtr3) : null;
			}

			// Token: 0x06000C5F RID: 3167 RVA: 0x0003605C File Offset: 0x0003425C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348245, XrefRangeEnd = 348249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual BridgedController ToBridgedController()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedController>(intPtr3) : null;
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x0003609C File Offset: 0x0003429C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348249, XrefRangeEnd = 348255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDisconnectedEventArgs>(intPtr3) : null;
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x000360DC File Offset: 0x000342DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348261, RefRangeEnd = 348262, XrefRangeStart = 348255, XrefRangeEnd = 348261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool VmiVIlKWEBlLoMJdCnarRONAJqD()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_VmiVIlKWEBlLoMJdCnarRONAJqD_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x00036118 File Offset: 0x00034318
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348264, RefRangeEnd = 348265, XrefRangeStart = 348262, XrefRangeEnd = 348264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WEOaJEBvHWsfDwuxnYgvTkTvLxZ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_WEOaJEBvHWsfDwuxnYgvTkTvLxZ_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C63 RID: 3171 RVA: 0x0003614C File Offset: 0x0003434C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348273, RefRangeEnd = 348274, XrefRangeStart = 348265, XrefRangeEnd = 348273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RUgKGlELCQBBrmrOvYkKJbAGPIE(Il2CppStructArray<bool> A_1, Il2CppStructArray<int> A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C64 RID: 3172 RVA: 0x000361A0 File Offset: 0x000343A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348282, RefRangeEnd = 348283, XrefRangeStart = 348274, XrefRangeEnd = 348282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ipocWZvAxAdXermpojWFHIJHbTFS(Il2CppStructArray<bool> A_1, Il2CppStructArray<int> A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x000361F4 File Offset: 0x000343F4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348284, RefRangeEnd = 348286, XrefRangeStart = 348283, XrefRangeEnd = 348284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MnKfNqjxLlxeBKgTKVckDkWYfiXR(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base A_1, int A_2, Il2CppStructArray<bool> A_3, Il2CppStructArray<int> A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_MnKfNqjxLlxeBKgTKVckDkWYfiXR_Private_Void_Axis_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C66 RID: 3174 RVA: 0x0003626C File Offset: 0x0003446C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348287, RefRangeEnd = 348289, XrefRangeStart = 348286, XrefRangeEnd = 348287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MCTjNTarCEETqZZnpAEOspBfjIV(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base A_1, int A_2, Il2CppStructArray<bool> A_3, Il2CppStructArray<int> A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_MCTjNTarCEETqZZnpAEOspBfjIV_Private_Void_Button_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x000362E4 File Offset: 0x000344E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348290, RefRangeEnd = 348291, XrefRangeStart = 348289, XrefRangeEnd = 348290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float BlNbZUiJZlAsIpeFJrmqKMdIohR(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base A_1, Il2CppStructArray<bool> A_2, Il2CppStructArray<int> A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x00036358 File Offset: 0x00034558
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348291, RefRangeEnd = 348292, XrefRangeStart = 348291, XrefRangeEnd = 348291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float BlNbZUiJZlAsIpeFJrmqKMdIohR(DirectInputAxis A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_DirectInputAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C69 RID: 3177 RVA: 0x000363A4 File Offset: 0x000345A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348311, RefRangeEnd = 348312, XrefRangeStart = 348292, XrefRangeEnd = 348311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool vGIDntSyHOcwKzWObiWxnUfsrtQ(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base A_1, Il2CppStructArray<bool> A_2, Il2CppStructArray<int> A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_Button_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x00036418 File Offset: 0x00034618
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348314, RefRangeEnd = 348315, XrefRangeStart = 348312, XrefRangeEnd = 348314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool vHPFVpeYMSXPpVGDKlRsxYWNAxN(int A_1, int A_2, HatType A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_vHPFVpeYMSXPpVGDKlRsxYWNAxN_Private_Boolean_Int32_Int32_HatType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x00036480 File Offset: 0x00034680
			[CallerCount(0)]
			public unsafe float mARCrvdmUYeEwAQXLmQRoaZYrBx(int A_1, AxisDirection A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_mARCrvdmUYeEwAQXLmQRoaZYrBx_Private_Single_Int32_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x000364D8 File Offset: 0x000346D8
			[CallerCount(0)]
			public unsafe bool kJNGlsEDqDckESXjfROGpyQJlMx(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData A_1, Il2CppStructArray<bool> A_2, out bool A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_kJNGlsEDqDckESXjfROGpyQJlMx_Private_Boolean_CustomCalculationSourceData_Il2CppStructArray_1_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x00036548 File Offset: 0x00034748
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348318, RefRangeEnd = 348319, XrefRangeStart = 348315, XrefRangeEnd = 348318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ROElGxvxwjOsQqbtUxHVBlYTlwS(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData A_1, out float A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_ROElGxvxwjOsQqbtUxHVBlYTlwS_Private_Boolean_CustomCalculationSourceData_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x000365A4 File Offset: 0x000347A4
			[CallerCount(0)]
			public unsafe ControlDeviceType eJqOxNBuOQSNBgbLPUtHZbPgVfC(ywcXCwDHBvioOXoUMwhfqIIEDX.NjSaotJqTqBjFgJfQtXFAQMDfCL A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_eJqOxNBuOQSNBgbLPUtHZbPgVfC_Private_ControlDeviceType_NjSaotJqTqBjFgJfQtXFAQMDfCL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x000365F0 File Offset: 0x000347F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348319, XrefRangeEnd = 348327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CQTmbqHFWEknbPpZQtaQsFEAfWh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C70 RID: 3184 RVA: 0x00036624 File Offset: 0x00034824
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348378, RefRangeEnd = 348379, XrefRangeStart = 348327, XrefRangeEnd = 348378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string UvMBqJGTnIKBwBtTdbzqNPjaUYJe()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_UvMBqJGTnIKBwBtTdbzqNPjaUYJe_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000C71 RID: 3185 RVA: 0x0003665C File Offset: 0x0003485C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 348391, RefRangeEnd = 348395, XrefRangeStart = 348379, XrefRangeEnd = 348391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xjeVBysddNzJLefqSMyUGbIFKoA(BridgedControllerHWInfo A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x000366A0 File Offset: 0x000348A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348398, RefRangeEnd = 348399, XrefRangeStart = 348395, XrefRangeEnd = 348398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xjeVBysddNzJLefqSMyUGbIFKoA(BridgedController A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C73 RID: 3187 RVA: 0x000366E4 File Offset: 0x000348E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348415, RefRangeEnd = 348416, XrefRangeStart = 348399, XrefRangeEnd = 348415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<UnknownControllerHat> GSGWoDIqRLoSTVEGPZGnWuXPYcg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_GSGWoDIqRLoSTVEGPZGnWuXPYcg_Private_Il2CppReferenceArray_1_UnknownControllerHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnknownControllerHat>>(intPtr3) : null;
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x00036724 File Offset: 0x00034924
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 348420, RefRangeEnd = 348423, XrefRangeStart = 348416, XrefRangeEnd = 348420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QRqHkxHQdTOvmTIyHpJqpqzNcTZi()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C75 RID: 3189 RVA: 0x00036758 File Offset: 0x00034958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C76 RID: 3190 RVA: 0x00036794 File Offset: 0x00034994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348423, XrefRangeEnd = 348427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void QRqHkxHQdTOvmTIyHpJqpqzNcTZi(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x000367E0 File Offset: 0x000349E0
			[CallerCount(0)]
			public unsafe static int rLdrhGzCsEudhqVRALmAGTDyhaD(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_0, ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_rLdrhGzCsEudhqVRALmAGTDyhaD_Public_Static_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x00036834 File Offset: 0x00034A34
			[CallerCount(0)]
			public unsafe static int MdlbbWPBfliYJpFiRWMnbrISlOH(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_0, ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeMethodInfoPtr_MdlbbWPBfliYJpFiRWMnbrISlOH_Public_Static_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C79 RID: 3193 RVA: 0x0000734A File Offset: 0x0000554A
			public iHSGdmFZhWkJBBLEQPSmDckqrFUw(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00036888 File Offset: 0x00034A88
			// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00007353 File Offset: 0x00005553
			public unsafe int GNKcpIRbTxVSstxcCBqZKkcbietE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE)) = value;
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000368B0 File Offset: 0x00034AB0
			// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0000736E File Offset: 0x0000556E
			public unsafe int JFhGUotVGyvgqRcgpmFnXSQrssJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ)) = value;
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000368D8 File Offset: 0x00034AD8
			// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00007389 File Offset: 0x00005589
			public unsafe Guid WmRdwFvHdKGkxAZMIAvntNHLbaxg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg)) = value;
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00036900 File Offset: 0x00034B00
			// (set) Token: 0x06000C81 RID: 3201 RVA: 0x000073A4 File Offset: 0x000055A4
			public unsafe string WLPWeHrDCPCLfETsRQYzcumJyOe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00036928 File Offset: 0x00034B28
			// (set) Token: 0x06000C83 RID: 3203 RVA: 0x000073C3 File Offset: 0x000055C3
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB xAEQkKEmsgGlqDEpuAlHEcNWauNE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00036958 File Offset: 0x00034B58
			// (set) Token: 0x06000C85 RID: 3205 RVA: 0x000073E2 File Offset: 0x000055E2
			public unsafe aebqsBAEhVilJeqHZosRvGGRxlb lqBzATSuHgWwXfTJMPicOqKhLIc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<aebqsBAEhVilJeqHZosRvGGRxlb>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00036988 File Offset: 0x00034B88
			// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00007401 File Offset: 0x00005601
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.NjSaotJqTqBjFgJfQtXFAQMDfCL bArWKXqJfPoaoIGnCMdYqoSRdOw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_bArWKXqJfPoaoIGnCMdYqoSRdOw);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_bArWKXqJfPoaoIGnCMdYqoSRdOw)) = value;
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000369B0 File Offset: 0x00034BB0
			// (set) Token: 0x06000C89 RID: 3209 RVA: 0x0000741C File Offset: 0x0000561C
			public unsafe string xcraKzUBKKbqrrMoJhsaaxGOFXRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000369D8 File Offset: 0x00034BD8
			// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0000743B File Offset: 0x0000563B
			public unsafe string XweWIFEyvCMnXulreJEhSfAAWOo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00036A00 File Offset: 0x00034C00
			// (set) Token: 0x06000C8D RID: 3213 RVA: 0x0000745A File Offset: 0x0000565A
			public unsafe int ePNBvlGnonVgXbSNyjfUvrOPppq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq)) = value;
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00036A28 File Offset: 0x00034C28
			// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00007475 File Offset: 0x00005675
			public unsafe Guid pFkVRJEPoSBxlAjsHKMcxCzbNGQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ)) = value;
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00036A50 File Offset: 0x00034C50
			// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00007490 File Offset: 0x00005690
			public unsafe Guid lzufHdDGBKQEIiVjiKYtKEEDzaGM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM)) = value;
				}
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00036A78 File Offset: 0x00034C78
			// (set) Token: 0x06000C93 RID: 3219 RVA: 0x000074AB File Offset: 0x000056AB
			public unsafe Guid BLfxWbmyTsFYizOjLnroMuVRaUd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd)) = value;
				}
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00036AA0 File Offset: 0x00034CA0
			// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000074C6 File Offset: 0x000056C6
			public unsafe int zRSLRumgAHYvaVfMhktxhOcdJEz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz)) = value;
				}
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00036AC8 File Offset: 0x00034CC8
			// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000074E1 File Offset: 0x000056E1
			public unsafe bool AvCqApdLGDXHFPBkTTaAQSVHPfK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK)) = value;
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00036AF0 File Offset: 0x00034CF0
			// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000074FC File Offset: 0x000056FC
			public unsafe string UOiadLOPlNhsLbNzLGQXTPSGUrP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00036B18 File Offset: 0x00034D18
			// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0000751B File Offset: 0x0000571B
			public unsafe string xuEqFOsehiRavyALxlGGzCCzqoA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xuEqFOsehiRavyALxlGGzCCzqoA);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xuEqFOsehiRavyALxlGGzCCzqoA), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00036B40 File Offset: 0x00034D40
			// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0000753A File Offset: 0x0000573A
			public unsafe int xnwhPiSLJZAWeXtpbVDLHoIbBMl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl)) = value;
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00036B68 File Offset: 0x00034D68
			// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00007555 File Offset: 0x00005755
			public unsafe int ilvTWYfRywhZpsIyUtQNREFcjLsj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj)) = value;
				}
			}

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00036B90 File Offset: 0x00034D90
			// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00007570 File Offset: 0x00005770
			public unsafe int uJThHFvMnnGWlhGgONRMIioDKZOj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj)) = value;
				}
			}

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00036BB8 File Offset: 0x00034DB8
			// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x0000758B File Offset: 0x0000578B
			public unsafe int fMsDvvtAhFIJLgiqYmvGYlgVARM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM)) = value;
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00036BE0 File Offset: 0x00034DE0
			// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x000075A6 File Offset: 0x000057A6
			public unsafe int OZweyeiUbnDOuxpLuoupDMKOgVli
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli)) = value;
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00036C08 File Offset: 0x00034E08
			// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000075C1 File Offset: 0x000057C1
			public unsafe bool DvJhuGjaHKRdHunWyrEKRNDBrab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab)) = value;
				}
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00036C30 File Offset: 0x00034E30
			// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x000075DC File Offset: 0x000057DC
			public unsafe Il2CppStructArray<float> CwSFCVqDCbrQyrvPmmvtgaAynZj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00036C60 File Offset: 0x00034E60
			// (set) Token: 0x06000CAB RID: 3243 RVA: 0x000075FB File Offset: 0x000057FB
			public unsafe Il2CppStructArray<bool> sHeRoiRHkuXpbNwEMmzznSiAEVf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00036C90 File Offset: 0x00034E90
			// (set) Token: 0x06000CAD RID: 3245 RVA: 0x0000761A File Offset: 0x0000581A
			public unsafe HardwareJoystickMap_InputManager OHFiyNAurvAHndtKvlMxUsQwcRc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00036CC0 File Offset: 0x00034EC0
			// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00007639 File Offset: 0x00005839
			public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> swOzpxtgHdYlzNpDnxeXdFTTYrt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00036CF0 File Offset: 0x00034EF0
			// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00007658 File Offset: 0x00005858
			public unsafe bool lNjuiEzDctUBliWAKQtnwVRUssh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh)) = value;
				}
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00036D18 File Offset: 0x00034F18
			// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00007673 File Offset: 0x00005873
			public unsafe bool KmDzQOsJBlrBVPwQvpSIJVwVAej
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej)) = value;
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00036D40 File Offset: 0x00034F40
			// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x0000768E File Offset: 0x0000588E
			public unsafe bool qCyeROasFnJmaEJMACZydOijuQgZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ)) = value;
				}
			}

			// Token: 0x04000BA6 RID: 2982
			private static readonly IntPtr NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE;

			// Token: 0x04000BA7 RID: 2983
			private static readonly IntPtr NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ;

			// Token: 0x04000BA8 RID: 2984
			private static readonly IntPtr NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg;

			// Token: 0x04000BA9 RID: 2985
			private static readonly IntPtr NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe;

			// Token: 0x04000BAA RID: 2986
			private static readonly IntPtr NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE;

			// Token: 0x04000BAB RID: 2987
			private static readonly IntPtr NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc;

			// Token: 0x04000BAC RID: 2988
			private static readonly IntPtr NativeFieldInfoPtr_bArWKXqJfPoaoIGnCMdYqoSRdOw;

			// Token: 0x04000BAD RID: 2989
			private static readonly IntPtr NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT;

			// Token: 0x04000BAE RID: 2990
			private static readonly IntPtr NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo;

			// Token: 0x04000BAF RID: 2991
			private static readonly IntPtr NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq;

			// Token: 0x04000BB0 RID: 2992
			private static readonly IntPtr NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ;

			// Token: 0x04000BB1 RID: 2993
			private static readonly IntPtr NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM;

			// Token: 0x04000BB2 RID: 2994
			private static readonly IntPtr NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd;

			// Token: 0x04000BB3 RID: 2995
			private static readonly IntPtr NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz;

			// Token: 0x04000BB4 RID: 2996
			private static readonly IntPtr NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK;

			// Token: 0x04000BB5 RID: 2997
			private static readonly IntPtr NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP;

			// Token: 0x04000BB6 RID: 2998
			private static readonly IntPtr NativeFieldInfoPtr_xuEqFOsehiRavyALxlGGzCCzqoA;

			// Token: 0x04000BB7 RID: 2999
			private static readonly IntPtr NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl;

			// Token: 0x04000BB8 RID: 3000
			private static readonly IntPtr NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj;

			// Token: 0x04000BB9 RID: 3001
			private static readonly IntPtr NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj;

			// Token: 0x04000BBA RID: 3002
			private static readonly IntPtr NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM;

			// Token: 0x04000BBB RID: 3003
			private static readonly IntPtr NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli;

			// Token: 0x04000BBC RID: 3004
			private static readonly IntPtr NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab;

			// Token: 0x04000BBD RID: 3005
			private static readonly IntPtr NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj;

			// Token: 0x04000BBE RID: 3006
			private static readonly IntPtr NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf;

			// Token: 0x04000BBF RID: 3007
			private static readonly IntPtr NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc;

			// Token: 0x04000BC0 RID: 3008
			private static readonly IntPtr NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt;

			// Token: 0x04000BC1 RID: 3009
			private static readonly IntPtr NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh;

			// Token: 0x04000BC2 RID: 3010
			private static readonly IntPtr NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej;

			// Token: 0x04000BC3 RID: 3011
			private static readonly IntPtr NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ;

			// Token: 0x04000BC4 RID: 3012
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000BC5 RID: 3013
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0;

			// Token: 0x04000BC6 RID: 3014
			private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000BC7 RID: 3015
			private static readonly IntPtr NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0;

			// Token: 0x04000BC8 RID: 3016
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04000BC9 RID: 3017
			private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0;

			// Token: 0x04000BCA RID: 3018
			private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000BCB RID: 3019
			private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0;

			// Token: 0x04000BCC RID: 3020
			private static readonly IntPtr NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x04000BCD RID: 3021
			private static readonly IntPtr NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x04000BCE RID: 3022
			private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0;

			// Token: 0x04000BCF RID: 3023
			private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000BD0 RID: 3024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TttPXAkanrujAZxEVnuNwvIODaB_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0;

			// Token: 0x04000BD1 RID: 3025
			private static readonly IntPtr NativeMethodInfoPtr_jgeCBEMtzKMTxBWHKEzsNZSbcZA_Public_Void_0;

			// Token: 0x04000BD2 RID: 3026
			private static readonly IntPtr NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

			// Token: 0x04000BD3 RID: 3027
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000BD4 RID: 3028
			private static readonly IntPtr NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0;

			// Token: 0x04000BD5 RID: 3029
			private static readonly IntPtr NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

			// Token: 0x04000BD6 RID: 3030
			private static readonly IntPtr NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Private_BridgedControllerHWInfo_0;

			// Token: 0x04000BD7 RID: 3031
			private static readonly IntPtr NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0;

			// Token: 0x04000BD8 RID: 3032
			private static readonly IntPtr NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0;

			// Token: 0x04000BD9 RID: 3033
			private static readonly IntPtr NativeMethodInfoPtr_VmiVIlKWEBlLoMJdCnarRONAJqD_Public_Boolean_0;

			// Token: 0x04000BDA RID: 3034
			private static readonly IntPtr NativeMethodInfoPtr_WEOaJEBvHWsfDwuxnYgvTkTvLxZ_Public_Void_0;

			// Token: 0x04000BDB RID: 3035
			private static readonly IntPtr NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000BDC RID: 3036
			private static readonly IntPtr NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000BDD RID: 3037
			private static readonly IntPtr NativeMethodInfoPtr_MnKfNqjxLlxeBKgTKVckDkWYfiXR_Private_Void_Axis_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000BDE RID: 3038
			private static readonly IntPtr NativeMethodInfoPtr_MCTjNTarCEETqZZnpAEOspBfjIV_Private_Void_Button_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000BDF RID: 3039
			private static readonly IntPtr NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000BE0 RID: 3040
			private static readonly IntPtr NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_DirectInputAxis_0;

			// Token: 0x04000BE1 RID: 3041
			private static readonly IntPtr NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_Button_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000BE2 RID: 3042
			private static readonly IntPtr NativeMethodInfoPtr_vHPFVpeYMSXPpVGDKlRsxYWNAxN_Private_Boolean_Int32_Int32_HatType_0;

			// Token: 0x04000BE3 RID: 3043
			private static readonly IntPtr NativeMethodInfoPtr_mARCrvdmUYeEwAQXLmQRoaZYrBx_Private_Single_Int32_AxisDirection_0;

			// Token: 0x04000BE4 RID: 3044
			private static readonly IntPtr NativeMethodInfoPtr_kJNGlsEDqDckESXjfROGpyQJlMx_Private_Boolean_CustomCalculationSourceData_Il2CppStructArray_1_Boolean_byref_Boolean_0;

			// Token: 0x04000BE5 RID: 3045
			private static readonly IntPtr NativeMethodInfoPtr_ROElGxvxwjOsQqbtUxHVBlYTlwS_Private_Boolean_CustomCalculationSourceData_byref_Single_0;

			// Token: 0x04000BE6 RID: 3046
			private static readonly IntPtr NativeMethodInfoPtr_eJqOxNBuOQSNBgbLPUtHZbPgVfC_Private_ControlDeviceType_NjSaotJqTqBjFgJfQtXFAQMDfCL_0;

			// Token: 0x04000BE7 RID: 3047
			private static readonly IntPtr NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0;

			// Token: 0x04000BE8 RID: 3048
			private static readonly IntPtr NativeMethodInfoPtr_UvMBqJGTnIKBwBtTdbzqNPjaUYJe_Private_String_0;

			// Token: 0x04000BE9 RID: 3049
			private static readonly IntPtr NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0;

			// Token: 0x04000BEA RID: 3050
			private static readonly IntPtr NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0;

			// Token: 0x04000BEB RID: 3051
			private static readonly IntPtr NativeMethodInfoPtr_GSGWoDIqRLoSTVEGPZGnWuXPYcg_Private_Il2CppReferenceArray_1_UnknownControllerHat_0;

			// Token: 0x04000BEC RID: 3052
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Public_Void_0;

			// Token: 0x04000BED RID: 3053
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04000BEE RID: 3054
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0;

			// Token: 0x04000BEF RID: 3055
			private static readonly IntPtr NativeMethodInfoPtr_rLdrhGzCsEudhqVRALmAGTDyhaD_Public_Static_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

			// Token: 0x04000BF0 RID: 3056
			private static readonly IntPtr NativeMethodInfoPtr_MdlbbWPBfliYJpFiRWMnbrISlOH_Public_Static_Int32_iHSGdmFZhWkJBBLEQPSmDckqrFUw_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;
		}

		// Token: 0x020000B7 RID: 183
		public class TttPXAkanrujAZxEVnuNwvIODaB : Object
		{
			// Token: 0x06000CB6 RID: 3254 RVA: 0x00036D68 File Offset: 0x00034F68
			// Note: this type is marked as 'beforefieldinit'.
			static TttPXAkanrujAZxEVnuNwvIODaB()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "TttPXAkanrujAZxEVnuNwvIODaB");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_wNDDIbxDpcuwPNTmgWxRaRTaDha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "wNDDIbxDpcuwPNTmgWxRaRTaDha");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "aehIuCaBGkJGXMAlznFlFxMWCEsN");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "oOqTZKxPXasKRoAwrxIXSHgbeIEE");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_ozcgEQNEpOKxqUTQWCoNJaykmTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "ozcgEQNEpOKxqUTQWCoNJaykmTH");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_RKAIOAsUghmJrQzFLArhGtRdWrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "RKAIOAsUghmJrQzFLArhGtRdWrp");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_WBZfZrFWIqliBwnGqtiVvToDmaYs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "WBZfZrFWIqliBwnGqtiVvToDmaYs");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_ucUdoohgVbSvmVKzCRduefsHAWff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "ucUdoohgVbSvmVKzCRduefsHAWff");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "sECYhWcWoiAmTNERBzazANDrFEp");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_DekKaOvqdlGsLDOpkjOWeqsIYsCc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "DekKaOvqdlGsLDOpkjOWeqsIYsCc");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_OnbWtATylFaTqVyWghSObPQJWKt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "OnbWtATylFaTqVyWghSObPQJWKt");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "qCyeROasFnJmaEJMACZydOijuQgZ");
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_get_CurrentButtonValues_Public_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663451);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_get_joystickState_Public_get_wJJFycMsPqmiMTbmhiWciaFDsZa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663452);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr__ctor_Public_Void_kSxyOZmmwwWWvbNbQDBfHzTOMgP_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663453);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_TMKRneAcTZDgoTcAvbZAIQuPJOX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663454);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_tChsqfLBbuaRDkpHTYDeKpSkXYu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663455);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_HGoylHCPNNCdnbJqcVqEhcxOqeE_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663456);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_aCpqPWTyANbPQOqZthrdsbSMBCo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663457);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_TttPXAkanrujAZxEVnuNwvIODaB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663458);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_OnUVplxETGecUrcFPtJzfihJtpO_Public_Void_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663459);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_GILvonkmsLiGJsGoiMQhRHnVKJa_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663460);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_EsFXOyEUEgqDNUGHjTiNgfcmyfN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663461);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_NvDtjMUtkOKqLAEsUOgHsaWxBCYA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663462);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663463);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663464);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663465);
				ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, 100663466);
			}

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00036FB0 File Offset: 0x000351B0
			public unsafe Il2CppStructArray<bool> WPhAJNUnKYzKwbbJCDGaBlqMWxg
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348566, XrefRangeEnd = 348568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_get_CurrentButtonValues_Public_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00036FF0 File Offset: 0x000351F0
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa vXsAtHkVGmKaqWJkVyejEKlBLRHh
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_get_joystickState_Public_get_wJJFycMsPqmiMTbmhiWciaFDsZa_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>(intPtr3) : null;
				}
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x00037030 File Offset: 0x00035230
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348603, RefRangeEnd = 348604, XrefRangeStart = 348568, XrefRangeEnd = 348603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TttPXAkanrujAZxEVnuNwvIODaB(kSxyOZmmwwWWvbNbQDBfHzTOMgP source, UpdateLoopSetting updateLoops)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoops;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr__ctor_Public_Void_kSxyOZmmwwWWvbNbQDBfHzTOMgP_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x0003708C File Offset: 0x0003528C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348604, XrefRangeEnd = 348616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TMKRneAcTZDgoTcAvbZAIQuPJOX()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_TMKRneAcTZDgoTcAvbZAIQuPJOX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x000370C0 File Offset: 0x000352C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348616, XrefRangeEnd = 348619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void tChsqfLBbuaRDkpHTYDeKpSkXYu()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_tChsqfLBbuaRDkpHTYDeKpSkXYu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBC RID: 3260 RVA: 0x000370F4 File Offset: 0x000352F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348619, XrefRangeEnd = 348620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void HGoylHCPNNCdnbJqcVqEhcxOqeE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_HGoylHCPNNCdnbJqcVqEhcxOqeE_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x00037128 File Offset: 0x00035328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348620, XrefRangeEnd = 348621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void aCpqPWTyANbPQOqZthrdsbSMBCo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_aCpqPWTyANbPQOqZthrdsbSMBCo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x0003715C File Offset: 0x0003535C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348653, RefRangeEnd = 348654, XrefRangeStart = 348621, XrefRangeEnd = 348653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void nmYEDBcicBHXDwuAcMZQWyZRpHE(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_TttPXAkanrujAZxEVnuNwvIODaB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x000371A0 File Offset: 0x000353A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348662, RefRangeEnd = 348663, XrefRangeStart = 348654, XrefRangeEnd = 348662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnUVplxETGecUrcFPtJzfihJtpO(int A_1, int A_2, int A_3, float A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_OnUVplxETGecUrcFPtJzfihJtpO_Public_Void_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00037208 File Offset: 0x00035408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348663, XrefRangeEnd = 348684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GILvonkmsLiGJsGoiMQhRHnVKJa()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_GILvonkmsLiGJsGoiMQhRHnVKJa_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x0003723C File Offset: 0x0003543C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348684, XrefRangeEnd = 348689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EsFXOyEUEgqDNUGHjTiNgfcmyfN()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_EsFXOyEUEgqDNUGHjTiNgfcmyfN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x00037270 File Offset: 0x00035470
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 348705, RefRangeEnd = 348709, XrefRangeStart = 348689, XrefRangeEnd = 348705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void NvDtjMUtkOKqLAEsUOgHsaWxBCYA()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_NvDtjMUtkOKqLAEsUOgHsaWxBCYA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC3 RID: 3267 RVA: 0x000372A4 File Offset: 0x000354A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348709, XrefRangeEnd = 348713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC4 RID: 3268 RVA: 0x000372D8 File Offset: 0x000354D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC5 RID: 3269 RVA: 0x00037314 File Offset: 0x00035514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348713, XrefRangeEnd = 348725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void QRqHkxHQdTOvmTIyHpJqpqzNcTZi(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x00037360 File Offset: 0x00035560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348725, XrefRangeEnd = 348726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float giTkLqleHbFHnWmDqeZsZmbNCBJH(int A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CC7 RID: 3271 RVA: 0x000076A9 File Offset: 0x000058A9
			public TttPXAkanrujAZxEVnuNwvIODaB(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x000373A0 File Offset: 0x000355A0
			// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x000076B2 File Offset: 0x000058B2
			public unsafe int wNDDIbxDpcuwPNTmgWxRaRTaDha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_wNDDIbxDpcuwPNTmgWxRaRTaDha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_wNDDIbxDpcuwPNTmgWxRaRTaDha)) = value;
				}
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000373C8 File Offset: 0x000355C8
			// (set) Token: 0x06000CCB RID: 3275 RVA: 0x000076CD File Offset: 0x000058CD
			public unsafe ButtonLoopSet aehIuCaBGkJGXMAlznFlFxMWCEsN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonLoopSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000CCC RID: 3276 RVA: 0x000373F8 File Offset: 0x000355F8
			// (set) Token: 0x06000CCD RID: 3277 RVA: 0x000076EC File Offset: 0x000058EC
			public unsafe DualThreadLowLevelInputEventQueue oOqTZKxPXasKRoAwrxIXSHgbeIEE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DualThreadLowLevelInputEventQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00037428 File Offset: 0x00035628
			// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0000770B File Offset: 0x0000590B
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI ozcgEQNEpOKxqUTQWCoNJaykmTH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_ozcgEQNEpOKxqUTQWCoNJaykmTH);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_ozcgEQNEpOKxqUTQWCoNJaykmTH), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00037458 File Offset: 0x00035658
			// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x0000772A File Offset: 0x0000592A
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz RKAIOAsUghmJrQzFLArhGtRdWrp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_RKAIOAsUghmJrQzFLArhGtRdWrp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_RKAIOAsUghmJrQzFLArhGtRdWrp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00037488 File Offset: 0x00035688
			// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00007749 File Offset: 0x00005949
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz WBZfZrFWIqliBwnGqtiVvToDmaYs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_WBZfZrFWIqliBwnGqtiVvToDmaYs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_WBZfZrFWIqliBwnGqtiVvToDmaYs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x000374B8 File Offset: 0x000356B8
			// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00007768 File Offset: 0x00005968
			public unsafe Object ucUdoohgVbSvmVKzCRduefsHAWff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_ucUdoohgVbSvmVKzCRduefsHAWff);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_ucUdoohgVbSvmVKzCRduefsHAWff), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000374E8 File Offset: 0x000356E8
			// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00007787 File Offset: 0x00005987
			public unsafe bool sECYhWcWoiAmTNERBzazANDrFEp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp)) = value;
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00037510 File Offset: 0x00035710
			// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x000077A2 File Offset: 0x000059A2
			public unsafe kSxyOZmmwwWWvbNbQDBfHzTOMgP DekKaOvqdlGsLDOpkjOWeqsIYsCc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_DekKaOvqdlGsLDOpkjOWeqsIYsCc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<kSxyOZmmwwWWvbNbQDBfHzTOMgP>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_DekKaOvqdlGsLDOpkjOWeqsIYsCc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00037540 File Offset: 0x00035740
			// (set) Token: 0x06000CDB RID: 3291 RVA: 0x000077C1 File Offset: 0x000059C1
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa OnbWtATylFaTqVyWghSObPQJWKt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_OnbWtATylFaTqVyWghSObPQJWKt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_OnbWtATylFaTqVyWghSObPQJWKt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00037570 File Offset: 0x00035770
			// (set) Token: 0x06000CDD RID: 3293 RVA: 0x000077E0 File Offset: 0x000059E0
			public unsafe bool qCyeROasFnJmaEJMACZydOijuQgZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ)) = value;
				}
			}

			// Token: 0x04000BF1 RID: 3057
			private static readonly IntPtr NativeFieldInfoPtr_wNDDIbxDpcuwPNTmgWxRaRTaDha;

			// Token: 0x04000BF2 RID: 3058
			private static readonly IntPtr NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN;

			// Token: 0x04000BF3 RID: 3059
			private static readonly IntPtr NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE;

			// Token: 0x04000BF4 RID: 3060
			private static readonly IntPtr NativeFieldInfoPtr_ozcgEQNEpOKxqUTQWCoNJaykmTH;

			// Token: 0x04000BF5 RID: 3061
			private static readonly IntPtr NativeFieldInfoPtr_RKAIOAsUghmJrQzFLArhGtRdWrp;

			// Token: 0x04000BF6 RID: 3062
			private static readonly IntPtr NativeFieldInfoPtr_WBZfZrFWIqliBwnGqtiVvToDmaYs;

			// Token: 0x04000BF7 RID: 3063
			private static readonly IntPtr NativeFieldInfoPtr_ucUdoohgVbSvmVKzCRduefsHAWff;

			// Token: 0x04000BF8 RID: 3064
			private static readonly IntPtr NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp;

			// Token: 0x04000BF9 RID: 3065
			private static readonly IntPtr NativeFieldInfoPtr_DekKaOvqdlGsLDOpkjOWeqsIYsCc;

			// Token: 0x04000BFA RID: 3066
			private static readonly IntPtr NativeFieldInfoPtr_OnbWtATylFaTqVyWghSObPQJWKt;

			// Token: 0x04000BFB RID: 3067
			private static readonly IntPtr NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ;

			// Token: 0x04000BFC RID: 3068
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentButtonValues_Public_get_Il2CppStructArray_1_Boolean_0;

			// Token: 0x04000BFD RID: 3069
			private static readonly IntPtr NativeMethodInfoPtr_get_joystickState_Public_get_wJJFycMsPqmiMTbmhiWciaFDsZa_0;

			// Token: 0x04000BFE RID: 3070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_kSxyOZmmwwWWvbNbQDBfHzTOMgP_UpdateLoopSetting_0;

			// Token: 0x04000BFF RID: 3071
			private static readonly IntPtr NativeMethodInfoPtr_TMKRneAcTZDgoTcAvbZAIQuPJOX_Public_Void_0;

			// Token: 0x04000C00 RID: 3072
			private static readonly IntPtr NativeMethodInfoPtr_tChsqfLBbuaRDkpHTYDeKpSkXYu_Public_Void_0;

			// Token: 0x04000C01 RID: 3073
			private static readonly IntPtr NativeMethodInfoPtr_HGoylHCPNNCdnbJqcVqEhcxOqeE_Public_Void_0;

			// Token: 0x04000C02 RID: 3074
			private static readonly IntPtr NativeMethodInfoPtr_aCpqPWTyANbPQOqZthrdsbSMBCo_Public_Void_0;

			// Token: 0x04000C03 RID: 3075
			private static readonly IntPtr NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_TttPXAkanrujAZxEVnuNwvIODaB_0;

			// Token: 0x04000C04 RID: 3076
			private static readonly IntPtr NativeMethodInfoPtr_OnUVplxETGecUrcFPtJzfihJtpO_Public_Void_Int32_Int32_Int32_Single_0;

			// Token: 0x04000C05 RID: 3077
			private static readonly IntPtr NativeMethodInfoPtr_GILvonkmsLiGJsGoiMQhRHnVKJa_Private_Void_0;

			// Token: 0x04000C06 RID: 3078
			private static readonly IntPtr NativeMethodInfoPtr_EsFXOyEUEgqDNUGHjTiNgfcmyfN_Private_Void_0;

			// Token: 0x04000C07 RID: 3079
			private static readonly IntPtr NativeMethodInfoPtr_NvDtjMUtkOKqLAEsUOgHsaWxBCYA_Private_Void_0;

			// Token: 0x04000C08 RID: 3080
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000C09 RID: 3081
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04000C0A RID: 3082
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0;

			// Token: 0x04000C0B RID: 3083
			private static readonly IntPtr NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Private_Static_Single_Int32_0;

			// Token: 0x02000121 RID: 289
			public class wJJFycMsPqmiMTbmhiWciaFDsZa : Object
			{
				// Token: 0x06001171 RID: 4465 RVA: 0x0004C470 File Offset: 0x0004A670
				// Note: this type is marked as 'beforefieldinit'.
				static wJJFycMsPqmiMTbmhiWciaFDsZa()
				{
					Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB>.NativeClassPtr, "wJJFycMsPqmiMTbmhiWciaFDsZa");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr);
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_oJtyZAuQaQLbHdnsUndVuAbqsxU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "oJtyZAuQaQLbHdnsUndVuAbqsxU");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_IanUpZXQnssdekbKGTmMlayyiVr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "IanUpZXQnssdekbKGTmMlayyiVr");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_MVjeSNVhluYjAxLjnsZqTGJbxrD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "MVjeSNVhluYjAxLjnsZqTGJbxrD");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PqyvSTVIgYCIPsuKovsFAuEczsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "PqyvSTVIgYCIPsuKovsFAuEczsX");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_UBlaMQcFmXTkcfQApXFFpPPLQmq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "UBlaMQcFmXTkcfQApXFFpPPLQmq");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_ROmMSHreHYAuUCdhNmWiBxcgcVBf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "ROmMSHreHYAuUCdhNmWiBxcgcVBf");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_lIcdoHEnwRfEJtzhKqvJcTdyHQKe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "lIcdoHEnwRfEJtzhKqvJcTdyHQKe");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_pArpQbcuXfOVwupUzVvPFdHKeAik = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "pArpQbcuXfOVwupUzVvPFdHKeAik");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PtOCcYpoJBPCmLLnSFIKGvhdhNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "PtOCcYpoJBPCmLLnSFIKGvhdhNu");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_rBjeldZTZtaajFnkfiozXDUeNbQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "rBjeldZTZtaajFnkfiozXDUeNbQ");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_mdZZUzZcEyXpQCWSXowpAKtMLhk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "mdZZUzZcEyXpQCWSXowpAKtMLhk");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_JxYSMpQHZsJhMESxExjeuICpfAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "JxYSMpQHZsJhMESxExjeuICpfAT");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_tpOyCtsuOXSxQMYQxHVpQWULXmm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "tpOyCtsuOXSxQMYQxHVpQWULXmm");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_NecZVcIcCvwCwjwTVGbliBdKzpL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "NecZVcIcCvwCwjwTVGbliBdKzpL");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_yBOzSWhgfuTgsjmCvkKhlJyTTmA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "yBOzSWhgfuTgsjmCvkKhlJyTTmA");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_WQshYriYBuIJGYvmscWyXcfyAnk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "WQshYriYBuIJGYvmscWyXcfyAnk");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PlJMdxNuZbNJtWFBpQyOKagiAPR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "PlJMdxNuZbNJtWFBpQyOKagiAPR");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_rSInHORHRyhaqltBIxZviadZfcyd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "rSInHORHRyhaqltBIxZviadZfcyd");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_OmUGthcIprRglEbXHDYLflyhogTR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "OmUGthcIprRglEbXHDYLflyhogTR");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_JuIdDEhfGGszuSTGMpDPvDsJBzla = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "JuIdDEhfGGszuSTGMpDPvDsJBzla");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_pZzbVHUOqZFhttphbvjSDkDmEQI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "pZzbVHUOqZFhttphbvjSDkDmEQI");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KymmZmoAbPENEzhKmpbAfbwiTJd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "KymmZmoAbPENEzhKmpbAfbwiTJd");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_GjNjGXUMZLNJTdnpBcWajwyuHJb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "GjNjGXUMZLNJTdnpBcWajwyuHJb");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_EXDQtJbBqKctTcXTHFyqcYRakoa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "EXDQtJbBqKctTcXTHFyqcYRakoa");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_AUutUNwJRXFvMhvgPNlDzNfdzbhQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "AUutUNwJRXFvMhvgPNlDzNfdzbhQ");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_VoNKWBVhbOhrCTHynIYXQymnwCL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "VoNKWBVhbOhrCTHynIYXQymnwCL");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KbwwJhRUpueCGvxJAFdPeZaPyfX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "KbwwJhRUpueCGvxJAFdPeZaPyfX");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KfBPNutJahPKqydbZjSPbTTANFB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "KfBPNutJahPKqydbZjSPbTTANFB");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_hsZGwUXREdABRNrdBSVKdGHTLpG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "hsZGwUXREdABRNrdBSVKdGHTLpG");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_SKCbvnQmLTQYYpkcZJwutQNgdyT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, "SKCbvnQmLTQYYpkcZJwutQNgdyT");
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, 100663467);
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_aSqilFoiaIFLjKgxDjHFkORkBKXb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, 100663468);
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_wJJFycMsPqmiMTbmhiWciaFDsZa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, 100663469);
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_byref_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, 100663470);
					ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_jKvqKKszcLdeTQPRlBbiEPZRqKNv_Public_Static_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_Double_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr, 100663471);
				}

				// Token: 0x06001172 RID: 4466 RVA: 0x0004C758 File Offset: 0x0004A958
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 348442, RefRangeEnd = 348443, XrefRangeStart = 348427, XrefRangeEnd = 348442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe wJJFycMsPqmiMTbmhiWciaFDsZa()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001173 RID: 4467 RVA: 0x0004C794 File Offset: 0x0004A994
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 348449, RefRangeEnd = 348453, XrefRangeStart = 348443, XrefRangeEnd = 348449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void aSqilFoiaIFLjKgxDjHFkORkBKXb()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_aSqilFoiaIFLjKgxDjHFkORkBKXb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001174 RID: 4468 RVA: 0x0004C7C8 File Offset: 0x0004A9C8
				[CallerCount(19)]
				[CachedScanResults(RefRangeStart = 348459, RefRangeEnd = 348478, XrefRangeStart = 348453, XrefRangeEnd = 348459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void UjzsqHDScPlnWELAYrmDqTzdPIM(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_wJJFycMsPqmiMTbmhiWciaFDsZa_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001175 RID: 4469 RVA: 0x0004C80C File Offset: 0x0004AA0C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 348478, RefRangeEnd = 348481, XrefRangeStart = 348478, XrefRangeEnd = 348478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void UjzsqHDScPlnWELAYrmDqTzdPIM(ref LowLevelInputEvent A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &A_1;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_byref_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001176 RID: 4470 RVA: 0x0004C84C File Offset: 0x0004AA4C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 348565, RefRangeEnd = 348566, XrefRangeStart = 348481, XrefRangeEnd = 348565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void jKvqKKszcLdeTQPRlBbiEPZRqKNv(MaEgfvevdVIfQCtrIJMLQCQzDLz A_0, double A_1, LowLevelInputEvent A_2)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeMethodInfoPtr_jKvqKKszcLdeTQPRlBbiEPZRqKNv_Public_Static_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_Double_LowLevelInputEvent_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001177 RID: 4471 RVA: 0x00009E13 File Offset: 0x00008013
				public wJJFycMsPqmiMTbmhiWciaFDsZa(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170005D6 RID: 1494
				// (get) Token: 0x06001178 RID: 4472 RVA: 0x0004C8A0 File Offset: 0x0004AAA0
				// (set) Token: 0x06001179 RID: 4473 RVA: 0x00009E1C File Offset: 0x0000801C
				public unsafe float oJtyZAuQaQLbHdnsUndVuAbqsxU
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_oJtyZAuQaQLbHdnsUndVuAbqsxU);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_oJtyZAuQaQLbHdnsUndVuAbqsxU)) = value;
					}
				}

				// Token: 0x170005D7 RID: 1495
				// (get) Token: 0x0600117A RID: 4474 RVA: 0x0004C8C8 File Offset: 0x0004AAC8
				// (set) Token: 0x0600117B RID: 4475 RVA: 0x00009E37 File Offset: 0x00008037
				public unsafe float IanUpZXQnssdekbKGTmMlayyiVr
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_IanUpZXQnssdekbKGTmMlayyiVr);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_IanUpZXQnssdekbKGTmMlayyiVr)) = value;
					}
				}

				// Token: 0x170005D8 RID: 1496
				// (get) Token: 0x0600117C RID: 4476 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
				// (set) Token: 0x0600117D RID: 4477 RVA: 0x00009E52 File Offset: 0x00008052
				public unsafe float MVjeSNVhluYjAxLjnsZqTGJbxrD
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_MVjeSNVhluYjAxLjnsZqTGJbxrD);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_MVjeSNVhluYjAxLjnsZqTGJbxrD)) = value;
					}
				}

				// Token: 0x170005D9 RID: 1497
				// (get) Token: 0x0600117E RID: 4478 RVA: 0x0004C918 File Offset: 0x0004AB18
				// (set) Token: 0x0600117F RID: 4479 RVA: 0x00009E6D File Offset: 0x0000806D
				public unsafe float PqyvSTVIgYCIPsuKovsFAuEczsX
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PqyvSTVIgYCIPsuKovsFAuEczsX);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PqyvSTVIgYCIPsuKovsFAuEczsX)) = value;
					}
				}

				// Token: 0x170005DA RID: 1498
				// (get) Token: 0x06001180 RID: 4480 RVA: 0x0004C940 File Offset: 0x0004AB40
				// (set) Token: 0x06001181 RID: 4481 RVA: 0x00009E88 File Offset: 0x00008088
				public unsafe float UBlaMQcFmXTkcfQApXFFpPPLQmq
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_UBlaMQcFmXTkcfQApXFFpPPLQmq);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_UBlaMQcFmXTkcfQApXFFpPPLQmq)) = value;
					}
				}

				// Token: 0x170005DB RID: 1499
				// (get) Token: 0x06001182 RID: 4482 RVA: 0x0004C968 File Offset: 0x0004AB68
				// (set) Token: 0x06001183 RID: 4483 RVA: 0x00009EA3 File Offset: 0x000080A3
				public unsafe float ROmMSHreHYAuUCdhNmWiBxcgcVBf
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_ROmMSHreHYAuUCdhNmWiBxcgcVBf);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_ROmMSHreHYAuUCdhNmWiBxcgcVBf)) = value;
					}
				}

				// Token: 0x170005DC RID: 1500
				// (get) Token: 0x06001184 RID: 4484 RVA: 0x0004C990 File Offset: 0x0004AB90
				// (set) Token: 0x06001185 RID: 4485 RVA: 0x00009EBE File Offset: 0x000080BE
				public unsafe Il2CppStructArray<float> lIcdoHEnwRfEJtzhKqvJcTdyHQKe
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_lIcdoHEnwRfEJtzhKqvJcTdyHQKe);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_lIcdoHEnwRfEJtzhKqvJcTdyHQKe), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005DD RID: 1501
				// (get) Token: 0x06001186 RID: 4486 RVA: 0x0004C9C0 File Offset: 0x0004ABC0
				// (set) Token: 0x06001187 RID: 4487 RVA: 0x00009EDD File Offset: 0x000080DD
				public unsafe Il2CppStructArray<int> pArpQbcuXfOVwupUzVvPFdHKeAik
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_pArpQbcuXfOVwupUzVvPFdHKeAik);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_pArpQbcuXfOVwupUzVvPFdHKeAik), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005DE RID: 1502
				// (get) Token: 0x06001188 RID: 4488 RVA: 0x0004C9F0 File Offset: 0x0004ABF0
				// (set) Token: 0x06001189 RID: 4489 RVA: 0x00009EFC File Offset: 0x000080FC
				public unsafe Il2CppStructArray<bool> PtOCcYpoJBPCmLLnSFIKGvhdhNu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PtOCcYpoJBPCmLLnSFIKGvhdhNu);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PtOCcYpoJBPCmLLnSFIKGvhdhNu), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005DF RID: 1503
				// (get) Token: 0x0600118A RID: 4490 RVA: 0x0004CA20 File Offset: 0x0004AC20
				// (set) Token: 0x0600118B RID: 4491 RVA: 0x00009F1B File Offset: 0x0000811B
				public unsafe float rBjeldZTZtaajFnkfiozXDUeNbQ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_rBjeldZTZtaajFnkfiozXDUeNbQ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_rBjeldZTZtaajFnkfiozXDUeNbQ)) = value;
					}
				}

				// Token: 0x170005E0 RID: 1504
				// (get) Token: 0x0600118C RID: 4492 RVA: 0x0004CA48 File Offset: 0x0004AC48
				// (set) Token: 0x0600118D RID: 4493 RVA: 0x00009F36 File Offset: 0x00008136
				public unsafe float mdZZUzZcEyXpQCWSXowpAKtMLhk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_mdZZUzZcEyXpQCWSXowpAKtMLhk);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_mdZZUzZcEyXpQCWSXowpAKtMLhk)) = value;
					}
				}

				// Token: 0x170005E1 RID: 1505
				// (get) Token: 0x0600118E RID: 4494 RVA: 0x0004CA70 File Offset: 0x0004AC70
				// (set) Token: 0x0600118F RID: 4495 RVA: 0x00009F51 File Offset: 0x00008151
				public unsafe float JxYSMpQHZsJhMESxExjeuICpfAT
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_JxYSMpQHZsJhMESxExjeuICpfAT);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_JxYSMpQHZsJhMESxExjeuICpfAT)) = value;
					}
				}

				// Token: 0x170005E2 RID: 1506
				// (get) Token: 0x06001190 RID: 4496 RVA: 0x0004CA98 File Offset: 0x0004AC98
				// (set) Token: 0x06001191 RID: 4497 RVA: 0x00009F6C File Offset: 0x0000816C
				public unsafe float tpOyCtsuOXSxQMYQxHVpQWULXmm
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_tpOyCtsuOXSxQMYQxHVpQWULXmm);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_tpOyCtsuOXSxQMYQxHVpQWULXmm)) = value;
					}
				}

				// Token: 0x170005E3 RID: 1507
				// (get) Token: 0x06001192 RID: 4498 RVA: 0x0004CAC0 File Offset: 0x0004ACC0
				// (set) Token: 0x06001193 RID: 4499 RVA: 0x00009F87 File Offset: 0x00008187
				public unsafe float NecZVcIcCvwCwjwTVGbliBdKzpL
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_NecZVcIcCvwCwjwTVGbliBdKzpL);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_NecZVcIcCvwCwjwTVGbliBdKzpL)) = value;
					}
				}

				// Token: 0x170005E4 RID: 1508
				// (get) Token: 0x06001194 RID: 4500 RVA: 0x0004CAE8 File Offset: 0x0004ACE8
				// (set) Token: 0x06001195 RID: 4501 RVA: 0x00009FA2 File Offset: 0x000081A2
				public unsafe float yBOzSWhgfuTgsjmCvkKhlJyTTmA
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_yBOzSWhgfuTgsjmCvkKhlJyTTmA);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_yBOzSWhgfuTgsjmCvkKhlJyTTmA)) = value;
					}
				}

				// Token: 0x170005E5 RID: 1509
				// (get) Token: 0x06001196 RID: 4502 RVA: 0x0004CB10 File Offset: 0x0004AD10
				// (set) Token: 0x06001197 RID: 4503 RVA: 0x00009FBD File Offset: 0x000081BD
				public unsafe Il2CppStructArray<float> WQshYriYBuIJGYvmscWyXcfyAnk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_WQshYriYBuIJGYvmscWyXcfyAnk);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_WQshYriYBuIJGYvmscWyXcfyAnk), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005E6 RID: 1510
				// (get) Token: 0x06001198 RID: 4504 RVA: 0x0004CB40 File Offset: 0x0004AD40
				// (set) Token: 0x06001199 RID: 4505 RVA: 0x00009FDC File Offset: 0x000081DC
				public unsafe float PlJMdxNuZbNJtWFBpQyOKagiAPR
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PlJMdxNuZbNJtWFBpQyOKagiAPR);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_PlJMdxNuZbNJtWFBpQyOKagiAPR)) = value;
					}
				}

				// Token: 0x170005E7 RID: 1511
				// (get) Token: 0x0600119A RID: 4506 RVA: 0x0004CB68 File Offset: 0x0004AD68
				// (set) Token: 0x0600119B RID: 4507 RVA: 0x00009FF7 File Offset: 0x000081F7
				public unsafe float rSInHORHRyhaqltBIxZviadZfcyd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_rSInHORHRyhaqltBIxZviadZfcyd);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_rSInHORHRyhaqltBIxZviadZfcyd)) = value;
					}
				}

				// Token: 0x170005E8 RID: 1512
				// (get) Token: 0x0600119C RID: 4508 RVA: 0x0004CB90 File Offset: 0x0004AD90
				// (set) Token: 0x0600119D RID: 4509 RVA: 0x0000A012 File Offset: 0x00008212
				public unsafe float OmUGthcIprRglEbXHDYLflyhogTR
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_OmUGthcIprRglEbXHDYLflyhogTR);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_OmUGthcIprRglEbXHDYLflyhogTR)) = value;
					}
				}

				// Token: 0x170005E9 RID: 1513
				// (get) Token: 0x0600119E RID: 4510 RVA: 0x0004CBB8 File Offset: 0x0004ADB8
				// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000A02D File Offset: 0x0000822D
				public unsafe float JuIdDEhfGGszuSTGMpDPvDsJBzla
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_JuIdDEhfGGszuSTGMpDPvDsJBzla);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_JuIdDEhfGGszuSTGMpDPvDsJBzla)) = value;
					}
				}

				// Token: 0x170005EA RID: 1514
				// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
				// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0000A048 File Offset: 0x00008248
				public unsafe float pZzbVHUOqZFhttphbvjSDkDmEQI
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_pZzbVHUOqZFhttphbvjSDkDmEQI);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_pZzbVHUOqZFhttphbvjSDkDmEQI)) = value;
					}
				}

				// Token: 0x170005EB RID: 1515
				// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0004CC08 File Offset: 0x0004AE08
				// (set) Token: 0x060011A3 RID: 4515 RVA: 0x0000A063 File Offset: 0x00008263
				public unsafe float KymmZmoAbPENEzhKmpbAfbwiTJd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KymmZmoAbPENEzhKmpbAfbwiTJd);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KymmZmoAbPENEzhKmpbAfbwiTJd)) = value;
					}
				}

				// Token: 0x170005EC RID: 1516
				// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0004CC30 File Offset: 0x0004AE30
				// (set) Token: 0x060011A5 RID: 4517 RVA: 0x0000A07E File Offset: 0x0000827E
				public unsafe Il2CppStructArray<float> GjNjGXUMZLNJTdnpBcWajwyuHJb
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_GjNjGXUMZLNJTdnpBcWajwyuHJb);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_GjNjGXUMZLNJTdnpBcWajwyuHJb), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005ED RID: 1517
				// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0004CC60 File Offset: 0x0004AE60
				// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0000A09D File Offset: 0x0000829D
				public unsafe float EXDQtJbBqKctTcXTHFyqcYRakoa
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_EXDQtJbBqKctTcXTHFyqcYRakoa);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_EXDQtJbBqKctTcXTHFyqcYRakoa)) = value;
					}
				}

				// Token: 0x170005EE RID: 1518
				// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0004CC88 File Offset: 0x0004AE88
				// (set) Token: 0x060011A9 RID: 4521 RVA: 0x0000A0B8 File Offset: 0x000082B8
				public unsafe float AUutUNwJRXFvMhvgPNlDzNfdzbhQ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_AUutUNwJRXFvMhvgPNlDzNfdzbhQ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_AUutUNwJRXFvMhvgPNlDzNfdzbhQ)) = value;
					}
				}

				// Token: 0x170005EF RID: 1519
				// (get) Token: 0x060011AA RID: 4522 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
				// (set) Token: 0x060011AB RID: 4523 RVA: 0x0000A0D3 File Offset: 0x000082D3
				public unsafe float VoNKWBVhbOhrCTHynIYXQymnwCL
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_VoNKWBVhbOhrCTHynIYXQymnwCL);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_VoNKWBVhbOhrCTHynIYXQymnwCL)) = value;
					}
				}

				// Token: 0x170005F0 RID: 1520
				// (get) Token: 0x060011AC RID: 4524 RVA: 0x0004CCD8 File Offset: 0x0004AED8
				// (set) Token: 0x060011AD RID: 4525 RVA: 0x0000A0EE File Offset: 0x000082EE
				public unsafe float KbwwJhRUpueCGvxJAFdPeZaPyfX
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KbwwJhRUpueCGvxJAFdPeZaPyfX);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KbwwJhRUpueCGvxJAFdPeZaPyfX)) = value;
					}
				}

				// Token: 0x170005F1 RID: 1521
				// (get) Token: 0x060011AE RID: 4526 RVA: 0x0004CD00 File Offset: 0x0004AF00
				// (set) Token: 0x060011AF RID: 4527 RVA: 0x0000A109 File Offset: 0x00008309
				public unsafe float KfBPNutJahPKqydbZjSPbTTANFB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KfBPNutJahPKqydbZjSPbTTANFB);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_KfBPNutJahPKqydbZjSPbTTANFB)) = value;
					}
				}

				// Token: 0x170005F2 RID: 1522
				// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0004CD28 File Offset: 0x0004AF28
				// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0000A124 File Offset: 0x00008324
				public unsafe float hsZGwUXREdABRNrdBSVKdGHTLpG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_hsZGwUXREdABRNrdBSVKdGHTLpG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_hsZGwUXREdABRNrdBSVKdGHTLpG)) = value;
					}
				}

				// Token: 0x170005F3 RID: 1523
				// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0004CD50 File Offset: 0x0004AF50
				// (set) Token: 0x060011B3 RID: 4531 RVA: 0x0000A13F File Offset: 0x0000833F
				public unsafe Il2CppStructArray<float> SKCbvnQmLTQYYpkcZJwutQNgdyT
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_SKCbvnQmLTQYYpkcZJwutQNgdyT);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.TttPXAkanrujAZxEVnuNwvIODaB.wJJFycMsPqmiMTbmhiWciaFDsZa.NativeFieldInfoPtr_SKCbvnQmLTQYYpkcZJwutQNgdyT), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001B03 RID: 6915
				private static readonly IntPtr NativeFieldInfoPtr_oJtyZAuQaQLbHdnsUndVuAbqsxU;

				// Token: 0x04001B04 RID: 6916
				private static readonly IntPtr NativeFieldInfoPtr_IanUpZXQnssdekbKGTmMlayyiVr;

				// Token: 0x04001B05 RID: 6917
				private static readonly IntPtr NativeFieldInfoPtr_MVjeSNVhluYjAxLjnsZqTGJbxrD;

				// Token: 0x04001B06 RID: 6918
				private static readonly IntPtr NativeFieldInfoPtr_PqyvSTVIgYCIPsuKovsFAuEczsX;

				// Token: 0x04001B07 RID: 6919
				private static readonly IntPtr NativeFieldInfoPtr_UBlaMQcFmXTkcfQApXFFpPPLQmq;

				// Token: 0x04001B08 RID: 6920
				private static readonly IntPtr NativeFieldInfoPtr_ROmMSHreHYAuUCdhNmWiBxcgcVBf;

				// Token: 0x04001B09 RID: 6921
				private static readonly IntPtr NativeFieldInfoPtr_lIcdoHEnwRfEJtzhKqvJcTdyHQKe;

				// Token: 0x04001B0A RID: 6922
				private static readonly IntPtr NativeFieldInfoPtr_pArpQbcuXfOVwupUzVvPFdHKeAik;

				// Token: 0x04001B0B RID: 6923
				private static readonly IntPtr NativeFieldInfoPtr_PtOCcYpoJBPCmLLnSFIKGvhdhNu;

				// Token: 0x04001B0C RID: 6924
				private static readonly IntPtr NativeFieldInfoPtr_rBjeldZTZtaajFnkfiozXDUeNbQ;

				// Token: 0x04001B0D RID: 6925
				private static readonly IntPtr NativeFieldInfoPtr_mdZZUzZcEyXpQCWSXowpAKtMLhk;

				// Token: 0x04001B0E RID: 6926
				private static readonly IntPtr NativeFieldInfoPtr_JxYSMpQHZsJhMESxExjeuICpfAT;

				// Token: 0x04001B0F RID: 6927
				private static readonly IntPtr NativeFieldInfoPtr_tpOyCtsuOXSxQMYQxHVpQWULXmm;

				// Token: 0x04001B10 RID: 6928
				private static readonly IntPtr NativeFieldInfoPtr_NecZVcIcCvwCwjwTVGbliBdKzpL;

				// Token: 0x04001B11 RID: 6929
				private static readonly IntPtr NativeFieldInfoPtr_yBOzSWhgfuTgsjmCvkKhlJyTTmA;

				// Token: 0x04001B12 RID: 6930
				private static readonly IntPtr NativeFieldInfoPtr_WQshYriYBuIJGYvmscWyXcfyAnk;

				// Token: 0x04001B13 RID: 6931
				private static readonly IntPtr NativeFieldInfoPtr_PlJMdxNuZbNJtWFBpQyOKagiAPR;

				// Token: 0x04001B14 RID: 6932
				private static readonly IntPtr NativeFieldInfoPtr_rSInHORHRyhaqltBIxZviadZfcyd;

				// Token: 0x04001B15 RID: 6933
				private static readonly IntPtr NativeFieldInfoPtr_OmUGthcIprRglEbXHDYLflyhogTR;

				// Token: 0x04001B16 RID: 6934
				private static readonly IntPtr NativeFieldInfoPtr_JuIdDEhfGGszuSTGMpDPvDsJBzla;

				// Token: 0x04001B17 RID: 6935
				private static readonly IntPtr NativeFieldInfoPtr_pZzbVHUOqZFhttphbvjSDkDmEQI;

				// Token: 0x04001B18 RID: 6936
				private static readonly IntPtr NativeFieldInfoPtr_KymmZmoAbPENEzhKmpbAfbwiTJd;

				// Token: 0x04001B19 RID: 6937
				private static readonly IntPtr NativeFieldInfoPtr_GjNjGXUMZLNJTdnpBcWajwyuHJb;

				// Token: 0x04001B1A RID: 6938
				private static readonly IntPtr NativeFieldInfoPtr_EXDQtJbBqKctTcXTHFyqcYRakoa;

				// Token: 0x04001B1B RID: 6939
				private static readonly IntPtr NativeFieldInfoPtr_AUutUNwJRXFvMhvgPNlDzNfdzbhQ;

				// Token: 0x04001B1C RID: 6940
				private static readonly IntPtr NativeFieldInfoPtr_VoNKWBVhbOhrCTHynIYXQymnwCL;

				// Token: 0x04001B1D RID: 6941
				private static readonly IntPtr NativeFieldInfoPtr_KbwwJhRUpueCGvxJAFdPeZaPyfX;

				// Token: 0x04001B1E RID: 6942
				private static readonly IntPtr NativeFieldInfoPtr_KfBPNutJahPKqydbZjSPbTTANFB;

				// Token: 0x04001B1F RID: 6943
				private static readonly IntPtr NativeFieldInfoPtr_hsZGwUXREdABRNrdBSVKdGHTLpG;

				// Token: 0x04001B20 RID: 6944
				private static readonly IntPtr NativeFieldInfoPtr_SKCbvnQmLTQYYpkcZJwutQNgdyT;

				// Token: 0x04001B21 RID: 6945
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001B22 RID: 6946
				private static readonly IntPtr NativeMethodInfoPtr_aSqilFoiaIFLjKgxDjHFkORkBKXb_Public_Void_0;

				// Token: 0x04001B23 RID: 6947
				private static readonly IntPtr NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_wJJFycMsPqmiMTbmhiWciaFDsZa_0;

				// Token: 0x04001B24 RID: 6948
				private static readonly IntPtr NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_byref_LowLevelInputEvent_0;

				// Token: 0x04001B25 RID: 6949
				private static readonly IntPtr NativeMethodInfoPtr_jKvqKKszcLdeTQPRlBbiEPZRqKNv_Public_Static_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_Double_LowLevelInputEvent_0;
			}
		}

		// Token: 0x020000B8 RID: 184
		public class oVxWVrUKPtXGlAJTYjKtkWEIdAI : Object
		{
			// Token: 0x06000CDE RID: 3294 RVA: 0x00037598 File Offset: 0x00035798
			// Note: this type is marked as 'beforefieldinit'.
			static oVxWVrUKPtXGlAJTYjKtkWEIdAI()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "oVxWVrUKPtXGlAJTYjKtkWEIdAI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_JDDFNbSMZQnpexMrgzuXTSqSDSt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, "JDDFNbSMZQnpexMrgzuXTSqSDSt");
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_taickaSKvWWGbFxQFnizFvtfBnR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, "taickaSKvWWGbFxQFnizFvtfBnR");
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_TpPDpNihYryNwtRAXctNEhdafXIH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, "TpPDpNihYryNwtRAXctNEhdafXIH");
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_QcEdRPBnTmjnQQKQYdIxsdCDpikm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, "QcEdRPBnTmjnQQKQYdIxsdCDpikm");
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_KvXeaAiYbstxfiWfbcqIjAthfMDe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, "KvXeaAiYbstxfiWfbcqIjAthfMDe");
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_MWuHxGhzKsdFnHSzKhqXFAUbHDY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, "MWuHxGhzKsdFnHSzKhqXFAUbHDY");
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_SGdMceYpHvabtEiuOdDtAuVSHLZj_Public_Static_oVxWVrUKPtXGlAJTYjKtkWEIdAI_oVxWVrUKPtXGlAJTYjKtkWEIdAI_MaEgfvevdVIfQCtrIJMLQCQzDLz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663472);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr__ctor_Public_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663473);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr__ctor_Private_Void_oVxWVrUKPtXGlAJTYjKtkWEIdAI_MaEgfvevdVIfQCtrIJMLQCQzDLz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663474);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663475);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663476);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_oVxWVrUKPtXGlAJTYjKtkWEIdAI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663477);
				ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_SHBxIShQkJlKQizqikfVGnwlYdh_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr, 100663478);
			}

			// Token: 0x06000CDF RID: 3295 RVA: 0x000376C8 File Offset: 0x000358C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348726, XrefRangeEnd = 348733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI SGdMceYpHvabtEiuOdDtAuVSHLZj(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI A_0, MaEgfvevdVIfQCtrIJMLQCQzDLz A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_SGdMceYpHvabtEiuOdDtAuVSHLZj_Public_Static_oVxWVrUKPtXGlAJTYjKtkWEIdAI_oVxWVrUKPtXGlAJTYjKtkWEIdAI_MaEgfvevdVIfQCtrIJMLQCQzDLz_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>(intPtr3) : null;
			}

			// Token: 0x06000CE0 RID: 3296 RVA: 0x00037720 File Offset: 0x00035920
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 348747, RefRangeEnd = 348751, XrefRangeStart = 348733, XrefRangeEnd = 348747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe oVxWVrUKPtXGlAJTYjKtkWEIdAI(MaEgfvevdVIfQCtrIJMLQCQzDLz state, int axisMin, int axisMax, int axisZero, float eventTimeout)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisMin;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisMax;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisZero;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr__ctor_Public_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CE1 RID: 3297 RVA: 0x000377A4 File Offset: 0x000359A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348751, XrefRangeEnd = 348755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe oVxWVrUKPtXGlAJTYjKtkWEIdAI(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI source, MaEgfvevdVIfQCtrIJMLQCQzDLz state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr__ctor_Private_Void_oVxWVrUKPtXGlAJTYjKtkWEIdAI_MaEgfvevdVIfQCtrIJMLQCQzDLz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CE2 RID: 3298 RVA: 0x00037804 File Offset: 0x00035A04
			[CallerCount(0)]
			public unsafe oVxWVrUKPtXGlAJTYjKtkWEIdAI(int axisMin, int axisMax, int axisZero, float axisTimeout)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axisMin;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisMax;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisZero;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x00037878 File Offset: 0x00035A78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348821, RefRangeEnd = 348822, XrefRangeStart = 348755, XrefRangeEnd = 348821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VkKCEPARYOuxbLbQAeytGgNzULkC(double A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CE4 RID: 3300 RVA: 0x000378B8 File Offset: 0x00035AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348822, XrefRangeEnd = 348825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UjzsqHDScPlnWELAYrmDqTzdPIM(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_oVxWVrUKPtXGlAJTYjKtkWEIdAI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x000378FC File Offset: 0x00035AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348825, XrefRangeEnd = 348826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int SHBxIShQkJlKQizqikfVGnwlYdh(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeMethodInfoPtr_SHBxIShQkJlKQizqikfVGnwlYdh_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CE6 RID: 3302 RVA: 0x000077FB File Offset: 0x000059FB
			public oVxWVrUKPtXGlAJTYjKtkWEIdAI(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00037948 File Offset: 0x00035B48
			// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00007804 File Offset: 0x00005A04
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz JDDFNbSMZQnpexMrgzuXTSqSDSt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_JDDFNbSMZQnpexMrgzuXTSqSDSt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_JDDFNbSMZQnpexMrgzuXTSqSDSt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00037978 File Offset: 0x00035B78
			// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00007823 File Offset: 0x00005A23
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe taickaSKvWWGbFxQFnizFvtfBnR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_taickaSKvWWGbFxQFnizFvtfBnR);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_taickaSKvWWGbFxQFnizFvtfBnR), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000379A8 File Offset: 0x00035BA8
			// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00007842 File Offset: 0x00005A42
			public unsafe int TpPDpNihYryNwtRAXctNEhdafXIH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_TpPDpNihYryNwtRAXctNEhdafXIH);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_TpPDpNihYryNwtRAXctNEhdafXIH)) = value;
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06000CED RID: 3309 RVA: 0x000379D0 File Offset: 0x00035BD0
			// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0000785D File Offset: 0x00005A5D
			public unsafe int QcEdRPBnTmjnQQKQYdIxsdCDpikm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_QcEdRPBnTmjnQQKQYdIxsdCDpikm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_QcEdRPBnTmjnQQKQYdIxsdCDpikm)) = value;
				}
			}

			// Token: 0x1700046A RID: 1130
			// (get) Token: 0x06000CEF RID: 3311 RVA: 0x000379F8 File Offset: 0x00035BF8
			// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00007878 File Offset: 0x00005A78
			public unsafe int KvXeaAiYbstxfiWfbcqIjAthfMDe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_KvXeaAiYbstxfiWfbcqIjAthfMDe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_KvXeaAiYbstxfiWfbcqIjAthfMDe)) = value;
				}
			}

			// Token: 0x1700046B RID: 1131
			// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00037A20 File Offset: 0x00035C20
			// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00007893 File Offset: 0x00005A93
			public unsafe float MWuHxGhzKsdFnHSzKhqXFAUbHDY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_MWuHxGhzKsdFnHSzKhqXFAUbHDY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.oVxWVrUKPtXGlAJTYjKtkWEIdAI.NativeFieldInfoPtr_MWuHxGhzKsdFnHSzKhqXFAUbHDY)) = value;
				}
			}

			// Token: 0x04000C0C RID: 3084
			private static readonly IntPtr NativeFieldInfoPtr_JDDFNbSMZQnpexMrgzuXTSqSDSt;

			// Token: 0x04000C0D RID: 3085
			private static readonly IntPtr NativeFieldInfoPtr_taickaSKvWWGbFxQFnizFvtfBnR;

			// Token: 0x04000C0E RID: 3086
			private static readonly IntPtr NativeFieldInfoPtr_TpPDpNihYryNwtRAXctNEhdafXIH;

			// Token: 0x04000C0F RID: 3087
			private static readonly IntPtr NativeFieldInfoPtr_QcEdRPBnTmjnQQKQYdIxsdCDpikm;

			// Token: 0x04000C10 RID: 3088
			private static readonly IntPtr NativeFieldInfoPtr_KvXeaAiYbstxfiWfbcqIjAthfMDe;

			// Token: 0x04000C11 RID: 3089
			private static readonly IntPtr NativeFieldInfoPtr_MWuHxGhzKsdFnHSzKhqXFAUbHDY;

			// Token: 0x04000C12 RID: 3090
			private static readonly IntPtr NativeMethodInfoPtr_SGdMceYpHvabtEiuOdDtAuVSHLZj_Public_Static_oVxWVrUKPtXGlAJTYjKtkWEIdAI_oVxWVrUKPtXGlAJTYjKtkWEIdAI_MaEgfvevdVIfQCtrIJMLQCQzDLz_0;

			// Token: 0x04000C13 RID: 3091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_Int32_Int32_Int32_Single_0;

			// Token: 0x04000C14 RID: 3092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_oVxWVrUKPtXGlAJTYjKtkWEIdAI_MaEgfvevdVIfQCtrIJMLQCQzDLz_0;

			// Token: 0x04000C15 RID: 3093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Single_0;

			// Token: 0x04000C16 RID: 3094
			private static readonly IntPtr NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Double_0;

			// Token: 0x04000C17 RID: 3095
			private static readonly IntPtr NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_oVxWVrUKPtXGlAJTYjKtkWEIdAI_0;

			// Token: 0x04000C18 RID: 3096
			private static readonly IntPtr NativeMethodInfoPtr_SHBxIShQkJlKQizqikfVGnwlYdh_Private_Int32_Int32_0;
		}

		// Token: 0x020000B9 RID: 185
		public class NCUlcWyyhCTkXCxgwVqNMEUjCTe : Object
		{
			// Token: 0x06000CF3 RID: 3315 RVA: 0x00037A48 File Offset: 0x00035C48
			// Note: this type is marked as 'beforefieldinit'.
			static NCUlcWyyhCTkXCxgwVqNMEUjCTe()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "NCUlcWyyhCTkXCxgwVqNMEUjCTe");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_lCizAKDReHYAWMadabZzWnTynsN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, "lCizAKDReHYAWMadabZzWnTynsN");
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_CSqArHMweKzDlupjVxOzYPqjaSJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, "CSqArHMweKzDlupjVxOzYPqjaSJ");
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_ThqjaaYYFxrNYAplSZGbAYMqrDj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, "ThqjaaYYFxrNYAplSZGbAYMqrDj");
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_DzEEEpaKJEVRMkZxvVJTGwYxVrH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, "DzEEEpaKJEVRMkZxvVJTGwYxVrH");
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_axXisVnNpjuUWWBaoouSeLwEixn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, "axXisVnNpjuUWWBaoouSeLwEixn");
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_goQFTHRYrUNsxKTEVRGFGXgYrbT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, "goQFTHRYrUNsxKTEVRGFGXgYrbT");
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_sourceState_Public_get_MaEgfvevdVIfQCtrIJMLQCQzDLz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663479);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_changedState_Public_get_MaEgfvevdVIfQCtrIJMLQCQzDLz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663480);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_valueChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663481);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_lastChangedTimestamp_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663482);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr__ctor_Public_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663483);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663484);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_NCUlcWyyhCTkXCxgwVqNMEUjCTe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663485);
				ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_QmxTIMaEMBeQiGjfpFYPTFpIJdzb_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr, 100663486);
			}

			// Token: 0x17000472 RID: 1138
			// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00037B8C File Offset: 0x00035D8C
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz eiTxVYEeFSIjKclTphuIUrLEmPsB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_sourceState_Public_get_MaEgfvevdVIfQCtrIJMLQCQzDLz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr3) : null;
				}
			}

			// Token: 0x17000473 RID: 1139
			// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00037BCC File Offset: 0x00035DCC
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz QVVDcRHSIEMkkzUKOcDQIXByVPKc
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_changedState_Public_get_MaEgfvevdVIfQCtrIJMLQCQzDLz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr3) : null;
				}
			}

			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00037C0C File Offset: 0x00035E0C
			public unsafe bool vwybeekcbJUYHehtJGhTAzjfGEY
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_valueChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00037C48 File Offset: 0x00035E48
			public unsafe double ZcAtKkELHFtpyeTuglVBEPULZJM
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_get_lastChangedTimestamp_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CF8 RID: 3320 RVA: 0x00037C84 File Offset: 0x00035E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348826, XrefRangeEnd = 348833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NCUlcWyyhCTkXCxgwVqNMEUjCTe(MaEgfvevdVIfQCtrIJMLQCQzDLz sourceState)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceState);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr__ctor_Public_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CF9 RID: 3321 RVA: 0x00037CD0 File Offset: 0x00035ED0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348841, RefRangeEnd = 348842, XrefRangeStart = 348833, XrefRangeEnd = 348841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VkKCEPARYOuxbLbQAeytGgNzULkC(double A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CFA RID: 3322 RVA: 0x00037D10 File Offset: 0x00035F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348842, XrefRangeEnd = 348845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UjzsqHDScPlnWELAYrmDqTzdPIM(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_NCUlcWyyhCTkXCxgwVqNMEUjCTe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CFB RID: 3323 RVA: 0x00037D54 File Offset: 0x00035F54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348851, RefRangeEnd = 348852, XrefRangeStart = 348845, XrefRangeEnd = 348851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool QmxTIMaEMBeQiGjfpFYPTFpIJdzb()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeMethodInfoPtr_QmxTIMaEMBeQiGjfpFYPTFpIJdzb_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CFC RID: 3324 RVA: 0x000078AE File Offset: 0x00005AAE
			public NCUlcWyyhCTkXCxgwVqNMEUjCTe(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00037D90 File Offset: 0x00035F90
			// (set) Token: 0x06000CFE RID: 3326 RVA: 0x000078B7 File Offset: 0x00005AB7
			public unsafe double lCizAKDReHYAWMadabZzWnTynsN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_lCizAKDReHYAWMadabZzWnTynsN);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_lCizAKDReHYAWMadabZzWnTynsN)) = value;
				}
			}

			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00037DB8 File Offset: 0x00035FB8
			// (set) Token: 0x06000D00 RID: 3328 RVA: 0x000078D2 File Offset: 0x00005AD2
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz CSqArHMweKzDlupjVxOzYPqjaSJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_CSqArHMweKzDlupjVxOzYPqjaSJ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_CSqArHMweKzDlupjVxOzYPqjaSJ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700046E RID: 1134
			// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00037DE8 File Offset: 0x00035FE8
			// (set) Token: 0x06000D02 RID: 3330 RVA: 0x000078F1 File Offset: 0x00005AF1
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz ThqjaaYYFxrNYAplSZGbAYMqrDj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_ThqjaaYYFxrNYAplSZGbAYMqrDj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_ThqjaaYYFxrNYAplSZGbAYMqrDj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700046F RID: 1135
			// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00037E18 File Offset: 0x00036018
			// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00007910 File Offset: 0x00005B10
			public unsafe MaEgfvevdVIfQCtrIJMLQCQzDLz DzEEEpaKJEVRMkZxvVJTGwYxVrH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_DzEEEpaKJEVRMkZxvVJTGwYxVrH);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaEgfvevdVIfQCtrIJMLQCQzDLz>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_DzEEEpaKJEVRMkZxvVJTGwYxVrH), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000470 RID: 1136
			// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00037E48 File Offset: 0x00036048
			// (set) Token: 0x06000D06 RID: 3334 RVA: 0x0000792F File Offset: 0x00005B2F
			public unsafe bool axXisVnNpjuUWWBaoouSeLwEixn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_axXisVnNpjuUWWBaoouSeLwEixn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_axXisVnNpjuUWWBaoouSeLwEixn)) = value;
				}
			}

			// Token: 0x17000471 RID: 1137
			// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00037E70 File Offset: 0x00036070
			// (set) Token: 0x06000D08 RID: 3336 RVA: 0x0000794A File Offset: 0x00005B4A
			public unsafe double goQFTHRYrUNsxKTEVRGFGXgYrbT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_goQFTHRYrUNsxKTEVRGFGXgYrbT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.NCUlcWyyhCTkXCxgwVqNMEUjCTe.NativeFieldInfoPtr_goQFTHRYrUNsxKTEVRGFGXgYrbT)) = value;
				}
			}

			// Token: 0x04000C19 RID: 3097
			private static readonly IntPtr NativeFieldInfoPtr_lCizAKDReHYAWMadabZzWnTynsN;

			// Token: 0x04000C1A RID: 3098
			private static readonly IntPtr NativeFieldInfoPtr_CSqArHMweKzDlupjVxOzYPqjaSJ;

			// Token: 0x04000C1B RID: 3099
			private static readonly IntPtr NativeFieldInfoPtr_ThqjaaYYFxrNYAplSZGbAYMqrDj;

			// Token: 0x04000C1C RID: 3100
			private static readonly IntPtr NativeFieldInfoPtr_DzEEEpaKJEVRMkZxvVJTGwYxVrH;

			// Token: 0x04000C1D RID: 3101
			private static readonly IntPtr NativeFieldInfoPtr_axXisVnNpjuUWWBaoouSeLwEixn;

			// Token: 0x04000C1E RID: 3102
			private static readonly IntPtr NativeFieldInfoPtr_goQFTHRYrUNsxKTEVRGFGXgYrbT;

			// Token: 0x04000C1F RID: 3103
			private static readonly IntPtr NativeMethodInfoPtr_get_sourceState_Public_get_MaEgfvevdVIfQCtrIJMLQCQzDLz_0;

			// Token: 0x04000C20 RID: 3104
			private static readonly IntPtr NativeMethodInfoPtr_get_changedState_Public_get_MaEgfvevdVIfQCtrIJMLQCQzDLz_0;

			// Token: 0x04000C21 RID: 3105
			private static readonly IntPtr NativeMethodInfoPtr_get_valueChanged_Public_get_Boolean_0;

			// Token: 0x04000C22 RID: 3106
			private static readonly IntPtr NativeMethodInfoPtr_get_lastChangedTimestamp_Public_get_Double_0;

			// Token: 0x04000C23 RID: 3107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MaEgfvevdVIfQCtrIJMLQCQzDLz_0;

			// Token: 0x04000C24 RID: 3108
			private static readonly IntPtr NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Double_0;

			// Token: 0x04000C25 RID: 3109
			private static readonly IntPtr NativeMethodInfoPtr_UjzsqHDScPlnWELAYrmDqTzdPIM_Public_Void_NCUlcWyyhCTkXCxgwVqNMEUjCTe_0;

			// Token: 0x04000C26 RID: 3110
			private static readonly IntPtr NativeMethodInfoPtr_QmxTIMaEMBeQiGjfpFYPTFpIJdzb_Private_Boolean_0;
		}

		// Token: 0x020000BA RID: 186
		public class xxNdTKEpEmrZxyHUUkmDlokLSxld : Object
		{
			// Token: 0x06000D09 RID: 3337 RVA: 0x00037E98 File Offset: 0x00036098
			// Note: this type is marked as 'beforefieldinit'.
			static xxNdTKEpEmrZxyHUUkmDlokLSxld()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "xxNdTKEpEmrZxyHUUkmDlokLSxld");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, "gusHCWBeNlrbYsMEBKlcvqKfDoT");
				ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, 100663487);
				ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_uOwTUAqJuTxgZTJKsRIMlqwZDeZ_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, 100663488);
				ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_pyuYZbVtvkRPLkXGbiJUCEvETcy_Public_IEnumerable_1_huwLQsTudyDmKGNMXEqbFGXyUGe_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, 100663489);
				ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_YWmSIrQCAqezdPoyxBTnhoyftbI_Private_Void_Int32_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, 100663490);
				ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, 100663491);
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00037F3C File Offset: 0x0003613C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349064, XrefRangeEnd = 349070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe xxNdTKEpEmrZxyHUUkmDlokLSxld()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x00037F78 File Offset: 0x00036178
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 349085, RefRangeEnd = 349089, XrefRangeStart = 349070, XrefRangeEnd = 349085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void uOwTUAqJuTxgZTJKsRIMlqwZDeZ(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_uOwTUAqJuTxgZTJKsRIMlqwZDeZ_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D0C RID: 3340 RVA: 0x00037FBC File Offset: 0x000361BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349094, RefRangeEnd = 349095, XrefRangeStart = 349089, XrefRangeEnd = 349094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe> pyuYZbVtvkRPLkXGbiJUCEvETcy(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1, ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.dPjibqvlOuPAdLsHbQeuqCgpqFl A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_pyuYZbVtvkRPLkXGbiJUCEvETcy_Public_IEnumerable_1_huwLQsTudyDmKGNMXEqbFGXyUGe_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>>(intPtr3) : null;
			}

			// Token: 0x06000D0D RID: 3341 RVA: 0x0003801C File Offset: 0x0003621C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349106, RefRangeEnd = 349107, XrefRangeStart = 349095, XrefRangeEnd = 349106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void YWmSIrQCAqezdPoyxBTnhoyftbI(int A_1, Guid A_2, int A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_YWmSIrQCAqezdPoyxBTnhoyftbI_Private_Void_Int32_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00038078 File Offset: 0x00036278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349107, XrefRangeEnd = 349155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x00007965 File Offset: 0x00005B65
			public xxNdTKEpEmrZxyHUUkmDlokLSxld(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000380BC File Offset: 0x000362BC
			// (set) Token: 0x06000D11 RID: 3345 RVA: 0x0000796E File Offset: 0x00005B6E
			public unsafe List<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe> gusHCWBeNlrbYsMEBKlcvqKfDoT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C27 RID: 3111
			private static readonly IntPtr NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT;

			// Token: 0x04000C28 RID: 3112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C29 RID: 3113
			private static readonly IntPtr NativeMethodInfoPtr_uOwTUAqJuTxgZTJKsRIMlqwZDeZ_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_0;

			// Token: 0x04000C2A RID: 3114
			private static readonly IntPtr NativeMethodInfoPtr_pyuYZbVtvkRPLkXGbiJUCEvETcy_Public_IEnumerable_1_huwLQsTudyDmKGNMXEqbFGXyUGe_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0;

			// Token: 0x04000C2B RID: 3115
			private static readonly IntPtr NativeMethodInfoPtr_YWmSIrQCAqezdPoyxBTnhoyftbI_Private_Void_Int32_Guid_Int32_0;

			// Token: 0x04000C2C RID: 3116
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000122 RID: 290
			[OriginalName("Rewired_Windows.dll", "", "dPjibqvlOuPAdLsHbQeuqCgpqFl")]
			public enum dPjibqvlOuPAdLsHbQeuqCgpqFl
			{
				// Token: 0x04001B27 RID: 6951
				cqFvgbREvaOHuBGfnPfDIMeHzpO,
				// Token: 0x04001B28 RID: 6952
				IpJNUAwnqcMPyudetEqVpEFXDzAE
			}

			// Token: 0x02000123 RID: 291
			public class huwLQsTudyDmKGNMXEqbFGXyUGe : Object
			{
				// Token: 0x060011B4 RID: 4532 RVA: 0x0004CD80 File Offset: 0x0004AF80
				// Note: this type is marked as 'beforefieldinit'.
				static huwLQsTudyDmKGNMXEqbFGXyUGe()
				{
					Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, "huwLQsTudyDmKGNMXEqbFGXyUGe");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "XUKXgpkeURQbNWYxnzWmsGORdLL");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "TDuxsXkDPajTuBGfNAPMKnjqIdbq");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "BLfxWbmyTsFYizOjLnroMuVRaUd");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "NEsIZMLRTnCdleEUzBtVXIIsWHd");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "uJThHFvMnnGWlhGgONRMIioDKZOj");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "fMsDvvtAhFIJLgiqYmvGYlgVARM");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, "OZweyeiUbnDOuxpLuoupDMKOgVli");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Boolean_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, 100663492);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, 100663493);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr, 100663494);
				}

				// Token: 0x060011B5 RID: 4533 RVA: 0x0004CE74 File Offset: 0x0004B074
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 348856, RefRangeEnd = 348857, XrefRangeStart = 348852, XrefRangeEnd = 348856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool PpfFXDqHyUXaiMeJUppAtMDNqvi(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw A_1, ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.dPjibqvlOuPAdLsHbQeuqCgpqFl A_2)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Boolean_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060011B6 RID: 4534 RVA: 0x0004CED0 File Offset: 0x0004B0D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348857, XrefRangeEnd = 349046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override string ToString()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060011B7 RID: 4535 RVA: 0x0004CF14 File Offset: 0x0004B114
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe huwLQsTudyDmKGNMXEqbFGXyUGe()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060011B8 RID: 4536 RVA: 0x0000A15E File Offset: 0x0000835E
				public huwLQsTudyDmKGNMXEqbFGXyUGe(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170005F4 RID: 1524
				// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0004CF50 File Offset: 0x0004B150
				// (set) Token: 0x060011BA RID: 4538 RVA: 0x0000A167 File Offset: 0x00008367
				public unsafe int XUKXgpkeURQbNWYxnzWmsGORdLL
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL)) = value;
					}
				}

				// Token: 0x170005F5 RID: 1525
				// (get) Token: 0x060011BB RID: 4539 RVA: 0x0004CF78 File Offset: 0x0004B178
				// (set) Token: 0x060011BC RID: 4540 RVA: 0x0000A182 File Offset: 0x00008382
				public unsafe Guid TDuxsXkDPajTuBGfNAPMKnjqIdbq
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq)) = value;
					}
				}

				// Token: 0x170005F6 RID: 1526
				// (get) Token: 0x060011BD RID: 4541 RVA: 0x0004CFA0 File Offset: 0x0004B1A0
				// (set) Token: 0x060011BE RID: 4542 RVA: 0x0000A19D File Offset: 0x0000839D
				public unsafe Guid BLfxWbmyTsFYizOjLnroMuVRaUd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd)) = value;
					}
				}

				// Token: 0x170005F7 RID: 1527
				// (get) Token: 0x060011BF RID: 4543 RVA: 0x0004CFC8 File Offset: 0x0004B1C8
				// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0000A1B8 File Offset: 0x000083B8
				public unsafe int NEsIZMLRTnCdleEUzBtVXIIsWHd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd)) = value;
					}
				}

				// Token: 0x170005F8 RID: 1528
				// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0004CFF0 File Offset: 0x0004B1F0
				// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0000A1D3 File Offset: 0x000083D3
				public unsafe int uJThHFvMnnGWlhGgONRMIioDKZOj
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj)) = value;
					}
				}

				// Token: 0x170005F9 RID: 1529
				// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0004D018 File Offset: 0x0004B218
				// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0000A1EE File Offset: 0x000083EE
				public unsafe int fMsDvvtAhFIJLgiqYmvGYlgVARM
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM)) = value;
					}
				}

				// Token: 0x170005FA RID: 1530
				// (get) Token: 0x060011C5 RID: 4549 RVA: 0x0004D040 File Offset: 0x0004B240
				// (set) Token: 0x060011C6 RID: 4550 RVA: 0x0000A209 File Offset: 0x00008409
				public unsafe int OZweyeiUbnDOuxpLuoupDMKOgVli
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli)) = value;
					}
				}

				// Token: 0x04001B29 RID: 6953
				private static readonly IntPtr NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL;

				// Token: 0x04001B2A RID: 6954
				private static readonly IntPtr NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq;

				// Token: 0x04001B2B RID: 6955
				private static readonly IntPtr NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd;

				// Token: 0x04001B2C RID: 6956
				private static readonly IntPtr NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd;

				// Token: 0x04001B2D RID: 6957
				private static readonly IntPtr NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj;

				// Token: 0x04001B2E RID: 6958
				private static readonly IntPtr NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM;

				// Token: 0x04001B2F RID: 6959
				private static readonly IntPtr NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli;

				// Token: 0x04001B30 RID: 6960
				private static readonly IntPtr NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Boolean_iHSGdmFZhWkJBBLEQPSmDckqrFUw_dPjibqvlOuPAdLsHbQeuqCgpqFl_0;

				// Token: 0x04001B31 RID: 6961
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

				// Token: 0x04001B32 RID: 6962
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x02000124 RID: 292
			public sealed class eIOhMldSbIiwoUELZrVWgZOgWYb : Object
			{
				// Token: 0x060011C7 RID: 4551 RVA: 0x0004D068 File Offset: 0x0004B268
				// Note: this type is marked as 'beforefieldinit'.
				static eIOhMldSbIiwoUELZrVWgZOgWYb()
				{
					Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>.NativeClassPtr, "eIOhMldSbIiwoUELZrVWgZOgWYb");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "hagrkYEKGHgWfVeuqDGSwljfqRk");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "poyFLvQJqpBqBCSyTDQhTmJIKbnJ");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "YJhQbhdgUViswToHoKBEorLmGpG");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "zYvOggOYJWkWYHTfuwFOvbNvpQl");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "NLMYqfSubrTVuBQIEZFGLpIppgD");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "dtArNceOjilclRmrtfdeVvzjqgK");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "qhNjyGyPtnCbyyBHGVfqpJDCHDt");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "WEWEENKIlEHwBcarOaBkUvDqgyzX");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_nzhNSAuZfHqUMiMiMTSdnGaEapw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "nzhNSAuZfHqUMiMiMTSdnGaEapw");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_YLXLrCxQifFUkVRDoAOTADoQRJm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, "YLXLrCxQifFUkVRDoAOTADoQRJm");
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Windows_DirectInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_huwLQsTudyDmKGNMXEqbFGXyUGe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663495);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663496);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663497);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Windows_DirectInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_huwLQsTudyDmKGNMXEqbFGXyUGe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663498);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663499);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663500);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663501);
					ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr, 100663502);
				}

				// Token: 0x060011C8 RID: 4552 RVA: 0x0004D1FC File Offset: 0x0004B3FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349046, XrefRangeEnd = 349054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe> System_Collections_Generic_IEnumerable_Rewired_Windows_DirectInputManager_JoystickRecords_Record__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Windows_DirectInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_huwLQsTudyDmKGNMXEqbFGXyUGe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>>(intPtr3) : null;
				}

				// Token: 0x060011C9 RID: 4553 RVA: 0x0004D23C File Offset: 0x0004B43C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x060011CA RID: 4554 RVA: 0x0004D27C File Offset: 0x0004B47C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349054, XrefRangeEnd = 349059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000605 RID: 1541
				// (get) Token: 0x060011CB RID: 4555 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe hhfpdGUOZEOAxmfPVuCCCpaubaN
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Windows_DirectInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_huwLQsTudyDmKGNMXEqbFGXyUGe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>(intPtr3) : null;
					}
				}

				// Token: 0x060011CC RID: 4556 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349059, XrefRangeEnd = 349064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060011CD RID: 4557 RVA: 0x0004D32C File Offset: 0x0004B52C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000606 RID: 1542
				// (get) Token: 0x060011CE RID: 4558 RVA: 0x0004D360 File Offset: 0x0004B560
				public unsafe Object exQSStbIkkFirilpySpDqHtFqeV
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060011CF RID: 4559 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe eIOhMldSbIiwoUELZrVWgZOgWYb(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060011D0 RID: 4560 RVA: 0x0000A224 File Offset: 0x00008424
				public eIOhMldSbIiwoUELZrVWgZOgWYb(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170005FB RID: 1531
				// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0004D3E8 File Offset: 0x0004B5E8
				// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0000A22D File Offset: 0x0000842D
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe hagrkYEKGHgWfVeuqDGSwljfqRk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.huwLQsTudyDmKGNMXEqbFGXyUGe>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005FC RID: 1532
				// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0004D418 File Offset: 0x0004B618
				// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0000A24C File Offset: 0x0000844C
				public unsafe int poyFLvQJqpBqBCSyTDQhTmJIKbnJ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ)) = value;
					}
				}

				// Token: 0x170005FD RID: 1533
				// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0004D440 File Offset: 0x0004B640
				// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0000A267 File Offset: 0x00008467
				public unsafe int YJhQbhdgUViswToHoKBEorLmGpG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG)) = value;
					}
				}

				// Token: 0x170005FE RID: 1534
				// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0004D468 File Offset: 0x0004B668
				// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0000A282 File Offset: 0x00008482
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld zYvOggOYJWkWYHTfuwFOvbNvpQl
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170005FF RID: 1535
				// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0004D498 File Offset: 0x0004B698
				// (set) Token: 0x060011DA RID: 4570 RVA: 0x0000A2A1 File Offset: 0x000084A1
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw NLMYqfSubrTVuBQIEZFGLpIppgD
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000600 RID: 1536
				// (get) Token: 0x060011DB RID: 4571 RVA: 0x0004D4C8 File Offset: 0x0004B6C8
				// (set) Token: 0x060011DC RID: 4572 RVA: 0x0000A2C0 File Offset: 0x000084C0
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw dtArNceOjilclRmrtfdeVvzjqgK
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000601 RID: 1537
				// (get) Token: 0x060011DD RID: 4573 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
				// (set) Token: 0x060011DE RID: 4574 RVA: 0x0000A2DF File Offset: 0x000084DF
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.dPjibqvlOuPAdLsHbQeuqCgpqFl qhNjyGyPtnCbyyBHGVfqpJDCHDt
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt)) = value;
					}
				}

				// Token: 0x17000602 RID: 1538
				// (get) Token: 0x060011DF RID: 4575 RVA: 0x0004D520 File Offset: 0x0004B720
				// (set) Token: 0x060011E0 RID: 4576 RVA: 0x0000A2FA File Offset: 0x000084FA
				public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.dPjibqvlOuPAdLsHbQeuqCgpqFl WEWEENKIlEHwBcarOaBkUvDqgyzX
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX)) = value;
					}
				}

				// Token: 0x17000603 RID: 1539
				// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0004D548 File Offset: 0x0004B748
				// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0000A315 File Offset: 0x00008515
				public unsafe int nzhNSAuZfHqUMiMiMTSdnGaEapw
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_nzhNSAuZfHqUMiMiMTSdnGaEapw);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_nzhNSAuZfHqUMiMiMTSdnGaEapw)) = value;
					}
				}

				// Token: 0x17000604 RID: 1540
				// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0004D570 File Offset: 0x0004B770
				// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0000A330 File Offset: 0x00008530
				public unsafe int YLXLrCxQifFUkVRDoAOTADoQRJm
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_YLXLrCxQifFUkVRDoAOTADoQRJm);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.xxNdTKEpEmrZxyHUUkmDlokLSxld.eIOhMldSbIiwoUELZrVWgZOgWYb.NativeFieldInfoPtr_YLXLrCxQifFUkVRDoAOTADoQRJm)) = value;
					}
				}

				// Token: 0x04001B33 RID: 6963
				private static readonly IntPtr NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk;

				// Token: 0x04001B34 RID: 6964
				private static readonly IntPtr NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ;

				// Token: 0x04001B35 RID: 6965
				private static readonly IntPtr NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG;

				// Token: 0x04001B36 RID: 6966
				private static readonly IntPtr NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl;

				// Token: 0x04001B37 RID: 6967
				private static readonly IntPtr NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD;

				// Token: 0x04001B38 RID: 6968
				private static readonly IntPtr NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK;

				// Token: 0x04001B39 RID: 6969
				private static readonly IntPtr NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt;

				// Token: 0x04001B3A RID: 6970
				private static readonly IntPtr NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX;

				// Token: 0x04001B3B RID: 6971
				private static readonly IntPtr NativeFieldInfoPtr_nzhNSAuZfHqUMiMiMTSdnGaEapw;

				// Token: 0x04001B3C RID: 6972
				private static readonly IntPtr NativeFieldInfoPtr_YLXLrCxQifFUkVRDoAOTADoQRJm;

				// Token: 0x04001B3D RID: 6973
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Windows_DirectInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_huwLQsTudyDmKGNMXEqbFGXyUGe_0;

				// Token: 0x04001B3E RID: 6974
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

				// Token: 0x04001B3F RID: 6975
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001B40 RID: 6976
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Windows_DirectInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_huwLQsTudyDmKGNMXEqbFGXyUGe_0;

				// Token: 0x04001B41 RID: 6977
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001B42 RID: 6978
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001B43 RID: 6979
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001B44 RID: 6980
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
			}
		}

		// Token: 0x020000BB RID: 187
		public class qLrmBekrRxATdwuXDDOTrHqiaRW : Object
		{
			// Token: 0x06000D12 RID: 3346 RVA: 0x000380EC File Offset: 0x000362EC
			// Note: this type is marked as 'beforefieldinit'.
			static qLrmBekrRxATdwuXDDOTrHqiaRW()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "qLrmBekrRxATdwuXDDOTrHqiaRW");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr, "SWSkqVEjiHnabOxljNQaBGNzOFT");
				ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr, "lqBzATSuHgWwXfTJMPicOqKhLIc");
				ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr, 100663503);
				ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeMethodInfoPtr__ctor_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_aebqsBAEhVilJeqHZosRvGGRxlb_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr, 100663504);
				ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeMethodInfoPtr_FtnGerGMeWtFKRAtFQYpELVozhj_Public_Static_List_1_aebqsBAEhVilJeqHZosRvGGRxlb_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr, 100663505);
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0003817C File Offset: 0x0003637C
			public unsafe bool wFvtdIWqNrGWrFqxSbSIDLPgtaZt
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x000381B8 File Offset: 0x000363B8
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe qLrmBekrRxATdwuXDDOTrHqiaRW(ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw joystick, aebqsBAEhVilJeqHZosRvGGRxlb deviceInstance)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deviceInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeMethodInfoPtr__ctor_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_aebqsBAEhVilJeqHZosRvGGRxlb_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D15 RID: 3349 RVA: 0x00038218 File Offset: 0x00036418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349155, XrefRangeEnd = 349167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static List<aebqsBAEhVilJeqHZosRvGGRxlb> FtnGerGMeWtFKRAtFQYpELVozhj(List<ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW> A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeMethodInfoPtr_FtnGerGMeWtFKRAtFQYpELVozhj_Public_Static_List_1_aebqsBAEhVilJeqHZosRvGGRxlb_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<aebqsBAEhVilJeqHZosRvGGRxlb>>(intPtr3) : null;
				}
			}

			// Token: 0x06000D16 RID: 3350 RVA: 0x0000798D File Offset: 0x00005B8D
			public qLrmBekrRxATdwuXDDOTrHqiaRW(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000477 RID: 1143
			// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0003825C File Offset: 0x0003645C
			// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00007996 File Offset: 0x00005B96
			public unsafe ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw SWSkqVEjiHnabOxljNQaBGNzOFT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ywcXCwDHBvioOXoUMwhfqIIEDX.iHSGdmFZhWkJBBLEQPSmDckqrFUw>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000478 RID: 1144
			// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0003828C File Offset: 0x0003648C
			// (set) Token: 0x06000D1A RID: 3354 RVA: 0x000079B5 File Offset: 0x00005BB5
			public unsafe aebqsBAEhVilJeqHZosRvGGRxlb lqBzATSuHgWwXfTJMPicOqKhLIc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<aebqsBAEhVilJeqHZosRvGGRxlb>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.qLrmBekrRxATdwuXDDOTrHqiaRW.NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C2D RID: 3117
			private static readonly IntPtr NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT;

			// Token: 0x04000C2E RID: 3118
			private static readonly IntPtr NativeFieldInfoPtr_lqBzATSuHgWwXfTJMPicOqKhLIc;

			// Token: 0x04000C2F RID: 3119
			private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

			// Token: 0x04000C30 RID: 3120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_iHSGdmFZhWkJBBLEQPSmDckqrFUw_aebqsBAEhVilJeqHZosRvGGRxlb_0;

			// Token: 0x04000C31 RID: 3121
			private static readonly IntPtr NativeMethodInfoPtr_FtnGerGMeWtFKRAtFQYpELVozhj_Public_Static_List_1_aebqsBAEhVilJeqHZosRvGGRxlb_List_1_qLrmBekrRxATdwuXDDOTrHqiaRW_0;
		}

		// Token: 0x020000BC RID: 188
		public class zcNzGwXdeHmAeReAXNspehYMYpr : Object
		{
			// Token: 0x06000D1B RID: 3355 RVA: 0x000382BC File Offset: 0x000364BC
			// Note: this type is marked as 'beforefieldinit'.
			static zcNzGwXdeHmAeReAXNspehYMYpr()
			{
				Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX>.NativeClassPtr, "zcNzGwXdeHmAeReAXNspehYMYpr");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr);
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_fkJeYONonlEGpvSjyNpxRVYxTCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, "fkJeYONonlEGpvSjyNpxRVYxTCd");
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_reqIZSHGtEvkMcmfOrMWvpzwUDkE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, "reqIZSHGtEvkMcmfOrMWvpzwUDkE");
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_DglprcNaVZYisgCKUIxPCHCXZTh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, "DglprcNaVZYisgCKUIxPCHCXZTh");
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_KZmPVSCtZyLzRrwUGltVWhgFcVAe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, "KZmPVSCtZyLzRrwUGltVWhgFcVAe");
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, 100663506);
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr_XqJGcYXGopYgOlmvziWNubEtaEs_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, 100663507);
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr_pqVFMhUUPmFOWrVLmEVhrlPBInN_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, 100663508);
				ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr_RqZsOGopsXeAGazOphRNsFRcKIJf_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr, 100663509);
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x00038388 File Offset: 0x00036588
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349185, RefRangeEnd = 349186, XrefRangeStart = 349167, XrefRangeEnd = 349185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe zcNzGwXdeHmAeReAXNspehYMYpr()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x000383C4 File Offset: 0x000365C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349186, XrefRangeEnd = 349187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool XqJGcYXGopYgOlmvziWNubEtaEs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr_XqJGcYXGopYgOlmvziWNubEtaEs_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D1E RID: 3358 RVA: 0x00038400 File Offset: 0x00036600
			[CallerCount(0)]
			public unsafe void pqVFMhUUPmFOWrVLmEVhrlPBInN(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr_pqVFMhUUPmFOWrVLmEVhrlPBInN_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D1F RID: 3359 RVA: 0x00038440 File Offset: 0x00036640
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349192, RefRangeEnd = 349194, XrefRangeStart = 349187, XrefRangeEnd = 349192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int RqZsOGopsXeAGazOphRNsFRcKIJf()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeMethodInfoPtr_RqZsOGopsXeAGazOphRNsFRcKIJf_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D20 RID: 3360 RVA: 0x000079D4 File Offset: 0x00005BD4
			public zcNzGwXdeHmAeReAXNspehYMYpr(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0003847C File Offset: 0x0003667C
			// (set) Token: 0x06000D22 RID: 3362 RVA: 0x000079DD File Offset: 0x00005BDD
			public unsafe XbCdfHsVWHGzaYTdEBgeKDAaNYvd.XdhjfjVcjCAPtIQhbLFPjfPAYuAD fkJeYONonlEGpvSjyNpxRVYxTCd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_fkJeYONonlEGpvSjyNpxRVYxTCd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_fkJeYONonlEGpvSjyNpxRVYxTCd)) = value;
				}
			}

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x06000D23 RID: 3363 RVA: 0x000384A4 File Offset: 0x000366A4
			// (set) Token: 0x06000D24 RID: 3364 RVA: 0x000079F8 File Offset: 0x00005BF8
			public XbCdfHsVWHGzaYTdEBgeKDAaNYvd.HtIFrZirTCEyZGEgQrOCItFkOlOI reqIZSHGtEvkMcmfOrMWvpzwUDkE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_reqIZSHGtEvkMcmfOrMWvpzwUDkE);
					return new XbCdfHsVWHGzaYTdEBgeKDAaNYvd.HtIFrZirTCEyZGEgQrOCItFkOlOI(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XbCdfHsVWHGzaYTdEBgeKDAaNYvd.HtIFrZirTCEyZGEgQrOCItFkOlOI>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_reqIZSHGtEvkMcmfOrMWvpzwUDkE), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XbCdfHsVWHGzaYTdEBgeKDAaNYvd.HtIFrZirTCEyZGEgQrOCItFkOlOI>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000384D4 File Offset: 0x000366D4
			// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00007A26 File Offset: 0x00005C26
			public unsafe NativeBuffer DglprcNaVZYisgCKUIxPCHCXZTh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_DglprcNaVZYisgCKUIxPCHCXZTh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_DglprcNaVZYisgCKUIxPCHCXZTh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00038504 File Offset: 0x00036704
			// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00007A45 File Offset: 0x00005C45
			public unsafe int KZmPVSCtZyLzRrwUGltVWhgFcVAe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_KZmPVSCtZyLzRrwUGltVWhgFcVAe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ywcXCwDHBvioOXoUMwhfqIIEDX.zcNzGwXdeHmAeReAXNspehYMYpr.NativeFieldInfoPtr_KZmPVSCtZyLzRrwUGltVWhgFcVAe)) = value;
				}
			}

			// Token: 0x04000C32 RID: 3122
			private static readonly IntPtr NativeFieldInfoPtr_fkJeYONonlEGpvSjyNpxRVYxTCd;

			// Token: 0x04000C33 RID: 3123
			private static readonly IntPtr NativeFieldInfoPtr_reqIZSHGtEvkMcmfOrMWvpzwUDkE;

			// Token: 0x04000C34 RID: 3124
			private static readonly IntPtr NativeFieldInfoPtr_DglprcNaVZYisgCKUIxPCHCXZTh;

			// Token: 0x04000C35 RID: 3125
			private static readonly IntPtr NativeFieldInfoPtr_KZmPVSCtZyLzRrwUGltVWhgFcVAe;

			// Token: 0x04000C36 RID: 3126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C37 RID: 3127
			private static readonly IntPtr NativeMethodInfoPtr_XqJGcYXGopYgOlmvziWNubEtaEs_Public_Boolean_0;

			// Token: 0x04000C38 RID: 3128
			private static readonly IntPtr NativeMethodInfoPtr_pqVFMhUUPmFOWrVLmEVhrlPBInN_Public_Void_Int32_0;

			// Token: 0x04000C39 RID: 3129
			private static readonly IntPtr NativeMethodInfoPtr_RqZsOGopsXeAGazOphRNsFRcKIJf_Private_Int32_0;
		}

		// Token: 0x020000BD RID: 189
		[OriginalName("Rewired_Windows.dll", "", "NjSaotJqTqBjFgJfQtXFAQMDfCL")]
		public enum NjSaotJqTqBjFgJfQtXFAQMDfCL
		{
			// Token: 0x04000C3B RID: 3131
			QXOOXdgsijJmZJgbJlRFgIgiPyA = 17,
			// Token: 0x04000C3C RID: 3132
			DcSuUDJhFYLWxppMuzlnvEUrGEB,
			// Token: 0x04000C3D RID: 3133
			itVWrfbIyivTlcEjFimvSCvumMF,
			// Token: 0x04000C3E RID: 3134
			vGYcFSHulPUWZEnaynRNJYSXJOG,
			// Token: 0x04000C3F RID: 3135
			ePPvCfMdQILUunGmtKHYocKjQDp,
			// Token: 0x04000C40 RID: 3136
			iXWpXFEgpRDzQWIAZdIrdGIUyeQ,
			// Token: 0x04000C41 RID: 3137
			YJPBDMHwWxMslhfvFIZibBMZypeH,
			// Token: 0x04000C42 RID: 3138
			sWLSIoqMAGQaVMJBwhWJiZgCIZ,
			// Token: 0x04000C43 RID: 3139
			NuBIiOjrxDUlbzuTxEgcKwZwVc,
			// Token: 0x04000C44 RID: 3140
			dfpuKQBtlZyVwjWWIqDICOJMifh,
			// Token: 0x04000C45 RID: 3141
			YAbBwdCIbsOXjRmAEjttYuuHwQD,
			// Token: 0x04000C46 RID: 3142
			jwtuFypoKtDKODzVyoxbELfNSuc
		}
	}
}
