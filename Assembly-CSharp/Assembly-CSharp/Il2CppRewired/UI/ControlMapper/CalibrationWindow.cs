using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Integration.UnityUI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001EE RID: 494
	public class CalibrationWindow : Window
	{
		// Token: 0x06003A18 RID: 14872 RVA: 0x000D8D00 File Offset: 0x000D6F00
		// Note: this type is marked as 'beforefieldinit'.
		static CalibrationWindow()
		{
			Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "CalibrationWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr);
			CalibrationWindow.NativeFieldInfoPtr_minSensitivityOtherAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "minSensitivityOtherAxes");
			CalibrationWindow.NativeFieldInfoPtr_maxDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "maxDeadzone");
			CalibrationWindow.NativeFieldInfoPtr_rightContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "rightContentContainer");
			CalibrationWindow.NativeFieldInfoPtr_valueDisplayGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "valueDisplayGroup");
			CalibrationWindow.NativeFieldInfoPtr_calibratedValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "calibratedValueMarker");
			CalibrationWindow.NativeFieldInfoPtr_rawValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "rawValueMarker");
			CalibrationWindow.NativeFieldInfoPtr_calibratedZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "calibratedZeroMarker");
			CalibrationWindow.NativeFieldInfoPtr_deadzoneArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "deadzoneArea");
			CalibrationWindow.NativeFieldInfoPtr_deadzoneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "deadzoneSlider");
			CalibrationWindow.NativeFieldInfoPtr_zeroSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "zeroSlider");
			CalibrationWindow.NativeFieldInfoPtr_sensitivitySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "sensitivitySlider");
			CalibrationWindow.NativeFieldInfoPtr_invertToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "invertToggle");
			CalibrationWindow.NativeFieldInfoPtr_axisScrollAreaContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "axisScrollAreaContent");
			CalibrationWindow.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "doneButton");
			CalibrationWindow.NativeFieldInfoPtr_calibrateButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "calibrateButton");
			CalibrationWindow.NativeFieldInfoPtr_doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "doneButtonLabel");
			CalibrationWindow.NativeFieldInfoPtr_cancelButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "cancelButtonLabel");
			CalibrationWindow.NativeFieldInfoPtr_defaultButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "defaultButtonLabel");
			CalibrationWindow.NativeFieldInfoPtr_deadzoneSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "deadzoneSliderLabel");
			CalibrationWindow.NativeFieldInfoPtr_zeroSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "zeroSliderLabel");
			CalibrationWindow.NativeFieldInfoPtr_sensitivitySliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "sensitivitySliderLabel");
			CalibrationWindow.NativeFieldInfoPtr_invertToggleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "invertToggleLabel");
			CalibrationWindow.NativeFieldInfoPtr_calibrateButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "calibrateButtonLabel");
			CalibrationWindow.NativeFieldInfoPtr_axisButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "axisButtonPrefab");
			CalibrationWindow.NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "joystick");
			CalibrationWindow.NativeFieldInfoPtr_origCalibrationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "origCalibrationData");
			CalibrationWindow.NativeFieldInfoPtr_selectedAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "selectedAxis");
			CalibrationWindow.NativeFieldInfoPtr_origSelectedAxisCalibrationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "origSelectedAxisCalibrationData");
			CalibrationWindow.NativeFieldInfoPtr_displayAreaWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "displayAreaWidth");
			CalibrationWindow.NativeFieldInfoPtr_axisButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "axisButtons");
			CalibrationWindow.NativeFieldInfoPtr_buttonCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "buttonCallbacks");
			CalibrationWindow.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "playerId");
			CalibrationWindow.NativeFieldInfoPtr_rewiredStandaloneInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "rewiredStandaloneInputModule");
			CalibrationWindow.NativeFieldInfoPtr_menuHorizActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "menuHorizActionId");
			CalibrationWindow.NativeFieldInfoPtr_menuVertActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "menuVertActionId");
			CalibrationWindow.NativeFieldInfoPtr_minSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "minSensitivity");
			CalibrationWindow.NativeMethodInfoPtr_get_axisSelected_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668227);
			CalibrationWindow.NativeMethodInfoPtr_get_axisCalibration_Private_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668228);
			CalibrationWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668229);
			CalibrationWindow.NativeMethodInfoPtr_SetJoystick_Public_Void_Int32_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668230);
			CalibrationWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668231);
			CalibrationWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668232);
			CalibrationWindow.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668233);
			CalibrationWindow.NativeMethodInfoPtr_OnDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668234);
			CalibrationWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668235);
			CalibrationWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668236);
			CalibrationWindow.NativeMethodInfoPtr_OnCalibrate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668237);
			CalibrationWindow.NativeMethodInfoPtr_OnInvert_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668238);
			CalibrationWindow.NativeMethodInfoPtr_OnZeroValueChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668239);
			CalibrationWindow.NativeMethodInfoPtr_OnZeroCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668240);
			CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneValueChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668241);
			CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668242);
			CalibrationWindow.NativeMethodInfoPtr_OnSensitivityValueChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668243);
			CalibrationWindow.NativeMethodInfoPtr_OnSensitivityCancel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668244);
			CalibrationWindow.NativeMethodInfoPtr_OnAxisScrollRectScroll_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668245);
			CalibrationWindow.NativeMethodInfoPtr_OnAxisSelected_Private_Void_Int32_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668246);
			CalibrationWindow.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668247);
			CalibrationWindow.NativeMethodInfoPtr_Redraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668248);
			CalibrationWindow.NativeMethodInfoPtr_RefreshControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668249);
			CalibrationWindow.NativeMethodInfoPtr_RedrawDeadzone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668250);
			CalibrationWindow.NativeMethodInfoPtr_RedrawCalibratedZero_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668251);
			CalibrationWindow.NativeMethodInfoPtr_RedrawValueMarkers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668252);
			CalibrationWindow.NativeMethodInfoPtr_SelectAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668253);
			CalibrationWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668254);
			CalibrationWindow.NativeMethodInfoPtr_SetMinSensitivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668255);
			CalibrationWindow.NativeMethodInfoPtr_IsMenuAxis_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668256);
			CalibrationWindow.NativeMethodInfoPtr_GetAxisButtonDeadZone_Private_Void_Int32_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668257);
			CalibrationWindow.NativeMethodInfoPtr_GetSliderSensitivity_Private_Single_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668258);
			CalibrationWindow.NativeMethodInfoPtr_SetSensitivity_Public_Void_AxisCalibration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668259);
			CalibrationWindow.NativeMethodInfoPtr_ProcessPowerValue_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668260);
			CalibrationWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, 100668261);
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x000D92BC File Offset: 0x000D74BC
		public unsafe bool axisSelected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90510, XrefRangeEnd = 90511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_get_axisSelected_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x000D92F8 File Offset: 0x000D74F8
		public unsafe AxisCalibration axisCalibration
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 90514, RefRangeEnd = 90528, XrefRangeStart = 90511, XrefRangeEnd = 90514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_get_axisCalibration_Private_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x000D9338 File Offset: 0x000D7538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90528, XrefRangeEnd = 90740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isFocusedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CalibrationWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x000D9394 File Offset: 0x000D7594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90836, RefRangeEnd = 90837, XrefRangeStart = 90740, XrefRangeEnd = 90836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetJoystick(int playerId, Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joystick);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetJoystick_Public_Void_Int32_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x000D93E4 File Offset: 0x000D75E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90842, RefRangeEnd = 90845, XrefRangeStart = 90837, XrefRangeEnd = 90842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonCallback(CalibrationWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIdentifier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x000D9434 File Offset: 0x000D7634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90845, XrefRangeEnd = 90850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CalibrationWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x000D9470 File Offset: 0x000D7670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90850, XrefRangeEnd = 90858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CalibrationWindow.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x000D94AC File Offset: 0x000D76AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90858, XrefRangeEnd = 90863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x000D94E0 File Offset: 0x000D76E0
		[CallerCount(0)]
		public unsafe void OnCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x000D9514 File Offset: 0x000D7714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90863, XrefRangeEnd = 90875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRestoreDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x000D9548 File Offset: 0x000D7748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90875, XrefRangeEnd = 90880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCalibrate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnCalibrate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x000D957C File Offset: 0x000D777C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90880, XrefRangeEnd = 90882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInvert(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnInvert_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x000D95BC File Offset: 0x000D77BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90882, XrefRangeEnd = 90885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnZeroValueChange(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnZeroValueChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x000D95FC File Offset: 0x000D77FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90885, XrefRangeEnd = 90889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnZeroCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnZeroCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x000D9630 File Offset: 0x000D7830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90889, XrefRangeEnd = 90894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeadzoneValueChange(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneValueChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x000D9670 File Offset: 0x000D7870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90894, XrefRangeEnd = 90899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeadzoneCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnDeadzoneCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x000D96A4 File Offset: 0x000D78A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90899, XrefRangeEnd = 90901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSensitivityValueChange(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnSensitivityValueChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x000D96E4 File Offset: 0x000D78E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90901, XrefRangeEnd = 90904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSensitivityCancel(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnSensitivityCancel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x000D9724 File Offset: 0x000D7924
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAxisScrollRectScroll(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnAxisScrollRectScroll_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x000D9764 File Offset: 0x000D7964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90904, XrefRangeEnd = 90908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAxisSelected(int axisIndex, Button button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_OnAxisSelected_Private_Void_Int32_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x000D97B4 File Offset: 0x000D79B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90908, XrefRangeEnd = 90909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x000D97E8 File Offset: 0x000D79E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90909, XrefRangeEnd = 90911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_Redraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x000D981C File Offset: 0x000D7A1C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 90921, RefRangeEnd = 90929, XrefRangeStart = 90911, XrefRangeEnd = 90921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RefreshControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x000D9850 File Offset: 0x000D7A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90942, RefRangeEnd = 90945, XrefRangeStart = 90929, XrefRangeEnd = 90942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RedrawDeadzone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RedrawDeadzone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x000D9884 File Offset: 0x000D7A84
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 90955, RefRangeEnd = 90963, XrefRangeStart = 90945, XrefRangeEnd = 90955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RedrawCalibratedZero()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RedrawCalibratedZero_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x000D98B8 File Offset: 0x000D7AB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 90988, RefRangeEnd = 90996, XrefRangeStart = 90963, XrefRangeEnd = 90988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RedrawValueMarkers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_RedrawValueMarkers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x000D98EC File Offset: 0x000D7AEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91018, RefRangeEnd = 91022, XrefRangeStart = 90996, XrefRangeEnd = 91018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SelectAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A34 RID: 14900 RVA: 0x000D992C File Offset: 0x000D7B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91022, XrefRangeEnd = 91027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TakeInputFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CalibrationWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x000D9968 File Offset: 0x000D7B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91043, RefRangeEnd = 91044, XrefRangeStart = 91027, XrefRangeEnd = 91043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMinSensitivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetMinSensitivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x000D999C File Offset: 0x000D7B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91080, RefRangeEnd = 91082, XrefRangeStart = 91044, XrefRangeEnd = 91080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMenuAxis(int actionId, int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_IsMenuAxis_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x000D99F4 File Offset: 0x000D7BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91091, RefRangeEnd = 91092, XrefRangeStart = 91082, XrefRangeEnd = 91091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_GetAxisButtonDeadZone_Private_Void_Int32_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x000D9A50 File Offset: 0x000D7C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91092, XrefRangeEnd = 91093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSliderSensitivity(AxisCalibration axisCalibration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisCalibration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_GetSliderSensitivity_Private_Single_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x000D9AA0 File Offset: 0x000D7CA0
		[CallerCount(0)]
		public unsafe void SetSensitivity(AxisCalibration axisCalibration, float sliderValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisCalibration);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliderValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_SetSensitivity_Public_Void_AxisCalibration_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x000D9AF0 File Offset: 0x000D7CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91095, RefRangeEnd = 91097, XrefRangeStart = 91093, XrefRangeEnd = 91095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ProcessPowerValue(float value, float minValue, float maxValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr_ProcessPowerValue_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x000D9B4C File Offset: 0x000D7D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91097, XrefRangeEnd = 91100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalibrationWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00024BD8 File Offset: 0x00022DD8
		public CalibrationWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x000D9B88 File Offset: 0x000D7D88
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x00024BE1 File Offset: 0x00022DE1
		public unsafe static float minSensitivityOtherAxes
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CalibrationWindow.NativeFieldInfoPtr_minSensitivityOtherAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalibrationWindow.NativeFieldInfoPtr_minSensitivityOtherAxes, (void*)(&value));
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x000D9BA4 File Offset: 0x000D7DA4
		// (set) Token: 0x06003A40 RID: 14912 RVA: 0x00024BEF File Offset: 0x00022DEF
		public unsafe static float maxDeadzone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CalibrationWindow.NativeFieldInfoPtr_maxDeadzone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalibrationWindow.NativeFieldInfoPtr_maxDeadzone, (void*)(&value));
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x000D9BC0 File Offset: 0x000D7DC0
		// (set) Token: 0x06003A42 RID: 14914 RVA: 0x00024BFD File Offset: 0x00022DFD
		public unsafe RectTransform rightContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rightContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rightContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x000D9BF0 File Offset: 0x000D7DF0
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x00024C1C File Offset: 0x00022E1C
		public unsafe RectTransform valueDisplayGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_valueDisplayGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_valueDisplayGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x000D9C20 File Offset: 0x000D7E20
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x00024C3B File Offset: 0x00022E3B
		public unsafe RectTransform calibratedValueMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedValueMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedValueMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x000D9C50 File Offset: 0x000D7E50
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x00024C5A File Offset: 0x00022E5A
		public unsafe RectTransform rawValueMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rawValueMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rawValueMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x000D9C80 File Offset: 0x000D7E80
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x00024C79 File Offset: 0x00022E79
		public unsafe RectTransform calibratedZeroMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedZeroMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibratedZeroMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x000D9CB0 File Offset: 0x000D7EB0
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x00024C98 File Offset: 0x00022E98
		public unsafe RectTransform deadzoneArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x000D9CE0 File Offset: 0x000D7EE0
		// (set) Token: 0x06003A4E RID: 14926 RVA: 0x00024CB7 File Offset: 0x00022EB7
		public unsafe Slider deadzoneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x000D9D10 File Offset: 0x000D7F10
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x00024CD6 File Offset: 0x00022ED6
		public unsafe Slider zeroSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x000D9D40 File Offset: 0x000D7F40
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x00024CF5 File Offset: 0x00022EF5
		public unsafe Slider sensitivitySlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x000D9D70 File Offset: 0x000D7F70
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00024D14 File Offset: 0x00022F14
		public unsafe Toggle invertToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x000D9DA0 File Offset: 0x000D7FA0
		// (set) Token: 0x06003A56 RID: 14934 RVA: 0x00024D33 File Offset: 0x00022F33
		public unsafe RectTransform axisScrollAreaContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisScrollAreaContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisScrollAreaContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x000D9DD0 File Offset: 0x000D7FD0
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x00024D52 File Offset: 0x00022F52
		public unsafe Button doneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x000D9E00 File Offset: 0x000D8000
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x00024D71 File Offset: 0x00022F71
		public unsafe Button calibrateButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x000D9E30 File Offset: 0x000D8030
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00024D90 File Offset: 0x00022F90
		public unsafe Text doneButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_doneButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x000D9E60 File Offset: 0x000D8060
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x00024DAF File Offset: 0x00022FAF
		public unsafe Text cancelButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_cancelButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_cancelButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x000D9E90 File Offset: 0x000D8090
		// (set) Token: 0x06003A60 RID: 14944 RVA: 0x00024DCE File Offset: 0x00022FCE
		public unsafe Text defaultButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_defaultButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_defaultButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x000D9EC0 File Offset: 0x000D80C0
		// (set) Token: 0x06003A62 RID: 14946 RVA: 0x00024DED File Offset: 0x00022FED
		public unsafe Text deadzoneSliderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSliderLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_deadzoneSliderLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x000D9EF0 File Offset: 0x000D80F0
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x00024E0C File Offset: 0x0002300C
		public unsafe Text zeroSliderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSliderLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_zeroSliderLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x000D9F20 File Offset: 0x000D8120
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x00024E2B File Offset: 0x0002302B
		public unsafe Text sensitivitySliderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySliderLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_sensitivitySliderLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06003A67 RID: 14951 RVA: 0x000D9F50 File Offset: 0x000D8150
		// (set) Token: 0x06003A68 RID: 14952 RVA: 0x00024E4A File Offset: 0x0002304A
		public unsafe Text invertToggleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_invertToggleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x000D9F80 File Offset: 0x000D8180
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x00024E69 File Offset: 0x00023069
		public unsafe Text calibrateButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_calibrateButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x000D9FB0 File Offset: 0x000D81B0
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x00024E88 File Offset: 0x00023088
		public unsafe GameObject axisButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x000D9FE0 File Offset: 0x000D81E0
		// (set) Token: 0x06003A6E RID: 14958 RVA: 0x00024EA7 File Offset: 0x000230A7
		public unsafe Joystick joystick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_joystick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_joystick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x000DA010 File Offset: 0x000D8210
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x00024EC6 File Offset: 0x000230C6
		public unsafe string origCalibrationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origCalibrationData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origCalibrationData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x000DA038 File Offset: 0x000D8238
		// (set) Token: 0x06003A72 RID: 14962 RVA: 0x00024EE5 File Offset: 0x000230E5
		public unsafe int selectedAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_selectedAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_selectedAxis)) = value;
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x000DA060 File Offset: 0x000D8260
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x00024F00 File Offset: 0x00023100
		public AxisCalibrationData origSelectedAxisCalibrationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origSelectedAxisCalibrationData);
				return new AxisCalibrationData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_origSelectedAxisCalibrationData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x000DA090 File Offset: 0x000D8290
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x00024F2E File Offset: 0x0002312E
		public unsafe float displayAreaWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_displayAreaWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_displayAreaWidth)) = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x000DA0B8 File Offset: 0x000D82B8
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x00024F49 File Offset: 0x00023149
		public unsafe List<Button> axisButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_axisButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x000DA0E8 File Offset: 0x000D82E8
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x00024F68 File Offset: 0x00023168
		public unsafe Dictionary<int, Action<int>> buttonCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_buttonCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_buttonCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x000DA118 File Offset: 0x000D8318
		// (set) Token: 0x06003A7C RID: 14972 RVA: 0x00024F87 File Offset: 0x00023187
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x000DA140 File Offset: 0x000D8340
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x00024FA2 File Offset: 0x000231A2
		public unsafe RewiredStandaloneInputModule rewiredStandaloneInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rewiredStandaloneInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RewiredStandaloneInputModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_rewiredStandaloneInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x000DA170 File Offset: 0x000D8370
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x00024FC1 File Offset: 0x000231C1
		public unsafe int menuHorizActionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuHorizActionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuHorizActionId)) = value;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x000DA198 File Offset: 0x000D8398
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x00024FDC File Offset: 0x000231DC
		public unsafe int menuVertActionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuVertActionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_menuVertActionId)) = value;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x000DA1C0 File Offset: 0x000D83C0
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x00024FF7 File Offset: 0x000231F7
		public unsafe float minSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_minSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.NativeFieldInfoPtr_minSensitivity)) = value;
			}
		}

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeFieldInfoPtr_minSensitivityOtherAxes;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeFieldInfoPtr_maxDeadzone;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeFieldInfoPtr_rightContentContainer;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeFieldInfoPtr_valueDisplayGroup;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeFieldInfoPtr_calibratedValueMarker;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeFieldInfoPtr_rawValueMarker;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeFieldInfoPtr_calibratedZeroMarker;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeFieldInfoPtr_deadzoneArea;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeFieldInfoPtr_deadzoneSlider;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeFieldInfoPtr_zeroSlider;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeFieldInfoPtr_sensitivitySlider;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeFieldInfoPtr_invertToggle;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeFieldInfoPtr_axisScrollAreaContent;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeFieldInfoPtr_doneButton;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeFieldInfoPtr_calibrateButton;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr_doneButtonLabel;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr_cancelButtonLabel;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonLabel;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeFieldInfoPtr_deadzoneSliderLabel;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeFieldInfoPtr_zeroSliderLabel;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeFieldInfoPtr_sensitivitySliderLabel;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeFieldInfoPtr_invertToggleLabel;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeFieldInfoPtr_calibrateButtonLabel;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeFieldInfoPtr_axisButtonPrefab;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeFieldInfoPtr_joystick;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeFieldInfoPtr_origCalibrationData;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeFieldInfoPtr_selectedAxis;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeFieldInfoPtr_origSelectedAxisCalibrationData;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeFieldInfoPtr_displayAreaWidth;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeFieldInfoPtr_axisButtons;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeFieldInfoPtr_buttonCallbacks;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeFieldInfoPtr_rewiredStandaloneInputModule;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeFieldInfoPtr_menuHorizActionId;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeFieldInfoPtr_menuVertActionId;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeFieldInfoPtr_minSensitivity;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_get_axisSelected_Private_get_Boolean_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCalibration_Private_get_AxisCalibration_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_SetJoystick_Public_Void_Int32_Joystick_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_OnDone_Public_Void_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Void_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_OnCalibrate_Public_Void_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_OnInvert_Public_Void_Boolean_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_OnZeroValueChange_Public_Void_Single_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_OnZeroCancel_Public_Void_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_OnDeadzoneValueChange_Public_Void_Single_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_OnDeadzoneCancel_Public_Void_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_OnSensitivityValueChange_Public_Void_Single_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_OnSensitivityCancel_Public_Void_Single_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_OnAxisScrollRectScroll_Public_Void_Vector2_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_OnAxisSelected_Private_Void_Int32_Button_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Private_Void_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_Redraw_Private_Void_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_RefreshControls_Private_Void_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_RedrawDeadzone_Private_Void_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_RedrawCalibratedZero_Private_Void_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_RedrawValueMarkers_Private_Void_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_SelectAxis_Private_Void_Int32_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_SetMinSensitivity_Private_Void_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_IsMenuAxis_Private_Boolean_Int32_Int32_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisButtonDeadZone_Private_Void_Int32_Int32_byref_Single_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderSensitivity_Private_Single_AxisCalibration_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_SetSensitivity_Public_Void_AxisCalibration_Single_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPowerValue_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000365 RID: 869
		[OriginalName("Assembly-CSharp.dll", "", "ButtonIdentifier")]
		public enum ButtonIdentifier
		{
			// Token: 0x04003801 RID: 14337
			Done,
			// Token: 0x04003802 RID: 14338
			Cancel,
			// Token: 0x04003803 RID: 14339
			Default,
			// Token: 0x04003804 RID: 14340
			Calibrate
		}

		// Token: 0x02000366 RID: 870
		[ObfuscatedName("Rewired.UI.ControlMapper.CalibrationWindow+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060054B4 RID: 21684 RVA: 0x00133314 File Offset: 0x00131514
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CalibrationWindow>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr);
				CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, "index");
				CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, "button");
				CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, 100668262);
				CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__SetJoystick_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr, 100668263);
			}

			// Token: 0x060054B5 RID: 21685 RVA: 0x001333A4 File Offset: 0x001315A4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationWindow.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054B6 RID: 21686 RVA: 0x001333E0 File Offset: 0x001315E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90506, XrefRangeEnd = 90510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetJoystick_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationWindow.__c__DisplayClass41_0.NativeMethodInfoPtr__SetJoystick_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054B7 RID: 21687 RVA: 0x000310CA File Offset: 0x0002F2CA
			public __c__DisplayClass41_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EDC RID: 7900
			// (get) Token: 0x060054B8 RID: 21688 RVA: 0x00133414 File Offset: 0x00131614
			// (set) Token: 0x060054B9 RID: 21689 RVA: 0x000310D3 File Offset: 0x0002F2D3
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17001EDD RID: 7901
			// (get) Token: 0x060054BA RID: 21690 RVA: 0x0013343C File Offset: 0x0013163C
			// (set) Token: 0x060054BB RID: 21691 RVA: 0x000310EE File Offset: 0x0002F2EE
			public unsafe Button button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EDE RID: 7902
			// (get) Token: 0x060054BC RID: 21692 RVA: 0x0013346C File Offset: 0x0013166C
			// (set) Token: 0x060054BD RID: 21693 RVA: 0x0003110D File Offset: 0x0002F30D
			public unsafe CalibrationWindow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalibrationWindow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationWindow.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003805 RID: 14341
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04003806 RID: 14342
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04003807 RID: 14343
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003808 RID: 14344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003809 RID: 14345
			private static readonly IntPtr NativeMethodInfoPtr__SetJoystick_b__0_Internal_Void_0;
		}
	}
}
