using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200007C RID: 124
	public class IControllerTemplateDPad : Il2CppObjectBase
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x0006A104 File Offset: 0x00068304
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateDPad()
		{
			Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateDPad");
			IControllerTemplateDPad.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666011);
			IControllerTemplateDPad.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666012);
			IControllerTemplateDPad.NativeMethodInfoPtr_get_up_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666013);
			IControllerTemplateDPad.NativeMethodInfoPtr_get_right_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666014);
			IControllerTemplateDPad.NativeMethodInfoPtr_get_down_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666015);
			IControllerTemplateDPad.NativeMethodInfoPtr_get_left_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666016);
			IControllerTemplateDPad.NativeMethodInfoPtr_get_press_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateDPad>.NativeClassPtr, 100666017);
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0006A1B8 File Offset: 0x000683B8
		public unsafe virtual Vector2 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0006A200 File Offset: 0x00068400
		public unsafe virtual Vector2 valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0006A248 File Offset: 0x00068448
		public unsafe virtual IControllerTemplateButton up
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_up_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0006A294 File Offset: 0x00068494
		public unsafe virtual IControllerTemplateButton right
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_right_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x0006A2E0 File Offset: 0x000684E0
		public unsafe virtual IControllerTemplateButton down
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_down_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0006A32C File Offset: 0x0006852C
		public unsafe virtual IControllerTemplateButton left
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_left_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0006A378 File Offset: 0x00068578
		public unsafe virtual IControllerTemplateButton press
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateDPad.NativeMethodInfoPtr_get_press_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0000749C File Offset: 0x0000569C
		public IControllerTemplateDPad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_get_press_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
	}
}
