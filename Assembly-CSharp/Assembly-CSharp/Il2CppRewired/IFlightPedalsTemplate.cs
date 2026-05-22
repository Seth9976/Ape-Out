using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x020001DB RID: 475
	public class IFlightPedalsTemplate : Il2CppObjectBase
	{
		// Token: 0x060033AE RID: 13230 RVA: 0x000C4CF4 File Offset: 0x000C2EF4
		// Note: this type is marked as 'beforefieldinit'.
		static IFlightPedalsTemplate()
		{
			Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "IFlightPedalsTemplate");
			IFlightPedalsTemplate.NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100667463);
			IFlightPedalsTemplate.NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100667464);
			IFlightPedalsTemplate.NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100667465);
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x000C4D58 File Offset: 0x000C2F58
		public unsafe virtual IControllerTemplateAxis leftPedal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x000C4DA4 File Offset: 0x000C2FA4
		public unsafe virtual IControllerTemplateAxis rightPedal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000C4DF0 File Offset: 0x000C2FF0
		public unsafe virtual IControllerTemplateAxis slide
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00022CCE File Offset: 0x00020ECE
		public IFlightPedalsTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
