using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200005F RID: 95
	public class ControllerWithAxes : ControllerWithMap
	{
		// Token: 0x06000DDA RID: 3546 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerWithAxes()
		{
			Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerWithAxes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr);
			ControllerWithAxes.NativeFieldInfoPtr__axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "_axisCount");
			ControllerWithAxes.NativeFieldInfoPtr__axis2DCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "_axis2DCount");
			ControllerWithAxes.NativeFieldInfoPtr_axes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "axes");
			ControllerWithAxes.NativeFieldInfoPtr_axes_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "axes_readOnly");
			ControllerWithAxes.NativeFieldInfoPtr_axes2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "axes2D");
			ControllerWithAxes.NativeFieldInfoPtr_axes2D_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "axes2D_readOnly");
			ControllerWithAxes.NativeFieldInfoPtr__calibrationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "_calibrationMap");
			ControllerWithAxes.NativeFieldInfoPtr_NfyaPNabLXuXxDlaMNphFhrWRZDr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "NfyaPNabLXuXxDlaMNphFhrWRZDr");
			ControllerWithAxes.NativeFieldInfoPtr_wWEecEgKhfvXWTUSJKMrvPaEUKDI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "wWEecEgKhfvXWTUSJKMrvPaEUKDI");
			ControllerWithAxes.NativeFieldInfoPtr_hpHTMjNbIaoFPKTmLobXcCadeHaH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "hpHTMjNbIaoFPKTmLobXcCadeHaH");
			ControllerWithAxes.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665391);
			ControllerWithAxes.NativeMethodInfoPtr_get_axis2DCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665392);
			ControllerWithAxes.NativeMethodInfoPtr_get_Axes_Public_get_IList_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665393);
			ControllerWithAxes.NativeMethodInfoPtr_get_Axes2D_Public_get_IList_1_Axis2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665394);
			ControllerWithAxes.NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665395);
			ControllerWithAxes.NativeMethodInfoPtr_get_AxisElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665396);
			ControllerWithAxes.NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665397);
			ControllerWithAxes.NativeMethodInfoPtr_GetElementById_Public_Virtual_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665398);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisIndexById_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665399);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxis_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665400);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisPrev_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665401);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRaw_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665402);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawPrev_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665403);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeActive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665404);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeInactive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665405);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeActive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665406);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeInactive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665407);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeActive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665408);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeInactive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665409);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeActive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665410);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeInactive_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665411);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisById_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665412);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisPrevById_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665413);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawById_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665414);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawPrevById_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665415);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeActiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665416);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeInactiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665417);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeActiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665418);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeInactiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665419);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeActiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665420);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeInactiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665421);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeActiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665422);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeInactiveById_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665423);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665424);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxis2DPrev_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665425);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxis2DRaw_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665426);
			ControllerWithAxes.NativeMethodInfoPtr_GetAxis2DRawPrev_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665427);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665428);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665429);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665430);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665431);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisActive_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665432);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisActive_Public_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665433);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisChanged_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665434);
			ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisChanged_Public_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665435);
			ControllerWithAxes.NativeMethodInfoPtr_PollForFirstElement_Public_Virtual_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665436);
			ControllerWithAxes.NativeMethodInfoPtr_PollForFirstElementDown_Public_Virtual_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665437);
			ControllerWithAxes.NativeMethodInfoPtr_PollForFirstAxis_Public_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665438);
			ControllerWithAxes.NativeMethodInfoPtr_PollForAllElements_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665439);
			ControllerWithAxes.NativeMethodInfoPtr_PollForAllElementsDown_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665440);
			ControllerWithAxes.NativeMethodInfoPtr_PollForAllAxes_Public_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665441);
			ControllerWithAxes.NativeMethodInfoPtr_iKslTFbdtnmlXhfMIhnMCfgHTRh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665442);
			ControllerWithAxes.NativeMethodInfoPtr_IsPolledAxisActive_Protected_Virtual_New_Boolean_Int32_byref_Pole_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665443);
			ControllerWithAxes.NativeMethodInfoPtr_ImportCalibrationMapFromXmlString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665444);
			ControllerWithAxes.NativeMethodInfoPtr_ImportCalibrationMapFromJsonString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665445);
			ControllerWithAxes.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665446);
			ControllerWithAxes.NativeMethodInfoPtr_sCMjMRGXsuEXkgTrdvMMfLUhfLw_Internal_Boolean_ActionElementMap_Int32_Boolean_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665447);
			ControllerWithAxes.NativeMethodInfoPtr_pZoQVaXjWpxKnkHUeJUpyVawiKT_Internal_Virtual_Void_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665448);
			ControllerWithAxes.NativeMethodInfoPtr_RliirvzCZqWXcPEGpRIuiOoLMRg_Internal_Virtual_Void_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665449);
			ControllerWithAxes.NativeMethodInfoPtr_MQqoBmcUfycuhWBLzSVrozxTTIO_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665450);
			ControllerWithAxes.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665451);
			ControllerWithAxes.NativeMethodInfoPtr_GYLzlteQGjICVoSfKEGOiJdARHev_Private_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665452);
			ControllerWithAxes.NativeMethodInfoPtr_ZkpWgLgYsqnxQihYOYbxIAFsQgq_Private_IEnumerable_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, 100665453);
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0005EADC File Offset: 0x0005CCDC
		public unsafe int axisCount
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 254442, RefRangeEnd = 254456, XrefRangeStart = 254438, XrefRangeEnd = 254442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0005EB18 File Offset: 0x0005CD18
		public unsafe int axis2DCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 254460, RefRangeEnd = 254462, XrefRangeStart = 254456, XrefRangeEnd = 254460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_get_axis2DCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0005EB54 File Offset: 0x0005CD54
		public unsafe IList<Controller.Axis> Axes
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254467, RefRangeEnd = 254473, XrefRangeStart = 254462, XrefRangeEnd = 254467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_get_Axes_Public_get_IList_1_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Axis>>(intPtr3) : null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0005EB94 File Offset: 0x0005CD94
		public unsafe IList<Controller.Axis2D> Axes2D
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254473, XrefRangeEnd = 254478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_get_Axes2D_Public_get_IList_1_Axis2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Controller.Axis2D>>(intPtr3) : null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0005EBD4 File Offset: 0x0005CDD4
		public unsafe CalibrationMap calibrationMap
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 254482, RefRangeEnd = 254514, XrefRangeStart = 254478, XrefRangeEnd = 254482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0005EC14 File Offset: 0x0005CE14
		public unsafe IList<ControllerElementIdentifier> AxisElementIdentifiers
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 254519, RefRangeEnd = 254533, XrefRangeStart = 254514, XrefRangeEnd = 254519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_get_AxisElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0005EC54 File Offset: 0x0005CE54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254633, RefRangeEnd = 254637, XrefRangeStart = 254533, XrefRangeEnd = 254633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerWithAxes(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int axisCount, int buttonCount, Il2CppStructArray<bool> isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareTypeGuid;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isButtonPressureSensitive);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0005ED6C File Offset: 0x0005CF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254637, XrefRangeEnd = 254646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Element GetElementById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_GetElementById_Public_Virtual_Element_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0005EDC4 File Offset: 0x0005CFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254646, XrefRangeEnd = 254650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisIndexById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisIndexById_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0005EE10 File Offset: 0x0005D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254650, XrefRangeEnd = 254657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxis_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0005EE5C File Offset: 0x0005D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254657, XrefRangeEnd = 254664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisPrev(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisPrev_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0005EEA8 File Offset: 0x0005D0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254664, XrefRangeEnd = 254671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRaw(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRaw_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254671, XrefRangeEnd = 254678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRawPrev(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawPrev_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0005EF40 File Offset: 0x0005D140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254678, XrefRangeEnd = 254685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisTimeActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeActive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0005EF8C File Offset: 0x0005D18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254685, XrefRangeEnd = 254692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisTimeInactive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeInactive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0005EFD8 File Offset: 0x0005D1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254692, XrefRangeEnd = 254699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisLastTimeActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeActive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0005F024 File Offset: 0x0005D224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254699, XrefRangeEnd = 254706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisLastTimeInactive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeInactive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0005F070 File Offset: 0x0005D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254706, XrefRangeEnd = 254713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawTimeActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeActive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254713, XrefRangeEnd = 254720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawTimeInactive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeInactive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0005F108 File Offset: 0x0005D308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254720, XrefRangeEnd = 254727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawLastTimeActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeActive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0005F154 File Offset: 0x0005D354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254727, XrefRangeEnd = 254734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawLastTimeInactive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeInactive_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254734, XrefRangeEnd = 254738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisById_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0005F1EC File Offset: 0x0005D3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254738, XrefRangeEnd = 254742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisPrevById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisPrevById_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0005F238 File Offset: 0x0005D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254742, XrefRangeEnd = 254746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRawById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawById_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0005F284 File Offset: 0x0005D484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254746, XrefRangeEnd = 254750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRawPrevById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawPrevById_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0005F2D0 File Offset: 0x0005D4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254750, XrefRangeEnd = 254754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisTimeActiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeActiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0005F31C File Offset: 0x0005D51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254754, XrefRangeEnd = 254758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisTimeInactiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisTimeInactiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0005F368 File Offset: 0x0005D568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254758, XrefRangeEnd = 254762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisLastTimeActiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeActiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254762, XrefRangeEnd = 254766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisLastTimeInactiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisLastTimeInactiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0005F400 File Offset: 0x0005D600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254766, XrefRangeEnd = 254770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawTimeActiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeActiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0005F44C File Offset: 0x0005D64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254770, XrefRangeEnd = 254774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawTimeInactiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawTimeInactiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0005F498 File Offset: 0x0005D698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254774, XrefRangeEnd = 254778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawLastTimeActiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeActiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0005F4E4 File Offset: 0x0005D6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254778, XrefRangeEnd = 254782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawLastTimeInactiveById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxisRawLastTimeInactiveById_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0005F530 File Offset: 0x0005D730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254782, XrefRangeEnd = 254787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAxis2D(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0005F57C File Offset: 0x0005D77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254787, XrefRangeEnd = 254792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAxis2DPrev(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxis2DPrev_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0005F5C8 File Offset: 0x0005D7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254792, XrefRangeEnd = 254812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAxis2DRaw(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxis2DRaw_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0005F614 File Offset: 0x0005D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254812, XrefRangeEnd = 254832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAxis2DRawPrev(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetAxis2DRawPrev_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0005F660 File Offset: 0x0005D860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254832, XrefRangeEnd = 254838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double GetLastTimeActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0005F6A8 File Offset: 0x0005D8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254838, XrefRangeEnd = 254844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double GetLastTimeActive(bool useRawValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useRawValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		[CallerCount(0)]
		public unsafe override double GetLastTimeAnyElementChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0005F744 File Offset: 0x0005D944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254844, XrefRangeEnd = 254857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double GetLastTimeAnyElementChanged(bool useRawValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useRawValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0005F798 File Offset: 0x0005D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254857, XrefRangeEnd = 254858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLastTimeAnyAxisActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisActive_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254866, RefRangeEnd = 254868, XrefRangeStart = 254858, XrefRangeEnd = 254866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLastTimeAnyAxisActive(bool useRawValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useRawValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisActive_Public_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0005F820 File Offset: 0x0005DA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254868, XrefRangeEnd = 254869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLastTimeAnyAxisChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisChanged_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0005F85C File Offset: 0x0005DA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254877, RefRangeEnd = 254879, XrefRangeStart = 254869, XrefRangeEnd = 254877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetLastTimeAnyAxisChanged(bool useRawValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useRawValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GetLastTimeAnyAxisChanged_Public_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0005F8A8 File Offset: 0x0005DAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254879, XrefRangeEnd = 254888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ControllerPollingInfo PollForFirstElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_PollForFirstElement_Public_Virtual_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0005F8EC File Offset: 0x0005DAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254888, XrefRangeEnd = 254897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ControllerPollingInfo PollForFirstElementDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_PollForFirstElementDown_Public_Virtual_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0005F930 File Offset: 0x0005DB30
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 254906, RefRangeEnd = 254927, XrefRangeStart = 254897, XrefRangeEnd = 254906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerPollingInfo PollForFirstAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_PollForFirstAxis_Public_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0005F968 File Offset: 0x0005DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254927, XrefRangeEnd = 254932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ControllerPollingInfo> PollForAllElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_PollForAllElements_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0005F9B4 File Offset: 0x0005DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254932, XrefRangeEnd = 254937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ControllerPollingInfo> PollForAllElementsDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_PollForAllElementsDown_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0005FA00 File Offset: 0x0005DC00
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 254942, RefRangeEnd = 254956, XrefRangeStart = 254937, XrefRangeEnd = 254942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ControllerPollingInfo> PollForAllAxes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_PollForAllAxes_Public_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0005FA40 File Offset: 0x0005DC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254965, RefRangeEnd = 254967, XrefRangeStart = 254956, XrefRangeEnd = 254965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void iKslTFbdtnmlXhfMIhnMCfgHTRh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_iKslTFbdtnmlXhfMIhnMCfgHTRh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0005FA74 File Offset: 0x0005DC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254967, XrefRangeEnd = 254976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pole;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &elementIdentifierId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_IsPolledAxisActive_Protected_Virtual_New_Boolean_Int32_byref_Pole_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254984, RefRangeEnd = 254986, XrefRangeStart = 254976, XrefRangeEnd = 254984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportCalibrationMapFromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_ImportCalibrationMapFromXmlString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0005FB34 File Offset: 0x0005DD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254986, XrefRangeEnd = 254994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportCalibrationMapFromJsonString(string jsonString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_ImportCalibrationMapFromJsonString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0005FB84 File Offset: 0x0005DD84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255027, RefRangeEnd = 255029, XrefRangeStart = 254994, XrefRangeEnd = 255027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0005FBD0 File Offset: 0x0005DDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255029, XrefRangeEnd = 255041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool sCMjMRGXsuEXkgTrdvMMfLUhfLw(ActionElementMap A_1, int A_2, bool A_3, bool A_4, out float A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_sCMjMRGXsuEXkgTrdvMMfLUhfLw_Internal_Boolean_ActionElementMap_Int32_Boolean_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0005FC58 File Offset: 0x0005DE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255041, XrefRangeEnd = 255060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void pZoQVaXjWpxKnkHUeJUpyVawiKT(ControllerMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_pZoQVaXjWpxKnkHUeJUpyVawiKT_Internal_Virtual_Void_ControllerMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0005FCA8 File Offset: 0x0005DEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255060, XrefRangeEnd = 255062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RliirvzCZqWXcPEGpRIuiOoLMRg(ControllerMap A_1, ActionElementMap A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_RliirvzCZqWXcPEGpRIuiOoLMRg_Internal_Virtual_Void_ControllerMap_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0005FD08 File Offset: 0x0005DF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255074, RefRangeEnd = 255075, XrefRangeStart = 255062, XrefRangeEnd = 255074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MQqoBmcUfycuhWBLzSVrozxTTIO()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_MQqoBmcUfycuhWBLzSVrozxTTIO_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0005FD3C File Offset: 0x0005DF3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255077, RefRangeEnd = 255079, XrefRangeStart = 255075, XrefRangeEnd = 255077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerWithAxes.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0005FD78 File Offset: 0x0005DF78
		[CallerCount(0)]
		public unsafe IEnumerable<ControllerPollingInfo> GYLzlteQGjICVoSfKEGOiJdARHev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_GYLzlteQGjICVoSfKEGOiJdARHev_Private_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0005FDB8 File Offset: 0x0005DFB8
		[CallerCount(0)]
		public unsafe IEnumerable<ControllerPollingInfo> ZkpWgLgYsqnxQihYOYbxIAFsQgq()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.NativeMethodInfoPtr_ZkpWgLgYsqnxQihYOYbxIAFsQgq_Private_IEnumerable_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00006D01 File Offset: 0x00004F01
		public ControllerWithAxes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0005FDF8 File Offset: 0x0005DFF8
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00006D0A File Offset: 0x00004F0A
		public unsafe int _axisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr__axisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr__axisCount)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0005FE20 File Offset: 0x0005E020
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00006D25 File Offset: 0x00004F25
		public unsafe int _axis2DCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr__axis2DCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr__axis2DCount)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0005FE48 File Offset: 0x0005E048
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00006D40 File Offset: 0x00004F40
		public unsafe Il2CppReferenceArray<Controller.Axis> axes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.Axis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0005FE78 File Offset: 0x0005E078
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00006D5F File Offset: 0x00004F5F
		public unsafe ReadOnlyCollection<Controller.Axis> axes_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Axis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0005FEA8 File Offset: 0x0005E0A8
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x00006D7E File Offset: 0x00004F7E
		public unsafe Il2CppReferenceArray<Controller.Axis2D> axes2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Controller.Axis2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0005FED8 File Offset: 0x0005E0D8
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00006D9D File Offset: 0x00004F9D
		public unsafe ReadOnlyCollection<Controller.Axis2D> axes2D_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes2D_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Controller.Axis2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_axes2D_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0005FF08 File Offset: 0x0005E108
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00006DBC File Offset: 0x00004FBC
		public unsafe CalibrationMap _calibrationMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr__calibrationMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr__calibrationMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0005FF38 File Offset: 0x0005E138
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00006DDB File Offset: 0x00004FDB
		public unsafe Il2CppStructArray<float> NfyaPNabLXuXxDlaMNphFhrWRZDr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_NfyaPNabLXuXxDlaMNphFhrWRZDr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_NfyaPNabLXuXxDlaMNphFhrWRZDr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0005FF68 File Offset: 0x0005E168
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00006DFA File Offset: 0x00004FFA
		public unsafe uint wWEecEgKhfvXWTUSJKMrvPaEUKDI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_wWEecEgKhfvXWTUSJKMrvPaEUKDI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_wWEecEgKhfvXWTUSJKMrvPaEUKDI)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0005FF90 File Offset: 0x0005E190
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00006E15 File Offset: 0x00005015
		public unsafe Func<int, int> hpHTMjNbIaoFPKTmLobXcCadeHaH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_hpHTMjNbIaoFPKTmLobXcCadeHaH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.NativeFieldInfoPtr_hpHTMjNbIaoFPKTmLobXcCadeHaH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr__axisCount;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr__axis2DCount;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_axes;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_axes_readOnly;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_axes2D;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_axes2D_readOnly;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr__calibrationMap;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_NfyaPNabLXuXxDlaMNphFhrWRZDr;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_wWEecEgKhfvXWTUSJKMrvPaEUKDI;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_hpHTMjNbIaoFPKTmLobXcCadeHaH;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_get_axis2DCount_Public_get_Int32_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_get_Axes_Public_get_IList_1_Axis_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_get_Axes2D_Public_get_IList_1_Axis2D_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisElementIdentifiers_Public_get_IList_1_ControllerElementIdentifier_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_GetElementById_Public_Virtual_Element_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisIndexById_Public_Int32_Int32_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Single_Int32_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisPrev_Public_Single_Int32_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Single_Int32_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawPrev_Public_Single_Int32_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTimeActive_Public_Double_Int32_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTimeInactive_Public_Double_Int32_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisLastTimeActive_Public_Double_Int32_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisLastTimeInactive_Public_Double_Int32_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawTimeActive_Public_Double_Int32_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawTimeInactive_Public_Double_Int32_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawLastTimeActive_Public_Double_Int32_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawLastTimeInactive_Public_Double_Int32_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisById_Public_Single_Int32_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisPrevById_Public_Single_Int32_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawById_Public_Single_Int32_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawPrevById_Public_Single_Int32_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTimeActiveById_Public_Double_Int32_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTimeInactiveById_Public_Double_Int32_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisLastTimeActiveById_Public_Double_Int32_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisLastTimeInactiveById_Public_Double_Int32_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawTimeActiveById_Public_Double_Int32_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawTimeInactiveById_Public_Double_Int32_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawLastTimeActiveById_Public_Double_Int32_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawLastTimeInactiveById_Public_Double_Int32_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2D_Public_Vector2_Int32_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2DPrev_Public_Vector2_Int32_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2DRaw_Public_Vector2_Int32_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2DRawPrev_Public_Vector2_Int32_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_Double_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeActive_Public_Virtual_Double_Boolean_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_Double_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyElementChanged_Public_Virtual_Double_Boolean_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyAxisActive_Public_Double_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyAxisActive_Public_Double_Boolean_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyAxisChanged_Public_Double_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_GetLastTimeAnyAxisChanged_Public_Double_Boolean_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstElement_Public_Virtual_ControllerPollingInfo_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstElementDown_Public_Virtual_ControllerPollingInfo_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_PollForFirstAxis_Public_ControllerPollingInfo_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllElements_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllElementsDown_Public_Virtual_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_PollForAllAxes_Public_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_iKslTFbdtnmlXhfMIhnMCfgHTRh_Private_Void_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_IsPolledAxisActive_Protected_Virtual_New_Boolean_Int32_byref_Pole_byref_Int32_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_ImportCalibrationMapFromXmlString_Public_Boolean_String_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_ImportCalibrationMapFromJsonString_Public_Boolean_String_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_sCMjMRGXsuEXkgTrdvMMfLUhfLw_Internal_Boolean_ActionElementMap_Int32_Boolean_Boolean_byref_Single_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_pZoQVaXjWpxKnkHUeJUpyVawiKT_Internal_Virtual_Void_ControllerMap_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_RliirvzCZqWXcPEGpRIuiOoLMRg_Internal_Virtual_Void_ControllerMap_ActionElementMap_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_MQqoBmcUfycuhWBLzSVrozxTTIO_Internal_Void_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_GYLzlteQGjICVoSfKEGOiJdARHev_Private_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_ZkpWgLgYsqnxQihYOYbxIAFsQgq_Private_IEnumerable_1_ControllerPollingInfo_0;

		// Token: 0x02000282 RID: 642
		public sealed class VVyEHnyGGJpDZxLEWEQJkieFcSM : global::Il2CppSystem.Object
		{
			// Token: 0x06003AAB RID: 15019 RVA: 0x0011BD5C File Offset: 0x00119F5C
			// Note: this type is marked as 'beforefieldinit'.
			static VVyEHnyGGJpDZxLEWEQJkieFcSM()
			{
				Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "VVyEHnyGGJpDZxLEWEQJkieFcSM");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_BpyyrnSmNhblvJAfWYtmDwYdPrQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "BpyyrnSmNhblvJAfWYtmDwYdPrQ");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_HDUtXBwMkEVkDXNtflfdCxojmrZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "HDUtXBwMkEVkDXNtflfdCxojmrZ");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "hCZHtxbCjMMeLdTSELlNlJExQXHx");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_AVoUccAgaWmJtyhnWOpwmmJTado = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, "AVoUccAgaWmJtyhnWOpwmmJTado");
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665454);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665455);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665456);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665457);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665458);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665459);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665460);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665461);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_fmTCpxhHCscZFeJLAfJlfuuJbHCL_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665462);
				ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_xYlbMieGahDMmWkdYgiqAdSjREyi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr, 100665463);
			}

			// Token: 0x06003AAC RID: 15020 RVA: 0x0011BEF0 File Offset: 0x0011A0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254303, XrefRangeEnd = 254306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003AAD RID: 15021 RVA: 0x0011BF30 File Offset: 0x0011A130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003AAE RID: 15022 RVA: 0x0011BF70 File Offset: 0x0011A170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254306, XrefRangeEnd = 254337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011AD RID: 4525
			// (get) Token: 0x06003AAF RID: 15023 RVA: 0x0011BFAC File Offset: 0x0011A1AC
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003AB0 RID: 15024 RVA: 0x0011BFE4 File Offset: 0x0011A1E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254337, XrefRangeEnd = 254342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AB1 RID: 15025 RVA: 0x0011C018 File Offset: 0x0011A218
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254348, RefRangeEnd = 254349, XrefRangeStart = 254342, XrefRangeEnd = 254348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011AE RID: 4526
			// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x0011C04C File Offset: 0x0011A24C
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254349, XrefRangeEnd = 254352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003AB3 RID: 15027 RVA: 0x0011C08C File Offset: 0x0011A28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VVyEHnyGGJpDZxLEWEQJkieFcSM(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003AB4 RID: 15028 RVA: 0x0011C0D4 File Offset: 0x0011A2D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254355, RefRangeEnd = 254356, XrefRangeStart = 254352, XrefRangeEnd = 254355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void fmTCpxhHCscZFeJLAfJlfuuJbHCL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_fmTCpxhHCscZFeJLAfJlfuuJbHCL_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AB5 RID: 15029 RVA: 0x0011C108 File Offset: 0x0011A308
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254359, RefRangeEnd = 254360, XrefRangeStart = 254356, XrefRangeEnd = 254359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xYlbMieGahDMmWkdYgiqAdSjREyi()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeMethodInfoPtr_xYlbMieGahDMmWkdYgiqAdSjREyi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AB6 RID: 15030 RVA: 0x00014BA1 File Offset: 0x00012DA1
			public VVyEHnyGGJpDZxLEWEQJkieFcSM(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011A5 RID: 4517
			// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x0011C13C File Offset: 0x0011A33C
			// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x00014BAA File Offset: 0x00012DAA
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011A6 RID: 4518
			// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x0011C16C File Offset: 0x0011A36C
			// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00014BD8 File Offset: 0x00012DD8
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170011A7 RID: 4519
			// (get) Token: 0x06003ABB RID: 15035 RVA: 0x0011C194 File Offset: 0x0011A394
			// (set) Token: 0x06003ABC RID: 15036 RVA: 0x00014BF3 File Offset: 0x00012DF3
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170011A8 RID: 4520
			// (get) Token: 0x06003ABD RID: 15037 RVA: 0x0011C1BC File Offset: 0x0011A3BC
			// (set) Token: 0x06003ABE RID: 15038 RVA: 0x00014C0E File Offset: 0x00012E0E
			public unsafe ControllerWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A9 RID: 4521
			// (get) Token: 0x06003ABF RID: 15039 RVA: 0x0011C1EC File Offset: 0x0011A3EC
			// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x00014C2D File Offset: 0x00012E2D
			public ControllerPollingInfo BpyyrnSmNhblvJAfWYtmDwYdPrQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_BpyyrnSmNhblvJAfWYtmDwYdPrQ);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_BpyyrnSmNhblvJAfWYtmDwYdPrQ), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011AA RID: 4522
			// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x0011C21C File Offset: 0x0011A41C
			// (set) Token: 0x06003AC2 RID: 15042 RVA: 0x00014C5B File Offset: 0x00012E5B
			public ControllerPollingInfo HDUtXBwMkEVkDXNtflfdCxojmrZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_HDUtXBwMkEVkDXNtflfdCxojmrZ);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_HDUtXBwMkEVkDXNtflfdCxojmrZ), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x0011C24C File Offset: 0x0011A44C
			// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x00014C89 File Offset: 0x00012E89
			public unsafe IEnumerator<ControllerPollingInfo> hCZHtxbCjMMeLdTSELlNlJExQXHx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x0011C27C File Offset: 0x0011A47C
			// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x00014CA8 File Offset: 0x00012EA8
			public unsafe IEnumerator<ControllerPollingInfo> AVoUccAgaWmJtyhnWOpwmmJTado
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_AVoUccAgaWmJtyhnWOpwmmJTado);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.VVyEHnyGGJpDZxLEWEQJkieFcSM.NativeFieldInfoPtr_AVoUccAgaWmJtyhnWOpwmmJTado), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003153 RID: 12627
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003154 RID: 12628
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003155 RID: 12629
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003156 RID: 12630
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003157 RID: 12631
			private static readonly IntPtr NativeFieldInfoPtr_BpyyrnSmNhblvJAfWYtmDwYdPrQ;

			// Token: 0x04003158 RID: 12632
			private static readonly IntPtr NativeFieldInfoPtr_HDUtXBwMkEVkDXNtflfdCxojmrZ;

			// Token: 0x04003159 RID: 12633
			private static readonly IntPtr NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx;

			// Token: 0x0400315A RID: 12634
			private static readonly IntPtr NativeFieldInfoPtr_AVoUccAgaWmJtyhnWOpwmmJTado;

			// Token: 0x0400315B RID: 12635
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x0400315C RID: 12636
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400315D RID: 12637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400315E RID: 12638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x0400315F RID: 12639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003160 RID: 12640
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003161 RID: 12641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003162 RID: 12642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003163 RID: 12643
			private static readonly IntPtr NativeMethodInfoPtr_fmTCpxhHCscZFeJLAfJlfuuJbHCL_Private_Void_0;

			// Token: 0x04003164 RID: 12644
			private static readonly IntPtr NativeMethodInfoPtr_xYlbMieGahDMmWkdYgiqAdSjREyi_Private_Void_0;
		}

		// Token: 0x02000283 RID: 643
		public sealed class gXhrYHIjejvPYBUgeOEbMPWTQZD : global::Il2CppSystem.Object
		{
			// Token: 0x06003AC7 RID: 15047 RVA: 0x0011C2AC File Offset: 0x0011A4AC
			// Note: this type is marked as 'beforefieldinit'.
			static gXhrYHIjejvPYBUgeOEbMPWTQZD()
			{
				Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "gXhrYHIjejvPYBUgeOEbMPWTQZD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_poCqJJnDVbzZBJgYBdvzjGqtCi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "poCqJJnDVbzZBJgYBdvzjGqtCi");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_OLqxkeDqUHBqcEtlSRxUUmFlHwz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "OLqxkeDqUHBqcEtlSRxUUmFlHwz");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_MNJOfZeBpaHEMSXyNuDFqehPDAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "MNJOfZeBpaHEMSXyNuDFqehPDAK");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, "NQCAcSEbWyXboGJHalZSbUuDHmFS");
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665464);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665465);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665466);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665467);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665468);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665469);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665470);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665471);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_AGkZHpmCCFluSvHOfCqLkzrUHRiq_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665472);
				ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_agwJmkDDUPobHOhcpdLRunRaqeG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr, 100665473);
			}

			// Token: 0x06003AC8 RID: 15048 RVA: 0x0011C440 File Offset: 0x0011A640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254360, XrefRangeEnd = 254363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003AC9 RID: 15049 RVA: 0x0011C480 File Offset: 0x0011A680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003ACA RID: 15050 RVA: 0x0011C4C0 File Offset: 0x0011A6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254363, XrefRangeEnd = 254394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011B7 RID: 4535
			// (get) Token: 0x06003ACB RID: 15051 RVA: 0x0011C4FC File Offset: 0x0011A6FC
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003ACC RID: 15052 RVA: 0x0011C534 File Offset: 0x0011A734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254394, XrefRangeEnd = 254399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003ACD RID: 15053 RVA: 0x0011C568 File Offset: 0x0011A768
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254405, RefRangeEnd = 254406, XrefRangeStart = 254399, XrefRangeEnd = 254405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011B8 RID: 4536
			// (get) Token: 0x06003ACE RID: 15054 RVA: 0x0011C59C File Offset: 0x0011A79C
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254406, XrefRangeEnd = 254409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003ACF RID: 15055 RVA: 0x0011C5DC File Offset: 0x0011A7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe gXhrYHIjejvPYBUgeOEbMPWTQZD(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003AD0 RID: 15056 RVA: 0x0011C624 File Offset: 0x0011A824
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254412, RefRangeEnd = 254413, XrefRangeStart = 254409, XrefRangeEnd = 254412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AGkZHpmCCFluSvHOfCqLkzrUHRiq()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_AGkZHpmCCFluSvHOfCqLkzrUHRiq_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AD1 RID: 15057 RVA: 0x0011C658 File Offset: 0x0011A858
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254416, RefRangeEnd = 254417, XrefRangeStart = 254413, XrefRangeEnd = 254416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void agwJmkDDUPobHOhcpdLRunRaqeG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeMethodInfoPtr_agwJmkDDUPobHOhcpdLRunRaqeG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AD2 RID: 15058 RVA: 0x00014CC7 File Offset: 0x00012EC7
			public gXhrYHIjejvPYBUgeOEbMPWTQZD(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011AF RID: 4527
			// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x0011C68C File Offset: 0x0011A88C
			// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x00014CD0 File Offset: 0x00012ED0
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x0011C6BC File Offset: 0x0011A8BC
			// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x00014CFE File Offset: 0x00012EFE
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170011B1 RID: 4529
			// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x0011C6E4 File Offset: 0x0011A8E4
			// (set) Token: 0x06003AD8 RID: 15064 RVA: 0x00014D19 File Offset: 0x00012F19
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170011B2 RID: 4530
			// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x0011C70C File Offset: 0x0011A90C
			// (set) Token: 0x06003ADA RID: 15066 RVA: 0x00014D34 File Offset: 0x00012F34
			public unsafe ControllerWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x06003ADB RID: 15067 RVA: 0x0011C73C File Offset: 0x0011A93C
			// (set) Token: 0x06003ADC RID: 15068 RVA: 0x00014D53 File Offset: 0x00012F53
			public ControllerPollingInfo poCqJJnDVbzZBJgYBdvzjGqtCi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_poCqJJnDVbzZBJgYBdvzjGqtCi);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_poCqJJnDVbzZBJgYBdvzjGqtCi), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011B4 RID: 4532
			// (get) Token: 0x06003ADD RID: 15069 RVA: 0x0011C76C File Offset: 0x0011A96C
			// (set) Token: 0x06003ADE RID: 15070 RVA: 0x00014D81 File Offset: 0x00012F81
			public ControllerPollingInfo OLqxkeDqUHBqcEtlSRxUUmFlHwz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_OLqxkeDqUHBqcEtlSRxUUmFlHwz);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_OLqxkeDqUHBqcEtlSRxUUmFlHwz), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x06003ADF RID: 15071 RVA: 0x0011C79C File Offset: 0x0011A99C
			// (set) Token: 0x06003AE0 RID: 15072 RVA: 0x00014DAF File Offset: 0x00012FAF
			public unsafe IEnumerator<ControllerPollingInfo> MNJOfZeBpaHEMSXyNuDFqehPDAK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_MNJOfZeBpaHEMSXyNuDFqehPDAK);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_MNJOfZeBpaHEMSXyNuDFqehPDAK), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x0011C7CC File Offset: 0x0011A9CC
			// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x00014DCE File Offset: 0x00012FCE
			public unsafe IEnumerator<ControllerPollingInfo> NQCAcSEbWyXboGJHalZSbUuDHmFS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.gXhrYHIjejvPYBUgeOEbMPWTQZD.NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003165 RID: 12645
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003166 RID: 12646
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003167 RID: 12647
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003168 RID: 12648
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003169 RID: 12649
			private static readonly IntPtr NativeFieldInfoPtr_poCqJJnDVbzZBJgYBdvzjGqtCi;

			// Token: 0x0400316A RID: 12650
			private static readonly IntPtr NativeFieldInfoPtr_OLqxkeDqUHBqcEtlSRxUUmFlHwz;

			// Token: 0x0400316B RID: 12651
			private static readonly IntPtr NativeFieldInfoPtr_MNJOfZeBpaHEMSXyNuDFqehPDAK;

			// Token: 0x0400316C RID: 12652
			private static readonly IntPtr NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS;

			// Token: 0x0400316D RID: 12653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x0400316E RID: 12654
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400316F RID: 12655
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003170 RID: 12656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x04003171 RID: 12657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003172 RID: 12658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003173 RID: 12659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003174 RID: 12660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003175 RID: 12661
			private static readonly IntPtr NativeMethodInfoPtr_AGkZHpmCCFluSvHOfCqLkzrUHRiq_Private_Void_0;

			// Token: 0x04003176 RID: 12662
			private static readonly IntPtr NativeMethodInfoPtr_agwJmkDDUPobHOhcpdLRunRaqeG_Private_Void_0;
		}

		// Token: 0x02000284 RID: 644
		public sealed class jhDvoBmZbSWlbPczASoIMaPmwju : global::Il2CppSystem.Object
		{
			// Token: 0x06003AE3 RID: 15075 RVA: 0x0011C7FC File Offset: 0x0011A9FC
			// Note: this type is marked as 'beforefieldinit'.
			static jhDvoBmZbSWlbPczASoIMaPmwju()
			{
				Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerWithAxes>.NativeClassPtr, "jhDvoBmZbSWlbPczASoIMaPmwju");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_xSSWKJUIwwhFYPGppjkcvpmPAmP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "xSSWKJUIwwhFYPGppjkcvpmPAmP");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_iHkiCMqWeVFftuqkYfSmPqDpFcnA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "iHkiCMqWeVFftuqkYfSmPqDpFcnA");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_uCacyidFHnMKSfkAKgDDHZPRGxuA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, "uCacyidFHnMKSfkAKgDDHZPRGxuA");
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665474);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665475);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665476);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665477);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665478);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665479);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665480);
				ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr, 100665481);
			}

			// Token: 0x06003AE4 RID: 15076 RVA: 0x0011C954 File Offset: 0x0011AB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254417, XrefRangeEnd = 254420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerPollingInfo> System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerPollingInfo>>(intPtr3) : null;
			}

			// Token: 0x06003AE5 RID: 15077 RVA: 0x0011C994 File Offset: 0x0011AB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003AE6 RID: 15078 RVA: 0x0011C9D4 File Offset: 0x0011ABD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254420, XrefRangeEnd = 254430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x0011CA10 File Offset: 0x0011AC10
			public unsafe ControllerPollingInfo eQOjYWBVDjtNugCRnQImrgdgoxJ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ControllerPollingInfo(intPtr);
				}
			}

			// Token: 0x06003AE8 RID: 15080 RVA: 0x0011CA48 File Offset: 0x0011AC48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254430, XrefRangeEnd = 254435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AE9 RID: 15081 RVA: 0x0011CA7C File Offset: 0x0011AC7C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x06003AEA RID: 15082 RVA: 0x0011CAB0 File Offset: 0x0011ACB0
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254435, XrefRangeEnd = 254438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003AEB RID: 15083 RVA: 0x0011CAF0 File Offset: 0x0011ACF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe jhDvoBmZbSWlbPczASoIMaPmwju(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003AEC RID: 15084 RVA: 0x00014DED File Offset: 0x00012FED
			public jhDvoBmZbSWlbPczASoIMaPmwju(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011B9 RID: 4537
			// (get) Token: 0x06003AED RID: 15085 RVA: 0x0011CB38 File Offset: 0x0011AD38
			// (set) Token: 0x06003AEE RID: 15086 RVA: 0x00014DF6 File Offset: 0x00012FF6
			public ControllerPollingInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011BA RID: 4538
			// (get) Token: 0x06003AEF RID: 15087 RVA: 0x0011CB68 File Offset: 0x0011AD68
			// (set) Token: 0x06003AF0 RID: 15088 RVA: 0x00014E24 File Offset: 0x00013024
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170011BB RID: 4539
			// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x0011CB90 File Offset: 0x0011AD90
			// (set) Token: 0x06003AF2 RID: 15090 RVA: 0x00014E3F File Offset: 0x0001303F
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x0011CBB8 File Offset: 0x0011ADB8
			// (set) Token: 0x06003AF4 RID: 15092 RVA: 0x00014E5A File Offset: 0x0001305A
			public unsafe ControllerWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x0011CBE8 File Offset: 0x0011ADE8
			// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x00014E79 File Offset: 0x00013079
			public unsafe int xSSWKJUIwwhFYPGppjkcvpmPAmP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_xSSWKJUIwwhFYPGppjkcvpmPAmP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_xSSWKJUIwwhFYPGppjkcvpmPAmP)) = value;
				}
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x0011CC10 File Offset: 0x0011AE10
			// (set) Token: 0x06003AF8 RID: 15096 RVA: 0x00014E94 File Offset: 0x00013094
			public unsafe Pole iHkiCMqWeVFftuqkYfSmPqDpFcnA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_iHkiCMqWeVFftuqkYfSmPqDpFcnA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_iHkiCMqWeVFftuqkYfSmPqDpFcnA)) = value;
				}
			}

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x0011CC38 File Offset: 0x0011AE38
			// (set) Token: 0x06003AFA RID: 15098 RVA: 0x00014EAF File Offset: 0x000130AF
			public unsafe int uCacyidFHnMKSfkAKgDDHZPRGxuA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_uCacyidFHnMKSfkAKgDDHZPRGxuA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerWithAxes.jhDvoBmZbSWlbPczASoIMaPmwju.NativeFieldInfoPtr_uCacyidFHnMKSfkAKgDDHZPRGxuA)) = value;
				}
			}

			// Token: 0x04003177 RID: 12663
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003178 RID: 12664
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003179 RID: 12665
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x0400317A RID: 12666
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x0400317B RID: 12667
			private static readonly IntPtr NativeFieldInfoPtr_xSSWKJUIwwhFYPGppjkcvpmPAmP;

			// Token: 0x0400317C RID: 12668
			private static readonly IntPtr NativeFieldInfoPtr_iHkiCMqWeVFftuqkYfSmPqDpFcnA;

			// Token: 0x0400317D RID: 12669
			private static readonly IntPtr NativeFieldInfoPtr_uCacyidFHnMKSfkAKgDDHZPRGxuA;

			// Token: 0x0400317E RID: 12670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerPollingInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerPollingInfo_0;

			// Token: 0x0400317F RID: 12671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003180 RID: 12672
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003181 RID: 12673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerPollingInfo__get_Current_Private_Virtual_Final_New_get_ControllerPollingInfo_0;

			// Token: 0x04003182 RID: 12674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003183 RID: 12675
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003184 RID: 12676
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003185 RID: 12677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
