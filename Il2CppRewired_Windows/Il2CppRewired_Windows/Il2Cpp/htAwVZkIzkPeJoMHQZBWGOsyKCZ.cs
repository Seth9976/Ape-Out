using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using Il2CppRewired.Config;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Libraries.SharpDX.XInput;
using Il2CppRewired.Platforms;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x02000010 RID: 16
	public class htAwVZkIzkPeJoMHQZBWGOsyKCZ : PlatformInputManager
	{
		// Token: 0x06000160 RID: 352 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		// Note: this type is marked as 'beforefieldinit'.
		static htAwVZkIzkPeJoMHQZBWGOsyKCZ()
		{
			Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "htAwVZkIzkPeJoMHQZBWGOsyKCZ");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_mzXEdxpDPIJqEbtYNycAAQwLAGo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "mzXEdxpDPIJqEbtYNycAAQwLAGo");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_JjxgLDAkudJhMhZmCUTzdOgvKIx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "JjxgLDAkudJhMhZmCUTzdOgvKIx");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_rELKOoRPbLflfQDTJFXYawYhGHih = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "rELKOoRPbLflfQDTJFXYawYhGHih");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_njfYFkhhPgTyoUjexTYhrDkdBzB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "njfYFkhhPgTyoUjexTYhrDkdBzB");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "rlvhAvIIAgpzhGBspLOycKQmvkk");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_xjPqAiYNrsWutprUAedaQiabxEJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "xjPqAiYNrsWutprUAedaQiabxEJ");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_IIzmWqVWERymmPEEkqqdZHuQeNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "IIzmWqVWERymmPEEkqqdZHuQeNS");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "vWyRryVhxsAuDrpdFmQHpBBaKbF");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_BOeBcuIEHZqsDMcxTALKcLKoIKkC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "BOeBcuIEHZqsDMcxTALKcLKoIKkC");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_TeREwHBWkFUbcjvwYsjdikGNLrdC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "TeREwHBWkFUbcjvwYsjdikGNLrdC");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_sqESqByGwyJDGncpeogboxWouiM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "sqESqByGwyJDGncpeogboxWouiM");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_WhkJEjoiDRCpAjXWdQIRPvnOSRpg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "WhkJEjoiDRCpAjXWdQIRPvnOSRpg");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "XgoiTRQUwWofwNpljdXDpYGrJws");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_YnwDuVcEbWNfHXdtKLjlJwPWvri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "YnwDuVcEbWNfHXdtKLjlJwPWvri");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "swOzpxtgHdYlzNpDnxeXdFTTYrt");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "bAJbZUeRbxcwwdOPEAlIzFuHOjFq");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_hILjdFfCPWnApIvQKrnwIYCyTqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "hILjdFfCPWnApIvQKrnwIYCyTqr");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_PkPRVUDmXYYGsjhBpOZPavswkEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "PkPRVUDmXYYGsjhBpOZPavswkEL");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_VfVEvnILhFEPrjXSDzrzChROwFj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "VfVEvnILhFEPrjXSDzrzChROwFj");
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr__ctor_Public_Void_Boolean_UpdateLoopSetting_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663695);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663696);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663697);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663698);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663699);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663700);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663701);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663702);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663703);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663704);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663705);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663706);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663707);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663708);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663709);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_XeWbFqExputuBEhDDbsHhgPOYwE_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663710);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_bcLjiIVyBOonxWSppTGeyXSbClu_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663711);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_jkneJbzouBAbosCebDOwgqXUJET_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663712);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_exGmXxEDGdDUjPciPZnhaLBfcRa_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663713);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_kxWbhrhqsolWqShUGIHarQbrYPol_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663714);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_CDmuLAoFhwtaSWPsPbdneZlYfjKs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663715);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663716);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_rSvDwWBezzjzdowKbeWYWmcgZiZ_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663717);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_fLaGcgKHsnMojaRyvucaPGiTFHuJ_Private_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663718);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_BudnZGzWeNjXrBizcwChAGGrbDB_Private_Void_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663719);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Boolean_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663720);
			htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_CwStFNsSSqMaHReKbdpPrPMRmcI_Public_Static_Boolean_String_String_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, 100663722);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00010084 File Offset: 0x0000E284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352105, RefRangeEnd = 352106, XrefRangeStart = 352055, XrefRangeEnd = 352105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe htAwVZkIzkPeJoMHQZBWGOsyKCZ(bool isWin10AUHack, UpdateLoopSetting updateLoop, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isWin10AUHack;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoop;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getNewJoystickId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr__ctor_Public_Void_Boolean_UpdateLoopSetting_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00010100 File Offset: 0x0000E300
		public unsafe override int deviceCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352106, XrefRangeEnd = 352109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00010148 File Offset: 0x0000E348
		public unsafe override PlatformInputManager primaryInputManager
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00010194 File Offset: 0x0000E394
		public unsafe override IInputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000101E0 File Offset: 0x0000E3E0
		public unsafe override InputSource inputSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00010228 File Offset: 0x0000E428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352109, XrefRangeEnd = 352162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00010264 File Offset: 0x0000E464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352162, XrefRangeEnd = 352165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType currentUpdateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentUpdateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000102B0 File Offset: 0x0000E4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352165, XrefRangeEnd = 352196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000102EC File Offset: 0x0000E4EC
		[CallerCount(0)]
		public unsafe override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr3) : null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00010338 File Offset: 0x0000E538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352196, XrefRangeEnd = 352200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00010394 File Offset: 0x0000E594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352200, XrefRangeEnd = 352205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000103D0 File Offset: 0x0000E5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352205, XrefRangeEnd = 352210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001040C File Offset: 0x0000E60C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00010464 File Offset: 0x0000E664
		[CallerCount(0)]
		public unsafe override IUnifiedMouseSource GetUnifiedMouseSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr3) : null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000104B0 File Offset: 0x0000E6B0
		[CallerCount(0)]
		public unsafe override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr3) : null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000104FC File Offset: 0x0000E6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352210, XrefRangeEnd = 352215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool XeWbFqExputuBEhDDbsHhgPOYwE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_XeWbFqExputuBEhDDbsHhgPOYwE_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00010538 File Offset: 0x0000E738
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 352219, RefRangeEnd = 352224, XrefRangeStart = 352215, XrefRangeEnd = 352219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bcLjiIVyBOonxWSppTGeyXSbClu(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_bcLjiIVyBOonxWSppTGeyXSbClu_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00010578 File Offset: 0x0000E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352224, XrefRangeEnd = 352227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void jkneJbzouBAbosCebDOwgqXUJET()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_jkneJbzouBAbosCebDOwgqXUJET_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000105AC File Offset: 0x0000E7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352227, XrefRangeEnd = 352231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void exGmXxEDGdDUjPciPZnhaLBfcRa()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_exGmXxEDGdDUjPciPZnhaLBfcRa_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000105E0 File Offset: 0x0000E7E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352245, RefRangeEnd = 352246, XrefRangeStart = 352231, XrefRangeEnd = 352245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void kxWbhrhqsolWqShUGIHarQbrYPol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_kxWbhrhqsolWqShUGIHarQbrYPol_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00010614 File Offset: 0x0000E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352246, XrefRangeEnd = 352250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CDmuLAoFhwtaSWPsPbdneZlYfjKs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_CDmuLAoFhwtaSWPsPbdneZlYfjKs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00010648 File Offset: 0x0000E848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352277, RefRangeEnd = 352278, XrefRangeStart = 352250, XrefRangeEnd = 352277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BYAEaHJnSzdqqawqWqIvjtCnpnz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001067C File Offset: 0x0000E87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352278, XrefRangeEnd = 352285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool rSvDwWBezzjzdowKbeWYWmcgZiZ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_rSvDwWBezzjzdowKbeWYWmcgZiZ_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000106B8 File Offset: 0x0000E8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352285, XrefRangeEnd = 352287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<bool> fLaGcgKHsnMojaRyvucaPGiTFHuJ()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_fLaGcgKHsnMojaRyvucaPGiTFHuJ_Private_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352289, RefRangeEnd = 352290, XrefRangeStart = 352287, XrefRangeEnd = 352289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BudnZGzWeNjXrBizcwChAGGrbDB(Il2CppStructArray<bool> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_BudnZGzWeNjXrBizcwChAGGrbDB_Private_Void_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001073C File Offset: 0x0000E93C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352338, RefRangeEnd = 352340, XrefRangeStart = 352290, XrefRangeEnd = 352338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool uRkEmxgrfgrTYABDMNLqkschCkE(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Boolean_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00010798 File Offset: 0x0000E998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352375, RefRangeEnd = 352377, XrefRangeStart = 352340, XrefRangeEnd = 352375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CwStFNsSSqMaHReKbdpPrPMRmcI(string A_0, string A_1, string A_2, Guid A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeMethodInfoPtr_CwStFNsSSqMaHReKbdpPrPMRmcI_Public_Static_Boolean_String_String_String_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002A36 File Offset: 0x00000C36
		public htAwVZkIzkPeJoMHQZBWGOsyKCZ(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001080C File Offset: 0x0000EA0C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002A3F File Offset: 0x00000C3F
		public unsafe Il2CppReferenceArray<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE> mzXEdxpDPIJqEbtYNycAAQwLAGo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_mzXEdxpDPIJqEbtYNycAAQwLAGo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_mzXEdxpDPIJqEbtYNycAAQwLAGo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001083C File Offset: 0x0000EA3C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002A5E File Offset: 0x00000C5E
		public unsafe bool JjxgLDAkudJhMhZmCUTzdOgvKIx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_JjxgLDAkudJhMhZmCUTzdOgvKIx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_JjxgLDAkudJhMhZmCUTzdOgvKIx)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00010864 File Offset: 0x0000EA64
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002A79 File Offset: 0x00000C79
		public unsafe htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR rELKOoRPbLflfQDTJFXYawYhGHih
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_rELKOoRPbLflfQDTJFXYawYhGHih);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_rELKOoRPbLflfQDTJFXYawYhGHih), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00010894 File Offset: 0x0000EA94
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002A98 File Offset: 0x00000C98
		public unsafe htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb njfYFkhhPgTyoUjexTYhrDkdBzB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_njfYFkhhPgTyoUjexTYhrDkdBzB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_njfYFkhhPgTyoUjexTYhrDkdBzB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000108C4 File Offset: 0x0000EAC4
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public unsafe MixEZdcyOILrKdCCWuLKJJMVEyRk<bool> rlvhAvIIAgpzhGBspLOycKQmvkk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixEZdcyOILrKdCCWuLKJJMVEyRk<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000108F4 File Offset: 0x0000EAF4
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public unsafe Il2CppStructArray<bool> xjPqAiYNrsWutprUAedaQiabxEJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_xjPqAiYNrsWutprUAedaQiabxEJ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_xjPqAiYNrsWutprUAedaQiabxEJ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00010924 File Offset: 0x0000EB24
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002AF5 File Offset: 0x00000CF5
		public unsafe Il2CppStructArray<bool> IIzmWqVWERymmPEEkqqdZHuQeNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_IIzmWqVWERymmPEEkqqdZHuQeNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_IIzmWqVWERymmPEEkqqdZHuQeNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00010954 File Offset: 0x0000EB54
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe bool vWyRryVhxsAuDrpdFmQHpBBaKbF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001097C File Offset: 0x0000EB7C
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002B2F File Offset: 0x00000D2F
		public unsafe bool BOeBcuIEHZqsDMcxTALKcLKoIKkC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_BOeBcuIEHZqsDMcxTALKcLKoIKkC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_BOeBcuIEHZqsDMcxTALKcLKoIKkC)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000109A4 File Offset: 0x0000EBA4
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002B4A File Offset: 0x00000D4A
		public unsafe UpdateLoopSetting TeREwHBWkFUbcjvwYsjdikGNLrdC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_TeREwHBWkFUbcjvwYsjdikGNLrdC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_TeREwHBWkFUbcjvwYsjdikGNLrdC)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000109CC File Offset: 0x0000EBCC
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002B65 File Offset: 0x00000D65
		public unsafe UpdateLoopType sqESqByGwyJDGncpeogboxWouiM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_sqESqByGwyJDGncpeogboxWouiM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_sqESqByGwyJDGncpeogboxWouiM)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000109F4 File Offset: 0x0000EBF4
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002B80 File Offset: 0x00000D80
		public unsafe UpdateLoopType WhkJEjoiDRCpAjXWdQIRPvnOSRpg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_WhkJEjoiDRCpAjXWdQIRPvnOSRpg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_WhkJEjoiDRCpAjXWdQIRPvnOSRpg)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00010A1C File Offset: 0x0000EC1C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002B9B File Offset: 0x00000D9B
		public unsafe Action<int, ControllerDataUpdater> XgoiTRQUwWofwNpljdXDpYGrJws
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00010A4C File Offset: 0x0000EC4C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002BBA File Offset: 0x00000DBA
		public unsafe bool YnwDuVcEbWNfHXdtKLjlJwPWvri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_YnwDuVcEbWNfHXdtKLjlJwPWvri);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_YnwDuVcEbWNfHXdtKLjlJwPWvri)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00010A74 File Offset: 0x0000EC74
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002BD5 File Offset: 0x00000DD5
		public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> swOzpxtgHdYlzNpDnxeXdFTTYrt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public unsafe Func<int> bAJbZUeRbxcwwdOPEAlIzFuHOjFq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002C13 File Offset: 0x00000E13
		public unsafe static Il2CppStructArray<Guid> hILjdFfCPWnApIvQKrnwIYCyTqr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_hILjdFfCPWnApIvQKrnwIYCyTqr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_hILjdFfCPWnApIvQKrnwIYCyTqr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00010AFC File Offset: 0x0000ECFC
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002C25 File Offset: 0x00000E25
		public unsafe static Il2CppStringArray PkPRVUDmXYYGsjhBpOZPavswkEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_PkPRVUDmXYYGsjhBpOZPavswkEL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_PkPRVUDmXYYGsjhBpOZPavswkEL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00010B24 File Offset: 0x0000ED24
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002C37 File Offset: 0x00000E37
		public unsafe static Il2CppStringArray VfVEvnILhFEPrjXSDzrzChROwFj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_VfVEvnILhFEPrjXSDzrzChROwFj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NativeFieldInfoPtr_VfVEvnILhFEPrjXSDzrzChROwFj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_mzXEdxpDPIJqEbtYNycAAQwLAGo;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_JjxgLDAkudJhMhZmCUTzdOgvKIx;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_rELKOoRPbLflfQDTJFXYawYhGHih;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_njfYFkhhPgTyoUjexTYhrDkdBzB;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_rlvhAvIIAgpzhGBspLOycKQmvkk;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_xjPqAiYNrsWutprUAedaQiabxEJ;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_IIzmWqVWERymmPEEkqqdZHuQeNS;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_BOeBcuIEHZqsDMcxTALKcLKoIKkC;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_TeREwHBWkFUbcjvwYsjdikGNLrdC;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_sqESqByGwyJDGncpeogboxWouiM;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_WhkJEjoiDRCpAjXWdQIRPvnOSRpg;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_XgoiTRQUwWofwNpljdXDpYGrJws;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_YnwDuVcEbWNfHXdtKLjlJwPWvri;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_bAJbZUeRbxcwwdOPEAlIzFuHOjFq;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_hILjdFfCPWnApIvQKrnwIYCyTqr;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_PkPRVUDmXYYGsjhBpOZPavswkEL;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_VfVEvnILhFEPrjXSDzrzChROwFj;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_UpdateLoopSetting_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Func_1_Int32_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryInputManager_Public_Virtual_get_PlatformInputManager_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Virtual_get_IInputSource_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceType_Public_Virtual_get_InputSource_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Virtual_Action_2_Int32_ControllerDataUpdater_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerData_Public_Virtual_Void_Int32_ControllerDataUpdater_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityJoystickId_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Virtual_IUnifiedMouseSource_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Virtual_IUnifiedKeyboardSource_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_XeWbFqExputuBEhDDbsHhgPOYwE_Private_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_bcLjiIVyBOonxWSppTGeyXSbClu_Private_Void_Boolean_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_jkneJbzouBAbosCebDOwgqXUJET_Private_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_exGmXxEDGdDUjPciPZnhaLBfcRa_Private_Void_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_kxWbhrhqsolWqShUGIHarQbrYPol_Private_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_CDmuLAoFhwtaSWPsPbdneZlYfjKs_Private_Void_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_BYAEaHJnSzdqqawqWqIvjtCnpnz_Private_Void_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_rSvDwWBezzjzdowKbeWYWmcgZiZ_Private_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_fLaGcgKHsnMojaRyvucaPGiTFHuJ_Private_Il2CppStructArray_1_Boolean_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_BudnZGzWeNjXrBizcwChAGGrbDB_Private_Void_Il2CppStructArray_1_Boolean_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_uRkEmxgrfgrTYABDMNLqkschCkE_Private_Boolean_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_CwStFNsSSqMaHReKbdpPrPMRmcI_Public_Static_Boolean_String_String_String_Guid_0;

		// Token: 0x020000C4 RID: 196
		public class CZKsiOWlVXlzzxfohroaYSgrUvE : Object
		{
			// Token: 0x06000DE0 RID: 3552 RVA: 0x0003AFE0 File Offset: 0x000391E0
			// Note: this type is marked as 'beforefieldinit'.
			static CZKsiOWlVXlzzxfohroaYSgrUvE()
			{
				Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "CZKsiOWlVXlzzxfohroaYSgrUvE");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "vWyRryVhxsAuDrpdFmQHpBBaKbF");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "GNKcpIRbTxVSstxcCBqZKkcbietE");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_EzgOmfXXqsMRZAVPXEFXGopnUEc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "EzgOmfXXqsMRZAVPXEFXGopnUEc");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "WmRdwFvHdKGkxAZMIAvntNHLbaxg");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "WLPWeHrDCPCLfETsRQYzcumJyOe");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "pFkVRJEPoSBxlAjsHKMcxCzbNGQ");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_RpYdDsUDofjGwUtBHUqyQfByLZs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "RpYdDsUDofjGwUtBHUqyQfByLZs");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "dBLQpFYawNfSkProgpWRXybmfWk");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "fluTuRVpPCEGssJAmSiTqFgASHv");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_iZyDqTfpGcbBmbsjPOPlCKAKzrwM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "iZyDqTfpGcbBmbsjPOPlCKAKzrwM");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_peDDbxQOdxaaiaVKXPEZetoCmNmT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "peDDbxQOdxaaiaVKXPEZetoCmNmT");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_LRvEJlriCwlBJKwKgMtnfZNIdMU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "LRvEJlriCwlBJKwKgMtnfZNIdMU");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_CEbkfnpUPjUNtreedpctkMveaeQe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "CEbkfnpUPjUNtreedpctkMveaeQe");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_DOGKAHhJUEZeDpaHNrJhwSCCnIY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "DOGKAHhJUEZeDpaHNrJhwSCCnIY");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "uJThHFvMnnGWlhGgONRMIioDKZOj");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "fMsDvvtAhFIJLgiqYmvGYlgVARM");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "CwSFCVqDCbrQyrvPmmvtgaAynZj");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "sHeRoiRHkuXpbNwEMmzznSiAEVf");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "OHFiyNAurvAHndtKvlMxUsQwcRc");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "xAEQkKEmsgGlqDEpuAlHEcNWauNE");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "swOzpxtgHdYlzNpDnxeXdFTTYrt");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_ucvHopENmIuaxSypqHacPhZuCAep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "ucvHopENmIuaxSypqHacPhZuCAep");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "sECYhWcWoiAmTNERBzazANDrFEp");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "KmDzQOsJBlrBVPwQvpSIJVwVAej");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, "qCyeROasFnJmaEJMACZydOijuQgZ");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_instanceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663723);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_productName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663724);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663725);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663726);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663727);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663728);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663729);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663730);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663731);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663732);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663733);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663734);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663735);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663736);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_llqRAazRwKOjwscvuInnIRNnEfF_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663737);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663738);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_MgKdZataXZfVBukywoIarMqqBLn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663739);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_NNQnHVDDVCGMehXjLuPOrHFgbcUD_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663740);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_GcJaKEnlQnOjISzwjPTvhJKDTcd_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663741);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_JnypvdEAppjAfHMiOhAwpPxUeqf_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663742);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_jQOHflYNIMMgmYicbOrPAzgpGRL_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663743);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_IKrBqwQJiliRvrkHcQvEgDXoSdG_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663744);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663745);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Public_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663746);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663747);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663748);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_EWOJgwjmQRgMbivbpSAmdHfknnxO_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663749);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ezpCyugqJsTbTGhxeNtgGdjebRtX_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663750);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_WcrZDNDCDsaLdhFeYzSHflusYhtE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663751);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_bgZomIfBhzvUBfUObQBLNhcIfXF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663752);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663753);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663754);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663755);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_XInputAxis_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663756);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_Button_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663757);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_XInputButton_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663758);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663759);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_GxMKQzmqXFgumLhiAHMyHUVdKniG_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663760);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663761);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663762);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663763);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663764);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr, 100663765);
			}

			// Token: 0x170004D5 RID: 1237
			// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0003B55C File Offset: 0x0003975C
			public unsafe string xcraKzUBKKbqrrMoJhsaaxGOFXRT
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 351532, RefRangeEnd = 351533, XrefRangeStart = 351521, XrefRangeEnd = 351532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_instanceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0003B594 File Offset: 0x00039794
			public unsafe string XweWIFEyvCMnXulreJEhSfAAWOo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 351539, RefRangeEnd = 351542, XrefRangeStart = 351533, XrefRangeEnd = 351539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_productName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170004D7 RID: 1239
			// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0003B5CC File Offset: 0x000397CC
			public unsafe bool uOQUnJRorSCxGwVxQKBHTClSVYx
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 351544, RefRangeEnd = 351547, XrefRangeStart = 351542, XrefRangeEnd = 351544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0003B608 File Offset: 0x00039808
			// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0003B644 File Offset: 0x00039844
			public unsafe virtual int rewiredId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170004D9 RID: 1241
			// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0003B684 File Offset: 0x00039884
			public unsafe virtual int inputManagerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0003B6C0 File Offset: 0x000398C0
			public unsafe virtual string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351547, XrefRangeEnd = 351557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0003B6F8 File Offset: 0x000398F8
			public unsafe virtual Nullable<long> systemId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351557, XrefRangeEnd = 351558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0003B730 File Offset: 0x00039930
			public unsafe virtual int unityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0003B76C File Offset: 0x0003996C
			public unsafe virtual Controller.Extension extension
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
				}
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0003B7AC File Offset: 0x000399AC
			public unsafe virtual Guid instanceGuid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0003B7E8 File Offset: 0x000399E8
			public unsafe virtual Guid persistentGuid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000DED RID: 3565 RVA: 0x0003B824 File Offset: 0x00039A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351558, XrefRangeEnd = 351563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DEE RID: 3566 RVA: 0x0003B870 File Offset: 0x00039A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351563, XrefRangeEnd = 351565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void StopVibration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x0003B8A4 File Offset: 0x00039AA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351572, RefRangeEnd = 351573, XrefRangeStart = 351565, XrefRangeEnd = 351572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CZKsiOWlVXlzzxfohroaYSgrUvE(int systemId, bool isWin8AppStore, htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Action deviceDisconnectedDelegate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref systemId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWin8AppStore;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceJoystick);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getHardwareJoystickMap_InputManager);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deviceDisconnectedDelegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_llqRAazRwKOjwscvuInnIRNnEfF_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DF0 RID: 3568 RVA: 0x0003B934 File Offset: 0x00039B34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351595, RefRangeEnd = 351596, XrefRangeStart = 351573, XrefRangeEnd = 351595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DF1 RID: 3569 RVA: 0x0003B968 File Offset: 0x00039B68
			[CallerCount(0)]
			public unsafe void MgKdZataXZfVBukywoIarMqqBLn(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_MgKdZataXZfVBukywoIarMqqBLn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DF2 RID: 3570 RVA: 0x0003B9A8 File Offset: 0x00039BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351596, XrefRangeEnd = 351597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool NNQnHVDDVCGMehXjLuPOrHFgbcUD(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NyyZSYJJkzTnYfWzTqOjsIHfWbL A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_NNQnHVDDVCGMehXjLuPOrHFgbcUD_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000DF3 RID: 3571 RVA: 0x0003B9F4 File Offset: 0x00039BF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351597, RefRangeEnd = 351598, XrefRangeStart = 351597, XrefRangeEnd = 351597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool GcJaKEnlQnOjISzwjPTvhJKDTcd(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NyyZSYJJkzTnYfWzTqOjsIHfWbL A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_GcJaKEnlQnOjISzwjPTvhJKDTcd_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000DF4 RID: 3572 RVA: 0x0003BA40 File Offset: 0x00039C40
			[CallerCount(0)]
			public unsafe void JnypvdEAppjAfHMiOhAwpPxUeqf(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_JnypvdEAppjAfHMiOhAwpPxUeqf_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DF5 RID: 3573 RVA: 0x0003BA80 File Offset: 0x00039C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351598, XrefRangeEnd = 351602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void jQOHflYNIMMgmYicbOrPAzgpGRL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_jQOHflYNIMMgmYicbOrPAzgpGRL_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DF6 RID: 3574 RVA: 0x0003BAB4 File Offset: 0x00039CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351602, XrefRangeEnd = 351606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IKrBqwQJiliRvrkHcQvEgDXoSdG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_IKrBqwQJiliRvrkHcQvEgDXoSdG_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DF7 RID: 3575 RVA: 0x0003BAE8 File Offset: 0x00039CE8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351606, RefRangeEnd = 351607, XrefRangeStart = 351606, XrefRangeEnd = 351606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void FillData(ControllerDataUpdater dataUpdater)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DF8 RID: 3576 RVA: 0x0003BB2C File Offset: 0x00039D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351607, XrefRangeEnd = 351611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BridgedControllerHWInfo QkACchszAolJQBMMsHcyPLktlPB()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Public_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedControllerHWInfo>(intPtr3) : null;
			}

			// Token: 0x06000DF9 RID: 3577 RVA: 0x0003BB6C File Offset: 0x00039D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351611, XrefRangeEnd = 351615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual BridgedController ToBridgedController()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BridgedController>(intPtr3) : null;
			}

			// Token: 0x06000DFA RID: 3578 RVA: 0x0003BBAC File Offset: 0x00039DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351615, XrefRangeEnd = 351621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerDisconnectedEventArgs>(intPtr3) : null;
			}

			// Token: 0x06000DFB RID: 3579 RVA: 0x0003BBEC File Offset: 0x00039DEC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 351659, RefRangeEnd = 351662, XrefRangeStart = 351621, XrefRangeEnd = 351659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EWOJgwjmQRgMbivbpSAmdHfknnxO()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_EWOJgwjmQRgMbivbpSAmdHfknnxO_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DFC RID: 3580 RVA: 0x0003BC20 File Offset: 0x00039E20
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 351664, RefRangeEnd = 351666, XrefRangeStart = 351662, XrefRangeEnd = 351664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ezpCyugqJsTbTGhxeNtgGdjebRtX()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ezpCyugqJsTbTGhxeNtgGdjebRtX_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DFD RID: 3581 RVA: 0x0003BC5C File Offset: 0x00039E5C
			[CallerCount(0)]
			public unsafe void WcrZDNDCDsaLdhFeYzSHflusYhtE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_WcrZDNDCDsaLdhFeYzSHflusYhtE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DFE RID: 3582 RVA: 0x0003BC90 File Offset: 0x00039E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351666, XrefRangeEnd = 351669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void bgZomIfBhzvUBfUObQBLNhcIfXF()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_bgZomIfBhzvUBfUObQBLNhcIfXF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DFF RID: 3583 RVA: 0x0003BCC4 File Offset: 0x00039EC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351673, RefRangeEnd = 351674, XrefRangeStart = 351669, XrefRangeEnd = 351673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RUgKGlELCQBBrmrOvYkKJbAGPIE(Il2CppStructArray<bool> A_1, ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E00 RID: 3584 RVA: 0x0003BD14 File Offset: 0x00039F14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351678, RefRangeEnd = 351679, XrefRangeStart = 351674, XrefRangeEnd = 351678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ipocWZvAxAdXermpojWFHIJHbTFS(Il2CppStructArray<bool> A_1, ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E01 RID: 3585 RVA: 0x0003BD64 File Offset: 0x00039F64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351680, RefRangeEnd = 351681, XrefRangeStart = 351679, XrefRangeEnd = 351680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float BlNbZUiJZlAsIpeFJrmqKMdIohR(HardwareJoystickMap.Platform_XInput_Base.Axis A_1, Il2CppStructArray<bool> A_2, ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E02 RID: 3586 RVA: 0x0003BDD4 File Offset: 0x00039FD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351686, RefRangeEnd = 351687, XrefRangeStart = 351681, XrefRangeEnd = 351686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float BlNbZUiJZlAsIpeFJrmqKMdIohR(XInputAxis A_1, ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_XInputAxis_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E03 RID: 3587 RVA: 0x0003BE2C File Offset: 0x0003A02C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351689, RefRangeEnd = 351690, XrefRangeStart = 351687, XrefRangeEnd = 351689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool vGIDntSyHOcwKzWObiWxnUfsrtQ(HardwareJoystickMap.Platform_XInput_Base.Button A_1, Il2CppStructArray<bool> A_2, ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_Button_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E04 RID: 3588 RVA: 0x0003BE9C File Offset: 0x0003A09C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351690, RefRangeEnd = 351691, XrefRangeStart = 351690, XrefRangeEnd = 351690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool vGIDntSyHOcwKzWObiWxnUfsrtQ(XInputButton A_1, Il2CppStructArray<bool> A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_XInputButton_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E05 RID: 3589 RVA: 0x0003BEF8 File Offset: 0x0003A0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351691, XrefRangeEnd = 351699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CQTmbqHFWEknbPpZQtaQsFEAfWh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E06 RID: 3590 RVA: 0x0003BF2C File Offset: 0x0003A12C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351746, RefRangeEnd = 351747, XrefRangeStart = 351699, XrefRangeEnd = 351746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GxMKQzmqXFgumLhiAHMyHUVdKniG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_GxMKQzmqXFgumLhiAHMyHUVdKniG_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000E07 RID: 3591 RVA: 0x0003BF64 File Offset: 0x0003A164
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 351749, RefRangeEnd = 351753, XrefRangeStart = 351747, XrefRangeEnd = 351749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xjeVBysddNzJLefqSMyUGbIFKoA(BridgedControllerHWInfo A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E08 RID: 3592 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 351762, RefRangeEnd = 351764, XrefRangeStart = 351753, XrefRangeEnd = 351762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xjeVBysddNzJLefqSMyUGbIFKoA(BridgedController A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E09 RID: 3593 RVA: 0x0003BFEC File Offset: 0x0003A1EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351768, RefRangeEnd = 351769, XrefRangeStart = 351764, XrefRangeEnd = 351768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E0A RID: 3594 RVA: 0x0003C020 File Offset: 0x0003A220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351769, XrefRangeEnd = 351770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E0B RID: 3595 RVA: 0x0003C05C File Offset: 0x0003A25C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351770, XrefRangeEnd = 351776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void QRqHkxHQdTOvmTIyHpJqpqzNcTZi(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E0C RID: 3596 RVA: 0x00007F38 File Offset: 0x00006138
			public CZKsiOWlVXlzzxfohroaYSgrUvE(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004BC RID: 1212
			// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0003C0A8 File Offset: 0x0003A2A8
			// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00007F41 File Offset: 0x00006141
			public unsafe bool vWyRryVhxsAuDrpdFmQHpBBaKbF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF)) = value;
				}
			}

			// Token: 0x170004BD RID: 1213
			// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0003C0D0 File Offset: 0x0003A2D0
			// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00007F5C File Offset: 0x0000615C
			public unsafe int GNKcpIRbTxVSstxcCBqZKkcbietE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE)) = value;
				}
			}

			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0003C0F8 File Offset: 0x0003A2F8
			// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00007F77 File Offset: 0x00006177
			public unsafe int EzgOmfXXqsMRZAVPXEFXGopnUEc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_EzgOmfXXqsMRZAVPXEFXGopnUEc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_EzgOmfXXqsMRZAVPXEFXGopnUEc)) = value;
				}
			}

			// Token: 0x170004BF RID: 1215
			// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0003C120 File Offset: 0x0003A320
			// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00007F92 File Offset: 0x00006192
			public unsafe Guid WmRdwFvHdKGkxAZMIAvntNHLbaxg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg)) = value;
				}
			}

			// Token: 0x170004C0 RID: 1216
			// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0003C148 File Offset: 0x0003A348
			// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00007FAD File Offset: 0x000061AD
			public unsafe string WLPWeHrDCPCLfETsRQYzcumJyOe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170004C1 RID: 1217
			// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0003C170 File Offset: 0x0003A370
			// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00007FCC File Offset: 0x000061CC
			public unsafe Guid pFkVRJEPoSBxlAjsHKMcxCzbNGQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ)) = value;
				}
			}

			// Token: 0x170004C2 RID: 1218
			// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0003C198 File Offset: 0x0003A398
			// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00007FE7 File Offset: 0x000061E7
			public unsafe DeviceType RpYdDsUDofjGwUtBHUqyQfByLZs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_RpYdDsUDofjGwUtBHUqyQfByLZs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_RpYdDsUDofjGwUtBHUqyQfByLZs)) = value;
				}
			}

			// Token: 0x170004C3 RID: 1219
			// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0003C1C0 File Offset: 0x0003A3C0
			// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00008002 File Offset: 0x00006202
			public unsafe XInputDeviceSubType dBLQpFYawNfSkProgpWRXybmfWk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk)) = value;
				}
			}

			// Token: 0x170004C4 RID: 1220
			// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
			// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0000801D File Offset: 0x0000621D
			public unsafe bool fluTuRVpPCEGssJAmSiTqFgASHv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv)) = value;
				}
			}

			// Token: 0x170004C5 RID: 1221
			// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0003C210 File Offset: 0x0003A410
			// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00008038 File Offset: 0x00006238
			public unsafe bool iZyDqTfpGcbBmbsjPOPlCKAKzrwM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_iZyDqTfpGcbBmbsjPOPlCKAKzrwM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_iZyDqTfpGcbBmbsjPOPlCKAKzrwM)) = value;
				}
			}

			// Token: 0x170004C6 RID: 1222
			// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0003C238 File Offset: 0x0003A438
			// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00008053 File Offset: 0x00006253
			public unsafe bool peDDbxQOdxaaiaVKXPEZetoCmNmT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_peDDbxQOdxaaiaVKXPEZetoCmNmT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_peDDbxQOdxaaiaVKXPEZetoCmNmT)) = value;
				}
			}

			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0003C260 File Offset: 0x0003A460
			// (set) Token: 0x06000E24 RID: 3620 RVA: 0x0000806E File Offset: 0x0000626E
			public unsafe bool LRvEJlriCwlBJKwKgMtnfZNIdMU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_LRvEJlriCwlBJKwKgMtnfZNIdMU);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_LRvEJlriCwlBJKwKgMtnfZNIdMU)) = value;
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0003C288 File Offset: 0x0003A488
			// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00008089 File Offset: 0x00006289
			public unsafe int CEbkfnpUPjUNtreedpctkMveaeQe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_CEbkfnpUPjUNtreedpctkMveaeQe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_CEbkfnpUPjUNtreedpctkMveaeQe)) = value;
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0003C2B0 File Offset: 0x0003A4B0
			// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000080A4 File Offset: 0x000062A4
			public unsafe int DOGKAHhJUEZeDpaHNrJhwSCCnIY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_DOGKAHhJUEZeDpaHNrJhwSCCnIY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_DOGKAHhJUEZeDpaHNrJhwSCCnIY)) = value;
				}
			}

			// Token: 0x170004CA RID: 1226
			// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
			// (set) Token: 0x06000E2A RID: 3626 RVA: 0x000080BF File Offset: 0x000062BF
			public unsafe int uJThHFvMnnGWlhGgONRMIioDKZOj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj)) = value;
				}
			}

			// Token: 0x170004CB RID: 1227
			// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0003C300 File Offset: 0x0003A500
			// (set) Token: 0x06000E2C RID: 3628 RVA: 0x000080DA File Offset: 0x000062DA
			public unsafe int fMsDvvtAhFIJLgiqYmvGYlgVARM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM)) = value;
				}
			}

			// Token: 0x170004CC RID: 1228
			// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0003C328 File Offset: 0x0003A528
			// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000080F5 File Offset: 0x000062F5
			public unsafe Il2CppStructArray<float> CwSFCVqDCbrQyrvPmmvtgaAynZj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004CD RID: 1229
			// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0003C358 File Offset: 0x0003A558
			// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00008114 File Offset: 0x00006314
			public unsafe Il2CppStructArray<bool> sHeRoiRHkuXpbNwEMmzznSiAEVf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004CE RID: 1230
			// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0003C388 File Offset: 0x0003A588
			// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00008133 File Offset: 0x00006333
			public unsafe HardwareJoystickMap_InputManager OHFiyNAurvAHndtKvlMxUsQwcRc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004CF RID: 1231
			// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
			// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00008152 File Offset: 0x00006352
			public unsafe htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF xAEQkKEmsgGlqDEpuAlHEcNWauNE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004D0 RID: 1232
			// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0003C3E8 File Offset: 0x0003A5E8
			// (set) Token: 0x06000E36 RID: 3638 RVA: 0x00008171 File Offset: 0x00006371
			public unsafe Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> swOzpxtgHdYlzNpDnxeXdFTTYrt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004D1 RID: 1233
			// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0003C418 File Offset: 0x0003A618
			// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00008190 File Offset: 0x00006390
			public unsafe Action ucvHopENmIuaxSypqHacPhZuCAep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_ucvHopENmIuaxSypqHacPhZuCAep);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_ucvHopENmIuaxSypqHacPhZuCAep), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004D2 RID: 1234
			// (get) Token: 0x06000E39 RID: 3641 RVA: 0x0003C448 File Offset: 0x0003A648
			// (set) Token: 0x06000E3A RID: 3642 RVA: 0x000081AF File Offset: 0x000063AF
			public unsafe bool sECYhWcWoiAmTNERBzazANDrFEp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp)) = value;
				}
			}

			// Token: 0x170004D3 RID: 1235
			// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0003C470 File Offset: 0x0003A670
			// (set) Token: 0x06000E3C RID: 3644 RVA: 0x000081CA File Offset: 0x000063CA
			public unsafe bool KmDzQOsJBlrBVPwQvpSIJVwVAej
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej)) = value;
				}
			}

			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0003C498 File Offset: 0x0003A698
			// (set) Token: 0x06000E3E RID: 3646 RVA: 0x000081E5 File Offset: 0x000063E5
			public unsafe bool qCyeROasFnJmaEJMACZydOijuQgZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ)) = value;
				}
			}

			// Token: 0x04000CC7 RID: 3271
			private static readonly IntPtr NativeFieldInfoPtr_vWyRryVhxsAuDrpdFmQHpBBaKbF;

			// Token: 0x04000CC8 RID: 3272
			private static readonly IntPtr NativeFieldInfoPtr_GNKcpIRbTxVSstxcCBqZKkcbietE;

			// Token: 0x04000CC9 RID: 3273
			private static readonly IntPtr NativeFieldInfoPtr_EzgOmfXXqsMRZAVPXEFXGopnUEc;

			// Token: 0x04000CCA RID: 3274
			private static readonly IntPtr NativeFieldInfoPtr_WmRdwFvHdKGkxAZMIAvntNHLbaxg;

			// Token: 0x04000CCB RID: 3275
			private static readonly IntPtr NativeFieldInfoPtr_WLPWeHrDCPCLfETsRQYzcumJyOe;

			// Token: 0x04000CCC RID: 3276
			private static readonly IntPtr NativeFieldInfoPtr_pFkVRJEPoSBxlAjsHKMcxCzbNGQ;

			// Token: 0x04000CCD RID: 3277
			private static readonly IntPtr NativeFieldInfoPtr_RpYdDsUDofjGwUtBHUqyQfByLZs;

			// Token: 0x04000CCE RID: 3278
			private static readonly IntPtr NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk;

			// Token: 0x04000CCF RID: 3279
			private static readonly IntPtr NativeFieldInfoPtr_fluTuRVpPCEGssJAmSiTqFgASHv;

			// Token: 0x04000CD0 RID: 3280
			private static readonly IntPtr NativeFieldInfoPtr_iZyDqTfpGcbBmbsjPOPlCKAKzrwM;

			// Token: 0x04000CD1 RID: 3281
			private static readonly IntPtr NativeFieldInfoPtr_peDDbxQOdxaaiaVKXPEZetoCmNmT;

			// Token: 0x04000CD2 RID: 3282
			private static readonly IntPtr NativeFieldInfoPtr_LRvEJlriCwlBJKwKgMtnfZNIdMU;

			// Token: 0x04000CD3 RID: 3283
			private static readonly IntPtr NativeFieldInfoPtr_CEbkfnpUPjUNtreedpctkMveaeQe;

			// Token: 0x04000CD4 RID: 3284
			private static readonly IntPtr NativeFieldInfoPtr_DOGKAHhJUEZeDpaHNrJhwSCCnIY;

			// Token: 0x04000CD5 RID: 3285
			private static readonly IntPtr NativeFieldInfoPtr_uJThHFvMnnGWlhGgONRMIioDKZOj;

			// Token: 0x04000CD6 RID: 3286
			private static readonly IntPtr NativeFieldInfoPtr_fMsDvvtAhFIJLgiqYmvGYlgVARM;

			// Token: 0x04000CD7 RID: 3287
			private static readonly IntPtr NativeFieldInfoPtr_CwSFCVqDCbrQyrvPmmvtgaAynZj;

			// Token: 0x04000CD8 RID: 3288
			private static readonly IntPtr NativeFieldInfoPtr_sHeRoiRHkuXpbNwEMmzznSiAEVf;

			// Token: 0x04000CD9 RID: 3289
			private static readonly IntPtr NativeFieldInfoPtr_OHFiyNAurvAHndtKvlMxUsQwcRc;

			// Token: 0x04000CDA RID: 3290
			private static readonly IntPtr NativeFieldInfoPtr_xAEQkKEmsgGlqDEpuAlHEcNWauNE;

			// Token: 0x04000CDB RID: 3291
			private static readonly IntPtr NativeFieldInfoPtr_swOzpxtgHdYlzNpDnxeXdFTTYrt;

			// Token: 0x04000CDC RID: 3292
			private static readonly IntPtr NativeFieldInfoPtr_ucvHopENmIuaxSypqHacPhZuCAep;

			// Token: 0x04000CDD RID: 3293
			private static readonly IntPtr NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp;

			// Token: 0x04000CDE RID: 3294
			private static readonly IntPtr NativeFieldInfoPtr_KmDzQOsJBlrBVPwQvpSIJVwVAej;

			// Token: 0x04000CDF RID: 3295
			private static readonly IntPtr NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ;

			// Token: 0x04000CE0 RID: 3296
			private static readonly IntPtr NativeMethodInfoPtr_get_instanceName_Public_get_String_0;

			// Token: 0x04000CE1 RID: 3297
			private static readonly IntPtr NativeMethodInfoPtr_get_productName_Public_get_String_0;

			// Token: 0x04000CE2 RID: 3298
			private static readonly IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;

			// Token: 0x04000CE3 RID: 3299
			private static readonly IntPtr NativeMethodInfoPtr_get_rewiredId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000CE4 RID: 3300
			private static readonly IntPtr NativeMethodInfoPtr_set_rewiredId_Public_set_Void_Int32_0;

			// Token: 0x04000CE5 RID: 3301
			private static readonly IntPtr NativeMethodInfoPtr_get_inputManagerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000CE6 RID: 3302
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04000CE7 RID: 3303
			private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_Virtual_Final_New_get_Nullable_1_Int64_0;

			// Token: 0x04000CE8 RID: 3304
			private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000CE9 RID: 3305
			private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_Virtual_Final_New_get_Extension_0;

			// Token: 0x04000CEA RID: 3306
			private static readonly IntPtr NativeMethodInfoPtr_get_instanceGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x04000CEB RID: 3307
			private static readonly IntPtr NativeMethodInfoPtr_get_persistentGuid_Public_Virtual_Final_New_get_Guid_0;

			// Token: 0x04000CEC RID: 3308
			private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Int32_0;

			// Token: 0x04000CED RID: 3309
			private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000CEE RID: 3310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_llqRAazRwKOjwscvuInnIRNnEfF_Func_2_BridgedControllerHWInfo_HardwareJoystickMap_InputManager_Action_0;

			// Token: 0x04000CEF RID: 3311
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000CF0 RID: 3312
			private static readonly IntPtr NativeMethodInfoPtr_MgKdZataXZfVBukywoIarMqqBLn_Public_Void_Boolean_0;

			// Token: 0x04000CF1 RID: 3313
			private static readonly IntPtr NativeMethodInfoPtr_NNQnHVDDVCGMehXjLuPOrHFgbcUD_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0;

			// Token: 0x04000CF2 RID: 3314
			private static readonly IntPtr NativeMethodInfoPtr_GcJaKEnlQnOjISzwjPTvhJKDTcd_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0;

			// Token: 0x04000CF3 RID: 3315
			private static readonly IntPtr NativeMethodInfoPtr_JnypvdEAppjAfHMiOhAwpPxUeqf_Public_Void_Boolean_0;

			// Token: 0x04000CF4 RID: 3316
			private static readonly IntPtr NativeMethodInfoPtr_jQOHflYNIMMgmYicbOrPAzgpGRL_Public_Void_0;

			// Token: 0x04000CF5 RID: 3317
			private static readonly IntPtr NativeMethodInfoPtr_IKrBqwQJiliRvrkHcQvEgDXoSdG_Public_Void_0;

			// Token: 0x04000CF6 RID: 3318
			private static readonly IntPtr NativeMethodInfoPtr_FillData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0;

			// Token: 0x04000CF7 RID: 3319
			private static readonly IntPtr NativeMethodInfoPtr_QkACchszAolJQBMMsHcyPLktlPB_Public_BridgedControllerHWInfo_0;

			// Token: 0x04000CF8 RID: 3320
			private static readonly IntPtr NativeMethodInfoPtr_ToBridgedController_Public_Virtual_Final_New_BridgedController_0;

			// Token: 0x04000CF9 RID: 3321
			private static readonly IntPtr NativeMethodInfoPtr_ToControllerDisconnectedEventArgs_Public_Virtual_Final_New_ControllerDisconnectedEventArgs_0;

			// Token: 0x04000CFA RID: 3322
			private static readonly IntPtr NativeMethodInfoPtr_EWOJgwjmQRgMbivbpSAmdHfknnxO_Private_Void_0;

			// Token: 0x04000CFB RID: 3323
			private static readonly IntPtr NativeMethodInfoPtr_ezpCyugqJsTbTGhxeNtgGdjebRtX_Private_Boolean_0;

			// Token: 0x04000CFC RID: 3324
			private static readonly IntPtr NativeMethodInfoPtr_WcrZDNDCDsaLdhFeYzSHflusYhtE_Private_Void_0;

			// Token: 0x04000CFD RID: 3325
			private static readonly IntPtr NativeMethodInfoPtr_bgZomIfBhzvUBfUObQBLNhcIfXF_Private_Void_0;

			// Token: 0x04000CFE RID: 3326
			private static readonly IntPtr NativeMethodInfoPtr_RUgKGlELCQBBrmrOvYkKJbAGPIE_Private_Void_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;

			// Token: 0x04000CFF RID: 3327
			private static readonly IntPtr NativeMethodInfoPtr_ipocWZvAxAdXermpojWFHIJHbTFS_Private_Void_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;

			// Token: 0x04000D00 RID: 3328
			private static readonly IntPtr NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_Axis_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;

			// Token: 0x04000D01 RID: 3329
			private static readonly IntPtr NativeMethodInfoPtr_BlNbZUiJZlAsIpeFJrmqKMdIohR_Private_Single_XInputAxis_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;

			// Token: 0x04000D02 RID: 3330
			private static readonly IntPtr NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_Button_Il2CppStructArray_1_Boolean_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;

			// Token: 0x04000D03 RID: 3331
			private static readonly IntPtr NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Boolean_XInputButton_Il2CppStructArray_1_Boolean_0;

			// Token: 0x04000D04 RID: 3332
			private static readonly IntPtr NativeMethodInfoPtr_CQTmbqHFWEknbPpZQtaQsFEAfWh_Private_Void_0;

			// Token: 0x04000D05 RID: 3333
			private static readonly IntPtr NativeMethodInfoPtr_GxMKQzmqXFgumLhiAHMyHUVdKniG_Private_String_0;

			// Token: 0x04000D06 RID: 3334
			private static readonly IntPtr NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedControllerHWInfo_0;

			// Token: 0x04000D07 RID: 3335
			private static readonly IntPtr NativeMethodInfoPtr_xjeVBysddNzJLefqSMyUGbIFKoA_Private_Void_BridgedController_0;

			// Token: 0x04000D08 RID: 3336
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000D09 RID: 3337
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04000D0A RID: 3338
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0;
		}

		// Token: 0x020000C5 RID: 197
		public class UQkAMyITvBRPDPZDOnsCOGGSBRJb : Object
		{
			// Token: 0x06000E3F RID: 3647 RVA: 0x0003C4C0 File Offset: 0x0003A6C0
			// Note: this type is marked as 'beforefieldinit'.
			static UQkAMyITvBRPDPZDOnsCOGGSBRJb()
			{
				Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "UQkAMyITvBRPDPZDOnsCOGGSBRJb");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, "gusHCWBeNlrbYsMEBKlcvqKfDoT");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663766);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_eDuzYZWtapugCAemjsDYiTyipa_Public_Void_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663767);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Int32_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663768);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_ubRidzTTEAFJideNZcYuiQSOzXAg_Public_Int32_XInputDeviceSubType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663769);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_ZiwPkJZMhrahAHUGkJPYMUwVQdI_Public_Int32_Int32_XInputDeviceSubType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663770);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_TWYdXHgYZSXDLigCQUhpFlxIRECF_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663771);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_wqMqMLyNUAEaPGqnpIloOGyWFEg_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, 100663772);
			}

			// Token: 0x06000E40 RID: 3648 RVA: 0x0003C58C File Offset: 0x0003A78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351776, XrefRangeEnd = 351782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UQkAMyITvBRPDPZDOnsCOGGSBRJb()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E41 RID: 3649 RVA: 0x0003C5C8 File Offset: 0x0003A7C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351782, XrefRangeEnd = 351790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void eDuzYZWtapugCAemjsDYiTyipa(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE A_1, bool A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_eDuzYZWtapugCAemjsDYiTyipa_Public_Void_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E42 RID: 3650 RVA: 0x0003C618 File Offset: 0x0003A818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351790, XrefRangeEnd = 351792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VkKCEPARYOuxbLbQAeytGgNzULkC(int A_1, htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE A_2, bool A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Int32_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E43 RID: 3651 RVA: 0x0003C678 File Offset: 0x0003A878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351792, XrefRangeEnd = 351794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int ubRidzTTEAFJideNZcYuiQSOzXAg(XInputDeviceSubType A_1, bool A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_ubRidzTTEAFJideNZcYuiQSOzXAg_Public_Int32_XInputDeviceSubType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E44 RID: 3652 RVA: 0x0003C6D0 File Offset: 0x0003A8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351794, XrefRangeEnd = 351796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int ZiwPkJZMhrahAHUGkJPYMUwVQdI(int A_1, XInputDeviceSubType A_2, bool A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_ZiwPkJZMhrahAHUGkJPYMUwVQdI_Public_Int32_Int32_XInputDeviceSubType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E45 RID: 3653 RVA: 0x0003C738 File Offset: 0x0003A938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351796, XrefRangeEnd = 351798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int TWYdXHgYZSXDLigCQUhpFlxIRECF(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_TWYdXHgYZSXDLigCQUhpFlxIRECF_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E46 RID: 3654 RVA: 0x0003C784 File Offset: 0x0003A984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351798, XrefRangeEnd = 351800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void wqMqMLyNUAEaPGqnpIloOGyWFEg(int A_1, bool A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeMethodInfoPtr_wqMqMLyNUAEaPGqnpIloOGyWFEg_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E47 RID: 3655 RVA: 0x00008200 File Offset: 0x00006400
			public UQkAMyITvBRPDPZDOnsCOGGSBRJb(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004E0 RID: 1248
			// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0003C7D0 File Offset: 0x0003A9D0
			// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00008209 File Offset: 0x00006409
			public unsafe List<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb> gusHCWBeNlrbYsMEBKlcvqKfDoT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D0B RID: 3339
			private static readonly IntPtr NativeFieldInfoPtr_gusHCWBeNlrbYsMEBKlcvqKfDoT;

			// Token: 0x04000D0C RID: 3340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000D0D RID: 3341
			private static readonly IntPtr NativeMethodInfoPtr_eDuzYZWtapugCAemjsDYiTyipa_Public_Void_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0;

			// Token: 0x04000D0E RID: 3342
			private static readonly IntPtr NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_Int32_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0;

			// Token: 0x04000D0F RID: 3343
			private static readonly IntPtr NativeMethodInfoPtr_ubRidzTTEAFJideNZcYuiQSOzXAg_Public_Int32_XInputDeviceSubType_Boolean_0;

			// Token: 0x04000D10 RID: 3344
			private static readonly IntPtr NativeMethodInfoPtr_ZiwPkJZMhrahAHUGkJPYMUwVQdI_Public_Int32_Int32_XInputDeviceSubType_Boolean_0;

			// Token: 0x04000D11 RID: 3345
			private static readonly IntPtr NativeMethodInfoPtr_TWYdXHgYZSXDLigCQUhpFlxIRECF_Public_Int32_Int32_0;

			// Token: 0x04000D12 RID: 3346
			private static readonly IntPtr NativeMethodInfoPtr_wqMqMLyNUAEaPGqnpIloOGyWFEg_Public_Void_Int32_Boolean_0;

			// Token: 0x0200012C RID: 300
			public class ZFebRvKVUBrpSPBPSxqLNaxqavmb : Object
			{
				// Token: 0x0600122F RID: 4655 RVA: 0x0004E270 File Offset: 0x0004C470
				// Note: this type is marked as 'beforefieldinit'.
				static ZFebRvKVUBrpSPBPSxqLNaxqavmb()
				{
					Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb>.NativeClassPtr, "ZFebRvKVUBrpSPBPSxqLNaxqavmb");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr);
					htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_izDxCepULXiUNpNEqvJkoXDwMCw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr, "izDxCepULXiUNpNEqvJkoXDwMCw");
					htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr, "XUKXgpkeURQbNWYxnzWmsGORdLL");
					htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr, "dBLQpFYawNfSkProgpWRXybmfWk");
					htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr, 100663773);
					htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeMethodInfoPtr__ctor_Public_Void_Int32_XInputDeviceSubType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr, 100663774);
				}

				// Token: 0x06001230 RID: 4656 RVA: 0x0004E300 File Offset: 0x0004C500
				[CallerCount(0)]
				public unsafe void VkKCEPARYOuxbLbQAeytGgNzULkC(htAwVZkIzkPeJoMHQZBWGOsyKCZ.CZKsiOWlVXlzzxfohroaYSgrUvE A_1, bool A_2)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001231 RID: 4657 RVA: 0x0004E350 File Offset: 0x0004C550
				[CallerCount(0)]
				public unsafe ZFebRvKVUBrpSPBPSxqLNaxqavmb(int rewiredId, XInputDeviceSubType deviceSubType)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref rewiredId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceSubType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeMethodInfoPtr__ctor_Public_Void_Int32_XInputDeviceSubType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001232 RID: 4658 RVA: 0x0000A622 File Offset: 0x00008822
				public ZFebRvKVUBrpSPBPSxqLNaxqavmb(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000621 RID: 1569
				// (get) Token: 0x06001233 RID: 4659 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
				// (set) Token: 0x06001234 RID: 4660 RVA: 0x0000A62B File Offset: 0x0000882B
				public unsafe bool izDxCepULXiUNpNEqvJkoXDwMCw
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_izDxCepULXiUNpNEqvJkoXDwMCw);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_izDxCepULXiUNpNEqvJkoXDwMCw)) = value;
					}
				}

				// Token: 0x17000622 RID: 1570
				// (get) Token: 0x06001235 RID: 4661 RVA: 0x0004E3D0 File Offset: 0x0004C5D0
				// (set) Token: 0x06001236 RID: 4662 RVA: 0x0000A646 File Offset: 0x00008846
				public unsafe int XUKXgpkeURQbNWYxnzWmsGORdLL
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL)) = value;
					}
				}

				// Token: 0x17000623 RID: 1571
				// (get) Token: 0x06001237 RID: 4663 RVA: 0x0004E3F8 File Offset: 0x0004C5F8
				// (set) Token: 0x06001238 RID: 4664 RVA: 0x0000A661 File Offset: 0x00008861
				public unsafe XInputDeviceSubType dBLQpFYawNfSkProgpWRXybmfWk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.UQkAMyITvBRPDPZDOnsCOGGSBRJb.ZFebRvKVUBrpSPBPSxqLNaxqavmb.NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk)) = value;
					}
				}

				// Token: 0x04001B83 RID: 7043
				private static readonly IntPtr NativeFieldInfoPtr_izDxCepULXiUNpNEqvJkoXDwMCw;

				// Token: 0x04001B84 RID: 7044
				private static readonly IntPtr NativeFieldInfoPtr_XUKXgpkeURQbNWYxnzWmsGORdLL;

				// Token: 0x04001B85 RID: 7045
				private static readonly IntPtr NativeFieldInfoPtr_dBLQpFYawNfSkProgpWRXybmfWk;

				// Token: 0x04001B86 RID: 7046
				private static readonly IntPtr NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Void_CZKsiOWlVXlzzxfohroaYSgrUvE_Boolean_0;

				// Token: 0x04001B87 RID: 7047
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_XInputDeviceSubType_0;
			}
		}

		// Token: 0x020000C6 RID: 198
		public class vHyHpOXenagtvzlIyAYUgczrAUR : Object
		{
			// Token: 0x06000E4A RID: 3658 RVA: 0x0003C800 File Offset: 0x0003AA00
			// Note: this type is marked as 'beforefieldinit'.
			static vHyHpOXenagtvzlIyAYUgczrAUR()
			{
				Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "vHyHpOXenagtvzlIyAYUgczrAUR");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_ZctjwhvLPibqIbPweETZgQPjwmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr, "ZctjwhvLPibqIbPweETZgQPjwmx");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_PIsGJBeONoeqSnNwjxmfHVdflHwh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr, "PIsGJBeONoeqSnNwjxmfHVdflHwh");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_paeGAgEWWNbgOiJyqADUTglxxsD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr, "paeGAgEWWNbgOiJyqADUTglxxsD");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr, 100663775);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeMethodInfoPtr_SiqFdgdmDgRtUUVrJYjNSNYxQCC_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr, 100663776);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr, 100663777);
			}

			// Token: 0x06000E4B RID: 3659 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
			[CallerCount(0)]
			public unsafe vHyHpOXenagtvzlIyAYUgczrAUR(float inLength)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref inLength;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E4C RID: 3660 RVA: 0x0003C8EC File Offset: 0x0003AAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351800, XrefRangeEnd = 351804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SiqFdgdmDgRtUUVrJYjNSNYxQCC()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeMethodInfoPtr_SiqFdgdmDgRtUUVrJYjNSNYxQCC_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E4D RID: 3661 RVA: 0x0003C920 File Offset: 0x0003AB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351804, XrefRangeEnd = 351808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool VkKCEPARYOuxbLbQAeytGgNzULkC()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x00008228 File Offset: 0x00006428
			public vHyHpOXenagtvzlIyAYUgczrAUR(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003C95C File Offset: 0x0003AB5C
			// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00008231 File Offset: 0x00006431
			public unsafe bool ZctjwhvLPibqIbPweETZgQPjwmx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_ZctjwhvLPibqIbPweETZgQPjwmx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_ZctjwhvLPibqIbPweETZgQPjwmx)) = value;
				}
			}

			// Token: 0x170004E2 RID: 1250
			// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003C984 File Offset: 0x0003AB84
			// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0000824C File Offset: 0x0000644C
			public unsafe double PIsGJBeONoeqSnNwjxmfHVdflHwh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_PIsGJBeONoeqSnNwjxmfHVdflHwh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_PIsGJBeONoeqSnNwjxmfHVdflHwh)) = value;
				}
			}

			// Token: 0x170004E3 RID: 1251
			// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003C9AC File Offset: 0x0003ABAC
			// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00008267 File Offset: 0x00006467
			public unsafe float paeGAgEWWNbgOiJyqADUTglxxsD
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_paeGAgEWWNbgOiJyqADUTglxxsD);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.vHyHpOXenagtvzlIyAYUgczrAUR.NativeFieldInfoPtr_paeGAgEWWNbgOiJyqADUTglxxsD)) = value;
				}
			}

			// Token: 0x04000D13 RID: 3347
			private static readonly IntPtr NativeFieldInfoPtr_ZctjwhvLPibqIbPweETZgQPjwmx;

			// Token: 0x04000D14 RID: 3348
			private static readonly IntPtr NativeFieldInfoPtr_PIsGJBeONoeqSnNwjxmfHVdflHwh;

			// Token: 0x04000D15 RID: 3349
			private static readonly IntPtr NativeFieldInfoPtr_paeGAgEWWNbgOiJyqADUTglxxsD;

			// Token: 0x04000D16 RID: 3350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

			// Token: 0x04000D17 RID: 3351
			private static readonly IntPtr NativeMethodInfoPtr_SiqFdgdmDgRtUUVrJYjNSNYxQCC_Public_Void_0;

			// Token: 0x04000D18 RID: 3352
			private static readonly IntPtr NativeMethodInfoPtr_VkKCEPARYOuxbLbQAeytGgNzULkC_Public_Boolean_0;
		}

		// Token: 0x020000C7 RID: 199
		public class llqRAazRwKOjwscvuInnIRNnEfF : Object
		{
			// Token: 0x06000E55 RID: 3669 RVA: 0x0003C9D4 File Offset: 0x0003ABD4
			// Note: this type is marked as 'beforefieldinit'.
			static llqRAazRwKOjwscvuInnIRNnEfF()
			{
				Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ>.NativeClassPtr, "llqRAazRwKOjwscvuInnIRNnEfF");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_lHFiYInKZOOfkkasDrhdWLVcQNU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "lHFiYInKZOOfkkasDrhdWLVcQNU");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_urhoGkOkWEcuhCGbXgLbGgsfcbaR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "urhoGkOkWEcuhCGbXgLbGgsfcbaR");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "sECYhWcWoiAmTNERBzazANDrFEp");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "aehIuCaBGkJGXMAlznFlFxMWCEsN");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_AcjJojhCzUEMVKnJfCFhmLbOTTq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "AcjJojhCzUEMVKnJfCFhmLbOTTq");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_KnmWmAlZbbtRhIgvwWbACLiKhRR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "KnmWmAlZbbtRhIgvwWbACLiKhRR");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "oOqTZKxPXasKRoAwrxIXSHgbeIEE");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "LakZHHdbozgBEgMhvUQKIaOsnnRh");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_VYAkRSQMhFCbCkdrawvvVcDijIj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "VYAkRSQMhFCbCkdrawvvVcDijIj");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_PMDenMjOADVaZgksLpJzFZhbCNZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "PMDenMjOADVaZgksLpJzFZhbCNZ");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_hQFPVWapbQvXASAfKdirKYvedSMU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "hQFPVWapbQvXASAfKdirKYvedSMU");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_eCsYKxtMFNInNRloZFSNSFuzWlf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "eCsYKxtMFNInNRloZFSNSFuzWlf");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_CenOIBLumXoRHIlGYDdeaytfNkiW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "CenOIBLumXoRHIlGYDdeaytfNkiW");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_kZNWWyfboxonkBvvdpjJjhYkfnr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "kZNWWyfboxonkBvvdpjJjhYkfnr");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, "qCyeROasFnJmaEJMACZydOijuQgZ");
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_get_CurrentButtonValues_Public_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663778);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr__ctor_Public_Void_Int32_UpdateLoopSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663779);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_TMKRneAcTZDgoTcAvbZAIQuPJOX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663780);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_tChsqfLBbuaRDkpHTYDeKpSkXYu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663781);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_HGoylHCPNNCdnbJqcVqEhcxOqeE_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663782);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_aCpqPWTyANbPQOqZthrdsbSMBCo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663783);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_GcJaKEnlQnOjISzwjPTvhJKDTcd_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663784);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_hTtCUpDInQXcBbpGVpdQRTQcaxe_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663785);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_iVBjsncoPGAPJQtxTaptiYByMnw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663786);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_NsRBDIKgGXKljkECzQKRmXRfWVBH_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663787);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_GWsnXnzzSKbYUFFsKGHcxraefnFk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663788);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_phnkXyPOSbdFAOVqgiwaBtHToMl_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663789);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_iLdnIMboLXykaDilblyvDakkDiY_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663790);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_JTHxIKmTZsDNMTgLAPKGTpAlseH_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663791);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_tSYaDkkwGqTaaQfYCSyLFiqPlxv_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663792);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_ctFPaNJzaxwJnbRfsScacLayEbT_Private_Static_Void_RingBuffer_1_UDRonmQIbhwuVcbmlgzfpmqddNE_tzQKWxDhNEWjpkwRtFOXAbdpqPv_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663793);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_MwiHFiVjLkICjFPkuuCjVQVnbFuK_Private_Static_Void_tzQKWxDhNEWjpkwRtFOXAbdpqPv_UDRonmQIbhwuVcbmlgzfpmqddNE_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663794);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_PRQEoVVZSpMeshjOAdQuWfumrFp_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663795);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_QsFdWGOVyzVLCoRdvLwLoVKVDlq_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_Double_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663796);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_bgxnLoCaLzkMBdCRfSMDAUZklDE_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_byref_LowLevelInputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663797);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663798);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_NvDtjMUtkOKqLAEsUOgHsaWxBCYA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663799);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663800);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663801);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663802);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663803);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_pltkvMqNemcDhVtZbJqoQwkvjBt_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663804);
				htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_KmdNDXnZEjTlSQlWVhOSuBfvaMYE_Private_Static_Boolean_lWGqplCPfeqSqYQMnGJhAaJXrqX_lWGqplCPfeqSqYQMnGJhAaJXrqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr, 100663805);
			}

			// Token: 0x170004F3 RID: 1267
			// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0003CD5C File Offset: 0x0003AF5C
			public unsafe Il2CppStructArray<bool> WPhAJNUnKYzKwbbJCDGaBlqMWxg
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351808, XrefRangeEnd = 351810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_get_CurrentButtonValues_Public_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06000E57 RID: 3671 RVA: 0x0003CD9C File Offset: 0x0003AF9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351838, RefRangeEnd = 351839, XrefRangeStart = 351810, XrefRangeEnd = 351838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe llqRAazRwKOjwscvuInnIRNnEfF(int controllerIndex, UpdateLoopSetting updateLoops)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref controllerIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoops;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr__ctor_Public_Void_Int32_UpdateLoopSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E58 RID: 3672 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351839, XrefRangeEnd = 351848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TMKRneAcTZDgoTcAvbZAIQuPJOX()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_TMKRneAcTZDgoTcAvbZAIQuPJOX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E59 RID: 3673 RVA: 0x0003CE28 File Offset: 0x0003B028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351848, XrefRangeEnd = 351858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void tChsqfLBbuaRDkpHTYDeKpSkXYu()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_tChsqfLBbuaRDkpHTYDeKpSkXYu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E5A RID: 3674 RVA: 0x0003CE5C File Offset: 0x0003B05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351858, XrefRangeEnd = 351860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void HGoylHCPNNCdnbJqcVqEhcxOqeE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_HGoylHCPNNCdnbJqcVqEhcxOqeE_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E5B RID: 3675 RVA: 0x0003CE90 File Offset: 0x0003B090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351860, XrefRangeEnd = 351861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void aCpqPWTyANbPQOqZthrdsbSMBCo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_aCpqPWTyANbPQOqZthrdsbSMBCo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E5C RID: 3676 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
			[CallerCount(0)]
			public unsafe bool GcJaKEnlQnOjISzwjPTvhJKDTcd(htAwVZkIzkPeJoMHQZBWGOsyKCZ.NyyZSYJJkzTnYfWzTqOjsIHfWbL A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_GcJaKEnlQnOjISzwjPTvhJKDTcd_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E5D RID: 3677 RVA: 0x0003CF10 File Offset: 0x0003B110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351861, XrefRangeEnd = 351865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void hTtCUpDInQXcBbpGVpdQRTQcaxe(float A_1, int A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_hTtCUpDInQXcBbpGVpdQRTQcaxe_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E5E RID: 3678 RVA: 0x0003CF5C File Offset: 0x0003B15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351865, XrefRangeEnd = 351866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void iVBjsncoPGAPJQtxTaptiYByMnw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_iVBjsncoPGAPJQtxTaptiYByMnw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E5F RID: 3679 RVA: 0x0003CF90 File Offset: 0x0003B190
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351877, RefRangeEnd = 351878, XrefRangeStart = 351866, XrefRangeEnd = 351877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void NsRBDIKgGXKljkECzQKRmXRfWVBH()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_NsRBDIKgGXKljkECzQKRmXRfWVBH_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E60 RID: 3680 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351878, XrefRangeEnd = 351918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GWsnXnzzSKbYUFFsKGHcxraefnFk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_GWsnXnzzSKbYUFFsKGHcxraefnFk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E61 RID: 3681 RVA: 0x0003CFF8 File Offset: 0x0003B1F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351918, XrefRangeEnd = 351942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void phnkXyPOSbdFAOVqgiwaBtHToMl()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_phnkXyPOSbdFAOVqgiwaBtHToMl_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E62 RID: 3682 RVA: 0x0003D02C File Offset: 0x0003B22C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351942, XrefRangeEnd = 351949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void iLdnIMboLXykaDilblyvDakkDiY()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_iLdnIMboLXykaDilblyvDakkDiY_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E63 RID: 3683 RVA: 0x0003D060 File Offset: 0x0003B260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void JTHxIKmTZsDNMTgLAPKGTpAlseH()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_JTHxIKmTZsDNMTgLAPKGTpAlseH_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E64 RID: 3684 RVA: 0x0003D094 File Offset: 0x0003B294
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 351956, RefRangeEnd = 351966, XrefRangeStart = 351949, XrefRangeEnd = 351956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void tSYaDkkwGqTaaQfYCSyLFiqPlxv()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_tSYaDkkwGqTaaQfYCSyLFiqPlxv_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E65 RID: 3685 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351966, XrefRangeEnd = 351972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ctFPaNJzaxwJnbRfsScacLayEbT(RingBuffer<UDRonmQIbhwuVcbmlgzfpmqddNE> A_0, tzQKWxDhNEWjpkwRtFOXAbdpqPv A_1, ref double A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_ctFPaNJzaxwJnbRfsScacLayEbT_Private_Static_Void_RingBuffer_1_UDRonmQIbhwuVcbmlgzfpmqddNE_tzQKWxDhNEWjpkwRtFOXAbdpqPv_byref_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E66 RID: 3686 RVA: 0x0003D120 File Offset: 0x0003B320
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 351978, RefRangeEnd = 351981, XrefRangeStart = 351972, XrefRangeEnd = 351978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void MwiHFiVjLkICjFPkuuCjVQVnbFuK(tzQKWxDhNEWjpkwRtFOXAbdpqPv A_0, UDRonmQIbhwuVcbmlgzfpmqddNE A_1, ref double A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_MwiHFiVjLkICjFPkuuCjVQVnbFuK_Private_Static_Void_tzQKWxDhNEWjpkwRtFOXAbdpqPv_UDRonmQIbhwuVcbmlgzfpmqddNE_byref_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E67 RID: 3687 RVA: 0x0003D174 File Offset: 0x0003B374
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 351992, RefRangeEnd = 351994, XrefRangeStart = 351981, XrefRangeEnd = 351992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PRQEoVVZSpMeshjOAdQuWfumrFp(ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_PRQEoVVZSpMeshjOAdQuWfumrFp_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E68 RID: 3688 RVA: 0x0003D1B4 File Offset: 0x0003B3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351994, XrefRangeEnd = 352008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QsFdWGOVyzVLCoRdvLwLoVKVDlq(ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_1, double A_2, LowLevelInputEvent A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_QsFdWGOVyzVLCoRdvLwLoVKVDlq_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_Double_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E69 RID: 3689 RVA: 0x0003D210 File Offset: 0x0003B410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352008, XrefRangeEnd = 352015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void bgxnLoCaLzkMBdCRfSMDAUZklDE(ref lWGqplCPfeqSqYQMnGJhAaJXrqX A_1, ref LowLevelInputEvent A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_bgxnLoCaLzkMBdCRfSMDAUZklDE_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_byref_LowLevelInputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E6A RID: 3690 RVA: 0x0003D25C File Offset: 0x0003B45C
			[CallerCount(0)]
			public unsafe static bool vGIDntSyHOcwKzWObiWxnUfsrtQ(int A_0, int A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E6B RID: 3691 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 352021, RefRangeEnd = 352031, XrefRangeStart = 352015, XrefRangeEnd = 352021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void NvDtjMUtkOKqLAEsUOgHsaWxBCYA()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_NvDtjMUtkOKqLAEsUOgHsaWxBCYA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E6C RID: 3692 RVA: 0x0003D2DC File Offset: 0x0003B4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352031, XrefRangeEnd = 352035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E6D RID: 3693 RVA: 0x0003D310 File Offset: 0x0003B510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E6E RID: 3694 RVA: 0x0003D34C File Offset: 0x0003B54C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352035, XrefRangeEnd = 352036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void QRqHkxHQdTOvmTIyHpJqpqzNcTZi(bool A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E6F RID: 3695 RVA: 0x0003D398 File Offset: 0x0003B598
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 352037, RefRangeEnd = 352049, XrefRangeStart = 352036, XrefRangeEnd = 352037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float giTkLqleHbFHnWmDqeZsZmbNCBJH(int A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E70 RID: 3696 RVA: 0x0003D3D8 File Offset: 0x0003B5D8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 352050, RefRangeEnd = 352055, XrefRangeStart = 352049, XrefRangeEnd = 352050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float pltkvMqNemcDhVtZbJqoQwkvjBt(int A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_pltkvMqNemcDhVtZbJqoQwkvjBt_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000E71 RID: 3697 RVA: 0x0003D418 File Offset: 0x0003B618
			[CallerCount(0)]
			public unsafe static bool KmdNDXnZEjTlSQlWVhOSuBfvaMYE(lWGqplCPfeqSqYQMnGJhAaJXrqX A_0, lWGqplCPfeqSqYQMnGJhAaJXrqX A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeMethodInfoPtr_KmdNDXnZEjTlSQlWVhOSuBfvaMYE_Private_Static_Boolean_lWGqplCPfeqSqYQMnGJhAaJXrqX_lWGqplCPfeqSqYQMnGJhAaJXrqX_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E72 RID: 3698 RVA: 0x00008282 File Offset: 0x00006482
			public llqRAazRwKOjwscvuInnIRNnEfF(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004E4 RID: 1252
			// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0003D464 File Offset: 0x0003B664
			// (set) Token: 0x06000E74 RID: 3700 RVA: 0x0000828B File Offset: 0x0000648B
			public unsafe tzQKWxDhNEWjpkwRtFOXAbdpqPv lHFiYInKZOOfkkasDrhdWLVcQNU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_lHFiYInKZOOfkkasDrhdWLVcQNU);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<tzQKWxDhNEWjpkwRtFOXAbdpqPv>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_lHFiYInKZOOfkkasDrhdWLVcQNU), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004E5 RID: 1253
			// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0003D494 File Offset: 0x0003B694
			// (set) Token: 0x06000E76 RID: 3702 RVA: 0x000082AA File Offset: 0x000064AA
			public unsafe lWGqplCPfeqSqYQMnGJhAaJXrqX urhoGkOkWEcuhCGbXgLbGgsfcbaR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_urhoGkOkWEcuhCGbXgLbGgsfcbaR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_urhoGkOkWEcuhCGbXgLbGgsfcbaR)) = value;
				}
			}

			// Token: 0x170004E6 RID: 1254
			// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0003D4BC File Offset: 0x0003B6BC
			// (set) Token: 0x06000E78 RID: 3704 RVA: 0x000082C5 File Offset: 0x000064C5
			public unsafe bool sECYhWcWoiAmTNERBzazANDrFEp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp)) = value;
				}
			}

			// Token: 0x170004E7 RID: 1255
			// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
			// (set) Token: 0x06000E7A RID: 3706 RVA: 0x000082E0 File Offset: 0x000064E0
			public unsafe ButtonLoopSet aehIuCaBGkJGXMAlznFlFxMWCEsN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonLoopSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004E8 RID: 1256
			// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0003D514 File Offset: 0x0003B714
			// (set) Token: 0x06000E7C RID: 3708 RVA: 0x000082FF File Offset: 0x000064FF
			public unsafe lWGqplCPfeqSqYQMnGJhAaJXrqX AcjJojhCzUEMVKnJfCFhmLbOTTq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_AcjJojhCzUEMVKnJfCFhmLbOTTq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_AcjJojhCzUEMVKnJfCFhmLbOTTq)) = value;
				}
			}

			// Token: 0x170004E9 RID: 1257
			// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0003D53C File Offset: 0x0003B73C
			// (set) Token: 0x06000E7E RID: 3710 RVA: 0x0000831A File Offset: 0x0000651A
			public unsafe bool KnmWmAlZbbtRhIgvwWbACLiKhRR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_KnmWmAlZbbtRhIgvwWbACLiKhRR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_KnmWmAlZbbtRhIgvwWbACLiKhRR)) = value;
				}
			}

			// Token: 0x170004EA RID: 1258
			// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0003D564 File Offset: 0x0003B764
			// (set) Token: 0x06000E80 RID: 3712 RVA: 0x00008335 File Offset: 0x00006535
			public unsafe DualThreadLowLevelInputEventQueue oOqTZKxPXasKRoAwrxIXSHgbeIEE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DualThreadLowLevelInputEventQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004EB RID: 1259
			// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0003D594 File Offset: 0x0003B794
			// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00008354 File Offset: 0x00006554
			public unsafe Object LakZHHdbozgBEgMhvUQKIaOsnnRh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004EC RID: 1260
			// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0003D5C4 File Offset: 0x0003B7C4
			// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00008373 File Offset: 0x00006573
			public unsafe RingBuffer<UDRonmQIbhwuVcbmlgzfpmqddNE> VYAkRSQMhFCbCkdrawvvVcDijIj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_VYAkRSQMhFCbCkdrawvvVcDijIj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RingBuffer<UDRonmQIbhwuVcbmlgzfpmqddNE>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_VYAkRSQMhFCbCkdrawvvVcDijIj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004ED RID: 1261
			// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0003D5F4 File Offset: 0x0003B7F4
			// (set) Token: 0x06000E86 RID: 3718 RVA: 0x00008392 File Offset: 0x00006592
			public unsafe RingBuffer<UDRonmQIbhwuVcbmlgzfpmqddNE> PMDenMjOADVaZgksLpJzFZhbCNZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_PMDenMjOADVaZgksLpJzFZhbCNZ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RingBuffer<UDRonmQIbhwuVcbmlgzfpmqddNE>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_PMDenMjOADVaZgksLpJzFZhbCNZ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004EE RID: 1262
			// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0003D624 File Offset: 0x0003B824
			// (set) Token: 0x06000E88 RID: 3720 RVA: 0x000083B1 File Offset: 0x000065B1
			public unsafe Object hQFPVWapbQvXASAfKdirKYvedSMU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_hQFPVWapbQvXASAfKdirKYvedSMU);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_hQFPVWapbQvXASAfKdirKYvedSMU), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004EF RID: 1263
			// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0003D654 File Offset: 0x0003B854
			// (set) Token: 0x06000E8A RID: 3722 RVA: 0x000083D0 File Offset: 0x000065D0
			public unsafe Object eCsYKxtMFNInNRloZFSNSFuzWlf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_eCsYKxtMFNInNRloZFSNSFuzWlf);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_eCsYKxtMFNInNRloZFSNSFuzWlf), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004F0 RID: 1264
			// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0003D684 File Offset: 0x0003B884
			// (set) Token: 0x06000E8C RID: 3724 RVA: 0x000083EF File Offset: 0x000065EF
			public unsafe UDRonmQIbhwuVcbmlgzfpmqddNE CenOIBLumXoRHIlGYDdeaytfNkiW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_CenOIBLumXoRHIlGYDdeaytfNkiW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_CenOIBLumXoRHIlGYDdeaytfNkiW)) = value;
				}
			}

			// Token: 0x170004F1 RID: 1265
			// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0003D6AC File Offset: 0x0003B8AC
			// (set) Token: 0x06000E8E RID: 3726 RVA: 0x0000840A File Offset: 0x0000660A
			public unsafe double kZNWWyfboxonkBvvdpjJjhYkfnr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_kZNWWyfboxonkBvvdpjJjhYkfnr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_kZNWWyfboxonkBvvdpjJjhYkfnr)) = value;
				}
			}

			// Token: 0x170004F2 RID: 1266
			// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
			// (set) Token: 0x06000E90 RID: 3728 RVA: 0x00008425 File Offset: 0x00006625
			public unsafe bool qCyeROasFnJmaEJMACZydOijuQgZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(htAwVZkIzkPeJoMHQZBWGOsyKCZ.llqRAazRwKOjwscvuInnIRNnEfF.NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ)) = value;
				}
			}

			// Token: 0x04000D19 RID: 3353
			private static readonly IntPtr NativeFieldInfoPtr_lHFiYInKZOOfkkasDrhdWLVcQNU;

			// Token: 0x04000D1A RID: 3354
			private static readonly IntPtr NativeFieldInfoPtr_urhoGkOkWEcuhCGbXgLbGgsfcbaR;

			// Token: 0x04000D1B RID: 3355
			private static readonly IntPtr NativeFieldInfoPtr_sECYhWcWoiAmTNERBzazANDrFEp;

			// Token: 0x04000D1C RID: 3356
			private static readonly IntPtr NativeFieldInfoPtr_aehIuCaBGkJGXMAlznFlFxMWCEsN;

			// Token: 0x04000D1D RID: 3357
			private static readonly IntPtr NativeFieldInfoPtr_AcjJojhCzUEMVKnJfCFhmLbOTTq;

			// Token: 0x04000D1E RID: 3358
			private static readonly IntPtr NativeFieldInfoPtr_KnmWmAlZbbtRhIgvwWbACLiKhRR;

			// Token: 0x04000D1F RID: 3359
			private static readonly IntPtr NativeFieldInfoPtr_oOqTZKxPXasKRoAwrxIXSHgbeIEE;

			// Token: 0x04000D20 RID: 3360
			private static readonly IntPtr NativeFieldInfoPtr_LakZHHdbozgBEgMhvUQKIaOsnnRh;

			// Token: 0x04000D21 RID: 3361
			private static readonly IntPtr NativeFieldInfoPtr_VYAkRSQMhFCbCkdrawvvVcDijIj;

			// Token: 0x04000D22 RID: 3362
			private static readonly IntPtr NativeFieldInfoPtr_PMDenMjOADVaZgksLpJzFZhbCNZ;

			// Token: 0x04000D23 RID: 3363
			private static readonly IntPtr NativeFieldInfoPtr_hQFPVWapbQvXASAfKdirKYvedSMU;

			// Token: 0x04000D24 RID: 3364
			private static readonly IntPtr NativeFieldInfoPtr_eCsYKxtMFNInNRloZFSNSFuzWlf;

			// Token: 0x04000D25 RID: 3365
			private static readonly IntPtr NativeFieldInfoPtr_CenOIBLumXoRHIlGYDdeaytfNkiW;

			// Token: 0x04000D26 RID: 3366
			private static readonly IntPtr NativeFieldInfoPtr_kZNWWyfboxonkBvvdpjJjhYkfnr;

			// Token: 0x04000D27 RID: 3367
			private static readonly IntPtr NativeFieldInfoPtr_qCyeROasFnJmaEJMACZydOijuQgZ;

			// Token: 0x04000D28 RID: 3368
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentButtonValues_Public_get_Il2CppStructArray_1_Boolean_0;

			// Token: 0x04000D29 RID: 3369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_UpdateLoopSetting_0;

			// Token: 0x04000D2A RID: 3370
			private static readonly IntPtr NativeMethodInfoPtr_TMKRneAcTZDgoTcAvbZAIQuPJOX_Public_Void_0;

			// Token: 0x04000D2B RID: 3371
			private static readonly IntPtr NativeMethodInfoPtr_tChsqfLBbuaRDkpHTYDeKpSkXYu_Public_Void_0;

			// Token: 0x04000D2C RID: 3372
			private static readonly IntPtr NativeMethodInfoPtr_HGoylHCPNNCdnbJqcVqEhcxOqeE_Public_Void_0;

			// Token: 0x04000D2D RID: 3373
			private static readonly IntPtr NativeMethodInfoPtr_aCpqPWTyANbPQOqZthrdsbSMBCo_Public_Void_0;

			// Token: 0x04000D2E RID: 3374
			private static readonly IntPtr NativeMethodInfoPtr_GcJaKEnlQnOjISzwjPTvhJKDTcd_Public_Boolean_NyyZSYJJkzTnYfWzTqOjsIHfWbL_0;

			// Token: 0x04000D2F RID: 3375
			private static readonly IntPtr NativeMethodInfoPtr_hTtCUpDInQXcBbpGVpdQRTQcaxe_Public_Void_Single_Int32_0;

			// Token: 0x04000D30 RID: 3376
			private static readonly IntPtr NativeMethodInfoPtr_iVBjsncoPGAPJQtxTaptiYByMnw_Public_Void_0;

			// Token: 0x04000D31 RID: 3377
			private static readonly IntPtr NativeMethodInfoPtr_NsRBDIKgGXKljkECzQKRmXRfWVBH_Public_Void_0;

			// Token: 0x04000D32 RID: 3378
			private static readonly IntPtr NativeMethodInfoPtr_GWsnXnzzSKbYUFFsKGHcxraefnFk_Public_Void_0;

			// Token: 0x04000D33 RID: 3379
			private static readonly IntPtr NativeMethodInfoPtr_phnkXyPOSbdFAOVqgiwaBtHToMl_Public_Void_0;

			// Token: 0x04000D34 RID: 3380
			private static readonly IntPtr NativeMethodInfoPtr_iLdnIMboLXykaDilblyvDakkDiY_Private_Void_0;

			// Token: 0x04000D35 RID: 3381
			private static readonly IntPtr NativeMethodInfoPtr_JTHxIKmTZsDNMTgLAPKGTpAlseH_Private_Void_0;

			// Token: 0x04000D36 RID: 3382
			private static readonly IntPtr NativeMethodInfoPtr_tSYaDkkwGqTaaQfYCSyLFiqPlxv_Private_Void_0;

			// Token: 0x04000D37 RID: 3383
			private static readonly IntPtr NativeMethodInfoPtr_ctFPaNJzaxwJnbRfsScacLayEbT_Private_Static_Void_RingBuffer_1_UDRonmQIbhwuVcbmlgzfpmqddNE_tzQKWxDhNEWjpkwRtFOXAbdpqPv_byref_Double_0;

			// Token: 0x04000D38 RID: 3384
			private static readonly IntPtr NativeMethodInfoPtr_MwiHFiVjLkICjFPkuuCjVQVnbFuK_Private_Static_Void_tzQKWxDhNEWjpkwRtFOXAbdpqPv_UDRonmQIbhwuVcbmlgzfpmqddNE_byref_Double_0;

			// Token: 0x04000D39 RID: 3385
			private static readonly IntPtr NativeMethodInfoPtr_PRQEoVVZSpMeshjOAdQuWfumrFp_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;

			// Token: 0x04000D3A RID: 3386
			private static readonly IntPtr NativeMethodInfoPtr_QsFdWGOVyzVLCoRdvLwLoVKVDlq_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_Double_LowLevelInputEvent_0;

			// Token: 0x04000D3B RID: 3387
			private static readonly IntPtr NativeMethodInfoPtr_bgxnLoCaLzkMBdCRfSMDAUZklDE_Private_Void_byref_lWGqplCPfeqSqYQMnGJhAaJXrqX_byref_LowLevelInputEvent_0;

			// Token: 0x04000D3C RID: 3388
			private static readonly IntPtr NativeMethodInfoPtr_vGIDntSyHOcwKzWObiWxnUfsrtQ_Private_Static_Boolean_Int32_Int32_0;

			// Token: 0x04000D3D RID: 3389
			private static readonly IntPtr NativeMethodInfoPtr_NvDtjMUtkOKqLAEsUOgHsaWxBCYA_Private_Void_0;

			// Token: 0x04000D3E RID: 3390
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000D3F RID: 3391
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04000D40 RID: 3392
			private static readonly IntPtr NativeMethodInfoPtr_QRqHkxHQdTOvmTIyHpJqpqzNcTZi_Protected_Virtual_New_Void_Boolean_0;

			// Token: 0x04000D41 RID: 3393
			private static readonly IntPtr NativeMethodInfoPtr_giTkLqleHbFHnWmDqeZsZmbNCBJH_Public_Static_Single_Int32_0;

			// Token: 0x04000D42 RID: 3394
			private static readonly IntPtr NativeMethodInfoPtr_pltkvMqNemcDhVtZbJqoQwkvjBt_Public_Static_Single_Int32_0;

			// Token: 0x04000D43 RID: 3395
			private static readonly IntPtr NativeMethodInfoPtr_KmdNDXnZEjTlSQlWVhOSuBfvaMYE_Private_Static_Boolean_lWGqplCPfeqSqYQMnGJhAaJXrqX_lWGqplCPfeqSqYQMnGJhAaJXrqX_0;
		}

		// Token: 0x020000C8 RID: 200
		[OriginalName("Rewired_Windows.dll", "", "NyyZSYJJkzTnYfWzTqOjsIHfWbL")]
		public enum NyyZSYJJkzTnYfWzTqOjsIHfWbL
		{
			// Token: 0x04000D45 RID: 3397
			oebROCdfZbfwwyNhjFlyvvheMjJ,
			// Token: 0x04000D46 RID: 3398
			AAZDanSzsbTiFogNKwQlDRPPAVO
		}
	}
}
