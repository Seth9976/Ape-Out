using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x02000155 RID: 341
	public class HardwareControllerMap_Game : Object
	{
		// Token: 0x060025E9 RID: 9705 RVA: 0x000C1DF8 File Offset: 0x000BFFF8
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareControllerMap_Game()
		{
			Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "HardwareControllerMap_Game");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr);
			HardwareControllerMap_Game.NativeFieldInfoPtr_controllerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "controllerName");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hardwareMapIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hardwareMapIdentifier");
			HardwareControllerMap_Game.NativeFieldInfoPtr_customControllerSourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "customControllerSourceId");
			HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "elementIdentifiers");
			HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "elementIdentifiers_cache");
			HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifiers_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "buttonElementIdentifiers_cache");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifiers_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axisElementIdentifiers_cache");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifiers_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axis2DElementIdentifiers_cache");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifiers_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hatElementIdentifiers_cache");
			HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "elementIdentifiers_readOnly");
			HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifiers_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "buttonElementIdentifiers_readOnly");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifiers_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axisElementIdentifiers_readOnly");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifiers_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axis2DElementIdentifiers_readOnly");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifiers_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hatElementIdentifiers_readOnly");
			HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifierIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "buttonElementIdentifierIds");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifierIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axisElementIdentifierIds");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifierIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axis2DElementIdentifierIds");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifierIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hatElementIdentifierIds");
			HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifierCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "elementIdentifierCount");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axisCount");
			HardwareControllerMap_Game.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "buttonCount");
			HardwareControllerMap_Game.NativeFieldInfoPtr_compoundElementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "compoundElementCount");
			HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "axis2DCount");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hatCount");
			HardwareControllerMap_Game.NativeFieldInfoPtr_joystickTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "joystickTypes");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisCalibrationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hwAxisCalibrationData");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hwAxisRanges");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hwAxisInfo");
			HardwareControllerMap_Game.NativeFieldInfoPtr_hwButtonInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "hwButtonInfo");
			HardwareControllerMap_Game.NativeFieldInfoPtr_compoundElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, "compoundElements");
			HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671562);
			HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671563);
			HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Public_Void_String_HardwareControllerMapIdentifier_Il2CppStructArray_1_JoystickType_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671564);
			HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Public_Void_String_HardwareControllerMapIdentifier_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671565);
			HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671566);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671567);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierPositiveName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671568);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierNegativeName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671569);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxisIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671570);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxisIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671571);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetButtonIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671572);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetButtonIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671573);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierById_Public_ControllerElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671574);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetButtonElementIdentifierById_Public_ControllerElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671575);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxisElementIdentifierById_Public_ControllerElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671576);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxis2DData_Public_CompoundElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671577);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetHatData_Public_CompoundElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671578);
			HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementType_Public_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671579);
			HardwareControllerMap_Game.NativeMethodInfoPtr_qYRCpTkZSmfnZDrXIwhprYYdXAhP_Private_Int32_Il2CppReferenceArray_1_ControllerElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr, 100671580);
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000C21FC File Offset: 0x000C03FC
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game(string controllerName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(controllerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000C2248 File Offset: 0x000C0448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294534, XrefRangeEnd = 294535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game(string controllerName, int customControllerSourceId, Il2CppReferenceArray<ControllerElementIdentifier> hardwareElementIdentifiers, Il2CppStructArray<int> buttonElementIdentifierIds, Il2CppStructArray<int> axisElementIdentifierIds, Il2CppReferenceArray<AxisCalibrationData> hwAxisCalibrationData, Il2CppStructArray<AxisRange> hwAxisRanges, Il2CppReferenceArray<HardwareAxisInfo> hwAxisInfo, Il2CppReferenceArray<HardwareButtonInfo> hwButtonInfo, Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(controllerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref customControllerSourceId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareElementIdentifiers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisCalibrationData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisRanges);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwButtonInfo);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compoundElements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000C233C File Offset: 0x000C053C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294535, XrefRangeEnd = 294543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, Il2CppStructArray<JoystickType> joystickTypes, Il2CppReferenceArray<ControllerElementIdentifier> hardwareElementIdentifiers, Il2CppStructArray<int> buttonElementIdentifierIds, Il2CppStructArray<int> axisElementIdentifierIds, Il2CppReferenceArray<AxisCalibrationData> hwAxisCalibrationData, Il2CppStructArray<AxisRange> hwAxisRanges, Il2CppReferenceArray<HardwareAxisInfo> hwAxisInfo, Il2CppReferenceArray<HardwareButtonInfo> hwButtonInfo, Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(controllerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareMapIdentifier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joystickTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareElementIdentifiers);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisCalibrationData);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisRanges);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisInfo);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwButtonInfo);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compoundElements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Public_Void_String_HardwareControllerMapIdentifier_Il2CppStructArray_1_JoystickType_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000C2444 File Offset: 0x000C0644
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 294548, RefRangeEnd = 294552, XrefRangeStart = 294543, XrefRangeEnd = 294548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, Il2CppReferenceArray<ControllerElementIdentifier> hardwareElementIdentifiers, Il2CppStructArray<int> buttonElementIdentifierIds, Il2CppStructArray<int> axisElementIdentifierIds, Il2CppReferenceArray<AxisCalibrationData> hwAxisCalibrationData, Il2CppStructArray<AxisRange> hwAxisRanges, Il2CppReferenceArray<HardwareAxisInfo> hwAxisInfo, Il2CppReferenceArray<HardwareButtonInfo> hwButtonInfo, Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(controllerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareMapIdentifier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareElementIdentifiers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisCalibrationData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisRanges);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwButtonInfo);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compoundElements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Public_Void_String_HardwareControllerMapIdentifier_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000C2538 File Offset: 0x000C0738
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 294640, RefRangeEnd = 294644, XrefRangeStart = 294552, XrefRangeEnd = 294640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game(string controllerName, Il2CppReferenceArray<ControllerElementIdentifier> hardwareElementIdentifiers, Il2CppStructArray<int> buttonElementIdentifierIds, Il2CppStructArray<int> axisElementIdentifierIds, Il2CppReferenceArray<AxisCalibrationData> hwAxisCalibrationData, Il2CppStructArray<AxisRange> hwAxisRanges, Il2CppReferenceArray<HardwareAxisInfo> hwAxisInfo, Il2CppReferenceArray<HardwareButtonInfo> hwButtonInfo, Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareControllerMap_Game>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(controllerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareElementIdentifiers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisElementIdentifierIds);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisCalibrationData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisRanges);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwAxisInfo);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hwButtonInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compoundElements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000C261C File Offset: 0x000C081C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 294650, RefRangeEnd = 294659, XrefRangeStart = 294644, XrefRangeEnd = 294650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetElementIdentifierName(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000C2660 File Offset: 0x000C0860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294659, XrefRangeEnd = 294665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetElementIdentifierPositiveName(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierPositiveName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000C26A4 File Offset: 0x000C08A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294665, XrefRangeEnd = 294671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetElementIdentifierNegativeName(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierNegativeName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x000C26E8 File Offset: 0x000C08E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294671, RefRangeEnd = 294676, XrefRangeStart = 294671, XrefRangeEnd = 294671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisIndex(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxisIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000C2734 File Offset: 0x000C0934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294681, RefRangeEnd = 294683, XrefRangeStart = 294676, XrefRangeEnd = 294681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisIndex(string elementIdentifierName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementIdentifierName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxisIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000C2784 File Offset: 0x000C0984
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 294683, RefRangeEnd = 294689, XrefRangeStart = 294683, XrefRangeEnd = 294683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetButtonIndex(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetButtonIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000C27D0 File Offset: 0x000C09D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294694, RefRangeEnd = 294696, XrefRangeStart = 294689, XrefRangeEnd = 294694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetButtonIndex(string elementIdentifierName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementIdentifierName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetButtonIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000C2820 File Offset: 0x000C0A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294696, XrefRangeEnd = 294697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier GetElementIdentifierById(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementIdentifierById_Public_ControllerElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000C286C File Offset: 0x000C0A6C
		[CallerCount(0)]
		public unsafe ControllerElementIdentifier GetButtonElementIdentifierById(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetButtonElementIdentifierById_Public_ControllerElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x000C28B8 File Offset: 0x000C0AB8
		[CallerCount(0)]
		public unsafe ControllerElementIdentifier GetAxisElementIdentifierById(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxisElementIdentifierById_Public_ControllerElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000C2904 File Offset: 0x000C0B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294697, XrefRangeEnd = 294698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap.CompoundElement GetAxis2DData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetAxis2DData_Public_CompoundElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap.CompoundElement>(intPtr3) : null;
			}
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000C2950 File Offset: 0x000C0B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294698, XrefRangeEnd = 294699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap.CompoundElement GetHatData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetHatData_Public_CompoundElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap.CompoundElement>(intPtr3) : null;
			}
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000C299C File Offset: 0x000C0B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294704, RefRangeEnd = 294706, XrefRangeStart = 294699, XrefRangeEnd = 294704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementType GetElementType(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_GetElementType_Public_ControllerElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000C29E8 File Offset: 0x000C0BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294706, XrefRangeEnd = 294707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int qYRCpTkZSmfnZDrXIwhprYYdXAhP(Il2CppReferenceArray<ControllerElementIdentifier> A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMap_Game.NativeMethodInfoPtr_qYRCpTkZSmfnZDrXIwhprYYdXAhP_Private_Int32_Il2CppReferenceArray_1_ControllerElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x0000EB4E File Offset: 0x0000CD4E
		public HardwareControllerMap_Game(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000C2A44 File Offset: 0x000C0C44
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0000EB57 File Offset: 0x0000CD57
		public unsafe string controllerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_controllerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_controllerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000C2A6C File Offset: 0x000C0C6C
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0000EB76 File Offset: 0x0000CD76
		public unsafe HardwareControllerMapIdentifier hardwareMapIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hardwareMapIdentifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hardwareMapIdentifier)) = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000C2A94 File Offset: 0x000C0C94
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x0000EB91 File Offset: 0x0000CD91
		public unsafe int customControllerSourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_customControllerSourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_customControllerSourceId)) = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000C2ABC File Offset: 0x000C0CBC
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		public unsafe ADictionary<int, ControllerElementIdentifier> elementIdentifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<int, ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000C2AEC File Offset: 0x000C0CEC
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x0000EBCB File Offset: 0x0000CDCB
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> elementIdentifiers_cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000C2B1C File Offset: 0x000C0D1C
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x0000EBEA File Offset: 0x0000CDEA
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> buttonElementIdentifiers_cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifiers_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifiers_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000C2B4C File Offset: 0x000C0D4C
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x0000EC09 File Offset: 0x0000CE09
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> axisElementIdentifiers_cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifiers_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifiers_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000C2B7C File Offset: 0x000C0D7C
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x0000EC28 File Offset: 0x0000CE28
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> axis2DElementIdentifiers_cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifiers_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifiers_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000C2BAC File Offset: 0x000C0DAC
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0000EC47 File Offset: 0x0000CE47
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> hatElementIdentifiers_cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifiers_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifiers_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000C2BDC File Offset: 0x000C0DDC
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0000EC66 File Offset: 0x0000CE66
		public unsafe IList<ControllerElementIdentifier> elementIdentifiers_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifiers_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000C2C0C File Offset: 0x000C0E0C
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x0000EC85 File Offset: 0x0000CE85
		public unsafe IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifiers_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifiers_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000C2C3C File Offset: 0x000C0E3C
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		public unsafe IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifiers_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifiers_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000C2C6C File Offset: 0x000C0E6C
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x0000ECC3 File Offset: 0x0000CEC3
		public unsafe IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifiers_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifiers_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000C2C9C File Offset: 0x000C0E9C
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x0000ECE2 File Offset: 0x0000CEE2
		public unsafe IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifiers_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifiers_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000C2CCC File Offset: 0x000C0ECC
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0000ED01 File Offset: 0x0000CF01
		public unsafe Il2CppStructArray<int> buttonElementIdentifierIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifierIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonElementIdentifierIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000C2CFC File Offset: 0x000C0EFC
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0000ED20 File Offset: 0x0000CF20
		public unsafe Il2CppStructArray<int> axisElementIdentifierIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifierIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisElementIdentifierIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000C2D2C File Offset: 0x000C0F2C
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0000ED3F File Offset: 0x0000CF3F
		public unsafe Il2CppStructArray<int> axis2DElementIdentifierIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifierIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DElementIdentifierIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000C2D5C File Offset: 0x000C0F5C
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0000ED5E File Offset: 0x0000CF5E
		public unsafe Il2CppStructArray<int> hatElementIdentifierIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifierIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatElementIdentifierIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000C2D8C File Offset: 0x000C0F8C
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x0000ED7D File Offset: 0x0000CF7D
		public unsafe int elementIdentifierCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifierCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_elementIdentifierCount)) = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x000C2DB4 File Offset: 0x000C0FB4
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public unsafe int axisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axisCount)) = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x000C2DDC File Offset: 0x000C0FDC
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x0000EDB3 File Offset: 0x0000CFB3
		public unsafe int buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_buttonCount)) = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x000C2E04 File Offset: 0x000C1004
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x0000EDCE File Offset: 0x0000CFCE
		public unsafe int compoundElementCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_compoundElementCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_compoundElementCount)) = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000C2E2C File Offset: 0x000C102C
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x0000EDE9 File Offset: 0x0000CFE9
		public unsafe int axis2DCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_axis2DCount)) = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000C2E54 File Offset: 0x000C1054
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0000EE04 File Offset: 0x0000D004
		public unsafe int hatCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hatCount)) = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000C2E7C File Offset: 0x000C107C
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0000EE1F File Offset: 0x0000D01F
		public unsafe Il2CppStructArray<JoystickType> joystickTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_joystickTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JoystickType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_joystickTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000C2EAC File Offset: 0x000C10AC
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x0000EE3E File Offset: 0x0000D03E
		public unsafe Il2CppReferenceArray<AxisCalibrationData> hwAxisCalibrationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisCalibrationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AxisCalibrationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisCalibrationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x000C2EDC File Offset: 0x000C10DC
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x0000EE5D File Offset: 0x0000D05D
		public unsafe Il2CppStructArray<AxisRange> hwAxisRanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisRanges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AxisRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisRanges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000C2F0C File Offset: 0x000C110C
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public unsafe Il2CppReferenceArray<HardwareAxisInfo> hwAxisInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareAxisInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwAxisInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x000C2F3C File Offset: 0x000C113C
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x0000EE9B File Offset: 0x0000D09B
		public unsafe Il2CppReferenceArray<HardwareButtonInfo> hwButtonInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwButtonInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareButtonInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_hwButtonInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000C2F6C File Offset: 0x000C116C
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x0000EEBA File Offset: 0x0000D0BA
		public unsafe Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_compoundElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickMap.CompoundElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareControllerMap_Game.NativeFieldInfoPtr_compoundElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_controllerName;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr_hardwareMapIdentifier;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeFieldInfoPtr_customControllerSourceId;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifiers;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifiers_cache;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr_buttonElementIdentifiers_cache;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeFieldInfoPtr_axisElementIdentifiers_cache;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeFieldInfoPtr_axis2DElementIdentifiers_cache;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeFieldInfoPtr_hatElementIdentifiers_cache;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifiers_readOnly;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeFieldInfoPtr_buttonElementIdentifiers_readOnly;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeFieldInfoPtr_axisElementIdentifiers_readOnly;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_axis2DElementIdentifiers_readOnly;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeFieldInfoPtr_hatElementIdentifiers_readOnly;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_buttonElementIdentifierIds;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeFieldInfoPtr_axisElementIdentifierIds;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeFieldInfoPtr_axis2DElementIdentifierIds;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeFieldInfoPtr_hatElementIdentifierIds;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifierCount;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeFieldInfoPtr_axisCount;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeFieldInfoPtr_buttonCount;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeFieldInfoPtr_compoundElementCount;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeFieldInfoPtr_axis2DCount;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeFieldInfoPtr_hatCount;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeFieldInfoPtr_joystickTypes;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeFieldInfoPtr_hwAxisCalibrationData;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr_hwAxisRanges;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr_hwAxisInfo;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_hwButtonInfo;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeFieldInfoPtr_compoundElements;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HardwareControllerMapIdentifier_Il2CppStructArray_1_JoystickType_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HardwareControllerMapIdentifier_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppReferenceArray_1_ControllerElementIdentifier_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_AxisCalibrationData_Il2CppStructArray_1_AxisRange_Il2CppReferenceArray_1_HardwareAxisInfo_Il2CppReferenceArray_1_HardwareButtonInfo_Il2CppReferenceArray_1_CompoundElement_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_String_Int32_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierPositiveName_Public_String_Int32_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierNegativeName_Public_String_Int32_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisIndex_Public_Int32_Int32_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisIndex_Public_Int32_String_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIndex_Public_Int32_Int32_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonIndex_Public_Int32_String_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierById_Public_ControllerElementIdentifier_Int32_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonElementIdentifierById_Public_ControllerElementIdentifier_Int32_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisElementIdentifierById_Public_ControllerElementIdentifier_Int32_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2DData_Public_CompoundElement_Int32_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_GetHatData_Public_CompoundElement_Int32_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_ControllerElementType_Int32_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_qYRCpTkZSmfnZDrXIwhprYYdXAhP_Private_Int32_Il2CppReferenceArray_1_ControllerElementIdentifier_Int32_0;
	}
}
