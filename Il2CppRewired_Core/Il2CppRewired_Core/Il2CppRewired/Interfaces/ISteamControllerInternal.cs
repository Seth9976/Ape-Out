using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ControllerExtensions;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000EF RID: 239
	public class ISteamControllerInternal : Il2CppObjectBase
	{
		// Token: 0x0600187D RID: 6269 RVA: 0x0008B51C File Offset: 0x0008971C
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamControllerInternal()
		{
			Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "ISteamControllerInternal");
			ISteamControllerInternal.NativeMethodInfoPtr_get_MaxActionSourceCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669248);
			ISteamControllerInternal.NativeMethodInfoPtr_get_IsConnected_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669249);
			ISteamControllerInternal.NativeMethodInfoPtr_GetActionSetName_Public_Abstract_Virtual_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669250);
			ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionName_Public_Abstract_Virtual_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669251);
			ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionName_Public_Abstract_Virtual_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669252);
			ISteamControllerInternal.NativeMethodInfoPtr_GetActionSetHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669253);
			ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669254);
			ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669255);
			ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionValue_Public_Abstract_Virtual_New_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669256);
			ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionValue_Public_Abstract_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669257);
			ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionValue_Public_Abstract_Virtual_New_Vector2_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669258);
			ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionValue_Public_Abstract_Virtual_New_Vector2_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669259);
			ISteamControllerInternal.NativeMethodInfoPtr_SetActiveActionSet_Public_Abstract_Virtual_New_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669260);
			ISteamControllerInternal.NativeMethodInfoPtr_SetActiveActionSet_Public_Abstract_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669261);
			ISteamControllerInternal.NativeMethodInfoPtr_GetActiveActionSetHandle_Public_Abstract_Virtual_New_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669262);
			ISteamControllerInternal.NativeMethodInfoPtr_GetActiveActionSetName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669263);
			ISteamControllerInternal.NativeMethodInfoPtr_ShowBindingPanel_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669264);
			ISteamControllerInternal.NativeMethodInfoPtr_SetHapticPulse_Public_Abstract_Virtual_New_Void_SteamControllerPadType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669265);
			ISteamControllerInternal.NativeMethodInfoPtr_SetHapticPulse_Public_Abstract_Virtual_New_Void_SteamControllerPadType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669266);
			ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669267);
			ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669268);
			ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669269);
			ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamControllerInternal>.NativeClassPtr, 100669270);
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0008B710 File Offset: 0x00089910
		public unsafe virtual int MaxActionSourceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_get_MaxActionSourceCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0008B758 File Offset: 0x00089958
		public unsafe virtual bool IsConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_get_IsConnected_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0008B7A0 File Offset: 0x000899A0
		[CallerCount(0)]
		public unsafe virtual string GetActionSetName(ulong handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetActionSetName_Public_Abstract_Virtual_New_String_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0008B7F0 File Offset: 0x000899F0
		[CallerCount(0)]
		public unsafe virtual string GetDigitalActionName(ulong handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionName_Public_Abstract_Virtual_New_String_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0008B840 File Offset: 0x00089A40
		[CallerCount(0)]
		public unsafe virtual string GetAnalogActionName(ulong handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionName_Public_Abstract_Virtual_New_String_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0008B890 File Offset: 0x00089A90
		[CallerCount(0)]
		public unsafe virtual ulong GetActionSetHandle(ref string actionSetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetActionSetHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				actionSetName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0008B8F8 File Offset: 0x00089AF8
		[CallerCount(0)]
		public unsafe virtual ulong GetDigitalActionHandle(ref string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				actionName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0008B960 File Offset: 0x00089B60
		[CallerCount(0)]
		public unsafe virtual ulong GetAnalogActionHandle(ref string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				actionName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0008B9C8 File Offset: 0x00089BC8
		[CallerCount(0)]
		public unsafe virtual bool GetDigitalActionValue(ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionValue_Public_Abstract_Virtual_New_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0008BA1C File Offset: 0x00089C1C
		[CallerCount(0)]
		public unsafe virtual bool GetDigitalActionValue(ref string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionValue_Public_Abstract_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				actionName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0008BA84 File Offset: 0x00089C84
		[CallerCount(0)]
		public unsafe virtual Vector2 GetAnalogActionValue(ulong actionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionValue_Public_Abstract_Virtual_New_Vector2_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0008BAD8 File Offset: 0x00089CD8
		[CallerCount(0)]
		public unsafe virtual Vector2 GetAnalogActionValue(ref string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionValue_Public_Abstract_Virtual_New_Vector2_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				actionName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0008BB40 File Offset: 0x00089D40
		[CallerCount(0)]
		public unsafe virtual bool SetActiveActionSet(ulong actionSetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionSetHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_SetActiveActionSet_Public_Abstract_Virtual_New_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0008BB94 File Offset: 0x00089D94
		[CallerCount(0)]
		public unsafe virtual bool SetActiveActionSet(ref string actionSetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_SetActiveActionSet_Public_Abstract_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				actionSetName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0008BBFC File Offset: 0x00089DFC
		[CallerCount(0)]
		public unsafe virtual ulong GetActiveActionSetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetActiveActionSetHandle_Public_Abstract_Virtual_New_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0008BC44 File Offset: 0x00089E44
		[CallerCount(0)]
		public unsafe virtual string GetActiveActionSetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetActiveActionSetName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0008BC88 File Offset: 0x00089E88
		[CallerCount(0)]
		public unsafe virtual void ShowBindingPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_ShowBindingPanel_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0008BCC4 File Offset: 0x00089EC4
		[CallerCount(0)]
		public unsafe virtual void SetHapticPulse(SteamControllerPadType targetPad, float durationSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetPad;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_SetHapticPulse_Public_Abstract_Virtual_New_Void_SteamControllerPadType_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0008BD1C File Offset: 0x00089F1C
		[CallerCount(0)]
		public unsafe virtual void SetHapticPulse(SteamControllerPadType targetPad, ushort durationMicroSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetPad;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMicroSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_SetHapticPulse_Public_Abstract_Virtual_New_Void_SteamControllerPadType_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0008BD74 File Offset: 0x00089F74
		[CallerCount(0)]
		public unsafe virtual IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(actionName);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			actionSetName = IL2CPP.Il2CppStringToManaged(intPtr);
			actionName = IL2CPP.Il2CppStringToManaged(intPtr2);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr5) : null;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0008BE00 File Offset: 0x0008A000
		[CallerCount(0)]
		public unsafe virtual IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr3) : null;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0008BE68 File Offset: 0x0008A068
		[CallerCount(0)]
		public unsafe virtual IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(actionSetName);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(actionName);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			actionSetName = IL2CPP.Il2CppStringToManaged(intPtr);
			actionName = IL2CPP.Il2CppStringToManaged(intPtr2);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr5) : null;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0008BEF4 File Offset: 0x0008A0F4
		[CallerCount(0)]
		public unsafe virtual IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamControllerInternal.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SteamControllerActionOrigin>>(intPtr3) : null;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0000A22E File Offset: 0x0000842E
		public ISteamControllerInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxActionSourceCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetName_Public_Abstract_Virtual_New_String_UInt64_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionName_Public_Abstract_Virtual_New_String_UInt64_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionName_Public_Abstract_Virtual_New_String_UInt64_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Public_Abstract_Virtual_New_UInt64_byref_String_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionValue_Public_Abstract_Virtual_New_Boolean_UInt64_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionValue_Public_Abstract_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionValue_Public_Abstract_Virtual_New_Vector2_UInt64_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionValue_Public_Abstract_Virtual_New_Vector2_byref_String_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveActionSet_Public_Abstract_Virtual_New_Boolean_UInt64_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveActionSet_Public_Abstract_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetHandle_Public_Abstract_Virtual_New_UInt64_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr_SetHapticPulse_Public_Abstract_Virtual_New_Void_SteamControllerPadType_Single_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_SetHapticPulse_Public_Abstract_Virtual_New_Void_SteamControllerPadType_UInt16_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_byref_String_byref_String_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_byref_String_byref_String_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Abstract_Virtual_New_IList_1_SteamControllerActionOrigin_UInt64_UInt64_0;
	}
}
