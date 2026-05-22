using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000014 RID: 20
	public class IGraphicEnabledDisabled : Il2CppObjectBase
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00002B04 File Offset: 0x00000D04
		// Note: this type is marked as 'beforefieldinit'.
		static IGraphicEnabledDisabled()
		{
			Il2CppClassPointerStore<IGraphicEnabledDisabled>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IGraphicEnabledDisabled");
			IGraphicEnabledDisabled.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphicEnabledDisabled>.NativeClassPtr, 100663610);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000E078 File Offset: 0x0000C278
		[CallerCount(0)]
		public unsafe virtual void OnSiblingGraphicEnabledDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGraphicEnabledDisabled.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002B33 File Offset: 0x00000D33
		public IGraphicEnabledDisabled(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0;
	}
}
