using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Drivers.Interfaces
{
	// Token: 0x020000FF RID: 255
	public class IControllerDriver : Il2CppObjectBase
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x0008F600 File Offset: 0x0008D800
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerDriver()
		{
			Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Drivers.Interfaces", "IControllerDriver");
			IControllerDriver.NativeMethodInfoPtr_get_AxisCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669382);
			IControllerDriver.NativeMethodInfoPtr_get_ButtonCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669383);
			IControllerDriver.NativeMethodInfoPtr_get_HatCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669384);
			IControllerDriver.NativeMethodInfoPtr_get_AccelerometerCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669385);
			IControllerDriver.NativeMethodInfoPtr_get_GyroscopeCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669386);
			IControllerDriver.NativeMethodInfoPtr_get_TouchpadCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669387);
			IControllerDriver.NativeMethodInfoPtr_get_LightCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669388);
			IControllerDriver.NativeMethodInfoPtr_get_VibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerDriver>.NativeClassPtr, 100669389);
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0008F6C8 File Offset: 0x0008D8C8
		public unsafe virtual int AxisCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_AxisCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0008F710 File Offset: 0x0008D910
		public unsafe virtual int ButtonCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_ButtonCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0008F758 File Offset: 0x0008D958
		public unsafe virtual int HatCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_HatCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0008F7A0 File Offset: 0x0008D9A0
		public unsafe virtual int AccelerometerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_AccelerometerCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0008F7E8 File Offset: 0x0008D9E8
		public unsafe virtual int GyroscopeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_GyroscopeCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0008F830 File Offset: 0x0008DA30
		public unsafe virtual int TouchpadCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_TouchpadCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0008F878 File Offset: 0x0008DA78
		public unsafe virtual int LightCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_LightCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0008F8C0 File Offset: 0x0008DAC0
		public unsafe virtual int VibrationMotorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerDriver.NativeMethodInfoPtr_get_VibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0000A2ED File Offset: 0x000084ED
		public IControllerDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_get_HatCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchpadCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_get_LightCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_VibrationMotorCount_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
