using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200007B RID: 123
	public class IControllerTemplateThumbStick : Il2CppObjectBase
	{
		// Token: 0x06001041 RID: 4161 RVA: 0x00069F04 File Offset: 0x00068104
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateThumbStick()
		{
			Il2CppClassPointerStore<IControllerTemplateThumbStick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateThumbStick");
			IControllerTemplateThumbStick.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThumbStick>.NativeClassPtr, 100666006);
			IControllerTemplateThumbStick.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThumbStick>.NativeClassPtr, 100666007);
			IControllerTemplateThumbStick.NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThumbStick>.NativeClassPtr, 100666008);
			IControllerTemplateThumbStick.NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThumbStick>.NativeClassPtr, 100666009);
			IControllerTemplateThumbStick.NativeMethodInfoPtr_get_press_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThumbStick>.NativeClassPtr, 100666010);
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00069F90 File Offset: 0x00068190
		public unsafe virtual Vector2 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThumbStick.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00069FD8 File Offset: 0x000681D8
		public unsafe virtual Vector2 valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThumbStick.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0006A020 File Offset: 0x00068220
		public unsafe virtual IControllerTemplateAxis horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThumbStick.NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0006A06C File Offset: 0x0006826C
		public unsafe virtual IControllerTemplateAxis vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThumbStick.NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0006A0B8 File Offset: 0x000682B8
		public unsafe virtual IControllerTemplateButton press
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThumbStick.NativeMethodInfoPtr_get_press_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00007493 File Offset: 0x00005693
		public IControllerTemplateThumbStick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_get_press_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
	}
}
