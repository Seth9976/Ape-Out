using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000137 RID: 311
	public static class SteamController : Object
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x00032168 File Offset: 0x00030368
		// Note: this type is marked as 'beforefieldinit'.
		static SteamController()
		{
			Il2CppClassPointerStore<SteamController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamController>.NativeClassPtr);
			SteamController.NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664368);
			SteamController.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664369);
			SteamController.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664370);
			SteamController.NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664371);
			SteamController.NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664372);
			SteamController.NativeMethodInfoPtr_GetActionSetHandle_Public_Static_ControllerActionSetHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664373);
			SteamController.NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664374);
			SteamController.NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_ControllerActionSetHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664375);
			SteamController.NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664376);
			SteamController.NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664377);
			SteamController.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664378);
			SteamController.NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_ControllerHandle_t_byref_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664379);
			SteamController.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_ControllerDigitalActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664380);
			SteamController.NativeMethodInfoPtr_GetDigitalActionData_Public_Static_ControllerDigitalActionData_t_ControllerHandle_t_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664381);
			SteamController.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664382);
			SteamController.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_ControllerAnalogActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664383);
			SteamController.NativeMethodInfoPtr_GetAnalogActionData_Public_Static_ControllerAnalogActionData_t_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664384);
			SteamController.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664385);
			SteamController.NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664386);
			SteamController.NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664387);
			SteamController.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664388);
			SteamController.NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_ControllerHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664389);
			SteamController.NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664390);
			SteamController.NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664391);
			SteamController.NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_ControllerHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664392);
			SteamController.NativeMethodInfoPtr_GetMotionData_Public_Static_ControllerMotionData_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664393);
			SteamController.NativeMethodInfoPtr_ShowDigitalActionOrigins_Public_Static_Boolean_ControllerHandle_t_ControllerDigitalActionHandle_t_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664394);
			SteamController.NativeMethodInfoPtr_ShowAnalogActionOrigins_Public_Static_Boolean_ControllerHandle_t_ControllerAnalogActionHandle_t_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664395);
			SteamController.NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664396);
			SteamController.NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664397);
			SteamController.NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100664398);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00032404 File Offset: 0x00030604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5999, XrefRangeEnd = 6004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00032434 File Offset: 0x00030634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6004, XrefRangeEnd = 6009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00032464 File Offset: 0x00030664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6009, XrefRangeEnd = 6014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunFrame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0003248C File Offset: 0x0003068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6014, XrefRangeEnd = 6026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetConnectedControllers(Il2CppStructArray<ControllerHandle_t> handlesOut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handlesOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000324D0 File Offset: 0x000306D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6026, XrefRangeEnd = 6031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00032510 File Offset: 0x00030710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6031, XrefRangeEnd = 6045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetActionSetHandle_Public_Static_ControllerActionSetHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00032554 File Offset: 0x00030754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6045, XrefRangeEnd = 6050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00032594 File Offset: 0x00030794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6050, XrefRangeEnd = 6055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_ControllerActionSetHandle_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000325D4 File Offset: 0x000307D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6055, XrefRangeEnd = 6060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00032614 File Offset: 0x00030814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6060, XrefRangeEnd = 6065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00032654 File Offset: 0x00030854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6065, XrefRangeEnd = 6070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00032688 File Offset: 0x00030888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6070, XrefRangeEnd = 6075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, out ControllerActionSetHandle_t handlesOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handlesOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_ControllerHandle_t_byref_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000326D4 File Offset: 0x000308D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6075, XrefRangeEnd = 6089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_ControllerDigitalActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00032718 File Offset: 0x00030918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6089, XrefRangeEnd = 6094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetDigitalActionData_Public_Static_ControllerDigitalActionData_t_ControllerHandle_t_ControllerDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00032764 File Offset: 0x00030964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6094, XrefRangeEnd = 6099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, Il2CppStructArray<EControllerActionOrigin> originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originsOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000327D0 File Offset: 0x000309D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6099, XrefRangeEnd = 6113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_ControllerAnalogActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00032814 File Offset: 0x00030A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6113, XrefRangeEnd = 6118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetAnalogActionData_Public_Static_ControllerAnalogActionData_t_ControllerHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00032860 File Offset: 0x00030A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6118, XrefRangeEnd = 6123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, Il2CppStructArray<EControllerActionOrigin> originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originsOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000328CC File Offset: 0x00030ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6123, XrefRangeEnd = 6128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0003290C File Offset: 0x00030B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6128, XrefRangeEnd = 6133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0003295C File Offset: 0x00030B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6133, XrefRangeEnd = 6138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000329D4 File Offset: 0x00030BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6138, XrefRangeEnd = 6143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_ControllerHandle_t_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00032A24 File Offset: 0x00030C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6143, XrefRangeEnd = 6148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00032A90 File Offset: 0x00030C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6148, XrefRangeEnd = 6153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulControllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00032AD0 File Offset: 0x00030CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6153, XrefRangeEnd = 6158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_ControllerHandle_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00032B10 File Offset: 0x00030D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6158, XrefRangeEnd = 6163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerMotionData_t GetMotionData(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetMotionData_Public_Static_ControllerMotionData_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00032B50 File Offset: 0x00030D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6163, XrefRangeEnd = 6168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flXPosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flYPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ShowDigitalActionOrigins_Public_Static_Boolean_ControllerHandle_t_ControllerDigitalActionHandle_t_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00032BC8 File Offset: 0x00030DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6168, XrefRangeEnd = 6173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flXPosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flYPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ShowAnalogActionOrigins_Public_Static_Boolean_ControllerHandle_t_ControllerAnalogActionHandle_t_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00032C40 File Offset: 0x00030E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6173, XrefRangeEnd = 6179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringForActionOrigin(EControllerActionOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00032C78 File Offset: 0x00030E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6179, XrefRangeEnd = 6185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00032CB0 File Offset: 0x00030EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6185, XrefRangeEnd = 6190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamInputType GetInputTypeForHandle(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00006498 File Offset: 0x00004698
		public SteamController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Public_Static_Void_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_ControllerHandle_t_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_ControllerHandle_t_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Public_Static_ControllerActionSetHandle_t_String_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_ControllerActionSetHandle_t_ControllerHandle_t_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_ControllerHandle_t_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_ControllerHandle_t_byref_ControllerActionSetHandle_t_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_ControllerDigitalActionHandle_t_String_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionData_Public_Static_ControllerDigitalActionData_t_ControllerHandle_t_ControllerDigitalActionHandle_t_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_ControllerAnalogActionHandle_t_String_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionData_Public_Static_ControllerAnalogActionData_t_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_ControllerHandle_t_UInt16_UInt16_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_ControllerHandle_t_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_ControllerHandle_t_Int32_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_GetMotionData_Public_Static_ControllerMotionData_t_ControllerHandle_t_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_ShowDigitalActionOrigins_Public_Static_Boolean_ControllerHandle_t_ControllerDigitalActionHandle_t_Single_Single_Single_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_ShowAnalogActionOrigins_Public_Static_Boolean_ControllerHandle_t_ControllerAnalogActionHandle_t_Single_Single_Single_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EControllerActionOrigin_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EControllerActionOrigin_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_ControllerHandle_t_0;
	}
}
