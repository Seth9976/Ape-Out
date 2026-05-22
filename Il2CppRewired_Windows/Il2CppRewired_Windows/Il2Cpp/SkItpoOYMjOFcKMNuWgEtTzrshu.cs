using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using Il2CppRewired.Data;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Platforms;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppRewired.Windows.RawInput;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x0200000C RID: 12
	public class SkItpoOYMjOFcKMNuWgEtTzrshu : PlatformInputManager
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0000D320 File Offset: 0x0000B520
		// Note: this type is marked as 'beforefieldinit'.
		static SkItpoOYMjOFcKMNuWgEtTzrshu()
		{
			Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "SkItpoOYMjOFcKMNuWgEtTzrshu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_noadQEWvNBzmvkRFNlgqUoewXmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "noadQEWvNBzmvkRFNlgqUoewXmh");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "VnLufxclyjGsMiGdTbUEAvtMFIT");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "gZEqoosEOGLFarcAdrRuSzTDTbJ");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "OGMAvYfEinNsarzsJCSCDmxKLFH");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_bXUfPebzHCtXNKioLTqKldTnYHY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "bXUfPebzHCtXNKioLTqKldTnYHY");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "MMZGKCecFzCSjjpobYLpwBUdwTl");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "MbJqwIRGZjMByqVJbovfaJVENbo");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "rlvhAvIIAgpzhGBspLOycKQmvkk");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_iyLGOPggjdjwJDauEFTCJwqhLSNO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "iyLGOPggjdjwJDauEFTCJwqhLSNO");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_RFOwircEEnOIvXWtvwIQYwLSFXD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "RFOwircEEnOIvXWtvwIQYwLSFXD");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_LqCGYvXhJMhWaTAmOwdPykajaoW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "LqCGYvXhJMhWaTAmOwdPykajaoW");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "xSmScWUrtttKopPpVEMnBxFcRXCS");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "XgoiTRQUwWofwNpljdXDpYGrJws");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "HpCxuedDaobbAMjVDkAdFgnGlZr");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_FtVHfoPpEhjhNnSsEGqNiLgxQfzp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "FtVHfoPpEhjhNnSsEGqNiLgxQfzp");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_AwTqxvcepGUNNgMxKESVNfMddqz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "AwTqxvcepGUNNgMxKESVNfMddqz");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_uoUJdbVqYudYWObETFECgcqZVso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "uoUJdbVqYudYWObETFECgcqZVso");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_WLGeuFrKSxaRfbTobVfkcHTDwnj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "WLGeuFrKSxaRfbTobVfkcHTDwnj");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_xDnUKXkbpYFaoKeIUwUQkckllsCb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "xDnUKXkbpYFaoKeIUwUQkckllsCb");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "swOzpxtgHdYlzNpDnxeXdFTTYrt");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "bAJbZUeRbxcwwdOPEAlIzFuHOjFq");
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_set_useXInput_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663510);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr__ctor_Public_Void_ConfigVars_Boolean_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663511);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663512);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663513);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663514);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663515);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663516);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663517);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663518);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663519);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663520);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663521);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663522);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663523);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663524);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663525);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_KxhaXMeQypRqEgzbpoTrfTkeRbU_Public_Void_TcbfLsJvNivwNJttbooNtecDtTfB_WPOyThamDxsrbfLsNoTOiGbjxmd_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663526);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_DOtZFoPISBlRmBZmWXLeooOlsJx_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663527);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_DQASrABAmyWBchDqfpFDdtgAzyX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663528);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_DQASrABAmyWBchDqfpFDdtgAzyX_Private_Void_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663529);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_eUzGvVUIDBdVAlTwoSBTtvOgnkA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663530);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_KWMZRXEdDFzDdXiFffGIgPUNbKx_Private_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663531);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_RILvUEHqHImXpPCOJUkVLtrWrcb_Private_Void_Int32_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663532);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_qyJAFNQSxZQeRPMJIUlWtHQetPp_Private_Boolean_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663533);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_qkhSrSJBYhuwODeqVgWOAprxBhM_Private_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663534);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_knYfclcTzqWOQszkLRzAvrLkhCM_Private_Boolean_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663535);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_VAJvFwueMAlPhoBbQOgviANMjaD_Private_Void_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663536);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_FLJDHmUfZvztSSljfKRvIaGPIoQh_Private_Void_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663537);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_uMaflnBVuGxmoCmhHHVwPFjeqxG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663538);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_ohDlIWOhoNFIxptgowxIvhwjkgk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663539);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663540);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_qCXWcepcJrbsdOZfKVkyJUauWqE_Private_Boolean_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663541);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_fQgfztDwUDUNJOBmZpOcNxfRKsd_Private_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663542);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_MCgSEQNrgvEGbagLgasSJfLlcuC_Private_Boolean_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663543);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SXGflLsFwiXQRfevxwahWooILCt_Private_Void_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663544);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663545);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_IOrkaQXLGpOjfAKliuKmlSVeUTl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663546);
			SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_zypxbaXNNfoFWSooNlKxOptHBnt_Private_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, 100663547);
		}

		// Token: 0x17000045 RID: 69
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000D7EC File Offset: 0x0000B9EC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_set_useXInput_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000D82C File Offset: 0x0000BA2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350479, RefRangeEnd = 350482, XrefRangeStart = 350443, XrefRangeEnd = 350479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu(ConfigVars configVars, bool useXInput, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId, bool handleJoysticks, bool handleUnifiedMouse, bool handleUnifiedKeyboard, bool useCustomDrivers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(configVars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useXInput;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getNewJoystickId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleJoysticks;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleUnifiedMouse;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleUnifiedKeyboard;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCustomDrivers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr__ctor_Public_Void_ConfigVars_Boolean_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		public unsafe override int deviceCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000D92C File Offset: 0x0000BB2C
		public unsafe override PlatformInputManager primaryInputManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000D978 File Offset: 0x0000BB78
		public unsafe override IInputSource inputSource
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000D9C4 File Offset: 0x0000BBC4
		public unsafe override InputSource inputSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350482, XrefRangeEnd = 350497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000DA48 File Offset: 0x0000BC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350497, XrefRangeEnd = 350547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000DA94 File Offset: 0x0000BC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350547, XrefRangeEnd = 350571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		[CallerCount(0)]
		public unsafe override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr3) : null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350571, XrefRangeEnd = 350583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350583, XrefRangeEnd = 350589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350589, XrefRangeEnd = 350595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000DC48 File Offset: 0x0000BE48
		[CallerCount(0)]
		public unsafe override IUnifiedMouseSource GetUnifiedMouseSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr3) : null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000DC94 File Offset: 0x0000BE94
		[CallerCount(0)]
		public unsafe override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr3) : null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KxhaXMeQypRqEgzbpoTrfTkeRbU(TcbfLsJvNivwNJttbooNtecDtTfB A_1, WPOyThamDxsrbfLsNoTOiGbjxmd A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_KxhaXMeQypRqEgzbpoTrfTkeRbU_Public_Void_TcbfLsJvNivwNJttbooNtecDtTfB_WPOyThamDxsrbfLsNoTOiGbjxmd_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350595, XrefRangeEnd = 350602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DOtZFoPISBlRmBZmWXLeooOlsJx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_DOtZFoPISBlRmBZmWXLeooOlsJx_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000DD60 File Offset: 0x0000BF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350602, XrefRangeEnd = 350604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DQASrABAmyWBchDqfpFDdtgAzyX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_DQASrABAmyWBchDqfpFDdtgAzyX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000DD94 File Offset: 0x0000BF94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 350695, RefRangeEnd = 350700, XrefRangeStart = 350604, XrefRangeEnd = 350695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DQASrABAmyWBchDqfpFDdtgAzyX(IList<NCAKlOuHHtmlQFmgNIReWrsmixC> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_DQASrABAmyWBchDqfpFDdtgAzyX_Private_Void_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350700, XrefRangeEnd = 350702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void eUzGvVUIDBdVAlTwoSBTtvOgnkA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_eUzGvVUIDBdVAlTwoSBTtvOgnkA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000DE0C File Offset: 0x0000C00C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 350707, RefRangeEnd = 350712, XrefRangeStart = 350702, XrefRangeEnd = 350707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<NCAKlOuHHtmlQFmgNIReWrsmixC> KWMZRXEdDFzDdXiFffGIgPUNbKx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_KWMZRXEdDFzDdXiFffGIgPUNbKx_Private_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<NCAKlOuHHtmlQFmgNIReWrsmixC>>(intPtr3) : null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000DE4C File Offset: 0x0000C04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350750, RefRangeEnd = 350751, XrefRangeStart = 350712, XrefRangeEnd = 350750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RILvUEHqHImXpPCOJUkVLtrWrcb(int A_1, int A_2, List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_3, List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_4)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_RILvUEHqHImXpPCOJUkVLtrWrcb_Private_Void_Int32_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350753, RefRangeEnd = 350754, XrefRangeStart = 350751, XrefRangeEnd = 350753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qyJAFNQSxZQeRPMJIUlWtHQetPp(List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_qyJAFNQSxZQeRPMJIUlWtHQetPp_Private_Boolean_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000DF1C File Offset: 0x0000C11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350756, RefRangeEnd = 350757, XrefRangeStart = 350754, XrefRangeEnd = 350756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int qkhSrSJBYhuwODeqVgWOAprxBhM(List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_qkhSrSJBYhuwODeqVgWOAprxBhM_Private_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000DF6C File Offset: 0x0000C16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350760, RefRangeEnd = 350761, XrefRangeStart = 350757, XrefRangeEnd = 350760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool knYfclcTzqWOQszkLRzAvrLkhCM(List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_knYfclcTzqWOQszkLRzAvrLkhCM_Private_Boolean_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350761, XrefRangeEnd = 350768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VAJvFwueMAlPhoBbQOgviANMjaD(int A_1, List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_2, int A_3, List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_4, SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.waBscGOIlYYOzSEgBftmKSeqAKG A_5)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_VAJvFwueMAlPhoBbQOgviANMjaD_Private_Void_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000E048 File Offset: 0x0000C248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350787, RefRangeEnd = 350789, XrefRangeStart = 350768, XrefRangeEnd = 350787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FLJDHmUfZvztSSljfKRvIaGPIoQh(int A_1, List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_2, SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.waBscGOIlYYOzSEgBftmKSeqAKG A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_FLJDHmUfZvztSSljfKRvIaGPIoQh_Private_Void_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350789, XrefRangeEnd = 350800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void uMaflnBVuGxmoCmhHHVwPFjeqxG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_uMaflnBVuGxmoCmhHHVwPFjeqxG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350800, XrefRangeEnd = 350804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ohDlIWOhoNFIxptgowxIvhwjkgk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_ohDlIWOhoNFIxptgowxIvhwjkgk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000E110 File Offset: 0x0000C310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350804, XrefRangeEnd = 350808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BYAEaHJnSzdqqawqWqIvjtCnpnz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000E144 File Offset: 0x0000C344
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350825, RefRangeEnd = 350828, XrefRangeStart = 350808, XrefRangeEnd = 350825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qCXWcepcJrbsdOZfKVkyJUauWqE(IList<NCAKlOuHHtmlQFmgNIReWrsmixC> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_qCXWcepcJrbsdOZfKVkyJUauWqE_Private_Boolean_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000E194 File Offset: 0x0000C394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350835, RefRangeEnd = 350836, XrefRangeStart = 350828, XrefRangeEnd = 350835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool fQgfztDwUDUNJOBmZpOcNxfRKsd(Guid A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_fQgfztDwUDUNJOBmZpOcNxfRKsd_Private_Boolean_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350851, RefRangeEnd = 350852, XrefRangeStart = 350836, XrefRangeEnd = 350851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MCgSEQNrgvEGbagLgasSJfLlcuC(IList<NCAKlOuHHtmlQFmgNIReWrsmixC> A_1, Guid A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_MCgSEQNrgvEGbagLgasSJfLlcuC_Private_Boolean_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000E23C File Offset: 0x0000C43C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350863, RefRangeEnd = 350865, XrefRangeStart = 350852, XrefRangeEnd = 350863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SXGflLsFwiXQRfevxwahWooILCt(List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_1, List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> A_2, bool A_3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_SXGflLsFwiXQRfevxwahWooILCt_Private_Void_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350875, RefRangeEnd = 350877, XrefRangeStart = 350865, XrefRangeEnd = 350875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void uRkEmxgrfgrTYABDMNLqkschCkE(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350877, XrefRangeEnd = 350889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IOrkaQXLGpOjfAKliuKmlSVeUTl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_IOrkaQXLGpOjfAKliuKmlSVeUTl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000E32C File Offset: 0x0000C52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350889, XrefRangeEnd = 350890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zypxbaXNNfoFWSooNlKxOptHBnt(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeMethodInfoPtr_zypxbaXNNfoFWSooNlKxOptHBnt_Private_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002531 File Offset: 0x00000731
		public SkItpoOYMjOFcKMNuWgEtTzrshu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe UGSgCiEOJCcfDeSCAzsKERowBwza noadQEWvNBzmvkRFNlgqUoewXmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_noadQEWvNBzmvkRFNlgqUoewXmh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UGSgCiEOJCcfDeSCAzsKERowBwza>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_noadQEWvNBzmvkRFNlgqUoewXmh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002559 File Offset: 0x00000759
		public unsafe List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj> VnLufxclyjGsMiGdTbUEAvtMFIT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002578 File Offset: 0x00000778
		public unsafe int gZEqoosEOGLFarcAdrRuSzTDTbJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000E3F8 File Offset: 0x0000C5F8
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002593 File Offset: 0x00000793
		public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk OGMAvYfEinNsarzsJCSCDmxKLFH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000E428 File Offset: 0x0000C628
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000025B2 File Offset: 0x000007B2
		public unsafe bool bXUfPebzHCtXNKioLTqKldTnYHY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_bXUfPebzHCtXNKioLTqKldTnYHY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_bXUfPebzHCtXNKioLTqKldTnYHY)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000E450 File Offset: 0x0000C650
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000025CD File Offset: 0x000007CD
		public unsafe TimerRealTime MMZGKCecFzCSjjpobYLpwBUdwTl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerRealTime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000E480 File Offset: 0x0000C680
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000025EC File Offset: 0x000007EC
		public unsafe MixEZdcyOILrKdCCWuLKJJMVEyRk<bool> MbJqwIRGZjMByqVJbovfaJVENbo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixEZdcyOILrKdCCWuLKJJMVEyRk<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000260B File Offset: 0x0000080B
		public unsafe MixEZdcyOILrKdCCWuLKJJMVEyRk<bool> rlvhAvIIAgpzhGBspLOycKQmvkk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixEZdcyOILrKdCCWuLKJJMVEyRk<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000262A File Offset: 0x0000082A
		public unsafe int iyLGOPggjdjwJDauEFTCJwqhLSNO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_iyLGOPggjdjwJDauEFTCJwqhLSNO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_iyLGOPggjdjwJDauEFTCJwqhLSNO)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000E508 File Offset: 0x0000C708
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002645 File Offset: 0x00000845
		public unsafe int RFOwircEEnOIvXWtvwIQYwLSFXD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_RFOwircEEnOIvXWtvwIQYwLSFXD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_RFOwircEEnOIvXWtvwIQYwLSFXD)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000E530 File Offset: 0x0000C730
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002660 File Offset: 0x00000860
		public unsafe ConfigVars LqCGYvXhJMhWaTAmOwdPykajaoW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_LqCGYvXhJMhWaTAmOwdPykajaoW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigVars>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_LqCGYvXhJMhWaTAmOwdPykajaoW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000E560 File Offset: 0x0000C760
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000267F File Offset: 0x0000087F
		public unsafe bool xSmScWUrtttKopPpVEMnBxFcRXCS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000E588 File Offset: 0x0000C788
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000269A File Offset: 0x0000089A
		public unsafe Action<int, ControllerDataUpdater> XgoiTRQUwWofwNpljdXDpYGrJws
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000026B9 File Offset: 0x000008B9
		public unsafe PlatformInputManager HpCxuedDaobbAMjVDkAdFgnGlZr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000026D8 File Offset: 0x000008D8
		public unsafe QIdBJZYBjDGMCNFsDyeTIPPeVEO FtVHfoPpEhjhNnSsEGqNiLgxQfzp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_FtVHfoPpEhjhNnSsEGqNiLgxQfzp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QIdBJZYBjDGMCNFsDyeTIPPeVEO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_FtVHfoPpEhjhNnSsEGqNiLgxQfzp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000E618 File Offset: 0x0000C818
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000026F7 File Offset: 0x000008F7
		public unsafe wNobuidIdmqPxdVsORSDoNbAhlvK AwTqxvcepGUNNgMxKESVNfMddqz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_AwTqxvcepGUNNgMxKESVNfMddqz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<wNobuidIdmqPxdVsORSDoNbAhlvK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_AwTqxvcepGUNNgMxKESVNfMddqz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000E648 File Offset: 0x0000C848
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002716 File Offset: 0x00000916
		public unsafe bool uoUJdbVqYudYWObETFECgcqZVso
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_uoUJdbVqYudYWObETFECgcqZVso);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_uoUJdbVqYudYWObETFECgcqZVso)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000E670 File Offset: 0x0000C870
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002731 File Offset: 0x00000931
		public unsafe bool WLGeuFrKSxaRfbTobVfkcHTDwnj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_WLGeuFrKSxaRfbTobVfkcHTDwnj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_WLGeuFrKSxaRfbTobVfkcHTDwnj)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000E698 File Offset: 0x0000C898
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000274C File Offset: 0x0000094C
		public unsafe bool xDnUKXkbpYFaoKeIUwUQkckllsCb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_xDnUKXkbpYFaoKeIUwUQkckllsCb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_xDnUKXkbpYFaoKeIUwUQkckllsCb)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002767 File Offset: 0x00000967
		public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> swOzpxtgHdYlzNpDnxeXdFTTYrt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002786 File Offset: 0x00000986
		public unsafe Func<int> bAJbZUeRbxcwwdOPEAlIzFuHOjFq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_noadQEWvNBzmvkRFNlgqUoewXmh;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_VnLufxclyjGsMiGdTbUEAvtMFIT;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_gZEqoosEOGLFarcAdrRuSzTDTbJ;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_OGMAvYfEinNsarzsJCSCDmxKLFH;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_bXUfPebzHCtXNKioLTqKldTnYHY;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_MMZGKCecFzCSjjpobYLpwBUdwTl;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_MbJqwIRGZjMByqVJbovfaJVENbo;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_iyLGOPggjdjwJDauEFTCJwqhLSNO;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_RFOwircEEnOIvXWtvwIQYwLSFXD;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_LqCGYvXhJMhWaTAmOwdPykajaoW;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_xSmScWUrtttKopPpVEMnBxFcRXCS;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_HpCxuedDaobbAMjVDkAdFgnGlZr;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_FtVHfoPpEhjhNnSsEGqNiLgxQfzp;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_AwTqxvcepGUNNgMxKESVNfMddqz;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_uoUJdbVqYudYWObETFECgcqZVso;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_WLGeuFrKSxaRfbTobVfkcHTDwnj;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_xDnUKXkbpYFaoKeIUwUQkckllsCb;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_set_useXInput_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigVars_Boolean_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_KxhaXMeQypRqEgzbpoTrfTkeRbU_Public_Void_TcbfLsJvNivwNJttbooNtecDtTfB_WPOyThamDxsrbfLsNoTOiGbjxmd_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_DOtZFoPISBlRmBZmWXLeooOlsJx_Private_Void_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_DQASrABAmyWBchDqfpFDdtgAzyX_Private_Void_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_DQASrABAmyWBchDqfpFDdtgAzyX_Private_Void_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_eUzGvVUIDBdVAlTwoSBTtvOgnkA_Private_Void_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_KWMZRXEdDFzDdXiFffGIgPUNbKx_Private_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_RILvUEHqHImXpPCOJUkVLtrWrcb_Private_Void_Int32_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_qyJAFNQSxZQeRPMJIUlWtHQetPp_Private_Boolean_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_qkhSrSJBYhuwODeqVgWOAprxBhM_Private_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_knYfclcTzqWOQszkLRzAvrLkhCM_Private_Boolean_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_VAJvFwueMAlPhoBbQOgviANMjaD_Private_Void_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_FLJDHmUfZvztSSljfKRvIaGPIoQh_Private_Void_Int32_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_uMaflnBVuGxmoCmhHHVwPFjeqxG_Private_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_ohDlIWOhoNFIxptgowxIvhwjkgk_Private_Void_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_qCXWcepcJrbsdOZfKVkyJUauWqE_Private_Boolean_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_fQgfztDwUDUNJOBmZpOcNxfRKsd_Private_Boolean_Guid_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_MCgSEQNrgvEGbagLgasSJfLlcuC_Private_Boolean_IList_1_NCAKlOuHHtmlQFmgNIReWrsmixC_Guid_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_SXGflLsFwiXQRfevxwahWooILCt_Private_Void_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_List_1_SbLfEObBttmOEqgDPyGjWaDXoZj_Boolean_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_Boolean_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_IOrkaQXLGpOjfAKliuKmlSVeUTl_Private_Boolean_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_zypxbaXNNfoFWSooNlKxOptHBnt_Private_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

		// Token: 0x020000BE RID: 190
		public class SbLfEObBttmOEqgDPyGjWaDXoZj : Object
		{
			// Token: 0x06000D29 RID: 3369 RVA: 0x0003852C File Offset: 0x0003672C
			// Note: this type is marked as 'beforefieldinit'.
			static SbLfEObBttmOEqgDPyGjWaDXoZj()
			{
				Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "SbLfEObBttmOEqgDPyGjWaDXoZj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "GNKcpIRbTxVSstxcCBqZKkcbietE");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "JFhGUotVGyvgqRcgpmFnXSQrssJ");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "WmRdwFvHdKGkxAZMIAvntNHLbaxg");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "WLPWeHrDCPCLfETsRQYzcumJyOe");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "SWSkqVEjiHnabOxljNQaBGNzOFT");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_IjJmmAdpNcsRLKbzSgBUhlFquWO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "IjJmmAdpNcsRLKbzSgBUhlFquWO");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "xcraKzUBKKbqrrMoJhsaaxGOFXRT");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "XweWIFEyvCMnXulreJEhSfAAWOo");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "UOiadLOPlNhsLbNzLGQXTPSGUrP");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "ePNBvlGnonVgXbSNyjfUvrOPppq");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_QNriiYyDefcYxiGNiogfBFplnmK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "QNriiYyDefcYxiGNiogfBFplnmK");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "pFkVRJEPoSBxlAjsHKMcxCzbNGQ");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "lzufHdDGBKQEIiVjiKYtKEEDzaGM");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "BLfxWbmyTsFYizOjLnroMuVRaUd");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "zRSLRumgAHYvaVfMhktxhOcdJEz");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "xnwhPiSLJZAWeXtpbVDLHoIbBMl");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "ilvTWYfRywhZpsIyUtQNREFcjLsj");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "uJThHFvMnnGWlhGgONRMIioDKZOj");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "fMsDvvtAhFIJLgiqYmvGYlgVARM");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "OZweyeiUbnDOuxpLuoupDMKOgVli");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "DvJhuGjaHKRdHunWyrEKRNDBrab");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "AvCqApdLGDXHFPBkTTaAQSVHPfK");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "fluTuRVpPCEGssJAmSiTqFgASHv");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_iXcFIKunTVeCZUaJOQlTQdlvObM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "iXcFIKunTVeCZUaJOQlTQdlvObM");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "CwSFCVqDCbrQyrvPmmvtgaAynZj");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "sHeRoiRHkuXpbNwEMmzznSiAEVf");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_rdbowCCLSvWWdSgEzCsNVlkuLFV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "rdbowCCLSvWWdSgEzCsNVlkuLFV");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "OHFiyNAurvAHndtKvlMxUsQwcRc");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_QnMBRLjBpUctTxKAlRhZitHXchtE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "QnMBRLjBpUctTxKAlRhZitHXchtE");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "swOzpxtgHdYlzNpDnxeXdFTTYrt");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "lNjuiEzDctUBliWAKQtnwVRUssh");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "KmDzQOsJBlrBVPwQvpSIJVwVAej");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "qCyeROasFnJmaEJMACZydOijuQgZ");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_VKfydcfIuthciwJAObUcwgFbJao = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, "VKfydcfIuthciwJAObUcwgFbJao");
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_hasDriver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663548);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663549);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663550);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663551);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663552);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663553);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663554);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663555);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663556);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_set_extension_Public_set_Void_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663557);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663558);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663559);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663560);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663561);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663562);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr__ctor_Public_Void_NCAKlOuHHtmlQFmgNIReWrsmixC_DeviceType_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663563);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_jgeCBEMtzKMTxBWHKEzsNZSbcZA_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663564);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663565);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663566);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663567);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663568);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Private_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663569);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663570);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663571);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663572);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663573);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_MnKfNqjxLlxeBKgTKVckDkWYfiXR_Private_Void_Axis_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663574);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_MCTjNTarCEETqZZnpAEOspBfjIV_Private_Void_Button_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663575);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663576);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_RawInputAxis_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663577);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Single_Button_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663578);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663579);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_vHPFVpeYMSXPpVGDKlRsxYWNAxN_Private_Single_Int32_Int32_HatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663580);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_mARCrvdmUYeEwAQXLmQRoaZYrBx_Private_Single_Int32_AxisDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663581);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_kJNGlsEDqDckESXjfROGpyQJlMx_Private_Boolean_CustomCalculationSourceData_Il2CppStructArray_1_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663582);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ROElGxvxwjOsQqbtUxHVBlYTlwS_Private_Boolean_CustomCalculationSourceData_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663583);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_vOahjFKxQVMSIdknBzwAOvWxJQY_Private_ControlDeviceType_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663584);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_AjCJZoSlAAwrIZRUmKMFTaJWJDP_Private_Void_Axis_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663585);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ldPMzzUrEKlHVjzvneFXACaMmOf_Private_Void_Button_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663586);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xUhQAGXwmisrJaEsIAOCRbjWcYog_Private_Single_Axis_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663587);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xUhQAGXwmisrJaEsIAOCRbjWcYog_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663588);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_XYKfBeMnMyxSHvdJIFlReutgEIiI_Private_Single_Button_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663589);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663590);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_GxMKQzmqXFgumLhiAHMyHUVdKniG_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663591);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663592);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663593);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_GSGWoDIqRLoSTVEGPZGnWuXPYcg_Private_Il2CppReferenceArray_1_UnknownControllerHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663594);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663595);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663596);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663597);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BgUdzPVUMGNmXeVpiTHfyfpLFkQ_Public_Static_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663598);
				SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BDcNszefYmjxbhANdakPWxuGSon_Public_Static_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr, 100663599);
			}

			// Token: 0x170004A0 RID: 1184
			// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00038C10 File Offset: 0x00036E10
			public unsafe bool HlHsXhgfRKEMFFzncMPMohdcDNwF
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 349732, RefRangeEnd = 349736, XrefRangeStart = 349730, XrefRangeEnd = 349732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_hasDriver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004A1 RID: 1185
			// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00038C4C File Offset: 0x00036E4C
			// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00038C88 File Offset: 0x00036E88
			public unsafe virtual int rewiredId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170004A2 RID: 1186
			// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00038CC8 File Offset: 0x00036EC8
			// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00038D04 File Offset: 0x00036F04
			public unsafe virtual int inputManagerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170004A3 RID: 1187
			// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00038D44 File Offset: 0x00036F44
			public unsafe virtual string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349736, XrefRangeEnd = 349738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00038D7C File Offset: 0x00036F7C
			public unsafe virtual Nullable<long> systemId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349738, XrefRangeEnd = 349739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
			}

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00038DB4 File Offset: 0x00036FB4
			public unsafe virtual int unityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004A6 RID: 1190
			// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00038DF0 File Offset: 0x00036FF0
			// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00038E30 File Offset: 0x00037030
			public unsafe virtual Controller.Extension extension
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 92148, RefRangeEnd = 92153, XrefRangeStart = 92148, XrefRangeEnd = 92153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_set_extension_Public_set_Void_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170004A7 RID: 1191
			// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00038E74 File Offset: 0x00037074
			public unsafe virtual Guid instanceGuid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004A8 RID: 1192
			// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00038EB0 File Offset: 0x000370B0
			public unsafe virtual Guid persistentGuid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x00038EEC File Offset: 0x000370EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349739, XrefRangeEnd = 349742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D37 RID: 3383 RVA: 0x00038F38 File Offset: 0x00037138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void StopVibration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00038F6C File Offset: 0x0003716C
			public unsafe bool wFvtdIWqNrGWrFqxSbSIDLPgtaZt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 349745, RefRangeEnd = 349747, XrefRangeStart = 349742, XrefRangeEnd = 349745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x00038FA8 File Offset: 0x000371A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349747, RefRangeEnd = 349748, XrefRangeStart = 349747, XrefRangeEnd = 349747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SbLfEObBttmOEqgDPyGjWaDXoZj(NCAKlOuHHtmlQFmgNIReWrsmixC joystick, DeviceType riDeviceType, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref riDeviceType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr__ctor_Public_Void_NCAKlOuHHtmlQFmgNIReWrsmixC_DeviceType_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x00039014 File Offset: 0x00037214
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349793, RefRangeEnd = 349794, XrefRangeStart = 349748, XrefRangeEnd = 349793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void jgeCBEMtzKMTxBWHKEzsNZSbcZA()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_jgeCBEMtzKMTxBWHKEzsNZSbcZA_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x00039048 File Offset: 0x00037248
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349800, RefRangeEnd = 349802, XrefRangeStart = 349794, XrefRangeEnd = 349800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void nmYEDBcicBHXDwuAcMZQWyZRpHE(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D3C RID: 3388 RVA: 0x0003908C File Offset: 0x0003728C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 349810, RefRangeEnd = 349813, XrefRangeStart = 349802, XrefRangeEnd = 349810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x000390C0 File Offset: 0x000372C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349813, XrefRangeEnd = 349817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void FillData(ControllerDataUpdater dataUpdater)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x00039104 File Offset: 0x00037304
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349831, RefRangeEnd = 349833, XrefRangeStart = 349817, XrefRangeEnd = 349831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int PpfFXDqHyUXaiMeJUppAtMDNqvi(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x00039154 File Offset: 0x00037354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349833, XrefRangeEnd = 349837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BridgedControllerHWInfo QkACchszAolJQBMMsHcyPLktlPB()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Private_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedControllerHWInfo>(intPtr3) : null;
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x00039194 File Offset: 0x00037394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349837, XrefRangeEnd = 349844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual BridgedController ToBridgedController()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedController>(intPtr3) : null;
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x000391D4 File Offset: 0x000373D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349844, XrefRangeEnd = 349850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDisconnectedEventArgs>(intPtr3) : null;
			}

			// Token: 0x06000D42 RID: 3394 RVA: 0x00039214 File Offset: 0x00037414
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349862, RefRangeEnd = 349863, XrefRangeStart = 349850, XrefRangeEnd = 349862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x00039268 File Offset: 0x00037468
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349875, RefRangeEnd = 349876, XrefRangeStart = 349863, XrefRangeEnd = 349875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x000392BC File Offset: 0x000374BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349877, RefRangeEnd = 349879, XrefRangeStart = 349876, XrefRangeEnd = 349877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_MnKfNqjxLlxeBKgTKVckDkWYfiXR_Private_Void_Axis_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x00039334 File Offset: 0x00037534
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349880, RefRangeEnd = 349882, XrefRangeStart = 349879, XrefRangeEnd = 349880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_MCTjNTarCEETqZZnpAEOspBfjIV_Private_Void_Button_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x000393AC File Offset: 0x000375AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349898, RefRangeEnd = 349899, XrefRangeStart = 349882, XrefRangeEnd = 349898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x00039420 File Offset: 0x00037620
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349903, RefRangeEnd = 349904, XrefRangeStart = 349899, XrefRangeEnd = 349903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float BlNbZUiJZlAsIpeFJrmqKMdIohR(RawInputAxis A_1, int A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_RawInputAxis_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x00039478 File Offset: 0x00037678
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349924, RefRangeEnd = 349925, XrefRangeStart = 349904, XrefRangeEnd = 349924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float vGIDntSyHOcwKzWObiWxnUfsrtQ(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base A_1, Il2CppStructArray<bool> A_2, Il2CppStructArray<int> A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Single_Button_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x000394EC File Offset: 0x000376EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349926, RefRangeEnd = 349928, XrefRangeStart = 349925, XrefRangeEnd = 349926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float giTkLqleHbFHnWmDqeZsZmbNCBJH(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x00039538 File Offset: 0x00037738
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349930, RefRangeEnd = 349932, XrefRangeStart = 349928, XrefRangeEnd = 349930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float vHPFVpeYMSXPpVGDKlRsxYWNAxN(int A_1, int A_2, HatType A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_vHPFVpeYMSXPpVGDKlRsxYWNAxN_Private_Single_Int32_Int32_HatType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x000395A0 File Offset: 0x000377A0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_mARCrvdmUYeEwAQXLmQRoaZYrBx_Private_Single_Int32_AxisDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D4C RID: 3404 RVA: 0x000395F8 File Offset: 0x000377F8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_kJNGlsEDqDckESXjfROGpyQJlMx_Private_Boolean_CustomCalculationSourceData_Il2CppStructArray_1_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x00039668 File Offset: 0x00037868
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349935, RefRangeEnd = 349937, XrefRangeStart = 349932, XrefRangeEnd = 349935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ROElGxvxwjOsQqbtUxHVBlYTlwS_Private_Boolean_CustomCalculationSourceData_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x000396C4 File Offset: 0x000378C4
			[CallerCount(0)]
			public unsafe ControlDeviceType vOahjFKxQVMSIdknBzwAOvWxJQY(DeviceType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_vOahjFKxQVMSIdknBzwAOvWxJQY_Private_ControlDeviceType_DeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x00039710 File Offset: 0x00037910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349937, XrefRangeEnd = 349938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AjCJZoSlAAwrIZRUmKMFTaJWJDP(HardwareJoystickMap.Platform_InternalDriver_Base.Axis A_1, int A_2, Il2CppStructArray<bool> A_3, Il2CppStructArray<int> A_4)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_AjCJZoSlAAwrIZRUmKMFTaJWJDP_Private_Void_Axis_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D50 RID: 3408 RVA: 0x00039788 File Offset: 0x00037988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349938, XrefRangeEnd = 349939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ldPMzzUrEKlHVjzvneFXACaMmOf(HardwareJoystickMap.Platform_InternalDriver_Base.Button A_1, int A_2, Il2CppStructArray<bool> A_3, Il2CppStructArray<int> A_4)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_ldPMzzUrEKlHVjzvneFXACaMmOf_Private_Void_Button_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D51 RID: 3409 RVA: 0x00039800 File Offset: 0x00037A00
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349941, RefRangeEnd = 349943, XrefRangeStart = 349939, XrefRangeEnd = 349941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float xUhQAGXwmisrJaEsIAOCRbjWcYog(HardwareJoystickMap.Platform_InternalDriver_Base.Axis A_1, Il2CppStructArray<bool> A_2, Il2CppStructArray<int> A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xUhQAGXwmisrJaEsIAOCRbjWcYog_Private_Single_Axis_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D52 RID: 3410 RVA: 0x00039874 File Offset: 0x00037A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349943, XrefRangeEnd = 349947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float xUhQAGXwmisrJaEsIAOCRbjWcYog(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xUhQAGXwmisrJaEsIAOCRbjWcYog_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D53 RID: 3411 RVA: 0x000398C0 File Offset: 0x00037AC0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349948, RefRangeEnd = 349950, XrefRangeStart = 349947, XrefRangeEnd = 349948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float XYKfBeMnMyxSHvdJIFlReutgEIiI(HardwareJoystickMap.Platform_InternalDriver_Base.Button A_1, Il2CppStructArray<bool> A_2, Il2CppStructArray<int> A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_XYKfBeMnMyxSHvdJIFlReutgEIiI_Private_Single_Button_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x00039934 File Offset: 0x00037B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349950, XrefRangeEnd = 349958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CQTmbqHFWEknbPpZQtaQsFEAfWh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x00039968 File Offset: 0x00037B68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350009, RefRangeEnd = 350010, XrefRangeStart = 349958, XrefRangeEnd = 350009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GxMKQzmqXFgumLhiAHMyHUVdKniG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_GxMKQzmqXFgumLhiAHMyHUVdKniG_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000D56 RID: 3414 RVA: 0x000399A0 File Offset: 0x00037BA0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 350026, RefRangeEnd = 350030, XrefRangeStart = 350010, XrefRangeEnd = 350026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xjeVBysddNzJLefqSMyUGbIFKoA(BridgedControllerHWInfo A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x000399E4 File Offset: 0x00037BE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350039, RefRangeEnd = 350040, XrefRangeStart = 350030, XrefRangeEnd = 350039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xjeVBysddNzJLefqSMyUGbIFKoA(BridgedController A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x00039A28 File Offset: 0x00037C28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350056, RefRangeEnd = 350057, XrefRangeStart = 350040, XrefRangeEnd = 350056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<UnknownControllerHat> GSGWoDIqRLoSTVEGPZGnWuXPYcg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_GSGWoDIqRLoSTVEGPZGnWuXPYcg_Private_Il2CppReferenceArray_1_UnknownControllerHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnknownControllerHat>>(intPtr3) : null;
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x00039A68 File Offset: 0x00037C68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350061, RefRangeEnd = 350062, XrefRangeStart = 350057, XrefRangeEnd = 350061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QRqHkxHQdTOvmTIyHpJqpqzNcTZi()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x00039A9C File Offset: 0x00037C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D5B RID: 3419 RVA: 0x00039AD8 File Offset: 0x00037CD8
			[CallerCount(0)]
			public unsafe virtual void QRqHkxHQdTOvmTIyHpJqpqzNcTZi(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x00039B24 File Offset: 0x00037D24
			[CallerCount(0)]
			public unsafe static int BgUdzPVUMGNmXeVpiTHfyfpLFkQ(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_0, SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BgUdzPVUMGNmXeVpiTHfyfpLFkQ_Public_Static_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_SbLfEObBttmOEqgDPyGjWaDXoZj_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x00039B78 File Offset: 0x00037D78
			[CallerCount(0)]
			public unsafe static int BDcNszefYmjxbhANdakPWxuGSon(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_0, SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeMethodInfoPtr_BDcNszefYmjxbhANdakPWxuGSon_Public_Static_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_SbLfEObBttmOEqgDPyGjWaDXoZj_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D5E RID: 3422 RVA: 0x00007A60 File Offset: 0x00005C60
			public SbLfEObBttmOEqgDPyGjWaDXoZj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00039BCC File Offset: 0x00037DCC
			// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00007A69 File Offset: 0x00005C69
			public unsafe int GNKcpIRbTxVSstxcCBqZKkcbietE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE)) = value;
				}
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00039BF4 File Offset: 0x00037DF4
			// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00007A84 File Offset: 0x00005C84
			public unsafe int JFhGUotVGyvgqRcgpmFnXSQrssJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ)) = value;
				}
			}

			// Token: 0x17000480 RID: 1152
			// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00039C1C File Offset: 0x00037E1C
			// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00007A9F File Offset: 0x00005C9F
			public unsafe Guid WmRdwFvHdKGkxAZMIAvntNHLbaxg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg)) = value;
				}
			}

			// Token: 0x17000481 RID: 1153
			// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00039C44 File Offset: 0x00037E44
			// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00007ABA File Offset: 0x00005CBA
			public unsafe string WLPWeHrDCPCLfETsRQYzcumJyOe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00039C6C File Offset: 0x00037E6C
			// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00007AD9 File Offset: 0x00005CD9
			public unsafe NCAKlOuHHtmlQFmgNIReWrsmixC SWSkqVEjiHnabOxljNQaBGNzOFT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NCAKlOuHHtmlQFmgNIReWrsmixC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00039C9C File Offset: 0x00037E9C
			// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00007AF8 File Offset: 0x00005CF8
			public unsafe DeviceType IjJmmAdpNcsRLKbzSgBUhlFquWO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_IjJmmAdpNcsRLKbzSgBUhlFquWO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_IjJmmAdpNcsRLKbzSgBUhlFquWO)) = value;
				}
			}

			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00039CC4 File Offset: 0x00037EC4
			// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00007B13 File Offset: 0x00005D13
			public unsafe string xcraKzUBKKbqrrMoJhsaaxGOFXRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00039CEC File Offset: 0x00037EEC
			// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00007B32 File Offset: 0x00005D32
			public unsafe string XweWIFEyvCMnXulreJEhSfAAWOo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00039D14 File Offset: 0x00037F14
			// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00007B51 File Offset: 0x00005D51
			public unsafe string UOiadLOPlNhsLbNzLGQXTPSGUrP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00039D3C File Offset: 0x00037F3C
			// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00007B70 File Offset: 0x00005D70
			public unsafe int ePNBvlGnonVgXbSNyjfUvrOPppq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq)) = value;
				}
			}

			// Token: 0x17000488 RID: 1160
			// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00039D64 File Offset: 0x00037F64
			// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00007B8B File Offset: 0x00005D8B
			public unsafe int QNriiYyDefcYxiGNiogfBFplnmK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_QNriiYyDefcYxiGNiogfBFplnmK);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_QNriiYyDefcYxiGNiogfBFplnmK)) = value;
				}
			}

			// Token: 0x17000489 RID: 1161
			// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00039D8C File Offset: 0x00037F8C
			// (set) Token: 0x06000D76 RID: 3446 RVA: 0x00007BA6 File Offset: 0x00005DA6
			public unsafe Guid pFkVRJEPoSBxlAjsHKMcxCzbNGQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ)) = value;
				}
			}

			// Token: 0x1700048A RID: 1162
			// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00039DB4 File Offset: 0x00037FB4
			// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00007BC1 File Offset: 0x00005DC1
			public unsafe Guid lzufHdDGBKQEIiVjiKYtKEEDzaGM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM)) = value;
				}
			}

			// Token: 0x1700048B RID: 1163
			// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00039DDC File Offset: 0x00037FDC
			// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00007BDC File Offset: 0x00005DDC
			public unsafe Guid BLfxWbmyTsFYizOjLnroMuVRaUd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd)) = value;
				}
			}

			// Token: 0x1700048C RID: 1164
			// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00039E04 File Offset: 0x00038004
			// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00007BF7 File Offset: 0x00005DF7
			public unsafe int zRSLRumgAHYvaVfMhktxhOcdJEz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz)) = value;
				}
			}

			// Token: 0x1700048D RID: 1165
			// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00039E2C File Offset: 0x0003802C
			// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00007C12 File Offset: 0x00005E12
			public unsafe int xnwhPiSLJZAWeXtpbVDLHoIbBMl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl)) = value;
				}
			}

			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00039E54 File Offset: 0x00038054
			// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00007C2D File Offset: 0x00005E2D
			public unsafe int ilvTWYfRywhZpsIyUtQNREFcjLsj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj)) = value;
				}
			}

			// Token: 0x1700048F RID: 1167
			// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00039E7C File Offset: 0x0003807C
			// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00007C48 File Offset: 0x00005E48
			public unsafe int uJThHFvMnnGWlhGgONRMIioDKZOj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj)) = value;
				}
			}

			// Token: 0x17000490 RID: 1168
			// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00039EA4 File Offset: 0x000380A4
			// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00007C63 File Offset: 0x00005E63
			public unsafe int fMsDvvtAhFIJLgiqYmvGYlgVARM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM)) = value;
				}
			}

			// Token: 0x17000491 RID: 1169
			// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00039ECC File Offset: 0x000380CC
			// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00007C7E File Offset: 0x00005E7E
			public unsafe int OZweyeiUbnDOuxpLuoupDMKOgVli
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli)) = value;
				}
			}

			// Token: 0x17000492 RID: 1170
			// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00039EF4 File Offset: 0x000380F4
			// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00007C99 File Offset: 0x00005E99
			public unsafe bool DvJhuGjaHKRdHunWyrEKRNDBrab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab)) = value;
				}
			}

			// Token: 0x17000493 RID: 1171
			// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00039F1C File Offset: 0x0003811C
			// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00007CB4 File Offset: 0x00005EB4
			public unsafe bool AvCqApdLGDXHFPBkTTaAQSVHPfK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK)) = value;
				}
			}

			// Token: 0x17000494 RID: 1172
			// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00039F44 File Offset: 0x00038144
			// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00007CCF File Offset: 0x00005ECF
			public unsafe bool fluTuRVpPCEGssJAmSiTqFgASHv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv)) = value;
				}
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00039F6C File Offset: 0x0003816C
			// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00007CEA File Offset: 0x00005EEA
			public unsafe int iXcFIKunTVeCZUaJOQlTQdlvObM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_iXcFIKunTVeCZUaJOQlTQdlvObM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_iXcFIKunTVeCZUaJOQlTQdlvObM)) = value;
				}
			}

			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00039F94 File Offset: 0x00038194
			// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00007D05 File Offset: 0x00005F05
			public unsafe Il2CppStructArray<float> CwSFCVqDCbrQyrvPmmvtgaAynZj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00039FC4 File Offset: 0x000381C4
			// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00007D24 File Offset: 0x00005F24
			public unsafe Il2CppStructArray<float> sHeRoiRHkuXpbNwEMmzznSiAEVf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00039FF4 File Offset: 0x000381F4
			// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00007D43 File Offset: 0x00005F43
			public unsafe Il2CppStructArray<bool> rdbowCCLSvWWdSgEzCsNVlkuLFV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_rdbowCCLSvWWdSgEzCsNVlkuLFV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_rdbowCCLSvWWdSgEzCsNVlkuLFV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0003A024 File Offset: 0x00038224
			// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00007D62 File Offset: 0x00005F62
			public unsafe HardwareJoystickMap_InputManager OHFiyNAurvAHndtKvlMxUsQwcRc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0003A054 File Offset: 0x00038254
			// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00007D81 File Offset: 0x00005F81
			public unsafe qtwrjJONpfKCHURInubHVWIzKtT QnMBRLjBpUctTxKAlRhZitHXchtE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_QnMBRLjBpUctTxKAlRhZitHXchtE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<qtwrjJONpfKCHURInubHVWIzKtT>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_QnMBRLjBpUctTxKAlRhZitHXchtE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0003A084 File Offset: 0x00038284
			// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00007DA0 File Offset: 0x00005FA0
			public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> swOzpxtgHdYlzNpDnxeXdFTTYrt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0003A0B4 File Offset: 0x000382B4
			// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00007DBF File Offset: 0x00005FBF
			public unsafe bool lNjuiEzDctUBliWAKQtnwVRUssh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh)) = value;
				}
			}

			// Token: 0x1700049D RID: 1181
			// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0003A0DC File Offset: 0x000382DC
			// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00007DDA File Offset: 0x00005FDA
			public unsafe bool KmDzQOsJBlrBVPwQvpSIJVwVAej
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej)) = value;
				}
			}

			// Token: 0x1700049E RID: 1182
			// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0003A104 File Offset: 0x00038304
			// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00007DF5 File Offset: 0x00005FF5
			public unsafe bool qCyeROasFnJmaEJMACZydOijuQgZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ)) = value;
				}
			}

			// Token: 0x1700049F RID: 1183
			// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0003A12C File Offset: 0x0003832C
			// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00007E10 File Offset: 0x00006010
			public unsafe Controller.Extension VKfydcfIuthciwJAObUcwgFbJao
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_VKfydcfIuthciwJAObUcwgFbJao);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj.NativeFieldInfoPtr_VKfydcfIuthciwJAObUcwgFbJao), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C47 RID: 3143
			private static readonly IntPtr NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE;

			// Token: 0x04000C48 RID: 3144
			private static readonly IntPtr NativeFieldInfoPtr_JFhGUotVGyvgqRcgpmFnXSQrssJ;

			// Token: 0x04000C49 RID: 3145
			private static readonly IntPtr NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg;

			// Token: 0x04000C4A RID: 3146
			private static readonly IntPtr NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe;

			// Token: 0x04000C4B RID: 3147
			private static readonly IntPtr NativeFieldInfoPtr_SWSkqVEjiHnabOxljNQaBGNzOFT;

			// Token: 0x04000C4C RID: 3148
			private static readonly IntPtr NativeFieldInfoPtr_IjJmmAdpNcsRLKbzSgBUhlFquWO;

			// Token: 0x04000C4D RID: 3149
			private static readonly IntPtr NativeFieldInfoPtr_xcraKzUBKKbqrrMoJhsaaxGOFXRT;

			// Token: 0x04000C4E RID: 3150
			private static readonly IntPtr NativeFieldInfoPtr_XweWIFEyvCMnXulreJEhSfAAWOo;

			// Token: 0x04000C4F RID: 3151
			private static readonly IntPtr NativeFieldInfoPtr_UOiadLOPlNhsLbNzLGQXTPSGUrP;

			// Token: 0x04000C50 RID: 3152
			private static readonly IntPtr NativeFieldInfoPtr_ePNBvlGnonVgXbSNyjfUvrOPppq;

			// Token: 0x04000C51 RID: 3153
			private static readonly IntPtr NativeFieldInfoPtr_QNriiYyDefcYxiGNiogfBFplnmK;

			// Token: 0x04000C52 RID: 3154
			private static readonly IntPtr NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ;

			// Token: 0x04000C53 RID: 3155
			private static readonly IntPtr NativeFieldInfoPtr_lzufHdDGBKQEIiVjiKYtKEEDzaGM;

			// Token: 0x04000C54 RID: 3156
			private static readonly IntPtr NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd;

			// Token: 0x04000C55 RID: 3157
			private static readonly IntPtr NativeFieldInfoPtr_zRSLRumgAHYvaVfMhktxhOcdJEz;

			// Token: 0x04000C56 RID: 3158
			private static readonly IntPtr NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl;

			// Token: 0x04000C57 RID: 3159
			private static readonly IntPtr NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj;

			// Token: 0x04000C58 RID: 3160
			private static readonly IntPtr NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj;

			// Token: 0x04000C59 RID: 3161
			private static readonly IntPtr NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM;

			// Token: 0x04000C5A RID: 3162
			private static readonly IntPtr NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli;

			// Token: 0x04000C5B RID: 3163
			private static readonly IntPtr NativeFieldInfoPtr_DvJhuGjaHKRdHunWyrEKRNDBrab;

			// Token: 0x04000C5C RID: 3164
			private static readonly IntPtr NativeFieldInfoPtr_AvCqApdLGDXHFPBkTTaAQSVHPfK;

			// Token: 0x04000C5D RID: 3165
			private static readonly IntPtr NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv;

			// Token: 0x04000C5E RID: 3166
			private static readonly IntPtr NativeFieldInfoPtr_iXcFIKunTVeCZUaJOQlTQdlvObM;

			// Token: 0x04000C5F RID: 3167
			private static readonly IntPtr NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj;

			// Token: 0x04000C60 RID: 3168
			private static readonly IntPtr NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf;

			// Token: 0x04000C61 RID: 3169
			private static readonly IntPtr NativeFieldInfoPtr_rdbowCCLSvWWdSgEzCsNVlkuLFV;

			// Token: 0x04000C62 RID: 3170
			private static readonly IntPtr NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc;

			// Token: 0x04000C63 RID: 3171
			private static readonly IntPtr NativeFieldInfoPtr_QnMBRLjBpUctTxKAlRhZitHXchtE;

			// Token: 0x04000C64 RID: 3172
			private static readonly IntPtr NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt;

			// Token: 0x04000C65 RID: 3173
			private static readonly IntPtr NativeFieldInfoPtr_lNjuiEzDctUBliWAKQtnwVRUssh;

			// Token: 0x04000C66 RID: 3174
			private static readonly IntPtr NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej;

			// Token: 0x04000C67 RID: 3175
			private static readonly IntPtr NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ;

			// Token: 0x04000C68 RID: 3176
			private static readonly IntPtr NativeFieldInfoPtr_VKfydcfIuthciwJAObUcwgFbJao;

			// Token: 0x04000C69 RID: 3177
			private static readonly IntPtr NativeMethodInfoPtr_get_hasDriver_Public_get_Boolean_0;

			// Token: 0x04000C6A RID: 3178
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000C6B RID: 3179
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0;

			// Token: 0x04000C6C RID: 3180
			private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000C6D RID: 3181
			private static readonly IntPtr NativeMethodInfoPtr_set_inputManagerId_Public_set_Void_Int32_0;

			// Token: 0x04000C6E RID: 3182
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04000C6F RID: 3183
			private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0;

			// Token: 0x04000C70 RID: 3184
			private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000C71 RID: 3185
			private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0;

			// Token: 0x04000C72 RID: 3186
			private static readonly IntPtr NativeMethodInfoPtr_set_extension_Public_set_Void_Extension_0;

			// Token: 0x04000C73 RID: 3187
			private static readonly IntPtr NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x04000C74 RID: 3188
			private static readonly IntPtr NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x04000C75 RID: 3189
			private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0;

			// Token: 0x04000C76 RID: 3190
			private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000C77 RID: 3191
			private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

			// Token: 0x04000C78 RID: 3192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NCAKlOuHHtmlQFmgNIReWrsmixC_DeviceType_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_0;

			// Token: 0x04000C79 RID: 3193
			private static readonly IntPtr NativeMethodInfoPtr_jgeCBEMtzKMTxBWHKEzsNZSbcZA_Public_Void_0;

			// Token: 0x04000C7A RID: 3194
			private static readonly IntPtr NativeMethodInfoPtr_nmYEDBcicBHXDwuAcMZQWyZRpHE_Public_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

			// Token: 0x04000C7B RID: 3195
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000C7C RID: 3196
			private static readonly IntPtr NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0;

			// Token: 0x04000C7D RID: 3197
			private static readonly IntPtr NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

			// Token: 0x04000C7E RID: 3198
			private static readonly IntPtr NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Private_BridgedControllerHWInfo_0;

			// Token: 0x04000C7F RID: 3199
			private static readonly IntPtr NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0;

			// Token: 0x04000C80 RID: 3200
			private static readonly IntPtr NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0;

			// Token: 0x04000C81 RID: 3201
			private static readonly IntPtr NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C82 RID: 3202
			private static readonly IntPtr NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C83 RID: 3203
			private static readonly IntPtr NativeMethodInfoPtr_MnKfNqjxLlxeBKgTKVckDkWYfiXR_Private_Void_Axis_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C84 RID: 3204
			private static readonly IntPtr NativeMethodInfoPtr_MCTjNTarCEETqZZnpAEOspBfjIV_Private_Void_Button_Base_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C85 RID: 3205
			private static readonly IntPtr NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C86 RID: 3206
			private static readonly IntPtr NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_RawInputAxis_Int32_0;

			// Token: 0x04000C87 RID: 3207
			private static readonly IntPtr NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Single_Button_Base_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C88 RID: 3208
			private static readonly IntPtr NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Private_Single_Int32_0;

			// Token: 0x04000C89 RID: 3209
			private static readonly IntPtr NativeMethodInfoPtr_vHPFVpeYMSXPpVGDKlRsxYWNAxN_Private_Single_Int32_Int32_HatType_0;

			// Token: 0x04000C8A RID: 3210
			private static readonly IntPtr NativeMethodInfoPtr_mARCrvdmUYeEwAQXLmQRoaZYrBx_Private_Single_Int32_AxisDirection_0;

			// Token: 0x04000C8B RID: 3211
			private static readonly IntPtr NativeMethodInfoPtr_kJNGlsEDqDckESXjfROGpyQJlMx_Private_Boolean_CustomCalculationSourceData_Il2CppStructArray_1_Boolean_byref_Boolean_0;

			// Token: 0x04000C8C RID: 3212
			private static readonly IntPtr NativeMethodInfoPtr_ROElGxvxwjOsQqbtUxHVBlYTlwS_Private_Boolean_CustomCalculationSourceData_byref_Single_0;

			// Token: 0x04000C8D RID: 3213
			private static readonly IntPtr NativeMethodInfoPtr_vOahjFKxQVMSIdknBzwAOvWxJQY_Private_ControlDeviceType_DeviceType_0;

			// Token: 0x04000C8E RID: 3214
			private static readonly IntPtr NativeMethodInfoPtr_AjCJZoSlAAwrIZRUmKMFTaJWJDP_Private_Void_Axis_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C8F RID: 3215
			private static readonly IntPtr NativeMethodInfoPtr_ldPMzzUrEKlHVjzvneFXACaMmOf_Private_Void_Button_Int32_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C90 RID: 3216
			private static readonly IntPtr NativeMethodInfoPtr_xUhQAGXwmisrJaEsIAOCRbjWcYog_Private_Single_Axis_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C91 RID: 3217
			private static readonly IntPtr NativeMethodInfoPtr_xUhQAGXwmisrJaEsIAOCRbjWcYog_Private_Single_Int32_0;

			// Token: 0x04000C92 RID: 3218
			private static readonly IntPtr NativeMethodInfoPtr_XYKfBeMnMyxSHvdJIFlReutgEIiI_Private_Single_Button_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Int32_0;

			// Token: 0x04000C93 RID: 3219
			private static readonly IntPtr NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0;

			// Token: 0x04000C94 RID: 3220
			private static readonly IntPtr NativeMethodInfoPtr_GxMKQzmqXFgumLhiAHMyHUVdKniG_Private_String_0;

			// Token: 0x04000C95 RID: 3221
			private static readonly IntPtr NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0;

			// Token: 0x04000C96 RID: 3222
			private static readonly IntPtr NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0;

			// Token: 0x04000C97 RID: 3223
			private static readonly IntPtr NativeMethodInfoPtr_GSGWoDIqRLoSTVEGPZGnWuXPYcg_Private_Il2CppReferenceArray_1_UnknownControllerHat_0;

			// Token: 0x04000C98 RID: 3224
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Public_Void_0;

			// Token: 0x04000C99 RID: 3225
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04000C9A RID: 3226
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0;

			// Token: 0x04000C9B RID: 3227
			private static readonly IntPtr NativeMethodInfoPtr_BgUdzPVUMGNmXeVpiTHfyfpLFkQ_Public_Static_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

			// Token: 0x04000C9C RID: 3228
			private static readonly IntPtr NativeMethodInfoPtr_BDcNszefYmjxbhANdakPWxuGSon_Public_Static_Int32_SbLfEObBttmOEqgDPyGjWaDXoZj_SbLfEObBttmOEqgDPyGjWaDXoZj_0;
		}

		// Token: 0x020000BF RID: 191
		public class mbTDmImHTXqIJFLzfXPXBjNdidk : Object
		{
			// Token: 0x06000DA3 RID: 3491 RVA: 0x0003A15C File Offset: 0x0003835C
			// Note: this type is marked as 'beforefieldinit'.
			static mbTDmImHTXqIJFLzfXPXBjNdidk()
			{
				Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu>.NativeClassPtr, "mbTDmImHTXqIJFLzfXPXBjNdidk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr);
				SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, "gusHCWBeNlrbYsMEBKlcvqKfDoT");
				SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, 100663600);
				SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_uOwTUAqJuTxgZTJKsRIMlqwZDeZ_Public_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, 100663601);
				SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_pyuYZbVtvkRPLkXGbiJUCEvETcy_Public_IEnumerable_1_GapdazuVkyUebAoYXTyIRrvbMjW_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, 100663602);
				SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_YWmSIrQCAqezdPoyxBTnhoyftbI_Private_Void_Int32_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, 100663603);
				SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, 100663604);
			}

			// Token: 0x06000DA4 RID: 3492 RVA: 0x0003A200 File Offset: 0x00038400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350355, XrefRangeEnd = 350361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe mbTDmImHTXqIJFLzfXPXBjNdidk()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DA5 RID: 3493 RVA: 0x0003A23C File Offset: 0x0003843C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 350373, RefRangeEnd = 350377, XrefRangeStart = 350361, XrefRangeEnd = 350373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void uOwTUAqJuTxgZTJKsRIMlqwZDeZ(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_uOwTUAqJuTxgZTJKsRIMlqwZDeZ_Public_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DA6 RID: 3494 RVA: 0x0003A280 File Offset: 0x00038480
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350382, RefRangeEnd = 350383, XrefRangeStart = 350377, XrefRangeEnd = 350382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW> pyuYZbVtvkRPLkXGbiJUCEvETcy(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1, SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.waBscGOIlYYOzSEgBftmKSeqAKG A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_pyuYZbVtvkRPLkXGbiJUCEvETcy_Public_IEnumerable_1_GapdazuVkyUebAoYXTyIRrvbMjW_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>>(intPtr3) : null;
			}

			// Token: 0x06000DA7 RID: 3495 RVA: 0x0003A2E0 File Offset: 0x000384E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 350394, RefRangeEnd = 350395, XrefRangeStart = 350383, XrefRangeEnd = 350394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_YWmSIrQCAqezdPoyxBTnhoyftbI_Private_Void_Int32_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DA8 RID: 3496 RVA: 0x0003A33C File Offset: 0x0003853C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350395, XrefRangeEnd = 350443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000DA9 RID: 3497 RVA: 0x00007E2F File Offset: 0x0000602F
			public mbTDmImHTXqIJFLzfXPXBjNdidk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004AA RID: 1194
			// (get) Token: 0x06000DAA RID: 3498 RVA: 0x0003A380 File Offset: 0x00038580
			// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00007E38 File Offset: 0x00006038
			public unsafe List<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW> gusHCWBeNlrbYsMEBKlcvqKfDoT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C9D RID: 3229
			private static readonly IntPtr NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT;

			// Token: 0x04000C9E RID: 3230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C9F RID: 3231
			private static readonly IntPtr NativeMethodInfoPtr_uOwTUAqJuTxgZTJKsRIMlqwZDeZ_Public_Void_SbLfEObBttmOEqgDPyGjWaDXoZj_0;

			// Token: 0x04000CA0 RID: 3232
			private static readonly IntPtr NativeMethodInfoPtr_pyuYZbVtvkRPLkXGbiJUCEvETcy_Public_IEnumerable_1_GapdazuVkyUebAoYXTyIRrvbMjW_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0;

			// Token: 0x04000CA1 RID: 3233
			private static readonly IntPtr NativeMethodInfoPtr_YWmSIrQCAqezdPoyxBTnhoyftbI_Private_Void_Int32_Guid_Int32_0;

			// Token: 0x04000CA2 RID: 3234
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000125 RID: 293
			[OriginalName("Rewired_Windows.dll", "", "waBscGOIlYYOzSEgBftmKSeqAKG")]
			public enum waBscGOIlYYOzSEgBftmKSeqAKG
			{
				// Token: 0x04001B46 RID: 6982
				cqFvgbREvaOHuBGfnPfDIMeHzpO,
				// Token: 0x04001B47 RID: 6983
				IpJNUAwnqcMPyudetEqVpEFXDzAE
			}

			// Token: 0x02000126 RID: 294
			public class GapdazuVkyUebAoYXTyIRrvbMjW : Object
			{
				// Token: 0x060011E5 RID: 4581 RVA: 0x0004D598 File Offset: 0x0004B798
				// Note: this type is marked as 'beforefieldinit'.
				static GapdazuVkyUebAoYXTyIRrvbMjW()
				{
					Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, "GapdazuVkyUebAoYXTyIRrvbMjW");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "XUKXgpkeURQbNWYxnzWmsGORdLL");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "TDuxsXkDPajTuBGfNAPMKnjqIdbq");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "BLfxWbmyTsFYizOjLnroMuVRaUd");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "NEsIZMLRTnCdleEUzBtVXIIsWHd");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "uJThHFvMnnGWlhGgONRMIioDKZOj");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "fMsDvvtAhFIJLgiqYmvGYlgVARM");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "OZweyeiUbnDOuxpLuoupDMKOgVli");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "ilvTWYfRywhZpsIyUtQNREFcjLsj");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "xnwhPiSLJZAWeXtpbVDLHoIbBMl");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_HlHsXhgfRKEMFFzncMPMohdcDNwF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, "HlHsXhgfRKEMFFzncMPMohdcDNwF");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Boolean_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, 100663605);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, 100663606);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr, 100663607);
				}

				// Token: 0x060011E6 RID: 4582 RVA: 0x0004D6C8 File Offset: 0x0004B8C8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 350067, RefRangeEnd = 350069, XrefRangeStart = 350062, XrefRangeEnd = 350067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool PpfFXDqHyUXaiMeJUppAtMDNqvi(SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj A_1, SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.waBscGOIlYYOzSEgBftmKSeqAKG A_2)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Boolean_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060011E7 RID: 4583 RVA: 0x0004D724 File Offset: 0x0004B924
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350069, XrefRangeEnd = 350337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override string ToString()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060011E8 RID: 4584 RVA: 0x0004D768 File Offset: 0x0004B968
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GapdazuVkyUebAoYXTyIRrvbMjW()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060011E9 RID: 4585 RVA: 0x0000A34B File Offset: 0x0000854B
				public GapdazuVkyUebAoYXTyIRrvbMjW(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000607 RID: 1543
				// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004D7A4 File Offset: 0x0004B9A4
				// (set) Token: 0x060011EB RID: 4587 RVA: 0x0000A354 File Offset: 0x00008554
				public unsafe int XUKXgpkeURQbNWYxnzWmsGORdLL
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL)) = value;
					}
				}

				// Token: 0x17000608 RID: 1544
				// (get) Token: 0x060011EC RID: 4588 RVA: 0x0004D7CC File Offset: 0x0004B9CC
				// (set) Token: 0x060011ED RID: 4589 RVA: 0x0000A36F File Offset: 0x0000856F
				public unsafe Guid TDuxsXkDPajTuBGfNAPMKnjqIdbq
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq)) = value;
					}
				}

				// Token: 0x17000609 RID: 1545
				// (get) Token: 0x060011EE RID: 4590 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
				// (set) Token: 0x060011EF RID: 4591 RVA: 0x0000A38A File Offset: 0x0000858A
				public unsafe Guid BLfxWbmyTsFYizOjLnroMuVRaUd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd)) = value;
					}
				}

				// Token: 0x1700060A RID: 1546
				// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0004D81C File Offset: 0x0004BA1C
				// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0000A3A5 File Offset: 0x000085A5
				public unsafe int NEsIZMLRTnCdleEUzBtVXIIsWHd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd)) = value;
					}
				}

				// Token: 0x1700060B RID: 1547
				// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0004D844 File Offset: 0x0004BA44
				// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000A3C0 File Offset: 0x000085C0
				public unsafe int uJThHFvMnnGWlhGgONRMIioDKZOj
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj)) = value;
					}
				}

				// Token: 0x1700060C RID: 1548
				// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0004D86C File Offset: 0x0004BA6C
				// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000A3DB File Offset: 0x000085DB
				public unsafe int fMsDvvtAhFIJLgiqYmvGYlgVARM
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM)) = value;
					}
				}

				// Token: 0x1700060D RID: 1549
				// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0004D894 File Offset: 0x0004BA94
				// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0000A3F6 File Offset: 0x000085F6
				public unsafe int OZweyeiUbnDOuxpLuoupDMKOgVli
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli)) = value;
					}
				}

				// Token: 0x1700060E RID: 1550
				// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0004D8BC File Offset: 0x0004BABC
				// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0000A411 File Offset: 0x00008611
				public unsafe int ilvTWYfRywhZpsIyUtQNREFcjLsj
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj)) = value;
					}
				}

				// Token: 0x1700060F RID: 1551
				// (get) Token: 0x060011FA RID: 4602 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
				// (set) Token: 0x060011FB RID: 4603 RVA: 0x0000A42C File Offset: 0x0000862C
				public unsafe int xnwhPiSLJZAWeXtpbVDLHoIbBMl
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl)) = value;
					}
				}

				// Token: 0x17000610 RID: 1552
				// (get) Token: 0x060011FC RID: 4604 RVA: 0x0004D90C File Offset: 0x0004BB0C
				// (set) Token: 0x060011FD RID: 4605 RVA: 0x0000A447 File Offset: 0x00008647
				public unsafe bool HlHsXhgfRKEMFFzncMPMohdcDNwF
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_HlHsXhgfRKEMFFzncMPMohdcDNwF);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW.NativeFieldInfoPtr_HlHsXhgfRKEMFFzncMPMohdcDNwF)) = value;
					}
				}

				// Token: 0x04001B48 RID: 6984
				private static readonly IntPtr NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL;

				// Token: 0x04001B49 RID: 6985
				private static readonly IntPtr NativeFieldInfoPtr_TDuxsXkDPajTuBGfNAPMKnjqIdbq;

				// Token: 0x04001B4A RID: 6986
				private static readonly IntPtr NativeFieldInfoPtr_BLfxWbmyTsFYizOjLnroMuVRaUd;

				// Token: 0x04001B4B RID: 6987
				private static readonly IntPtr NativeFieldInfoPtr_NEsIZMLRTnCdleEUzBtVXIIsWHd;

				// Token: 0x04001B4C RID: 6988
				private static readonly IntPtr NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj;

				// Token: 0x04001B4D RID: 6989
				private static readonly IntPtr NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM;

				// Token: 0x04001B4E RID: 6990
				private static readonly IntPtr NativeFieldInfoPtr_OZweyeiUbnDOuxpLuoupDMKOgVli;

				// Token: 0x04001B4F RID: 6991
				private static readonly IntPtr NativeFieldInfoPtr_ilvTWYfRywhZpsIyUtQNREFcjLsj;

				// Token: 0x04001B50 RID: 6992
				private static readonly IntPtr NativeFieldInfoPtr_xnwhPiSLJZAWeXtpbVDLHoIbBMl;

				// Token: 0x04001B51 RID: 6993
				private static readonly IntPtr NativeFieldInfoPtr_HlHsXhgfRKEMFFzncMPMohdcDNwF;

				// Token: 0x04001B52 RID: 6994
				private static readonly IntPtr NativeMethodInfoPtr_PpfFXDqHyUXaiMeJUppAtMDNqvi_Public_Boolean_SbLfEObBttmOEqgDPyGjWaDXoZj_waBscGOIlYYOzSEgBftmKSeqAKG_0;

				// Token: 0x04001B53 RID: 6995
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

				// Token: 0x04001B54 RID: 6996
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x02000127 RID: 295
			public sealed class hzsXotmObgvfMnCTEbXFJANchbSd : Object
			{
				// Token: 0x060011FE RID: 4606 RVA: 0x0004D934 File Offset: 0x0004BB34
				// Note: this type is marked as 'beforefieldinit'.
				static hzsXotmObgvfMnCTEbXFJANchbSd()
				{
					Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>.NativeClassPtr, "hzsXotmObgvfMnCTEbXFJANchbSd");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "hagrkYEKGHgWfVeuqDGSwljfqRk");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "poyFLvQJqpBqBCSyTDQhTmJIKbnJ");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "YJhQbhdgUViswToHoKBEorLmGpG");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "zYvOggOYJWkWYHTfuwFOvbNvpQl");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "NLMYqfSubrTVuBQIEZFGLpIppgD");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "dtArNceOjilclRmrtfdeVvzjqgK");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "qhNjyGyPtnCbyyBHGVfqpJDCHDt");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "WEWEENKIlEHwBcarOaBkUvDqgyzX");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_iOdxYqIIArtqMhsxeiozkjpPdnG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "iOdxYqIIArtqMhsxeiozkjpPdnG");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_pjoQERlpVcaZMhJtYLOHCIgjsihx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, "pjoQERlpVcaZMhJtYLOHCIgjsihx");
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Windows_RawInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_GapdazuVkyUebAoYXTyIRrvbMjW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663608);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663609);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663610);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Windows_RawInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_GapdazuVkyUebAoYXTyIRrvbMjW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663611);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663612);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663613);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663614);
					SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr, 100663615);
				}

				// Token: 0x060011FF RID: 4607 RVA: 0x0004DAC8 File Offset: 0x0004BCC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350337, XrefRangeEnd = 350345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW> System_Collections_Generic_IEnumerable_Rewired_Windows_RawInputManager_JoystickRecords_Record__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Windows_RawInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_GapdazuVkyUebAoYXTyIRrvbMjW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>>(intPtr3) : null;
				}

				// Token: 0x06001200 RID: 4608 RVA: 0x0004DB08 File Offset: 0x0004BD08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x06001201 RID: 4609 RVA: 0x0004DB48 File Offset: 0x0004BD48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350345, XrefRangeEnd = 350350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700061B RID: 1563
				// (get) Token: 0x06001202 RID: 4610 RVA: 0x0004DB84 File Offset: 0x0004BD84
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW TISZhmWqmprrZavKIFuqAeagRWY
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Windows_RawInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_GapdazuVkyUebAoYXTyIRrvbMjW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>(intPtr3) : null;
					}
				}

				// Token: 0x06001203 RID: 4611 RVA: 0x0004DBC4 File Offset: 0x0004BDC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350350, XrefRangeEnd = 350355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001204 RID: 4612 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700061C RID: 1564
				// (get) Token: 0x06001205 RID: 4613 RVA: 0x0004DC2C File Offset: 0x0004BE2C
				public unsafe Object exQSStbIkkFirilpySpDqHtFqeV
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001206 RID: 4614 RVA: 0x0004DC6C File Offset: 0x0004BE6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe hzsXotmObgvfMnCTEbXFJANchbSd(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001207 RID: 4615 RVA: 0x0000A462 File Offset: 0x00008662
				public hzsXotmObgvfMnCTEbXFJANchbSd(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000611 RID: 1553
				// (get) Token: 0x06001208 RID: 4616 RVA: 0x0004DCB4 File Offset: 0x0004BEB4
				// (set) Token: 0x06001209 RID: 4617 RVA: 0x0000A46B File Offset: 0x0000866B
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW hagrkYEKGHgWfVeuqDGSwljfqRk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.GapdazuVkyUebAoYXTyIRrvbMjW>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000612 RID: 1554
				// (get) Token: 0x0600120A RID: 4618 RVA: 0x0004DCE4 File Offset: 0x0004BEE4
				// (set) Token: 0x0600120B RID: 4619 RVA: 0x0000A48A File Offset: 0x0000868A
				public unsafe int poyFLvQJqpBqBCSyTDQhTmJIKbnJ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ)) = value;
					}
				}

				// Token: 0x17000613 RID: 1555
				// (get) Token: 0x0600120C RID: 4620 RVA: 0x0004DD0C File Offset: 0x0004BF0C
				// (set) Token: 0x0600120D RID: 4621 RVA: 0x0000A4A5 File Offset: 0x000086A5
				public unsafe int YJhQbhdgUViswToHoKBEorLmGpG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG)) = value;
					}
				}

				// Token: 0x17000614 RID: 1556
				// (get) Token: 0x0600120E RID: 4622 RVA: 0x0004DD34 File Offset: 0x0004BF34
				// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000A4C0 File Offset: 0x000086C0
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk zYvOggOYJWkWYHTfuwFOvbNvpQl
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000615 RID: 1557
				// (get) Token: 0x06001210 RID: 4624 RVA: 0x0004DD64 File Offset: 0x0004BF64
				// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000A4DF File Offset: 0x000086DF
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj NLMYqfSubrTVuBQIEZFGLpIppgD
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000616 RID: 1558
				// (get) Token: 0x06001212 RID: 4626 RVA: 0x0004DD94 File Offset: 0x0004BF94
				// (set) Token: 0x06001213 RID: 4627 RVA: 0x0000A4FE File Offset: 0x000086FE
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj dtArNceOjilclRmrtfdeVvzjqgK
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkItpoOYMjOFcKMNuWgEtTzrshu.SbLfEObBttmOEqgDPyGjWaDXoZj>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000617 RID: 1559
				// (get) Token: 0x06001214 RID: 4628 RVA: 0x0004DDC4 File Offset: 0x0004BFC4
				// (set) Token: 0x06001215 RID: 4629 RVA: 0x0000A51D File Offset: 0x0000871D
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.waBscGOIlYYOzSEgBftmKSeqAKG qhNjyGyPtnCbyyBHGVfqpJDCHDt
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt)) = value;
					}
				}

				// Token: 0x17000618 RID: 1560
				// (get) Token: 0x06001216 RID: 4630 RVA: 0x0004DDEC File Offset: 0x0004BFEC
				// (set) Token: 0x06001217 RID: 4631 RVA: 0x0000A538 File Offset: 0x00008738
				public unsafe SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.waBscGOIlYYOzSEgBftmKSeqAKG WEWEENKIlEHwBcarOaBkUvDqgyzX
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX)) = value;
					}
				}

				// Token: 0x17000619 RID: 1561
				// (get) Token: 0x06001218 RID: 4632 RVA: 0x0004DE14 File Offset: 0x0004C014
				// (set) Token: 0x06001219 RID: 4633 RVA: 0x0000A553 File Offset: 0x00008753
				public unsafe int iOdxYqIIArtqMhsxeiozkjpPdnG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_iOdxYqIIArtqMhsxeiozkjpPdnG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_iOdxYqIIArtqMhsxeiozkjpPdnG)) = value;
					}
				}

				// Token: 0x1700061A RID: 1562
				// (get) Token: 0x0600121A RID: 4634 RVA: 0x0004DE3C File Offset: 0x0004C03C
				// (set) Token: 0x0600121B RID: 4635 RVA: 0x0000A56E File Offset: 0x0000876E
				public unsafe int pjoQERlpVcaZMhJtYLOHCIgjsihx
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_pjoQERlpVcaZMhJtYLOHCIgjsihx);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkItpoOYMjOFcKMNuWgEtTzrshu.mbTDmImHTXqIJFLzfXPXBjNdidk.hzsXotmObgvfMnCTEbXFJANchbSd.NativeFieldInfoPtr_pjoQERlpVcaZMhJtYLOHCIgjsihx)) = value;
					}
				}

				// Token: 0x04001B55 RID: 6997
				private static readonly IntPtr NativeFieldInfoPtr_hagrkYEKGHgWfVeuqDGSwljfqRk;

				// Token: 0x04001B56 RID: 6998
				private static readonly IntPtr NativeFieldInfoPtr_poyFLvQJqpBqBCSyTDQhTmJIKbnJ;

				// Token: 0x04001B57 RID: 6999
				private static readonly IntPtr NativeFieldInfoPtr_YJhQbhdgUViswToHoKBEorLmGpG;

				// Token: 0x04001B58 RID: 7000
				private static readonly IntPtr NativeFieldInfoPtr_zYvOggOYJWkWYHTfuwFOvbNvpQl;

				// Token: 0x04001B59 RID: 7001
				private static readonly IntPtr NativeFieldInfoPtr_NLMYqfSubrTVuBQIEZFGLpIppgD;

				// Token: 0x04001B5A RID: 7002
				private static readonly IntPtr NativeFieldInfoPtr_dtArNceOjilclRmrtfdeVvzjqgK;

				// Token: 0x04001B5B RID: 7003
				private static readonly IntPtr NativeFieldInfoPtr_qhNjyGyPtnCbyyBHGVfqpJDCHDt;

				// Token: 0x04001B5C RID: 7004
				private static readonly IntPtr NativeFieldInfoPtr_WEWEENKIlEHwBcarOaBkUvDqgyzX;

				// Token: 0x04001B5D RID: 7005
				private static readonly IntPtr NativeFieldInfoPtr_iOdxYqIIArtqMhsxeiozkjpPdnG;

				// Token: 0x04001B5E RID: 7006
				private static readonly IntPtr NativeFieldInfoPtr_pjoQERlpVcaZMhJtYLOHCIgjsihx;

				// Token: 0x04001B5F RID: 7007
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Windows_RawInputManager_JoystickRecords_Record__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_GapdazuVkyUebAoYXTyIRrvbMjW_0;

				// Token: 0x04001B60 RID: 7008
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

				// Token: 0x04001B61 RID: 7009
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001B62 RID: 7010
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Windows_RawInputManager_JoystickRecords_Record__get_Current_Private_Virtual_Final_New_get_GapdazuVkyUebAoYXTyIRrvbMjW_0;

				// Token: 0x04001B63 RID: 7011
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001B64 RID: 7012
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001B65 RID: 7013
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001B66 RID: 7014
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
			}
		}
	}
}
