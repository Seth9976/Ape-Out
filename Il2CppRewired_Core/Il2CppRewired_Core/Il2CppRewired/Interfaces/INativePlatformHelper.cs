using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000E6 RID: 230
	public class INativePlatformHelper : Il2CppObjectBase
	{
		// Token: 0x06001840 RID: 6208 RVA: 0x0000A17F File Offset: 0x0000837F
		// Note: this type is marked as 'beforefieldinit'.
		static INativePlatformHelper()
		{
			Il2CppClassPointerStore<INativePlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "INativePlatformHelper");
			INativePlatformHelper.NativeMethodInfoPtr_get_isApplicationFocused_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativePlatformHelper>.NativeClassPtr, 100669205);
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x0008A4D8 File Offset: 0x000886D8
		public unsafe virtual bool isApplicationFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativePlatformHelper.NativeMethodInfoPtr_get_isApplicationFocused_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0000A1AE File Offset: 0x000083AE
		public INativePlatformHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_get_isApplicationFocused_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
