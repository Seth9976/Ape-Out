using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x02000188 RID: 392
	public class IPS4ControllerExtensionSourceLight : Il2CppObjectBase
	{
		// Token: 0x060028DA RID: 10458 RVA: 0x000CE6AC File Offset: 0x000CC8AC
		// Note: this type is marked as 'beforefieldinit'.
		static IPS4ControllerExtensionSourceLight()
		{
			Il2CppClassPointerStore<IPS4ControllerExtensionSourceLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "IPS4ControllerExtensionSourceLight");
			IPS4ControllerExtensionSourceLight.NativeMethodInfoPtr_SetLightColor_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceLight>.NativeClassPtr, 100673216);
			IPS4ControllerExtensionSourceLight.NativeMethodInfoPtr_ResetLight_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPS4ControllerExtensionSourceLight>.NativeClassPtr, 100673217);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000CE6FC File Offset: 0x000CC8FC
		[CallerCount(0)]
		public unsafe virtual void SetLightColor(int red, int green, int blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref red;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceLight.NativeMethodInfoPtr_SetLightColor_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000CE764 File Offset: 0x000CC964
		[CallerCount(0)]
		public unsafe virtual void ResetLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPS4ControllerExtensionSourceLight.NativeMethodInfoPtr_ResetLight_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0000FADF File Offset: 0x0000DCDF
		public IPS4ControllerExtensionSourceLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_ResetLight_Public_Abstract_Virtual_New_Void_0;
	}
}
