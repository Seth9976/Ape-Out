using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x0200018B RID: 395
	public class IPS4ControllerSetExtensionSource : Il2CppObjectBase
	{
		// Token: 0x060028E2 RID: 10466 RVA: 0x000CE7A0 File Offset: 0x000CC9A0
		// Note: this type is marked as 'beforefieldinit'.
		static IPS4ControllerSetExtensionSource()
		{
			Il2CppClassPointerStore<IPS4ControllerSetExtensionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "IPS4ControllerSetExtensionSource");
			IPS4ControllerSetExtensionSource.NativeMethodInfoPtr_get_controllerCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerSetExtensionSource>.NativeClassPtr, 100673218);
			IPS4ControllerSetExtensionSource.NativeMethodInfoPtr_GetController_Public_Abstract_Virtual_New_IPS4ControllerExtensionSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerSetExtensionSource>.NativeClassPtr, 100673219);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000CE7F0 File Offset: 0x000CC9F0
		public unsafe virtual int controllerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerSetExtensionSource.NativeMethodInfoPtr_get_controllerCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000CE838 File Offset: 0x000CCA38
		[CallerCount(0)]
		public unsafe virtual IPS4ControllerExtensionSource GetController(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerSetExtensionSource.NativeMethodInfoPtr_GetController_Public_Abstract_Virtual_New_IPS4ControllerExtensionSource_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPS4ControllerExtensionSource>(intPtr3) : null;
			}
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0000FB30 File Offset: 0x0000DD30
		public IPS4ControllerSetExtensionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_GetController_Public_Abstract_Virtual_New_IPS4ControllerExtensionSource_Int32_0;
	}
}
