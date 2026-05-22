using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000079 RID: 121
	public class IControllerTemplateAxis6D : Il2CppObjectBase
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x0006992C File Offset: 0x00067B2C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateAxis6D()
		{
			Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateAxis6D");
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665991);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionPrev_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665992);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665993);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationPrev_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665994);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665995);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665996);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665997);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665998);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100665999);
			IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis6D>.NativeClassPtr, 100666000);
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00069A1C File Offset: 0x00067C1C
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00069A64 File Offset: 0x00067C64
		public unsafe virtual Vector3 positionPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionPrev_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00069AAC File Offset: 0x00067CAC
		public unsafe virtual Vector3 rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00069AF4 File Offset: 0x00067CF4
		public unsafe virtual Vector3 rotationPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationPrev_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00069B3C File Offset: 0x00067D3C
		public unsafe virtual IControllerTemplateAxis positionX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00069B88 File Offset: 0x00067D88
		public unsafe virtual IControllerTemplateAxis positionY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00069BD4 File Offset: 0x00067DD4
		public unsafe virtual IControllerTemplateAxis positionZ
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_positionZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00069C20 File Offset: 0x00067E20
		public unsafe virtual IControllerTemplateAxis rotationX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00069C6C File Offset: 0x00067E6C
		public unsafe virtual IControllerTemplateAxis rotationY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00069CB8 File Offset: 0x00067EB8
		public unsafe virtual IControllerTemplateAxis rotationZ
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis6D.NativeMethodInfoPtr_get_rotationZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00007481 File Offset: 0x00005681
		public IControllerTemplateAxis6D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_get_positionPrev_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationPrev_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_get_positionX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_get_positionY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_get_positionZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationX_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationY_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationZ_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
