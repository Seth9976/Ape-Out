using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000078 RID: 120
	public class IControllerTemplateAxis3D : Il2CppObjectBase
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x0006972C File Offset: 0x0006792C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateAxis3D()
		{
			Il2CppClassPointerStore<IControllerTemplateAxis3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateAxis3D");
			IControllerTemplateAxis3D.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis3D>.NativeClassPtr, 100665986);
			IControllerTemplateAxis3D.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis3D>.NativeClassPtr, 100665987);
			IControllerTemplateAxis3D.NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis3D>.NativeClassPtr, 100665988);
			IControllerTemplateAxis3D.NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis3D>.NativeClassPtr, 100665989);
			IControllerTemplateAxis3D.NativeMethodInfoPtr_get_depth_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis3D>.NativeClassPtr, 100665990);
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000697B8 File Offset: 0x000679B8
		public unsafe virtual Vector3 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis3D.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00069800 File Offset: 0x00067A00
		public unsafe virtual Vector3 valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis3D.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00069848 File Offset: 0x00067A48
		public unsafe virtual IControllerTemplateAxis horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis3D.NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00069894 File Offset: 0x00067A94
		public unsafe virtual IControllerTemplateAxis vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis3D.NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x000698E0 File Offset: 0x00067AE0
		public unsafe virtual IControllerTemplateAxis depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis3D.NativeMethodInfoPtr_get_depth_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00007478 File Offset: 0x00005678
		public IControllerTemplateAxis3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
