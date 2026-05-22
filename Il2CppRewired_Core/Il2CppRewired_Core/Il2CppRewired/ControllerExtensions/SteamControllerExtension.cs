using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.ControllerExtensions
{
	// Token: 0x0200006D RID: 109
	public class SteamControllerExtension : Controller.Extension
	{
		// Token: 0x06000EFC RID: 3836 RVA: 0x00064188 File Offset: 0x00062388
		// Note: this type is marked as 'beforefieldinit'.
		static SteamControllerExtension()
		{
			Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ControllerExtensions", "SteamControllerExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr);
			SteamControllerExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, "biBJftmjAXeWoBqMpeqfZEjZwtg");
			SteamControllerExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665652);
			SteamControllerExtension.NativeMethodInfoPtr_get_internalController_Internal_get_ISteamControllerInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665653);
			SteamControllerExtension.NativeMethodInfoPtr__ctor_Internal_Void_ISteamControllerInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665654);
			SteamControllerExtension.NativeMethodInfoPtr__ctor_Private_Void_SteamControllerExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665655);
			SteamControllerExtension.NativeMethodInfoPtr_GetActionSetHandle_Public_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665656);
			SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionHandle_Public_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665657);
			SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionHandle_Public_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665658);
			SteamControllerExtension.NativeMethodInfoPtr_GetActionSetName_Public_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665659);
			SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionName_Public_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665660);
			SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionName_Public_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665661);
			SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionValue_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665662);
			SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionValue_Public_Vector2_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665663);
			SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionValue_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665664);
			SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionValue_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665665);
			SteamControllerExtension.NativeMethodInfoPtr_SetActiveActionSet_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665666);
			SteamControllerExtension.NativeMethodInfoPtr_SetActiveActionSet_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665667);
			SteamControllerExtension.NativeMethodInfoPtr_GetActiveActionSetHandle_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665668);
			SteamControllerExtension.NativeMethodInfoPtr_GetActiveActionSetName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665669);
			SteamControllerExtension.NativeMethodInfoPtr_ShowBindingPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665670);
			SteamControllerExtension.NativeMethodInfoPtr_SetHapticPulse_Public_Void_SteamControllerPadType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665671);
			SteamControllerExtension.NativeMethodInfoPtr_SetHapticPulse_Public_Void_SteamControllerPadType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665672);
			SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_IList_1_SteamControllerActionOrigin_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665673);
			SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665674);
			SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_IList_1_SteamControllerActionOrigin_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665675);
			SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665676);
			SteamControllerExtension.NativeMethodInfoPtr_UpdateData_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665677);
			SteamControllerExtension.NativeMethodInfoPtr_SourceUpdated_Internal_Virtual_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665678);
			SteamControllerExtension.NativeMethodInfoPtr_Clone_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665679);
			SteamControllerExtension.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, 100665680);
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00064410 File Offset: 0x00062610
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256593, XrefRangeEnd = 256595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00064450 File Offset: 0x00062650
		public unsafe ISteamControllerInternal internalController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_get_internalController_Internal_get_ISteamControllerInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamControllerInternal>(intPtr3) : null;
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00064490 File Offset: 0x00062690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256595, XrefRangeEnd = 256599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamControllerExtension(ISteamControllerInternal internalController)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr__ctor_Internal_Void_ISteamControllerInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000644DC File Offset: 0x000626DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamControllerExtension(SteamControllerExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr__ctor_Private_Void_SteamControllerExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00064528 File Offset: 0x00062728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256599, XrefRangeEnd = 256605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetActionSetHandle(string actionSetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetActionSetHandle_Public_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00064578 File Offset: 0x00062778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256605, XrefRangeEnd = 256611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetAnalogActionHandle(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionHandle_Public_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000645C8 File Offset: 0x000627C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256611, XrefRangeEnd = 256617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetDigitalActionHandle(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionHandle_Public_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00064618 File Offset: 0x00062818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256617, XrefRangeEnd = 256628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionSetName(ulong actionSetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionSetHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetActionSetName_Public_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0006465C File Offset: 0x0006285C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256628, XrefRangeEnd = 256639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAnalogActionName(ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionName_Public_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000646A0 File Offset: 0x000628A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256639, XrefRangeEnd = 256650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDigitalActionName(ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionName_Public_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000646E4 File Offset: 0x000628E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256650, XrefRangeEnd = 256657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAnalogActionValue(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionValue_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00064734 File Offset: 0x00062934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256657, XrefRangeEnd = 256669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAnalogActionValue(ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionValue_Public_Vector2_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00064780 File Offset: 0x00062980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256669, XrefRangeEnd = 256675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDigitalActionValue(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionValue_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000647D0 File Offset: 0x000629D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256675, XrefRangeEnd = 256684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDigitalActionValue(ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionValue_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0006481C File Offset: 0x00062A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256684, XrefRangeEnd = 256693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetActiveActionSet(ulong actionSetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionSetHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_SetActiveActionSet_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00064868 File Offset: 0x00062A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256693, XrefRangeEnd = 256699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetActiveActionSet(string actionSetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_SetActiveActionSet_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000648B8 File Offset: 0x00062AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256699, XrefRangeEnd = 256708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetActiveActionSetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetActiveActionSetHandle_Public_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000648F4 File Offset: 0x00062AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256708, XrefRangeEnd = 256719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActiveActionSetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetActiveActionSetName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0006492C File Offset: 0x00062B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256719, XrefRangeEnd = 256729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowBindingPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_ShowBindingPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00064960 File Offset: 0x00062B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256729, XrefRangeEnd = 256740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targePad;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_SetHapticPulse_Public_Void_SteamControllerPadType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000649AC File Offset: 0x00062BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256740, XrefRangeEnd = 256751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targePad;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMicroSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_SetHapticPulse_Public_Void_SteamControllerPadType_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000649F8 File Offset: 0x00062BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256751, XrefRangeEnd = 256759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_IList_1_SteamControllerActionOrigin_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr3) : null;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00064A5C File Offset: 0x00062C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256759, XrefRangeEnd = 256771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionSetHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr3) : null;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00064AB8 File Offset: 0x00062CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256771, XrefRangeEnd = 256779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_IList_1_SteamControllerActionOrigin_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr3) : null;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00064B1C File Offset: 0x00062D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256779, XrefRangeEnd = 256791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionSetHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr3) : null;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00064B78 File Offset: 0x00062D78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateData(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamControllerExtension.NativeMethodInfoPtr_UpdateData_Internal_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00064BC4 File Offset: 0x00062DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256791, XrefRangeEnd = 256795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SourceUpdated(IControllerExtensionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamControllerExtension.NativeMethodInfoPtr_SourceUpdated_Internal_Virtual_Void_IControllerExtensionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00064C14 File Offset: 0x00062E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256795, XrefRangeEnd = 256799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamControllerExtension.NativeMethodInfoPtr_Clone_Internal_Virtual_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00064C60 File Offset: 0x00062E60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dwHOFmApnpWkXreTmwZYsRXRrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00006FEE File Offset: 0x000051EE
		public SteamControllerExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00064C94 File Offset: 0x00062E94
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00006FF7 File Offset: 0x000051F7
		public unsafe SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA biBJftmjAXeWoBqMpeqfZEjZwtg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamControllerExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamControllerExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_get_internalController_Internal_get_ISteamControllerInternal_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISteamControllerInternal_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SteamControllerExtension_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Public_UInt64_String_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Public_UInt64_String_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Public_UInt64_String_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetName_Public_String_UInt64_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionName_Public_String_UInt64_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionName_Public_String_UInt64_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionValue_Public_Vector2_String_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionValue_Public_Vector2_UInt64_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionValue_Public_Boolean_String_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionValue_Public_Boolean_UInt64_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveActionSet_Public_Boolean_UInt64_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveActionSet_Public_Boolean_String_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetHandle_Public_UInt64_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetName_Public_String_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Public_Void_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_SetHapticPulse_Public_Void_SteamControllerPadType_Single_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_SetHapticPulse_Public_Void_SteamControllerPadType_UInt16_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_IList_1_SteamControllerActionOrigin_String_String_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_IList_1_SteamControllerActionOrigin_String_String_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_SourceUpdated_Internal_Virtual_Void_IControllerExtensionSource_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_Extension_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Private_Void_0;

		// Token: 0x02000288 RID: 648
		public class pjRhlxqVVWwyuWfVnEFKTHEEmvA : global::Il2CppSystem.Object
		{
			// Token: 0x06003B12 RID: 15122 RVA: 0x0011CFF8 File Offset: 0x0011B1F8
			// Note: this type is marked as 'beforefieldinit'.
			static pjRhlxqVVWwyuWfVnEFKTHEEmvA()
			{
				Il2CppClassPointerStore<SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamControllerExtension>.NativeClassPtr, "pjRhlxqVVWwyuWfVnEFKTHEEmvA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA>.NativeClassPtr);
				SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA.NativeFieldInfoPtr_mjEtUbaHlOaYkbgjSgoHPfnSZkBD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA>.NativeClassPtr, "mjEtUbaHlOaYkbgjSgoHPfnSZkBD");
				SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA.NativeMethodInfoPtr__ctor_Public_Void_ISteamControllerInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA>.NativeClassPtr, 100665681);
			}

			// Token: 0x06003B13 RID: 15123 RVA: 0x0011D04C File Offset: 0x0011B24C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe pjRhlxqVVWwyuWfVnEFKTHEEmvA(ISteamControllerInternal internalController)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalController);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA.NativeMethodInfoPtr__ctor_Public_Void_ISteamControllerInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003B14 RID: 15124 RVA: 0x00014FAE File Offset: 0x000131AE
			public pjRhlxqVVWwyuWfVnEFKTHEEmvA(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C9 RID: 4553
			// (get) Token: 0x06003B15 RID: 15125 RVA: 0x0011D098 File Offset: 0x0011B298
			// (set) Token: 0x06003B16 RID: 15126 RVA: 0x00014FB7 File Offset: 0x000131B7
			public unsafe ISteamControllerInternal mjEtUbaHlOaYkbgjSgoHPfnSZkBD
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA.NativeFieldInfoPtr_mjEtUbaHlOaYkbgjSgoHPfnSZkBD);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamControllerInternal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamControllerExtension.pjRhlxqVVWwyuWfVnEFKTHEEmvA.NativeFieldInfoPtr_mjEtUbaHlOaYkbgjSgoHPfnSZkBD), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003190 RID: 12688
			private static readonly IntPtr NativeFieldInfoPtr_mjEtUbaHlOaYkbgjSgoHPfnSZkBD;

			// Token: 0x04003191 RID: 12689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISteamControllerInternal_0;
		}
	}
}
