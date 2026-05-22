using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.UI
{
	// Token: 0x02000047 RID: 71
	public class IVisibilityChangedHandler : Il2CppObjectBase
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00003D31 File Offset: 0x00001F31
		// Note: this type is marked as 'beforefieldinit'.
		static IVisibilityChangedHandler()
		{
			Il2CppClassPointerStore<IVisibilityChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.UI", "IVisibilityChangedHandler");
			IVisibilityChangedHandler.NativeMethodInfoPtr_OnVisibilityChanged_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisibilityChangedHandler>.NativeClassPtr, 100664259);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0004396C File Offset: 0x00041B6C
		[CallerCount(0)]
		public unsafe virtual void OnVisibilityChanged(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisibilityChangedHandler.NativeMethodInfoPtr_OnVisibilityChanged_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00003D60 File Offset: 0x00001F60
		public IVisibilityChangedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityChanged_Public_Abstract_Virtual_New_Void_Boolean_0;
	}
}
