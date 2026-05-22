using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200007F RID: 127
	public class IControllerTemplateYoke : Il2CppObjectBase
	{
		// Token: 0x06001063 RID: 4195 RVA: 0x0006A944 File Offset: 0x00068B44
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateYoke()
		{
			Il2CppClassPointerStore<IControllerTemplateYoke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateYoke");
			IControllerTemplateYoke.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateYoke>.NativeClassPtr, 100666032);
			IControllerTemplateYoke.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateYoke>.NativeClassPtr, 100666033);
			IControllerTemplateYoke.NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateYoke>.NativeClassPtr, 100666034);
			IControllerTemplateYoke.NativeMethodInfoPtr_get_pushPull_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateYoke>.NativeClassPtr, 100666035);
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0006A9BC File Offset: 0x00068BBC
		public unsafe virtual Vector2 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateYoke.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0006AA04 File Offset: 0x00068C04
		public unsafe virtual Vector2 valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateYoke.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0006AA4C File Offset: 0x00068C4C
		public unsafe virtual IControllerTemplateAxis rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateYoke.NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x0006AA98 File Offset: 0x00068C98
		public unsafe virtual IControllerTemplateAxis pushPull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateYoke.NativeMethodInfoPtr_get_pushPull_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000074B7 File Offset: 0x000056B7
		public IControllerTemplateYoke(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_pushPull_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
