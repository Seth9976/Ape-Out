using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000077 RID: 119
	public class IControllerTemplateAxis2D : Il2CppObjectBase
	{
		// Token: 0x06001021 RID: 4129 RVA: 0x0006958C File Offset: 0x0006778C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateAxis2D()
		{
			Il2CppClassPointerStore<IControllerTemplateAxis2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateAxis2D");
			IControllerTemplateAxis2D.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis2D>.NativeClassPtr, 100665982);
			IControllerTemplateAxis2D.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis2D>.NativeClassPtr, 100665983);
			IControllerTemplateAxis2D.NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis2D>.NativeClassPtr, 100665984);
			IControllerTemplateAxis2D.NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis2D>.NativeClassPtr, 100665985);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00069604 File Offset: 0x00067804
		public unsafe virtual Vector2 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis2D.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0006964C File Offset: 0x0006784C
		public unsafe virtual Vector2 valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis2D.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00069694 File Offset: 0x00067894
		public unsafe virtual IControllerTemplateAxis horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis2D.NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x000696E0 File Offset: 0x000678E0
		public unsafe virtual IControllerTemplateAxis vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis2D.NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0000746F File Offset: 0x0000566F
		public IControllerTemplateAxis2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
