using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000209 RID: 521
	public class ControlRemappingDemo1 : MonoBehaviour
	{
		// Token: 0x06003F90 RID: 16272 RVA: 0x000EDE8C File Offset: 0x000EC08C
		// Note: this type is marked as 'beforefieldinit'.
		static ControlRemappingDemo1()
		{
			Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "ControlRemappingDemo1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr);
			ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "defaultModalWidth");
			ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "defaultModalHeight");
			ControlRemappingDemo1.NativeFieldInfoPtr_assignmentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "assignmentTimeout");
			ControlRemappingDemo1.NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "dialog");
			ControlRemappingDemo1.NativeFieldInfoPtr_inputMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "inputMapper");
			ControlRemappingDemo1.NativeFieldInfoPtr_conflictFoundEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "conflictFoundEventData");
			ControlRemappingDemo1.NativeFieldInfoPtr_guiState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "guiState");
			ControlRemappingDemo1.NativeFieldInfoPtr_busy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "busy");
			ControlRemappingDemo1.NativeFieldInfoPtr_pageGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "pageGUIState");
			ControlRemappingDemo1.NativeFieldInfoPtr_selectedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedPlayer");
			ControlRemappingDemo1.NativeFieldInfoPtr_selectedMapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedMapCategoryId");
			ControlRemappingDemo1.NativeFieldInfoPtr_selectedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedController");
			ControlRemappingDemo1.NativeFieldInfoPtr_selectedMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedMap");
			ControlRemappingDemo1.NativeFieldInfoPtr_showMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "showMenu");
			ControlRemappingDemo1.NativeFieldInfoPtr_startListening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "startListening");
			ControlRemappingDemo1.NativeFieldInfoPtr_actionScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "actionScrollPos");
			ControlRemappingDemo1.NativeFieldInfoPtr_calibrateScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "calibrateScrollPos");
			ControlRemappingDemo1.NativeFieldInfoPtr_actionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "actionQueue");
			ControlRemappingDemo1.NativeFieldInfoPtr_setupFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "setupFinished");
			ControlRemappingDemo1.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "initialized");
			ControlRemappingDemo1.NativeFieldInfoPtr_isCompiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "isCompiling");
			ControlRemappingDemo1.NativeFieldInfoPtr_style_wordWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "style_wordWrap");
			ControlRemappingDemo1.NativeFieldInfoPtr_style_centeredBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "style_centeredBox");
			ControlRemappingDemo1.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669408);
			ControlRemappingDemo1.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669409);
			ControlRemappingDemo1.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669410);
			ControlRemappingDemo1.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669411);
			ControlRemappingDemo1.NativeMethodInfoPtr_Setup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669412);
			ControlRemappingDemo1.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669413);
			ControlRemappingDemo1.NativeMethodInfoPtr_Unsubscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669414);
			ControlRemappingDemo1.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669415);
			ControlRemappingDemo1.NativeMethodInfoPtr_HandleMenuControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669416);
			ControlRemappingDemo1.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669417);
			ControlRemappingDemo1.NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669418);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669419);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawPage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669420);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669421);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669422);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669423);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669424);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669425);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawMapCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669426);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669427);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669428);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669429);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669430);
			ControlRemappingDemo1.NativeMethodInfoPtr_ShowDialog_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669431);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669432);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669433);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669434);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669435);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669436);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669437);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669438);
			ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669439);
			ControlRemappingDemo1.NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669440);
			ControlRemappingDemo1.NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669441);
			ControlRemappingDemo1.NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669442);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669443);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669444);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669445);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669446);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669447);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669448);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669449);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669450);
			ControlRemappingDemo1.NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669451);
			ControlRemappingDemo1.NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669452);
			ControlRemappingDemo1.NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669453);
			ControlRemappingDemo1.NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669454);
			ControlRemappingDemo1.NativeMethodInfoPtr_ClearMapSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669455);
			ControlRemappingDemo1.NativeMethodInfoPtr_ResetAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669456);
			ControlRemappingDemo1.NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669457);
			ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669458);
			ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669459);
			ControlRemappingDemo1.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669460);
			ControlRemappingDemo1.NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669461);
			ControlRemappingDemo1.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669462);
			ControlRemappingDemo1.NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669463);
			ControlRemappingDemo1.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669464);
			ControlRemappingDemo1.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669465);
			ControlRemappingDemo1.NativeMethodInfoPtr_CheckRecompile_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669466);
			ControlRemappingDemo1.NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669467);
			ControlRemappingDemo1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100669468);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x000EE54C File Offset: 0x000EC74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101194, XrefRangeEnd = 101199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x000EE580 File Offset: 0x000EC780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101199, XrefRangeEnd = 101200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x000EE5B4 File Offset: 0x000EC7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101200, XrefRangeEnd = 101202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000EE5E8 File Offset: 0x000EC7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101241, RefRangeEnd = 101242, XrefRangeStart = 101202, XrefRangeEnd = 101241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000EE61C File Offset: 0x000EC81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101258, RefRangeEnd = 101259, XrefRangeStart = 101242, XrefRangeEnd = 101258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Setup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000EE650 File Offset: 0x000EC850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101275, RefRangeEnd = 101276, XrefRangeStart = 101259, XrefRangeEnd = 101275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x000EE684 File Offset: 0x000EC884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsubscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Unsubscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x000EE6B8 File Offset: 0x000EC8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101276, XrefRangeEnd = 101322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x000EE6EC File Offset: 0x000EC8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101322, XrefRangeEnd = 101335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleMenuControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_HandleMenuControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x000EE720 File Offset: 0x000EC920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101335, XrefRangeEnd = 101336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x000EE754 File Offset: 0x000EC954
		[CallerCount(0)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x000EE788 File Offset: 0x000EC988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101336, XrefRangeEnd = 101390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawInitialScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x000EE7BC File Offset: 0x000EC9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101441, RefRangeEnd = 101442, XrefRangeStart = 101390, XrefRangeEnd = 101441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawPage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawPage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x000EE7F0 File Offset: 0x000EC9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101508, RefRangeEnd = 101509, XrefRangeStart = 101442, XrefRangeEnd = 101508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawPlayerSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x000EE824 File Offset: 0x000ECA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101580, RefRangeEnd = 101581, XrefRangeStart = 101509, XrefRangeEnd = 101580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMouseAssignment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x000EE858 File Offset: 0x000ECA58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101673, RefRangeEnd = 101674, XrefRangeStart = 101581, XrefRangeEnd = 101673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawJoystickSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x000EE88C File Offset: 0x000ECA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101766, RefRangeEnd = 101767, XrefRangeStart = 101674, XrefRangeEnd = 101766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawControllerSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x000EE8C0 File Offset: 0x000ECAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101820, RefRangeEnd = 101821, XrefRangeStart = 101767, XrefRangeEnd = 101820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCalibrateButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x000EE8F4 File Offset: 0x000ECAF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101929, RefRangeEnd = 101930, XrefRangeStart = 101821, XrefRangeEnd = 101929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMapCategories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawMapCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x000EE928 File Offset: 0x000ECB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102113, RefRangeEnd = 102114, XrefRangeStart = 101930, XrefRangeEnd = 102113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCategoryActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x000EE95C File Offset: 0x000ECB5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102156, RefRangeEnd = 102160, XrefRangeStart = 102114, XrefRangeEnd = 102156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControlRemappingDemo1.ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionRange;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000EE9F4 File Offset: 0x000ECBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102181, RefRangeEnd = 102182, XrefRangeStart = 102160, XrefRangeEnd = 102181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControlRemappingDemo1.ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionAxisContribution;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000EEA8C File Offset: 0x000ECC8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102212, RefRangeEnd = 102216, XrefRangeStart = 102182, XrefRangeEnd = 102212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControlRemappingDemo1.ControllerSelection controller, ControllerMap controllerMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionRange;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x000EEB10 File Offset: 0x000ECD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102216, XrefRangeEnd = 102219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ShowDialog_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x000EEB44 File Offset: 0x000ECD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102219, XrefRangeEnd = 102239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawModalWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x000EEB98 File Offset: 0x000ECD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102239, XrefRangeEnd = 102255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawModalWindow_OkayOnly(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x000EEBEC File Offset: 0x000ECDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102255, XrefRangeEnd = 102280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawElementAssignmentWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x000EEC40 File Offset: 0x000ECE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102280, XrefRangeEnd = 102304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawElementAssignmentProtectedConflictWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x000EEC94 File Offset: 0x000ECE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102304, XrefRangeEnd = 102332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawElementAssignmentNormalConflictWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x000EECE8 File Offset: 0x000ECEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102332, XrefRangeEnd = 102352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x000EED3C File Offset: 0x000ECF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102352, XrefRangeEnd = 102381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawFallbackJoystickIdentificationWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x000EED90 File Offset: 0x000ECF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102381, XrefRangeEnd = 102642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCalibrationWindow(string title, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x000EEDE4 File Offset: 0x000ECFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102642, XrefRangeEnd = 102652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DialogResultCallback(int queueActionId, ControlRemappingDemo1.UserResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref queueActionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x000EEE30 File Offset: 0x000ED030
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 102656, RefRangeEnd = 102665, XrefRangeStart = 102652, XrefRangeEnd = 102656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetScreenCenteredRect(float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x000EEE88 File Offset: 0x000ED088
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102673, RefRangeEnd = 102677, XrefRangeStart = 102665, XrefRangeEnd = 102673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnqueueAction(ControlRemappingDemo1.QueueEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x000EEECC File Offset: 0x000ED0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102699, RefRangeEnd = 102700, XrefRangeStart = 102677, XrefRangeEnd = 102699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x000EEF00 File Offset: 0x000ED100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102736, RefRangeEnd = 102737, XrefRangeStart = 102700, XrefRangeEnd = 102736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessJoystickAssignmentChange(ControlRemappingDemo1.JoystickAssignmentChange entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x000EEF50 File Offset: 0x000ED150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102747, RefRangeEnd = 102748, XrefRangeStart = 102737, XrefRangeEnd = 102747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessElementAssignmentChange(ControlRemappingDemo1.ElementAssignmentChange entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x000EEFA0 File Offset: 0x000ED1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102774, RefRangeEnd = 102775, XrefRangeStart = 102748, XrefRangeEnd = 102774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessRemoveOrReassignElementAssignment(ControlRemappingDemo1.ElementAssignmentChange entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x000EEFF0 File Offset: 0x000ED1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102793, RefRangeEnd = 102794, XrefRangeStart = 102775, XrefRangeEnd = 102793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessRemoveElementAssignment(ControlRemappingDemo1.ElementAssignmentChange entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x000EF040 File Offset: 0x000ED240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102826, RefRangeEnd = 102827, XrefRangeStart = 102794, XrefRangeEnd = 102826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessAddOrReplaceElementAssignment(ControlRemappingDemo1.ElementAssignmentChange entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x000EF090 File Offset: 0x000ED290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102864, RefRangeEnd = 102865, XrefRangeStart = 102827, XrefRangeEnd = 102864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessElementAssignmentConflictCheck(ControlRemappingDemo1.ElementAssignmentChange entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x000EF0E0 File Offset: 0x000ED2E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102883, RefRangeEnd = 102884, XrefRangeStart = 102865, XrefRangeEnd = 102883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessFallbackJoystickIdentification(ControlRemappingDemo1.FallbackJoystickIdentification entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x000EF130 File Offset: 0x000ED330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102906, RefRangeEnd = 102907, XrefRangeStart = 102884, XrefRangeEnd = 102906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessCalibration(ControlRemappingDemo1.Calibration entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x000EF180 File Offset: 0x000ED380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102907, XrefRangeEnd = 102908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSelectionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x000EF1B4 File Offset: 0x000ED3B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 102908, RefRangeEnd = 102913, XrefRangeStart = 102908, XrefRangeEnd = 102908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerSelectionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x000EF1E8 File Offset: 0x000ED3E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102913, RefRangeEnd = 102915, XrefRangeStart = 102913, XrefRangeEnd = 102913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearControllerSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x000EF21C File Offset: 0x000ED41C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 102908, RefRangeEnd = 102913, XrefRangeStart = 102908, XrefRangeEnd = 102913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMapSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ClearMapSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x000EF250 File Offset: 0x000ED450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102915, XrefRangeEnd = 102916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ResetAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x000EF284 File Offset: 0x000ED484
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 102922, RefRangeEnd = 102928, XrefRangeStart = 102916, XrefRangeEnd = 102922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWorkingVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x000EF2B8 File Offset: 0x000ED4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102928, XrefRangeEnd = 102939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGUIStateStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x000EF2EC File Offset: 0x000ED4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102939, XrefRangeEnd = 102948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGUIStateEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x000EF320 File Offset: 0x000ED520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102948, XrefRangeEnd = 102987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickConnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x000EF364 File Offset: 0x000ED564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102987, XrefRangeEnd = 103023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x000EF3A8 File Offset: 0x000ED5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103023, XrefRangeEnd = 103029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x000EF3EC File Offset: 0x000ED5EC
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConflictFound(InputMapper.ConflictFoundEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x000EF430 File Offset: 0x000ED630
		[CallerCount(0)]
		public unsafe void OnStopped(InputMapper.StoppedEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x000EF474 File Offset: 0x000ED674
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103063, RefRangeEnd = 103066, XrefRangeStart = 103029, XrefRangeEnd = 103063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IdentifyAllJoysticks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x000EF4A8 File Offset: 0x000ED6A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRecompile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_CheckRecompile_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x000EF4DC File Offset: 0x000ED6DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecompileWindow(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x000EF51C File Offset: 0x000ED71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103066, XrefRangeEnd = 103073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlRemappingDemo1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0002704F File Offset: 0x0002524F
		public ControlRemappingDemo1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x000EF558 File Offset: 0x000ED758
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x00027058 File Offset: 0x00025258
		public unsafe static float defaultModalWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalWidth, (void*)(&value));
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x000EF574 File Offset: 0x000ED774
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x00027066 File Offset: 0x00025266
		public unsafe static float defaultModalHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.NativeFieldInfoPtr_defaultModalHeight, (void*)(&value));
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x000EF590 File Offset: 0x000ED790
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x00027074 File Offset: 0x00025274
		public unsafe static float assignmentTimeout
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.NativeFieldInfoPtr_assignmentTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.NativeFieldInfoPtr_assignmentTimeout, (void*)(&value));
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x000EF5AC File Offset: 0x000ED7AC
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x00027082 File Offset: 0x00025282
		public unsafe ControlRemappingDemo1.DialogHelper dialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_dialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControlRemappingDemo1.DialogHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_dialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x000EF5DC File Offset: 0x000ED7DC
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x000270A1 File Offset: 0x000252A1
		public unsafe InputMapper inputMapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_inputMapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_inputMapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x000EF60C File Offset: 0x000ED80C
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x000270C0 File Offset: 0x000252C0
		public unsafe InputMapper.ConflictFoundEventData conflictFoundEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_conflictFoundEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.ConflictFoundEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_conflictFoundEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x000EF63C File Offset: 0x000ED83C
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x000270DF File Offset: 0x000252DF
		public unsafe bool guiState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_guiState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_guiState)) = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x000EF664 File Offset: 0x000ED864
		// (set) Token: 0x06003FDE RID: 16350 RVA: 0x000270FA File Offset: 0x000252FA
		public unsafe bool busy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_busy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_busy)) = value;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x000EF68C File Offset: 0x000ED88C
		// (set) Token: 0x06003FE0 RID: 16352 RVA: 0x00027115 File Offset: 0x00025315
		public unsafe bool pageGUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_pageGUIState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_pageGUIState)) = value;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06003FE1 RID: 16353 RVA: 0x000EF6B4 File Offset: 0x000ED8B4
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x00027130 File Offset: 0x00025330
		public unsafe Player selectedPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x000EF6E4 File Offset: 0x000ED8E4
		// (set) Token: 0x06003FE4 RID: 16356 RVA: 0x0002714F File Offset: 0x0002534F
		public unsafe int selectedMapCategoryId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMapCategoryId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMapCategoryId)) = value;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x000EF70C File Offset: 0x000ED90C
		// (set) Token: 0x06003FE6 RID: 16358 RVA: 0x0002716A File Offset: 0x0002536A
		public unsafe ControlRemappingDemo1.ControllerSelection selectedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControlRemappingDemo1.ControllerSelection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x000EF73C File Offset: 0x000ED93C
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x00027189 File Offset: 0x00025389
		public unsafe ControllerMap selectedMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_selectedMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x000EF76C File Offset: 0x000ED96C
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x000271A8 File Offset: 0x000253A8
		public unsafe bool showMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_showMenu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_showMenu)) = value;
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x000EF794 File Offset: 0x000ED994
		// (set) Token: 0x06003FEC RID: 16364 RVA: 0x000271C3 File Offset: 0x000253C3
		public unsafe bool startListening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_startListening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_startListening)) = value;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x000EF7BC File Offset: 0x000ED9BC
		// (set) Token: 0x06003FEE RID: 16366 RVA: 0x000271DE File Offset: 0x000253DE
		public unsafe Vector2 actionScrollPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionScrollPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionScrollPos)) = value;
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06003FEF RID: 16367 RVA: 0x000EF7E4 File Offset: 0x000ED9E4
		// (set) Token: 0x06003FF0 RID: 16368 RVA: 0x000271F9 File Offset: 0x000253F9
		public unsafe Vector2 calibrateScrollPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_calibrateScrollPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_calibrateScrollPos)) = value;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000EF80C File Offset: 0x000EDA0C
		// (set) Token: 0x06003FF2 RID: 16370 RVA: 0x00027214 File Offset: 0x00025414
		public unsafe Queue<ControlRemappingDemo1.QueueEntry> actionQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ControlRemappingDemo1.QueueEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_actionQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x000EF83C File Offset: 0x000EDA3C
		// (set) Token: 0x06003FF4 RID: 16372 RVA: 0x00027233 File Offset: 0x00025433
		public unsafe bool setupFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_setupFinished);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_setupFinished)) = value;
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x000EF864 File Offset: 0x000EDA64
		// (set) Token: 0x06003FF6 RID: 16374 RVA: 0x0002724E File Offset: 0x0002544E
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x000EF88C File Offset: 0x000EDA8C
		// (set) Token: 0x06003FF8 RID: 16376 RVA: 0x00027269 File Offset: 0x00025469
		public unsafe bool isCompiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_isCompiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_isCompiling)) = value;
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x000EF8B4 File Offset: 0x000EDAB4
		// (set) Token: 0x06003FFA RID: 16378 RVA: 0x00027284 File Offset: 0x00025484
		public unsafe GUIStyle style_wordWrap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_wordWrap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_wordWrap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x000EF8E4 File Offset: 0x000EDAE4
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x000272A3 File Offset: 0x000254A3
		public unsafe GUIStyle style_centeredBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_centeredBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.NativeFieldInfoPtr_style_centeredBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026F7 RID: 9975
		private static readonly IntPtr NativeFieldInfoPtr_defaultModalWidth;

		// Token: 0x040026F8 RID: 9976
		private static readonly IntPtr NativeFieldInfoPtr_defaultModalHeight;

		// Token: 0x040026F9 RID: 9977
		private static readonly IntPtr NativeFieldInfoPtr_assignmentTimeout;

		// Token: 0x040026FA RID: 9978
		private static readonly IntPtr NativeFieldInfoPtr_dialog;

		// Token: 0x040026FB RID: 9979
		private static readonly IntPtr NativeFieldInfoPtr_inputMapper;

		// Token: 0x040026FC RID: 9980
		private static readonly IntPtr NativeFieldInfoPtr_conflictFoundEventData;

		// Token: 0x040026FD RID: 9981
		private static readonly IntPtr NativeFieldInfoPtr_guiState;

		// Token: 0x040026FE RID: 9982
		private static readonly IntPtr NativeFieldInfoPtr_busy;

		// Token: 0x040026FF RID: 9983
		private static readonly IntPtr NativeFieldInfoPtr_pageGUIState;

		// Token: 0x04002700 RID: 9984
		private static readonly IntPtr NativeFieldInfoPtr_selectedPlayer;

		// Token: 0x04002701 RID: 9985
		private static readonly IntPtr NativeFieldInfoPtr_selectedMapCategoryId;

		// Token: 0x04002702 RID: 9986
		private static readonly IntPtr NativeFieldInfoPtr_selectedController;

		// Token: 0x04002703 RID: 9987
		private static readonly IntPtr NativeFieldInfoPtr_selectedMap;

		// Token: 0x04002704 RID: 9988
		private static readonly IntPtr NativeFieldInfoPtr_showMenu;

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeFieldInfoPtr_startListening;

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeFieldInfoPtr_actionScrollPos;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeFieldInfoPtr_calibrateScrollPos;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeFieldInfoPtr_actionQueue;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeFieldInfoPtr_setupFinished;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeFieldInfoPtr_isCompiling;

		// Token: 0x0400270C RID: 9996
		private static readonly IntPtr NativeFieldInfoPtr_style_wordWrap;

		// Token: 0x0400270D RID: 9997
		private static readonly IntPtr NativeFieldInfoPtr_style_centeredBox;

		// Token: 0x0400270E RID: 9998
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400270F RID: 9999
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002710 RID: 10000
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002711 RID: 10001
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x04002712 RID: 10002
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Private_Void_0;

		// Token: 0x04002713 RID: 10003
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Private_Void_0;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeMethodInfoPtr_HandleMenuControl_Private_Void_0;

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_0;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeMethodInfoPtr_DrawPage_Private_Void_0;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_DrawMapCategories_Private_Void_0;

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeMethodInfoPtr_ShowDialog_Private_Void_0;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0;

		// Token: 0x04002727 RID: 10023
		private static readonly IntPtr NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0;

		// Token: 0x04002728 RID: 10024
		private static readonly IntPtr NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0;

		// Token: 0x04002729 RID: 10025
		private static readonly IntPtr NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0;

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0;

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0;

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0;

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0;

		// Token: 0x04002730 RID: 10032
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0;

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeMethodInfoPtr_ProcessQueue_Private_Void_0;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0;

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr_ClearMapSelection_Private_Void_0;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeMethodInfoPtr_ResetAll_Private_Void_0;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr_CheckRecompile_Protected_Void_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039D RID: 925
		public class ControllerSelection : global::Il2CppSystem.Object
		{
			// Token: 0x06005853 RID: 22611 RVA: 0x00140424 File Offset: 0x0013E624
			// Note: this type is marked as 'beforefieldinit'.
			static ControllerSelection()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "ControllerSelection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr);
				ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, "_id");
				ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__idPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, "_idPrev");
				ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, "_type");
				ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__typePrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, "_typePrev");
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669469);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669470);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669471);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669472);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669473);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669474);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669475);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669476);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669477);
				ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr, 100669478);
			}

			// Token: 0x06005854 RID: 22612 RVA: 0x00140568 File Offset: 0x0013E768
			[CallerCount(0)]
			public unsafe ControllerSelection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.ControllerSelection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700204E RID: 8270
			// (get) Token: 0x06005855 RID: 22613 RVA: 0x001405A4 File Offset: 0x0013E7A4
			// (set) Token: 0x06005856 RID: 22614 RVA: 0x001405E0 File Offset: 0x0013E7E0
			public unsafe int id
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700204F RID: 8271
			// (get) Token: 0x06005857 RID: 22615 RVA: 0x00140620 File Offset: 0x0013E820
			// (set) Token: 0x06005858 RID: 22616 RVA: 0x0014065C File Offset: 0x0013E85C
			public unsafe ControllerType type
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002050 RID: 8272
			// (get) Token: 0x06005859 RID: 22617 RVA: 0x0014069C File Offset: 0x0013E89C
			public unsafe int idPrev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002051 RID: 8273
			// (get) Token: 0x0600585A RID: 22618 RVA: 0x001406D8 File Offset: 0x0013E8D8
			public unsafe ControllerType typePrev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002052 RID: 8274
			// (get) Token: 0x0600585B RID: 22619 RVA: 0x00140714 File Offset: 0x0013E914
			public unsafe bool hasSelection
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600585C RID: 22620 RVA: 0x00140750 File Offset: 0x0013E950
			[CallerCount(0)]
			public unsafe void Set(int id, ControllerType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600585D RID: 22621 RVA: 0x0014079C File Offset: 0x0013E99C
			[CallerCount(0)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ControllerSelection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600585E RID: 22622 RVA: 0x00032AFF File Offset: 0x00030CFF
			public ControllerSelection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700204A RID: 8266
			// (get) Token: 0x0600585F RID: 22623 RVA: 0x001407D0 File Offset: 0x0013E9D0
			// (set) Token: 0x06005860 RID: 22624 RVA: 0x00032B08 File Offset: 0x00030D08
			public unsafe int _id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__id)) = value;
				}
			}

			// Token: 0x1700204B RID: 8267
			// (get) Token: 0x06005861 RID: 22625 RVA: 0x001407F8 File Offset: 0x0013E9F8
			// (set) Token: 0x06005862 RID: 22626 RVA: 0x00032B23 File Offset: 0x00030D23
			public unsafe int _idPrev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__idPrev);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__idPrev)) = value;
				}
			}

			// Token: 0x1700204C RID: 8268
			// (get) Token: 0x06005863 RID: 22627 RVA: 0x00140820 File Offset: 0x0013EA20
			// (set) Token: 0x06005864 RID: 22628 RVA: 0x00032B3E File Offset: 0x00030D3E
			public unsafe ControllerType _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__type)) = value;
				}
			}

			// Token: 0x1700204D RID: 8269
			// (get) Token: 0x06005865 RID: 22629 RVA: 0x00140848 File Offset: 0x0013EA48
			// (set) Token: 0x06005866 RID: 22630 RVA: 0x00032B59 File Offset: 0x00030D59
			public unsafe ControllerType _typePrev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__typePrev);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ControllerSelection.NativeFieldInfoPtr__typePrev)) = value;
				}
			}

			// Token: 0x04003AA5 RID: 15013
			private static readonly IntPtr NativeFieldInfoPtr__id;

			// Token: 0x04003AA6 RID: 15014
			private static readonly IntPtr NativeFieldInfoPtr__idPrev;

			// Token: 0x04003AA7 RID: 15015
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x04003AA8 RID: 15016
			private static readonly IntPtr NativeFieldInfoPtr__typePrev;

			// Token: 0x04003AA9 RID: 15017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003AAA RID: 15018
			private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

			// Token: 0x04003AAB RID: 15019
			private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

			// Token: 0x04003AAC RID: 15020
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_ControllerType_0;

			// Token: 0x04003AAD RID: 15021
			private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0;

			// Token: 0x04003AAE RID: 15022
			private static readonly IntPtr NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0;

			// Token: 0x04003AAF RID: 15023
			private static readonly IntPtr NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0;

			// Token: 0x04003AB0 RID: 15024
			private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0;

			// Token: 0x04003AB1 RID: 15025
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0;

			// Token: 0x04003AB2 RID: 15026
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
		}

		// Token: 0x0200039E RID: 926
		public class DialogHelper : global::Il2CppSystem.Object
		{
			// Token: 0x06005867 RID: 22631 RVA: 0x00140870 File Offset: 0x0013EA70
			// Note: this type is marked as 'beforefieldinit'.
			static DialogHelper()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "DialogHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr);
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_openBusyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "openBusyDelay");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_closeBusyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "closeBusyDelay");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "_type");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "_enabled");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "_busyTime");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTimerRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "_busyTimerRunning");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "drawWindowDelegate");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "drawWindowFunction");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_windowProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "windowProperties");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_currentActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "currentActionId");
				ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_resultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, "resultCallback");
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669479);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669480);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669481);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_type_Public_get_DialogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669482);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669483);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669484);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669485);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669486);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669487);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669488);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669489);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669490);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669491);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669492);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669493);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669494);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669495);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669496);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669497);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669498);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669499);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_UpdateTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669500);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669501);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669502);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StateChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669503);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669504);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_ResetTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669505);
				ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_FullReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr, 100669506);
			}

			// Token: 0x1700205E RID: 8286
			// (get) Token: 0x06005868 RID: 22632 RVA: 0x00140BA8 File Offset: 0x0013EDA8
			public unsafe float busyTimer
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100983, XrefRangeEnd = 100985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700205F RID: 8287
			// (get) Token: 0x06005869 RID: 22633 RVA: 0x00140BE4 File Offset: 0x0013EDE4
			// (set) Token: 0x0600586A RID: 22634 RVA: 0x00140C20 File Offset: 0x0013EE20
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100985, XrefRangeEnd = 100987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002060 RID: 8288
			// (get) Token: 0x0600586B RID: 22635 RVA: 0x00140C60 File Offset: 0x0013EE60
			// (set) Token: 0x0600586C RID: 22636 RVA: 0x00140C9C File Offset: 0x0013EE9C
			public unsafe ControlRemappingDemo1.DialogHelper.DialogType type
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_type_Public_get_DialogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100987, XrefRangeEnd = 100991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002061 RID: 8289
			// (get) Token: 0x0600586D RID: 22637 RVA: 0x00140CDC File Offset: 0x0013EEDC
			public unsafe bool busy
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_get_busy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600586E RID: 22638 RVA: 0x00140D18 File Offset: 0x0013EF18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101002, RefRangeEnd = 101003, XrefRangeStart = 100991, XrefRangeEnd = 101002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DialogHelper()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.DialogHelper>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600586F RID: 22639 RVA: 0x00140D54 File Offset: 0x0013EF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101003, XrefRangeEnd = 101004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartModal(int queueActionId, ControlRemappingDemo1.DialogHelper.DialogType type, ControlRemappingDemo1.WindowProperties windowProperties, Action<int, ControlRemappingDemo1.UserResponse> resultCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref queueActionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(windowProperties));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005870 RID: 22640 RVA: 0x00140DCC File Offset: 0x0013EFCC
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 101009, RefRangeEnd = 101017, XrefRangeStart = 101004, XrefRangeEnd = 101009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartModal(int queueActionId, ControlRemappingDemo1.DialogHelper.DialogType type, ControlRemappingDemo1.WindowProperties windowProperties, Action<int, ControlRemappingDemo1.UserResponse> resultCallback, float openBusyDelay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref queueActionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(windowProperties));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openBusyDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005871 RID: 22641 RVA: 0x00140E50 File Offset: 0x0013F050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101017, XrefRangeEnd = 101020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005872 RID: 22642 RVA: 0x00140E84 File Offset: 0x0013F084
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101039, RefRangeEnd = 101042, XrefRangeStart = 101020, XrefRangeEnd = 101039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Draw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005873 RID: 22643 RVA: 0x00140EB8 File Offset: 0x0013F0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101042, XrefRangeEnd = 101045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawConfirmButton()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005874 RID: 22644 RVA: 0x00140EEC File Offset: 0x0013F0EC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 101070, RefRangeEnd = 101074, XrefRangeStart = 101045, XrefRangeEnd = 101070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawConfirmButton(string title)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005875 RID: 22645 RVA: 0x00140F30 File Offset: 0x0013F130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101074, XrefRangeEnd = 101077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawConfirmButton(ControlRemappingDemo1.UserResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref response;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005876 RID: 22646 RVA: 0x00140F70 File Offset: 0x0013F170
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 101099, RefRangeEnd = 101103, XrefRangeStart = 101077, XrefRangeEnd = 101099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawConfirmButton(ControlRemappingDemo1.UserResponse response, string title)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref response;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005877 RID: 22647 RVA: 0x00140FC0 File Offset: 0x0013F1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101103, XrefRangeEnd = 101106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawCancelButton()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005878 RID: 22648 RVA: 0x00140FF4 File Offset: 0x0013F1F4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 101131, RefRangeEnd = 101136, XrefRangeStart = 101106, XrefRangeEnd = 101131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawCancelButton(string title)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005879 RID: 22649 RVA: 0x00141038 File Offset: 0x0013F238
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 101141, RefRangeEnd = 101143, XrefRangeStart = 101136, XrefRangeEnd = 101141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Confirm()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600587A RID: 22650 RVA: 0x0014106C File Offset: 0x0013F26C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101148, RefRangeEnd = 101149, XrefRangeStart = 101143, XrefRangeEnd = 101148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Confirm(ControlRemappingDemo1.UserResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref response;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600587B RID: 22651 RVA: 0x001410AC File Offset: 0x0013F2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101149, XrefRangeEnd = 101154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600587C RID: 22652 RVA: 0x001410E0 File Offset: 0x0013F2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101154, XrefRangeEnd = 101158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DrawWindow(int windowId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref windowId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600587D RID: 22653 RVA: 0x00141120 File Offset: 0x0013F320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101158, XrefRangeEnd = 101160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTimers()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_UpdateTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600587E RID: 22654 RVA: 0x00141154 File Offset: 0x0013F354
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101162, RefRangeEnd = 101163, XrefRangeStart = 101160, XrefRangeEnd = 101162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartBusyTimer(float time)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600587F RID: 22655 RVA: 0x00141194 File Offset: 0x0013F394
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 101165, RefRangeEnd = 101170, XrefRangeStart = 101163, XrefRangeEnd = 101165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005880 RID: 22656 RVA: 0x001411C8 File Offset: 0x0013F3C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101162, RefRangeEnd = 101163, XrefRangeStart = 101162, XrefRangeEnd = 101163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StateChanged(float delay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref delay;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_StateChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005881 RID: 22657 RVA: 0x00141208 File Offset: 0x0013F408
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005882 RID: 22658 RVA: 0x0014123C File Offset: 0x0013F43C
			[CallerCount(0)]
			public unsafe void ResetTimers()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_ResetTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005883 RID: 22659 RVA: 0x00141270 File Offset: 0x0013F470
			[CallerCount(0)]
			public unsafe void FullReset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.DialogHelper.NativeMethodInfoPtr_FullReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005884 RID: 22660 RVA: 0x00032B74 File Offset: 0x00030D74
			public DialogHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002053 RID: 8275
			// (get) Token: 0x06005885 RID: 22661 RVA: 0x001412A4 File Offset: 0x0013F4A4
			// (set) Token: 0x06005886 RID: 22662 RVA: 0x00032B7D File Offset: 0x00030D7D
			public unsafe static float openBusyDelay
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_openBusyDelay, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_openBusyDelay, (void*)(&value));
				}
			}

			// Token: 0x17002054 RID: 8276
			// (get) Token: 0x06005887 RID: 22663 RVA: 0x001412C0 File Offset: 0x0013F4C0
			// (set) Token: 0x06005888 RID: 22664 RVA: 0x00032B8B File Offset: 0x00030D8B
			public unsafe static float closeBusyDelay
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_closeBusyDelay, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_closeBusyDelay, (void*)(&value));
				}
			}

			// Token: 0x17002055 RID: 8277
			// (get) Token: 0x06005889 RID: 22665 RVA: 0x001412DC File Offset: 0x0013F4DC
			// (set) Token: 0x0600588A RID: 22666 RVA: 0x00032B99 File Offset: 0x00030D99
			public unsafe ControlRemappingDemo1.DialogHelper.DialogType _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__type)) = value;
				}
			}

			// Token: 0x17002056 RID: 8278
			// (get) Token: 0x0600588B RID: 22667 RVA: 0x00141304 File Offset: 0x0013F504
			// (set) Token: 0x0600588C RID: 22668 RVA: 0x00032BB4 File Offset: 0x00030DB4
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x17002057 RID: 8279
			// (get) Token: 0x0600588D RID: 22669 RVA: 0x0014132C File Offset: 0x0013F52C
			// (set) Token: 0x0600588E RID: 22670 RVA: 0x00032BCF File Offset: 0x00030DCF
			public unsafe float _busyTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTime)) = value;
				}
			}

			// Token: 0x17002058 RID: 8280
			// (get) Token: 0x0600588F RID: 22671 RVA: 0x00141354 File Offset: 0x0013F554
			// (set) Token: 0x06005890 RID: 22672 RVA: 0x00032BEA File Offset: 0x00030DEA
			public unsafe bool _busyTimerRunning
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTimerRunning);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr__busyTimerRunning)) = value;
				}
			}

			// Token: 0x17002059 RID: 8281
			// (get) Token: 0x06005891 RID: 22673 RVA: 0x0014137C File Offset: 0x0013F57C
			// (set) Token: 0x06005892 RID: 22674 RVA: 0x00032C05 File Offset: 0x00030E05
			public unsafe Action<int> drawWindowDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700205A RID: 8282
			// (get) Token: 0x06005893 RID: 22675 RVA: 0x001413AC File Offset: 0x0013F5AC
			// (set) Token: 0x06005894 RID: 22676 RVA: 0x00032C24 File Offset: 0x00030E24
			public unsafe GUI.WindowFunction drawWindowFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUI.WindowFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_drawWindowFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700205B RID: 8283
			// (get) Token: 0x06005895 RID: 22677 RVA: 0x001413DC File Offset: 0x0013F5DC
			// (set) Token: 0x06005896 RID: 22678 RVA: 0x00032C43 File Offset: 0x00030E43
			public ControlRemappingDemo1.WindowProperties windowProperties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_windowProperties);
					return new ControlRemappingDemo1.WindowProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_windowProperties), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700205C RID: 8284
			// (get) Token: 0x06005897 RID: 22679 RVA: 0x0014140C File Offset: 0x0013F60C
			// (set) Token: 0x06005898 RID: 22680 RVA: 0x00032C71 File Offset: 0x00030E71
			public unsafe int currentActionId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_currentActionId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_currentActionId)) = value;
				}
			}

			// Token: 0x1700205D RID: 8285
			// (get) Token: 0x06005899 RID: 22681 RVA: 0x00141434 File Offset: 0x0013F634
			// (set) Token: 0x0600589A RID: 22682 RVA: 0x00032C8C File Offset: 0x00030E8C
			public unsafe Action<int, ControlRemappingDemo1.UserResponse> resultCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_resultCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ControlRemappingDemo1.UserResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.DialogHelper.NativeFieldInfoPtr_resultCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003AB3 RID: 15027
			private static readonly IntPtr NativeFieldInfoPtr_openBusyDelay;

			// Token: 0x04003AB4 RID: 15028
			private static readonly IntPtr NativeFieldInfoPtr_closeBusyDelay;

			// Token: 0x04003AB5 RID: 15029
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x04003AB6 RID: 15030
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x04003AB7 RID: 15031
			private static readonly IntPtr NativeFieldInfoPtr__busyTime;

			// Token: 0x04003AB8 RID: 15032
			private static readonly IntPtr NativeFieldInfoPtr__busyTimerRunning;

			// Token: 0x04003AB9 RID: 15033
			private static readonly IntPtr NativeFieldInfoPtr_drawWindowDelegate;

			// Token: 0x04003ABA RID: 15034
			private static readonly IntPtr NativeFieldInfoPtr_drawWindowFunction;

			// Token: 0x04003ABB RID: 15035
			private static readonly IntPtr NativeFieldInfoPtr_windowProperties;

			// Token: 0x04003ABC RID: 15036
			private static readonly IntPtr NativeFieldInfoPtr_currentActionId;

			// Token: 0x04003ABD RID: 15037
			private static readonly IntPtr NativeFieldInfoPtr_resultCallback;

			// Token: 0x04003ABE RID: 15038
			private static readonly IntPtr NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0;

			// Token: 0x04003ABF RID: 15039
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04003AC0 RID: 15040
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04003AC1 RID: 15041
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_DialogType_0;

			// Token: 0x04003AC2 RID: 15042
			private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0;

			// Token: 0x04003AC3 RID: 15043
			private static readonly IntPtr NativeMethodInfoPtr_get_busy_Public_get_Boolean_0;

			// Token: 0x04003AC4 RID: 15044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003AC5 RID: 15045
			private static readonly IntPtr NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0;

			// Token: 0x04003AC6 RID: 15046
			private static readonly IntPtr NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0;

			// Token: 0x04003AC7 RID: 15047
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

			// Token: 0x04003AC8 RID: 15048
			private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;

			// Token: 0x04003AC9 RID: 15049
			private static readonly IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0;

			// Token: 0x04003ACA RID: 15050
			private static readonly IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0;

			// Token: 0x04003ACB RID: 15051
			private static readonly IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0;

			// Token: 0x04003ACC RID: 15052
			private static readonly IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0;

			// Token: 0x04003ACD RID: 15053
			private static readonly IntPtr NativeMethodInfoPtr_DrawCancelButton_Public_Void_0;

			// Token: 0x04003ACE RID: 15054
			private static readonly IntPtr NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0;

			// Token: 0x04003ACF RID: 15055
			private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

			// Token: 0x04003AD0 RID: 15056
			private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0;

			// Token: 0x04003AD1 RID: 15057
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

			// Token: 0x04003AD2 RID: 15058
			private static readonly IntPtr NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0;

			// Token: 0x04003AD3 RID: 15059
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTimers_Private_Void_0;

			// Token: 0x04003AD4 RID: 15060
			private static readonly IntPtr NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0;

			// Token: 0x04003AD5 RID: 15061
			private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

			// Token: 0x04003AD6 RID: 15062
			private static readonly IntPtr NativeMethodInfoPtr_StateChanged_Private_Void_Single_0;

			// Token: 0x04003AD7 RID: 15063
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

			// Token: 0x04003AD8 RID: 15064
			private static readonly IntPtr NativeMethodInfoPtr_ResetTimers_Private_Void_0;

			// Token: 0x04003AD9 RID: 15065
			private static readonly IntPtr NativeMethodInfoPtr_FullReset_Public_Void_0;

			// Token: 0x0200040E RID: 1038
			[OriginalName("Assembly-CSharp.dll", "", "DialogType")]
			public enum DialogType
			{
				// Token: 0x04003D32 RID: 15666
				None,
				// Token: 0x04003D33 RID: 15667
				JoystickConflict,
				// Token: 0x04003D34 RID: 15668
				ElementConflict,
				// Token: 0x04003D35 RID: 15669
				KeyConflict,
				// Token: 0x04003D36 RID: 15670
				DeleteAssignmentConfirmation = 10,
				// Token: 0x04003D37 RID: 15671
				AssignElement
			}
		}

		// Token: 0x0200039F RID: 927
		public class QueueEntry : global::Il2CppSystem.Object
		{
			// Token: 0x0600589B RID: 22683 RVA: 0x00141464 File Offset: 0x0013F664
			// Note: this type is marked as 'beforefieldinit'.
			static QueueEntry()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "QueueEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr);
				ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<id>k__BackingField");
				ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__queueActionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<queueActionType>k__BackingField");
				ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<state>k__BackingField");
				ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__response_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "<response>k__BackingField");
				ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr_uidCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, "uidCounter");
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669507);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669508);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669509);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669510);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_state_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669511);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_state_Protected_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669512);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_response_Public_get_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669513);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669514);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669515);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669516);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669517);
				ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr, 100669518);
			}

			// Token: 0x17002067 RID: 8295
			// (get) Token: 0x0600589C RID: 22684 RVA: 0x001415E4 File Offset: 0x0013F7E4
			// (set) Token: 0x0600589D RID: 22685 RVA: 0x00141620 File Offset: 0x0013F820
			public unsafe int id
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002068 RID: 8296
			// (get) Token: 0x0600589E RID: 22686 RVA: 0x00141660 File Offset: 0x0013F860
			// (set) Token: 0x0600589F RID: 22687 RVA: 0x0014169C File Offset: 0x0013F89C
			public unsafe ControlRemappingDemo1.QueueActionType queueActionType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002069 RID: 8297
			// (get) Token: 0x060058A0 RID: 22688 RVA: 0x001416DC File Offset: 0x0013F8DC
			// (set) Token: 0x060058A1 RID: 22689 RVA: 0x00141718 File Offset: 0x0013F918
			public unsafe ControlRemappingDemo1.QueueEntry.State state
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_state_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_state_Protected_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700206A RID: 8298
			// (get) Token: 0x060058A2 RID: 22690 RVA: 0x00141758 File Offset: 0x0013F958
			// (set) Token: 0x060058A3 RID: 22691 RVA: 0x00141794 File Offset: 0x0013F994
			public unsafe ControlRemappingDemo1.UserResponse response
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_response_Public_get_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700206B RID: 8299
			// (get) Token: 0x060058A4 RID: 22692 RVA: 0x001417D4 File Offset: 0x0013F9D4
			public unsafe static int nextId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101170, XrefRangeEnd = 101172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060058A5 RID: 22693 RVA: 0x00141804 File Offset: 0x0013FA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101172, XrefRangeEnd = 101174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueueEntry(ControlRemappingDemo1.QueueActionType queueActionType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.QueueEntry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref queueActionType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058A6 RID: 22694 RVA: 0x0014184C File Offset: 0x0013FA4C
			[CallerCount(0)]
			public unsafe void Confirm(ControlRemappingDemo1.UserResponse response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref response;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058A7 RID: 22695 RVA: 0x0014188C File Offset: 0x0013FA8C
			[CallerCount(0)]
			public unsafe void Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.QueueEntry.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058A8 RID: 22696 RVA: 0x00032CAB File Offset: 0x00030EAB
			public QueueEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002062 RID: 8290
			// (get) Token: 0x060058A9 RID: 22697 RVA: 0x001418C0 File Offset: 0x0013FAC0
			// (set) Token: 0x060058AA RID: 22698 RVA: 0x00032CB4 File Offset: 0x00030EB4
			public unsafe int _id_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__id_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__id_k__BackingField)) = value;
				}
			}

			// Token: 0x17002063 RID: 8291
			// (get) Token: 0x060058AB RID: 22699 RVA: 0x001418E8 File Offset: 0x0013FAE8
			// (set) Token: 0x060058AC RID: 22700 RVA: 0x00032CCF File Offset: 0x00030ECF
			public unsafe ControlRemappingDemo1.QueueActionType _queueActionType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__queueActionType_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__queueActionType_k__BackingField)) = value;
				}
			}

			// Token: 0x17002064 RID: 8292
			// (get) Token: 0x060058AD RID: 22701 RVA: 0x00141910 File Offset: 0x0013FB10
			// (set) Token: 0x060058AE RID: 22702 RVA: 0x00032CEA File Offset: 0x00030EEA
			public unsafe ControlRemappingDemo1.QueueEntry.State _state_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__state_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__state_k__BackingField)) = value;
				}
			}

			// Token: 0x17002065 RID: 8293
			// (get) Token: 0x060058AF RID: 22703 RVA: 0x00141938 File Offset: 0x0013FB38
			// (set) Token: 0x060058B0 RID: 22704 RVA: 0x00032D05 File Offset: 0x00030F05
			public unsafe ControlRemappingDemo1.UserResponse _response_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__response_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr__response_k__BackingField)) = value;
				}
			}

			// Token: 0x17002066 RID: 8294
			// (get) Token: 0x060058B1 RID: 22705 RVA: 0x00141960 File Offset: 0x0013FB60
			// (set) Token: 0x060058B2 RID: 22706 RVA: 0x00032D20 File Offset: 0x00030F20
			public unsafe static int uidCounter
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr_uidCounter, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControlRemappingDemo1.QueueEntry.NativeFieldInfoPtr_uidCounter, (void*)(&value));
				}
			}

			// Token: 0x04003ADA RID: 15066
			private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

			// Token: 0x04003ADB RID: 15067
			private static readonly IntPtr NativeFieldInfoPtr__queueActionType_k__BackingField;

			// Token: 0x04003ADC RID: 15068
			private static readonly IntPtr NativeFieldInfoPtr__state_k__BackingField;

			// Token: 0x04003ADD RID: 15069
			private static readonly IntPtr NativeFieldInfoPtr__response_k__BackingField;

			// Token: 0x04003ADE RID: 15070
			private static readonly IntPtr NativeFieldInfoPtr_uidCounter;

			// Token: 0x04003ADF RID: 15071
			private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

			// Token: 0x04003AE0 RID: 15072
			private static readonly IntPtr NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0;

			// Token: 0x04003AE1 RID: 15073
			private static readonly IntPtr NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0;

			// Token: 0x04003AE2 RID: 15074
			private static readonly IntPtr NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0;

			// Token: 0x04003AE3 RID: 15075
			private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_get_State_0;

			// Token: 0x04003AE4 RID: 15076
			private static readonly IntPtr NativeMethodInfoPtr_set_state_Protected_set_Void_State_0;

			// Token: 0x04003AE5 RID: 15077
			private static readonly IntPtr NativeMethodInfoPtr_get_response_Public_get_UserResponse_0;

			// Token: 0x04003AE6 RID: 15078
			private static readonly IntPtr NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0;

			// Token: 0x04003AE7 RID: 15079
			private static readonly IntPtr NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0;

			// Token: 0x04003AE8 RID: 15080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0;

			// Token: 0x04003AE9 RID: 15081
			private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0;

			// Token: 0x04003AEA RID: 15082
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

			// Token: 0x0200040F RID: 1039
			[OriginalName("Assembly-CSharp.dll", "", "State")]
			public enum State
			{
				// Token: 0x04003D39 RID: 15673
				Waiting,
				// Token: 0x04003D3A RID: 15674
				Confirmed,
				// Token: 0x04003D3B RID: 15675
				Canceled
			}
		}

		// Token: 0x020003A0 RID: 928
		public class JoystickAssignmentChange : ControlRemappingDemo1.QueueEntry
		{
			// Token: 0x060058B3 RID: 22707 RVA: 0x0014197C File Offset: 0x0013FB7C
			// Note: this type is marked as 'beforefieldinit'.
			static JoystickAssignmentChange()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "JoystickAssignmentChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, "<playerId>k__BackingField");
				ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__joystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, "<joystickId>k__BackingField");
				ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__assign_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, "<assign>k__BackingField");
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669519);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669520);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669521);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669522);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_assign_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669523);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669524);
				ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr, 100669525);
			}

			// Token: 0x1700206F RID: 8303
			// (get) Token: 0x060058B4 RID: 22708 RVA: 0x00141A70 File Offset: 0x0013FC70
			// (set) Token: 0x060058B5 RID: 22709 RVA: 0x00141AAC File Offset: 0x0013FCAC
			public unsafe int playerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002070 RID: 8304
			// (get) Token: 0x060058B6 RID: 22710 RVA: 0x00141AEC File Offset: 0x0013FCEC
			// (set) Token: 0x060058B7 RID: 22711 RVA: 0x00141B28 File Offset: 0x0013FD28
			public unsafe int joystickId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002071 RID: 8305
			// (get) Token: 0x060058B8 RID: 22712 RVA: 0x00141B68 File Offset: 0x0013FD68
			// (set) Token: 0x060058B9 RID: 22713 RVA: 0x00141BA4 File Offset: 0x0013FDA4
			public unsafe bool assign
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_get_assign_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060058BA RID: 22714 RVA: 0x00141BE4 File Offset: 0x0013FDE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101176, RefRangeEnd = 101177, XrefRangeStart = 101174, XrefRangeEnd = 101176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.JoystickAssignmentChange>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref newPlayerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref joystickId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.JoystickAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058BB RID: 22715 RVA: 0x00032D2E File Offset: 0x00030F2E
			public JoystickAssignmentChange(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700206C RID: 8300
			// (get) Token: 0x060058BC RID: 22716 RVA: 0x00141C48 File Offset: 0x0013FE48
			// (set) Token: 0x060058BD RID: 22717 RVA: 0x00032D37 File Offset: 0x00030F37
			public unsafe int _playerId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__playerId_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__playerId_k__BackingField)) = value;
				}
			}

			// Token: 0x1700206D RID: 8301
			// (get) Token: 0x060058BE RID: 22718 RVA: 0x00141C70 File Offset: 0x0013FE70
			// (set) Token: 0x060058BF RID: 22719 RVA: 0x00032D52 File Offset: 0x00030F52
			public unsafe int _joystickId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__joystickId_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__joystickId_k__BackingField)) = value;
				}
			}

			// Token: 0x1700206E RID: 8302
			// (get) Token: 0x060058C0 RID: 22720 RVA: 0x00141C98 File Offset: 0x0013FE98
			// (set) Token: 0x060058C1 RID: 22721 RVA: 0x00032D6D File Offset: 0x00030F6D
			public unsafe bool _assign_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__assign_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.JoystickAssignmentChange.NativeFieldInfoPtr__assign_k__BackingField)) = value;
				}
			}

			// Token: 0x04003AEB RID: 15083
			private static readonly IntPtr NativeFieldInfoPtr__playerId_k__BackingField;

			// Token: 0x04003AEC RID: 15084
			private static readonly IntPtr NativeFieldInfoPtr__joystickId_k__BackingField;

			// Token: 0x04003AED RID: 15085
			private static readonly IntPtr NativeFieldInfoPtr__assign_k__BackingField;

			// Token: 0x04003AEE RID: 15086
			private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

			// Token: 0x04003AEF RID: 15087
			private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0;

			// Token: 0x04003AF0 RID: 15088
			private static readonly IntPtr NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0;

			// Token: 0x04003AF1 RID: 15089
			private static readonly IntPtr NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0;

			// Token: 0x04003AF2 RID: 15090
			private static readonly IntPtr NativeMethodInfoPtr_get_assign_Public_get_Boolean_0;

			// Token: 0x04003AF3 RID: 15091
			private static readonly IntPtr NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0;

			// Token: 0x04003AF4 RID: 15092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;
		}

		// Token: 0x020003A1 RID: 929
		public class ElementAssignmentChange : ControlRemappingDemo1.QueueEntry
		{
			// Token: 0x060058C2 RID: 22722 RVA: 0x00141CC0 File Offset: 0x0013FEC0
			// Note: this type is marked as 'beforefieldinit'.
			static ElementAssignmentChange()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "ElementAssignmentChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr);
				ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__changeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, "<changeType>k__BackingField");
				ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, "<context>k__BackingField");
				ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100669526);
				ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100669527);
				ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100669528);
				ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_context_Private_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100669529);
				ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100669530);
				ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr, 100669531);
			}

			// Token: 0x17002074 RID: 8308
			// (get) Token: 0x060058C3 RID: 22723 RVA: 0x00141D8C File Offset: 0x0013FF8C
			// (set) Token: 0x060058C4 RID: 22724 RVA: 0x00141DC8 File Offset: 0x0013FFC8
			public unsafe ControlRemappingDemo1.ElementAssignmentChangeType changeType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002075 RID: 8309
			// (get) Token: 0x060058C5 RID: 22725 RVA: 0x00141E08 File Offset: 0x00140008
			// (set) Token: 0x060058C6 RID: 22726 RVA: 0x00141E48 File Offset: 0x00140048
			public unsafe InputMapper.Context context
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_get_context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr3) : null;
				}
				[CallerCount(38)]
				[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr_set_context_Private_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060058C7 RID: 22727 RVA: 0x00141E8C File Offset: 0x0014008C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101179, RefRangeEnd = 101182, XrefRangeStart = 101177, XrefRangeEnd = 101179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementAssignmentChange(ControlRemappingDemo1.ElementAssignmentChangeType changeType, InputMapper.Context context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref changeType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058C8 RID: 22728 RVA: 0x00141EE8 File Offset: 0x001400E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101189, RefRangeEnd = 101190, XrefRangeStart = 101182, XrefRangeEnd = 101189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementAssignmentChange(ControlRemappingDemo1.ElementAssignmentChange other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.ElementAssignmentChange>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.ElementAssignmentChange.NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058C9 RID: 22729 RVA: 0x00032D88 File Offset: 0x00030F88
			public ElementAssignmentChange(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002072 RID: 8306
			// (get) Token: 0x060058CA RID: 22730 RVA: 0x00141F34 File Offset: 0x00140134
			// (set) Token: 0x060058CB RID: 22731 RVA: 0x00032D91 File Offset: 0x00030F91
			public unsafe ControlRemappingDemo1.ElementAssignmentChangeType _changeType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__changeType_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__changeType_k__BackingField)) = value;
				}
			}

			// Token: 0x17002073 RID: 8307
			// (get) Token: 0x060058CC RID: 22732 RVA: 0x00141F5C File Offset: 0x0014015C
			// (set) Token: 0x060058CD RID: 22733 RVA: 0x00032DAC File Offset: 0x00030FAC
			public unsafe InputMapper.Context _context_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__context_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.ElementAssignmentChange.NativeFieldInfoPtr__context_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003AF5 RID: 15093
			private static readonly IntPtr NativeFieldInfoPtr__changeType_k__BackingField;

			// Token: 0x04003AF6 RID: 15094
			private static readonly IntPtr NativeFieldInfoPtr__context_k__BackingField;

			// Token: 0x04003AF7 RID: 15095
			private static readonly IntPtr NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0;

			// Token: 0x04003AF8 RID: 15096
			private static readonly IntPtr NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0;

			// Token: 0x04003AF9 RID: 15097
			private static readonly IntPtr NativeMethodInfoPtr_get_context_Public_get_Context_0;

			// Token: 0x04003AFA RID: 15098
			private static readonly IntPtr NativeMethodInfoPtr_set_context_Private_set_Void_Context_0;

			// Token: 0x04003AFB RID: 15099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0;

			// Token: 0x04003AFC RID: 15100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0;
		}

		// Token: 0x020003A2 RID: 930
		public class FallbackJoystickIdentification : ControlRemappingDemo1.QueueEntry
		{
			// Token: 0x060058CE RID: 22734 RVA: 0x00141F8C File Offset: 0x0014018C
			// Note: this type is marked as 'beforefieldinit'.
			static FallbackJoystickIdentification()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "FallbackJoystickIdentification");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr);
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, "<joystickId>k__BackingField");
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, "<joystickName>k__BackingField");
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100669532);
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100669533);
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100669534);
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100669535);
				ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr, 100669536);
			}

			// Token: 0x17002078 RID: 8312
			// (get) Token: 0x060058CF RID: 22735 RVA: 0x00142044 File Offset: 0x00140244
			// (set) Token: 0x060058D0 RID: 22736 RVA: 0x00142080 File Offset: 0x00140280
			public unsafe int joystickId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002079 RID: 8313
			// (get) Token: 0x060058D1 RID: 22737 RVA: 0x001420C0 File Offset: 0x001402C0
			// (set) Token: 0x060058D2 RID: 22738 RVA: 0x001420F8 File Offset: 0x001402F8
			public unsafe string joystickName
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_get_joystickName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(38)]
				[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060058D3 RID: 22739 RVA: 0x0014213C File Offset: 0x0014033C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101190, XrefRangeEnd = 101192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FallbackJoystickIdentification(int joystickId, string joystickName)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.FallbackJoystickIdentification>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(joystickName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.FallbackJoystickIdentification.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058D4 RID: 22740 RVA: 0x00032DCB File Offset: 0x00030FCB
			public FallbackJoystickIdentification(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002076 RID: 8310
			// (get) Token: 0x060058D5 RID: 22741 RVA: 0x00142198 File Offset: 0x00140398
			// (set) Token: 0x060058D6 RID: 22742 RVA: 0x00032DD4 File Offset: 0x00030FD4
			public unsafe int _joystickId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickId_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickId_k__BackingField)) = value;
				}
			}

			// Token: 0x17002077 RID: 8311
			// (get) Token: 0x060058D7 RID: 22743 RVA: 0x001421C0 File Offset: 0x001403C0
			// (set) Token: 0x060058D8 RID: 22744 RVA: 0x00032DEF File Offset: 0x00030FEF
			public unsafe string _joystickName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.FallbackJoystickIdentification.NativeFieldInfoPtr__joystickName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003AFD RID: 15101
			private static readonly IntPtr NativeFieldInfoPtr__joystickId_k__BackingField;

			// Token: 0x04003AFE RID: 15102
			private static readonly IntPtr NativeFieldInfoPtr__joystickName_k__BackingField;

			// Token: 0x04003AFF RID: 15103
			private static readonly IntPtr NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0;

			// Token: 0x04003B00 RID: 15104
			private static readonly IntPtr NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0;

			// Token: 0x04003B01 RID: 15105
			private static readonly IntPtr NativeMethodInfoPtr_get_joystickName_Public_get_String_0;

			// Token: 0x04003B02 RID: 15106
			private static readonly IntPtr NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0;

			// Token: 0x04003B03 RID: 15107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;
		}

		// Token: 0x020003A3 RID: 931
		public class Calibration : ControlRemappingDemo1.QueueEntry
		{
			// Token: 0x060058D9 RID: 22745 RVA: 0x001421E8 File Offset: 0x001403E8
			// Note: this type is marked as 'beforefieldinit'.
			static Calibration()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "Calibration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr);
				ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<player>k__BackingField");
				ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<controllerType>k__BackingField");
				ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__joystick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<joystick>k__BackingField");
				ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__calibrationMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "<calibrationMap>k__BackingField");
				ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_selectedElementIdentifierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "selectedElementIdentifierId");
				ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_recording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, "recording");
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669537);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669538);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669539);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669540);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669541);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669542);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669543);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669544);
				ControlRemappingDemo1.Calibration.NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr, 100669545);
			}

			// Token: 0x17002080 RID: 8320
			// (get) Token: 0x060058DA RID: 22746 RVA: 0x00142340 File Offset: 0x00140540
			// (set) Token: 0x060058DB RID: 22747 RVA: 0x00142380 File Offset: 0x00140580
			public unsafe Player player
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002081 RID: 8321
			// (get) Token: 0x060058DC RID: 22748 RVA: 0x001423C4 File Offset: 0x001405C4
			// (set) Token: 0x060058DD RID: 22749 RVA: 0x00142400 File Offset: 0x00140600
			public unsafe ControllerType controllerType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002082 RID: 8322
			// (get) Token: 0x060058DE RID: 22750 RVA: 0x00142440 File Offset: 0x00140640
			// (set) Token: 0x060058DF RID: 22751 RVA: 0x00142480 File Offset: 0x00140680
			public unsafe Joystick joystick
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
				}
				[CallerCount(38)]
				[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002083 RID: 8323
			// (get) Token: 0x060058E0 RID: 22752 RVA: 0x001424C4 File Offset: 0x001406C4
			// (set) Token: 0x060058E1 RID: 22753 RVA: 0x00142504 File Offset: 0x00140704
			public unsafe CalibrationMap calibrationMap
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr3) : null;
				}
				[CallerCount(23)]
				[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060058E2 RID: 22754 RVA: 0x00142548 File Offset: 0x00140748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101192, XrefRangeEnd = 101194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.Calibration>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calibrationMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlRemappingDemo1.Calibration.NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058E3 RID: 22755 RVA: 0x00032E0E File Offset: 0x0003100E
			public Calibration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700207A RID: 8314
			// (get) Token: 0x060058E4 RID: 22756 RVA: 0x001425B8 File Offset: 0x001407B8
			// (set) Token: 0x060058E5 RID: 22757 RVA: 0x00032E17 File Offset: 0x00031017
			public unsafe Player _player_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__player_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700207B RID: 8315
			// (get) Token: 0x060058E6 RID: 22758 RVA: 0x001425E8 File Offset: 0x001407E8
			// (set) Token: 0x060058E7 RID: 22759 RVA: 0x00032E36 File Offset: 0x00031036
			public unsafe ControllerType _controllerType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__controllerType_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__controllerType_k__BackingField)) = value;
				}
			}

			// Token: 0x1700207C RID: 8316
			// (get) Token: 0x060058E8 RID: 22760 RVA: 0x00142610 File Offset: 0x00140810
			// (set) Token: 0x060058E9 RID: 22761 RVA: 0x00032E51 File Offset: 0x00031051
			public unsafe Joystick _joystick_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__joystick_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__joystick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700207D RID: 8317
			// (get) Token: 0x060058EA RID: 22762 RVA: 0x00142640 File Offset: 0x00140840
			// (set) Token: 0x060058EB RID: 22763 RVA: 0x00032E70 File Offset: 0x00031070
			public unsafe CalibrationMap _calibrationMap_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__calibrationMap_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr__calibrationMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700207E RID: 8318
			// (get) Token: 0x060058EC RID: 22764 RVA: 0x00142670 File Offset: 0x00140870
			// (set) Token: 0x060058ED RID: 22765 RVA: 0x00032E8F File Offset: 0x0003108F
			public unsafe int selectedElementIdentifierId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_selectedElementIdentifierId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_selectedElementIdentifierId)) = value;
				}
			}

			// Token: 0x1700207F RID: 8319
			// (get) Token: 0x060058EE RID: 22766 RVA: 0x00142698 File Offset: 0x00140898
			// (set) Token: 0x060058EF RID: 22767 RVA: 0x00032EAA File Offset: 0x000310AA
			public unsafe bool recording
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_recording);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.Calibration.NativeFieldInfoPtr_recording)) = value;
				}
			}

			// Token: 0x04003B04 RID: 15108
			private static readonly IntPtr NativeFieldInfoPtr__player_k__BackingField;

			// Token: 0x04003B05 RID: 15109
			private static readonly IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;

			// Token: 0x04003B06 RID: 15110
			private static readonly IntPtr NativeFieldInfoPtr__joystick_k__BackingField;

			// Token: 0x04003B07 RID: 15111
			private static readonly IntPtr NativeFieldInfoPtr__calibrationMap_k__BackingField;

			// Token: 0x04003B08 RID: 15112
			private static readonly IntPtr NativeFieldInfoPtr_selectedElementIdentifierId;

			// Token: 0x04003B09 RID: 15113
			private static readonly IntPtr NativeFieldInfoPtr_recording;

			// Token: 0x04003B0A RID: 15114
			private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

			// Token: 0x04003B0B RID: 15115
			private static readonly IntPtr NativeMethodInfoPtr_set_player_Private_set_Void_Player_0;

			// Token: 0x04003B0C RID: 15116
			private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

			// Token: 0x04003B0D RID: 15117
			private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0;

			// Token: 0x04003B0E RID: 15118
			private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0;

			// Token: 0x04003B0F RID: 15119
			private static readonly IntPtr NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0;

			// Token: 0x04003B10 RID: 15120
			private static readonly IntPtr NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0;

			// Token: 0x04003B11 RID: 15121
			private static readonly IntPtr NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0;

			// Token: 0x04003B12 RID: 15122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0;
		}

		// Token: 0x020003A4 RID: 932
		public sealed class WindowProperties : ValueType
		{
			// Token: 0x060058F0 RID: 22768 RVA: 0x001426C0 File Offset: 0x001408C0
			// Note: this type is marked as 'beforefieldinit'.
			static WindowProperties()
			{
				Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "WindowProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr);
				ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, "windowId");
				ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, "rect");
				ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowDrawDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, "windowDrawDelegate");
				ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, "title");
				ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr, "message");
			}

			// Token: 0x060058F1 RID: 22769 RVA: 0x00032EC5 File Offset: 0x000310C5
			public WindowProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060058F2 RID: 22770 RVA: 0x00032ECE File Offset: 0x000310CE
			public WindowProperties()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1.WindowProperties>.NativeClassPtr))
			{
			}

			// Token: 0x17002084 RID: 8324
			// (get) Token: 0x060058F3 RID: 22771 RVA: 0x00142750 File Offset: 0x00140950
			// (set) Token: 0x060058F4 RID: 22772 RVA: 0x00032EE0 File Offset: 0x000310E0
			public unsafe int windowId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowId)) = value;
				}
			}

			// Token: 0x17002085 RID: 8325
			// (get) Token: 0x060058F5 RID: 22773 RVA: 0x00142778 File Offset: 0x00140978
			// (set) Token: 0x060058F6 RID: 22774 RVA: 0x00032EFB File Offset: 0x000310FB
			public unsafe Rect rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x17002086 RID: 8326
			// (get) Token: 0x060058F7 RID: 22775 RVA: 0x001427A0 File Offset: 0x001409A0
			// (set) Token: 0x060058F8 RID: 22776 RVA: 0x00032F16 File Offset: 0x00031116
			public unsafe Action<string, string> windowDrawDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowDrawDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_windowDrawDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002087 RID: 8327
			// (get) Token: 0x060058F9 RID: 22777 RVA: 0x001427D0 File Offset: 0x001409D0
			// (set) Token: 0x060058FA RID: 22778 RVA: 0x00032F35 File Offset: 0x00031135
			public unsafe string title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002088 RID: 8328
			// (get) Token: 0x060058FB RID: 22779 RVA: 0x001427F8 File Offset: 0x001409F8
			// (set) Token: 0x060058FC RID: 22780 RVA: 0x00032F54 File Offset: 0x00031154
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlRemappingDemo1.WindowProperties.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003B13 RID: 15123
			private static readonly IntPtr NativeFieldInfoPtr_windowId;

			// Token: 0x04003B14 RID: 15124
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04003B15 RID: 15125
			private static readonly IntPtr NativeFieldInfoPtr_windowDrawDelegate;

			// Token: 0x04003B16 RID: 15126
			private static readonly IntPtr NativeFieldInfoPtr_title;

			// Token: 0x04003B17 RID: 15127
			private static readonly IntPtr NativeFieldInfoPtr_message;
		}

		// Token: 0x020003A5 RID: 933
		[OriginalName("Assembly-CSharp.dll", "", "QueueActionType")]
		public enum QueueActionType
		{
			// Token: 0x04003B19 RID: 15129
			None,
			// Token: 0x04003B1A RID: 15130
			JoystickAssignment,
			// Token: 0x04003B1B RID: 15131
			ElementAssignment,
			// Token: 0x04003B1C RID: 15132
			FallbackJoystickIdentification,
			// Token: 0x04003B1D RID: 15133
			Calibrate
		}

		// Token: 0x020003A6 RID: 934
		[OriginalName("Assembly-CSharp.dll", "", "ElementAssignmentChangeType")]
		public enum ElementAssignmentChangeType
		{
			// Token: 0x04003B1F RID: 15135
			Add,
			// Token: 0x04003B20 RID: 15136
			Replace,
			// Token: 0x04003B21 RID: 15137
			Remove,
			// Token: 0x04003B22 RID: 15138
			ReassignOrRemove,
			// Token: 0x04003B23 RID: 15139
			ConflictCheck
		}

		// Token: 0x020003A7 RID: 935
		[OriginalName("Assembly-CSharp.dll", "", "UserResponse")]
		public enum UserResponse
		{
			// Token: 0x04003B25 RID: 15141
			Confirm,
			// Token: 0x04003B26 RID: 15142
			Cancel,
			// Token: 0x04003B27 RID: 15143
			Custom1,
			// Token: 0x04003B28 RID: 15144
			Custom2
		}
	}
}
