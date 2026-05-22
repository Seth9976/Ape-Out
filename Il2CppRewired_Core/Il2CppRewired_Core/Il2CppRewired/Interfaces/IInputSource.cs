using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x02000025 RID: 37
	public class IInputSource : Il2CppObjectBase
	{
		// Token: 0x060002EE RID: 750 RVA: 0x00038EB4 File Offset: 0x000370B4
		// Note: this type is marked as 'beforefieldinit'.
		static IInputSource()
		{
			Il2CppClassPointerStore<IInputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IInputSource");
			IInputSource.NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663778);
			IInputSource.NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663779);
			IInputSource.NativeMethodInfoPtr_SystemDeviceConnected_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663780);
			IInputSource.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663781);
			IInputSource.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663782);
			IInputSource.NativeMethodInfoPtr_UpdateDevices_Public_Abstract_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663783);
			IInputSource.NativeMethodInfoPtr_UpdateFinished_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663784);
			IInputSource.NativeMethodInfoPtr_GetJoysticks_Public_Abstract_Virtual_New_IList_1_TJoy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputSource>.NativeClassPtr, 100663785);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00038F7C File Offset: 0x0003717C
		[CallerCount(0)]
		public unsafe virtual void add_DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00038FCC File Offset: 0x000371CC
		[CallerCount(0)]
		public unsafe virtual void remove_DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0003901C File Offset: 0x0003721C
		[CallerCount(0)]
		public unsafe virtual void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_SystemDeviceConnected_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00039058 File Offset: 0x00037258
		[CallerCount(0)]
		public unsafe virtual void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00039094 File Offset: 0x00037294
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000390D0 File Offset: 0x000372D0
		[CallerCount(0)]
		public unsafe virtual void UpdateDevices(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_UpdateDevices_Public_Abstract_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0003911C File Offset: 0x0003731C
		[CallerCount(0)]
		public unsafe virtual void UpdateFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.NativeMethodInfoPtr_UpdateFinished_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00039158 File Offset: 0x00037358
		[CallerCount(0)]
		public unsafe virtual IList<TJoy> GetJoysticks<TJoy>() where TJoy : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputSource.MethodInfoStoreGeneric_GetJoysticks_Public_Abstract_Virtual_New_IList_1_TJoy_0<TJoy>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TJoy>>(intPtr3) : null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002F7B File Offset: 0x0000117B
		public IInputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Abstract_Virtual_New_add_Void_Action_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Abstract_Virtual_New_rem_Void_Action_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDevices_Public_Abstract_Virtual_New_Void_UpdateLoopType_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFinished_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_GetJoysticks_Public_Abstract_Virtual_New_IList_1_TJoy_0;

		// Token: 0x02000232 RID: 562
		private sealed class MethodInfoStoreGeneric_GetJoysticks_Public_Abstract_Virtual_New_IList_1_TJoy_0<TJoy>
		{
			// Token: 0x04002F4E RID: 12110
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IInputSource.NativeMethodInfoPtr_GetJoysticks_Public_Abstract_Virtual_New_IList_1_TJoy_0, Il2CppClassPointerStore<IInputSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TJoy>.NativeClassPtr)) }))));
		}
	}
}
