using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000020 RID: 32
	public class PlatformInputManager : Object
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00036E14 File Offset: 0x00035014
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformInputManager()
		{
			Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PlatformInputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr);
			PlatformInputManager.NativeFieldInfoPtr__DeviceConnectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, "_DeviceConnectedEvent");
			PlatformInputManager.NativeFieldInfoPtr__DeviceDisconnectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, "_DeviceDisconnectedEvent");
			PlatformInputManager.NativeFieldInfoPtr__UpdateControllerInfoEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, "_UpdateControllerInfoEvent");
			PlatformInputManager.NativeFieldInfoPtr__SystemDeviceConnectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, "_SystemDeviceConnectedEvent");
			PlatformInputManager.NativeFieldInfoPtr__SystemDeviceDisconnectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, "_SystemDeviceDisconnectedEvent");
			PlatformInputManager.NativeMethodInfoPtr_add_DeviceConnectedEvent_Public_add_Void_Action_1_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663678);
			PlatformInputManager.NativeMethodInfoPtr_remove_DeviceConnectedEvent_Public_rem_Void_Action_1_BridgedController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663679);
			PlatformInputManager.NativeMethodInfoPtr_add_DeviceDisconnectedEvent_Public_add_Void_Action_1_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663680);
			PlatformInputManager.NativeMethodInfoPtr_remove_DeviceDisconnectedEvent_Public_rem_Void_Action_1_ControllerDisconnectedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663681);
			PlatformInputManager.NativeMethodInfoPtr_add_UpdateControllerInfoEvent_Public_add_Void_Action_1_UpdateControllerInfoEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663682);
			PlatformInputManager.NativeMethodInfoPtr_remove_UpdateControllerInfoEvent_Public_rem_Void_Action_1_UpdateControllerInfoEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663683);
			PlatformInputManager.NativeMethodInfoPtr_add_SystemDeviceConnectedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663684);
			PlatformInputManager.NativeMethodInfoPtr_remove_SystemDeviceConnectedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663685);
			PlatformInputManager.NativeMethodInfoPtr_add_SystemDeviceDisconnectedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663686);
			PlatformInputManager.NativeMethodInfoPtr_remove_SystemDeviceDisconnectedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663687);
			PlatformInputManager.NativeMethodInfoPtr_get_deviceCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663688);
			PlatformInputManager.NativeMethodInfoPtr_get_primaryInputManager_Public_Abstract_Virtual_New_get_PlatformInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663689);
			PlatformInputManager.NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_IInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663690);
			PlatformInputManager.NativeMethodInfoPtr_get_inputSourceType_Public_Abstract_Virtual_New_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663691);
			PlatformInputManager.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663692);
			PlatformInputManager.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663693);
			PlatformInputManager.NativeMethodInfoPtr_OnDestroy_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663694);
			PlatformInputManager.NativeMethodInfoPtr_SystemDeviceConnected_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663695);
			PlatformInputManager.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663696);
			PlatformInputManager.NativeMethodInfoPtr_UpdateControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663697);
			PlatformInputManager.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Abstract_Virtual_New_Action_2_Int32_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663698);
			PlatformInputManager.NativeMethodInfoPtr_SetUnityJoystickId_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663699);
			PlatformInputManager.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Abstract_Virtual_New_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663700);
			PlatformInputManager.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Abstract_Virtual_New_IUnifiedKeyboardSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663701);
			PlatformInputManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr, 100663702);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0003709C File Offset: 0x0003529C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243843, RefRangeEnd = 243846, XrefRangeStart = 243840, XrefRangeEnd = 243843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DeviceConnectedEvent(Action<BridgedController> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_add_DeviceConnectedEvent_Public_add_Void_Action_1_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000370E0 File Offset: 0x000352E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243846, XrefRangeEnd = 243849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DeviceConnectedEvent(Action<BridgedController> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_remove_DeviceConnectedEvent_Public_rem_Void_Action_1_BridgedController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00037124 File Offset: 0x00035324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243852, RefRangeEnd = 243855, XrefRangeStart = 243849, XrefRangeEnd = 243852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_add_DeviceDisconnectedEvent_Public_add_Void_Action_1_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00037168 File Offset: 0x00035368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243855, XrefRangeEnd = 243858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_remove_DeviceDisconnectedEvent_Public_rem_Void_Action_1_ControllerDisconnectedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000371AC File Offset: 0x000353AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243861, RefRangeEnd = 243864, XrefRangeStart = 243858, XrefRangeEnd = 243861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_add_UpdateControllerInfoEvent_Public_add_Void_Action_1_UpdateControllerInfoEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000371F0 File Offset: 0x000353F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243864, XrefRangeEnd = 243867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_remove_UpdateControllerInfoEvent_Public_rem_Void_Action_1_UpdateControllerInfoEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00037234 File Offset: 0x00035434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243870, RefRangeEnd = 243872, XrefRangeStart = 243867, XrefRangeEnd = 243870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SystemDeviceConnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_add_SystemDeviceConnectedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00037278 File Offset: 0x00035478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243872, XrefRangeEnd = 243875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SystemDeviceConnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_remove_SystemDeviceConnectedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000372BC File Offset: 0x000354BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243878, RefRangeEnd = 243880, XrefRangeStart = 243875, XrefRangeEnd = 243878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SystemDeviceDisconnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_add_SystemDeviceDisconnectedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00037300 File Offset: 0x00035500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243880, XrefRangeEnd = 243883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SystemDeviceDisconnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr_remove_SystemDeviceDisconnectedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00037344 File Offset: 0x00035544
		public unsafe virtual int deviceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_get_deviceCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0003738C File Offset: 0x0003558C
		public unsafe virtual PlatformInputManager primaryInputManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_get_primaryInputManager_Public_Abstract_Virtual_New_get_PlatformInputManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInputManager>(intPtr3) : null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000373D8 File Offset: 0x000355D8
		public unsafe virtual IInputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_IInputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00037424 File Offset: 0x00035624
		public unsafe virtual InputSource inputSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_get_inputSourceType_Public_Abstract_Virtual_New_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0003746C File Offset: 0x0003566C
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000374A8 File Offset: 0x000356A8
		[CallerCount(0)]
		public unsafe virtual void Update(UpdateLoopType currentUpdateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentUpdateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000374F4 File Offset: 0x000356F4
		[CallerCount(0)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_OnDestroy_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00037530 File Offset: 0x00035730
		[CallerCount(0)]
		public unsafe virtual void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_SystemDeviceConnected_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0003756C File Offset: 0x0003576C
		[CallerCount(0)]
		public unsafe virtual void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000375A8 File Offset: 0x000357A8
		[CallerCount(0)]
		public unsafe virtual void UpdateControllerData(int controllerId, ControllerDataUpdater data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_UpdateControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00037604 File Offset: 0x00035804
		[CallerCount(0)]
		public unsafe virtual Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Abstract_Virtual_New_Action_2_Int32_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, ControllerDataUpdater>>(intPtr3) : null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00037650 File Offset: 0x00035850
		[CallerCount(0)]
		public unsafe virtual void SetUnityJoystickId(int joystickId, int unityJoystickId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_SetUnityJoystickId_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000376A8 File Offset: 0x000358A8
		[CallerCount(0)]
		public unsafe virtual IUnifiedMouseSource GetUnifiedMouseSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Abstract_Virtual_New_IUnifiedMouseSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr3) : null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000376F4 File Offset: 0x000358F4
		[CallerCount(0)]
		public unsafe virtual IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInputManager.NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Abstract_Virtual_New_IUnifiedKeyboardSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUnifiedKeyboardSource>(intPtr3) : null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00037740 File Offset: 0x00035940
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformInputManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformInputManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInputManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002D02 File Offset: 0x00000F02
		public PlatformInputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0003777C File Offset: 0x0003597C
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00002D0B File Offset: 0x00000F0B
		public unsafe Action<BridgedController> _DeviceConnectedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__DeviceConnectedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BridgedController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__DeviceConnectedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000377AC File Offset: 0x000359AC
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__DeviceDisconnectedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ControllerDisconnectedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__DeviceDisconnectedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000377DC File Offset: 0x000359DC
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00002D49 File Offset: 0x00000F49
		public unsafe Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__UpdateControllerInfoEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UpdateControllerInfoEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__UpdateControllerInfoEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0003780C File Offset: 0x00035A0C
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00002D68 File Offset: 0x00000F68
		public unsafe Action _SystemDeviceConnectedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__SystemDeviceConnectedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__SystemDeviceConnectedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0003783C File Offset: 0x00035A3C
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002D87 File Offset: 0x00000F87
		public unsafe Action _SystemDeviceDisconnectedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__SystemDeviceDisconnectedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInputManager.NativeFieldInfoPtr__SystemDeviceDisconnectedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr__DeviceConnectedEvent;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr__DeviceDisconnectedEvent;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr__UpdateControllerInfoEvent;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr__SystemDeviceConnectedEvent;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr__SystemDeviceDisconnectedEvent;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_add_DeviceConnectedEvent_Public_add_Void_Action_1_BridgedController_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_remove_DeviceConnectedEvent_Public_rem_Void_Action_1_BridgedController_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_add_DeviceDisconnectedEvent_Public_add_Void_Action_1_ControllerDisconnectedEventArgs_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_remove_DeviceDisconnectedEvent_Public_rem_Void_Action_1_ControllerDisconnectedEventArgs_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_add_UpdateControllerInfoEvent_Public_add_Void_Action_1_UpdateControllerInfoEventArgs_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_remove_UpdateControllerInfoEvent_Public_rem_Void_Action_1_UpdateControllerInfoEventArgs_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_add_SystemDeviceConnectedEvent_Public_add_Void_Action_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_remove_SystemDeviceConnectedEvent_Public_rem_Void_Action_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_add_SystemDeviceDisconnectedEvent_Public_add_Void_Action_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_remove_SystemDeviceDisconnectedEvent_Public_rem_Void_Action_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryInputManager_Public_Abstract_Virtual_New_get_PlatformInputManager_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_IInputSource_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceType_Public_Abstract_Virtual_New_get_InputSource_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UpdateLoopType_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerData_Public_Abstract_Virtual_New_Void_Int32_ControllerDataUpdater_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDataUpdateDelegate_Public_Abstract_Virtual_New_Action_2_Int32_ControllerDataUpdater_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityJoystickId_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedMouseSource_Public_Abstract_Virtual_New_IUnifiedMouseSource_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_GetUnifiedKeyboardSource_Public_Abstract_Virtual_New_IUnifiedKeyboardSource_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
