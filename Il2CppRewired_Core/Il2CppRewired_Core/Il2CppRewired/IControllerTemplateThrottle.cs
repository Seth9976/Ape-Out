using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x0200007D RID: 125
	public class IControllerTemplateThrottle : Il2CppObjectBase
	{
		// Token: 0x06001051 RID: 4177 RVA: 0x0006A3C4 File Offset: 0x000685C4
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateThrottle()
		{
			Il2CppClassPointerStore<IControllerTemplateThrottle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateThrottle");
			IControllerTemplateThrottle.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThrottle>.NativeClassPtr, 100666018);
			IControllerTemplateThrottle.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThrottle>.NativeClassPtr, 100666019);
			IControllerTemplateThrottle.NativeMethodInfoPtr_get_throttle_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThrottle>.NativeClassPtr, 100666020);
			IControllerTemplateThrottle.NativeMethodInfoPtr_get_minDetent_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateThrottle>.NativeClassPtr, 100666021);
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0006A43C File Offset: 0x0006863C
		public unsafe virtual float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThrottle.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x0006A484 File Offset: 0x00068684
		public unsafe virtual float valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThrottle.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0006A4CC File Offset: 0x000686CC
		public unsafe virtual IControllerTemplateAxis throttle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThrottle.NativeMethodInfoPtr_get_throttle_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x0006A518 File Offset: 0x00068718
		public unsafe virtual IControllerTemplateButton minDetent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateThrottle.NativeMethodInfoPtr_get_minDetent_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x000074A5 File Offset: 0x000056A5
		public IControllerTemplateThrottle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_get_throttle_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_get_minDetent_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
	}
}
