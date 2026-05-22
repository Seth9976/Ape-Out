using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class Input : Object
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002AD4 File Offset: 0x00000CD4
		// Note: this type is marked as 'beforefieldinit'.
		static Input()
		{
			Il2CppClassPointerStore<Input>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Input");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Input>.NativeClassPtr);
			Input.NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663307);
			Input.NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663308);
			Input.NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663309);
			Input.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663310);
			Input.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663311);
			Input.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663312);
			Input.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663313);
			Input.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663314);
			Input.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663315);
			Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663316);
			Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663317);
			Input.NativeMethodInfoPtr_GetJoystickNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663318);
			Input.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663319);
			Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663320);
			Input.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663321);
			Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663322);
			Input.NativeMethodInfoPtr_get_simulateMouseWithTouches_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663323);
			Input.NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663324);
			Input.NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663325);
			Input.NativeMethodInfoPtr_get_anyKeyDown_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663326);
			Input.NativeMethodInfoPtr_get_inputString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663327);
			Input.NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663328);
			Input.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663329);
			Input.NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663330);
			Input.NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663331);
			Input.NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663332);
			Input.NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663333);
			Input.NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663334);
			Input.NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663335);
			Input.NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663336);
			Input.NativeMethodInfoPtr_get_touchPressureSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663337);
			Input.NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663338);
			Input.NativeMethodInfoPtr_get_multiTouchEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663339);
			Input.NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663340);
			Input.NativeMethodInfoPtr_get_acceleration_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663341);
			Input.NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663342);
			Input.NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663343);
			Input.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663344);
			Input.NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663345);
			Input.NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663346);
			Input.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663347);
			Input.NativeMethodInfoPtr_get_acceleration_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663348);
			Input.GetKeyStringDelegateField = IL2CPP.ResolveICall<Input.GetKeyStringDelegate>("UnityEngine.Input::GetKeyString");
			Input.GetKeyUpStringDelegateField = IL2CPP.ResolveICall<Input.GetKeyUpStringDelegate>("UnityEngine.Input::GetKeyUpString");
			Input.GetKeyDownStringDelegateField = IL2CPP.ResolveICall<Input.GetKeyDownStringDelegate>("UnityEngine.Input::GetKeyDownString");
			Input.ResetInputAxesDelegateField = IL2CPP.ResolveICall<Input.ResetInputAxesDelegate>("UnityEngine.Input::ResetInputAxes");
			Input.get_imeIsSelectedDelegateField = IL2CPP.ResolveICall<Input.get_imeIsSelectedDelegate>("UnityEngine.Input::get_imeIsSelected");
			Input.get_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<Input.get_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::get_eatKeyPressOnTextFieldFocus");
			Input.set_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<Input.set_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::set_eatKeyPressOnTextFieldFocus");
			Input.get_stylusTouchSupportedDelegateField = IL2CPP.ResolveICall<Input.get_stylusTouchSupportedDelegate>("UnityEngine.Input::get_stylusTouchSupported");
			Input.get_isGyroAvailableDelegateField = IL2CPP.ResolveICall<Input.get_isGyroAvailableDelegate>("UnityEngine.Input::get_isGyroAvailable");
			Input.get_deviceOrientationDelegateField = IL2CPP.ResolveICall<Input.get_deviceOrientationDelegate>("UnityEngine.Input::get_deviceOrientation");
			Input.get_compensateSensorsDelegateField = IL2CPP.ResolveICall<Input.get_compensateSensorsDelegate>("UnityEngine.Input::get_compensateSensors");
			Input.set_compensateSensorsDelegateField = IL2CPP.ResolveICall<Input.set_compensateSensorsDelegate>("UnityEngine.Input::set_compensateSensors");
			Input.get_accelerationEventCountDelegateField = IL2CPP.ResolveICall<Input.get_accelerationEventCountDelegate>("UnityEngine.Input::get_accelerationEventCount");
			Input.get_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<Input.get_backButtonLeavesAppDelegate>("UnityEngine.Input::get_backButtonLeavesApp");
			Input.set_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<Input.set_backButtonLeavesAppDelegate>("UnityEngine.Input::set_backButtonLeavesApp");
			Input.GetGyroInternalDelegateField = IL2CPP.ResolveICall<Input.GetGyroInternalDelegate>("UnityEngine.Input::GetGyroInternal");
			Input.SimulateTouchInternal_InjectedDelegateField = IL2CPP.ResolveICall<Input.SimulateTouchInternal_InjectedDelegate>("UnityEngine.Input::SimulateTouchInternal_Injected");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002F4C File Offset: 0x0000114C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 511783, RefRangeEnd = 511803, XrefRangeStart = 511779, XrefRangeEnd = 511783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002F8C File Offset: 0x0000118C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511803, XrefRangeEnd = 511807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUpInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002FCC File Offset: 0x000011CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 511811, RefRangeEnd = 511816, XrefRangeStart = 511807, XrefRangeEnd = 511811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDownInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000300C File Offset: 0x0000120C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511820, RefRangeEnd = 511821, XrefRangeStart = 511816, XrefRangeEnd = 511820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003050 File Offset: 0x00001250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 511825, RefRangeEnd = 511828, XrefRangeStart = 511821, XrefRangeEnd = 511825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003094 File Offset: 0x00001294
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 511832, RefRangeEnd = 511842, XrefRangeStart = 511828, XrefRangeEnd = 511832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000030D8 File Offset: 0x000012D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511842, XrefRangeEnd = 511846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000311C File Offset: 0x0000131C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511846, XrefRangeEnd = 511850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003160 File Offset: 0x00001360
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 511854, RefRangeEnd = 511864, XrefRangeStart = 511850, XrefRangeEnd = 511854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButton(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000031A0 File Offset: 0x000013A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 511868, RefRangeEnd = 511871, XrefRangeStart = 511864, XrefRangeEnd = 511868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonDown(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000031E0 File Offset: 0x000013E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511871, XrefRangeEnd = 511875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonUp(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003220 File Offset: 0x00001420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511875, XrefRangeEnd = 511879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetJoystickNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetJoystickNames_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003254 File Offset: 0x00001454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511879, XrefRangeEnd = 511881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Touch GetTouch(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003294 File Offset: 0x00001494
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 511783, RefRangeEnd = 511803, XrefRangeStart = 511783, XrefRangeEnd = 511803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000032D4 File Offset: 0x000014D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUp(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003314 File Offset: 0x00001514
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 511811, RefRangeEnd = 511816, XrefRangeStart = 511811, XrefRangeEnd = 511816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDown(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003354 File Offset: 0x00001554
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00003384 File Offset: 0x00001584
		public unsafe static bool simulateMouseWithTouches
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_simulateMouseWithTouches_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511881, XrefRangeEnd = 511885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000033B8 File Offset: 0x000015B8
		public unsafe static bool anyKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511885, XrefRangeEnd = 511889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000033E8 File Offset: 0x000015E8
		public unsafe static bool anyKeyDown
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511889, XrefRangeEnd = 511893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_anyKeyDown_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003418 File Offset: 0x00001618
		public unsafe static string inputString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511893, XrefRangeEnd = 511897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_inputString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003444 File Offset: 0x00001644
		public unsafe static Vector3 mousePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511897, XrefRangeEnd = 511899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003474 File Offset: 0x00001674
		public unsafe static Vector2 mouseScrollDelta
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 511901, RefRangeEnd = 511902, XrefRangeStart = 511899, XrefRangeEnd = 511901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000034A4 File Offset: 0x000016A4
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000034D4 File Offset: 0x000016D4
		public unsafe static IMECompositionMode imeCompositionMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511902, XrefRangeEnd = 511906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511906, XrefRangeEnd = 511910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003508 File Offset: 0x00001708
		public unsafe static string compositionString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511910, XrefRangeEnd = 511914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003534 File Offset: 0x00001734
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00003564 File Offset: 0x00001764
		public unsafe static Vector2 compositionCursorPos
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511914, XrefRangeEnd = 511916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511916, XrefRangeEnd = 511918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003598 File Offset: 0x00001798
		public unsafe static bool mousePresent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 511922, RefRangeEnd = 511923, XrefRangeStart = 511918, XrefRangeEnd = 511922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000035C8 File Offset: 0x000017C8
		public unsafe static int touchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000035F8 File Offset: 0x000017F8
		public unsafe static bool touchPressureSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchPressureSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003628 File Offset: 0x00001828
		public unsafe static bool touchSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511923, XrefRangeEnd = 511927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003658 File Offset: 0x00001858
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003688 File Offset: 0x00001888
		public unsafe static bool multiTouchEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_multiTouchEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511927, XrefRangeEnd = 511931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000036BC File Offset: 0x000018BC
		public unsafe static Vector3 acceleration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511931, XrefRangeEnd = 511933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_acceleration_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000036EC File Offset: 0x000018EC
		public unsafe static Il2CppStructArray<Touch> touches
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 511940, RefRangeEnd = 511943, XrefRangeStart = 511933, XrefRangeEnd = 511940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Touch>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003720 File Offset: 0x00001920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511943, XrefRangeEnd = 511947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTouch_Injected(int index, out Touch ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003760 File Offset: 0x00001960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511947, XrefRangeEnd = 511951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_mousePosition_Injected(out Vector3 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003794 File Offset: 0x00001994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511951, XrefRangeEnd = 511955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_mouseScrollDelta_Injected(out Vector2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000037C8 File Offset: 0x000019C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511955, XrefRangeEnd = 511959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_compositionCursorPos_Injected(out Vector2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000037FC File Offset: 0x000019FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511959, XrefRangeEnd = 511963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_compositionCursorPos_Injected(ref Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003830 File Offset: 0x00001A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511963, XrefRangeEnd = 511967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_acceleration_Injected(out Vector3 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_acceleration_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000020F7 File Offset: 0x000002F7
		public Input(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002100 File Offset: 0x00000300
		public static bool GetKeyString(string name)
		{
			return Input.GetKeyStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002112 File Offset: 0x00000312
		public static bool GetKeyUpString(string name)
		{
			return Input.GetKeyUpStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002124 File Offset: 0x00000324
		public static bool GetKeyDownString(string name)
		{
			return Input.GetKeyDownStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002136 File Offset: 0x00000336
		public static void ResetInputAxes()
		{
			Input.ResetInputAxesDelegateField();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003864 File Offset: 0x00001A64
		public static bool GetKey(string name)
		{
			return Input.GetKeyString(name);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000387C File Offset: 0x00001A7C
		public static bool GetKeyUp(string name)
		{
			return Input.GetKeyUpString(name);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003894 File Offset: 0x00001A94
		public static bool GetKeyDown(string name)
		{
			return Input.GetKeyDownString(name);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002142 File Offset: 0x00000342
		public static void SimulateTouch(int id, Vector2 position, TouchPhase action)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002145 File Offset: 0x00000345
		public static void SimulateTouchInternal(int id, Vector2 position, TouchPhase action, long timestamp)
		{
			Input.SimulateTouchInternal_Injected(id, ref position, action, timestamp);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002151 File Offset: 0x00000351
		public static bool imeIsSelected
		{
			get
			{
				return Input.get_imeIsSelectedDelegateField();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000215D File Offset: 0x0000035D
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002169 File Offset: 0x00000369
		public static bool eatKeyPressOnTextFieldFocus
		{
			get
			{
				return Input.get_eatKeyPressOnTextFieldFocusDelegateField();
			}
			set
			{
				Input.set_eatKeyPressOnTextFieldFocusDelegateField(value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002176 File Offset: 0x00000376
		public static bool stylusTouchSupported
		{
			get
			{
				return Input.get_stylusTouchSupportedDelegateField();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002182 File Offset: 0x00000382
		public static bool isGyroAvailable
		{
			get
			{
				return Input.get_isGyroAvailableDelegateField();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000218E File Offset: 0x0000038E
		public static DeviceOrientation deviceOrientation
		{
			get
			{
				return Input.get_deviceOrientationDelegateField();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000219A File Offset: 0x0000039A
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000021A6 File Offset: 0x000003A6
		public static bool compensateSensors
		{
			get
			{
				return Input.get_compensateSensorsDelegateField();
			}
			set
			{
				Input.set_compensateSensorsDelegateField(value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000021B3 File Offset: 0x000003B3
		public static int accelerationEventCount
		{
			get
			{
				return Input.get_accelerationEventCountDelegateField();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000021BF File Offset: 0x000003BF
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000021CB File Offset: 0x000003CB
		public static bool backButtonLeavesApp
		{
			get
			{
				return Input.get_backButtonLeavesAppDelegateField();
			}
			set
			{
				Input.set_backButtonLeavesAppDelegateField(value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000021D8 File Offset: 0x000003D8
		public static LocationService location
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000021E5 File Offset: 0x000003E5
		public static Compass compass
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000021F2 File Offset: 0x000003F2
		public static int GetGyroInternal()
		{
			return Input.GetGyroInternalDelegateField();
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000021FE File Offset: 0x000003FE
		public static Gyroscope gyro
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000220B File Offset: 0x0000040B
		public static void SimulateTouchInternal_Injected(int id, ref Vector2 position, TouchPhase action, long timestamp)
		{
			Input.SimulateTouchInternal_InjectedDelegateField(id, ref position, action, timestamp);
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickNames_Public_Static_Il2CppStringArray_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_simulateMouseWithTouches_Public_Static_get_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_anyKeyDown_Public_Static_get_Boolean_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_inputString_Public_Static_get_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_touchPressureSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_multiTouchEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_acceleration_Public_Static_get_Vector3_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_acceleration_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x0400005F RID: 95
		private static readonly Input.GetKeyStringDelegate GetKeyStringDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Input.GetKeyUpStringDelegate GetKeyUpStringDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Input.GetKeyDownStringDelegate GetKeyDownStringDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Input.ResetInputAxesDelegate ResetInputAxesDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Input.get_imeIsSelectedDelegate get_imeIsSelectedDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Input.get_eatKeyPressOnTextFieldFocusDelegate get_eatKeyPressOnTextFieldFocusDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Input.set_eatKeyPressOnTextFieldFocusDelegate set_eatKeyPressOnTextFieldFocusDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Input.get_stylusTouchSupportedDelegate get_stylusTouchSupportedDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Input.get_isGyroAvailableDelegate get_isGyroAvailableDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Input.get_deviceOrientationDelegate get_deviceOrientationDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Input.get_compensateSensorsDelegate get_compensateSensorsDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Input.set_compensateSensorsDelegate set_compensateSensorsDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Input.get_accelerationEventCountDelegate get_accelerationEventCountDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Input.get_backButtonLeavesAppDelegate get_backButtonLeavesAppDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Input.set_backButtonLeavesAppDelegate set_backButtonLeavesAppDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Input.GetGyroInternalDelegate GetGyroInternalDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Input.SimulateTouchInternal_InjectedDelegate SimulateTouchInternal_InjectedDelegateField;

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000B4 RID: 180
		private delegate bool GetKeyStringDelegate(IntPtr name);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000B6 RID: 182
		private delegate bool GetKeyUpStringDelegate(IntPtr name);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000B8 RID: 184
		private delegate bool GetKeyDownStringDelegate(IntPtr name);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000BA RID: 186
		private delegate void ResetInputAxesDelegate();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000BC RID: 188
		private delegate bool get_imeIsSelectedDelegate();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000BE RID: 190
		private delegate bool get_eatKeyPressOnTextFieldFocusDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000C0 RID: 192
		private delegate void set_eatKeyPressOnTextFieldFocusDelegate(bool value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000C2 RID: 194
		private delegate bool get_stylusTouchSupportedDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000C4 RID: 196
		private delegate bool get_isGyroAvailableDelegate();

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000C6 RID: 198
		private delegate DeviceOrientation get_deviceOrientationDelegate();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000C8 RID: 200
		private delegate bool get_compensateSensorsDelegate();

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000CA RID: 202
		private delegate void set_compensateSensorsDelegate(bool value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000CC RID: 204
		private delegate int get_accelerationEventCountDelegate();

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000CE RID: 206
		private delegate bool get_backButtonLeavesAppDelegate();

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000D0 RID: 208
		private delegate void set_backButtonLeavesAppDelegate(bool value);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000D2 RID: 210
		private delegate int GetGyroInternalDelegate();

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000D4 RID: 212
		private delegate void SimulateTouchInternal_InjectedDelegate(int id, IntPtr position, TouchPhase action, long timestamp);
	}
}
