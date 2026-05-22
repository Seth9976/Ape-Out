using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000015 RID: 21
	public class IMask : Il2CppObjectBase
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		// Note: this type is marked as 'beforefieldinit'.
		static IMask()
		{
			Il2CppClassPointerStore<IMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMask");
			IMask.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMask>.NativeClassPtr, 100663611);
			IMask.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMask>.NativeClassPtr, 100663612);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000E104 File Offset: 0x0000C304
		[CallerCount(0)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMask.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000E14C File Offset: 0x0000C34C
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMask.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002B3C File Offset: 0x00000D3C
		public IMask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0;
	}
}
