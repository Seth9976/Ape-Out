using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000EB RID: 235
	public class IUnifiedKeyboardSource : Il2CppObjectBase
	{
		// Token: 0x06001865 RID: 6245 RVA: 0x0008AF04 File Offset: 0x00089104
		// Note: this type is marked as 'beforefieldinit'.
		static IUnifiedKeyboardSource()
		{
			Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IUnifiedKeyboardSource");
			IUnifiedKeyboardSource.NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr, 100669232);
			IUnifiedKeyboardSource.NativeMethodInfoPtr_get_hardwareMap_Public_Abstract_Virtual_New_get_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr, 100669233);
			IUnifiedKeyboardSource.NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr, 100669234);
			IUnifiedKeyboardSource.NativeMethodInfoPtr_get_controllerExtension_Public_Abstract_Virtual_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr, 100669235);
			IUnifiedKeyboardSource.NativeMethodInfoPtr_UpdateInputData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr, 100669236);
			IUnifiedKeyboardSource.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnifiedKeyboardSource>.NativeClassPtr, 100669237);
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x0008AFA4 File Offset: 0x000891A4
		public unsafe virtual InputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedKeyboardSource.NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_InputSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x0008AFEC File Offset: 0x000891EC
		public unsafe virtual HardwareControllerMap_Game hardwareMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedKeyboardSource.NativeMethodInfoPtr_get_hardwareMap_Public_Abstract_Virtual_New_get_HardwareControllerMap_Game_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr3) : null;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x0008B038 File Offset: 0x00089238
		public unsafe virtual int buttonCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedKeyboardSource.NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x0008B080 File Offset: 0x00089280
		public unsafe virtual Controller.Extension controllerExtension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedKeyboardSource.NativeMethodInfoPtr_get_controllerExtension_Public_Abstract_Virtual_New_get_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0008B0CC File Offset: 0x000892CC
		[CallerCount(0)]
		public unsafe virtual void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedKeyboardSource.NativeMethodInfoPtr_UpdateInputData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0008B11C File Offset: 0x0008931C
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnifiedKeyboardSource.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0000A1DB File Offset: 0x000083DB
		public IUnifiedKeyboardSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Abstract_Virtual_New_get_InputSource_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareMap_Public_Abstract_Virtual_New_get_HardwareControllerMap_Game_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerExtension_Public_Abstract_Virtual_New_get_Extension_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputData_Public_Abstract_Virtual_New_Void_ControllerDataUpdater_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;
	}
}
