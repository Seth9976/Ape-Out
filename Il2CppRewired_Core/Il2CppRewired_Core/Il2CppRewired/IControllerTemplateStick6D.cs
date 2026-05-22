using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000080 RID: 128
	public class IControllerTemplateStick6D : Il2CppObjectBase
	{
		// Token: 0x06001069 RID: 4201 RVA: 0x0006AAE4 File Offset: 0x00068CE4
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateStick6D()
		{
			Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateStick6D");
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666036);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionPrev_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666037);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666038);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationPrev_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666039);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666040);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666041);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666042);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666043);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666044);
			IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateStick6D>.NativeClassPtr, 100666045);
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0006ABD4 File Offset: 0x00068DD4
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0006AC1C File Offset: 0x00068E1C
		public unsafe virtual Vector3 positionPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionPrev_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0006AC64 File Offset: 0x00068E64
		public unsafe virtual Vector3 rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0006ACAC File Offset: 0x00068EAC
		public unsafe virtual Vector3 rotationPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationPrev_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0006ACF4 File Offset: 0x00068EF4
		public unsafe virtual IControllerTemplateAxis positionX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0006AD40 File Offset: 0x00068F40
		public unsafe virtual IControllerTemplateAxis positionY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0006AD8C File Offset: 0x00068F8C
		public unsafe virtual IControllerTemplateAxis positionZ
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_positionZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0006ADD8 File Offset: 0x00068FD8
		public unsafe virtual IControllerTemplateAxis rotationX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0006AE24 File Offset: 0x00069024
		public unsafe virtual IControllerTemplateAxis rotationY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0006AE70 File Offset: 0x00069070
		public unsafe virtual IControllerTemplateAxis rotationZ
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateStick6D.NativeMethodInfoPtr_get_rotationZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000074C0 File Offset: 0x000056C0
		public IControllerTemplateStick6D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_get_positionPrev_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationPrev_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_get_positionX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_get_positionY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_get_positionZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
