using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000023 RID: 35
	public class ILayoutIgnorer : Il2CppObjectBase
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x000037EC File Offset: 0x000019EC
		// Note: this type is marked as 'beforefieldinit'.
		static ILayoutIgnorer()
		{
			Il2CppClassPointerStore<ILayoutIgnorer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ILayoutIgnorer");
			ILayoutIgnorer.NativeMethodInfoPtr_get_ignoreLayout_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutIgnorer>.NativeClassPtr, 100663984);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00017310 File Offset: 0x00015510
		public unsafe virtual bool ignoreLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutIgnorer.NativeMethodInfoPtr_get_ignoreLayout_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000381B File Offset: 0x00001A1B
		public ILayoutIgnorer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreLayout_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
