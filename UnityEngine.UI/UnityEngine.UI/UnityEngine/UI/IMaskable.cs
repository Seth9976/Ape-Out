using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000016 RID: 22
	public class IMaskable : Il2CppObjectBase
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00002B45 File Offset: 0x00000D45
		// Note: this type is marked as 'beforefieldinit'.
		static IMaskable()
		{
			Il2CppClassPointerStore<IMaskable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMaskable");
			IMaskable.NativeMethodInfoPtr_RecalculateMasking_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMaskable>.NativeClassPtr, 100663613);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000E198 File Offset: 0x0000C398
		[CallerCount(0)]
		public unsafe virtual void RecalculateMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMaskable.NativeMethodInfoPtr_RecalculateMasking_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002B74 File Offset: 0x00000D74
		public IMaskable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateMasking_Public_Abstract_Virtual_New_Void_0;
	}
}
