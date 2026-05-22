using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000ED RID: 237
	public class IControllerTemplateElementIdentifier : Il2CppObjectBase
	{
		// Token: 0x06001876 RID: 6262 RVA: 0x0000A1ED File Offset: 0x000083ED
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateElementIdentifier()
		{
			Il2CppClassPointerStore<IControllerTemplateElementIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IControllerTemplateElementIdentifier");
			IControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElementIdentifier>.NativeClassPtr, 100669245);
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0008B3FC File Offset: 0x000895FC
		public unsafe virtual ControllerTemplateElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_ControllerTemplateElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0000A21C File Offset: 0x0000841C
		public IControllerTemplateElementIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_ControllerTemplateElementType_0;
	}
}
