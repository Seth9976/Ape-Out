using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000EA RID: 234
	public class IUnifiedMouseSource : Il2CppObjectBase
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x0008ABF8 File Offset: 0x00088DF8
		// Note: this type is marked as 'beforefieldinit'.
		static IUnifiedMouseSource()
		{
			Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IUnifiedMouseSource");
			IUnifiedMouseSource.NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669224);
			IUnifiedMouseSource.NativeMethodInfoPtr_get_hardwareMap_Public_Abstract_Virtual_New_get_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669225);
			IUnifiedMouseSource.NativeMethodInfoPtr_get_axisCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669226);
			IUnifiedMouseSource.NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669227);
			IUnifiedMouseSource.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669228);
			IUnifiedMouseSource.NativeMethodInfoPtr_get_controllerExtension_Public_Abstract_Virtual_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669229);
			IUnifiedMouseSource.NativeMethodInfoPtr_UpdateInputData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669230);
			IUnifiedMouseSource.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedMouseSource>.NativeClassPtr, 100669231);
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0008ACC0 File Offset: 0x00088EC0
		public unsafe virtual InputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0008AD08 File Offset: 0x00088F08
		public unsafe virtual HardwareControllerMap_Game hardwareMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_get_hardwareMap_Public_Abstract_Virtual_New_get_HardwareControllerMap_Game_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr3) : null;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0008AD54 File Offset: 0x00088F54
		public unsafe virtual int axisCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_get_axisCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0008AD9C File Offset: 0x00088F9C
		public unsafe virtual int buttonCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x0008ADE4 File Offset: 0x00088FE4
		public unsafe virtual Vector2 mousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0008AE2C File Offset: 0x0008902C
		public unsafe virtual Controller.Extension controllerExtension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_get_controllerExtension_Public_Abstract_Virtual_New_get_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
			}
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0008AE78 File Offset: 0x00089078
		[CallerCount(0)]
		public unsafe virtual void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_UpdateInputData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0008AEC8 File Offset: 0x000890C8
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedMouseSource.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0000A1D2 File Offset: 0x000083D2
		public IUnifiedMouseSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_InputSource_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareMap_Public_Abstract_Virtual_New_get_HardwareControllerMap_Game_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerExtension_Public_Abstract_Virtual_New_get_Extension_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;
	}
}
