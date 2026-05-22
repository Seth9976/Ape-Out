using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F6 RID: 502
	public class InputBehaviorWindow : Window
	{
		// Token: 0x06003D3E RID: 15678 RVA: 0x000E5308 File Offset: 0x000E3508
		// Note: this type is marked as 'beforefieldinit'.
		static InputBehaviorWindow()
		{
			Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "InputBehaviorWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr);
			InputBehaviorWindow.NativeFieldInfoPtr_minSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "minSensitivity");
			InputBehaviorWindow.NativeFieldInfoPtr_spawnTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "spawnTransform");
			InputBehaviorWindow.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "doneButton");
			InputBehaviorWindow.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "cancelButton");
			InputBehaviorWindow.NativeFieldInfoPtr_defaultButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "defaultButton");
			InputBehaviorWindow.NativeFieldInfoPtr_doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "doneButtonLabel");
			InputBehaviorWindow.NativeFieldInfoPtr_cancelButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "cancelButtonLabel");
			InputBehaviorWindow.NativeFieldInfoPtr_defaultButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "defaultButtonLabel");
			InputBehaviorWindow.NativeFieldInfoPtr_uiControlSetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "uiControlSetPrefab");
			InputBehaviorWindow.NativeFieldInfoPtr_uiSliderControlPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "uiSliderControlPrefab");
			InputBehaviorWindow.NativeFieldInfoPtr_inputBehaviorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "inputBehaviorInfo");
			InputBehaviorWindow.NativeFieldInfoPtr_buttonCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "buttonCallbacks");
			InputBehaviorWindow.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "playerId");
			InputBehaviorWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669016);
			InputBehaviorWindow.NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669017);
			InputBehaviorWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669018);
			InputBehaviorWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669019);
			InputBehaviorWindow.NativeMethodInfoPtr_OnDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669020);
			InputBehaviorWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669021);
			InputBehaviorWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669022);
			InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669023);
			InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669024);
			InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669025);
			InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669026);
			InputBehaviorWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669027);
			InputBehaviorWindow.NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669028);
			InputBehaviorWindow.NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669029);
			InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669030);
			InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669031);
			InputBehaviorWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100669032);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x000E5590 File Offset: 0x000E3790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98541, XrefRangeEnd = 98666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputBehaviorWindow.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x000E55EC File Offset: 0x000E37EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98713, RefRangeEnd = 98714, XrefRangeStart = 98666, XrefRangeEnd = 98713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(int playerId, Il2CppReferenceArray<ControlMapper.InputBehaviorSettings> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x000E563C File Offset: 0x000E383C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98719, RefRangeEnd = 98721, XrefRangeStart = 98714, XrefRangeEnd = 98719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonCallback(InputBehaviorWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x000E568C File Offset: 0x000E388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98721, XrefRangeEnd = 98734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputBehaviorWindow.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x000E56C8 File Offset: 0x000E38C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98734, XrefRangeEnd = 98739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_OnDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x000E56FC File Offset: 0x000E38FC
		[CallerCount(0)]
		public unsafe void OnCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_OnCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x000E5730 File Offset: 0x000E3930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98739, XrefRangeEnd = 98749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRestoreDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x000E5764 File Offset: 0x000E3964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98749, XrefRangeEnd = 98750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputBehaviorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x000E57C0 File Offset: 0x000E39C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98750, XrefRangeEnd = 98751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputBehaviorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x000E581C File Offset: 0x000E3A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98751, XrefRangeEnd = 98753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputBehaviorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x000E5868 File Offset: 0x000E3A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98753, XrefRangeEnd = 98755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputBehaviorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x000E58B4 File Offset: 0x000E3AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98755, XrefRangeEnd = 98756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TakeInputFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputBehaviorWindow.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x000E58F0 File Offset: 0x000E3AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98774, RefRangeEnd = 98775, XrefRangeStart = 98756, XrefRangeEnd = 98774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIControlSet CreateControlSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIControlSet>(intPtr3) : null;
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x000E5930 File Offset: 0x000E3B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98826, RefRangeEnd = 98828, XrefRangeStart = 98775, XrefRangeEnd = 98826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<int, int, float> valueChangedCallback, Action<int, int> cancelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputBehaviorId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultTitle);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideTitle);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueChangedCallback);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancelCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISliderControl>(intPtr3) : null;
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x000E5A0C File Offset: 0x000E3C0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98834, RefRangeEnd = 98837, XrefRangeStart = 98828, XrefRangeEnd = 98834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehavior GetInputBehavior(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x000E5A58 File Offset: 0x000E3C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98839, RefRangeEnd = 98841, XrefRangeStart = 98837, XrefRangeEnd = 98839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehaviorWindow.InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputBehaviorId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputBehaviorWindow.InputBehaviorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x000E5AA4 File Offset: 0x000E3CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98841, XrefRangeEnd = 98844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehaviorWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00025ED3 File Offset: 0x000240D3
		public InputBehaviorWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x000E5AE0 File Offset: 0x000E3CE0
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x00025EDC File Offset: 0x000240DC
		public unsafe static float minSensitivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputBehaviorWindow.NativeFieldInfoPtr_minSensitivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputBehaviorWindow.NativeFieldInfoPtr_minSensitivity, (void*)(&value));
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x000E5AFC File Offset: 0x000E3CFC
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x00025EEA File Offset: 0x000240EA
		public unsafe RectTransform spawnTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_spawnTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_spawnTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x000E5B2C File Offset: 0x000E3D2C
		// (set) Token: 0x06003D56 RID: 15702 RVA: 0x00025F09 File Offset: 0x00024109
		public unsafe Button doneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x000E5B5C File Offset: 0x000E3D5C
		// (set) Token: 0x06003D58 RID: 15704 RVA: 0x00025F28 File Offset: 0x00024128
		public unsafe Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x000E5B8C File Offset: 0x000E3D8C
		// (set) Token: 0x06003D5A RID: 15706 RVA: 0x00025F47 File Offset: 0x00024147
		public unsafe Button defaultButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x000E5BBC File Offset: 0x000E3DBC
		// (set) Token: 0x06003D5C RID: 15708 RVA: 0x00025F66 File Offset: 0x00024166
		public unsafe Text doneButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_doneButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x000E5BEC File Offset: 0x000E3DEC
		// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00025F85 File Offset: 0x00024185
		public unsafe Text cancelButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_cancelButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x000E5C1C File Offset: 0x000E3E1C
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00025FA4 File Offset: 0x000241A4
		public unsafe Text defaultButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_defaultButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x000E5C4C File Offset: 0x000E3E4C
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00025FC3 File Offset: 0x000241C3
		public unsafe GameObject uiControlSetPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiControlSetPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiControlSetPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x000E5C7C File Offset: 0x000E3E7C
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00025FE2 File Offset: 0x000241E2
		public unsafe GameObject uiSliderControlPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiSliderControlPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_uiSliderControlPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x000E5CAC File Offset: 0x000E3EAC
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00026001 File Offset: 0x00024201
		public unsafe List<InputBehaviorWindow.InputBehaviorInfo> inputBehaviorInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_inputBehaviorInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputBehaviorWindow.InputBehaviorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_inputBehaviorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x000E5CDC File Offset: 0x000E3EDC
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x00026020 File Offset: 0x00024220
		public unsafe Dictionary<int, Action<int>> buttonCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_buttonCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_buttonCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x000E5D0C File Offset: 0x000E3F0C
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x0002603F File Offset: 0x0002423F
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeFieldInfoPtr_minSensitivity;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeFieldInfoPtr_spawnTransform;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeFieldInfoPtr_doneButton;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeFieldInfoPtr_defaultButton;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeFieldInfoPtr_doneButtonLabel;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeFieldInfoPtr_cancelButtonLabel;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonLabel;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeFieldInfoPtr_uiControlSetPrefab;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeFieldInfoPtr_uiSliderControlPrefab;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeFieldInfoPtr_inputBehaviorInfo;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeFieldInfoPtr_buttonCallbacks;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeMethodInfoPtr_OnDone_Public_Void_0;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Void_0;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000383 RID: 899
		public class InputBehaviorInfo : global::Il2CppSystem.Object
		{
			// Token: 0x06005737 RID: 22327 RVA: 0x0013C9F0 File Offset: 0x0013ABF0
			// Note: this type is marked as 'beforefieldinit'.
			static InputBehaviorInfo()
			{
				Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "InputBehaviorInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr);
				InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__inputBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, "_inputBehavior");
				InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__controlSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, "_controlSet");
				InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_idToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, "idToProperty");
				InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_copyOfOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, "copyOfOriginal");
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669033);
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669034);
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669035);
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestorePreviousData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669036);
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669037);
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669038);
				InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RefreshControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr, 100669039);
			}

			// Token: 0x17001FDB RID: 8155
			// (get) Token: 0x06005738 RID: 22328 RVA: 0x0013CAF8 File Offset: 0x0013ACF8
			public unsafe InputBehavior inputBehavior
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr3) : null;
				}
			}

			// Token: 0x17001FDC RID: 8156
			// (get) Token: 0x06005739 RID: 22329 RVA: 0x0013CB38 File Offset: 0x0013AD38
			public unsafe UIControlSet controlSet
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIControlSet>(intPtr3) : null;
				}
			}

			// Token: 0x0600573A RID: 22330 RVA: 0x0013CB78 File Offset: 0x0013AD78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98472, RefRangeEnd = 98473, XrefRangeStart = 98468, XrefRangeEnd = 98472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow.InputBehaviorInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBehavior);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlSet);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573B RID: 22331 RVA: 0x0013CBE8 File Offset: 0x0013ADE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98473, XrefRangeEnd = 98474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RestorePreviousData()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestorePreviousData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573C RID: 22332 RVA: 0x0013CC1C File Offset: 0x0013AE1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98474, XrefRangeEnd = 98477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RestoreDefaultData()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573D RID: 22333 RVA: 0x0013CC50 File Offset: 0x0013AE50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 98493, RefRangeEnd = 98495, XrefRangeStart = 98477, XrefRangeEnd = 98493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RestoreData(InputBehaviorWindow.PropertyType propertyType, int controlId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref propertyType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573E RID: 22334 RVA: 0x0013CC9C File Offset: 0x0013AE9C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 98532, RefRangeEnd = 98534, XrefRangeStart = 98495, XrefRangeEnd = 98532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RefreshControls()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.InputBehaviorInfo.NativeMethodInfoPtr_RefreshControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573F RID: 22335 RVA: 0x000322F4 File Offset: 0x000304F4
			public InputBehaviorInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FD7 RID: 8151
			// (get) Token: 0x06005740 RID: 22336 RVA: 0x0013CCD0 File Offset: 0x0013AED0
			// (set) Token: 0x06005741 RID: 22337 RVA: 0x000322FD File Offset: 0x000304FD
			public unsafe InputBehavior _inputBehavior
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__inputBehavior);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__inputBehavior), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FD8 RID: 8152
			// (get) Token: 0x06005742 RID: 22338 RVA: 0x0013CD00 File Offset: 0x0013AF00
			// (set) Token: 0x06005743 RID: 22339 RVA: 0x0003231C File Offset: 0x0003051C
			public unsafe UIControlSet _controlSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__controlSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIControlSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr__controlSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FD9 RID: 8153
			// (get) Token: 0x06005744 RID: 22340 RVA: 0x0013CD30 File Offset: 0x0013AF30
			// (set) Token: 0x06005745 RID: 22341 RVA: 0x0003233B File Offset: 0x0003053B
			public unsafe Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_idToProperty);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, InputBehaviorWindow.PropertyType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_idToProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FDA RID: 8154
			// (get) Token: 0x06005746 RID: 22342 RVA: 0x0013CD60 File Offset: 0x0013AF60
			// (set) Token: 0x06005747 RID: 22343 RVA: 0x0003235A File Offset: 0x0003055A
			public unsafe InputBehavior copyOfOriginal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_copyOfOriginal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.InputBehaviorInfo.NativeFieldInfoPtr_copyOfOriginal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039D1 RID: 14801
			private static readonly IntPtr NativeFieldInfoPtr__inputBehavior;

			// Token: 0x040039D2 RID: 14802
			private static readonly IntPtr NativeFieldInfoPtr__controlSet;

			// Token: 0x040039D3 RID: 14803
			private static readonly IntPtr NativeFieldInfoPtr_idToProperty;

			// Token: 0x040039D4 RID: 14804
			private static readonly IntPtr NativeFieldInfoPtr_copyOfOriginal;

			// Token: 0x040039D5 RID: 14805
			private static readonly IntPtr NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0;

			// Token: 0x040039D6 RID: 14806
			private static readonly IntPtr NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0;

			// Token: 0x040039D7 RID: 14807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0;

			// Token: 0x040039D8 RID: 14808
			private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousData_Public_Void_0;

			// Token: 0x040039D9 RID: 14809
			private static readonly IntPtr NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0;

			// Token: 0x040039DA RID: 14810
			private static readonly IntPtr NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0;

			// Token: 0x040039DB RID: 14811
			private static readonly IntPtr NativeMethodInfoPtr_RefreshControls_Public_Void_0;
		}

		// Token: 0x02000384 RID: 900
		[OriginalName("Assembly-CSharp.dll", "", "ButtonIdentifier")]
		public enum ButtonIdentifier
		{
			// Token: 0x040039DD RID: 14813
			Done,
			// Token: 0x040039DE RID: 14814
			Cancel,
			// Token: 0x040039DF RID: 14815
			Default
		}

		// Token: 0x02000385 RID: 901
		[OriginalName("Assembly-CSharp.dll", "", "PropertyType")]
		public enum PropertyType
		{
			// Token: 0x040039E1 RID: 14817
			JoystickAxisSensitivity,
			// Token: 0x040039E2 RID: 14818
			MouseXYAxisSensitivity
		}

		// Token: 0x02000386 RID: 902
		[ObfuscatedName("Rewired.UI.ControlMapper.InputBehaviorWindow+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005748 RID: 22344 RVA: 0x0013CD90 File Offset: 0x0013AF90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr);
				InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_valueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, "valueChangedCallback");
				InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_inputBehaviorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, "inputBehaviorId");
				InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, "cancelCallback");
				InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, 100669040);
				InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, 100669041);
				InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr, 100669042);
			}

			// Token: 0x06005749 RID: 22345 RVA: 0x0013CE34 File Offset: 0x0013B034
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600574A RID: 22346 RVA: 0x0013CE70 File Offset: 0x0013B070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98534, XrefRangeEnd = 98537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSlider_b__0(int cId, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600574B RID: 22347 RVA: 0x0013CEBC File Offset: 0x0013B0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98537, XrefRangeEnd = 98541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSlider_b__1(int cId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehaviorWindow.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600574C RID: 22348 RVA: 0x00032379 File Offset: 0x00030579
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FDD RID: 8157
			// (get) Token: 0x0600574D RID: 22349 RVA: 0x0013CEFC File Offset: 0x0013B0FC
			// (set) Token: 0x0600574E RID: 22350 RVA: 0x00032382 File Offset: 0x00030582
			public unsafe Action<int, int, float> valueChangedCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_valueChangedCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_valueChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FDE RID: 8158
			// (get) Token: 0x0600574F RID: 22351 RVA: 0x0013CF2C File Offset: 0x0013B12C
			// (set) Token: 0x06005750 RID: 22352 RVA: 0x000323A1 File Offset: 0x000305A1
			public unsafe int inputBehaviorId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_inputBehaviorId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_inputBehaviorId)) = value;
				}
			}

			// Token: 0x17001FDF RID: 8159
			// (get) Token: 0x06005751 RID: 22353 RVA: 0x0013CF54 File Offset: 0x0013B154
			// (set) Token: 0x06005752 RID: 22354 RVA: 0x000323BC File Offset: 0x000305BC
			public unsafe Action<int, int> cancelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_cancelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehaviorWindow.__c__DisplayClass26_0.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039E3 RID: 14819
			private static readonly IntPtr NativeFieldInfoPtr_valueChangedCallback;

			// Token: 0x040039E4 RID: 14820
			private static readonly IntPtr NativeFieldInfoPtr_inputBehaviorId;

			// Token: 0x040039E5 RID: 14821
			private static readonly IntPtr NativeFieldInfoPtr_cancelCallback;

			// Token: 0x040039E6 RID: 14822
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040039E7 RID: 14823
			private static readonly IntPtr NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0;

			// Token: 0x040039E8 RID: 14824
			private static readonly IntPtr NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0;
		}
	}
}
