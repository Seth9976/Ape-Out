using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x02000038 RID: 56
	public class IComponentControl : Il2CppObjectBase
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x0003E3A0 File Offset: 0x0003C5A0
		// Note: this type is marked as 'beforefieldinit'.
		static IComponentControl()
		{
			Il2CppClassPointerStore<IComponentControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "IComponentControl");
			IComponentControl.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentControl>.NativeClassPtr, 100664022);
			IComponentControl.NativeMethodInfoPtr_ClearValue_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentControl>.NativeClassPtr, 100664023);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComponentControl.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0003E42C File Offset: 0x0003C62C
		[CallerCount(0)]
		public unsafe virtual void ClearValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComponentControl.NativeMethodInfoPtr_ClearValue_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000368D File Offset: 0x0000188D
		public IComponentControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_ClearValue_Public_Abstract_Virtual_New_Void_0;
	}
}
