using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ComponentControls.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class CustomController : ComponentController
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0003F860 File Offset: 0x0003DA60
		// Note: this type is marked as 'beforefieldinit'.
		static CustomController()
		{
			Il2CppClassPointerStore<CustomController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "CustomController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController>.NativeClassPtr);
			CustomController.NativeFieldInfoPtr__rewiredInputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "_rewiredInputManager");
			CustomController.NativeFieldInfoPtr__customControllerSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "_customControllerSelector");
			CustomController.NativeFieldInfoPtr__createCustomControllerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "_createCustomControllerSettings");
			CustomController.NativeFieldInfoPtr_qsOGFcBXltPjukZYjDvqRblsrke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "qsOGFcBXltPjukZYjDvqRblsrke");
			CustomController.NativeFieldInfoPtr_JUCBYegzuCDYgdsXKBOjqVrnftgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "JUCBYegzuCDYgdsXKBOjqVrnftgo");
			CustomController.NativeFieldInfoPtr_RfBisnjYPXlvzzeFBTcoLXbYsXS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "RfBisnjYPXlvzzeFBTcoLXbYsXS");
			CustomController.NativeMethodInfoPtr_add_InputSourceUpdateEvent_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664089);
			CustomController.NativeMethodInfoPtr_remove_InputSourceUpdateEvent_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664090);
			CustomController.NativeMethodInfoPtr_get_rewiredInputManager_Public_get_InputManager_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664091);
			CustomController.NativeMethodInfoPtr_set_rewiredInputManager_Public_set_Void_InputManager_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664092);
			CustomController.NativeMethodInfoPtr_get_customControllerSelector_Public_get_CustomControllerSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664093);
			CustomController.NativeMethodInfoPtr_get_createCustomControllerSettings_Public_get_CreateCustomControllerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664094);
			CustomController.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664095);
			CustomController.NativeMethodInfoPtr_GetCustomController_Public_CustomController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664096);
			CustomController.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664097);
			CustomController.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664098);
			CustomController.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664099);
			CustomController.NativeMethodInfoPtr_OnDestroy_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664100);
			CustomController.NativeMethodInfoPtr_OnInitialize_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664101);
			CustomController.NativeMethodInfoPtr_OnSubscribeEvents_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664102);
			CustomController.NativeMethodInfoPtr_OnUnsubscribeEvents_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664103);
			CustomController.NativeMethodInfoPtr_ClearControlValues_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664104);
			CustomController.NativeMethodInfoPtr_GetUseCustomController_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664105);
			CustomController.NativeMethodInfoPtr_SetUseCustomController_Internal_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664106);
			CustomController.NativeMethodInfoPtr_SetAxisValue_Internal_Void_CustomControllerElementSelector_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664107);
			CustomController.NativeMethodInfoPtr_SetButtonValue_Internal_Void_CustomControllerElementSelector_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664108);
			CustomController.NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementTargetSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664109);
			CustomController.NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664110);
			CustomController.NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664111);
			CustomController.NativeMethodInfoPtr_ElementExists_Editor_Internal_Int32_CustomControllerElementSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664112);
			CustomController.NativeMethodInfoPtr_ElementExists_Internal_Boolean_CustomControllerElementSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664113);
			CustomController.NativeMethodInfoPtr_ValidateElements_Internal_Boolean_CustomControllerElementTargetSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664114);
			CustomController.NativeMethodInfoPtr_ValidateElement_Internal_Boolean_CustomControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664115);
			CustomController.NativeMethodInfoPtr_ValidateElement_Internal_Boolean_CustomControllerElementSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664116);
			CustomController.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664117);
			CustomController.NativeMethodInfoPtr_sPqdYqrwdeRfNxfmsZSsBqAynDp_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664118);
			CustomController.NativeMethodInfoPtr_epdCkhotExOOrFVpNIqMtYAENEh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664119);
			CustomController.NativeMethodInfoPtr_EdIZyVRXgEYpMcneMHHHvLApaOe_Private_CustomController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664120);
			CustomController.NativeMethodInfoPtr_bShgeGPvBPNmpwqnOaiyfpBMrCA_Private_Void_CustomController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664121);
			CustomController.NativeMethodInfoPtr_oumcrselOkCaASmwOWPXMBabagsi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664122);
			CustomController.NativeMethodInfoPtr_wxfCBnsXJFrchrVOIgWqRoWcRNo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController>.NativeClassPtr, 100664123);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245474, XrefRangeEnd = 245477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InputSourceUpdateEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_add_InputSourceUpdateEvent_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0003FC08 File Offset: 0x0003DE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245477, XrefRangeEnd = 245480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InputSourceUpdateEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_remove_InputSourceUpdateEvent_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0003FC4C File Offset: 0x0003DE4C
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0003FC8C File Offset: 0x0003DE8C
		public unsafe InputManager_Base rewiredInputManager
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_get_rewiredInputManager_Public_get_InputManager_Base_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputManager_Base>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245480, XrefRangeEnd = 245497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_set_rewiredInputManager_Public_set_Void_InputManager_Base_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0003FCD0 File Offset: 0x0003DED0
		public unsafe CustomControllerSelector customControllerSelector
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_get_customControllerSelector_Public_get_CustomControllerSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerSelector>(intPtr3) : null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0003FD10 File Offset: 0x0003DF10
		public unsafe CustomController.CreateCustomControllerSettings createCustomControllerSettings
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_get_createCustomControllerSettings_Public_get_CreateCustomControllerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController.CreateCustomControllerSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0003FD50 File Offset: 0x0003DF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245522, RefRangeEnd = 245523, XrefRangeStart = 245497, XrefRangeEnd = 245522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0003FD8C File Offset: 0x0003DF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245523, XrefRangeEnd = 245524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController GetCustomController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_GetCustomController_Public_CustomController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr3) : null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0003FDCC File Offset: 0x0003DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0003FE08 File Offset: 0x0003E008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245524, XrefRangeEnd = 245526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0003FE44 File Offset: 0x0003E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245526, XrefRangeEnd = 245528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0003FE80 File Offset: 0x0003E080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245528, XrefRangeEnd = 245539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnDestroy_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0003FEBC File Offset: 0x0003E0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245539, XrefRangeEnd = 245546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnInitialize_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0003FF04 File Offset: 0x0003E104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245546, XrefRangeEnd = 245558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSubscribeEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnSubscribeEvents_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0003FF40 File Offset: 0x0003E140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245558, XrefRangeEnd = 245576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUnsubscribeEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_OnUnsubscribeEvents_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0003FF7C File Offset: 0x0003E17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245576, XrefRangeEnd = 245588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearControlValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_ClearControlValues_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0003FFB8 File Offset: 0x0003E1B8
		[CallerCount(0)]
		public unsafe virtual bool GetUseCustomController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_GetUseCustomController_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00040000 File Offset: 0x0003E200
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetUseCustomController(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController.NativeMethodInfoPtr_SetUseCustomController_Internal_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0004004C File Offset: 0x0003E24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245588, XrefRangeEnd = 245595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisValue(CustomControllerElementSelector element, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetAxisValue_Internal_Void_CustomControllerElementSelector_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0004009C File Offset: 0x0003E29C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245602, RefRangeEnd = 245604, XrefRangeStart = 245595, XrefRangeEnd = 245602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonValue(CustomControllerElementSelector element, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_SetButtonValue_Internal_Void_CustomControllerElementSelector_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000400EC File Offset: 0x0003E2EC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 245605, RefRangeEnd = 245616, XrefRangeStart = 245604, XrefRangeEnd = 245605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearElementValue(CustomControllerElementTargetSet targetSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementTargetSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00040130 File Offset: 0x0003E330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245616, XrefRangeEnd = 245617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearElementValue(CustomControllerElementTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00040174 File Offset: 0x0003E374
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 245626, RefRangeEnd = 245632, XrefRangeStart = 245617, XrefRangeEnd = 245626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearElementValue(CustomControllerElementSelector element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000401B8 File Offset: 0x0003E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245632, XrefRangeEnd = 245656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ElementExists_Editor(CustomControllerElementSelector element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ElementExists_Editor_Internal_Int32_CustomControllerElementSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00040208 File Offset: 0x0003E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245656, XrefRangeEnd = 245658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ElementExists(CustomControllerElementSelector element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ElementExists_Internal_Boolean_CustomControllerElementSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00040258 File Offset: 0x0003E458
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 245659, RefRangeEnd = 245668, XrefRangeStart = 245658, XrefRangeEnd = 245659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateElements(CustomControllerElementTargetSet targetSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ValidateElements_Internal_Boolean_CustomControllerElementTargetSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000402A8 File Offset: 0x0003E4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245668, XrefRangeEnd = 245669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateElement(CustomControllerElementTarget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ValidateElement_Internal_Boolean_CustomControllerElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000402F8 File Offset: 0x0003E4F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245677, RefRangeEnd = 245679, XrefRangeStart = 245669, XrefRangeEnd = 245677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateElement(CustomControllerElementSelector element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_ValidateElement_Internal_Boolean_CustomControllerElementSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00040348 File Offset: 0x0003E548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245681, RefRangeEnd = 245682, XrefRangeStart = 245679, XrefRangeEnd = 245681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0004037C File Offset: 0x0003E57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245682, XrefRangeEnd = 245689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool sPqdYqrwdeRfNxfmsZSsBqAynDp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_sPqdYqrwdeRfNxfmsZSsBqAynDp_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000403B8 File Offset: 0x0003E5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245700, RefRangeEnd = 245701, XrefRangeStart = 245689, XrefRangeEnd = 245700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void epdCkhotExOOrFVpNIqMtYAENEh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_epdCkhotExOOrFVpNIqMtYAENEh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000403EC File Offset: 0x0003E5EC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 245727, RefRangeEnd = 245737, XrefRangeStart = 245701, XrefRangeEnd = 245727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController EdIZyVRXgEYpMcneMHHHvLApaOe(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_EdIZyVRXgEYpMcneMHHHvLApaOe_Private_CustomController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr3) : null;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00040438 File Offset: 0x0003E638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245747, RefRangeEnd = 245748, XrefRangeStart = 245737, XrefRangeEnd = 245747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bShgeGPvBPNmpwqnOaiyfpBMrCA(CustomController A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_bShgeGPvBPNmpwqnOaiyfpBMrCA_Private_Void_CustomController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0004047C File Offset: 0x0003E67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245748, XrefRangeEnd = 245757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void oumcrselOkCaASmwOWPXMBabagsi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_oumcrselOkCaASmwOWPXMBabagsi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000404B0 File Offset: 0x0003E6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245757, XrefRangeEnd = 245759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void wxfCBnsXJFrchrVOIgWqRoWcRNo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.NativeMethodInfoPtr_wxfCBnsXJFrchrVOIgWqRoWcRNo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000037AE File Offset: 0x000019AE
		public CustomController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000404E4 File Offset: 0x0003E6E4
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000037B7 File Offset: 0x000019B7
		public unsafe InputManager_Base _rewiredInputManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr__rewiredInputManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr__rewiredInputManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00040514 File Offset: 0x0003E714
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000037D6 File Offset: 0x000019D6
		public unsafe CustomControllerSelector _customControllerSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr__customControllerSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomControllerSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr__customControllerSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00040544 File Offset: 0x0003E744
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000037F5 File Offset: 0x000019F5
		public unsafe CustomController.CreateCustomControllerSettings _createCustomControllerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr__createCustomControllerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomController.CreateCustomControllerSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr__createCustomControllerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00040574 File Offset: 0x0003E774
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00003814 File Offset: 0x00001A14
		public unsafe List<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq> qsOGFcBXltPjukZYjDvqRblsrke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_qsOGFcBXltPjukZYjDvqRblsrke);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_qsOGFcBXltPjukZYjDvqRblsrke), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000405A4 File Offset: 0x0003E7A4
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00003833 File Offset: 0x00001A33
		public unsafe int JUCBYegzuCDYgdsXKBOjqVrnftgo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_JUCBYegzuCDYgdsXKBOjqVrnftgo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_JUCBYegzuCDYgdsXKBOjqVrnftgo)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000405CC File Offset: 0x0003E7CC
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0000384E File Offset: 0x00001A4E
		public unsafe Action RfBisnjYPXlvzzeFBTcoLXbYsXS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_RfBisnjYPXlvzzeFBTcoLXbYsXS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.NativeFieldInfoPtr_RfBisnjYPXlvzzeFBTcoLXbYsXS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr__rewiredInputManager;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr__customControllerSelector;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr__createCustomControllerSettings;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_qsOGFcBXltPjukZYjDvqRblsrke;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_JUCBYegzuCDYgdsXKBOjqVrnftgo;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_RfBisnjYPXlvzzeFBTcoLXbYsXS;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_add_InputSourceUpdateEvent_Internal_add_Void_Action_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_remove_InputSourceUpdateEvent_Internal_rem_Void_Action_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_get_rewiredInputManager_Public_get_InputManager_Base_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_set_rewiredInputManager_Public_set_Void_InputManager_Base_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerSelector_Public_get_CustomControllerSelector_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_get_createCustomControllerSettings_Public_get_CreateCustomControllerSettings_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomController_Public_CustomController_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Internal_Virtual_Void_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Internal_Virtual_Void_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Internal_Virtual_Boolean_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_OnSubscribeEvents_Internal_Virtual_Void_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_OnUnsubscribeEvents_Internal_Virtual_Void_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_ClearControlValues_Public_Virtual_Void_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_GetUseCustomController_Internal_Virtual_New_Boolean_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_SetUseCustomController_Internal_Virtual_New_Void_Boolean_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisValue_Internal_Void_CustomControllerElementSelector_Single_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonValue_Internal_Void_CustomControllerElementSelector_Boolean_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementTargetSet_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementTarget_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementValue_Internal_Void_CustomControllerElementSelector_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_ElementExists_Editor_Internal_Int32_CustomControllerElementSelector_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_ElementExists_Internal_Boolean_CustomControllerElementSelector_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElements_Internal_Boolean_CustomControllerElementTargetSet_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Internal_Boolean_CustomControllerElementTarget_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Internal_Boolean_CustomControllerElementSelector_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_sPqdYqrwdeRfNxfmsZSsBqAynDp_Private_Boolean_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_epdCkhotExOOrFVpNIqMtYAENEh_Private_Void_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_EdIZyVRXgEYpMcneMHHHvLApaOe_Private_CustomController_Boolean_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_bShgeGPvBPNmpwqnOaiyfpBMrCA_Private_Void_CustomController_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_oumcrselOkCaASmwOWPXMBabagsi_Private_Void_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_wxfCBnsXJFrchrVOIgWqRoWcRNo_Private_Void_0;

		// Token: 0x0200023A RID: 570
		[Serializable]
		public class CreateCustomControllerSettings : Object
		{
			// Token: 0x060038A9 RID: 14505 RVA: 0x00115730 File Offset: 0x00113930
			// Note: this type is marked as 'beforefieldinit'.
			static CreateCustomControllerSettings()
			{
				Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "CreateCustomControllerSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr);
				CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__createCustomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, "_createCustomController");
				CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__customControllerSourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, "_customControllerSourceId");
				CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__assignToPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, "_assignToPlayerId");
				CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__destroyCustomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, "_destroyCustomController");
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_createCustomController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664124);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_createCustomController_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664125);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664126);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_customControllerSourceId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664127);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_assignToPlayerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664128);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_assignToPlayerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664129);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_destroyCustomController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664130);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_destroyCustomController_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664131);
				CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr, 100664132);
			}

			// Token: 0x170010EE RID: 4334
			// (get) Token: 0x060038AA RID: 14506 RVA: 0x00115860 File Offset: 0x00113A60
			// (set) Token: 0x060038AB RID: 14507 RVA: 0x0011589C File Offset: 0x00113A9C
			public unsafe bool createCustomController
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_createCustomController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_createCustomController_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170010EF RID: 4335
			// (get) Token: 0x060038AC RID: 14508 RVA: 0x001158DC File Offset: 0x00113ADC
			// (set) Token: 0x060038AD RID: 14509 RVA: 0x00115918 File Offset: 0x00113B18
			public unsafe int customControllerSourceId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_customControllerSourceId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170010F0 RID: 4336
			// (get) Token: 0x060038AE RID: 14510 RVA: 0x00115958 File Offset: 0x00113B58
			// (set) Token: 0x060038AF RID: 14511 RVA: 0x00115994 File Offset: 0x00113B94
			public unsafe int assignToPlayerId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_assignToPlayerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_assignToPlayerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170010F1 RID: 4337
			// (get) Token: 0x060038B0 RID: 14512 RVA: 0x001159D4 File Offset: 0x00113BD4
			// (set) Token: 0x060038B1 RID: 14513 RVA: 0x00115A10 File Offset: 0x00113C10
			public unsafe bool destroyCustomController
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_get_destroyCustomController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr_set_destroyCustomController_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060038B2 RID: 14514 RVA: 0x00115A50 File Offset: 0x00113C50
			[CallerCount(0)]
			public unsafe CreateCustomControllerSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController.CreateCustomControllerSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.CreateCustomControllerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038B3 RID: 14515 RVA: 0x00013A3A File Offset: 0x00011C3A
			public CreateCustomControllerSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x060038B4 RID: 14516 RVA: 0x00115A8C File Offset: 0x00113C8C
			// (set) Token: 0x060038B5 RID: 14517 RVA: 0x00013A43 File Offset: 0x00011C43
			public unsafe bool _createCustomController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__createCustomController);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__createCustomController)) = value;
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x060038B6 RID: 14518 RVA: 0x00115AB4 File Offset: 0x00113CB4
			// (set) Token: 0x060038B7 RID: 14519 RVA: 0x00013A5E File Offset: 0x00011C5E
			public unsafe int _customControllerSourceId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__customControllerSourceId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__customControllerSourceId)) = value;
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x060038B8 RID: 14520 RVA: 0x00115ADC File Offset: 0x00113CDC
			// (set) Token: 0x060038B9 RID: 14521 RVA: 0x00013A79 File Offset: 0x00011C79
			public unsafe int _assignToPlayerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__assignToPlayerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__assignToPlayerId)) = value;
				}
			}

			// Token: 0x170010ED RID: 4333
			// (get) Token: 0x060038BA RID: 14522 RVA: 0x00115B04 File Offset: 0x00113D04
			// (set) Token: 0x060038BB RID: 14523 RVA: 0x00013A94 File Offset: 0x00011C94
			public unsafe bool _destroyCustomController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__destroyCustomController);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController.CreateCustomControllerSettings.NativeFieldInfoPtr__destroyCustomController)) = value;
				}
			}

			// Token: 0x04002FAE RID: 12206
			private static readonly IntPtr NativeFieldInfoPtr__createCustomController;

			// Token: 0x04002FAF RID: 12207
			private static readonly IntPtr NativeFieldInfoPtr__customControllerSourceId;

			// Token: 0x04002FB0 RID: 12208
			private static readonly IntPtr NativeFieldInfoPtr__assignToPlayerId;

			// Token: 0x04002FB1 RID: 12209
			private static readonly IntPtr NativeFieldInfoPtr__destroyCustomController;

			// Token: 0x04002FB2 RID: 12210
			private static readonly IntPtr NativeMethodInfoPtr_get_createCustomController_Public_get_Boolean_0;

			// Token: 0x04002FB3 RID: 12211
			private static readonly IntPtr NativeMethodInfoPtr_set_createCustomController_Public_set_Void_Boolean_0;

			// Token: 0x04002FB4 RID: 12212
			private static readonly IntPtr NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0;

			// Token: 0x04002FB5 RID: 12213
			private static readonly IntPtr NativeMethodInfoPtr_set_customControllerSourceId_Public_set_Void_Int32_0;

			// Token: 0x04002FB6 RID: 12214
			private static readonly IntPtr NativeMethodInfoPtr_get_assignToPlayerId_Public_get_Int32_0;

			// Token: 0x04002FB7 RID: 12215
			private static readonly IntPtr NativeMethodInfoPtr_set_assignToPlayerId_Public_set_Void_Int32_0;

			// Token: 0x04002FB8 RID: 12216
			private static readonly IntPtr NativeMethodInfoPtr_get_destroyCustomController_Public_get_Boolean_0;

			// Token: 0x04002FB9 RID: 12217
			private static readonly IntPtr NativeMethodInfoPtr_set_destroyCustomController_Public_set_Void_Boolean_0;

			// Token: 0x04002FBA RID: 12218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200023B RID: 571
		[StructLayout(2)]
		public struct ecuDOtdFXOWqpnadhjYqWXewaBq
		{
			// Token: 0x060038BC RID: 14524 RVA: 0x00115B2C File Offset: 0x00113D2C
			// Note: this type is marked as 'beforefieldinit'.
			static ecuDOtdFXOWqpnadhjYqWXewaBq()
			{
				Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomController>.NativeClassPtr, "ecuDOtdFXOWqpnadhjYqWXewaBq");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr);
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeFieldInfoPtr_CHaEJkIgFdQGmISJDTXBVBdlFsSx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, "CHaEJkIgFdQGmISJDTXBVBdlFsSx");
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeFieldInfoPtr_juGKsGmYeZHIktxrIxnDupwKTXQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, "juGKsGmYeZHIktxrIxnDupwKTXQ");
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr__ctor_Public_Void_ElementType_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, 100664133);
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr__ctor_Public_Void_ElementType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, 100664134);
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr_AZWVkHPilHHqnIxfAXlWMNLKpBbd_Public_Boolean_ElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, 100664135);
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr_aeSHljftEeJGoYjISBTVgoiAunfW_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, 100664136);
				CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr_aeSHljftEeJGoYjISBTVgoiAunfW_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, 100664137);
			}

			// Token: 0x060038BD RID: 14525 RVA: 0x00115BF8 File Offset: 0x00113DF8
			[CallerCount(0)]
			public unsafe ecuDOtdFXOWqpnadhjYqWXewaBq(CustomControllerElementSelector.ElementType elementType, int elementIndex, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref elementType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr__ctor_Public_Void_ElementType_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038BE RID: 14526 RVA: 0x00115C48 File Offset: 0x00113E48
			[CallerCount(0)]
			public unsafe ecuDOtdFXOWqpnadhjYqWXewaBq(CustomControllerElementSelector.ElementType elementType, int elementIndex, bool value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref elementType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr__ctor_Public_Void_ElementType_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038BF RID: 14527 RVA: 0x00115C98 File Offset: 0x00113E98
			[CallerCount(0)]
			public unsafe bool AZWVkHPilHHqnIxfAXlWMNLKpBbd(CustomControllerElementSelector.ElementType A_1, int A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr_AZWVkHPilHHqnIxfAXlWMNLKpBbd_Public_Boolean_ElementType_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060038C0 RID: 14528 RVA: 0x00115CE4 File Offset: 0x00113EE4
			[CallerCount(0)]
			public unsafe void aeSHljftEeJGoYjISBTVgoiAunfW(float A_1)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr_aeSHljftEeJGoYjISBTVgoiAunfW_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038C1 RID: 14529 RVA: 0x00115D18 File Offset: 0x00113F18
			[CallerCount(0)]
			public unsafe void aeSHljftEeJGoYjISBTVgoiAunfW(bool A_1)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq.NativeMethodInfoPtr_aeSHljftEeJGoYjISBTVgoiAunfW_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038C2 RID: 14530 RVA: 0x00013AAF File Offset: 0x00011CAF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomController.ecuDOtdFXOWqpnadhjYqWXewaBq>.NativeClassPtr, ref this));
			}

			// Token: 0x04002FBB RID: 12219
			private static readonly IntPtr NativeFieldInfoPtr_CHaEJkIgFdQGmISJDTXBVBdlFsSx;

			// Token: 0x04002FBC RID: 12220
			private static readonly IntPtr NativeFieldInfoPtr_juGKsGmYeZHIktxrIxnDupwKTXQ;

			// Token: 0x04002FBD RID: 12221
			private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

			// Token: 0x04002FBE RID: 12222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementType_Int32_Single_0;

			// Token: 0x04002FBF RID: 12223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementType_Int32_Boolean_0;

			// Token: 0x04002FC0 RID: 12224
			private static readonly IntPtr NativeMethodInfoPtr_AZWVkHPilHHqnIxfAXlWMNLKpBbd_Public_Boolean_ElementType_Int32_0;

			// Token: 0x04002FC1 RID: 12225
			private static readonly IntPtr NativeMethodInfoPtr_aeSHljftEeJGoYjISBTVgoiAunfW_Public_Void_Single_0;

			// Token: 0x04002FC2 RID: 12226
			private static readonly IntPtr NativeMethodInfoPtr_aeSHljftEeJGoYjISBTVgoiAunfW_Public_Void_Boolean_0;

			// Token: 0x04002FC3 RID: 12227
			[FieldOffset(0)]
			public CustomControllerElementSelector.ElementType CHaEJkIgFdQGmISJDTXBVBdlFsSx;

			// Token: 0x04002FC4 RID: 12228
			[FieldOffset(4)]
			public int juGKsGmYeZHIktxrIxnDupwKTXQ;

			// Token: 0x04002FC5 RID: 12229
			[FieldOffset(8)]
			public float wvNaDPcNUyHJKWogdKCZCqbNISpy;
		}
	}
}
